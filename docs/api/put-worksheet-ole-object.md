# **putWorksheetOleObject API**

Add an OLE object in the worksheet. 

```bash

PUT http://api.aspose.cloud/v3.0//cells/{name}/worksheets/{sheetName}/oleobjects

```

## The request parameters of **putWorksheetOleObject** API are: 

| Parameter Name | Type | Path/Query String/HTTPBody | Description | 
| :- | :- | :- |:- | 
|name|String|Path|The file name.|
|sheetName|String|Path|The worsheet name.|
|upperLeftRow|Integer|Query|Upper left row index|
|upperLeftColumn|Integer|Query|Upper left column index|
|height|Integer|Query|Height of oleObject, in unit of pixel|
|width|Integer|Query|Width of oleObject, in unit of pixel|
|oleFile|String|Query|OLE filename path(full file name).|
|imageFile|String|Query|Image filename path(full file name).|
|folder|String|Query|The folder where the file is situated.|
|storageName|String|Query|The storage name where the file is situated.|


The [OpenAPI Specification](https://reference.aspose.cloud/cells/#/OleObjectsController/PutWorksheetOleObject) defines a publicly accessible programming interface and lets you carry out REST interactions directly from a web browser.
