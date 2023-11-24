# **putWorksheetListObject API**

Adds a list object in worksheet. 

```bash

PUT http://api.aspose.cloud/v3.0//cells/{name}/worksheets/{sheetName}/listobjects

```

## The request parameters of **putWorksheetListObject** API are: 

| Parameter Name | Type | Path/Query String/HTTPBody | Description | 
| :- | :- | :- |:- | 
|name|String|Path|The workbook name.|
|sheetName|String|Path|The worksheet name.|
|startRow|Integer|Query|The start row of the list range.|
|startColumn|Integer|Query|The start row of the list range.|
|endRow|Integer|Query|The start row of the list range.|
|endColumn|Integer|Query|The start row of the list range.|
|folder|String|Query|Original workbook folder.|
|hasHeaders|Boolean|Query|Whether the range has headers.|
|displayName|String|Query||
|showTotals|Boolean|Query||
|storageName|String|Query|Storage name.|


The [OpenAPI Specification](https://reference.aspose.cloud/cells/#/ListObjectsController/PutWorksheetListObject) defines a publicly accessible programming interface and lets you carry out REST interactions directly from a web browser.
