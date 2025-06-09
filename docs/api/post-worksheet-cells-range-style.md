# **postWorksheetCellsRangeStyle API**

Set the style for the specified range. 

```bash

POST http://api.aspose.cloud/v3.0//cells/{name}/worksheets/{sheetName}/ranges/style

```
Set the style for the specified range.

## The request parameters of **postWorksheetCellsRangeStyle** API are: 

| Parameter Name | Type | Path/Query String/HTTPBody | Description | 
| :- | :- | :- |:- | 
|name|String|Path|The file name.|
|sheetName|String|Path|The worksheet name.|
|rangeOperate|Class|Body|RangeSetStyleRequest Range Set Style Request |
|folder|String|Query|Original workbook folder.|
|storageName|String|Query|Storage name.|


The [OpenAPI Specification](https://reference.aspose.cloud/cells/#/RangesController/PostWorksheetCellsRangeStyle) defines a publicly accessible programming interface and lets you carry out REST interactions directly from a web browser.

<gist "aspose-cells-cloud-gists" "8a5b324fdf3e574dbd747c1a1e24b05d" "Example40_PostWorksheetCellsRangeStyle.cs">

