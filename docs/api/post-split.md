# **postSplit API**

Split Excel spreadsheet files by worksheet, save as kinds of format files. 

```bash

POST http://api.aspose.cloud/v3.0//cells/split

```

## The request parameters of **postSplit** API are: 

| Parameter Name | Type | Path/Query String/HTTPBody | Description | 
| :- | :- | :- |:- | 
|File|File|FormData|The format to convert(CSV/XLS/HTML/MHTML/ODS/PDF/XML/TXT/TIFF/XLSB/XLSM/XLSX/XLTM/XLTX/XPS/PNG/JPG/JPEG/GIF/EMF/BMP/MD[Markdown]/Numbers)|
|format|String|Query|The format to convert(CSV/XLS/HTML/MHTML/ODS/PDF/XML/TXT/TIFF/XLSB/XLSM/XLSX/XLTM/XLTX/XPS/PNG/JPG/JPEG/GIF/EMF/BMP/MD[Markdown]/Numbers)|
|password|String|Query||
|from|Integer|Query|sheet index|
|to|Integer|Query|sheet index|
|checkExcelRestriction|Boolean|Query||


The [OpenAPI Specification](https://reference.aspose.cloud/cells/#/LightCellsController/PostSplit) defines a publicly accessible programming interface and lets you carry out REST interactions directly from a web browser.
