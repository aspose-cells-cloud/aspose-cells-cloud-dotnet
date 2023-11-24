# **deleteUnprotectWorksheet API**

Unprotects worksheet. 

```bash

DELETE http://api.aspose.cloud/v3.0//cells/{name}/worksheets/{sheetName}/protection

```

## The request parameters of **deleteUnprotectWorksheet** API are: 

| Parameter Name | Type | Path/Query String/HTTPBody | Description | 
| :- | :- | :- |:- | 
|name|String|Path|The workbook name.|
|sheetName|String|Path|The worksheet name.|
|protectParameter|Class|Body|WorksheetResponse with protection settings. Only password is used here.|
|folder|String|Query|Original workbook folder.|
|storageName|String|Query|Storage name.|


The [OpenAPI Specification](https://reference.aspose.cloud/cells/#/WorksheetsController/DeleteUnprotectWorksheet) defines a publicly accessible programming interface and lets you carry out REST interactions directly from a web browser.
