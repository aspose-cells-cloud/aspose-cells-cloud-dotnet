# **getWorksheetWithFormat API**

Gets worksheet in some format. 

```bash

GET http://api.aspose.cloud/v3.0//cells/{name}/worksheets/{sheetName}

```

## The request parameters of **getWorksheetWithFormat** API are: 

| Parameter Name | Type | Path/Query String/HTTPBody | Description | 
| :- | :- | :- |:- | 
|name|String|Path|The workbook name.|
|sheetName|String|Path|The worksheet name.|
|format|String|Query|Export format(CSV/XLS/HTML/MHTML/ODS/PDF/XML/TXT/TIFF/XLSB/XLSM/XLSX/XLTM/XLTX/XPS/PNG/JPG/JPEG/GIF/EMF/BMP/MD[Markdown]/Numbers).|
|verticalResolution|Integer|Query|Image vertical resolution.|
|horizontalResolution|Integer|Query|Image horizontal resolution.|
|area|String|Query|Represents the range to be printed.|
|pageIndex|Integer|Query|Represents the page to be printed|
|folder|String|Query|Original workbook folder.|
|storageName|String|Query|Storage name.|


The [OpenAPI Specification](https://reference.aspose.cloud/cells/#/WorksheetsController/GetWorksheetWithFormat) defines a publicly accessible programming interface and lets you carry out REST interactions directly from a web browser.
