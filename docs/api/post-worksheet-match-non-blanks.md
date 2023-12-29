# **postWorksheetMatchNonBlanks API**

Match all not blank cells in the list. 

```bash

POST http://api.aspose.cloud/v3.0//cells/{name}/worksheets/{sheetName}/autoFilter/matchNonBlanks

```

## The request parameters of **postWorksheetMatchNonBlanks** API are: 

| Parameter Name | Type | Path/Query String/HTTPBody | Description | 
| :- | :- | :- |:- | 
|name|String|Path|The workbook name.|
|sheetName|String|Path|The worksheet name.|
|fieldIndex|Integer|Query|The integer offset of the field on which you want to base the filter (from the left of the list; the leftmost field is field 0).|
|folder|String|Query|The folder where the file is situated.|
|storageName|String|Query|The storage name where the file is situated.|


The [OpenAPI Specification](https://reference.aspose.cloud/cells/#/AutoFilterController/PostWorksheetMatchNonBlanks) defines a publicly accessible programming interface and lets you carry out REST interactions directly from a web browser.
