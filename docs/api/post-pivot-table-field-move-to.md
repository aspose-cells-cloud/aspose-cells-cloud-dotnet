# **postPivotTableFieldMoveTo API**

Moves pivot field in pivot table. 

```bash

POST http://api.aspose.cloud/v3.0//cells/{name}/worksheets/{sheetName}/pivottables/{pivotTableIndex}/PivotField/Move

```

## The request parameters of **postPivotTableFieldMoveTo** API are: 

| Parameter Name | Type | Path/Query String/HTTPBody | Description | 
| :- | :- | :- |:- | 
|name|String|Path|The workbook name.|
|sheetName|String|Path|The worksheet name.|
|pivotTableIndex|Integer|Path|Gets the PivotTable report by index.|
|fieldIndex|Integer|Query|Gets the PivotField Object at the specific index.|
|from|String|Query|The fields area type(Column/Row/Page/Data/Undefined).|
|to|String|Query|The fields area type(Column/Row/Page/Data/Undefined).|
|folder|String|Query|Original workbook folder.|
|storageName|String|Query|Storage name.|


The [OpenAPI Specification](https://reference.aspose.cloud/cells/#/PivotTablesController/PostPivotTableFieldMoveTo) defines a publicly accessible programming interface and lets you carry out REST interactions directly from a web browser.
