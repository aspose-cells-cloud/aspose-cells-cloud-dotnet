# **putWorksheetConditionalFormatting API**

Add conditional formatting in the worksheet. 

```bash

PUT http://api.aspose.cloud/v3.0//cells/{name}/worksheets/{sheetName}/conditionalFormattings

```

## The request parameters of **putWorksheetConditionalFormatting** API are: 

| Parameter Name | Type | Path/Query String/HTTPBody | Description | 
| :- | :- | :- |:- | 
|name|String|Path|The file name.|
|sheetName|String|Path|The worksheet name.|
|formatcondition|Class|Body||
|cellArea|String|Query|Adds a conditional formatted cell range.|
|folder|String|Query|The folder where the file is situated.|
|storageName|String|Query|The storage name where the file is situated.|


The [OpenAPI Specification](https://reference.aspose.cloud/cells/#/ConditionalFormattingsController/PutWorksheetConditionalFormatting) defines a publicly accessible programming interface and lets you carry out REST interactions directly from a web browser.
