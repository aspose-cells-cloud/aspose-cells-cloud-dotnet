# Aspose.Cells.Cloud.SDK.Api.CellsPageSetupApi

All URIs are relative to *https://api.aspose.cloud/v1.1/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CellsPageSetupDeleteHeaderFooter**](CellsPageSetupApi.md#cellspagesetupdeleteheaderfooter) | **DELETE** /cells/{name}/worksheets/{sheetName}/pagesetup/clearheaderfooter | clear header footer
[**CellsPageSetupGetFooter**](CellsPageSetupApi.md#cellspagesetupgetfooter) | **GET** /cells/{name}/worksheets/{sheetName}/pagesetup/footer | get page footer information
[**CellsPageSetupGetHeader**](CellsPageSetupApi.md#cellspagesetupgetheader) | **GET** /cells/{name}/worksheets/{sheetName}/pagesetup/header | get page header information
[**CellsPageSetupGetPageSetup**](CellsPageSetupApi.md#cellspagesetupgetpagesetup) | **GET** /cells/{name}/worksheets/{sheetName}/pagesetup | Get Page Setup information.             
[**CellsPageSetupPostFooter**](CellsPageSetupApi.md#cellspagesetuppostfooter) | **POST** /cells/{name}/worksheets/{sheetName}/pagesetup/footer | update  page footer information 
[**CellsPageSetupPostHeader**](CellsPageSetupApi.md#cellspagesetuppostheader) | **POST** /cells/{name}/worksheets/{sheetName}/pagesetup/header | update  page header information 
[**CellsPageSetupPostPageSetup**](CellsPageSetupApi.md#cellspagesetuppostpagesetup) | **POST** /cells/{name}/worksheets/{sheetName}/pagesetup | Update Page Setup information.


<a name="cellspagesetupdeleteheaderfooter"></a>
# **CellsPageSetupDeleteHeaderFooter**
> SaaSposeResponse CellsPageSetupDeleteHeaderFooter (string name, string sheetName, string folder = null)

clear header footer

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsPageSetupDeleteHeaderFooterExample
    {
        public void main()
        {
            var apiInstance = new CellsPageSetupApi();
            var name = name_example;  // string | 
            var sheetName = sheetName_example;  // string | 
            var folder = folder_example;  // string |  (optional) 

            try
            {
                // clear header footer
                SaaSposeResponse result = apiInstance.CellsPageSetupDeleteHeaderFooter(name, sheetName, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsPageSetupApi.CellsPageSetupDeleteHeaderFooter: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**|  | 
 **sheetName** | **string**|  | 
 **folder** | **string**|  | [optional] 

### Return type

[**SaaSposeResponse**](SaaSposeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellspagesetupgetfooter"></a>
# **CellsPageSetupGetFooter**
> PageSectionsResponse CellsPageSetupGetFooter (string name, string sheetName, string folder = null)

get page footer information

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsPageSetupGetFooterExample
    {
        public void main()
        {
            var apiInstance = new CellsPageSetupApi();
            var name = name_example;  // string | 
            var sheetName = sheetName_example;  // string | 
            var folder = folder_example;  // string |  (optional) 

            try
            {
                // get page footer information
                PageSectionsResponse result = apiInstance.CellsPageSetupGetFooter(name, sheetName, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsPageSetupApi.CellsPageSetupGetFooter: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**|  | 
 **sheetName** | **string**|  | 
 **folder** | **string**|  | [optional] 

### Return type

[**PageSectionsResponse**](PageSectionsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellspagesetupgetheader"></a>
# **CellsPageSetupGetHeader**
> PageSectionsResponse CellsPageSetupGetHeader (string name, string sheetName, string folder = null)

get page header information

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsPageSetupGetHeaderExample
    {
        public void main()
        {
            var apiInstance = new CellsPageSetupApi();
            var name = name_example;  // string | 
            var sheetName = sheetName_example;  // string | 
            var folder = folder_example;  // string |  (optional) 

            try
            {
                // get page header information
                PageSectionsResponse result = apiInstance.CellsPageSetupGetHeader(name, sheetName, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsPageSetupApi.CellsPageSetupGetHeader: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**|  | 
 **sheetName** | **string**|  | 
 **folder** | **string**|  | [optional] 

### Return type

[**PageSectionsResponse**](PageSectionsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellspagesetupgetpagesetup"></a>
# **CellsPageSetupGetPageSetup**
> PageSetupResponse CellsPageSetupGetPageSetup (string name, string sheetName, string folder = null)

Get Page Setup information.             

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsPageSetupGetPageSetupExample
    {
        public void main()
        {
            var apiInstance = new CellsPageSetupApi();
            var name = name_example;  // string | 
            var sheetName = sheetName_example;  // string | 
            var folder = folder_example;  // string |  (optional) 

            try
            {
                // Get Page Setup information.             
                PageSetupResponse result = apiInstance.CellsPageSetupGetPageSetup(name, sheetName, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsPageSetupApi.CellsPageSetupGetPageSetup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**|  | 
 **sheetName** | **string**|  | 
 **folder** | **string**|  | [optional] 

### Return type

[**PageSetupResponse**](PageSetupResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellspagesetuppostfooter"></a>
# **CellsPageSetupPostFooter**
> SaaSposeResponse CellsPageSetupPostFooter (string name, string sheetName, int? section, string script, bool? isFirstPage, string folder = null)

update  page footer information 

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsPageSetupPostFooterExample
    {
        public void main()
        {
            var apiInstance = new CellsPageSetupApi();
            var name = name_example;  // string | 
            var sheetName = sheetName_example;  // string | 
            var section = 56;  // int? | 
            var script = script_example;  // string | 
            var isFirstPage = true;  // bool? | 
            var folder = folder_example;  // string |  (optional) 

            try
            {
                // update  page footer information 
                SaaSposeResponse result = apiInstance.CellsPageSetupPostFooter(name, sheetName, section, script, isFirstPage, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsPageSetupApi.CellsPageSetupPostFooter: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**|  | 
 **sheetName** | **string**|  | 
 **section** | **int?**|  | 
 **script** | **string**|  | 
 **isFirstPage** | **bool?**|  | 
 **folder** | **string**|  | [optional] 

### Return type

[**SaaSposeResponse**](SaaSposeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellspagesetuppostheader"></a>
# **CellsPageSetupPostHeader**
> SaaSposeResponse CellsPageSetupPostHeader (string name, string sheetName, int? section, string script, bool? isFirstPage, string folder = null)

update  page header information 

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsPageSetupPostHeaderExample
    {
        public void main()
        {
            var apiInstance = new CellsPageSetupApi();
            var name = name_example;  // string | 
            var sheetName = sheetName_example;  // string | 
            var section = 56;  // int? | 
            var script = script_example;  // string | 
            var isFirstPage = true;  // bool? | 
            var folder = folder_example;  // string |  (optional) 

            try
            {
                // update  page header information 
                SaaSposeResponse result = apiInstance.CellsPageSetupPostHeader(name, sheetName, section, script, isFirstPage, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsPageSetupApi.CellsPageSetupPostHeader: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**|  | 
 **sheetName** | **string**|  | 
 **section** | **int?**|  | 
 **script** | **string**|  | 
 **isFirstPage** | **bool?**|  | 
 **folder** | **string**|  | [optional] 

### Return type

[**SaaSposeResponse**](SaaSposeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellspagesetuppostpagesetup"></a>
# **CellsPageSetupPostPageSetup**
> SaaSposeResponse CellsPageSetupPostPageSetup (string name, string sheetName, PageSetup pageSetup = null, string folder = null)

Update Page Setup information.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsPageSetupPostPageSetupExample
    {
        public void main()
        {
            var apiInstance = new CellsPageSetupApi();
            var name = name_example;  // string | 
            var sheetName = sheetName_example;  // string | 
            var pageSetup = new PageSetup(); // PageSetup |  (optional) 
            var folder = folder_example;  // string |  (optional) 

            try
            {
                // Update Page Setup information.
                SaaSposeResponse result = apiInstance.CellsPageSetupPostPageSetup(name, sheetName, pageSetup, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsPageSetupApi.CellsPageSetupPostPageSetup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**|  | 
 **sheetName** | **string**|  | 
 **pageSetup** | [**PageSetup**](PageSetup.md)|  | [optional] 
 **folder** | **string**|  | [optional] 

### Return type

[**SaaSposeResponse**](SaaSposeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

