# **postPivotTableFieldHideItem API**

Hides pivot field item in pivot table. 

```bash

POST http://api.aspose.cloud/v3.0//cells/{name}/worksheets/{sheetName}/pivottables/{pivotTableIndex}/PivotField/Hide

```

## The request parameters of **postPivotTableFieldHideItem** API are: 

| Parameter Name | Type | Path/Query String/HTTPBody | Description | 
| :- | :- | :- |:- | 
|name|String|Path|The workbook name.|
|sheetName|String|Path|The worksheet name.|
|pivotTableIndex|Integer|Path|Gets the PivotTable report by index.|
|pivotFieldType|String|Query|Represents PivotTable field type(Undefined/Row/Column/Page/Data).|
|fieldIndex|Integer|Query|Gets the PivotField Object at the specific index.|
|itemIndex|Integer|Query|The index of the pivotItem in the pivotField.|
|isHide|Boolean|Query|Whether the specific PivotItem is hidden(true/false).|
|needReCalculate|Boolean|Query|Whether the specific pivot table calculate(true/false).|
|folder|String|Query|Original workbook folder.|
|storageName|String|Query|Storage name.|


The [OpenAPI Specification](https://reference.aspose.cloud/cells/#/PivotTablesController/PostPivotTableFieldHideItem) defines a publicly accessible programming interface and lets you carry out REST interactions directly from a web browser.
