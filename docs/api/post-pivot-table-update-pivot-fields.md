# **postPivotTableUpdatePivotFields API**

Update pivot fields in the PivotTable. 

```bash

POST http://api.aspose.cloud/v3.0//cells/{name}/worksheets/{sheetName}/pivottables/{pivotTableIndex}/PivotFields

```

## The request parameters of **postPivotTableUpdatePivotFields** API are: 

| Parameter Name | Type | Path/Query String/HTTPBody | Description | 
| :- | :- | :- |:- | 
|name|String|Path|The file name.|
|sheetName|String|Path|The worksheet name.|
|pivotTableIndex|Integer|Path|The PivotTable index.|
|pivotFieldType|String|Query|Represents PivotTable field type(Undefined/Row/Column/Page/Data).|
|pivotField|Class|Body|PivotFieldRepresents pivot field.|
|needReCalculate|Boolean|Query|Whether the specific PivotTable calculate(true/false).|
|folder|String|Query|The folder where the file is situated.|
|storageName|String|Query|The storage name where the file is situated.|


The [OpenAPI Specification](https://reference.aspose.cloud/cells/#/PivotTablesController/PostPivotTableUpdatePivotFields) defines a publicly accessible programming interface and lets you carry out REST interactions directly from a web browser.
