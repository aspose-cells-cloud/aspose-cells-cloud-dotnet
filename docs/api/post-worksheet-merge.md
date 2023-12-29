# **postWorksheetMerge API**

Merge cells in the worksheet. 

```bash

POST http://api.aspose.cloud/v3.0//cells/{name}/worksheets/{sheetName}/cells/merge

```

## The request parameters of **postWorksheetMerge** API are: 

| Parameter Name | Type | Path/Query String/HTTPBody | Description | 
| :- | :- | :- |:- | 
|name|String|Path|The file name.|
|sheetName|String|Path|The worksheet name.|
|startRow|Integer|Query|The start row index.|
|startColumn|Integer|Query|The start column index.|
|totalRows|Integer|Query|The total rows number.|
|totalColumns|Integer|Query|The total columns number.|
|folder|String|Query|The folder where the file is situated.|
|storageName|String|Query|The storage name where the file is situated.|


The [OpenAPI Specification](https://reference.aspose.cloud/cells/#/CellsController/PostWorksheetMerge) defines a publicly accessible programming interface and lets you carry out REST interactions directly from a web browser.
