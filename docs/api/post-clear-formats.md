# **postClearFormats API**

Clear cell formats in the worksheet. 

```bash

POST http://api.aspose.cloud/v3.0//cells/{name}/worksheets/{sheetName}/cells/clearformats

```

## The request parameters of **postClearFormats** API are: 

| Parameter Name | Type | Path/Query String/HTTPBody | Description | 
| :- | :- | :- |:- | 
|name|String|Path|The file name.|
|sheetName|String|Path|The worksheet name.|
|range|String|Query|Represents the range to which the specified cells applies.|
|startRow|Integer|Query|The start row index.|
|startColumn|Integer|Query|The start column index.|
|endRow|Integer|Query|The end row index.|
|endColumn|Integer|Query|The end column index.|
|folder|String|Query|The folder where the file is situated.|
|storageName|String|Query|The storage name where the file is situated.|


The [OpenAPI Specification](https://reference.aspose.cloud/cells/#/CellsController/PostClearFormats) defines a publicly accessible programming interface and lets you carry out REST interactions directly from a web browser.
