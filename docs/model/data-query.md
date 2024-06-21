# **dataQuery**

Data query. 

## **Properties**

| Property Name | Property Type | Nullable |  ReadOnly | DefaultValue | Description | 
| :- | :- | :- |:- |  :- | :- |
|Name|String|true|false |  |Define a name for data query. Unique identification.|
|DataSourceDataType|String|true|false |  |The specific data object type. When the value is File, DataItem is invalid.|
|DataSource|Class|true|false |  |Indicates the source of the mount data.|
|FileInfo|Class|true|false |  |When data souce is request files, FileInfo store the contents of the file.|
|DataItem|Class|true|false |  |The specific data object type and name.|

