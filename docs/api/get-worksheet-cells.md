# **getWorksheetCells API**

Retrieve cell descriptions in a specified format. 

```bash

GET http://api.aspose.cloud/v3.0//cells/{name}/worksheets/{sheetName}/cells

```

## The request parameters of **getWorksheetCells** API are: 

| Parameter Name | Type | Path/Query String/HTTPBody | Description | 
| :- | :- | :- |:- | 
|name|String|Path|The file name.|
|sheetName|String|Path|The worksheet name.|
|offest|Integer|Query|Begginig offset.|
|count|Integer|Query|Maximum amount of cells in the response.|
|folder|String|Query|The folder where the file is situated.|
|storageName|String|Query|The storage name where the file is situated.|


The [OpenAPI Specification](https://reference.aspose.cloud/cells/#/CellsController/GetWorksheetCells) defines a publicly accessible programming interface and lets you carry out REST interactions directly from a web browser.
