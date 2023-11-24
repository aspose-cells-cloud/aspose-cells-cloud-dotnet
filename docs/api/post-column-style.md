# **postColumnStyle API**

Sets column style in worksheet. 

```bash

POST http://api.aspose.cloud/v3.0//cells/{name}/worksheets/{sheetName}/cells/columns/{columnIndex}/style

```

## The request parameters of **postColumnStyle** API are: 

| Parameter Name | Type | Path/Query String/HTTPBody | Description | 
| :- | :- | :- |:- | 
|name|String|Path|The workbook name.|
|sheetName|String|Path|The worksheet name.|
|columnIndex|Integer|Path|The column index.|
|style|Class|Body|Represents display style of excel document,such as font,color,alignment,border,etc.|
|folder|String|Query|Original workbook folder.|
|storageName|String|Query|Storage name.|


The [OpenAPI Specification](https://reference.aspose.cloud/cells/#/CellsController/PostColumnStyle) defines a publicly accessible programming interface and lets you carry out REST interactions directly from a web browser.
