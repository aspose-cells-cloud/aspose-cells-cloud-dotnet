# **postWorksheetHyperlink API**

Update hyperlink by index in the worksheet. 

```bash

POST http://api.aspose.cloud/v3.0//cells/{name}/worksheets/{sheetName}/hyperlinks/{hyperlinkIndex}

```

## The request parameters of **postWorksheetHyperlink** API are: 

| Parameter Name | Type | Path/Query String/HTTPBody | Description | 
| :- | :- | :- |:- | 
|name|String|Path|The file name.|
|sheetName|String|Path|The worksheet name.|
|hyperlinkIndex|Integer|Path|The hyperlink's index.|
|hyperlink|Class|Body|Hyperlink object|
|folder|String|Query|The folder where the file is situated.|
|storageName|String|Query|The storage name where the file is situated.|


The [OpenAPI Specification](https://reference.aspose.cloud/cells/#/HypelinksController/PostWorksheetHyperlink) defines a publicly accessible programming interface and lets you carry out REST interactions directly from a web browser.
