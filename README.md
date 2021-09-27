# How to show tooltip for the disabled cell in WPF DataGrid (SfDataGrid)?

How to show tooltip for the disabled cell in WPF DataGrid (SfDataGrid)?

# About the sample

This sample show cases how to show tooltip for disabled cells in [WPF DataGrid](https://www.syncfusion.com/wpf-ui-controls/datagrid) (SfDataGrid). The tooltip will not be displayed for disabled cells in datagrid. You can show tooltip for disabled cells by setting ToolTipPlacement property of column.

```Xaml
<Style TargetType="syncfusion:GridCell"
        x:Key="KeyGridCellColumnCellStyle" >
    <Setter Property="IsEnabled" Value="False" />
    <Setter Property="ToolTip">
        <Setter.Value>
            <TextBlock Text="{Binding ShipCountry}" ToolTipService.IsEnabled="True" 
                                ToolTipService.ShowOnDisabled="True"/>
        </Setter.Value>
    </Setter>
    <Setter Property="ToolTipService.IsEnabled" Value="True" />
    <Setter Property="ToolTipService.ShowOnDisabled" Value="True" />
</Style>
<syncfusion:GridTextColumn HeaderText="Ship Country" MappingName="ShipCountry" 
                        CellStyle="{StaticResource KeyGridCellColumnCellStyle}"  ShowToolTip="true">
```

KB article - [How to show tooltip for the disabled cell in WPF DataGrid (SfDataGrid)?](https://www.syncfusion.com/kb/12015/how-to-show-tooltip-for-the-disabled-cell-in-wpf-datagrid-sfdatagrid)

## Requirements to run the demo
 Visual Studio 2015 and above versions
