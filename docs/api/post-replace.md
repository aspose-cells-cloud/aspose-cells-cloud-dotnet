# **postReplace API**

Replace specified text with new text in Excel files. 

```bash

POST http://api.aspose.cloud/v3.0//cells/replace

```

## The request parameters of **postReplace** API are: 

| Parameter Name | Type | Path/Query String/HTTPBody | Description | 
| :- | :- | :- |:- | 
|File|File|FormData|Find content|
|text|String|Query|Find content|
|newtext|String|Query|Replace content|
|password|String|Query|The password needed to open an Excel file.|
|sheetname|String|Query|The worksheet name. Locate the specified text content in the worksheet.|
|checkExcelRestriction|Boolean|Query|Whether check restriction of excel file when user modify cells related objects.|


The [OpenAPI Specification](https://reference.aspose.cloud/cells/#/LightCellsController/PostReplace) defines a publicly accessible programming interface and lets you carry out REST interactions directly from a web browser.
