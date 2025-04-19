# **postWorkbookSaveAs API**

Save an Excel file in various formats. 

```bash

POST http://api.aspose.cloud/v3.0//cells/{name}/SaveAs

```

## The request parameters of **postWorkbookSaveAs** API are: 

| Parameter Name | Type | Path/Query String/HTTPBody | Description | 
| :- | :- | :- |:- | 
|name|String|Path|The workbook name.|
|newfilename|String|Query|newfilename to save the result.The `newfilename` should encompass both the filename and extension.|
|saveOptions|Class|Body||
|isAutoFitRows|Boolean|Query|Indicates if Autofit rows in workbook.|
|isAutoFitColumns|Boolean|Query|Indicates if Autofit columns in workbook.|
|folder|String|Query|The folder where the file is situated.|
|storageName|String|Query|The storage name where the file is situated.|
|outStorageName|String|Query|The storage name where the output file is situated.|
|checkExcelRestriction|Boolean|Query|Whether check restriction of excel file when user modify cells related objects.|
|region|String|Query|The regional settings for workbook.|
|pageWideFitOnPerSheet|Boolean|Query|The page wide fit on worksheet.|
|pageTallFitOnPerSheet|Boolean|Query|The page tall fit on worksheet.|
|FontsLocation|String|Query|Use Custom fonts.|


The [OpenAPI Specification](https://reference.aspose.cloud/cells/#/ConversionController/PostWorkbookSaveAs) defines a publicly accessible programming interface and lets you carry out REST interactions directly from a web browser.
