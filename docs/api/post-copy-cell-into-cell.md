# **postCopyCellIntoCell API**

Copies data to destination cell from a source cell in worksheet. 

```bash

POST http://api.aspose.cloud/v3.0//cells/{name}/worksheets/{sheetName}/cells/{destCellName}/copy

```

## The request parameters of **postCopyCellIntoCell** API are: 

| Parameter Name | Type | Path/Query String/HTTPBody | Description | 
| :- | :- | :- |:- | 
|name|String|Path|The workbook name.|
|destCellName|String|Path|Destination cell name|
|sheetName|String|Path|Destination worksheet name.|
|worksheet|String|Query|Source worksheet name.|
|cellname|String|Query|Source cell name|
|row|Integer|Query|Source row|
|column|Integer|Query|Source column|
|folder|String|Query|Original workbook folder.|
|storageName|String|Query|Storage name.|


The [OpenAPI Specification](https://reference.aspose.cloud/cells/#/CellsController/PostCopyCellIntoCell) defines a publicly accessible programming interface and lets you carry out REST interactions directly from a web browser.
