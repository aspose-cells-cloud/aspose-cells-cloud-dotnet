# **postWorksheetChartTitle API**

Update chart title in the worksheet. 

```bash

POST http://api.aspose.cloud/v3.0//cells/{name}/worksheets/{sheetName}/charts/{chartIndex}/title

```
Update chart title in the worksheet.

## The request parameters of **postWorksheetChartTitle** API are: 

| Parameter Name | Type | Path/Query String/HTTPBody | Description | 
| :- | :- | :- |:- | 
|name|String|Path|The file name.|
|sheetName|String|Path|The worksheet name.|
|chartIndex|Integer|Path|The chart index.|
|title|Class|Body|TitleChart title|
|folder|String|Query|The folder where the file is situated.|
|storageName|String|Query|The storage name where the file is situated.|


The [OpenAPI Specification](https://reference.aspose.cloud/cells/#/ChartsController/PostWorksheetChartTitle) defines a publicly accessible programming interface and lets you carry out REST interactions directly from a web browser.

<gist "aspose-cells-cloud-gists" "8a5b324fdf3e574dbd747c1a1e24b05d" "Example40_PostWorksheetChartTitle.cs">

