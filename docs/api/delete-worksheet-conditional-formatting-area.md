# **deleteWorksheetConditionalFormattingArea API**

Remove cell area from conditional formatting. 

```bash

DELETE http://api.aspose.cloud/v3.0//cells/{name}/worksheets/{sheetName}/conditionalFormattings/area

```

## The request parameters of **deleteWorksheetConditionalFormattingArea** API are: 

| Parameter Name | Type | Path/Query String/HTTPBody | Description | 
| :- | :- | :- |:- | 
|name|String|Path|The file name.|
|sheetName|String|Path|The worksheet name.|
|startRow|Integer|Query|The start row of the range.|
|startColumn|Integer|Query|The start column of the range.|
|totalRows|Integer|Query|The number of rows of the range.|
|totalColumns|Integer|Query|The number of columns of the range.|
|folder|String|Query|The folder where the file is situated.|
|storageName|String|Query|The storage name where the file is situated.|


The [OpenAPI Specification](https://reference.aspose.cloud/cells/#/ConditionalFormattingsController/DeleteWorksheetConditionalFormattingArea) defines a publicly accessible programming interface and lets you carry out REST interactions directly from a web browser.
