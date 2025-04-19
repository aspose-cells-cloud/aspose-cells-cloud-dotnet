# **postImportData API**

Import data into the Excel file. 

```bash

POST http://api.aspose.cloud/v3.0//cells/{name}/importdata

```

## The request parameters of **postImportData** API are: 

| Parameter Name | Type | Path/Query String/HTTPBody | Description | 
| :- | :- | :- |:- | 
|name|String|Path|The file name.|
|importOption|Class|Body|Import option. They are include of ImportCSVDataOption, ImportBatchDataOption, ImportPictureOption, ImportStringArrayOption, Import2DimensionStringArrayOption, and so on.  |
|folder|String|Query|The folder where the file is situated.|
|storageName|String|Query|The storage name where the file is situated.|
|region|String|Query|The regional settings for workbook.|
|FontsLocation|String|Query|Use Custom fonts.|


The [OpenAPI Specification](https://reference.aspose.cloud/cells/#/DataProcessingController/PostImportData) defines a publicly accessible programming interface and lets you carry out REST interactions directly from a web browser.
