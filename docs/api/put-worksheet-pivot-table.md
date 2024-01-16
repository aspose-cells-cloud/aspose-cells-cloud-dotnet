# **putWorksheetPivotTable API**

Add a PivotTable in the worksheet. 

```bash

PUT http://api.aspose.cloud/v3.0//cells/{name}/worksheets/{sheetName}/pivottables

```

## The request parameters of **putWorksheetPivotTable** API are: 

| Parameter Name | Type | Path/Query String/HTTPBody | Description | 
| :- | :- | :- |:- | 
|name|String|Path|The file name.|
|sheetName|String|Path|The worksheet name.|
|folder|String|Query|The folder where the file is situated.|
|sourceData|String|Query|The data for the new PivotTable cache.|
|destCellName|String|Query|The cell in the upper-left corner of the destination range for the PivotTable report.|
|tableName|String|Query|The name of the new PivotTable.|
|useSameSource|Boolean|Query|Indicates whether using same data source when another existing PivotTable has used this data source. If the property is true, it will save memory.|
|storageName|String|Query|The storage name where the file is situated.|


The [OpenAPI Specification](https://reference.aspose.cloud/cells/#/PivotTablesController/PutWorksheetPivotTable) defines a publicly accessible programming interface and lets you carry out REST interactions directly from a web browser.
