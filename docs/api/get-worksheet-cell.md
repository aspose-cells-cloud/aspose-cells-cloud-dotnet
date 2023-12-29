# **getWorksheetCell API**

Retrieve cell data using either cell reference or method name in the worksheet. 

```bash

GET http://api.aspose.cloud/v3.0//cells/{name}/worksheets/{sheetName}/cells/{cellOrMethodName}

```

## The request parameters of **getWorksheetCell** API are: 

| Parameter Name | Type | Path/Query String/HTTPBody | Description | 
| :- | :- | :- |:- | 
|name|String|Path|The file name.|
|sheetName|String|Path|The worksheet name.|
|cellOrMethodName|String|Path|The cell's or method name. (Method name like firstcell, endcell etc.)|
|folder|String|Query|The folder where the file is situated.|
|storageName|String|Query|The storage name where the file is situated.|


The [OpenAPI Specification](https://reference.aspose.cloud/cells/#/CellsController/GetWorksheetCell) defines a publicly accessible programming interface and lets you carry out REST interactions directly from a web browser.
