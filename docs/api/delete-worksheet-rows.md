# **deleteWorksheetRows API**

Delete several rows in the worksheet. 

```bash

DELETE http://api.aspose.cloud/v3.0//cells/{name}/worksheets/{sheetName}/cells/rows/

```

## The request parameters of **deleteWorksheetRows** API are: 

| Parameter Name | Type | Path/Query String/HTTPBody | Description | 
| :- | :- | :- |:- | 
|name|String|Path|The file name.|
|sheetName|String|Path|The worksheet name.|
|startrow|Integer|Query|The begin row index to be operated.|
|totalRows|Integer|Query|Number of rows to be operated.|
|updateReference|Boolean|Query|Indicates if update references in other worksheets.|
|folder|String|Query|The folder where the file is situated.|
|storageName|String|Query|The storage name where the file is situated.|


The [OpenAPI Specification](https://reference.aspose.cloud/cells/#/CellsController/DeleteWorksheetRows) defines a publicly accessible programming interface and lets you carry out REST interactions directly from a web browser.
