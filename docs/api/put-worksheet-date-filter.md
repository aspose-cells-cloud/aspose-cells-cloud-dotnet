# **putWorksheetDateFilter API**

Adds date filter in worksheet. 

```bash

PUT http://api.aspose.cloud/v3.0//cells/{name}/worksheets/{sheetName}/autoFilter/dateFilter

```

## The request parameters of **putWorksheetDateFilter** API are: 

| Parameter Name | Type | Path/Query String/HTTPBody | Description | 
| :- | :- | :- |:- | 
|name|String|Path|The workbook name.|
|sheetName|String|Path|The worksheet name.|
|range|String|Query|Represents the range to which the specified AutoFilter applies.|
|fieldIndex|Integer|Query|The integer offset of the field on which you want to base the filter (from the left of the list; the leftmost field is field 0).|
|dateTimeGroupingType|String|Query|Specifies how to group dateTime values(Day,Hour,Minute,Month,Second,Year).|
|year|Integer|Query|The year.|
|month|Integer|Query|The month.|
|day|Integer|Query|The day.|
|hour|Integer|Query|The hour.|
|minute|Integer|Query|The minute.|
|second|Integer|Query|The second.|
|matchBlanks|Boolean|Query|Match all blank or not blank cell in the list.(true/false)|
|refresh|Boolean|Query|If true, hide the filtered rows.|
|folder|String|Query|Original workbook folder.|
|storageName|String|Query|Storage name.|


The [OpenAPI Specification](https://reference.aspose.cloud/cells/#/AutoFilterController/PutWorksheetDateFilter) defines a publicly accessible programming interface and lets you carry out REST interactions directly from a web browser.
