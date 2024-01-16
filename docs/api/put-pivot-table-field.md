# **putPivotTableField API**

Add a pivot field in the PivotTable. 

```bash

PUT http://api.aspose.cloud/v3.0//cells/{name}/worksheets/{sheetName}/pivottables/{pivotTableIndex}/PivotField

```

## The request parameters of **putPivotTableField** API are: 

| Parameter Name | Type | Path/Query String/HTTPBody | Description | 
| :- | :- | :- |:- | 
|name|String|Path|The file name.|
|sheetName|String|Path|The worksheet name.|
|pivotTableIndex|Integer|Path|The PivotTable index.|
|pivotFieldType|String|Query|The fields area type.|
|pivotTableFieldRequest|Class|Body|PivotTableFieldRequest The PivotTable field request.|
|needReCalculate|Boolean|Query|Whether the specific PivotTable calculate(true/false).|
|folder|String|Query|The folder where the file is situated.|
|storageName|String|Query|The storage name where the file is situated.|


The [OpenAPI Specification](https://reference.aspose.cloud/cells/#/PivotTablesController/PutPivotTableField) defines a publicly accessible programming interface and lets you carry out REST interactions directly from a web browser.
