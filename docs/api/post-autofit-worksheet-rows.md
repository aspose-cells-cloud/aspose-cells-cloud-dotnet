# **postAutofitWorksheetRows API**

Autofit rows in worksheet. 

```bash

POST http://api.aspose.cloud/v3.0//cells/{name}/worksheets/{sheetName}/autofitrows

```

## The request parameters of **postAutofitWorksheetRows** API are: 

| Parameter Name | Type | Path/Query String/HTTPBody | Description | 
| :- | :- | :- |:- | 
|name|String|Path|The workbook name.|
|sheetName|String|Path|The worksheet name.|
|startRow|Integer|Query|Start row index.|
|endRow|Integer|Query|End row index.|
|onlyAuto|Boolean|Query|Autofits all rows in this worksheet.|
|folder|String|Query|Original workbook folder.|
|storageName|String|Query|Storage name.|


The [OpenAPI Specification](https://reference.aspose.cloud/cells/#/WorksheetsController/PostAutofitWorksheetRows) defines a publicly accessible programming interface and lets you carry out REST interactions directly from a web browser.
