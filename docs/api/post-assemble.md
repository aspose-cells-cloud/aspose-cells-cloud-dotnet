# **postAssemble API**

Assemble data files with template files to generate files in various formats. 

```bash

POST http://api.aspose.cloud/v3.0//cells/assemble

```

## The request parameters of **postAssemble** API are: 

| Parameter Name | Type | Path/Query String/HTTPBody | Description | 
| :- | :- | :- |:- | 
|File|File|FormData|The format to convert(CSV/XLS/HTML/MHTML/ODS/PDF/XML/TXT/TIFF/XLSB/XLSM/XLSX/XLTM/XLTX/XPS/PNG/JPG/JPEG/GIF/EMF/BMP/MD[Markdown]/Numbers)|
|datasource|String|Query||
|outFormat|String|Query|The format to convert(CSV/XLS/HTML/MHTML/ODS/PDF/XML/TXT/TIFF/XLSB/XLSM/XLSX/XLTM/XLTX/XPS/PNG/JPG/JPEG/GIF/EMF/BMP/MD[Markdown]/Numbers)|
|password|String|Query|The password needed to open an Excel file.|
|checkExcelRestriction|Boolean|Query|Whether check restriction of excel file when user modify cells related objects.|
|region|String|Query|The regional settings for workbook.|


The [OpenAPI Specification](https://reference.aspose.cloud/cells/#/LightCellsController/PostAssemble) defines a publicly accessible programming interface and lets you carry out REST interactions directly from a web browser.
