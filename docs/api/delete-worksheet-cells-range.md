# **deleteWorksheetCellsRange API**

Delete a range of cells and shift existing cells based on the specified shift option. 

```bash

DELETE http://api.aspose.cloud/v3.0//cells/{name}/worksheets/{sheetName}/ranges

```
Delete a range of cells and shift existing cells based on the specified shift option.

## The request parameters of **deleteWorksheetCellsRange** API are: 

| Parameter Name | Type | Path/Query String/HTTPBody | Description | 
| :- | :- | :- |:- | 
|name|String|Path|The file name.|
|sheetName|String|Path|The worksheet name.|
|range|String|Query|The range object.|
|shift|String|Query|Represent the shift options when deleting a range of cells(Down/Left/None/Right/Up).|
|folder|String|Query|Original workbook folder.|
|storageName|String|Query|Storage name.|


The [OpenAPI Specification](https://reference.aspose.cloud/cells/#/RangesController/DeleteWorksheetCellsRange) defines a publicly accessible programming interface and lets you carry out REST interactions directly from a web browser.

<gist "aspose-cells-cloud-gists" "8a5b324fdf3e574dbd747c1a1e24b05d" "Example40_DeleteWorksheetCellsRange.cs">

