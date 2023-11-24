# **postPivotTableCellStyle API**

Updates cell style in pivot table. 

```bash

POST http://api.aspose.cloud/v3.0//cells/{name}/worksheets/{sheetName}/pivottables/{pivotTableIndex}/Format

```

## The request parameters of **postPivotTableCellStyle** API are: 

| Parameter Name | Type | Path/Query String/HTTPBody | Description | 
| :- | :- | :- |:- | 
|name|String|Path|The workbook name.|
|sheetName|String|Path|The worksheet name.|
|pivotTableIndex|Integer|Path|Gets the PivotTable report by index.|
|column|Integer|Query|Column index of the cell.|
|row|Integer|Query|RowIndex of the cell.|
|style|Class|Body|Style description in request body.|
|needReCalculate|Boolean|Query|Whether the specific pivot table calculate(true/false).|
|folder|String|Query|Original workbook folder.|
|storageName|String|Query|Storage name.|


The [OpenAPI Specification](https://reference.aspose.cloud/cells/#/PivotTablesController/PostPivotTableCellStyle) defines a publicly accessible programming interface and lets you carry out REST interactions directly from a web browser.
