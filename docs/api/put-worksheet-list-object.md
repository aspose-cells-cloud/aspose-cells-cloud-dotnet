# **putWorksheetListObject API**

Add a ListObject in the worksheet. 

```bash

PUT http://api.aspose.cloud/v3.0//cells/{name}/worksheets/{sheetName}/listobjects

```

## The request parameters of **putWorksheetListObject** API are: 

| Parameter Name | Type | Path/Query String/HTTPBody | Description | 
| :- | :- | :- |:- | 
|name|String|Path|The file name.|
|sheetName|String|Path|The worksheet name.|
|startRow|Integer|Query|The start row of the list range.|
|startColumn|Integer|Query|The start column of the list range.|
|endRow|Integer|Query|The start row of the list range.|
|endColumn|Integer|Query|The start column of the list range.|
|folder|String|Query|The folder where the file is situated.|
|hasHeaders|Boolean|Query|Indicate whether the range has headers.|
|displayName|String|Query|Indicate whether display name.|
|showTotals|Boolean|Query|Indicate whether show totals.|
|storageName|String|Query|The storage name where the file is situated.|


The [OpenAPI Specification](https://reference.aspose.cloud/cells/#/ListObjectsController/PutWorksheetListObject) defines a publicly accessible programming interface and lets you carry out REST interactions directly from a web browser.
