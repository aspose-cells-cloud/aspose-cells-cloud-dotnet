# **colorScale**

Describe the ColorScale conditional formatting rule. This conditional formatting   rule creates a gradated color scale on the cells.             

## **Properties**

| Property Name | Property Type | Nullable |  ReadOnly | DefaultValue | Description | 
| :- | :- | :- |:- |  :- | :- |
|MaxCfvo|Class|true|false |  |Get or set this ColorScale's max value object.            Cannot set null or CFValueObject with type FormatConditionValueType.Min to it. |
|MaxColor|Class|true|false |  |Get or set the gradient color for the maximum value in the range. |
|MidCfvo|Class|true|false |  |Get or set this ColorScale's mid value object.            Cannot set CFValueObject with type FormatConditionValueType.Max or FormatConditionValueType.Min to it. |
|MidColor|Class|true|false |  |Get or set the gradient color for the middle value in the range. |
|MinCfvo|Class|true|false |  |Get or set this ColorScale's min value object.            Cannot set null or CFValueObject with type FormatConditionValueType.Max to it. |
|MinColor|Class|true|false |  |Get or set the gradient color for the minimum value in the range. |

