# **postWorksheetShape API**

Updates a shape in worksheet. 

```bash

POST http://api.aspose.cloud/v3.0//cells/{name}/worksheets/{sheetName}/shapes/{shapeindex}

```

## The request parameters of **postWorksheetShape** API are: 

| Parameter Name | Type | Path/Query String/HTTPBody | Description | 
| :- | :- | :- |:- | 
|name|String|Path|The workbook name.|
|sheetName|String|Path|The worksheet name.|
|shapeindex|Integer|Path|shape index in worksheet shapes.|
|dto|Class|Body|The shape description.|
|folder|String|Query|Original workbook folder.|
|storageName|String|Query|Storage name.|


The [OpenAPI Specification](https://reference.aspose.cloud/cells/#/ShapesController/PostWorksheetShape) defines a publicly accessible programming interface and lets you carry out REST interactions directly from a web browser.
