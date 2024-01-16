# **postUpdateWorksheetZoom API**

Update the scaling percentage in the worksheet. It should be between 10 and 400. 

```bash

POST http://api.aspose.cloud/v3.0//cells/{name}/worksheets/{sheetName}/zoom

```

## The request parameters of **postUpdateWorksheetZoom** API are: 

| Parameter Name | Type | Path/Query String/HTTPBody | Description | 
| :- | :- | :- |:- | 
|name|String|Path|The file name.|
|sheetName|String|Path|The worksheet name.|
|value|Integer|Query|Represents the scaling factor in percentage. It should be between 10 and 400.|
|folder|String|Query|The folder where the file is situated.|
|storageName|String|Query|The storage name where the file is situated.|


The [OpenAPI Specification](https://reference.aspose.cloud/cells/#/WorksheetsController/PostUpdateWorksheetZoom) defines a publicly accessible programming interface and lets you carry out REST interactions directly from a web browser.
