# **putWorksheetSparklineGroup API**

Add a sparkline group in the worksheet. 

```bash

PUT http://api.aspose.cloud/v3.0//cells/{name}/worksheets/{sheetName}/sparklineGroups

```
Add a sparkline group in the worksheet.

## The request parameters of **putWorksheetSparklineGroup** API are: 

| Parameter Name | Type | Path/Query String/HTTPBody | Description | 
| :- | :- | :- |:- | 
|name|String|Path|The file name.|
|sheetName|String|Path|The worksheet name.|
|type|String|Query|Represents the sparkline types(Line/Column/Stacked).|
|dataRange|String|Query|Specifies the data range of the sparkline group.|
|isVertical|Boolean|Query|Specifies whether to plot the sparklines from the data range by row or by column.|
|locationRange|String|Query|Specifies where the sparklines to be placed.|
|folder|String|Query|The folder where the file is situated.|
|storageName|String|Query|The storage name where the file is situated.|


The [OpenAPI Specification](https://reference.aspose.cloud/cells/#/SparklineGroupsController/PutWorksheetSparklineGroup) defines a publicly accessible programming interface and lets you carry out REST interactions directly from a web browser.

<gist "aspose-cells-cloud-gists" "8a5b324fdf3e574dbd747c1a1e24b05d" "Example40_PutWorksheetSparklineGroup.cs">

