# **postPivotTableFieldMoveTo API**

Move a pivot field in the PivotTable. 

```bash

POST http://api.aspose.cloud/v3.0//cells/{name}/worksheets/{sheetName}/pivottables/{pivotTableIndex}/PivotField/Move

```

## The request parameters of **postPivotTableFieldMoveTo** API are: 

| Parameter Name | Type | Path/Query String/HTTPBody | Description | 
| :- | :- | :- |:- | 
|name|String|Path|The file name.|
|sheetName|String|Path|The worksheet name.|
|pivotTableIndex|Integer|Path|The PivotTable index.|
|fieldIndex|Integer|Query|The pivot field index.|
|from|String|Query|The fields area type(Column/Row/Page/Data/Undefined).|
|to|String|Query|The fields area type(Column/Row/Page/Data/Undefined).|
|folder|String|Query|The folder where the file is situated.|
|storageName|String|Query|The storage name where the file is situated.|


The [OpenAPI Specification](https://reference.aspose.cloud/cells/#/PivotTablesController/PostPivotTableFieldMoveTo) defines a publicly accessible programming interface and lets you carry out REST interactions directly from a web browser.
