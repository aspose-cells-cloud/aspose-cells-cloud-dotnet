# **exportSpreadsheetAsFormat API**

Converts a spreadsheet in cloud storage to the specified format. 

```bash

GET http://api.aspose.cloud/v3.0//cells/{name}

```
Converts a spreadsheet in cloud storage to the specified format.

## The request parameters of **exportSpreadsheetAsFormat** API are: 

| Parameter Name | Type | Path/Query String/HTTPBody | Description | 
| :- | :- | :- |:- | 
|name|String|Path|(Required) The name of the workbook file to be retrieved.|
|format|String|Query|(Required) The desired output format (e.g., "Xlsx", "Pdf", "Csv").|
|folder|String|Query|(Optional) The folder path where the workbook is stored. The default is null.|
|storageName|String|Query|(Optional) The name of the storage if using custom cloud storage. Use default storage if omitted.|
|outPath|String|Query|(Optional) The folder path where the workbook is stored. The default is null.|
|outStorageName|String|Query|Output file Storage Name.|
|fontsLocation|String|Query|Use Custom fonts.|
|regoin|String|Query|The spreadsheet region setting.|
|password|String|Query|The password for opening spreadsheet file.|


The [OpenAPI Specification](https://reference.aspose.cloud/cells/#/ConversionController/ExportSpreadsheetAsFormat) defines a publicly accessible programming interface and lets you carry out REST interactions directly from a web browser.

<gist "aspose-cells-cloud-gists" "8a5b324fdf3e574dbd747c1a1e24b05d" "Example40_GetWorkbookWithFormat.cs">

