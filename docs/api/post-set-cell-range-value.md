# **postSetCellRangeValue API**

Set the value of the range in the worksheet. 

```bash

POST http://api.aspose.cloud/v3.0//cells/{name}/worksheets/{sheetName}/cells

```

## The request parameters of **postSetCellRangeValue** API are: 

| Parameter Name | Type | Path/Query String/HTTPBody | Description | 
| :- | :- | :- |:- | 
|name|String|Path|The file name.|
|sheetName|String|Path|The worksheet name.|
|cellarea|String|Query|Cell area (like "A1:C2")|
|value|String|Query|Range value|
|type|String|Query|Value data type (like "int")|
|folder|String|Query|The folder where the file is situated.|
|storageName|String|Query|The storage name where the file is situated.|


The [OpenAPI Specification](https://reference.aspose.cloud/cells/#/CellsController/PostSetCellRangeValue) defines a publicly accessible programming interface and lets you carry out REST interactions directly from a web browser.
