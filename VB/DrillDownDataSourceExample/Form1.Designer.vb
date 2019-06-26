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
			Me.pivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
			Me.invoicesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.nWDataSet = New DrillDownDataSourceExample.NWDataSet()
			Me.fieldCountry = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldCity = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldOrderDateYear = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldExtendedPrice = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldOrderDateMonth = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
			Me.invoicesTableAdapter = New DrillDownDataSourceExample.NWDataSetTableAdapters.InvoicesTableAdapter()
			Me.linqServerModeSource1 = New DevExpress.Data.Linq.LinqServerModeSource()
			Me.toggleSwitch1 = New DevExpress.XtraEditors.ToggleSwitch()
			Me.btnGrandTotal = New DevExpress.XtraEditors.SimpleButton()
			DirectCast(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.invoicesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.nWDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl1.SuspendLayout()
			DirectCast(Me.linqServerModeSource1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.toggleSwitch1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' pivotGridControl1
			' 
			Me.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.pivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() { Me.fieldCountry, Me.fieldCity, Me.fieldOrderDateYear, Me.fieldExtendedPrice, Me.fieldOrderDateMonth})
			Me.pivotGridControl1.Location = New System.Drawing.Point(0, 49)
			Me.pivotGridControl1.Name = "pivotGridControl1"
			Me.pivotGridControl1.Size = New System.Drawing.Size(800, 401)
			Me.pivotGridControl1.TabIndex = 0
			' 
			' invoicesBindingSource
			' 
			Me.invoicesBindingSource.DataMember = "Invoices"
			Me.invoicesBindingSource.DataSource = Me.nWDataSet
			' 
			' nWDataSet
			' 
			Me.nWDataSet.DataSetName = "NWDataSet"
			Me.nWDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' fieldCountry
			' 
			Me.fieldCountry.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
			Me.fieldCountry.AreaIndex = 0
			Me.fieldCountry.Caption = "Country"
			Me.fieldCountry.FieldName = "Country"
			Me.fieldCountry.Name = "fieldCountry"
			' 
			' fieldCity
			' 
			Me.fieldCity.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
			Me.fieldCity.AreaIndex = 1
			Me.fieldCity.Caption = "City"
			Me.fieldCity.FieldName = "City"
			Me.fieldCity.Name = "fieldCity"
			' 
			' fieldOrderDateYear
			' 
			Me.fieldOrderDateYear.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
			Me.fieldOrderDateYear.AreaIndex = 0
			Me.fieldOrderDateYear.Caption = "Order Year"
			Me.fieldOrderDateYear.FieldName = "OrderDate"
			Me.fieldOrderDateYear.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear
			Me.fieldOrderDateYear.Name = "fieldOrderDateYear"
			Me.fieldOrderDateYear.UnboundFieldName = "fldYear"
			' 
			' fieldExtendedPrice
			' 
			Me.fieldExtendedPrice.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
			Me.fieldExtendedPrice.AreaIndex = 0
			Me.fieldExtendedPrice.Caption = "Extended Price"
			Me.fieldExtendedPrice.FieldName = "ExtendedPrice"
			Me.fieldExtendedPrice.Name = "fieldExtendedPrice"
			' 
			' fieldOrderDateMonth
			' 
			Me.fieldOrderDateMonth.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
			Me.fieldOrderDateMonth.AreaIndex = 1
			Me.fieldOrderDateMonth.Caption = "Order Month"
			Me.fieldOrderDateMonth.FieldName = "OrderDate"
			Me.fieldOrderDateMonth.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateMonth
			Me.fieldOrderDateMonth.Name = "fieldOrderDateMonth"
			Me.fieldOrderDateMonth.UnboundFieldName = "fldMonth"
			' 
			' panelControl1
			' 
			Me.panelControl1.Controls.Add(Me.btnGrandTotal)
			Me.panelControl1.Controls.Add(Me.toggleSwitch1)
			Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Top
			Me.panelControl1.Location = New System.Drawing.Point(0, 0)
			Me.panelControl1.Name = "panelControl1"
			Me.panelControl1.Size = New System.Drawing.Size(800, 49)
			Me.panelControl1.TabIndex = 1
			' 
			' invoicesTableAdapter
			' 
			Me.invoicesTableAdapter.ClearBeforeFill = True
			' 
			' linqServerModeSource1
			' 
			Me.linqServerModeSource1.ElementType = GetType(DrillDownDataSourceExample.Invoice)
			Me.linqServerModeSource1.KeyExpression = "OrderID"
			' 
			' toggleSwitch1
			' 
			Me.toggleSwitch1.Location = New System.Drawing.Point(12, 12)
			Me.toggleSwitch1.Name = "toggleSwitch1"
			Me.toggleSwitch1.Properties.OffText = "Server Mode Off"
			Me.toggleSwitch1.Properties.OnText = "Server Mode On"
			Me.toggleSwitch1.Size = New System.Drawing.Size(158, 24)
			Me.toggleSwitch1.TabIndex = 1
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.toggleSwitch1.Toggled += new System.EventHandler(this.toggleSwitch1_Toggled);
			' 
			' btnGrandTotal
			' 
			Me.btnGrandTotal.Location = New System.Drawing.Point(314, 12)
			Me.btnGrandTotal.Name = "btnGrandTotal"
			Me.btnGrandTotal.Size = New System.Drawing.Size(131, 23)
			Me.btnGrandTotal.TabIndex = 2
			Me.btnGrandTotal.Text = "Get Grand Total Data"
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.btnGrandTotal.Click += new System.EventHandler(this.btnGrandTotal_Click);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(800, 450)
			Me.Controls.Add(Me.pivotGridControl1)
			Me.Controls.Add(Me.panelControl1)
			Me.Name = "Form1"
			Me.Text = "Drill Down Data Source Example"
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.Load += new System.EventHandler(this.Form1_Load);
			DirectCast(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.invoicesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.nWDataSet, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl1.ResumeLayout(False)
			DirectCast(Me.linqServerModeSource1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.toggleSwitch1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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

