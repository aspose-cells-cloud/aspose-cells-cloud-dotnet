# **postWorksheetMerge API**

Merge cells in worksheet. 

```bash

POST http://api.aspose.cloud/v3.0//cells/{name}/worksheets/{sheetName}/cells/merge

```

## The request parameters of **postWorksheetMerge** API are: 

| Parameter Name | Type | Path/Query String/HTTPBody | Description | 
| :- | :- | :- |:- | 
|name|String|Path|The workbook name.|
|sheetName|String|Path|The worksheet name.|
|startRow|Integer|Query|The start row.|
|startColumn|Integer|Query|The start column.|
|totalRows|Integer|Query|The total rows|
|totalColumns|Integer|Query|The total columns.|
|folder|String|Query|Original workbook folder.|
|storageName|String|Query|Storage name.|


The [OpenAPI Specification](https://reference.aspose.cloud/cells/#/CellsController/PostWorksheetMerge) defines a publicly accessible programming interface and lets you carry out REST interactions directly from a web browser.
