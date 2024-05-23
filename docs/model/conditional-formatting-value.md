# **conditionalFormattingValue**

           Describes the values of the interpolation points in a gradient scale, dataBar or iconSet.            

## **Properties**

| Property Name | Property Type | Nullable |  ReadOnly | DefaultValue | Description | 
| :- | :- | :- |:- |  :- | :- |
|IsGTE|Boolean|true|false |  |Get or set the Greater Than Or Equal flag.             Use only for icon sets, determines whether this threshold value uses             the greater than or equal to operator.             'false' indicates 'greater than' is used instead of 'greater than or equal to'.            Default value is true. |
|Type|String|true|false |  |Get or set the type of this conditional formatting value object.            Setting the type to FormatConditionValueType.Min or FormatConditionValueType.Max             will auto set "Value" to null. |
|Value|Class|true|false |  |Get or set the value of this conditional formatting value object.            It should be used in conjunction with Type. |

