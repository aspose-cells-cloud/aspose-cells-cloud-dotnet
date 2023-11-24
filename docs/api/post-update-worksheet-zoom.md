# **postUpdateWorksheetZoom API**

Updates worksheet zoom. 

```bash

POST http://api.aspose.cloud/v3.0//cells/{name}/worksheets/{sheetName}/zoom

```

## The request parameters of **postUpdateWorksheetZoom** API are: 

| Parameter Name | Type | Path/Query String/HTTPBody | Description | 
| :- | :- | :- |:- | 
|name|String|Path|The workbook name.|
|sheetName|String|Path|The worksheet name.|
|value|Integer|Query|Represents the scaling factor in percentage. It should be between 10 and 400.|
|folder|String|Query|Original workbook folder.|
|storageName|String|Query|Storage name.|


The [OpenAPI Specification](https://reference.aspose.cloud/cells/#/WorksheetsController/PostUpdateWorksheetZoom) defines a publicly accessible programming interface and lets you carry out REST interactions directly from a web browser.
