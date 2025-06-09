# **postReverse API**

Reverse rows or columns in Excel files and create output files in various formats. 

```bash

POST http://api.aspose.cloud/v3.0//cells/reverse

```
Reverse rows or columns in Excel files and create output files in various formats.

## The request parameters of **postReverse** API are: 

| Parameter Name | Type | Path/Query String/HTTPBody | Description | 
| :- | :- | :- |:- | 
|File|File|FormData|File to upload|
|rotateType|String|Query|rows/cols/both|
|outFormat|String|Query|The output data file format.(CSV/XLS/HTML/MHTML/ODS/PDF/XML/TXT/TIFF/XLSB/XLSM/XLSX/XLTM/XLTX/XPS/PNG/JPG/JPEG/GIF/EMF/BMP/MD[Markdown]/Numbers)|
|password|String|Query|The password needed to open an Excel file.|
|checkExcelRestriction|Boolean|Query|Whether check restriction of excel file when user modify cells related objects.|
|region|String|Query|The regional settings for workbook.|


The [OpenAPI Specification](https://reference.aspose.cloud/cells/#/LightCellsController/PostReverse) defines a publicly accessible programming interface and lets you carry out REST interactions directly from a web browser.

<gist "aspose-cells-cloud-gists" "8a5b324fdf3e574dbd747c1a1e24b05d" "Example40_PostReverse.cs">

