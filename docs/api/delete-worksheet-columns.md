# **deleteWorksheetColumns API**

Delete worksheet columns. 

```bash

DELETE http://api.aspose.cloud/v3.0//cells/{name}/worksheets/{sheetName}/cells/columns/{columnIndex}

```

## The request parameters of **deleteWorksheetColumns** API are: 

| Parameter Name | Type | Path/Query String/HTTPBody | Description | 
| :- | :- | :- |:- | 
|name|String|Path|The workbook name.|
|sheetName|String|Path|The worksheet name.|
|columnIndex|Integer|Path|The column index.|
|columns|Integer|Query|The number of columns.|
|updateReference|Boolean|Query|Indicates if references in other worksheets will be updated.|
|folder|String|Query|Original workbook folder.|
|storageName|String|Query|Storage name.|


The [OpenAPI Specification](https://reference.aspose.cloud/cells/#/CellsController/DeleteWorksheetColumns) defines a publicly accessible programming interface and lets you carry out REST interactions directly from a web browser.
