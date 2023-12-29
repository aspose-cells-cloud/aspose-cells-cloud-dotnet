# **postMerge API**

Merge cells in the worksheet. 

```bash

POST http://api.aspose.cloud/v3.0//cells/merge

```

## The request parameters of **postMerge** API are: 

| Parameter Name | Type | Path/Query String/HTTPBody | Description | 
| :- | :- | :- |:- | 
|File|File|FormData|The output data file format.(CSV/XLS/HTML/MHTML/ODS/PDF/XML/TXT/TIFF/XLSB/XLSM/XLSX/XLTM/XLTX/XPS/PNG/JPG/JPEG/GIF/EMF/BMP/MD[Markdown]/Numbers)|
|outFormat|String|Query|The password needed to open an Excel file.|
|mergeToOneSheet|Boolean|Query|Whether check restriction of excel file when user modify cells related objects.|
|password|String|Query|The regional settings for workbook.|
|checkExcelRestriction|Boolean|Query|Upload files.|
|region|String|Query||


The [OpenAPI Specification](https://reference.aspose.cloud/cells/#/LightCellsController/PostMerge) defines a publicly accessible programming interface and lets you carry out REST interactions directly from a web browser.
