# **postGroupWorksheetRows API**

Group rows in worksheet. 

```bash

POST http://api.aspose.cloud/v3.0//cells/{name}/worksheets/{sheetName}/cells/rows/group

```

## The request parameters of **postGroupWorksheetRows** API are: 

| Parameter Name | Type | Path/Query String/HTTPBody | Description | 
| :- | :- | :- |:- | 
|name|String|Path|The workbook name.|
|sheetName|String|Path|The worksheet name.|
|firstIndex|Integer|Query|The first row index to be operated.|
|lastIndex|Integer|Query|The last row index to be operated.|
|hide|Boolean|Query|rows visible state|
|folder|String|Query|Original workbook folder.|
|storageName|String|Query|Storage name.|


The [OpenAPI Specification](https://reference.aspose.cloud/cells/#/CellsController/PostGroupWorksheetRows) defines a publicly accessible programming interface and lets you carry out REST interactions directly from a web browser.
