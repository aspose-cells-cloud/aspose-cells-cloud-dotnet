# **getWorksheetOleObject API**

Gets OLE object info or get the OLE object in some format. 

```bash

GET http://api.aspose.cloud/v3.0//cells/{name}/worksheets/{sheetName}/oleobjects/{objectNumber}

```

## The request parameters of **getWorksheetOleObject** API are: 

| Parameter Name | Type | Path/Query String/HTTPBody | Description | 
| :- | :- | :- |:- | 
|name|String|Path|The workbook name.|
|sheetName|String|Path|The worksheet name.|
|objectNumber|Integer|Path|The object number.|
|format|String|Query|Object conversion format(PNG/TIFF/JPEG/GIF/EMF/BMP).|
|folder|String|Query|Original workbook folder.|
|storageName|String|Query|Storage name.|


The [OpenAPI Specification](https://reference.aspose.cloud/cells/#/OleObjectsController/GetWorksheetOleObject) defines a publicly accessible programming interface and lets you carry out REST interactions directly from a web browser.
