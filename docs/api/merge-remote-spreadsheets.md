# **mergeRemoteSpreadsheets API**

Merge spreadsheet files in cloud storage into a specified format file. 

```bash

PUT http://api.aspose.cloud/v3.0//cells/merge/remote-spreadsheets

```
Merge spreadsheet files in cloud storage into a specified format file.

## The request parameters of **mergeRemoteSpreadsheets** API are: 

| Parameter Name | Type | Path/Query String/HTTPBody | Description | 
| :- | :- | :- |:- | 
|folder|String|Query|The folder used to store the merged files.|
|fileMatchExpression|String|Query||
|outFormat|String|Query|The out file format.|
|mergeInOneSheet|Boolean|Query|Whether to combine all data into a single worksheet.|
|storageName|String|Query|(Optional) The name of the storage if using custom cloud storage. Use default storage if omitted.|
|outPath|String|Query|(Optional) The folder path where the workbook is stored. The default is null.|
|outStorageName|String|Query|Output file Storage Name.|
|fontsLocation|String|Query|Use Custom fonts.|
|regoin|String|Query|The spreadsheet region setting.|
|password|String|Query|The password for opening spreadsheet file.|


The [OpenAPI Specification](https://reference.aspose.cloud/cells/#/DataProcessingController/MergeRemoteSpreadsheets) defines a publicly accessible programming interface and lets you carry out REST interactions directly from a web browser.

<gist "aspose-cells-cloud-gists" "8a5b324fdf3e574dbd747c1a1e24b05d" "Example40_MergeFilesInRemoteFolder.cs">

