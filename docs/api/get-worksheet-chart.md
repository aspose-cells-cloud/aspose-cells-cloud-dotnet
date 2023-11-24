# **getWorksheetChart API**

Gets chart in some format. 

```bash

GET http://api.aspose.cloud/v3.0//cells/{name}/worksheets/{sheetName}/charts/{chartNumber}

```

## The request parameters of **getWorksheetChart** API are: 

| Parameter Name | Type | Path/Query String/HTTPBody | Description | 
| :- | :- | :- |:- | 
|name|String|Path|The workbook name.|
|sheetName|String|Path|The worksheet name.|
|chartNumber|Integer|Path|The chart number.|
|format|String|Query|Chart conversion format.(PNG/TIFF/JPEG/GIF/EMF/BMP)|
|folder|String|Query|Original workbook folder.|
|storageName|String|Query|Storage name.|


The [OpenAPI Specification](https://reference.aspose.cloud/cells/#/ChartsController/GetWorksheetChart) defines a publicly accessible programming interface and lets you carry out REST interactions directly from a web browser.
