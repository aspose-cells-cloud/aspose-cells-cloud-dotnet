# **postHeader API**

Update page header in the worksheet. 

```bash

POST http://api.aspose.cloud/v3.0//cells/{name}/worksheets/{sheetName}/pagesetup/header

```
Update page header in the worksheet.

## The request parameters of **postHeader** API are: 

| Parameter Name | Type | Path/Query String/HTTPBody | Description | 
| :- | :- | :- |:- | 
|name|String|Path|The file name.|
|sheetName|String|Path|The worksheet name.|
|section|Integer|Query|0:Left Section. 1:Center Section 2:Right Section|
|script|String|Query|Header format script.|
|isFirstPage|Boolean|Query|Is first page(true/false).|
|folder|String|Query|The folder where the file is situated.|
|storageName|String|Query|The storage name where the file is situated.|


The [OpenAPI Specification](https://reference.aspose.cloud/cells/#/PageSetupController/PostHeader) defines a publicly accessible programming interface and lets you carry out REST interactions directly from a web browser.

<gist "aspose-cells-cloud-gists" "8a5b324fdf3e574dbd747c1a1e24b05d" "Example40_PostHeader.cs">

