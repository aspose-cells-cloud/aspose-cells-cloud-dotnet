# **postAutofitWorkbookRows API**

Autofit rows in the workbook. 

```bash

POST http://api.aspose.cloud/v3.0//cells/{name}/autofitrows

```
Autofit rows in the workbook.

## The request parameters of **postAutofitWorkbookRows** API are: 

| Parameter Name | Type | Path/Query String/HTTPBody | Description | 
| :- | :- | :- |:- | 
|name|String|Path|The file name.|
|startRow|Integer|Query|Start row.|
|endRow|Integer|Query|End row.|
|onlyAuto|Boolean|Query|Only auto.|
|folder|String|Query|The folder where the file is situated.|
|storageName|String|Query|The storage name where the file is situated.|
|firstColumn|Integer|Query||
|lastColumn|Integer|Query||


The [OpenAPI Specification](https://reference.aspose.cloud/cells/#/WorkbookController/PostAutofitWorkbookRows) defines a publicly accessible programming interface and lets you carry out REST interactions directly from a web browser.

<gist "aspose-cells-cloud-gists" "8a5b324fdf3e574dbd747c1a1e24b05d" "Example40_PostAutofitWorkbookRows.cs">

