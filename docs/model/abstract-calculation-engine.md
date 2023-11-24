# **abstractCalculationEngine**

Represents user's custom calculation engine to extend the default calculation engine of Aspose.Cells.  

## **Properties**

| Property Name | Property Type | Nullable |  ReadOnly | DefaultValue | Description | 
| :- | :- | :- |:- |  :- | :- |
|IsParamLiteralRequired|Boolean|true|false |  |Indicates whether this engine needs the literal text of parameter while doing calculation. Default value is false. |
|IsParamArrayModeRequired|Boolean|true|false |  |Indicates whether this engine needs the parameter to be calculated in array mode. Default value is false.            If  is required when calculating custom            functions, this property needs to be set as true. |
|ProcessBuiltInFunctions|Boolean|true|false |  |Whether built-in functions that have been supported by the built-in engine            should be checked and processed by this implementation.            Default is false.            If user needs to change the calculation logic of some built-in functions, this property should be set as true.            Otherwise please leave this property as false for performance consideration. |

