# Aspose.Cells.Cloud.SDK.Api.CellsHypelinksApi

All URIs are relative to *https://api.aspose.cloud/v1.1/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CellsHypelinksDeleteWorksheetHyperlink**](CellsHypelinksApi.md#cellshypelinksdeleteworksheethyperlink) | **DELETE** /cells/{name}/worksheets/{sheetName}/hyperlinks/{hyperlinkIndex} | Delete worksheet hyperlink by index.
[**CellsHypelinksDeleteWorksheetHyperlinks**](CellsHypelinksApi.md#cellshypelinksdeleteworksheethyperlinks) | **DELETE** /cells/{name}/worksheets/{sheetName}/hyperlinks | Delete all hyperlinks in worksheet.
[**CellsHypelinksGetWorksheetHyperlink**](CellsHypelinksApi.md#cellshypelinksgetworksheethyperlink) | **GET** /cells/{name}/worksheets/{sheetName}/hyperlinks/{hyperlinkIndex} | Get worksheet hyperlink by index.
[**CellsHypelinksGetWorksheetHyperlinks**](CellsHypelinksApi.md#cellshypelinksgetworksheethyperlinks) | **GET** /cells/{name}/worksheets/{sheetName}/hyperlinks | Get worksheet hyperlinks.
[**CellsHypelinksPostWorksheetHyperlink**](CellsHypelinksApi.md#cellshypelinkspostworksheethyperlink) | **POST** /cells/{name}/worksheets/{sheetName}/hyperlinks/{hyperlinkIndex} | Update worksheet hyperlink by index.
[**CellsHypelinksPutWorksheetHyperlink**](CellsHypelinksApi.md#cellshypelinksputworksheethyperlink) | **PUT** /cells/{name}/worksheets/{sheetName}/hyperlinks | Add worksheet hyperlink.


<a name="cellshypelinksdeleteworksheethyperlink"></a>
# **CellsHypelinksDeleteWorksheetHyperlink**
> SaaSposeResponse CellsHypelinksDeleteWorksheetHyperlink (string name, string sheetName, int? hyperlinkIndex, string folder = null, string storage = null)

Delete worksheet hyperlink by index.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsHypelinksDeleteWorksheetHyperlinkExample
    {
        public void main()
        {
            var apiInstance = new CellsHypelinksApi();
            var name = name_example;  // string | Document name.
            var sheetName = sheetName_example;  // string | Worksheet name.
            var hyperlinkIndex = 56;  // int? | The hyperlink's index.
            var folder = folder_example;  // string | The document folder. (optional) 
            var storage = storage_example;  // string | storage name. (optional) 

            try
            {
                // Delete worksheet hyperlink by index.
                SaaSposeResponse result = apiInstance.CellsHypelinksDeleteWorksheetHyperlink(name, sheetName, hyperlinkIndex, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsHypelinksApi.CellsHypelinksDeleteWorksheetHyperlink: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Document name. | 
 **sheetName** | **string**| Worksheet name. | 
 **hyperlinkIndex** | **int?**| The hyperlink&#39;s index. | 
 **folder** | **string**| The document folder. | [optional] 
 **storage** | **string**| storage name. | [optional] 

### Return type

[**SaaSposeResponse**](SaaSposeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellshypelinksdeleteworksheethyperlinks"></a>
# **CellsHypelinksDeleteWorksheetHyperlinks**
> SaaSposeResponse CellsHypelinksDeleteWorksheetHyperlinks (string name, string sheetName, string folder = null, string storage = null)

Delete all hyperlinks in worksheet.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsHypelinksDeleteWorksheetHyperlinksExample
    {
        public void main()
        {
            var apiInstance = new CellsHypelinksApi();
            var name = name_example;  // string | Document name.
            var sheetName = sheetName_example;  // string | Worksheet name.
            var folder = folder_example;  // string | The document folder. (optional) 
            var storage = storage_example;  // string | storage name. (optional) 

            try
            {
                // Delete all hyperlinks in worksheet.
                SaaSposeResponse result = apiInstance.CellsHypelinksDeleteWorksheetHyperlinks(name, sheetName, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsHypelinksApi.CellsHypelinksDeleteWorksheetHyperlinks: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Document name. | 
 **sheetName** | **string**| Worksheet name. | 
 **folder** | **string**| The document folder. | [optional] 
 **storage** | **string**| storage name. | [optional] 

### Return type

[**SaaSposeResponse**](SaaSposeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellshypelinksgetworksheethyperlink"></a>
# **CellsHypelinksGetWorksheetHyperlink**
> HyperlinkResponse CellsHypelinksGetWorksheetHyperlink (string name, string sheetName, int? hyperlinkIndex, string folder = null, string storage = null)

Get worksheet hyperlink by index.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsHypelinksGetWorksheetHyperlinkExample
    {
        public void main()
        {
            var apiInstance = new CellsHypelinksApi();
            var name = name_example;  // string | Document name.
            var sheetName = sheetName_example;  // string | Worksheet name.
            var hyperlinkIndex = 56;  // int? | The hyperlink's index.
            var folder = folder_example;  // string | The document folder. (optional) 
            var storage = storage_example;  // string | storage name. (optional) 

            try
            {
                // Get worksheet hyperlink by index.
                HyperlinkResponse result = apiInstance.CellsHypelinksGetWorksheetHyperlink(name, sheetName, hyperlinkIndex, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsHypelinksApi.CellsHypelinksGetWorksheetHyperlink: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Document name. | 
 **sheetName** | **string**| Worksheet name. | 
 **hyperlinkIndex** | **int?**| The hyperlink&#39;s index. | 
 **folder** | **string**| The document folder. | [optional] 
 **storage** | **string**| storage name. | [optional] 

### Return type

[**HyperlinkResponse**](HyperlinkResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellshypelinksgetworksheethyperlinks"></a>
# **CellsHypelinksGetWorksheetHyperlinks**
> HyperlinksResponse CellsHypelinksGetWorksheetHyperlinks (string name, string sheetName, string folder = null, string storage = null)

Get worksheet hyperlinks.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsHypelinksGetWorksheetHyperlinksExample
    {
        public void main()
        {
            var apiInstance = new CellsHypelinksApi();
            var name = name_example;  // string | Document name.
            var sheetName = sheetName_example;  // string | The worksheet name.
            var folder = folder_example;  // string | Document's folder. (optional) 
            var storage = storage_example;  // string | storage name. (optional) 

            try
            {
                // Get worksheet hyperlinks.
                HyperlinksResponse result = apiInstance.CellsHypelinksGetWorksheetHyperlinks(name, sheetName, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsHypelinksApi.CellsHypelinksGetWorksheetHyperlinks: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Document name. | 
 **sheetName** | **string**| The worksheet name. | 
 **folder** | **string**| Document&#39;s folder. | [optional] 
 **storage** | **string**| storage name. | [optional] 

### Return type

[**HyperlinksResponse**](HyperlinksResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellshypelinkspostworksheethyperlink"></a>
# **CellsHypelinksPostWorksheetHyperlink**
> HyperlinkResponse CellsHypelinksPostWorksheetHyperlink (string name, string sheetName, int? hyperlinkIndex, Hyperlink hyperlink = null, string folder = null, string storage = null)

Update worksheet hyperlink by index.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsHypelinksPostWorksheetHyperlinkExample
    {
        public void main()
        {
            var apiInstance = new CellsHypelinksApi();
            var name = name_example;  // string | Document name.
            var sheetName = sheetName_example;  // string | Worksheet name.
            var hyperlinkIndex = 56;  // int? | The hyperlink's index.
            var hyperlink = new Hyperlink(); // Hyperlink | Hyperlink object (optional) 
            var folder = folder_example;  // string | The document folder. (optional) 
            var storage = storage_example;  // string | storage name. (optional) 

            try
            {
                // Update worksheet hyperlink by index.
                HyperlinkResponse result = apiInstance.CellsHypelinksPostWorksheetHyperlink(name, sheetName, hyperlinkIndex, hyperlink, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsHypelinksApi.CellsHypelinksPostWorksheetHyperlink: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Document name. | 
 **sheetName** | **string**| Worksheet name. | 
 **hyperlinkIndex** | **int?**| The hyperlink&#39;s index. | 
 **hyperlink** | [**Hyperlink**](Hyperlink.md)| Hyperlink object | [optional] 
 **folder** | **string**| The document folder. | [optional] 
 **storage** | **string**| storage name. | [optional] 

### Return type

[**HyperlinkResponse**](HyperlinkResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellshypelinksputworksheethyperlink"></a>
# **CellsHypelinksPutWorksheetHyperlink**
> HyperlinkResponse CellsHypelinksPutWorksheetHyperlink (string name, string sheetName, int? firstRow, int? firstColumn, int? totalRows, int? totalColumns, string address, string folder = null, string storage = null)

Add worksheet hyperlink.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsHypelinksPutWorksheetHyperlinkExample
    {
        public void main()
        {
            var apiInstance = new CellsHypelinksApi();
            var name = name_example;  // string | Document name.
            var sheetName = sheetName_example;  // string | Worksheet name.
            var firstRow = 56;  // int? | 
            var firstColumn = 56;  // int? | 
            var totalRows = 56;  // int? | 
            var totalColumns = 56;  // int? | 
            var address = address_example;  // string | 
            var folder = folder_example;  // string | The document folder. (optional) 
            var storage = storage_example;  // string | storage name. (optional) 

            try
            {
                // Add worksheet hyperlink.
                HyperlinkResponse result = apiInstance.CellsHypelinksPutWorksheetHyperlink(name, sheetName, firstRow, firstColumn, totalRows, totalColumns, address, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsHypelinksApi.CellsHypelinksPutWorksheetHyperlink: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Document name. | 
 **sheetName** | **string**| Worksheet name. | 
 **firstRow** | **int?**|  | 
 **firstColumn** | **int?**|  | 
 **totalRows** | **int?**|  | 
 **totalColumns** | **int?**|  | 
 **address** | **string**|  | 
 **folder** | **string**| The document folder. | [optional] 
 **storage** | **string**| storage name. | [optional] 

### Return type

[**HyperlinkResponse**](HyperlinkResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

