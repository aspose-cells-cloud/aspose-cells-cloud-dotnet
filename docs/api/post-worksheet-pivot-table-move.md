# **postWorksheetPivotTableMove API**

Move PivotTable in the worksheet. 

```bash

POST http://api.aspose.cloud/v3.0//cells/{name}/worksheets/{sheetName}/pivottables/{pivotTableIndex}/Move

```

## The request parameters of **postWorksheetPivotTableMove** API are: 

| Parameter Name | Type | Path/Query String/HTTPBody | Description | 
| :- | :- | :- |:- | 
|name|String|Path|The file name.|
|sheetName|String|Path|The worksheet name.|
|pivotTableIndex|Integer|Path|Gets the PivotTable report by index.|
|row|Integer|Query|Row index.|
|column|Integer|Query|Column index.|
|destCellName|String|Query|The dest cell name.|
|folder|String|Query|The folder where the file is situated.|
|storageName|String|Query|The storage name where the file is situated.|


The [OpenAPI Specification](https://reference.aspose.cloud/cells/#/PivotTablesController/PostWorksheetPivotTableMove) defines a publicly accessible programming interface and lets you carry out REST interactions directly from a web browser.
