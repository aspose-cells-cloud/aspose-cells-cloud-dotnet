# **putWorksheetPivotTable API**

Adds a pivot table in worksheet. 

```bash

PUT http://api.aspose.cloud/v3.0//cells/{name}/worksheets/{sheetName}/pivottables

```

## The request parameters of **putWorksheetPivotTable** API are: 

| Parameter Name | Type | Path/Query String/HTTPBody | Description | 
| :- | :- | :- |:- | 
|name|String|Path|The workbook name.|
|sheetName|String|Path|The worksheet name.|
|folder|String|Query|Original workbook folder.|
|sourceData|String|Query|The data for the new PivotTable cache.|
|destCellName|String|Query|The cell in the upper-left corner of the PivotTable report's destination range.|
|tableName|String|Query|The name of the new PivotTable report.|
|useSameSource|Boolean|Query|Indicates whether using same data source when another existing pivot table has used this data source. If the property is true, it will save memory.|
|storageName|String|Query|Storage name.|


The [OpenAPI Specification](https://reference.aspose.cloud/cells/#/PivotTablesController/PutWorksheetPivotTable) defines a publicly accessible programming interface and lets you carry out REST interactions directly from a web browser.
