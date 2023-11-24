# **postWorkbookImportJson API**

Imports/Updates an XML data file into the workbook.The XML data file can be a cloud file or HTTP URI data. 

```bash

POST http://api.aspose.cloud/v3.0//cells/{name}/importjson

```

## The request parameters of **postWorkbookImportJson** API are: 

| Parameter Name | Type | Path/Query String/HTTPBody | Description | 
| :- | :- | :- |:- | 
|name|String|Path|The workbook(Excel/ODS/...) name.|
|importJsonRequest|Class|Body||
|password|String|Query|password|
|folder|String|Query|Original workbook folder.|
|storageName|String|Query|Storage name.|
|outPath|String|Query|Output file path.|
|outStorageName|String|Query|Storage name for output file.|
|checkExcelRestriction|Boolean|Query|check Excel restriction.|


The [OpenAPI Specification](https://reference.aspose.cloud/cells/#/DataProcessingController/PostWorkbookImportJson) defines a publicly accessible programming interface and lets you carry out REST interactions directly from a web browser.
