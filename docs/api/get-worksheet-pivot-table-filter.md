# **getWorksheetPivotTableFilter API**

Gets pivot table filters in worksheet. 

```bash

GET http://api.aspose.cloud/v3.0//cells/{name}/worksheets/{sheetName}/pivottables/{pivotTableIndex}/PivotFilters/{filterIndex}

```

## The request parameters of **getWorksheetPivotTableFilter** API are: 

| Parameter Name | Type | Path/Query String/HTTPBody | Description | 
| :- | :- | :- |:- | 
|name|String|Path|The workbook name.|
|sheetName|String|Path|The worksheet name.|
|pivotTableIndex|Integer|Path|Gets the PivotTable report by index.|
|filterIndex|Integer|Path|Gets the pivotfilter object at the specific index.|
|folder|String|Query|Original workbook folder.|
|storageName|String|Query|Storage name.|


The [OpenAPI Specification](https://reference.aspose.cloud/cells/#/PivotTablesController/GetWorksheetPivotTableFilter) defines a publicly accessible programming interface and lets you carry out REST interactions directly from a web browser.
