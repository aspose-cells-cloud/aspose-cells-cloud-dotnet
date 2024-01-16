# **postWorksheetSparklineGroup API**

Update a sparkline group in the worksheet. 

```bash

POST http://api.aspose.cloud/v3.0//cells/{name}/worksheets/{sheetName}/sparklineGroups/{sparklineGroupIndex}

```

## The request parameters of **postWorksheetSparklineGroup** API are: 

| Parameter Name | Type | Path/Query String/HTTPBody | Description | 
| :- | :- | :- |:- | 
|name|String|Path|The file name.|
|sheetName|String|Path|The worksheet name.|
|sparklineGroupIndex|Integer|Path|The zero based index of the element.|
|sparklineGroup|Class|Body|Spark line group description.|
|folder|String|Query|The folder where the file is situated.|
|storageName|String|Query|The storage name where the file is situated.|


The [OpenAPI Specification](https://reference.aspose.cloud/cells/#/SparklineGroupsController/PostWorksheetSparklineGroup) defines a publicly accessible programming interface and lets you carry out REST interactions directly from a web browser.
