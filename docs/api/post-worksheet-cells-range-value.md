# **postWorksheetCellsRangeValue API**

Assign a value to the range; if necessary, the value will be converted to another data type, and the cell's number format will be reset. 

```bash

POST http://api.aspose.cloud/v3.0//cells/{name}/worksheets/{sheetName}/ranges/value

```

## The request parameters of **postWorksheetCellsRangeValue** API are: 

| Parameter Name | Type | Path/Query String/HTTPBody | Description | 
| :- | :- | :- |:- | 
|name|String|Path|The file name.|
|sheetName|String|Path|The worksheet name.|
|range|Class|Body|The range in worksheet. |
|Value|String|Query|Input value.|
|isConverted|Boolean|Query|True: converted to other data type if appropriate.|
|setStyle|Boolean|Query|True: set the number format to cell's style when converting to other data type.|
|folder|String|Query|Original workbook folder.|
|storageName|String|Query|Storage name.|


The [OpenAPI Specification](https://reference.aspose.cloud/cells/#/RangesController/PostWorksheetCellsRangeValue) defines a publicly accessible programming interface and lets you carry out REST interactions directly from a web browser.
