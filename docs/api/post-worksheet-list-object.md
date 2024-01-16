# **postWorksheetListObject API**

Update list object by index in the worksheet. 

```bash

POST http://api.aspose.cloud/v3.0//cells/{name}/worksheets/{sheetName}/listobjects/{listObjectIndex}

```

## The request parameters of **postWorksheetListObject** API are: 

| Parameter Name | Type | Path/Query String/HTTPBody | Description | 
| :- | :- | :- |:- | 
|name|String|Path|The file name.|
|sheetName|String|Path|The worksheet name.|
|listObjectIndex|Integer|Path|list Object index|
|listObject|Class|Body|listObject dto in request body.|
|folder|String|Query|The folder where the file is situated.|
|storageName|String|Query|The storage name where the file is situated.|


The [OpenAPI Specification](https://reference.aspose.cloud/cells/#/ListObjectsController/PostWorksheetListObject) defines a publicly accessible programming interface and lets you carry out REST interactions directly from a web browser.
