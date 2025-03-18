# **sqlScriptSaveOptions**

Represents the options of saving .sql file. 

## **Properties**

| Property Name | Property Type | Nullable |  ReadOnly | DefaultValue | Description | 
| :- | :- | :- |:- |  :- | :- |
|CheckIfTableExists|Boolean|true|false |  |Check if the table name exists before creating|
|ColumnTypeMap|String|true|false |  |Gets and sets the map of column type for different database.|
|CheckAllDataForColumnType|Boolean|true|false |  |Check all data to find columns' data type.|
|AddBlankLineBetweenRows|Boolean|true|false |  |Insert blank line between each data.|
|Separator|String|true|false |  |Gets and sets character separator of sql script.|
|OperatorType|String|true|false |  |Gets and sets the operator type of sql.|
|PrimaryKey|Integer|true|false |  |Represents which column is primary key of the data table.|
|CreateTable|Boolean|true|false |  |Indicates whether exporting sql of creating table.|
|IdName|String|true|false |  |Gets and sets the name of id column.|
|StartId|Integer|true|false |  |Gets and sets the start id.|
|TableName|String|true|false |  |Gets and sets the table name.|
|ExportAsString|Boolean|true|false |  |Indicates whether exporting all data as string value.|
|ExportArea|Class|true|false |  |Gets or sets the exporting range.|
|HasHeaderRow|Boolean|true|false |  |Indicates whether the range contains header row.|
|SaveFormat|String|true|false |  ||
|CachedFileFolder|String|true|false |  ||
|ClearData|Boolean|true|false |  ||
|CreateDirectory|Boolean|true|false |  ||
|EnableHTTPCompression|Boolean|true|false |  ||
|RefreshChartCache|Boolean|true|false |  ||
|SortNames|Boolean|true|false |  ||
|ValidateMergedAreas|Boolean|true|false |  ||
|MergeAreas|Boolean|true|false |  ||
|SortExternalNames|Boolean|true|false |  ||
|CheckExcelRestriction|Boolean|true|false |  ||
|UpdateSmartArt|Boolean|true|false |  ||
|EncryptDocumentProperties|Boolean|true|false |  ||

