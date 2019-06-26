﻿using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPivotGrid;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace DrillDownDataSourceExample
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        bool serverMode = false;
        public Form1()
        {
            InitializeComponent();
            pivotGridControl1.CellDoubleClick += PivotGridControl1_CellDoubleClick;
            // This line of code is generated by Data Source Configuration Wizard
            linqServerModeSource1.QueryableSource = new DrillDownDataSourceExample.DataClasses1DataContext().Invoices;
        }

        private void PivotGridControl1_CellDoubleClick(object sender, DevExpress.XtraPivotGrid.PivotCellEventArgs e)
        {
            PivotDrillDownDataSource drillDownDataSource;
            if (serverMode)
               drillDownDataSource = e.CreateDrillDownDataSource(25, new List<string> { "ShipName" });
            else
                drillDownDataSource = e.CreateDrillDownDataSource(25);
            Form dataform = CreateDrillDownForm(drillDownDataSource);
            dataform.ShowDialog();
            dataform.Dispose();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nWDataSet.Invoices' table. You can move, or remove it, as needed.
            this.invoicesTableAdapter.Fill(this.nWDataSet.Invoices);
            SetPivotGridDataSource();
        }

        private Form CreateDrillDownForm(PivotDrillDownDataSource dataSource) {
            Form form = new Form();
            form.Text = "Underlying Data";
            GridControl grid = new GridControl();
            grid.Parent = form;
            grid.Dock = DockStyle.Fill;
            grid.DataSource = dataSource;
            grid.DataSource =
            form.Bounds = new Rectangle(100, 100, 800, 400);
            GridView gridView1 = new GridView();
            grid.MainView = gridView1;
            gridView1.Columns["OrderDate"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            form.Text = string.Format("Underlying Data - {0} Records", dataSource.RowCount);
            return form;
        }

        private void toggleSwitch1_Toggled(object sender, EventArgs e)
        {
            serverMode = ((ToggleSwitch)sender).IsOn;
            SetPivotGridDataSource();
        }

        private void SetPivotGridDataSource()
        {
            if (serverMode)
                pivotGridControl1.DataSource = linqServerModeSource1;
            else
                pivotGridControl1.DataSource = invoicesBindingSource;
        }

        private void btnGrandTotal_Click(object sender, EventArgs e)
        {
            PivotDrillDownDataSource drillDownDataSource = pivotGridControl1.CreateDrillDownDataSource();
            Form dataform = CreateDrillDownForm(drillDownDataSource);
            dataform.ShowDialog();
            dataform.Dispose();
        }
    }
}
