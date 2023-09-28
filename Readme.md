<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/193913517/22.1.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T828662)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
# Pivot Grid for WinForms - How to Display Underlying (Drill-Down) Records

This example demonstrates how to obtain the records from the control's underlying data source for a particular cell. Double-click a cell to invoke a form that contains a grid to show the underlying data. 

![screenshot](/images/screenshot.png)

## Files to Review

[Form1.cs](./CS/DrillDownDataSourceExample/Form1.cs) ([Form1.vb](./VB/DrillDownDataSourceExample/Form1.vb))
## Example Overview

The data in this example are contained in the Northwind database in the SQL Server data file _NW.mdf_. The application can use the [BindingSource component](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.bindingsource) or the [LinqServerModeDataSource](https://docs.devexpress.com/AspNet/DevExpress.Data.Linq.LinqServerModeDataSource) instance to retrieve the data from the database. A LinqServerModeDataSource data source is a queryable data source, and it forces the PivotGrid to operate in server mode. Use the _Server Mode_ [toggle switch control](https://docs.devexpress.com/WindowsForms/DevExpress.XtraEditors.ToggleSwitch) to switch from one data source to another.

When you double-click the PivotGrid cell, the [PivotGridControl.CellDoubleClick](https://docs.devexpress.com/WindowsForms/DevExpress.XtraPivotGrid.PivotGridControl.CellDoubleClick) event occurs. The following CreateDrillDownDataSource method overrides are called to obtain the list of records associated with the selected cell:

* If Server Mode is not enabled, the [e.CreateDrillDownDataSource(int maxRowCount)](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraPivotGrid.PivotCellEventArgsBase-3.CreateDrillDownDataSource(System.Int32)) method returns a data source that contains the columns retrieved from the original data source as well as the columns which the PivotGrid creates.
* If [Server Mode](https://docs.devexpress.com/WindowsForms/17856) is enabled, the [e.CreateDrillDownDataSource(int maxRowCount, List<string> customColumns](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraPivotGrid.PivotCellEventArgsBase-3.CreateDrillDownDataSource(System.Int32-System.Collections.Generic.List-System.String-)) method returns a data source that contains the columns shown in the PivotGridControl and the columns explicitly specified in the method parameter.

You can also click the _Get Grand Total Data_ button to call the [PivotGridControl.CreateDrillDownDataSource](https://docs.devexpress.com/WindowsForms/DevExpress.XtraPivotGrid.PivotGridControl.CreateDrillDownDataSource) method and display all data records that the PivotGridControl uses to show the summarized data.

## Documentation

[Drill Down to the Underlying Data](https://docs.devexpress.com/WindowsForms/1882/controls-and-libraries/pivot-grid/data-shaping/summarization/summaries/obtaining-underlying-data-drill-down)

## More Examples

- [Pivot Grid for WinForms - How to Create the Underlying Data Source (Drill-Down) Asynchronously](https://github.com/DevExpress-Examples/how-to-use-asynchronous-operations-that-return-the-result-e4567)
- [Pivot Grid for WPF - How to Display Underlying (Drill-Down) Records](https://github.com/DevExpress-Examples/how-to-obtain-underlying-data-e2173)






