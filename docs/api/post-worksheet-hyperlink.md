# **postWorksheetHyperlink API**

Updates hyperlink by index in worksheet. 

```bash

POST http://api.aspose.cloud/v3.0//cells/{name}/worksheets/{sheetName}/hyperlinks/{hyperlinkIndex}

```

## The request parameters of **postWorksheetHyperlink** API are: 

| Parameter Name | Type | Path/Query String/HTTPBody | Description | 
| :- | :- | :- |:- | 
|name|String|Path|The workbook name.|
|sheetName|String|Path|The worksheet name.|
|hyperlinkIndex|Integer|Path|The hyperlink's index.|
|hyperlink|Class|Body|Hyperlink object|
|folder|String|Query|Original workbook folder.|
|storageName|String|Query|Storage name.|


The [OpenAPI Specification](https://reference.aspose.cloud/cells/#/HypelinksController/PostWorksheetHyperlink) defines a publicly accessible programming interface and lets you carry out REST interactions directly from a web browser.
