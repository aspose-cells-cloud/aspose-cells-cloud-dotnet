# **postPivotTableUpdatePivotField API**

 

```bash

POST http://api.aspose.cloud/v3.0//cells/{name}/worksheets/{sheetName}/pivottables/{pivotTableIndex}/PivotFields/{pivotFieldIndex}

```

## The request parameters of **postPivotTableUpdatePivotField** API are: 

| Parameter Name | Type | Path/Query String/HTTPBody | Description | 
| :- | :- | :- |:- | 
|name|String|Path|The workbook name.|
|sheetName|String|Path|The worksheet name.|
|pivotTableIndex|Integer|Path|Gets the PivotTable report by index.|
|pivotFieldIndex|Integer|Path|Gets the PivotField Object at the specific index.|
|pivotFieldType|String|Query|Represents PivotTable field type(Undefined/Row/Column/Page/Data).|
|pivotField|Class|Body|Represents pivot field.|
|needReCalculate|Boolean|Query|Whether the specific pivot table calculate(true/false).|
|folder|String|Query|Original workbook folder.|
|storageName|String|Query|Storage name.|


The [OpenAPI Specification](https://reference.aspose.cloud/cells/#/PivotTablesController/PostPivotTableUpdatePivotField) defines a publicly accessible programming interface and lets you carry out REST interactions directly from a web browser.
