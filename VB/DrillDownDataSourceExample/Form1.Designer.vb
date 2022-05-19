Namespace DrillDownDataSourceExample
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim DataSourceColumnBinding1 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim DataSourceColumnBinding2 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim DataSourceColumnBinding3 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim DataSourceColumnBinding4 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim DataSourceColumnBinding5 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Me.pivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
            Me.fieldCountry = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldCity = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldOrderDateYear = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldExtendedPrice = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldOrderDateMonth = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.invoicesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.nWDataSet = New DrillDownDataSourceExample.NWDataSet()
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
            Me.btnGrandTotal = New DevExpress.XtraEditors.SimpleButton()
            Me.toggleSwitch1 = New DevExpress.XtraEditors.ToggleSwitch()
            Me.invoicesTableAdapter = New DrillDownDataSourceExample.NWDataSetTableAdapters.InvoicesTableAdapter()
            Me.linqServerModeSource1 = New DevExpress.Data.Linq.LinqServerModeSource()
            CType(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.invoicesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nWDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            CType(Me.toggleSwitch1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.linqServerModeSource1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'pivotGridControl1
            '
            Me.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldCountry, Me.fieldCity, Me.fieldOrderDateYear, Me.fieldExtendedPrice, Me.fieldOrderDateMonth})
            Me.pivotGridControl1.Location = New System.Drawing.Point(0, 49)
            Me.pivotGridControl1.Name = "pivotGridControl1"
            Me.pivotGridControl1.OptionsData.DataProcessingEngine = DevExpress.XtraPivotGrid.PivotDataProcessingEngine.Optimized
            Me.pivotGridControl1.Size = New System.Drawing.Size(800, 401)
            Me.pivotGridControl1.TabIndex = 0
            '
            'fieldCountry
            '
            Me.fieldCountry.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.fieldCountry.AreaIndex = 0
            Me.fieldCountry.Caption = "Country"
            DataSourceColumnBinding1.ColumnName = "Country"
            Me.fieldCountry.DataBinding = DataSourceColumnBinding1
            Me.fieldCountry.Name = "fieldCountry"
            '
            'fieldCity
            '
            Me.fieldCity.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.fieldCity.AreaIndex = 1
            Me.fieldCity.Caption = "City"
            DataSourceColumnBinding2.ColumnName = "City"
            Me.fieldCity.DataBinding = DataSourceColumnBinding2
            Me.fieldCity.Name = "fieldCity"
            '
            'fieldOrderDateYear
            '
            Me.fieldOrderDateYear.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            Me.fieldOrderDateYear.AreaIndex = 0
            Me.fieldOrderDateYear.Caption = "Order Year"
            DataSourceColumnBinding3.ColumnName = "OrderDate"
            DataSourceColumnBinding3.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear
            Me.fieldOrderDateYear.DataBinding = DataSourceColumnBinding3
            Me.fieldOrderDateYear.Name = "fieldOrderDateYear"
            '
            'fieldExtendedPrice
            '
            Me.fieldExtendedPrice.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.fieldExtendedPrice.AreaIndex = 0
            Me.fieldExtendedPrice.Caption = "Extended Price"
            DataSourceColumnBinding4.ColumnName = "ExtendedPrice"
            Me.fieldExtendedPrice.DataBinding = DataSourceColumnBinding4
            Me.fieldExtendedPrice.Name = "fieldExtendedPrice"
            '
            'fieldOrderDateMonth
            '
            Me.fieldOrderDateMonth.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            Me.fieldOrderDateMonth.AreaIndex = 1
            Me.fieldOrderDateMonth.Caption = "Order Month"
            DataSourceColumnBinding5.ColumnName = "OrderDate"
            DataSourceColumnBinding5.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateMonth
            Me.fieldOrderDateMonth.DataBinding = DataSourceColumnBinding5
            Me.fieldOrderDateMonth.Name = "fieldOrderDateMonth"
            '
            'invoicesBindingSource
            '
            Me.invoicesBindingSource.DataMember = "Invoices"
            Me.invoicesBindingSource.DataSource = Me.nWDataSet
            '
            'nWDataSet
            '
            Me.nWDataSet.DataSetName = "NWDataSet"
            Me.nWDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            '
            'panelControl1
            '
            Me.panelControl1.Controls.Add(Me.btnGrandTotal)
            Me.panelControl1.Controls.Add(Me.toggleSwitch1)
            Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Top
            Me.panelControl1.Location = New System.Drawing.Point(0, 0)
            Me.panelControl1.Name = "panelControl1"
            Me.panelControl1.Size = New System.Drawing.Size(800, 49)
            Me.panelControl1.TabIndex = 1
            '
            'btnGrandTotal
            '
            Me.btnGrandTotal.Location = New System.Drawing.Point(314, 12)
            Me.btnGrandTotal.Name = "btnGrandTotal"
            Me.btnGrandTotal.Size = New System.Drawing.Size(131, 23)
            Me.btnGrandTotal.TabIndex = 2
            Me.btnGrandTotal.Text = "Get Grand Total Data"
            '
            'toggleSwitch1
            '
            Me.toggleSwitch1.Location = New System.Drawing.Point(12, 12)
            Me.toggleSwitch1.Name = "toggleSwitch1"
            Me.toggleSwitch1.Properties.OffText = "Server Mode Off"
            Me.toggleSwitch1.Properties.OnText = "Server Mode On"
            Me.toggleSwitch1.Size = New System.Drawing.Size(158, 18)
            Me.toggleSwitch1.TabIndex = 1
            '
            'invoicesTableAdapter
            '
            Me.invoicesTableAdapter.ClearBeforeFill = True
            '
            'linqServerModeSource1
            '
            Me.linqServerModeSource1.ElementType = GetType(DrillDownDataSourceExample.Invoice)
            Me.linqServerModeSource1.KeyExpression = "OrderID"
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(800, 450)
            Me.Controls.Add(Me.pivotGridControl1)
            Me.Controls.Add(Me.panelControl1)
            Me.Name = "Form1"
            Me.Text = "Drill Down Data Source Example"
            CType(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.invoicesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nWDataSet, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            CType(Me.toggleSwitch1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.linqServerModeSource1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private pivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
		Private panelControl1 As DevExpress.XtraEditors.PanelControl
		Private nWDataSet As DrillDownDataSourceExample.NWDataSet
		Private invoicesBindingSource As System.Windows.Forms.BindingSource
		Private invoicesTableAdapter As DrillDownDataSourceExample.NWDataSetTableAdapters.InvoicesTableAdapter
		Private fieldCountry As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldCity As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldOrderDateYear As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldExtendedPrice As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldOrderDateMonth As DevExpress.XtraPivotGrid.PivotGridField
		Private linqServerModeSource1 As DevExpress.Data.Linq.LinqServerModeSource
		Private WithEvents toggleSwitch1 As DevExpress.XtraEditors.ToggleSwitch
		Private WithEvents btnGrandTotal As DevExpress.XtraEditors.SimpleButton
	End Class
End Namespace

