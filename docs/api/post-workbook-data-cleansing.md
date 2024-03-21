# **postWorkbookDataCleansing API**

Data cleaning of spreadsheet files is a data management process used to identify, correct, and remove errors, incompleteness, duplicates, or inaccuracies in tables and ranges. 

```bash

POST http://api.aspose.cloud/v3.0//cells/{name}/datacleansing

```

## The request parameters of **postWorkbookDataCleansing** API are: 

| Parameter Name | Type | Path/Query String/HTTPBody | Description | 
| :- | :- | :- |:- | 
|name|String|Path|The file name.|
|dataCleansing|Class|Body|data cleansing content.|
|folder|String|Query|The folder where the file is situated.|
|storageName|String|Query|The storage name where the file is situated.|
|password|String|Query|The file password. |
|region|String|Query|The regional settings for workbook.|
|checkExcelRestriction|Boolean|Query||


The [OpenAPI Specification](https://reference.aspose.cloud/cells/#/DataProcessingController/PostWorkbookDataCleansing) defines a publicly accessible programming interface and lets you carry out REST interactions directly from a web browser.
