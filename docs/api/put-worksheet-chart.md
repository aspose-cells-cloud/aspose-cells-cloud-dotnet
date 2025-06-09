# **putWorksheetChart API**

Add a new chart in the worksheet. 

```bash

PUT http://api.aspose.cloud/v3.0//cells/{name}/worksheets/{sheetName}/charts

```
Add a new chart in the worksheet.

## The request parameters of **putWorksheetChart** API are: 

| Parameter Name | Type | Path/Query String/HTTPBody | Description | 
| :- | :- | :- |:- | 
|name|String|Path|The file name.|
|sheetName|String|Path|The worksheet name.|
|chartType|String|Query|Chart type, please refer property Type in chart resource.|
|upperLeftRow|Integer|Query|Upper-left row for the new chart.|
|upperLeftColumn|Integer|Query|Upper-left column for the new chart.|
|lowerRightRow|Integer|Query|Lower-left row for the new chart.|
|lowerRightColumn|Integer|Query|Lower-left column for the new chart.|
|area|String|Query|Specify the values from which to plot the data series.|
|isVertical|Boolean|Query|Specify whether to plot the series from a range of cell values by row or by column. |
|categoryData|String|Query|Get or set the range of category axis values. It can be a range of cells (e.g., "D1:E10").|
|isAutoGetSerialName|Boolean|Query|Specify whether to auto-update the serial name.|
|title|String|Query|Specify the chart title name.|
|folder|String|Query|The folder where the file is situated.|
|dataLabels|Boolean|Query|Represents the specified chart's data label values display behavior. True to display the values, False to hide them.|
|dataLabelsPosition|String|Query|Represents data label position (Center/InsideBase/InsideEnd/OutsideEnd/Above/Below/Left/Right/BestFit/Moved).|
|pivotTableSheet|String|Query|The source is the data of the pivotTable. If PivotSource is not empty, the chart is a PivotChart.|
|pivotTableName|String|Query|The pivot table name.|
|storageName|String|Query|The storage name where the file is situated.|


The [OpenAPI Specification](https://reference.aspose.cloud/cells/#/ChartsController/PutWorksheetChart) defines a publicly accessible programming interface and lets you carry out REST interactions directly from a web browser.

<gist "aspose-cells-cloud-gists" "8a5b324fdf3e574dbd747c1a1e24b05d" "Example40_PutWorksheetChart.cs">

