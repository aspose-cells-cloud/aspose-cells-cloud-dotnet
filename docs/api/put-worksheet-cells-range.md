# **putWorksheetCellsRange API**

Inserts a range of cells and shift cells according to the shift option.             

```bash

PUT http://api.aspose.cloud/v3.0//cells/{name}/worksheets/{sheetName}/ranges

```

## The request parameters of **putWorksheetCellsRange** API are: 

| Parameter Name | Type | Path/Query String/HTTPBody | Description | 
| :- | :- | :- |:- | 
|name|String|Path|The workbook name.|
|sheetName|String|Path|The worksheet name.|
|range|String|Query|The range object.|
|shift|String|Query|Represent the shift options when deleting a range of cells(Down/Left/None/Right/Up).|
|folder|String|Query|Original workbook folder.|
|storageName|String|Query|Storage name.|


The [OpenAPI Specification](https://reference.aspose.cloud/cells/#/RangesController/PutWorksheetCellsRange) defines a publicly accessible programming interface and lets you carry out REST interactions directly from a web browser.
