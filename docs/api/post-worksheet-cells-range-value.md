# **postWorksheetCellsRangeValue API**

Puts a value into the range, if appropriate the value will be converted to other data type and cell's number format will be reset.             

```bash

POST http://api.aspose.cloud/v3.0//cells/{name}/worksheets/{sheetName}/ranges/value

```

## The request parameters of **postWorksheetCellsRangeValue** API are: 

| Parameter Name | Type | Path/Query String/HTTPBody | Description | 
| :- | :- | :- |:- | 
|name|String|Path|The workbook name.|
|sheetName|String|Path|The worksheet name.|
|range|Class|Body|range in worksheet |
|Value|String|Query|Input value|
|isConverted|Boolean|Query|True: converted to other data type if appropriate.|
|setStyle|Boolean|Query|True: set the number format to cell's style when converting to other data type|
|folder|String|Query|Original workbook folder.|
|storageName|String|Query|Storage name.|


The [OpenAPI Specification](https://reference.aspose.cloud/cells/#/RangesController/PostWorksheetCellsRangeValue) defines a publicly accessible programming interface and lets you carry out REST interactions directly from a web browser.
