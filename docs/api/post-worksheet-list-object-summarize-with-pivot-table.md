# **postWorksheetListObjectSummarizeWithPivotTable API**

Create a pivot table with a list object in the worksheet. 

```bash

POST http://api.aspose.cloud/v3.0//cells/{name}/worksheets/{sheetName}/listobjects/{listObjectIndex}/SummarizeWithPivotTable

```

## The request parameters of **postWorksheetListObjectSummarizeWithPivotTable** API are: 

| Parameter Name | Type | Path/Query String/HTTPBody | Description | 
| :- | :- | :- |:- | 
|name|String|Path|The file name.|
|sheetName|String|Path|The worksheet name.|
|listObjectIndex|Integer|Path|The list object index.|
|destsheetName|String|Query|The target worksheet name.|
|createPivotTableRequest|Class|Body|Create pivot table request.|
|folder|String|Query|The folder where the file is situated.|
|storageName|String|Query|The storage name where the file is situated.|


The [OpenAPI Specification](https://reference.aspose.cloud/cells/#/ListObjectsController/PostWorksheetListObjectSummarizeWithPivotTable) defines a publicly accessible programming interface and lets you carry out REST interactions directly from a web browser.
