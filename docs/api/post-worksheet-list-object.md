# **postWorksheetListObject API**

Updates list object in worksheet. 

```bash

POST http://api.aspose.cloud/v3.0//cells/{name}/worksheets/{sheetName}/listobjects/{listObjectIndex}

```

## The request parameters of **postWorksheetListObject** API are: 

| Parameter Name | Type | Path/Query String/HTTPBody | Description | 
| :- | :- | :- |:- | 
|name|String|Path|The workbook name.|
|sheetName|String|Path|The worksheet name.|
|listObjectIndex|Integer|Path|list Object index|
|listObject|Class|Body|listObject dto in request body.|
|folder|String|Query|Original workbook folder.|
|storageName|String|Query|Storage name.|


The [OpenAPI Specification](https://reference.aspose.cloud/cells/#/ListObjectsController/PostWorksheetListObject) defines a publicly accessible programming interface and lets you carry out REST interactions directly from a web browser.
