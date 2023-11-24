# **postWorksheetMatchBlanks API**

Match all blank cell in the list. 

```bash

POST http://api.aspose.cloud/v3.0//cells/{name}/worksheets/{sheetName}/autoFilter/matchBlanks

```

## The request parameters of **postWorksheetMatchBlanks** API are: 

| Parameter Name | Type | Path/Query String/HTTPBody | Description | 
| :- | :- | :- |:- | 
|name|String|Path|The workbook name.|
|sheetName|String|Path|The worksheet name.|
|fieldIndex|Integer|Query|The integer offset of the field on which you want to base the filter (from the left of the list; the leftmost field is field 0).|
|folder|String|Query|Original workbook folder.|
|storageName|String|Query|Storage name.|


The [OpenAPI Specification](https://reference.aspose.cloud/cells/#/AutoFilterController/PostWorksheetMatchBlanks) defines a publicly accessible programming interface and lets you carry out REST interactions directly from a web browser.
