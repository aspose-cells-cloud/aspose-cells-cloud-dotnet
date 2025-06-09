# **deleteWorksheetHyperlink API**

Delete hyperlink by index in the worksheet. 

```bash

DELETE http://api.aspose.cloud/v3.0//cells/{name}/worksheets/{sheetName}/hyperlinks/{hyperlinkIndex}

```
Delete hyperlink by index in the worksheet.

## The request parameters of **deleteWorksheetHyperlink** API are: 

| Parameter Name | Type | Path/Query String/HTTPBody | Description | 
| :- | :- | :- |:- | 
|name|String|Path|The file name.|
|sheetName|String|Path|The worksheet name.|
|hyperlinkIndex|Integer|Path|The hyperlink's index.|
|folder|String|Query|The folder where the file is situated.|
|storageName|String|Query|The storage name where the file is situated.|


The [OpenAPI Specification](https://reference.aspose.cloud/cells/#/HypelinksController/DeleteWorksheetHyperlink) defines a publicly accessible programming interface and lets you carry out REST interactions directly from a web browser.

<gist "aspose-cells-cloud-gists" "8a5b324fdf3e574dbd747c1a1e24b05d" "Example40_DeleteWorksheetHyperlink.cs">

