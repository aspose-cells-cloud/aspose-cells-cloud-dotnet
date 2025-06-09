# **mergeSpreadsheets API**

Merge local spreadsheet files into a specified format file. 

```bash

PUT http://api.aspose.cloud/v3.0//cells/merge

```
Merge local spreadsheet files into a specified format file.

## The request parameters of **mergeSpreadsheets** API are: 

| Parameter Name | Type | Path/Query String/HTTPBody | Description | 
| :- | :- | :- |:- | 
|Spreadsheet|File|FormData|Upload spreadsheet file.|
|outFormat|String|Query|The out file format.|
|mergeInOneSheet|Boolean|Query|Whether to combine all data into a single worksheet.|
|outPath|String|Query|(Optional) The folder path where the workbook is stored. The default is null.|
|outStorageName|String|Query|Output file Storage Name.|
|fontsLocation|String|Query|Use Custom fonts.|
|regoin|String|Query|The spreadsheet region setting.|
|password|String|Query|The password for opening spreadsheet file.|


The [OpenAPI Specification](https://reference.aspose.cloud/cells/#/DataProcessingController/MergeSpreadsheets) defines a publicly accessible programming interface and lets you carry out REST interactions directly from a web browser.


