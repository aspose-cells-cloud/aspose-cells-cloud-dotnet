# **putAddNewWorksheet API**

Add a new worksheet in the workbook. 

```bash

PUT http://api.aspose.cloud/v3.0//cells/{name}/worksheets/{sheetName}

```

## The request parameters of **putAddNewWorksheet** API are: 

| Parameter Name | Type | Path/Query String/HTTPBody | Description | 
| :- | :- | :- |:- | 
|name|String|Path|The file name.|
|sheetName|String|Path|The new sheet name.|
|position|Integer|Query|The new sheet position.|
|sheettype|String|Query|Specifies the worksheet type(VB/Worksheet/Chart/BIFF4Macro/InternationalMacro/Other/Dialog).|
|folder|String|Query|The folder where the file is situated.|
|storageName|String|Query|The storage name where the file is situated.|


The [OpenAPI Specification](https://reference.aspose.cloud/cells/#/WorksheetsController/PutAddNewWorksheet) defines a publicly accessible programming interface and lets you carry out REST interactions directly from a web browser.
