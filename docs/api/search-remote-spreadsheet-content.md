# **searchRemoteSpreadsheetContent API**

Search text in the remoted spreadsheet. 

```bash

PUT http://api.aspose.cloud/v3.0//cells/{name}/search/content

```
Search text in the remoted spreadsheet.

## The request parameters of **searchRemoteSpreadsheetContent** API are: 

| Parameter Name | Type | Path/Query String/HTTPBody | Description | 
| :- | :- | :- |:- | 
|name|String|Path|The name of the workbook file to be search.|
|searchText|String|Query|The searched text.|
|ignoringCase|Boolean|Query|Ignore the text of the search.|
|sheetname|String|Query|Specify the worksheet for the lookup.|
|cellarea|String|Query|Specify the cell area for the lookup|
|folder|String|Query|The folder path where the workbook is stored.|
|storageName|String|Query|(Optional) The name of the storage if using custom cloud storage. Use default storage if omitted.|
|regoin|String|Query|The spreadsheet region setting.|
|password|String|Query|The password for opening spreadsheet file.|


The [OpenAPI Specification](https://reference.aspose.cloud/cells/#/SearchControllor/SearchRemoteSpreadsheetContent) defines a publicly accessible programming interface and lets you carry out REST interactions directly from a web browser.


