# **postWorksheetListColumn API**

Update list column properties. 

```bash

POST http://api.aspose.cloud/v3.0//cells/{name}/worksheets/{sheetName}/listobjects/{listObjectIndex}/listcolumns/{columnIndex}

```

## The request parameters of **postWorksheetListColumn** API are: 

| Parameter Name | Type | Path/Query String/HTTPBody | Description | 
| :- | :- | :- |:- | 
|name|String|Path|The workbook name.|
|sheetName|String|Path|The worksheet name.|
|listObjectIndex|Integer|Path|List object index.|
|columnIndex|Integer|Path|Represents table column index.|
|listColumn|Class|Body|Represents table column description.|
|folder|String|Query|Original workbook folder.|
|storageName|String|Query|Storage name.|


The [OpenAPI Specification](https://reference.aspose.cloud/cells/#/ListObjectsController/PostWorksheetListColumn) defines a publicly accessible programming interface and lets you carry out REST interactions directly from a web browser.
