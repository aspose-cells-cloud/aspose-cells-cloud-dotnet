# **postWorksheetCellsRangeMerge API**

Merge a range of cells into a single cell. 

```bash

POST http://api.aspose.cloud/v3.0//cells/{name}/worksheets/{sheetName}/ranges/merge

```
Merge a range of cells into a single cell.

## The request parameters of **postWorksheetCellsRangeMerge** API are: 

| Parameter Name | Type | Path/Query String/HTTPBody | Description | 
| :- | :- | :- |:- | 
|name|String|Path|The file name.|
|sheetName|String|Path|The worksheet name.|
|range|Class|Body|Rangerange description.|
|folder|String|Query|Original workbook folder.|
|storageName|String|Query|Storage name.|


The [OpenAPI Specification](https://reference.aspose.cloud/cells/#/RangesController/PostWorksheetCellsRangeMerge) defines a publicly accessible programming interface and lets you carry out REST interactions directly from a web browser.

<gist "aspose-cells-cloud-gists" "8a5b324fdf3e574dbd747c1a1e24b05d" "Example40_PostWorksheetCellsRangeMerge.cs">

