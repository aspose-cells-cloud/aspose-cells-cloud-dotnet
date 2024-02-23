# **postWatermark API**

Add Text Watermark to Excel files and generate output files in various formats. 

```bash

POST http://api.aspose.cloud/v3.0//cells/watermark

```

## The request parameters of **postWatermark** API are: 

| Parameter Name | Type | Path/Query String/HTTPBody | Description | 
| :- | :- | :- |:- | 
|File|File|FormData|File to upload|
|text|String|Query|background text.|
|color|String|Query|e.g. #1032ff|
|outFormat|String|Query|The output data file format.(CSV/XLS/HTML/MHTML/ODS/PDF/XML/TXT/TIFF/XLSB/XLSM/XLSX/XLTM/XLTX/XPS/PNG/JPG/JPEG/GIF/EMF/BMP/MD[Markdown]/Numbers)|
|password|String|Query|The password needed to open an Excel file.|
|checkExcelRestriction|Boolean|Query|Whether check restriction of excel file when user modify cells related objects.|
|region|String|Query|The regional settings for workbook.|


The [OpenAPI Specification](https://reference.aspose.cloud/cells/#/LightCellsController/PostWatermark) defines a publicly accessible programming interface and lets you carry out REST interactions directly from a web browser.
