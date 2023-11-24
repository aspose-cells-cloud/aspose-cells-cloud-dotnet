# **txtSaveOptions**

Represents the options of saving .txt file. 

## **Properties**

| Property Name | Property Type | Nullable |  ReadOnly | DefaultValue | Description | 
| :- | :- | :- |:- |  :- | :- |
|QuoteType|String|true|false |  |Gets or sets how to quote values in the exported text file.|
|Separator|String|true|false |  |Gets and sets char Delimiter of text file.|
|SeparatorString|String|true|false |  |Gets and sets the a string value as separator.|
|AlwaysQuoted|Boolean|true|false |  |Indicates whether always adding '"' for each field. If true then all values will be quoted; If false then values will only be quoted when needed(for example, when values contain special characters such as '"' , '\n' or separator character). Default is false.|
|SaveFormat|String|true|false |  ||
|CachedFileFolder|String|true|false |  ||
|ClearData|Boolean|true|false |  ||
|CreateDirectory|Boolean|true|false |  ||
|EnableHTTPCompression|Boolean|true|false |  ||
|RefreshChartCache|Boolean|true|false |  ||
|SortNames|Boolean|true|false |  ||
|ValidateMergedAreas|Boolean|true|false |  ||

