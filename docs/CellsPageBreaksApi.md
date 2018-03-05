# Aspose.Cells.Cloud.SDK.Api.CellsPageBreaksApi

All URIs are relative to *https://api.aspose.cloud/v1.1/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CellsPageBreaksDeleteHorizontalPageBreak**](CellsPageBreaksApi.md#cellspagebreaksdeletehorizontalpagebreak) | **DELETE** /cells/{name}/worksheets/{sheetName}/horizontalpagebreaks/{index} | 
[**CellsPageBreaksDeleteHorizontalPageBreaks**](CellsPageBreaksApi.md#cellspagebreaksdeletehorizontalpagebreaks) | **DELETE** /cells/{name}/worksheets/{sheetName}/horizontalpagebreaks | 
[**CellsPageBreaksDeleteVerticalPageBreak**](CellsPageBreaksApi.md#cellspagebreaksdeleteverticalpagebreak) | **DELETE** /cells/{name}/worksheets/{sheetName}/verticalpagebreaks/{index} | 
[**CellsPageBreaksDeleteVerticalPageBreaks**](CellsPageBreaksApi.md#cellspagebreaksdeleteverticalpagebreaks) | **DELETE** /cells/{name}/worksheets/{sheetName}/verticalpagebreaks | 
[**CellsPageBreaksGetHorizontalPageBreak**](CellsPageBreaksApi.md#cellspagebreaksgethorizontalpagebreak) | **GET** /cells/{name}/worksheets/{sheetName}/horizontalpagebreaks/{index} | 
[**CellsPageBreaksGetHorizontalPageBreaks**](CellsPageBreaksApi.md#cellspagebreaksgethorizontalpagebreaks) | **GET** /cells/{name}/worksheets/{sheetName}/horizontalpagebreaks | 
[**CellsPageBreaksGetVerticalPageBreak**](CellsPageBreaksApi.md#cellspagebreaksgetverticalpagebreak) | **GET** /cells/{name}/worksheets/{sheetName}/verticalpagebreaks/{index} | 
[**CellsPageBreaksGetVerticalPageBreaks**](CellsPageBreaksApi.md#cellspagebreaksgetverticalpagebreaks) | **GET** /cells/{name}/worksheets/{sheetName}/verticalpagebreaks | 
[**CellsPageBreaksPutHorizontalPageBreak**](CellsPageBreaksApi.md#cellspagebreaksputhorizontalpagebreak) | **PUT** /cells/{name}/worksheets/{sheetName}/horizontalpagebreaks | 
[**CellsPageBreaksPutVerticalPageBreak**](CellsPageBreaksApi.md#cellspagebreaksputverticalpagebreak) | **PUT** /cells/{name}/worksheets/{sheetName}/verticalpagebreaks | 


<a name="cellspagebreaksdeletehorizontalpagebreak"></a>
# **CellsPageBreaksDeleteHorizontalPageBreak**
> SaaSposeResponse CellsPageBreaksDeleteHorizontalPageBreak (string name, string sheetName, int? index, string folder = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsPageBreaksDeleteHorizontalPageBreakExample
    {
        public void main()
        {
            var apiInstance = new CellsPageBreaksApi();
            var name = name_example;  // string | 
            var sheetName = sheetName_example;  // string | 
            var index = 56;  // int? | 
            var folder = folder_example;  // string |  (optional) 

            try
            {
                SaaSposeResponse result = apiInstance.CellsPageBreaksDeleteHorizontalPageBreak(name, sheetName, index, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsPageBreaksApi.CellsPageBreaksDeleteHorizontalPageBreak: " + e.Message );
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
 **index** | **int?**|  | 
 **folder** | **string**|  | [optional] 

### Return type

[**SaaSposeResponse**](SaaSposeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellspagebreaksdeletehorizontalpagebreaks"></a>
# **CellsPageBreaksDeleteHorizontalPageBreaks**
> SaaSposeResponse CellsPageBreaksDeleteHorizontalPageBreaks (string name, string sheetName, int? row = null, string folder = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsPageBreaksDeleteHorizontalPageBreaksExample
    {
        public void main()
        {
            var apiInstance = new CellsPageBreaksApi();
            var name = name_example;  // string | 
            var sheetName = sheetName_example;  // string | 
            var row = 56;  // int? |  (optional) 
            var folder = folder_example;  // string |  (optional) 

            try
            {
                SaaSposeResponse result = apiInstance.CellsPageBreaksDeleteHorizontalPageBreaks(name, sheetName, row, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsPageBreaksApi.CellsPageBreaksDeleteHorizontalPageBreaks: " + e.Message );
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
 **row** | **int?**|  | [optional] 
 **folder** | **string**|  | [optional] 

### Return type

[**SaaSposeResponse**](SaaSposeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellspagebreaksdeleteverticalpagebreak"></a>
# **CellsPageBreaksDeleteVerticalPageBreak**
> SaaSposeResponse CellsPageBreaksDeleteVerticalPageBreak (string name, string sheetName, int? index, string folder = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsPageBreaksDeleteVerticalPageBreakExample
    {
        public void main()
        {
            var apiInstance = new CellsPageBreaksApi();
            var name = name_example;  // string | 
            var sheetName = sheetName_example;  // string | 
            var index = 56;  // int? | 
            var folder = folder_example;  // string |  (optional) 

            try
            {
                SaaSposeResponse result = apiInstance.CellsPageBreaksDeleteVerticalPageBreak(name, sheetName, index, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsPageBreaksApi.CellsPageBreaksDeleteVerticalPageBreak: " + e.Message );
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
 **index** | **int?**|  | 
 **folder** | **string**|  | [optional] 

### Return type

[**SaaSposeResponse**](SaaSposeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellspagebreaksdeleteverticalpagebreaks"></a>
# **CellsPageBreaksDeleteVerticalPageBreaks**
> SaaSposeResponse CellsPageBreaksDeleteVerticalPageBreaks (string name, string sheetName, int? column = null, string folder = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsPageBreaksDeleteVerticalPageBreaksExample
    {
        public void main()
        {
            var apiInstance = new CellsPageBreaksApi();
            var name = name_example;  // string | 
            var sheetName = sheetName_example;  // string | 
            var column = 56;  // int? |  (optional) 
            var folder = folder_example;  // string |  (optional) 

            try
            {
                SaaSposeResponse result = apiInstance.CellsPageBreaksDeleteVerticalPageBreaks(name, sheetName, column, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsPageBreaksApi.CellsPageBreaksDeleteVerticalPageBreaks: " + e.Message );
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
 **column** | **int?**|  | [optional] 
 **folder** | **string**|  | [optional] 

### Return type

[**SaaSposeResponse**](SaaSposeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellspagebreaksgethorizontalpagebreak"></a>
# **CellsPageBreaksGetHorizontalPageBreak**
> HorizontalPageBreakResponse CellsPageBreaksGetHorizontalPageBreak (string name, string sheetName, int? index, string folder = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsPageBreaksGetHorizontalPageBreakExample
    {
        public void main()
        {
            var apiInstance = new CellsPageBreaksApi();
            var name = name_example;  // string | 
            var sheetName = sheetName_example;  // string | 
            var index = 56;  // int? | 
            var folder = folder_example;  // string |  (optional) 

            try
            {
                HorizontalPageBreakResponse result = apiInstance.CellsPageBreaksGetHorizontalPageBreak(name, sheetName, index, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsPageBreaksApi.CellsPageBreaksGetHorizontalPageBreak: " + e.Message );
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
 **index** | **int?**|  | 
 **folder** | **string**|  | [optional] 

### Return type

[**HorizontalPageBreakResponse**](HorizontalPageBreakResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellspagebreaksgethorizontalpagebreaks"></a>
# **CellsPageBreaksGetHorizontalPageBreaks**
> HorizontalPageBreaksResponse CellsPageBreaksGetHorizontalPageBreaks (string name, string sheetName, string folder = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsPageBreaksGetHorizontalPageBreaksExample
    {
        public void main()
        {
            var apiInstance = new CellsPageBreaksApi();
            var name = name_example;  // string | 
            var sheetName = sheetName_example;  // string | 
            var folder = folder_example;  // string |  (optional) 

            try
            {
                HorizontalPageBreaksResponse result = apiInstance.CellsPageBreaksGetHorizontalPageBreaks(name, sheetName, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsPageBreaksApi.CellsPageBreaksGetHorizontalPageBreaks: " + e.Message );
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

[**HorizontalPageBreaksResponse**](HorizontalPageBreaksResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellspagebreaksgetverticalpagebreak"></a>
# **CellsPageBreaksGetVerticalPageBreak**
> VerticalPageBreakResponse CellsPageBreaksGetVerticalPageBreak (string name, string sheetName, int? index, string folder = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsPageBreaksGetVerticalPageBreakExample
    {
        public void main()
        {
            var apiInstance = new CellsPageBreaksApi();
            var name = name_example;  // string | 
            var sheetName = sheetName_example;  // string | 
            var index = 56;  // int? | 
            var folder = folder_example;  // string |  (optional) 

            try
            {
                VerticalPageBreakResponse result = apiInstance.CellsPageBreaksGetVerticalPageBreak(name, sheetName, index, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsPageBreaksApi.CellsPageBreaksGetVerticalPageBreak: " + e.Message );
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
 **index** | **int?**|  | 
 **folder** | **string**|  | [optional] 

### Return type

[**VerticalPageBreakResponse**](VerticalPageBreakResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellspagebreaksgetverticalpagebreaks"></a>
# **CellsPageBreaksGetVerticalPageBreaks**
> VerticalPageBreaksResponse CellsPageBreaksGetVerticalPageBreaks (string name, string sheetName, string folder = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsPageBreaksGetVerticalPageBreaksExample
    {
        public void main()
        {
            var apiInstance = new CellsPageBreaksApi();
            var name = name_example;  // string | 
            var sheetName = sheetName_example;  // string | 
            var folder = folder_example;  // string |  (optional) 

            try
            {
                VerticalPageBreaksResponse result = apiInstance.CellsPageBreaksGetVerticalPageBreaks(name, sheetName, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsPageBreaksApi.CellsPageBreaksGetVerticalPageBreaks: " + e.Message );
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

[**VerticalPageBreaksResponse**](VerticalPageBreaksResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellspagebreaksputhorizontalpagebreak"></a>
# **CellsPageBreaksPutHorizontalPageBreak**
> SaaSposeResponse CellsPageBreaksPutHorizontalPageBreak (string name, string sheetName, string cellname = null, int? row = null, int? column = null, int? startColumn = null, int? endColumn = null, string folder = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsPageBreaksPutHorizontalPageBreakExample
    {
        public void main()
        {
            var apiInstance = new CellsPageBreaksApi();
            var name = name_example;  // string | 
            var sheetName = sheetName_example;  // string | 
            var cellname = cellname_example;  // string |  (optional) 
            var row = 56;  // int? |  (optional) 
            var column = 56;  // int? |  (optional) 
            var startColumn = 56;  // int? |  (optional) 
            var endColumn = 56;  // int? |  (optional) 
            var folder = folder_example;  // string |  (optional) 

            try
            {
                SaaSposeResponse result = apiInstance.CellsPageBreaksPutHorizontalPageBreak(name, sheetName, cellname, row, column, startColumn, endColumn, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsPageBreaksApi.CellsPageBreaksPutHorizontalPageBreak: " + e.Message );
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
 **cellname** | **string**|  | [optional] 
 **row** | **int?**|  | [optional] 
 **column** | **int?**|  | [optional] 
 **startColumn** | **int?**|  | [optional] 
 **endColumn** | **int?**|  | [optional] 
 **folder** | **string**|  | [optional] 

### Return type

[**SaaSposeResponse**](SaaSposeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellspagebreaksputverticalpagebreak"></a>
# **CellsPageBreaksPutVerticalPageBreak**
> SaaSposeResponse CellsPageBreaksPutVerticalPageBreak (string name, string sheetName, string cellname = null, int? column = null, int? row = null, int? startRow = null, int? endRow = null, string folder = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsPageBreaksPutVerticalPageBreakExample
    {
        public void main()
        {
            var apiInstance = new CellsPageBreaksApi();
            var name = name_example;  // string | 
            var sheetName = sheetName_example;  // string | 
            var cellname = cellname_example;  // string |  (optional) 
            var column = 56;  // int? |  (optional) 
            var row = 56;  // int? |  (optional) 
            var startRow = 56;  // int? |  (optional) 
            var endRow = 56;  // int? |  (optional) 
            var folder = folder_example;  // string |  (optional) 

            try
            {
                SaaSposeResponse result = apiInstance.CellsPageBreaksPutVerticalPageBreak(name, sheetName, cellname, column, row, startRow, endRow, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsPageBreaksApi.CellsPageBreaksPutVerticalPageBreak: " + e.Message );
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
 **cellname** | **string**|  | [optional] 
 **column** | **int?**|  | [optional] 
 **row** | **int?**|  | [optional] 
 **startRow** | **int?**|  | [optional] 
 **endRow** | **int?**|  | [optional] 
 **folder** | **string**|  | [optional] 

### Return type

[**SaaSposeResponse**](SaaSposeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

