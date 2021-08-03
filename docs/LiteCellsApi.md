# Aspose.Cells.Cloud.SDK.Api.LiteCellsApi

All URIs are relative to *https://api.aspose.cloud/v3.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteMetadata**](LiteCellsApi.md#deletemetadata) | **POST** /cells/metadata/delete | 
[**GetMetadata**](LiteCellsApi.md#getmetadata) | **POST** /cells/metadata/get | 
[**PostAssemble**](LiteCellsApi.md#postassemble) | **POST** /cells/assemble | 
[**PostClearObjects**](LiteCellsApi.md#postclearobjects) | **POST** /cells/clearobjects | 
[**PostExport**](LiteCellsApi.md#postexport) | **POST** /cells/export | 
[**PostMerge**](LiteCellsApi.md#postmerge) | **POST** /cells/merge | 
[**PostMetadata**](LiteCellsApi.md#postmetadata) | **POST** /cells/metadata/update | 
[**PostProtect**](LiteCellsApi.md#postprotect) | **POST** /cells/protect | 
[**PostSearch**](LiteCellsApi.md#postsearch) | **POST** /cells/search | 
[**PostSplit**](LiteCellsApi.md#postsplit) | **POST** /cells/split | 
[**PostUnlock**](LiteCellsApi.md#postunlock) | **POST** /cells/unlock | 
[**PostWatermark**](LiteCellsApi.md#postwatermark) | **POST** /cells/watermark | 


<a name="deletemetadata"></a>
# **DeleteMetadata**
> FilesResult DeleteMetadata (System.IO.Stream file, string type = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class DeleteMetadataExample
    {
        public void main()
        {
            var apiInstance = new LiteCellsApi();
            var file = new System.IO.Stream(); // System.IO.Stream | File to upload
            var type = type_example;  // string |  (optional)  (default to all)

            try
            {
                FilesResult result = apiInstance.DeleteMetadata(file, type);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LiteCellsApi.DeleteMetadata: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **file** | **System.IO.Stream**| File to upload | 
 **type** | **string**|  | [optional] [default to all]

### Return type

[**FilesResult**](FilesResult.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmetadata"></a>
# **GetMetadata**
> List<CellsDocumentProperty> GetMetadata (System.IO.Stream file, string type = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class GetMetadataExample
    {
        public void main()
        {
            var apiInstance = new LiteCellsApi();
            var file = new System.IO.Stream(); // System.IO.Stream | File to upload
            var type = type_example;  // string |  (optional)  (default to all)

            try
            {
                List&lt;CellsDocumentProperty&gt; result = apiInstance.GetMetadata(file, type);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LiteCellsApi.GetMetadata: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **file** | **System.IO.Stream**| File to upload | 
 **type** | **string**|  | [optional] [default to all]

### Return type

[**List<CellsDocumentProperty>**](CellsDocumentProperty.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postassemble"></a>
# **PostAssemble**
> FilesResult PostAssemble (System.IO.Stream file, string datasource, string format = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class PostAssembleExample
    {
        public void main()
        {
            var apiInstance = new LiteCellsApi();
            var file = new System.IO.Stream(); // System.IO.Stream | File to upload
            var datasource = datasource_example;  // string | 
            var format = format_example;  // string |  (optional)  (default to Xlsx)

            try
            {
                FilesResult result = apiInstance.PostAssemble(file, datasource, format);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LiteCellsApi.PostAssemble: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **file** | **System.IO.Stream**| File to upload | 
 **datasource** | **string**|  | 
 **format** | **string**|  | [optional] [default to Xlsx]

### Return type

[**FilesResult**](FilesResult.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postclearobjects"></a>
# **PostClearObjects**
> FilesResult PostClearObjects (System.IO.Stream file, string objecttype)



### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class PostClearObjectsExample
    {
        public void main()
        {
            var apiInstance = new LiteCellsApi();
            var file = new System.IO.Stream(); // System.IO.Stream | File to upload
            var objecttype = objecttype_example;  // string | 

            try
            {
                FilesResult result = apiInstance.PostClearObjects(file, objecttype);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LiteCellsApi.PostClearObjects: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **file** | **System.IO.Stream**| File to upload | 
 **objecttype** | **string**|  | 

### Return type

[**FilesResult**](FilesResult.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postexport"></a>
# **PostExport**
> FilesResult PostExport (System.IO.Stream file, string objectType, string format)



### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class PostExportExample
    {
        public void main()
        {
            var apiInstance = new LiteCellsApi();
            var file = new System.IO.Stream(); // System.IO.Stream | File to upload
            var objectType = objectType_example;  // string | 
            var format = format_example;  // string | 

            try
            {
                FilesResult result = apiInstance.PostExport(file, objectType, format);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LiteCellsApi.PostExport: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **file** | **System.IO.Stream**| File to upload | 
 **objectType** | **string**|  | 
 **format** | **string**|  | 

### Return type

[**FilesResult**](FilesResult.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postmerge"></a>
# **PostMerge**
> FileInfo PostMerge (System.IO.Stream file, string format = null, bool? mergeToOneSheet = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class PostMergeExample
    {
        public void main()
        {
            var apiInstance = new LiteCellsApi();
            var file = new System.IO.Stream(); // System.IO.Stream | File to upload
            var format = format_example;  // string |  (optional)  (default to xlsx)
            var mergeToOneSheet = true;  // bool? |  (optional)  (default to false)

            try
            {
                FileInfo result = apiInstance.PostMerge(file, format, mergeToOneSheet);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LiteCellsApi.PostMerge: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **file** | **System.IO.Stream**| File to upload | 
 **format** | **string**|  | [optional] [default to xlsx]
 **mergeToOneSheet** | **bool?**|  | [optional] [default to false]

### Return type

[**FileInfo**](FileInfo.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postmetadata"></a>
# **PostMetadata**
> FilesResult PostMetadata (System.IO.Stream file, CellsDocumentProperty documentProperties)



### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class PostMetadataExample
    {
        public void main()
        {
            var apiInstance = new LiteCellsApi();
            var file = new System.IO.Stream(); // System.IO.Stream | File to upload
            var documentProperties = new CellsDocumentProperty(); // CellsDocumentProperty | Cells document property.

            try
            {
                FilesResult result = apiInstance.PostMetadata(file, documentProperties);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LiteCellsApi.PostMetadata: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **file** | **System.IO.Stream**| File to upload | 
 **documentProperties** | [**CellsDocumentProperty**](CellsDocumentProperty.md)| Cells document property. | 

### Return type

[**FilesResult**](FilesResult.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postprotect"></a>
# **PostProtect**
> FilesResult PostProtect (System.IO.Stream file, string password)



### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class PostProtectExample
    {
        public void main()
        {
            var apiInstance = new LiteCellsApi();
            var file = new System.IO.Stream(); // System.IO.Stream | File to upload
            var password = password_example;  // string | 

            try
            {
                FilesResult result = apiInstance.PostProtect(file, password);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LiteCellsApi.PostProtect: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **file** | **System.IO.Stream**| File to upload | 
 **password** | **string**|  | 

### Return type

[**FilesResult**](FilesResult.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postsearch"></a>
# **PostSearch**
> List<TextItem> PostSearch (System.IO.Stream file, string text, string password = null, string sheetname = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class PostSearchExample
    {
        public void main()
        {
            var apiInstance = new LiteCellsApi();
            var file = new System.IO.Stream(); // System.IO.Stream | File to upload
            var text = text_example;  // string | 
            var password = password_example;  // string |  (optional) 
            var sheetname = sheetname_example;  // string |  (optional) 

            try
            {
                List&lt;TextItem&gt; result = apiInstance.PostSearch(file, text, password, sheetname);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LiteCellsApi.PostSearch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **file** | **System.IO.Stream**| File to upload | 
 **text** | **string**|  | 
 **password** | **string**|  | [optional] 
 **sheetname** | **string**|  | [optional] 

### Return type

[**List<TextItem>**](TextItem.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postsplit"></a>
# **PostSplit**
> FilesResult PostSplit (System.IO.Stream file, string format, string password = null, int? from = null, int? to = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class PostSplitExample
    {
        public void main()
        {
            var apiInstance = new LiteCellsApi();
            var file = new System.IO.Stream(); // System.IO.Stream | File to upload
            var format = format_example;  // string | 
            var password = password_example;  // string |  (optional) 
            var from = 56;  // int? |  (optional) 
            var to = 56;  // int? |  (optional) 

            try
            {
                FilesResult result = apiInstance.PostSplit(file, format, password, from, to);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LiteCellsApi.PostSplit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **file** | **System.IO.Stream**| File to upload | 
 **format** | **string**|  | 
 **password** | **string**|  | [optional] 
 **from** | **int?**|  | [optional] 
 **to** | **int?**|  | [optional] 

### Return type

[**FilesResult**](FilesResult.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postunlock"></a>
# **PostUnlock**
> FilesResult PostUnlock (System.IO.Stream file, string password)



### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class PostUnlockExample
    {
        public void main()
        {
            var apiInstance = new LiteCellsApi();
            var file = new System.IO.Stream(); // System.IO.Stream | File to upload
            var password = password_example;  // string | 

            try
            {
                FilesResult result = apiInstance.PostUnlock(file, password);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LiteCellsApi.PostUnlock: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **file** | **System.IO.Stream**| File to upload | 
 **password** | **string**|  | 

### Return type

[**FilesResult**](FilesResult.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postwatermark"></a>
# **PostWatermark**
> FilesResult PostWatermark (System.IO.Stream file, string text, string color)



### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class PostWatermarkExample
    {
        public void main()
        {
            var apiInstance = new LiteCellsApi();
            var file = new System.IO.Stream(); // System.IO.Stream | File to upload
            var text = text_example;  // string | 
            var color = color_example;  // string | 

            try
            {
                FilesResult result = apiInstance.PostWatermark(file, text, color);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LiteCellsApi.PostWatermark: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **file** | **System.IO.Stream**| File to upload | 
 **text** | **string**|  | 
 **color** | **string**|  | 

### Return type

[**FilesResult**](FilesResult.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

