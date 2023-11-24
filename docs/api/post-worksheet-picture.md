# **postWorksheetPicture API**

Updates a picture by index in worksheet. 

```bash

POST http://api.aspose.cloud/v3.0//cells/{name}/worksheets/{sheetName}/pictures/{pictureIndex}

```

## The request parameters of **postWorksheetPicture** API are: 

| Parameter Name | Type | Path/Query String/HTTPBody | Description | 
| :- | :- | :- |:- | 
|name|String|Path|The workbook name.|
|sheetName|String|Path|The worksheet name.|
|pictureIndex|Integer|Path|The picture's index.|
|picture|Class|Body|Picture object description.|
|folder|String|Query|Original workbook folder.|
|storageName|String|Query|Storage name.|


The [OpenAPI Specification](https://reference.aspose.cloud/cells/#/PicturesController/PostWorksheetPicture) defines a publicly accessible programming interface and lets you carry out REST interactions directly from a web browser.
