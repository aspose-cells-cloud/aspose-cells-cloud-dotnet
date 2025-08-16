# **Spreadsheet Cloud API: createSpreadsheet**

The Web API allows users to create a new spreadsheet with a specified name. Optionally, a template can be provided to initialize the spreadsheet with predefined content or formatting. 

## **Quick Start**

- **Base URL**: `http://api.aspose.cloud/v4.0`
- **Authentication Method**: `JWT (OAuth2, application)`  **Token URL**: `https://api.aspose.cloud/connect/token`
- **Example** 
<script src="https://gist.github.com/aspose-cells-cloud-gists/8a5b324fdf3e574dbd747c1a1e24b05d.js?file=Example40_CreateSpreadsheet.cs"></script>

## **Interface Details**

### **Endpoint** 

```
PUT http://api.aspose.cloud/v4.0/cells/spreadsheet/create
```

### **Function Description**
By using the CreateSpreadsheet function, you can quickly set up new spreadsheets with or without templates, streamlining your workflow and enhancing productivity.**Considerations**: Ensure that the provided name is unique to avoid conflicts with existing spreadsheets. If using a template, ensure that the template file is accessible and correctly formatted.**Error Handling**: If the name is not provided or is invalid, the function may throw an exception or return an error message. If the template file is specified but cannot be found or is corrupted, the function may also throw an exception or return an error message.

### The request parameters of **createSpreadsheet** API are: 

| Parameter Name | Type | Path/Query String/HTTPBody | Description | 
| :- | :- | :- |:- | 
|format|String|Query|Specifies the name of the new spreadsheet. This name will be used to identify the spreadsheet in the system.|
|template|String|Query|template: Optional.If provided, the new spreadsheet will be created based on the specified template.This can be useful for applying predefined layouts and styles.|
|outPath|String|Query|(Optional) The folder path where the workbook is stored. The default is null.|
|outStorageName|String|Query|Output file Storage Name.|
|regoin|String|Query|The spreadsheet region setting.|
|password|String|Query|The password for opening spreadsheet file.|


### **Response Description**
```json
{
File
}
```

## OpenAPI Specification

The [OpenAPI Specification](https://reference.aspose.cloud/cells/#/ManagementController/CreateSpreadsheet) defines a publicly accessible programming interface and lets you carry out REST interactions directly from a web browser.

