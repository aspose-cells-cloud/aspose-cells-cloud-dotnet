# **postWorkbookExportXML API**

Export XML data from an Excel file.When there are XML Maps in an Excel file, export XML data. When there is no XML map in the Excel file, convert the Excel file to an XML file. 

```bash

POST http://api.aspose.cloud/v3.0//cells/{name}/exportxml

```
Export XML data from an Excel file.When there are XML Maps in an Excel file, export XML data. When there is no XML map in the Excel file, convert the Excel file to an XML file.

## The request parameters of **postWorkbookExportXML** API are: 

| Parameter Name | Type | Path/Query String/HTTPBody | Description | 
| :- | :- | :- |:- | 
|name|String|Path|The file name.|
|password|String|Query|The password needed to open an Excel file.|
|folder|String|Query|The folder where the file is situated.|
|storageName|String|Query|The storage name where the file is situated.|
|outPath|String|Query|Path to save the result. If it's a single file, the `outPath` should encompass both the filename and extension. In the case of multiple files, the `outPath` should only include the folder.|
|outStorageName|String|Query|The storage name where the output file is situated.|
|checkExcelRestriction|Boolean|Query|Whether check restriction of excel file when user modify cells related objects.|
|region|String|Query|The regional settings for workbook.|


The [OpenAPI Specification](https://reference.aspose.cloud/cells/#/DataProcessingController/PostWorkbookExportXML) defines a publicly accessible programming interface and lets you carry out REST interactions directly from a web browser.

<gist "aspose-cells-cloud-gists" "8a5b324fdf3e574dbd747c1a1e24b05d" "Example40_PostWorkbookExportXML.cs">

