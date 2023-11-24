# **postCopyWorksheet API**

Copies contents and formats from another worksheet. 

```bash

POST http://api.aspose.cloud/v3.0//cells/{name}/worksheets/{sheetName}/copy

```

## The request parameters of **postCopyWorksheet** API are: 

| Parameter Name | Type | Path/Query String/HTTPBody | Description | 
| :- | :- | :- |:- | 
|name|String|Path|The workbook name.|
|sheetName|String|Path|The worksheet name.|
|sourceSheet|String|Query|Source worksheet.|
|options|Class|Body|Represents the copy options.|
|sourceWorkbook|String|Query|source Workbook.|
|sourceFolder|String|Query|Original workbook folder.|
|folder|String|Query|Original workbook folder.|
|storageName|String|Query|Storage name.|


The [OpenAPI Specification](https://reference.aspose.cloud/cells/#/WorksheetsController/PostCopyWorksheet) defines a publicly accessible programming interface and lets you carry out REST interactions directly from a web browser.
