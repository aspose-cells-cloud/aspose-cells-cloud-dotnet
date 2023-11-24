# **deleteWorksheetDateFilter API**

Removes a date filter in worksheet.             

```bash

DELETE http://api.aspose.cloud/v3.0//cells/{name}/worksheets/{sheetName}/autoFilter/dateFilter

```

## The request parameters of **deleteWorksheetDateFilter** API are: 

| Parameter Name | Type | Path/Query String/HTTPBody | Description | 
| :- | :- | :- |:- | 
|name|String|Path|The workbook name.|
|sheetName|String|Path|The worksheet name.|
|fieldIndex|Integer|Query|The integer offset of the field on which you want to base the filter (from the left of the list; the leftmost field is field 0).|
|dateTimeGroupingType|String|Query|Specifies how to group dateTime values.|
|year|Integer|Query|The year.|
|month|Integer|Query|The month.|
|day|Integer|Query|The day.|
|hour|Integer|Query|The hour.|
|minute|Integer|Query|The minute.|
|second|Integer|Query|The second.|
|folder|String|Query|Original workbook folder.|
|storageName|String|Query|Storage name.|


The [OpenAPI Specification](https://reference.aspose.cloud/cells/#/AutoFilterController/DeleteWorksheetDateFilter) defines a publicly accessible programming interface and lets you carry out REST interactions directly from a web browser.
