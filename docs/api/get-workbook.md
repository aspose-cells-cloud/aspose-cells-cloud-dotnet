# **getWorkbook API**

Exports workbook to some format. 

```bash

GET http://api.aspose.cloud/v3.0//cells/{name}

```

## The request parameters of **getWorkbook** API are: 

| Parameter Name | Type | Path/Query String/HTTPBody | Description | 
| :- | :- | :- |:- | 
|name|String|Path|The workbook name.|
|format|String|Query|The conversion format(CSV/XLS/HTML/MHTML/ODS/PDF/XML/TXT/TIFF/XLSB/XLSM/XLSX/XLTM/XLTX/XPS/PNG/JPG/JPEG/GIF/EMF/BMP/MD[Markdown]/Numbers).|
|password|String|Query|The excel password.|
|isAutoFit|Boolean|Query|Specifies whether set workbook rows to be autofit.|
|onlySaveTable|Boolean|Query|Specifies whether only save table data.Only use pdf to excel.|
|folder|String|Query|Original workbook folder.|
|outPath|String|Query|Path to save result|
|storageName|String|Query|Storage name.|
|outStorageName|String|Query|Storage name.|
|checkExcelRestriction|Boolean|Query||


The [OpenAPI Specification](https://reference.aspose.cloud/cells/#/ConversionController/GetWorkbook) defines a publicly accessible programming interface and lets you carry out REST interactions directly from a web browser.
