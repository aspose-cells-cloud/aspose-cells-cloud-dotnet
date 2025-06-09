# **searchSpreadsheetContent API**

Search text in the local spreadsheet. 

```bash

PUT http://api.aspose.cloud/v3.0//cells/search/content

```
Search text in the local spreadsheet.

## The request parameters of **searchSpreadsheetContent** API are: 

| Parameter Name | Type | Path/Query String/HTTPBody | Description | 
| :- | :- | :- |:- | 
|Spreadsheet|File|FormData|Upload spreadsheet file.|
|searchText|String|Query|The searched text.|
|ignoringCase|Boolean|Query|Ignore the text of the search.|
|sheetname|String|Query|Specify the worksheet for the lookup.|
|cellarea|String|Query|Specify the cell area for the lookup|
|regoin|String|Query|The spreadsheet region setting.|
|password|String|Query|The password for opening spreadsheet file.|


The [OpenAPI Specification](https://reference.aspose.cloud/cells/#/SearchControllor/SearchSpreadsheetContent) defines a publicly accessible programming interface and lets you carry out REST interactions directly from a web browser.

<gist "aspose-cells-cloud-gists" "8a5b324fdf3e574dbd747c1a1e24b05d" "Example40_SearchTextInLocalFile.cs">

