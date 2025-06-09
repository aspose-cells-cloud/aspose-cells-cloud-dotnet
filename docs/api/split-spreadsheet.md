# **splitSpreadsheet API**

Split a local spreadsheet into the specified format, multi-file. 

```bash

PUT http://api.aspose.cloud/v3.0//cells/split

```
Split a local spreadsheet into the specified format, multi-file.

## The request parameters of **splitSpreadsheet** API are: 

| Parameter Name | Type | Path/Query String/HTTPBody | Description | 
| :- | :- | :- |:- | 
|Spreadsheet|File|FormData|Upload spreadsheet file.|
|from|Integer|Query|Begin worksheet index.|
|to|Integer|Query|End worksheet index.|
|outFormat|String|Query|The out file format.|
|outPath|String|Query|(Optional) The folder path where the workbook is stored. The default is null.|
|outStorageName|String|Query|Output file Storage Name.|
|fontsLocation|String|Query|Use Custom fonts.|
|regoin|String|Query|The spreadsheet region setting.|
|password|String|Query|The password for opening spreadsheet file.|


The [OpenAPI Specification](https://reference.aspose.cloud/cells/#/DataProcessingController/SplitSpreadsheet) defines a publicly accessible programming interface and lets you carry out REST interactions directly from a web browser.

<gist "aspose-cells-cloud-gists" "8a5b324fdf3e574dbd747c1a1e24b05d" "Example40_SplitLocalFile.cs">

