# **postPivotTableCellStyle API**

Update cell style in the PivotTable. 

```bash

POST http://api.aspose.cloud/v3.0//cells/{name}/worksheets/{sheetName}/pivottables/{pivotTableIndex}/Format

```

## The request parameters of **postPivotTableCellStyle** API are: 

| Parameter Name | Type | Path/Query String/HTTPBody | Description | 
| :- | :- | :- |:- | 
|name|String|Path|The file name.|
|sheetName|String|Path|The worksheet name.|
|pivotTableIndex|Integer|Path|The PivotTable index.|
|column|Integer|Query|The column index of the cell.|
|row|Integer|Query|The row index of the cell.|
|style|Class|Body|Style Style description in request body.|
|needReCalculate|Boolean|Query|Whether the specific PivotTable calculate(true/false).|
|folder|String|Query|The folder where the file is situated.|
|storageName|String|Query|The storage name where the file is situated.|


The [OpenAPI Specification](https://reference.aspose.cloud/cells/#/PivotTablesController/PostPivotTableCellStyle) defines a publicly accessible programming interface and lets you carry out REST interactions directly from a web browser.
