# **postWorksheetCellsRangeColumnWidth API**

Set the column width of the specified range. 

```bash

POST http://api.aspose.cloud/v3.0//cells/{name}/worksheets/{sheetName}/ranges/columnWidth

```
Set the column width of the specified range.

## The request parameters of **postWorksheetCellsRangeColumnWidth** API are: 

| Parameter Name | Type | Path/Query String/HTTPBody | Description | 
| :- | :- | :- |:- | 
|name|String|Path|The file name.|
|sheetName|String|Path|The worksheet name.|
|range|Class|Body|Range The range object.|
|value|Floating|Query|Sets the column width of this range.|
|folder|String|Query|Original workbook folder.|
|storageName|String|Query|Storage name.|


The [OpenAPI Specification](https://reference.aspose.cloud/cells/#/RangesController/PostWorksheetCellsRangeColumnWidth) defines a publicly accessible programming interface and lets you carry out REST interactions directly from a web browser.

<gist "aspose-cells-cloud-gists" "8a5b324fdf3e574dbd747c1a1e24b05d" "Example40_PostWorksheetCellsRangeColumnWidth.cs">

