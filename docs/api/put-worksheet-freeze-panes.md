# **putWorksheetFreezePanes API**

Sets freeze panes in worksheet. 

```bash

PUT http://api.aspose.cloud/v3.0//cells/{name}/worksheets/{sheetName}/freezepanes

```

## The request parameters of **putWorksheetFreezePanes** API are: 

| Parameter Name | Type | Path/Query String/HTTPBody | Description | 
| :- | :- | :- |:- | 
|name|String|Path|The workbook name.|
|sheetName|String|Path|The worksheet name.|
|row|Integer|Query|Row index.|
|column|Integer|Query|Column index.|
|freezedRows|Integer|Query|Number of visible rows in top pane, no more than row index.|
|freezedColumns|Integer|Query|Number of visible columns in left pane, no more than column index.|
|folder|String|Query|Original workbook folder.|
|storageName|String|Query|Storage name.|


The [OpenAPI Specification](https://reference.aspose.cloud/cells/#/WorksheetsController/PutWorksheetFreezePanes) defines a publicly accessible programming interface and lets you carry out REST interactions directly from a web browser.
