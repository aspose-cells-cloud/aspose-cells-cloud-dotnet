# **getMetadata API**

Get cells document properties. 

```bash

POST http://api.aspose.cloud/v3.0//cells/metadata/get

```
Get cells document properties.

## The request parameters of **getMetadata** API are: 

| Parameter Name | Type | Path/Query String/HTTPBody | Description | 
| :- | :- | :- |:- | 
|File|File|FormData|File to upload|
|type|String|Query|Cells document property name.|
|password|String|Query|The password needed to open an Excel file.|
|checkExcelRestriction|Boolean|Query|Whether check restriction of excel file when user modify cells related objects.|


The [OpenAPI Specification](https://reference.aspose.cloud/cells/#/LightCellsController/GetMetadata) defines a publicly accessible programming interface and lets you carry out REST interactions directly from a web browser.

<gist "aspose-cells-cloud-gists" "8a5b324fdf3e574dbd747c1a1e24b05d" "Example40_GetMetadata.cs">

