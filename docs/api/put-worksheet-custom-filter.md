# **putWorksheetCustomFilter API**

Filter a list with custom criteria in the worksheet. 

```bash

PUT http://api.aspose.cloud/v3.0//cells/{name}/worksheets/{sheetName}/autoFilter/custom

```

## The request parameters of **putWorksheetCustomFilter** API are: 

| Parameter Name | Type | Path/Query String/HTTPBody | Description | 
| :- | :- | :- |:- | 
|name|String|Path|The workbook name.|
|sheetName|String|Path|The worksheet name.|
|range|String|Query|Represents the range to which the specified AutoFilter applies.|
|fieldIndex|Integer|Query|The integer offset of the field on which you want to base the filter (from the left of the list; the leftmost field is field 0).|
|operatorType1|String|Query|The filter operator type|
|criteria1|String|Query|The custom criteria.|
|isAnd|Boolean|Query|true/false|
|operatorType2|String|Query||
|criteria2|String|Query|The custom criteria.|
|matchBlanks|Boolean|Query|Match all blank cell in the list.|
|refresh|Boolean|Query|Refresh auto filters to hide or unhide the rows.|
|folder|String|Query|The folder where the file is situated.|
|storageName|String|Query|The storage name where the file is situated.|


The [OpenAPI Specification](https://reference.aspose.cloud/cells/#/AutoFilterController/PutWorksheetCustomFilter) defines a publicly accessible programming interface and lets you carry out REST interactions directly from a web browser.
