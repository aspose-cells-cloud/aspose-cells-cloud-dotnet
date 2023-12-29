# **postMetadata API**

Update document properties in Excel file, and save them is various formats. 

```bash

POST http://api.aspose.cloud/v3.0//cells/metadata/update

```

## The request parameters of **postMetadata** API are: 

| Parameter Name | Type | Path/Query String/HTTPBody | Description | 
| :- | :- | :- |:- | 
|File|File|FormData|document properties|
|cellsDocuments|Container|Body|document properties|
|password|String|Query|The password needed to open an Excel file.|
|checkExcelRestriction|Boolean|Query|Whether check restriction of excel file when user modify cells related objects.|
|outFormat|String|Query|The output data file format.(CSV/XLS/HTML/MHTML/ODS/PDF/XML/TXT/TIFF/XLSB/XLSM/XLSX/XLTM/XLTX/XPS/PNG/JPG/JPEG/GIF/EMF/BMP/MD[Markdown]/Numbers)|
|region|String|Query|The regional settings for workbook.|


The [OpenAPI Specification](https://reference.aspose.cloud/cells/#/LightCellsController/PostMetadata) defines a publicly accessible programming interface and lets you carry out REST interactions directly from a web browser.
