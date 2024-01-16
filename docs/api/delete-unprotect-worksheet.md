# **deleteUnprotectWorksheet API**

Unprotect worksheet. 

```bash

DELETE http://api.aspose.cloud/v3.0//cells/{name}/worksheets/{sheetName}/protection

```

## The request parameters of **deleteUnprotectWorksheet** API are: 

| Parameter Name | Type | Path/Query String/HTTPBody | Description | 
| :- | :- | :- |:- | 
|name|String|Path|The file name.|
|sheetName|String|Path|The worksheet name.|
|protectParameter|Class|Body|WorksheetResponse with protection settings. Only password is used here.|
|folder|String|Query|The folder where the file is situated.|
|storageName|String|Query|The storage name where the file is situated.|


The [OpenAPI Specification](https://reference.aspose.cloud/cells/#/WorksheetsController/DeleteUnprotectWorksheet) defines a publicly accessible programming interface and lets you carry out REST interactions directly from a web browser.
