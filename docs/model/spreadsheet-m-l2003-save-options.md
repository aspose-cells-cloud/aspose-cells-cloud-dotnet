# **spreadsheetML2003SaveOptions**

Represents the options of saving .xml file. 

## **Properties**

| Property Name | Property Type | Nullable |  ReadOnly | DefaultValue | Description | 
| :- | :- | :- |:- |  :- | :- |
|ExportColumnIndexOfCell|Boolean|true|false |  |The default value is false, it means that column index will be ignored if the cell is contiguous to the previous cell.|
|IsIndentedFormatting|Boolean|true|false |  |Causes child elements to be indented.The default value is true.  If the value is false, it will reduce the size of the xml file|
|LimitAsXls|Boolean|true|false |  |Limit as xls, the max row index is 65535 and the max column index is 255.|
|SaveFormat|String|true|false |  ||
|CachedFileFolder|String|true|false |  ||
|ClearData|Boolean|true|false |  ||
|CreateDirectory|Boolean|true|false |  ||
|EnableHTTPCompression|Boolean|true|false |  ||
|RefreshChartCache|Boolean|true|false |  ||
|SortNames|Boolean|true|false |  ||
|ValidateMergedAreas|Boolean|true|false |  ||

