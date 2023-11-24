# **postWorkbookSplit API**

Splits workbook. 

```bash

POST http://api.aspose.cloud/v3.0//cells/{name}/split

```

## The request parameters of **postWorkbookSplit** API are: 

| Parameter Name | Type | Path/Query String/HTTPBody | Description | 
| :- | :- | :- |:- | 
|name|String|Path|The workbook name.|
|format|String|Query|Split format.|
|outFolder|String|Query||
|from|Integer|Query|Start worksheet index.|
|to|Integer|Query|End worksheet index.|
|horizontalResolution|Integer|Query|Image horizontal resolution.|
|verticalResolution|Integer|Query|Image vertical resolution.|
|splitNameRule|String|Query|rule name : sheetname  newguid |
|folder|String|Query|Original workbook folder.|
|storageName|String|Query|Storage name.|
|outStorageName|String|Query||


The [OpenAPI Specification](https://reference.aspose.cloud/cells/#/WorkbookController/PostWorkbookSplit) defines a publicly accessible programming interface and lets you carry out REST interactions directly from a web browser.
