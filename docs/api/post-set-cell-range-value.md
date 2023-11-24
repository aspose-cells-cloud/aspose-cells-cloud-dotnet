# **postSetCellRangeValue API**

Sets the value of the range in worksheet. 

```bash

POST http://api.aspose.cloud/v3.0//cells/{name}/worksheets/{sheetName}/cells

```

## The request parameters of **postSetCellRangeValue** API are: 

| Parameter Name | Type | Path/Query String/HTTPBody | Description | 
| :- | :- | :- |:- | 
|name|String|Path|The workbook name.|
|sheetName|String|Path|The worksheet name.|
|cellarea|String|Query|Cell area (like "A1:C2")|
|value|String|Query|Range value|
|type|String|Query|Value data type (like "int")|
|folder|String|Query|Original workbook folder.|
|storageName|String|Query|Storage name.|


The [OpenAPI Specification](https://reference.aspose.cloud/cells/#/CellsController/PostSetCellRangeValue) defines a publicly accessible programming interface and lets you carry out REST interactions directly from a web browser.
