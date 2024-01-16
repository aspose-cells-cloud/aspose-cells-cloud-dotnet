# **deleteWorksheetPivotTableFilter API**

Delete a pivot filter in the PivotTable. 

```bash

DELETE http://api.aspose.cloud/v3.0//cells/{name}/worksheets/{sheetName}/pivottables/{pivotTableIndex}/PivotFilters/{fieldIndex}

```

## The request parameters of **deleteWorksheetPivotTableFilter** API are: 

| Parameter Name | Type | Path/Query String/HTTPBody | Description | 
| :- | :- | :- |:- | 
|name|String|Path|The file name.|
|sheetName|String|Path|The worksheet name.|
|pivotTableIndex|Integer|Path|Gets the PivotTable report by index.|
|fieldIndex|Integer|Path|Gets the PivotField Object at the specific index.|
|needReCalculate|Boolean|Query|Whether the specific PivotTable calculate(true/false).|
|folder|String|Query|The folder where the file is situated.|
|storageName|String|Query|The storage name where the file is situated.|


The [OpenAPI Specification](https://reference.aspose.cloud/cells/#/PivotTablesController/DeleteWorksheetPivotTableFilter) defines a publicly accessible programming interface and lets you carry out REST interactions directly from a web browser.
