# **calculationOptions**

           Represents options for calculation.            

## **Properties**

| Property Name | Property Type | Nullable |  ReadOnly | DefaultValue | Description | 
| :- | :- | :- |:- |  :- | :- |
|CalcStackSize|Integer|true|false |  |Specifies the stack size for calculating cells recursively. |
|IgnoreError|Boolean|true|false |  |Indicates whether errors encountered while calculating formulas should be ignored.            The error may be unsupported function, external links, etc.            The default value is true. |
|PrecisionStrategy|String|true|false |  |Specifies the strategy for processing precision of calculation. |
|Recursive|Boolean|true|false |  |Indicates whether calculate the dependent cells recursively when calculating one cell and it depends on other cells.            The default value is true. |
|CustomEngine|Class|true|false |  |The custom formula calculation engine to extend the default calculation engine of Aspose.Cells. |
|CalculationMonitor|Class|true|false |  |The monitor for user to track the progress of formula calculation. |
|LinkedDataSources|Array|true|false |  |Specifies the data sources for external links used in formulas. |

