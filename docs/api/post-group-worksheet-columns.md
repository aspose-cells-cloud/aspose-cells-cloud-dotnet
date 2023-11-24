# **postGroupWorksheetColumns API**

Group worksheet columns. 

```bash

POST http://api.aspose.cloud/v3.0//cells/{name}/worksheets/{sheetName}/cells/columns/group

```

## The request parameters of **postGroupWorksheetColumns** API are: 

| Parameter Name | Type | Path/Query String/HTTPBody | Description | 
| :- | :- | :- |:- | 
|name|String|Path|The workbook name.|
|sheetName|String|Path|The worksheet name.|
|firstIndex|Integer|Query|The first column index to be operated.|
|lastIndex|Integer|Query|The last column index to be operated.|
|hide|Boolean|Query|columns visible state|
|folder|String|Query|Original workbook folder.|
|storageName|String|Query|Storage name.|


The [OpenAPI Specification](https://reference.aspose.cloud/cells/#/CellsController/PostGroupWorksheetColumns) defines a publicly accessible programming interface and lets you carry out REST interactions directly from a web browser.
