# **postCompress API**

Compress files and generate target files in various formats, supported file formats are include Xls, Xlsx, Xlsm, Xlsb, Ods and more. 

```bash

POST http://api.aspose.cloud/v3.0//cells/compress

```

## The request parameters of **postCompress** API are: 

| Parameter Name | Type | Path/Query String/HTTPBody | Description | 
| :- | :- | :- |:- | 
|File|File|FormData|Compress level. The compression ratio 1-100.|
|CompressLevel|Integer|Query|Compress level. The compression ratio 1-100.|
|password|String|Query|The password needed to open an Excel file.|
|checkExcelRestriction|Boolean|Query|Whether check restriction of excel file when user modify cells related objects.|


The [OpenAPI Specification](https://reference.aspose.cloud/cells/#/LightCellsController/PostCompress) defines a publicly accessible programming interface and lets you carry out REST interactions directly from a web browser.
