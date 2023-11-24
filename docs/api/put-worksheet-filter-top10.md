# **putWorksheetFilterTop10 API**

Filters the top 10 item in the list in worksheet 

```bash

PUT http://api.aspose.cloud/v3.0//cells/{name}/worksheets/{sheetName}/autoFilter/filterTop10

```

## The request parameters of **putWorksheetFilterTop10** API are: 

| Parameter Name | Type | Path/Query String/HTTPBody | Description | 
| :- | :- | :- |:- | 
|name|String|Path|The workbook name.|
|sheetName|String|Path|The worksheet name.|
|range|String|Query|Represents the range to which the specified AutoFilter applies.|
|fieldIndex|Integer|Query|The integer offset of the field on which you want to base the filter (from the left of the list; the leftmost field is field 0).|
|isTop|Boolean|Query|Indicates whether filter from top or bottom|
|isPercent|Boolean|Query|Indicates whether the items is percent or count|
|itemCount|Integer|Query|The item count|
|matchBlanks|Boolean|Query|Match all blank or  not blank cell in the list.(true/false)|
|refresh|Boolean|Query|If true, hide the filtered rows.|
|folder|String|Query|Original workbook folder.|
|storageName|String|Query|Storage name.|


The [OpenAPI Specification](https://reference.aspose.cloud/cells/#/AutoFilterController/PutWorksheetFilterTop10) defines a publicly accessible programming interface and lets you carry out REST interactions directly from a web browser.
