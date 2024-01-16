# **postPivotTableFieldHideItem API**

Hide a pivot field item in the PivotTable. 

```bash

POST http://api.aspose.cloud/v3.0//cells/{name}/worksheets/{sheetName}/pivottables/{pivotTableIndex}/PivotField/Hide

```

## The request parameters of **postPivotTableFieldHideItem** API are: 

| Parameter Name | Type | Path/Query String/HTTPBody | Description | 
| :- | :- | :- |:- | 
|name|String|Path|The file name.|
|sheetName|String|Path|The worksheet name.|
|pivotTableIndex|Integer|Path|The PivotTable index.|
|pivotFieldType|String|Query|Represents PivotTable field type(Undefined/Row/Column/Page/Data).|
|fieldIndex|Integer|Query|The pivot field index.|
|itemIndex|Integer|Query|The index of the pivot item in the pivot field.|
|isHide|Boolean|Query|Whether the specific PivotItem is hidden(true/false).|
|needReCalculate|Boolean|Query|Whether the specific PivotTable calculate(true/false).|
|folder|String|Query|The folder where the file is situated.|
|storageName|String|Query|The storage name where the file is situated.|


The [OpenAPI Specification](https://reference.aspose.cloud/cells/#/PivotTablesController/PostPivotTableFieldHideItem) defines a publicly accessible programming interface and lets you carry out REST interactions directly from a web browser.
