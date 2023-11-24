# **putWorksheetAddPicture API**

Adds a new picture in worksheet. 

```bash

PUT http://api.aspose.cloud/v3.0//cells/{name}/worksheets/{sheetName}/pictures

```

## The request parameters of **putWorksheetAddPicture** API are: 

| Parameter Name | Type | Path/Query String/HTTPBody | Description | 
| :- | :- | :- |:- | 
|name|String|Path|The workbook name.|
|sheetName|String|Path|The worsheet name.|
|picture|Class|Body|Pictute object|
|upperLeftRow|Integer|Query|The image upper left row.|
|upperLeftColumn|Integer|Query|The image upper left column.|
|lowerRightRow|Integer|Query|The image low right row.|
|lowerRightColumn|Integer|Query|The image low right column.|
|picturePath|String|Query|The picture path, if not provided the picture data is inspected in the request body.|
|folder|String|Query|Original workbook folder.|
|storageName|String|Query|Storage name.|


The [OpenAPI Specification](https://reference.aspose.cloud/cells/#/PicturesController/PutWorksheetAddPicture) defines a publicly accessible programming interface and lets you carry out REST interactions directly from a web browser.
