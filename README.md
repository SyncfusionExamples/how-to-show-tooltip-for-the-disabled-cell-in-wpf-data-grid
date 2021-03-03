# How to show tooltip for the disabled cell in WPF DataGrid (SfDataGrid)?

How to show tooltip for the disabled cell in WPF DataGrid (SfDataGrid)?

# About the sample

By default  [WPF DataGrid](https://www.syncfusion.com/wpf-ui-controls/datagrid) (SfDataGrid), shown ToolTip through OnMouseEnter event. But when you set IsEnabled as false to the GridCell by the framework this event can’t triggered and tooltip not shown for the disabled cells. You can show the Tooltip for disabled cells by setting the values to ToolTipPemplate of the column.

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
## Requirements to run the demo
 Visual Studio 2015 and above versions
