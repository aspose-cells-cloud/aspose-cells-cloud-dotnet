# **postWorksheetCellsRangesCopy API**

Copy content from the source range to the destination range in the worksheet. 

```bash

POST http://api.aspose.cloud/v3.0//cells/{name}/worksheets/{sheetName}/ranges/copy

```

## The request parameters of **postWorksheetCellsRangesCopy** API are: 

| Parameter Name | Type | Path/Query String/HTTPBody | Description | 
| :- | :- | :- |:- | 
|name|String|Path|The file name.|
|sheetName|String|Path|The worksheet name.|
|rangeOperate|Class|Body|RangeCopyRequestcopydata,copystyle,copyto,copyvalue|
|folder|String|Query|Original workbook folder.|
|storageName|String|Query|Storage name.|


The [OpenAPI Specification](https://reference.aspose.cloud/cells/#/RangesController/PostWorksheetCellsRangesCopy) defines a publicly accessible programming interface and lets you carry out REST interactions directly from a web browser.
