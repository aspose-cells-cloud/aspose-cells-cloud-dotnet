# **postWorkbookExportXML API**

Export XML data from Excel file. When there are Xml Maps in Excel file, export xml data. When there is not xml map in Excel file, convert Excel file to xml file.  

```bash

POST http://api.aspose.cloud/v3.0//cells/{name}/exportxml

```

## The request parameters of **postWorkbookExportXML** API are: 

| Parameter Name | Type | Path/Query String/HTTPBody | Description | 
| :- | :- | :- |:- | 
|name|String|Path|The workbook(Excel/ODS/...) name.|
|password|String|Query|password|
|folder|String|Query|Original workbook folder.|
|storageName|String|Query|Storage name.|
|outPath|String|Query|Output file path.|
|outStorageName|String|Query|Storage name for output file.|
|checkExcelRestriction|Boolean|Query|check excel restriction.|


The [OpenAPI Specification](https://reference.aspose.cloud/cells/#/DataProcessingController/PostWorkbookExportXML) defines a publicly accessible programming interface and lets you carry out REST interactions directly from a web browser.
