# **formatCondition**

Represents conditional formatting condition. 

## **Properties**

| Property Name | Property Type | Nullable |  ReadOnly | DefaultValue | Description | 
| :- | :- | :- |:- |  :- | :- |
|Priority|Integer|true|false |  |The priority of this conditional formatting rule. This value is used to determine which                        format should be evaluated and rendered. Lower numeric values are higher priority than                        higher numeric values, where '1' is the highest priority.|
|Type|String|true|false |  |Gets and sets whether the conditional format Type.|
|StopIfTrue|Boolean|true|false |  |True, no rules with lower priority may be applied over this rule, when this rule evaluates to true.                        Only applies for Excel 2007;|
|AboveAverage|Class|true|false |  |Get the conditional formatting's "AboveAverage" instance.                        The default instance's rule highlights cells that are                         above the average for all values in the range.                        Valid only for type = AboveAverage.|
|ColorScale|Class|true|false |  |Get the conditional formatting's "ColorScale" instance.                        The default instance is a "green-yellow-red" 3ColorScale .                        Valid only for type = ColorScale.|
|DataBar|Class|true|false |  |Get the conditional formatting's "DataBar" instance.                        The default instance's color is blue.                        Valid only for type is DataBar.|
|Formula1|String|true|false |  |Gets and sets the value or expression associated with conditional formatting.|
|Formula2|String|true|false |  |Gets and sets the value or expression associated with conditional formatting.|
|IconSet|Class|true|false |  |Get the conditional formatting's "IconSet" instance.                        The default instance's IconSetType is TrafficLights31.                        Valid only for type = IconSet.|
|Operator|String|true|false |  |Gets and sets the conditional format operator type.|
|Style|Class|true|false |  |Gets or setts style of conditional formatted cell ranges.|
|Text|String|true|false |  |The text value in a "text contains" conditional formatting rule.                         Valid only for type = containsText, notContainsText, beginsWith and endsWith.                        The default value is null.|
|TimePeriod|String|true|false |  |The applicable time period in a "date occurring…" conditional formatting rule.                         Valid only for type = timePeriod.                        The default value is TimePeriodType.Today.|
|Top10|Class|true|false |  |Get the conditional formatting's "Top10" instance.                        The default instance's rule highlights cells whose                        values fall in the top 10 bracket.                        Valid only for type is Top10.|
|link|Class|true|false |  ||

