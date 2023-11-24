# **style**

 

## **Properties**

| Property Name | Property Type | Nullable |  ReadOnly | DefaultValue | Description | 
| :- | :- | :- |:- |  :- | :- |
|Font|Class|true|false |  |Gets a  object. |
|Name|String|true|false |  |Gets or sets the name of the style. |
|CultureCustom|String|true|false |  |Gets and sets the culture-dependent pattern string for number format.            If no number format has been set for this object, null will be returned.            If number format is builtin, the pattern string corresponding to the builtin number will be returned. |
|Custom|String|true|false |  |Represents the custom number format string of this style object.            If the custom number format is not set(For example, the number format is builtin), "" will be returned. |
|BackgroundColor|Class|true|false |  |Gets or sets a style's background color. |
|ForegroundColor|Class|true|false |  |Gets or sets a style's foreground color. |
|IsFormulaHidden|Boolean|true|false |  |Represents if the formula will be hidden when the worksheet is protected. |
|IsDateTime|Boolean|true|false |  |Indicates whether the number format is a date format. |
|IsTextWrapped|Boolean|true|false |  |Gets or sets a value indicating whether the text within a cell is wrapped. |
|IsGradient|Boolean|true|false |  |Indicates whether the cell shading is a gradient pattern. |
|IsLocked|Boolean|true|false |  |Gets or sets a value indicating whether a cell can be modified or not. |
|IsPercent|Boolean|true|false |  |Indicates whether the number format is a percent format. |
|ShrinkToFit|Boolean|true|false |  |Represents if text automatically shrinks to fit in the available column width. |
|IndentLevel|Integer|true|false |  |Represents the indent level for the cell or range. Can only be an integer from 0 to 250. |
|Number|Integer|true|false |  |Gets or sets the display format of numbers and dates. The formatting patterns are different for different regions. |
|RotationAngle|Integer|true|false |  |Represents text rotation angle. |
|Pattern|String|true|false |  |Gets or sets the cell background pattern type. |
|TextDirection|String|true|false |  |Represents text reading order. |
|VerticalAlignment|String|true|false |  |Gets or sets the vertical alignment type of the text in a cell. |
|HorizontalAlignment|String|true|false |  |Gets or sets the horizontal alignment type of the text in a cell. |
|BorderCollection|Container|true|false |  ||
|BackgroundThemeColor|Class|true|false |  |Gets and sets the background theme color. |
|ForegroundThemeColor|Class|true|false |  |Gets and sets the foreground theme color. |

