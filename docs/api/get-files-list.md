# **Spreadsheet Cloud API: getFilesList**

 

## **Quick Start**

- **Base URL**: `http://api.aspose.cloud/v4.0`
- **Authentication Method**: `JWT (OAuth2, application)`  **Token URL**: `https://api.aspose.cloud/connect/token`
- **Example** 
<script src="https://gist.github.com/aspose-cells-cloud-gists/8a5b324fdf3e574dbd747c1a1e24b05d.js?file=Example40_GetFilesList.cs"></script>

## **Interface Details**

### **Endpoint** 

```
GET http://api.aspose.cloud/v4.0/cells/storage/folder/{path}
```

### **Function Description**

### The request parameters of **getFilesList** API are: 

| Parameter Name | Type | Path/Query String/HTTPBody | Description | 
| :- | :- | :- |:- | 
|path|String|Path||
|storageName|String|Query||


### **Response Description**
```json
{
  "Name": "FilesList",
  "Description": [
    "Files list"
  ],
  "Type": "Class",
  "IsAbstract": false,
  "Properties": [
    {
      "Name": "Value",
      "Description": [
        "Files and folders contained by folder StorageFile."
      ],
      "Nullable": true,
      "ReadOnly": false,
      "IsInherit": false,
      "DataType": {
        "Identifier": "Container",
        "Reference": "StorageFile",
        "ElementDataType": {
          "Identifier": "Class",
          "Reference": "StorageFile",
          "Name": "class:storagefile"
        },
        "Name": "container"
      }
    }
  ]
}
```

## OpenAPI Specification

The [OpenAPI Specification](https://reference.aspose.cloud/cells/#/FolderController/GetFilesList) defines a publicly accessible programming interface and lets you carry out REST interactions directly from a web browser.

