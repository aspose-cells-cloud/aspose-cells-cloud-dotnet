# **putWorkbookCreate API**

Creates new workbook using deferent methods. 

```bash

PUT http://api.aspose.cloud/v3.0//cells/{name}

```

## The request parameters of **putWorkbookCreate** API are: 

| Parameter Name | Type | Path/Query String/HTTPBody | Description | 
| :- | :- | :- |:- | 
|name|String|Path|The new document name.|
|templateFile|String|Query|The template file, if the data not provided default workbook is created.|
|dataFile|String|Query|Smart marker data file, if the data not provided the request content is checked for the data.|
|isWriteOver|Boolean|Query|Specifies whether to write over targer file.|
|folder|String|Query|Original workbook folder.|
|storageName|String|Query|Storage name.|
|checkExcelRestriction|Boolean|Query||


The [OpenAPI Specification](https://reference.aspose.cloud/cells/#/WorkbookController/PutWorkbookCreate) defines a publicly accessible programming interface and lets you carry out REST interactions directly from a web browser.
