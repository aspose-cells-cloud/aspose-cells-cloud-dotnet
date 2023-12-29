# **postWorksheetChart API**

Update chart properties in the worksheet. 

```bash

POST http://api.aspose.cloud/v3.0//cells/{name}/worksheets/{sheetName}/charts/{chartIndex}

```

## The request parameters of **postWorksheetChart** API are: 

| Parameter Name | Type | Path/Query String/HTTPBody | Description | 
| :- | :- | :- |:- | 
|name|String|Path|The file name.|
|sheetName|String|Path|The worksheet name.|
|chartIndex|Integer|Path|The chart index.|
|chart|Class|Body|Chart Represents a specified chart.|
|folder|String|Query|The folder where the file is situated.|
|storageName|String|Query|The storage name where the file is situated.|


The [OpenAPI Specification](https://reference.aspose.cloud/cells/#/ChartsController/PostWorksheetChart) defines a publicly accessible programming interface and lets you carry out REST interactions directly from a web browser.
