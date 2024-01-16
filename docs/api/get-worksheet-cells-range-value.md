# **getWorksheetCellsRangeValue API**

Retrieve the values of cells within the specified range. 

```bash

GET http://api.aspose.cloud/v3.0//cells/{name}/worksheets/{sheetName}/ranges/value

```

## The request parameters of **getWorksheetCellsRangeValue** API are: 

| Parameter Name | Type | Path/Query String/HTTPBody | Description | 
| :- | :- | :- |:- | 
|name|String|Path|The file name.|
|sheetName|String|Path|The worksheet name.|
|namerange|String|Query|The range name.|
|firstRow|Integer|Query|Gets the index of the first row of the range.|
|firstColumn|Integer|Query|Gets the index of the first columnn of the range.|
|rowCount|Integer|Query|Gets the count of rows in the range.|
|columnCount|Integer|Query|Gets the count of columns in the range.|
|folder|String|Query|Original workbook folder.|
|storageName|String|Query|Storage name.|


The [OpenAPI Specification](https://reference.aspose.cloud/cells/#/RangesController/GetWorksheetCellsRangeValue) defines a publicly accessible programming interface and lets you carry out REST interactions directly from a web browser.
