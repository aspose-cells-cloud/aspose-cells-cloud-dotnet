# **postMoveWorksheet API**

Move worksheet in workbook. 

```bash

POST http://api.aspose.cloud/v3.0//cells/{name}/worksheets/{sheetName}/position

```

## The request parameters of **postMoveWorksheet** API are: 

| Parameter Name | Type | Path/Query String/HTTPBody | Description | 
| :- | :- | :- |:- | 
|name|String|Path|The workbook name.|
|sheetName|String|Path|The worksheet name.|
|moving|Class|Body|WorksheetMovingRequest with moving parameters.|
|folder|String|Query|Original workbook folder.|
|storageName|String|Query|Storage name.|


The [OpenAPI Specification](https://reference.aspose.cloud/cells/#/WorksheetsController/PostMoveWorksheet) defines a publicly accessible programming interface and lets you carry out REST interactions directly from a web browser.
