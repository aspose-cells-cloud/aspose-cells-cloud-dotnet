# **postWorkbookSplit API**

Split the workbook with a specific format. 

```bash

POST http://api.aspose.cloud/v3.0//cells/{name}/split

```

## The request parameters of **postWorkbookSplit** API are: 

| Parameter Name | Type | Path/Query String/HTTPBody | Description | 
| :- | :- | :- |:- | 
|name|String|Path|The file name.|
|format|String|Query|Split format.|
|outFolder|String|Query||
|from|Integer|Query|Start worksheet index.|
|to|Integer|Query|End worksheet index.|
|horizontalResolution|Integer|Query|Image horizontal resolution.|
|verticalResolution|Integer|Query|Image vertical resolution.|
|splitNameRule|String|Query|rule name : sheetname  newguid |
|folder|String|Query|The folder where the file is situated.|
|storageName|String|Query|The storage name where the file is situated.|
|outStorageName|String|Query||


The [OpenAPI Specification](https://reference.aspose.cloud/cells/#/WorkbookController/PostWorkbookSplit) defines a publicly accessible programming interface and lets you carry out REST interactions directly from a web browser.
