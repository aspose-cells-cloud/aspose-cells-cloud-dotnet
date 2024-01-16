# **putWorksheetFormatConditionArea API**

Add a cell area for the format condition in the worksheet. 

```bash

PUT http://api.aspose.cloud/v3.0//cells/{name}/worksheets/{sheetName}/conditionalFormattings/{index}/area

```

## The request parameters of **putWorksheetFormatConditionArea** API are: 

| Parameter Name | Type | Path/Query String/HTTPBody | Description | 
| :- | :- | :- |:- | 
|name|String|Path|The file name.|
|sheetName|String|Path|The worksheet name.|
|index|Integer|Path|Gets the Conditional Formatting element at the specified index.|
|cellArea|String|Query|Adds a conditional formatted cell range.|
|folder|String|Query|The folder where the file is situated.|
|storageName|String|Query|The storage name where the file is situated.|


The [OpenAPI Specification](https://reference.aspose.cloud/cells/#/ConditionalFormattingsController/PutWorksheetFormatConditionArea) defines a publicly accessible programming interface and lets you carry out REST interactions directly from a web browser.
