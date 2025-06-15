# **postUnlock API**

Unlock Excel files. 

## **Quick Start**

- **Base URL**: `http://api.aspose.cloud/v3.0`
- **Authentication Method**: `JWT (OAuth2, application)`  **Token URL**: `https://api.aspose.cloud/connect/token`
- **Example Request** 
<script src="https://gist.github.com/aspose-cells-cloud-gists/8a5b324fdf3e574dbd747c1a1e24b05d.js?file=Example30_PostUnlock.cs"></script>

## **Interface Details**

### **Endpoint** 

```
POST http://api.aspose.cloud/v3.0/cells/unlock
```

### **Function Description**
PageTitle: Unlock Excel files.PageDescription: Aspose.Cells Cloud provides robust support for unlocking Excel files.HeadTitle: Unlock Excel files.HeadSummary: Aspose.Cells Cloud provides robust support for unlocking Excel files.HeadContent: Aspose.Cells Cloud provides REST API which supports unlocking Excel files and offers SDKs for multiple programming languages. These programming languages are include of Net, Java, Go, NodeJS, Python, and so on.

### The request parameters of **postUnlock** API are: 

| Parameter Name | Type | Path/Query String/HTTPBody | Description | 
| :- | :- | :- |:- | 
|File|File|FormData|File to upload|
|password|String|Query|The password needed to open an Excel file.|


### **Response Description**
```json
{
  "Name": "FilesResult",
  "Description": [
    "Class features: Weekly lectures, group projects, midterm and final exams, and participation in class discussions."
  ],
  "Type": "Class",
  "IsAbstract": false,
  "Properties": [
    {
      "Name": "Files",
      "Description": [
        "A property named **Files** of type **IList FileInfo ** containing a collection of file information objects."
      ],
      "Nullable": true,
      "ReadOnly": false,
      "IsInherit": false,
      "DataType": {
        "Identifier": "Container",
        "Reference": "FileInfo",
        "ElementDataType": {
          "Identifier": "Class",
          "Reference": "FileInfo",
          "Name": "class:fileinfo"
        },
        "Name": "container"
      }
    }
  ]
}
```

## OpenAPI Specification

The [OpenAPI Specification](https://reference.aspose.cloud/cells/#/ProtectionController/PostUnlock) defines a publicly accessible programming interface and lets you carry out REST interactions directly from a web browser.

