# **putWorksheetAddChart API**

Adds new chart in worksheet. 

```bash

PUT http://api.aspose.cloud/v3.0//cells/{name}/worksheets/{sheetName}/charts

```

## The request parameters of **putWorksheetAddChart** API are: 

| Parameter Name | Type | Path/Query String/HTTPBody | Description | 
| :- | :- | :- |:- | 
|name|String|Path|The workbook name.|
|sheetName|String|Path|The worksheet name.|
|chartType|String|Query|Chart type, please refer property Type in chart resource.|
|upperLeftRow|Integer|Query|New chart upper left row.|
|upperLeftColumn|Integer|Query|New chart upperleft column.|
|lowerRightRow|Integer|Query|New chart lower right row.|
|lowerRightColumn|Integer|Query|New chart lower right column.|
|area|String|Query|Specifies values from which to plot the data series. |
|isVertical|Boolean|Query|Specifies whether to plot the series from a range of cell values by row or by column. |
|categoryData|String|Query|Gets or sets the range of category Axis values. It can be a range of cells (such as, "d1:e10"). |
|isAutoGetSerialName|Boolean|Query|Specifies whether auto update serial name. |
|title|String|Query|Specifies chart title name.|
|folder|String|Query|Original workbook folder.|
|dataLabels|Boolean|Query|Represents a specified chart's data label values display behavior. True displays the values. False to hide.|
|dataLabelsPosition|String|Query|Represents data label position(Center/InsideBase/InsideEnd/OutsideEnd/Above/Below/Left/Right/BestFit/Moved).|
|pivotTableSheet|String|Query|The source is the data of the pivotTable. If PivotSource is not empty ,the chart is PivotChart.|
|pivotTableName|String|Query|The source is the data of the pivotTable.|
|storageName|String|Query|Storage name.|


The [OpenAPI Specification](https://reference.aspose.cloud/cells/#/ChartsController/PutWorksheetAddChart) defines a publicly accessible programming interface and lets you carry out REST interactions directly from a web browser.
