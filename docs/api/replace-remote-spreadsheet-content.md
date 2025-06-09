# **replaceRemoteSpreadsheetContent API**

Replace text in the remoted spreadsheet. 

```bash

PUT http://api.aspose.cloud/v3.0//cells/{name}/replace/content

```
Replace text in the remoted spreadsheet.

## The request parameters of **replaceRemoteSpreadsheetContent** API are: 

| Parameter Name | Type | Path/Query String/HTTPBody | Description | 
| :- | :- | :- |:- | 
|name|String|Path|The name of the workbook file to be replace.|
|searchText|String|Query|The searched text.|
|replaceText|String|Query|The replaced text.|
|sheetname|String|Query|Specify the worksheet for the replace.|
|cellarea|String|Query|Specify the cell area for the replace.|
|folder|String|Query|The folder path where the workbook is stored.|
|storageName|String|Query|(Optional) The name of the storage if using custom cloud storage. Use default storage if omitted.|
|regoin|String|Query|The spreadsheet region setting.|
|password|String|Query|The password for opening spreadsheet file.|


The [OpenAPI Specification](https://reference.aspose.cloud/cells/#/SearchControllor/ReplaceRemoteSpreadsheetContent) defines a publicly accessible programming interface and lets you carry out REST interactions directly from a web browser.

<gist "aspose-cells-cloud-gists" "8a5b324fdf3e574dbd747c1a1e24b05d" "Example40_ReplaceTextInRemote.cs">

