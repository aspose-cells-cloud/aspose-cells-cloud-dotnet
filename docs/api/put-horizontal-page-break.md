# **putHorizontalPageBreak API**

Add a horizontal page breaks in the worksheet. 

```bash

PUT http://api.aspose.cloud/v3.0//cells/{name}/worksheets/{sheetName}/horizontalpagebreaks

```

## The request parameters of **putHorizontalPageBreak** API are: 

| Parameter Name | Type | Path/Query String/HTTPBody | Description | 
| :- | :- | :- |:- | 
|name|String|Path|The workbook name.|
|sheetName|String|Path|The worksheet name.|
|cellname|String|Query|Cell name|
|row|Integer|Query|Row index, zero based.|
|column|Integer|Query|Column index, zero based.|
|startColumn|Integer|Query|Start column index, zero based.|
|endColumn|Integer|Query|End column index, zero based.|
|folder|String|Query|The folder where the file is situated.|
|storageName|String|Query|The storage name where the file is situated.|


The [OpenAPI Specification](https://reference.aspose.cloud/cells/#/PageBreaksController/PutHorizontalPageBreak) defines a publicly accessible programming interface and lets you carry out REST interactions directly from a web browser.
