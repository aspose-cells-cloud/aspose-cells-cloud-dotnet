# **postCopyCellIntoCell API**

Copy data from a source cell to a destination cell in the worksheet. 

```bash

POST http://api.aspose.cloud/v3.0//cells/{name}/worksheets/{sheetName}/cells/{destCellName}/copy

```

## The request parameters of **postCopyCellIntoCell** API are: 

| Parameter Name | Type | Path/Query String/HTTPBody | Description | 
| :- | :- | :- |:- | 
|name|String|Path|The file name.|
|destCellName|String|Path|The destination cell name.|
|sheetName|String|Path|The destination worksheet name.|
|worksheet|String|Query|The source worksheet name.|
|cellname|String|Query|The source cell name.|
|row|Integer|Query|The source row index.|
|column|Integer|Query|The source column index.|
|folder|String|Query|The folder where the file is situated.|
|storageName|String|Query|The storage name where the file is situated.|


The [OpenAPI Specification](https://reference.aspose.cloud/cells/#/CellsController/PostCopyCellIntoCell) defines a publicly accessible programming interface and lets you carry out REST interactions directly from a web browser.
