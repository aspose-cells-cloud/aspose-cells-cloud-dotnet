# **postWorksheetComment API**

Update cell comment in the worksheet. 

```bash

POST http://api.aspose.cloud/v3.0//cells/{name}/worksheets/{sheetName}/comments/{cellName}

```

## The request parameters of **postWorksheetComment** API are: 

| Parameter Name | Type | Path/Query String/HTTPBody | Description | 
| :- | :- | :- |:- | 
|name|String|Path|The file name.|
|sheetName|String|Path|The worksheet name.|
|cellName|String|Path|The cell name.|
|comment|Class|Body|Comment object.|
|folder|String|Query|The folder where the file is situated.|
|storageName|String|Query|The storage name where the file is situated.|


The [OpenAPI Specification](https://reference.aspose.cloud/cells/#/WorksheetsController/PostWorksheetComment) defines a publicly accessible programming interface and lets you carry out REST interactions directly from a web browser.
