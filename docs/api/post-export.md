# **postExport API**

Export Excel internal elements or the workbook itself to various format files. 

```bash

POST http://api.aspose.cloud/v3.0//cells/export

```
Export Excel internal elements or the workbook itself to various format files.

## The request parameters of **postExport** API are: 

| Parameter Name | Type | Path/Query String/HTTPBody | Description | 
| :- | :- | :- |:- | 
|File|File|FormData|File to upload|
|objectType|String|Query|Exported object type:workbook/worksheet/chart/comment/picture/shape/listobject/oleobject.|
|format|String|Query|The conversion format(CSV/XLS/HTML/MHTML/ODS/PDF/XML/TXT/TIFF/XLSB/XLSM/XLSX/XLTM/XLTX/XPS/PNG/JPG/JPEG/GIF/EMF/BMP/MD[Markdown]/Numbers).|
|password|String|Query|The password needed to open an Excel file.|
|checkExcelRestriction|Boolean|Query|Whether check restriction of excel file when user modify cells related objects.|
|region|String|Query|The regional settings for workbook.|
|FontsLocation|String|Query|Use Custom fonts.|


The [OpenAPI Specification](https://reference.aspose.cloud/cells/#/DataProcessingController/PostExport) defines a publicly accessible programming interface and lets you carry out REST interactions directly from a web browser.

<gist "aspose-cells-cloud-gists" "8a5b324fdf3e574dbd747c1a1e24b05d" "Example40_PostExport.cs">

