# **postWorksheetComment API**

Updates cell comment in worksheet. 

```bash

POST http://api.aspose.cloud/v3.0//cells/{name}/worksheets/{sheetName}/comments/{cellName}

```

## The request parameters of **postWorksheetComment** API are: 

| Parameter Name | Type | Path/Query String/HTTPBody | Description | 
| :- | :- | :- |:- | 
|name|String|Path|The workbook name.|
|sheetName|String|Path|The worksheet name.|
|cellName|String|Path|The cell name.|
|comment|Class|Body|Comment object.|
|folder|String|Query|Original workbook folder.|
|storageName|String|Query|Storage name.|


The [OpenAPI Specification](https://reference.aspose.cloud/cells/#/WorksheetsController/PostWorksheetComment) defines a publicly accessible programming interface and lets you carry out REST interactions directly from a web browser.
