# **abstractCalculationMonitor**

Monitor for user to track the progress of formula calculation.  

## **Properties**

| Property Name | Property Type | Nullable |  ReadOnly | DefaultValue | Description | 
| :- | :- | :- |:- |  :- | :- |
|OriginalValue|Class|true|false |  |Gets the old value of the calculated cell.            Should be used only in  and . |
|ValueChanged|Boolean|true|false |  |Whether the cell's value has been changed after the calculation.            Should be used only in . |
|CalculatedValue|Class|true|false |  |Gets the newly calculated value of the cell.            Should be used only in . |

