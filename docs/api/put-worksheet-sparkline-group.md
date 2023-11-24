# **putWorksheetSparklineGroup API**

Put worksheet sparkline group description. 

```bash

PUT http://api.aspose.cloud/v3.0//cells/{name}/worksheets/{sheetName}/sparklineGroups

```

## The request parameters of **putWorksheetSparklineGroup** API are: 

| Parameter Name | Type | Path/Query String/HTTPBody | Description | 
| :- | :- | :- |:- | 
|name|String|Path|The workbook name.|
|sheetName|String|Path|The worksheet name.|
|type|String|Query|Represents the sparkline types(Line/Column/Stacked).|
|dataRange|String|Query|Specifies the data range of the sparkline group.|
|isVertical|Boolean|Query|Specifies whether to plot the sparklines from the data range by row or by column.|
|locationRange|String|Query|Specifies where the sparklines to be placed.|
|folder|String|Query|Original workbook folder.|
|storageName|String|Query|Storage name.|


The [OpenAPI Specification](https://reference.aspose.cloud/cells/#/SparklineGroupsController/PutWorksheetSparklineGroup) defines a publicly accessible programming interface and lets you carry out REST interactions directly from a web browser.
