# **putWorksheetPivotTableFilter API**

Add a pivot filter to the PivotTable. 

```bash

PUT http://api.aspose.cloud/v3.0//cells/{name}/worksheets/{sheetName}/pivottables/{pivotTableIndex}/PivotFilters

```

## The request parameters of **putWorksheetPivotTableFilter** API are: 

| Parameter Name | Type | Path/Query String/HTTPBody | Description | 
| :- | :- | :- |:- | 
|name|String|Path|The file name.|
|sheetName|String|Path|The worksheet name.|
|pivotTableIndex|Integer|Path|Gets the PivotTable report by index.|
|filter|Class|Body|PivotFilter Pivot filter description.|
|needReCalculate|Boolean|Query|Whether the specific PivotTable calculate(true/false).|
|folder|String|Query|The folder where the file is situated.|
|storageName|String|Query|The storage name where the file is situated.|


The [OpenAPI Specification](https://reference.aspose.cloud/cells/#/PivotTablesController/PutWorksheetPivotTableFilter) defines a publicly accessible programming interface and lets you carry out REST interactions directly from a web browser.
