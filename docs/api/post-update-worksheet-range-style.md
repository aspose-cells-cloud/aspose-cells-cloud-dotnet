# **postUpdateWorksheetRangeStyle API**

Updates cell's range style in worksheet. 

```bash

POST http://api.aspose.cloud/v3.0//cells/{name}/worksheets/{sheetName}/cells/style

```

## The request parameters of **postUpdateWorksheetRangeStyle** API are: 

| Parameter Name | Type | Path/Query String/HTTPBody | Description | 
| :- | :- | :- |:- | 
|name|String|Path|The workbook name.|
|sheetName|String|Path|The worksheet name.|
|range|String|Query|Represents the range to which the specified cells applies.|
|style|Class|Body|Style with update style settings.|
|folder|String|Query|Original workbook folder.|
|storageName|String|Query|Storage name.|


The [OpenAPI Specification](https://reference.aspose.cloud/cells/#/CellsController/PostUpdateWorksheetRangeStyle) defines a publicly accessible programming interface and lets you carry out REST interactions directly from a web browser.
