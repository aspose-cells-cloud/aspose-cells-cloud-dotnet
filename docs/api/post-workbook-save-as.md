# **postWorkbookSaveAs API**

Converts document and saves result to storage. 

```bash

POST http://api.aspose.cloud/v3.0//cells/{name}/SaveAs

```

## The request parameters of **postWorkbookSaveAs** API are: 

| Parameter Name | Type | Path/Query String/HTTPBody | Description | 
| :- | :- | :- |:- | 
|name|String|Path|The workbook name.|
|newfilename|String|Query|The new file name.|
|saveOptions|Class|Body||
|isAutoFitRows|Boolean|Query|Indicates if Autofit rows in workbook.|
|isAutoFitColumns|Boolean|Query|Indicates if Autofit columns in workbook.|
|folder|String|Query|Original workbook folder.|
|storageName|String|Query|Storage name.|
|outStorageName|String|Query||
|checkExcelRestriction|Boolean|Query||


The [OpenAPI Specification](https://reference.aspose.cloud/cells/#/ConversionController/PostWorkbookSaveAs) defines a publicly accessible programming interface and lets you carry out REST interactions directly from a web browser.
