# **putWorksheetHyperlink API**

Add hyperlink in the worksheet. 

```bash

PUT http://api.aspose.cloud/v3.0//cells/{name}/worksheets/{sheetName}/hyperlinks

```

## The request parameters of **putWorksheetHyperlink** API are: 

| Parameter Name | Type | Path/Query String/HTTPBody | Description | 
| :- | :- | :- |:- | 
|name|String|Path|The file name.|
|sheetName|String|Path|The worksheet name.|
|firstRow|Integer|Query|First row of the hyperlink range.|
|firstColumn|Integer|Query|First column of the hyperlink range.|
|totalRows|Integer|Query|Number of rows in this hyperlink range.|
|totalColumns|Integer|Query|Number of columns of this hyperlink range.|
|address|String|Query|Address of the hyperlink.|
|folder|String|Query|The folder where the file is situated.|
|storageName|String|Query|The storage name where the file is situated.|


The [OpenAPI Specification](https://reference.aspose.cloud/cells/#/HypelinksController/PutWorksheetHyperlink) defines a publicly accessible programming interface and lets you carry out REST interactions directly from a web browser.
