# **postWorksheetTextReplace API**

Replace old text with new text in the worksheet. 

```bash

POST http://api.aspose.cloud/v3.0//cells/{name}/worksheets/{sheetName}/replaceText

```

## The request parameters of **postWorksheetTextReplace** API are: 

| Parameter Name | Type | Path/Query String/HTTPBody | Description | 
| :- | :- | :- |:- | 
|name|String|Path|The file name.|
|sheetName|String|Path|Worksheet name.|
|oldValue|String|Query|The old text to replace.|
|newValue|String|Query|The new text to replace by.|
|folder|String|Query|The folder where the file is situated.|
|storageName|String|Query|The storage name where the file is situated.|


The [OpenAPI Specification](https://reference.aspose.cloud/cells/#/WorksheetsController/PostWorksheetTextReplace) defines a publicly accessible programming interface and lets you carry out REST interactions directly from a web browser.
