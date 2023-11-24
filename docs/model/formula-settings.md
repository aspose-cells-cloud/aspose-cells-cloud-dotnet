# **formulaSettings**

Settings of formulas and calculation.  

## **Properties**

| Property Name | Property Type | Nullable |  ReadOnly | DefaultValue | Description | 
| :- | :- | :- |:- |  :- | :- |
|CalculateOnOpen|Boolean|true|false |  |Indicates whether the application is required to perform a full calculation when the workbook is opened. |
|CalculateOnSave|Boolean|true|false |  |Indicates whether recalculate the workbook before saving the document, when in manual calculation mode. |
|ForceFullCalculation|Boolean|true|false |  |Indicates whether calculates all formulas every time when a calculation is triggered. |
|CalculationMode|String|true|false |  |Gets or sets the mode for workbook calculation in ms excel. |
|CalculationId|String|true|false |  |Specifies the version of the calculation engine used to calculate values in the workbook. |
|EnableIterativeCalculation|Boolean|true|false |  |Indicates whether enable iterative calculation to resolve circular references. |
|MaxIteration|Integer|true|false |  |The maximum iterations to resolve a circular reference. |
|MaxChange|Floating|true|false |  |The maximum change to resolve a circular reference. |
|PrecisionAsDisplayed|Boolean|true|false |  |Whether the precision of calculated result be set as they are displayed while calculating formulas |
|EnableCalculationChain|Boolean|true|false |  |Whether enable calculation chain for formulas. Default is false. |
|PreservePaddingSpaces|Boolean|true|false |  |Indicates whether preserve those spaces and line breaks that are padded between formula tokens            while getting and setting formulas.            Default value is false. |

