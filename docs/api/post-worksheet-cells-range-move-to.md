# **postWorksheetCellsRangeMoveTo API**

Move the current range to the destination range. 

```bash

POST http://api.aspose.cloud/v3.0//cells/{name}/worksheets/{sheetName}/ranges/moveto

```

## The request parameters of **postWorksheetCellsRangeMoveTo** API are: 

| Parameter Name | Type | Path/Query String/HTTPBody | Description | 
| :- | :- | :- |:- | 
|name|String|Path|The file name.|
|sheetName|String|Path|The worksheet name.|
|range|Class|Body|range in worksheet |
|destRow|Integer|Query|The start row of the dest range.|
|destColumn|Integer|Query|The start column of the dest range.|
|folder|String|Query|Original workbook folder.|
|storageName|String|Query|Storage name.|


The [OpenAPI Specification](https://reference.aspose.cloud/cells/#/RangesController/PostWorksheetCellsRangeMoveTo) defines a publicly accessible programming interface and lets you carry out REST interactions directly from a web browser.
