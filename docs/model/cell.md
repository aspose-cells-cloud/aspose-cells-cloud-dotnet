# **cell**

Encapsulates the object that represents a single Workbook cell. 

## **Properties**

| Property Name | Property Type | Nullable |  ReadOnly | DefaultValue | Description | 
| :- | :- | :- |:- |  :- | :- |
|Name|String|true|false |  |Gets the name of the cell.|
|Row|Integer|true|false |  |Gets row number (zero based) of the cell.|
|Column|Integer|true|false |  |Gets column number (zero based) of the cell.|
|Value|String|true|false |  |Gets the value contained in this cell.|
|Type|String|true|false |  |Represents cell value type.|
|Formula|String|true|false |  |Gets or sets a formula of the .|
|IsFormula|Boolean|true|false |  |Represents if the specified cell contains formula.|
|IsMerged|Boolean|true|false |  |Checks if a cell is part of a merged range or not.|
|IsArrayHeader|Boolean|true|false |  |Indicates the cell's formula is and array formula                         and it is the first cell of the array.|
|IsInArray|Boolean|true|false |  |Indicates whether the cell formula is an array formula.|
|IsErrorValue|Boolean|true|false |  |Checks if the value of this cell is an error.|
|IsInTable|Boolean|true|false |  |Indicates whether this cell is part of table formula.|
|IsStyleSet|Boolean|true|false |  |Indicates if the cell's style is set. If return false, it means this cell has a default cell format.|
|HtmlString|String|true|false |  |Gets and sets the html string which contains data and some formats in this cell.|
|Style|Class|true|false |  |This class property represents a style element with the specified XML element name.|
|Worksheet|String|true|false |  |Gets the parent worksheet.|
|link|Class|true|false |  ||

