# **postCopyWorksheetColumns API**

Copy data from source columns to destination columns in the worksheet. 

```bash

POST http://api.aspose.cloud/v3.0//cells/{name}/worksheets/{sheetName}/cells/columns/copy

```

## The request parameters of **postCopyWorksheetColumns** API are: 

| Parameter Name | Type | Path/Query String/HTTPBody | Description | 
| :- | :- | :- |:- | 
|name|String|Path|The file name.|
|sheetName|String|Path|The worksheet name.|
|sourceColumnIndex|Integer|Query|Source column index|
|destinationColumnIndex|Integer|Query|Destination column index|
|columnNumber|Integer|Query|The copied column number|
|worksheet|String|Query|The destination worksheet name.|
|folder|String|Query|The folder where the file is situated.|
|storageName|String|Query|The storage name where the file is situated.|


The [OpenAPI Specification](https://reference.aspose.cloud/cells/#/CellsController/PostCopyWorksheetColumns) defines a publicly accessible programming interface and lets you carry out REST interactions directly from a web browser.
