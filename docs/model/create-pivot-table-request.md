# **createPivotTableRequest**

Indicates create pivot table request 

## **Properties**

| Property Name | Property Type | Nullable |  ReadOnly | DefaultValue | Description | 
| :- | :- | :- |:- |  :- | :- |
|Name|String|true|false |  |Pivot table name|
|SourceData|String|true|false |  |The data for the new PivotTable cache.|
|DestCellName|String|true|false |  |The cell in the upper-left corner of the PivotTable report's destination range.|
|UseSameSource|Boolean|true|false |  |Indicates whether using same data source when another existing pivot table has used this data source.If the property is true, it will save memory.|
|PivotFieldRows|Array|true|false |  |Represents row fields in a PivotTable report.|
|PivotFieldColumns|Array|true|false |  |Represents column fields in a PivotTable report.|
|PivotFieldData|Array|true|false |  |Represents data fields in a PivotTable report.|

