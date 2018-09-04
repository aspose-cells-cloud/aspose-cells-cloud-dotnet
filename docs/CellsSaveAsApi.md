# Aspose.Cells.Cloud.SDK.Api.CellsSaveAsApi

All URIs are relative to *https://api.aspose.cloud/v1.1/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CellsSaveAsPostDocumentSaveAs**](CellsSaveAsApi.md#cellssaveaspostdocumentsaveas) | **POST** /cells/{name}/SaveAs | Convert document and save result to storage.


<a name="cellssaveaspostdocumentsaveas"></a>
# **CellsSaveAsPostDocumentSaveAs**
> SaveResponse CellsSaveAsPostDocumentSaveAs (string name, SaveOptions saveOptions = null, string newfilename = null, bool? isAutoFitRows = null, bool? isAutoFitColumns = null, string folder = null, string storage = null)

Convert document and save result to storage.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsSaveAsPostDocumentSaveAsExample
    {
        public void main()
        {
            var apiInstance = new CellsSaveAsApi();
            var name = name_example;  // string | The document name.
            var saveOptions = new SaveOptions(); // SaveOptions | Save options. (optional) 
            var newfilename = newfilename_example;  // string | The new file name. (optional) 
            var isAutoFitRows = true;  // bool? | Autofit rows. (optional)  (default to false)
            var isAutoFitColumns = true;  // bool? | Autofit columns. (optional)  (default to false)
            var folder = folder_example;  // string | The document folder. (optional) 
            var storage = storage_example;  // string | storage name. (optional) 

            try
            {
                // Convert document and save result to storage.
                SaveResponse result = apiInstance.CellsSaveAsPostDocumentSaveAs(name, saveOptions, newfilename, isAutoFitRows, isAutoFitColumns, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsSaveAsApi.CellsSaveAsPostDocumentSaveAs: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **saveOptions** | [**SaveOptions**](SaveOptions.md)| Save options. | [optional] 
 **newfilename** | **string**| The new file name. | [optional] 
 **isAutoFitRows** | **bool?**| Autofit rows. | [optional] [default to false]
 **isAutoFitColumns** | **bool?**| Autofit columns. | [optional] [default to false]
 **folder** | **string**| The document folder. | [optional] 
 **storage** | **string**| storage name. | [optional] 

### Return type

[**SaveResponse**](SaveResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

