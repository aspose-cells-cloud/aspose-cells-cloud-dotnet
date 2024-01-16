# **postAutofitWorksheetRows API**

Autofit rows in the worksheet. 

```bash

POST http://api.aspose.cloud/v3.0//cells/{name}/worksheets/{sheetName}/autofitrows

```

## The request parameters of **postAutofitWorksheetRows** API are: 

| Parameter Name | Type | Path/Query String/HTTPBody | Description | 
| :- | :- | :- |:- | 
|name|String|Path|The file name.|
|sheetName|String|Path|The worksheet name.|
|startRow|Integer|Query|The start row index.|
|endRow|Integer|Query|The end row index.|
|onlyAuto|Boolean|Query|Autofits all rows in this worksheet.|
|folder|String|Query|The folder where the file is situated.|
|storageName|String|Query|The storage name where the file is situated.|


The [OpenAPI Specification](https://reference.aspose.cloud/cells/#/WorksheetsController/PostAutofitWorksheetRows) defines a publicly accessible programming interface and lets you carry out REST interactions directly from a web browser.
