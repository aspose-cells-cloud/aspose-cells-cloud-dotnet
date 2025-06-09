# **splitRemoteSpreadsheet API**

Split a spreadsheet in cloud storage into the specified format, multi-file. 

```bash

PUT http://api.aspose.cloud/v3.0//cells/{name}/split

```
Split a spreadsheet in cloud storage into the specified format, multi-file.

## The request parameters of **splitRemoteSpreadsheet** API are: 

| Parameter Name | Type | Path/Query String/HTTPBody | Description | 
| :- | :- | :- |:- | 
|name|String|Path|The name of the workbook file to be split.|
|folder|String|Query|The folder path where the workbook is stored.|
|from|Integer|Query|Begin worksheet index.|
|to|Integer|Query|End worksheet index.|
|outFormat|String|Query|The desired output format (e.g., "Xlsx", "Pdf", "Csv").|
|storageName|String|Query|(Optional) The name of the storage if using custom cloud storage. Use default storage if omitted.|
|outPath|String|Query|(Optional) The folder path where the workbook is stored. The default is null.|
|outStorageName|String|Query|Output file Storage Name.|
|fontsLocation|String|Query|Use Custom fonts.|
|regoin|String|Query|The spreadsheet region setting.|
|password|String|Query|The password for opening spreadsheet file.|


The [OpenAPI Specification](https://reference.aspose.cloud/cells/#/DataProcessingController/SplitRemoteSpreadsheet) defines a publicly accessible programming interface and lets you carry out REST interactions directly from a web browser.

<gist "aspose-cells-cloud-gists" "8a5b324fdf3e574dbd747c1a1e24b05d" "Example40_SplitFileInRemote.cs">

