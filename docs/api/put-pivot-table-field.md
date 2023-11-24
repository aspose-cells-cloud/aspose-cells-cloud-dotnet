# **putPivotTableField API**

Adds a pivot field in pivot table 

```bash

PUT http://api.aspose.cloud/v3.0//cells/{name}/worksheets/{sheetName}/pivottables/{pivotTableIndex}/PivotField

```

## The request parameters of **putPivotTableField** API are: 

| Parameter Name | Type | Path/Query String/HTTPBody | Description | 
| :- | :- | :- |:- | 
|name|String|Path|The workbook name.|
|sheetName|String|Path|The worksheet name.|
|pivotTableIndex|Integer|Path|Gets the PivotTable report by index.|
|pivotFieldType|String|Query|The fields area type.|
|pivotTableFieldRequest|Class|Body|Dto that conrains field indexes|
|needReCalculate|Boolean|Query|Whether the specific pivot table calculate(true/false).|
|folder|String|Query|Original workbook folder.|
|storageName|String|Query|Storage name.|


The [OpenAPI Specification](https://reference.aspose.cloud/cells/#/PivotTablesController/PutPivotTableField) defines a publicly accessible programming interface and lets you carry out REST interactions directly from a web browser.
