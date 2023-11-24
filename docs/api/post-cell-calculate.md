# **postCellCalculate API**

Calculates cell formula in worksheet. 

```bash

POST http://api.aspose.cloud/v3.0//cells/{name}/worksheets/{sheetName}/cells/{cellName}/calculate

```

## The request parameters of **postCellCalculate** API are: 

| Parameter Name | Type | Path/Query String/HTTPBody | Description | 
| :- | :- | :- |:- | 
|name|String|Path|The workbook name.|
|sheetName|String|Path|The worksheet name.|
|cellName|String|Path|The cell name.|
|options|Class|Body|Calculation Options|
|folder|String|Query|Original workbook folder.|
|storageName|String|Query|Storage name.|


The [OpenAPI Specification](https://reference.aspose.cloud/cells/#/CellsController/PostCellCalculate) defines a publicly accessible programming interface and lets you carry out REST interactions directly from a web browser.
