# **trimContentOptions**

 

## **Properties**

| Property Name | Property Type | Nullable |  ReadOnly | DefaultValue | Description | 
| :- | :- | :- |:- |  :- | :- |
|DataSource|Class|true|false |  |Represents data source.  There are three types of data, they are CloudFileSystem, RequestFiles, HttpUri.|
|FileInfo|Class|true|false |  |Represents file information. Include of filename, filesize, and file content(base64String).|
|TrimContent|String|true|false |  |Trim Content|
|TrimLeading|Boolean|true|false |  |If the trim leading value is true, the trim content before and after cell values will be deleted.|
|TrimTrailing|Boolean|true|false |  |If the trim trailing value is true, the trim content before and after cell values will be deleted.|
|TrimSpaceBetweenWordTo1|Boolean|true|false |  |When the trim space between word to 1 parameter is true, it enables the removal of extra spaces between words within a cell, ensuring that only a single space is maintained between words.|
|TrimNonBreakingSpaces|Boolean|true|false |  ||
|RemoveExtraLineBreaks|Boolean|true|false |  |When this parameter is enabled (set to True), it deletes extra line breaks within the selected range, ensuring that only necessary line breaks are retained.|
|RemoveAllLineBreaks|Boolean|true|false |  |When this parameter is enabled (set to True), it removes all line breaks within the selected range, resulting in a continuous block of text without any line breaks.|
|ScopeOptions|Class|true|false |  |Specifies the range of cells within the worksheet where the spreadsheet operations will be performed. This parameter allows users to define the exact area to be processed, ensuring that operations are applied only to the designated cells.|

