# **postWorksheetListColumn API**

Update list column in list object. 

```bash

POST http://api.aspose.cloud/v3.0//cells/{name}/worksheets/{sheetName}/listobjects/{listObjectIndex}/listcolumns/{columnIndex}

```

## The request parameters of **postWorksheetListColumn** API are: 

| Parameter Name | Type | Path/Query String/HTTPBody | Description | 
| :- | :- | :- |:- | 
|name|String|Path|The file name.|
|sheetName|String|Path|The worksheet name.|
|listObjectIndex|Integer|Path|The list object index.|
|columnIndex|Integer|Path|Represents table column index.|
|listColumn|Class|Body|Represents table column description.|
|folder|String|Query|The folder where the file is situated.|
|storageName|String|Query|The storage name where the file is situated.|


The [OpenAPI Specification](https://reference.aspose.cloud/cells/#/ListObjectsController/PostWorksheetListColumn) defines a publicly accessible programming interface and lets you carry out REST interactions directly from a web browser.
