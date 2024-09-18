# **putConvertWorkbook API**

Convert the workbook from the requested content into files in different formats. 

```bash

PUT http://api.aspose.cloud/v3.0//cells/convert

```

## The request parameters of **putConvertWorkbook** API are: 

| Parameter Name | Type | Path/Query String/HTTPBody | Description | 
| :- | :- | :- |:- | 
|File|File|FormData|File to upload|
|format|String|Query|The format to convert(CSV/XLS/HTML/MHTML/ODS/PDF/XML/TXT/TIFF/XLSB/XLSM/XLSX/XLTM/XLTX/XPS/PNG/JPG/JPEG/GIF/EMF/BMP/MD[Markdown]/Numbers).|
|password|String|Query|The password needed to open an Excel file.|
|outPath|String|Query|Path to save the result. If it's a single file, the `outPath` should encompass both the filename and extension. In the case of multiple files, the `outPath` should only include the folder.|
|storageName|String|Query|The storage name where the file is situated.|
|checkExcelRestriction|Boolean|Query|Whether check restriction of excel file when user modify cells related objects.|
|streamFormat|String|Query|The format of the input file stream. |
|region|String|Query|The regional settings for workbook.|
|pageWideFitOnPerSheet|Boolean|Query|The page wide fit on worksheet.|
|pageTallFitOnPerSheet|Boolean|Query|The page tall fit on worksheet.|
|sheetName|String|Query||
|pageIndex|Integer|Query||


The [OpenAPI Specification](https://reference.aspose.cloud/cells/#/ConversionController/PutConvertWorkbook) defines a publicly accessible programming interface and lets you carry out REST interactions directly from a web browser.
