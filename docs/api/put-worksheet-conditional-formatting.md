# **putWorksheetConditionalFormatting API**

Adds a condition formatting in worksheet. 

```bash

PUT http://api.aspose.cloud/v3.0//cells/{name}/worksheets/{sheetName}/conditionalFormattings

```

## The request parameters of **putWorksheetConditionalFormatting** API are: 

| Parameter Name | Type | Path/Query String/HTTPBody | Description | 
| :- | :- | :- |:- | 
|name|String|Path|The workbook name.|
|sheetName|String|Path|The worksheet name.|
|formatcondition|Class|Body||
|cellArea|String|Query|Adds a conditional formatted cell range.|
|folder|String|Query|Original workbook folder.|
|storageName|String|Query|Storage name.|


The [OpenAPI Specification](https://reference.aspose.cloud/cells/#/ConditionalFormattingsController/PutWorksheetConditionalFormatting) defines a publicly accessible programming interface and lets you carry out REST interactions directly from a web browser.
