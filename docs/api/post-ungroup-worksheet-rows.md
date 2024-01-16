# **postUngroupWorksheetRows API**

Ungroup rows in the worksheet. 

```bash

POST http://api.aspose.cloud/v3.0//cells/{name}/worksheets/{sheetName}/cells/rows/ungroup

```

## The request parameters of **postUngroupWorksheetRows** API are: 

| Parameter Name | Type | Path/Query String/HTTPBody | Description | 
| :- | :- | :- |:- | 
|name|String|Path|The file name.|
|sheetName|String|Path|The worksheet name.|
|firstIndex|Integer|Query|The first row index to be operated.|
|lastIndex|Integer|Query|The last row index to be operated.|
|isAll|Boolean|Query|Is all row to be operated|
|folder|String|Query|The folder where the file is situated.|
|storageName|String|Query|The storage name where the file is situated.|


The [OpenAPI Specification](https://reference.aspose.cloud/cells/#/CellsController/PostUngroupWorksheetRows) defines a publicly accessible programming interface and lets you carry out REST interactions directly from a web browser.
