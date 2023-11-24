# **postCopyWorksheetColumns API**

Copy data to destination columns from source columns in worksheet. 

```bash

POST http://api.aspose.cloud/v3.0//cells/{name}/worksheets/{sheetName}/cells/columns/copy

```

## The request parameters of **postCopyWorksheetColumns** API are: 

| Parameter Name | Type | Path/Query String/HTTPBody | Description | 
| :- | :- | :- |:- | 
|name|String|Path|The workbook name.|
|sheetName|String|Path|The worksheet name.|
|sourceColumnIndex|Integer|Query|Source column index|
|destinationColumnIndex|Integer|Query|Destination column index|
|columnNumber|Integer|Query|The copied column number|
|worksheet|String|Query|The destination worksheet name.|
|folder|String|Query|Original workbook folder.|
|storageName|String|Query|Storage name.|


The [OpenAPI Specification](https://reference.aspose.cloud/cells/#/CellsController/PostCopyWorksheetColumns) defines a publicly accessible programming interface and lets you carry out REST interactions directly from a web browser.
