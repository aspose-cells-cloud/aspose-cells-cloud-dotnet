# **putWorksheetShape API**

Add a shape in the worksheet. 

```bash

PUT http://api.aspose.cloud/v3.0//cells/{name}/worksheets/{sheetName}/shapes

```

## The request parameters of **putWorksheetShape** API are: 

| Parameter Name | Type | Path/Query String/HTTPBody | Description | 
| :- | :- | :- |:- | 
|name|String|Path|The file name.|
|sheetName|String|Path|The worksheet name.|
|shapeDTO|Class|Body||
|DrawingType|String|Query|Shape object type|
|upperLeftRow|Integer|Query|Upper left row index.|
|upperLeftColumn|Integer|Query|Upper left column index.|
|top|Integer|Query|Represents the vertical offset of Spinner from its left row, in unit of pixel.|
|left|Integer|Query|Represents the horizontal offset of Spinner from its left column, in unit of pixel.|
|width|Integer|Query|Represents the height of Spinner, in unit of pixel.|
|height|Integer|Query|Represents the width of Spinner, in unit of pixel.|
|folder|String|Query|The folder where the file is situated.|
|storageName|String|Query|The storage name where the file is situated.|


The [OpenAPI Specification](https://reference.aspose.cloud/cells/#/ShapesController/PutWorksheetShape) defines a publicly accessible programming interface and lets you carry out REST interactions directly from a web browser.
