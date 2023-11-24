# **putWorksheetFormatConditionCondition API**

Adds a condition for format condition. 

```bash

PUT http://api.aspose.cloud/v3.0//cells/{name}/worksheets/{sheetName}/conditionalFormattings/{index}/condition

```

## The request parameters of **putWorksheetFormatConditionCondition** API are: 

| Parameter Name | Type | Path/Query String/HTTPBody | Description | 
| :- | :- | :- |:- | 
|name|String|Path|The workbook name.|
|sheetName|String|Path|The worksheet name.|
|index|Integer|Path|Gets the Conditional Formatting element at the specified index.|
|type|String|Query|Format condition type(CellValue/Expression/ColorScale/DataBar/IconSet/Top10/UniqueValues/DuplicateValues/ContainsText/NotContainsText/BeginsWith/EndsWith/ContainsBlanks/NotContainsBlanks/ContainsErrors/NotContainsErrors/TimePeriod/AboveAverage).|
|operatorType|String|Query|Represents the operator type of conditional format and data validation(Between/Equal/GreaterThan/GreaterOrEqual/LessThan/None/NotBetween/NotEqual).|
|formula1|String|Query|The value or expression associated with conditional formatting.|
|formula2|String|Query|The value or expression associated with conditional formatting.|
|folder|String|Query|Original workbook folder.|
|storageName|String|Query|Storage name.|


The [OpenAPI Specification](https://reference.aspose.cloud/cells/#/ConditionalFormattingsController/PutWorksheetFormatConditionCondition) defines a publicly accessible programming interface and lets you carry out REST interactions directly from a web browser.
