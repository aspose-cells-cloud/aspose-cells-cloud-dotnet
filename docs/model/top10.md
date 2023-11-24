# **top10**

Describe the Top10 conditional formatting rule. This conditional formatting    rule highlights cells whose values fall in the top N or bottom N bracket,    as specified. 

## **Properties**

| Property Name | Property Type | Nullable |  ReadOnly | DefaultValue | Description | 
| :- | :- | :- |:- |  :- | :- |
|IsBottom|Boolean|true|false |  |Get or set whether a "top/bottom n" rule is a "bottom n" rule.            Default value is false. |
|IsPercent|Boolean|true|false |  |Get or set whether a "top/bottom n" rule is a "top/bottom n percent" rule.            Default value is false. |
|Rank|Integer|true|false |  |Get or set the value of "n" in a "top/bottom n" conditional formatting rule.            If IsPercent is true, the value must between 0 and 100.            Otherwise it must between 0 and 1000.            Default value is 10. |

