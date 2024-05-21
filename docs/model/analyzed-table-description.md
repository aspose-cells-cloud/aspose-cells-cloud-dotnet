# **analyzedTableDescription**

Represents analyzed table description. 

## **Properties**

| Property Name | Property Type | Nullable |  ReadOnly | DefaultValue | Description | 
| :- | :- | :- |:- |  :- | :- |
|Name|String|true|false |  |Represents table name.|
|SheetName|String|true|false |  |Represents worksheet name which is where the table is located.|
|Columns|Container|true|false |  |Represents analyzed description about table columns.|
|DateColumns|Container|true|false |  |Represents date columns list.|
|NumberColumns|Container|true|false |  |Represents number columns list.|
|TextColumns|Container|true|false |  |Represents string columns list.|
|ExceptionColumns|Container|true|false |  |Represents exception columns list.|
|HasTableHeaderRow|Boolean|true|false |  |Represents there is a table header in the table.|
|HasTableTotalRow|Boolean|true|false |  |Represents there is a total row in the table.|
|StartDataColumnIndex|Integer|true|false |  |Represents the column index as the start data column.|
|EndDataColumnIndex|Integer|true|false |  |Represents the column index as the end data column.|
|StartDataRowIndex|Integer|true|false |  |Represents the row index as the start data row.|
|EndDataRowIndex|Integer|true|false |  |Represents the row index as the end data row.|
|Thumbnail|String|true|false |  |Represents table thumbnail. Base64String|
|DiscoverCharts|Container|true|false |  |Represents a collection of charts, which is a collection of charts created based on data analysis of a table.|
|DiscoverPivotTables|Container|true|false |  |Represents a collection of pivot tables, which is a collection of pivot tables created based on data analysis of a table.|

