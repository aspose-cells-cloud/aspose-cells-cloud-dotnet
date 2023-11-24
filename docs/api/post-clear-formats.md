# **postClearFormats API**

Clear cells formats in worksheet. 

```bash

POST http://api.aspose.cloud/v3.0//cells/{name}/worksheets/{sheetName}/cells/clearformats

```

## The request parameters of **postClearFormats** API are: 

| Parameter Name | Type | Path/Query String/HTTPBody | Description | 
| :- | :- | :- |:- | 
|name|String|Path|The workbook name.|
|sheetName|String|Path|The worksheet name.|
|range|String|Query|Represents the range to which the specified cells applies.|
|startRow|Integer|Query|The start row.|
|startColumn|Integer|Query|The start column.|
|endRow|Integer|Query|The end row.|
|endColumn|Integer|Query|The end column.|
|folder|String|Query|Original workbook folder.|
|storageName|String|Query|Storage name.|


The [OpenAPI Specification](https://reference.aspose.cloud/cells/#/CellsController/PostClearFormats) defines a publicly accessible programming interface and lets you carry out REST interactions directly from a web browser.
