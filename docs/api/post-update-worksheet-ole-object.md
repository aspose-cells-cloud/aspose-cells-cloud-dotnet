# **postUpdateWorksheetOleObject API**

Update an OLE object in worksheet. 

```bash

POST http://api.aspose.cloud/v3.0//cells/{name}/worksheets/{sheetName}/oleobjects/{oleObjectIndex}

```

## The request parameters of **postUpdateWorksheetOleObject** API are: 

| Parameter Name | Type | Path/Query String/HTTPBody | Description | 
| :- | :- | :- |:- | 
|name|String|Path|The file name.|
|sheetName|String|Path|The worsheet name.|
|oleObjectIndex|Integer|Path|Ole object index.|
|ole|Class|Body|Ole Object description.|
|folder|String|Query|The folder where the file is situated.|
|storageName|String|Query|The storage name where the file is situated.|


The [OpenAPI Specification](https://reference.aspose.cloud/cells/#/OleObjectsController/PostUpdateWorksheetOleObject) defines a publicly accessible programming interface and lets you carry out REST interactions directly from a web browser.
