# **postWorksheetValidation API**

Update a validation by index in the worksheet. 

```bash

POST http://api.aspose.cloud/v3.0//cells/{name}/worksheets/{sheetName}/validations/{validationIndex}

```

## The request parameters of **postWorksheetValidation** API are: 

| Parameter Name | Type | Path/Query String/HTTPBody | Description | 
| :- | :- | :- |:- | 
|name|String|Path|The workbook name.|
|sheetName|String|Path|The worksheet name.|
|validationIndex|Integer|Path|The validation index.|
|validation|Class|Body|Validation description.|
|folder|String|Query|The folder where the file is situated.|
|storageName|String|Query|The storage name where the file is situated.|


The [OpenAPI Specification](https://reference.aspose.cloud/cells/#/WorksheetValidationsController/PostWorksheetValidation) defines a publicly accessible programming interface and lets you carry out REST interactions directly from a web browser.
