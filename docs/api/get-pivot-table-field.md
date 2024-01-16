# **getPivotTableField API**

Retrieve descriptions of pivot fields in the PivotTable. 

```bash

GET http://api.aspose.cloud/v3.0//cells/{name}/worksheets/{sheetName}/pivottables/{pivotTableIndex}/PivotField

```

## The request parameters of **getPivotTableField** API are: 

| Parameter Name | Type | Path/Query String/HTTPBody | Description | 
| :- | :- | :- |:- | 
|name|String|Path|The file name.|
|sheetName|String|Path|The worksheet name.|
|pivotTableIndex|Integer|Path|The PivotTable index.|
|pivotFieldIndex|Integer|Query|The pivot field index of PivotTable.|
|pivotFieldType|String|Query|The field area type(column/row).|
|folder|String|Query|The folder where the file is situated.|
|storageName|String|Query|The storage name where the file is situated.|


The [OpenAPI Specification](https://reference.aspose.cloud/cells/#/PivotTablesController/GetPivotTableField) defines a publicly accessible programming interface and lets you carry out REST interactions directly from a web browser.
