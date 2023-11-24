# **putVerticalPageBreak API**

Adds a vertical page break in worksheet. 

```bash

PUT http://api.aspose.cloud/v3.0//cells/{name}/worksheets/{sheetName}/verticalpagebreaks

```

## The request parameters of **putVerticalPageBreak** API are: 

| Parameter Name | Type | Path/Query String/HTTPBody | Description | 
| :- | :- | :- |:- | 
|name|String|Path|The workbook name.|
|sheetName|String|Path|The worksheet name.|
|cellname|String|Query|Cell name|
|column|Integer|Query|Column index, zero based.|
|row|Integer|Query|Row index, zero based.|
|startRow|Integer|Query|Start row index, zero based.|
|endRow|Integer|Query|End row index, zero based.|
|folder|String|Query|Original workbook folder.|
|storageName|String|Query|Storage name.|


The [OpenAPI Specification](https://reference.aspose.cloud/cells/#/PageBreaksController/PutVerticalPageBreak) defines a publicly accessible programming interface and lets you carry out REST interactions directly from a web browser.
