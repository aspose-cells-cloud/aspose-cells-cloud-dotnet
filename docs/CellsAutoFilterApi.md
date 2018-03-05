# Aspose.Cells.Cloud.SDK.Api.CellsAutoFilterApi

All URIs are relative to *https://api.aspose.cloud/v1.1/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CellsAutoFilterDeleteWorksheetDateFilter**](CellsAutoFilterApi.md#cellsautofilterdeleteworksheetdatefilter) | **DELETE** /cells/{name}/worksheets/{sheetName}/autoFilter/dateFilter | Removes a date filter.             
[**CellsAutoFilterDeleteWorksheetFilter**](CellsAutoFilterApi.md#cellsautofilterdeleteworksheetfilter) | **DELETE** /cells/{name}/worksheets/{sheetName}/autoFilter/filter | Delete a filter for a filter column.             
[**CellsAutoFilterGetWorksheetAutoFilter**](CellsAutoFilterApi.md#cellsautofiltergetworksheetautofilter) | **GET** /cells/{name}/worksheets/{sheetName}/autoFilter | Get Auto filter Description
[**CellsAutoFilterPostWorksheetAutoFilterRefresh**](CellsAutoFilterApi.md#cellsautofilterpostworksheetautofilterrefresh) | **POST** /cells/{name}/worksheets/{sheetName}/autoFilter/refresh | 
[**CellsAutoFilterPostWorksheetMatchBlanks**](CellsAutoFilterApi.md#cellsautofilterpostworksheetmatchblanks) | **POST** /cells/{name}/worksheets/{sheetName}/autoFilter/matchBlanks | Match all blank cell in the list.
[**CellsAutoFilterPostWorksheetMatchNonBlanks**](CellsAutoFilterApi.md#cellsautofilterpostworksheetmatchnonblanks) | **POST** /cells/{name}/worksheets/{sheetName}/autoFilter/matchNonBlanks | Match all not blank cell in the list.             
[**CellsAutoFilterPutWorksheetColorFilter**](CellsAutoFilterApi.md#cellsautofilterputworksheetcolorfilter) | **PUT** /cells/{name}/worksheets/{sheetName}/autoFilter/colorFilter | 
[**CellsAutoFilterPutWorksheetCustomFilter**](CellsAutoFilterApi.md#cellsautofilterputworksheetcustomfilter) | **PUT** /cells/{name}/worksheets/{sheetName}/autoFilter/custom | Filters a list with a custom criteria.             
[**CellsAutoFilterPutWorksheetDateFilter**](CellsAutoFilterApi.md#cellsautofilterputworksheetdatefilter) | **PUT** /cells/{name}/worksheets/{sheetName}/autoFilter/dateFilter | add date filter in worksheet 
[**CellsAutoFilterPutWorksheetDynamicFilter**](CellsAutoFilterApi.md#cellsautofilterputworksheetdynamicfilter) | **PUT** /cells/{name}/worksheets/{sheetName}/autoFilter/dynamicFilter | 
[**CellsAutoFilterPutWorksheetFilter**](CellsAutoFilterApi.md#cellsautofilterputworksheetfilter) | **PUT** /cells/{name}/worksheets/{sheetName}/autoFilter/filter | Adds a filter for a filter column.             
[**CellsAutoFilterPutWorksheetFilterTop10**](CellsAutoFilterApi.md#cellsautofilterputworksheetfiltertop10) | **PUT** /cells/{name}/worksheets/{sheetName}/autoFilter/filterTop10 | Filter the top 10 item in the list
[**CellsAutoFilterPutWorksheetIconFilter**](CellsAutoFilterApi.md#cellsautofilterputworksheeticonfilter) | **PUT** /cells/{name}/worksheets/{sheetName}/autoFilter/iconFilter | Adds an icon filter.


<a name="cellsautofilterdeleteworksheetdatefilter"></a>
# **CellsAutoFilterDeleteWorksheetDateFilter**
> SaaSposeResponse CellsAutoFilterDeleteWorksheetDateFilter (string name, string sheetName, int? fieldIndex, string dateTimeGroupingType, int? year = null, int? month = null, int? day = null, int? hour = null, int? minute = null, int? second = null, string folder = null)

Removes a date filter.             

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsAutoFilterDeleteWorksheetDateFilterExample
    {
        public void main()
        {
            var apiInstance = new CellsAutoFilterApi();
            var name = name_example;  // string | 
            var sheetName = sheetName_example;  // string | 
            var fieldIndex = 56;  // int? | 
            var dateTimeGroupingType = dateTimeGroupingType_example;  // string | 
            var year = 56;  // int? |  (optional)  (default to 0)
            var month = 56;  // int? |  (optional)  (default to 0)
            var day = 56;  // int? |  (optional)  (default to 0)
            var hour = 56;  // int? |  (optional)  (default to 0)
            var minute = 56;  // int? |  (optional)  (default to 0)
            var second = 56;  // int? |  (optional)  (default to 0)
            var folder = folder_example;  // string |  (optional) 

            try
            {
                // Removes a date filter.             
                SaaSposeResponse result = apiInstance.CellsAutoFilterDeleteWorksheetDateFilter(name, sheetName, fieldIndex, dateTimeGroupingType, year, month, day, hour, minute, second, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsAutoFilterApi.CellsAutoFilterDeleteWorksheetDateFilter: " + e.Message );
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
 **fieldIndex** | **int?**|  | 
 **dateTimeGroupingType** | **string**|  | 
 **year** | **int?**|  | [optional] [default to 0]
 **month** | **int?**|  | [optional] [default to 0]
 **day** | **int?**|  | [optional] [default to 0]
 **hour** | **int?**|  | [optional] [default to 0]
 **minute** | **int?**|  | [optional] [default to 0]
 **second** | **int?**|  | [optional] [default to 0]
 **folder** | **string**|  | [optional] 

### Return type

[**SaaSposeResponse**](SaaSposeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellsautofilterdeleteworksheetfilter"></a>
# **CellsAutoFilterDeleteWorksheetFilter**
> SaaSposeResponse CellsAutoFilterDeleteWorksheetFilter (string name, string sheetName, int? fieldIndex, string criteria = null, string folder = null)

Delete a filter for a filter column.             

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsAutoFilterDeleteWorksheetFilterExample
    {
        public void main()
        {
            var apiInstance = new CellsAutoFilterApi();
            var name = name_example;  // string | 
            var sheetName = sheetName_example;  // string | 
            var fieldIndex = 56;  // int? | 
            var criteria = criteria_example;  // string |  (optional) 
            var folder = folder_example;  // string |  (optional) 

            try
            {
                // Delete a filter for a filter column.             
                SaaSposeResponse result = apiInstance.CellsAutoFilterDeleteWorksheetFilter(name, sheetName, fieldIndex, criteria, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsAutoFilterApi.CellsAutoFilterDeleteWorksheetFilter: " + e.Message );
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
 **fieldIndex** | **int?**|  | 
 **criteria** | **string**|  | [optional] 
 **folder** | **string**|  | [optional] 

### Return type

[**SaaSposeResponse**](SaaSposeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellsautofiltergetworksheetautofilter"></a>
# **CellsAutoFilterGetWorksheetAutoFilter**
> AutoFilterResponse CellsAutoFilterGetWorksheetAutoFilter (string name, string sheetName, string folder = null)

Get Auto filter Description

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsAutoFilterGetWorksheetAutoFilterExample
    {
        public void main()
        {
            var apiInstance = new CellsAutoFilterApi();
            var name = name_example;  // string | 
            var sheetName = sheetName_example;  // string | 
            var folder = folder_example;  // string |  (optional) 

            try
            {
                // Get Auto filter Description
                AutoFilterResponse result = apiInstance.CellsAutoFilterGetWorksheetAutoFilter(name, sheetName, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsAutoFilterApi.CellsAutoFilterGetWorksheetAutoFilter: " + e.Message );
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

[**AutoFilterResponse**](AutoFilterResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellsautofilterpostworksheetautofilterrefresh"></a>
# **CellsAutoFilterPostWorksheetAutoFilterRefresh**
> SaaSposeResponse CellsAutoFilterPostWorksheetAutoFilterRefresh (string name, string sheetName, string folder = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsAutoFilterPostWorksheetAutoFilterRefreshExample
    {
        public void main()
        {
            var apiInstance = new CellsAutoFilterApi();
            var name = name_example;  // string | 
            var sheetName = sheetName_example;  // string | 
            var folder = folder_example;  // string |  (optional) 

            try
            {
                SaaSposeResponse result = apiInstance.CellsAutoFilterPostWorksheetAutoFilterRefresh(name, sheetName, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsAutoFilterApi.CellsAutoFilterPostWorksheetAutoFilterRefresh: " + e.Message );
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

<a name="cellsautofilterpostworksheetmatchblanks"></a>
# **CellsAutoFilterPostWorksheetMatchBlanks**
> SaaSposeResponse CellsAutoFilterPostWorksheetMatchBlanks (string name, string sheetName, int? fieldIndex, string folder = null)

Match all blank cell in the list.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsAutoFilterPostWorksheetMatchBlanksExample
    {
        public void main()
        {
            var apiInstance = new CellsAutoFilterApi();
            var name = name_example;  // string | 
            var sheetName = sheetName_example;  // string | 
            var fieldIndex = 56;  // int? | 
            var folder = folder_example;  // string |  (optional) 

            try
            {
                // Match all blank cell in the list.
                SaaSposeResponse result = apiInstance.CellsAutoFilterPostWorksheetMatchBlanks(name, sheetName, fieldIndex, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsAutoFilterApi.CellsAutoFilterPostWorksheetMatchBlanks: " + e.Message );
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
 **fieldIndex** | **int?**|  | 
 **folder** | **string**|  | [optional] 

### Return type

[**SaaSposeResponse**](SaaSposeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellsautofilterpostworksheetmatchnonblanks"></a>
# **CellsAutoFilterPostWorksheetMatchNonBlanks**
> SaaSposeResponse CellsAutoFilterPostWorksheetMatchNonBlanks (string name, string sheetName, int? fieldIndex, string folder = null)

Match all not blank cell in the list.             

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsAutoFilterPostWorksheetMatchNonBlanksExample
    {
        public void main()
        {
            var apiInstance = new CellsAutoFilterApi();
            var name = name_example;  // string | 
            var sheetName = sheetName_example;  // string | 
            var fieldIndex = 56;  // int? | 
            var folder = folder_example;  // string |  (optional) 

            try
            {
                // Match all not blank cell in the list.             
                SaaSposeResponse result = apiInstance.CellsAutoFilterPostWorksheetMatchNonBlanks(name, sheetName, fieldIndex, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsAutoFilterApi.CellsAutoFilterPostWorksheetMatchNonBlanks: " + e.Message );
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
 **fieldIndex** | **int?**|  | 
 **folder** | **string**|  | [optional] 

### Return type

[**SaaSposeResponse**](SaaSposeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellsautofilterputworksheetcolorfilter"></a>
# **CellsAutoFilterPutWorksheetColorFilter**
> SaaSposeResponse CellsAutoFilterPutWorksheetColorFilter (string name, string sheetName, string range, int? fieldIndex, ColorFilterRequest colorFilter = null, bool? matchBlanks = null, bool? refresh = null, string folder = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsAutoFilterPutWorksheetColorFilterExample
    {
        public void main()
        {
            var apiInstance = new CellsAutoFilterApi();
            var name = name_example;  // string | 
            var sheetName = sheetName_example;  // string | 
            var range = range_example;  // string | 
            var fieldIndex = 56;  // int? | 
            var colorFilter = new ColorFilterRequest(); // ColorFilterRequest |  (optional) 
            var matchBlanks = true;  // bool? |  (optional) 
            var refresh = true;  // bool? |  (optional) 
            var folder = folder_example;  // string |  (optional) 

            try
            {
                SaaSposeResponse result = apiInstance.CellsAutoFilterPutWorksheetColorFilter(name, sheetName, range, fieldIndex, colorFilter, matchBlanks, refresh, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsAutoFilterApi.CellsAutoFilterPutWorksheetColorFilter: " + e.Message );
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
 **range** | **string**|  | 
 **fieldIndex** | **int?**|  | 
 **colorFilter** | [**ColorFilterRequest**](ColorFilterRequest.md)|  | [optional] 
 **matchBlanks** | **bool?**|  | [optional] 
 **refresh** | **bool?**|  | [optional] 
 **folder** | **string**|  | [optional] 

### Return type

[**SaaSposeResponse**](SaaSposeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellsautofilterputworksheetcustomfilter"></a>
# **CellsAutoFilterPutWorksheetCustomFilter**
> SaaSposeResponse CellsAutoFilterPutWorksheetCustomFilter (string name, string sheetName, string range, int? fieldIndex, string operatorType1, string criteria1, bool? isAnd = null, string operatorType2 = null, string criteria2 = null, bool? matchBlanks = null, bool? refresh = null, string folder = null)

Filters a list with a custom criteria.             

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsAutoFilterPutWorksheetCustomFilterExample
    {
        public void main()
        {
            var apiInstance = new CellsAutoFilterApi();
            var name = name_example;  // string | 
            var sheetName = sheetName_example;  // string | 
            var range = range_example;  // string | 
            var fieldIndex = 56;  // int? | 
            var operatorType1 = operatorType1_example;  // string | 
            var criteria1 = criteria1_example;  // string | 
            var isAnd = true;  // bool? |  (optional) 
            var operatorType2 = operatorType2_example;  // string |  (optional) 
            var criteria2 = criteria2_example;  // string |  (optional) 
            var matchBlanks = true;  // bool? |  (optional) 
            var refresh = true;  // bool? |  (optional) 
            var folder = folder_example;  // string |  (optional) 

            try
            {
                // Filters a list with a custom criteria.             
                SaaSposeResponse result = apiInstance.CellsAutoFilterPutWorksheetCustomFilter(name, sheetName, range, fieldIndex, operatorType1, criteria1, isAnd, operatorType2, criteria2, matchBlanks, refresh, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsAutoFilterApi.CellsAutoFilterPutWorksheetCustomFilter: " + e.Message );
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
 **range** | **string**|  | 
 **fieldIndex** | **int?**|  | 
 **operatorType1** | **string**|  | 
 **criteria1** | **string**|  | 
 **isAnd** | **bool?**|  | [optional] 
 **operatorType2** | **string**|  | [optional] 
 **criteria2** | **string**|  | [optional] 
 **matchBlanks** | **bool?**|  | [optional] 
 **refresh** | **bool?**|  | [optional] 
 **folder** | **string**|  | [optional] 

### Return type

[**SaaSposeResponse**](SaaSposeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellsautofilterputworksheetdatefilter"></a>
# **CellsAutoFilterPutWorksheetDateFilter**
> SaaSposeResponse CellsAutoFilterPutWorksheetDateFilter (string name, string sheetName, string range, int? fieldIndex, string dateTimeGroupingType, int? year = null, int? month = null, int? day = null, int? hour = null, int? minute = null, int? second = null, bool? matchBlanks = null, bool? refresh = null, string folder = null)

add date filter in worksheet 

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsAutoFilterPutWorksheetDateFilterExample
    {
        public void main()
        {
            var apiInstance = new CellsAutoFilterApi();
            var name = name_example;  // string | 
            var sheetName = sheetName_example;  // string | 
            var range = range_example;  // string | 
            var fieldIndex = 56;  // int? | 
            var dateTimeGroupingType = dateTimeGroupingType_example;  // string | 
            var year = 56;  // int? |  (optional)  (default to 0)
            var month = 56;  // int? |  (optional)  (default to 0)
            var day = 56;  // int? |  (optional)  (default to 0)
            var hour = 56;  // int? |  (optional)  (default to 0)
            var minute = 56;  // int? |  (optional)  (default to 0)
            var second = 56;  // int? |  (optional)  (default to 0)
            var matchBlanks = true;  // bool? |  (optional) 
            var refresh = true;  // bool? |  (optional) 
            var folder = folder_example;  // string |  (optional) 

            try
            {
                // add date filter in worksheet 
                SaaSposeResponse result = apiInstance.CellsAutoFilterPutWorksheetDateFilter(name, sheetName, range, fieldIndex, dateTimeGroupingType, year, month, day, hour, minute, second, matchBlanks, refresh, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsAutoFilterApi.CellsAutoFilterPutWorksheetDateFilter: " + e.Message );
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
 **range** | **string**|  | 
 **fieldIndex** | **int?**|  | 
 **dateTimeGroupingType** | **string**|  | 
 **year** | **int?**|  | [optional] [default to 0]
 **month** | **int?**|  | [optional] [default to 0]
 **day** | **int?**|  | [optional] [default to 0]
 **hour** | **int?**|  | [optional] [default to 0]
 **minute** | **int?**|  | [optional] [default to 0]
 **second** | **int?**|  | [optional] [default to 0]
 **matchBlanks** | **bool?**|  | [optional] 
 **refresh** | **bool?**|  | [optional] 
 **folder** | **string**|  | [optional] 

### Return type

[**SaaSposeResponse**](SaaSposeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellsautofilterputworksheetdynamicfilter"></a>
# **CellsAutoFilterPutWorksheetDynamicFilter**
> SaaSposeResponse CellsAutoFilterPutWorksheetDynamicFilter (string name, string sheetName, string range, int? fieldIndex, string dynamicFilterType, bool? matchBlanks = null, bool? refresh = null, string folder = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsAutoFilterPutWorksheetDynamicFilterExample
    {
        public void main()
        {
            var apiInstance = new CellsAutoFilterApi();
            var name = name_example;  // string | 
            var sheetName = sheetName_example;  // string | 
            var range = range_example;  // string | 
            var fieldIndex = 56;  // int? | 
            var dynamicFilterType = dynamicFilterType_example;  // string | 
            var matchBlanks = true;  // bool? |  (optional) 
            var refresh = true;  // bool? |  (optional) 
            var folder = folder_example;  // string |  (optional) 

            try
            {
                SaaSposeResponse result = apiInstance.CellsAutoFilterPutWorksheetDynamicFilter(name, sheetName, range, fieldIndex, dynamicFilterType, matchBlanks, refresh, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsAutoFilterApi.CellsAutoFilterPutWorksheetDynamicFilter: " + e.Message );
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
 **range** | **string**|  | 
 **fieldIndex** | **int?**|  | 
 **dynamicFilterType** | **string**|  | 
 **matchBlanks** | **bool?**|  | [optional] 
 **refresh** | **bool?**|  | [optional] 
 **folder** | **string**|  | [optional] 

### Return type

[**SaaSposeResponse**](SaaSposeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellsautofilterputworksheetfilter"></a>
# **CellsAutoFilterPutWorksheetFilter**
> SaaSposeResponse CellsAutoFilterPutWorksheetFilter (string name, string sheetName, string range, int? fieldIndex, string criteria, bool? matchBlanks = null, bool? refresh = null, string folder = null)

Adds a filter for a filter column.             

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsAutoFilterPutWorksheetFilterExample
    {
        public void main()
        {
            var apiInstance = new CellsAutoFilterApi();
            var name = name_example;  // string | 
            var sheetName = sheetName_example;  // string | 
            var range = range_example;  // string | 
            var fieldIndex = 56;  // int? | 
            var criteria = criteria_example;  // string | 
            var matchBlanks = true;  // bool? |  (optional) 
            var refresh = true;  // bool? |  (optional) 
            var folder = folder_example;  // string |  (optional) 

            try
            {
                // Adds a filter for a filter column.             
                SaaSposeResponse result = apiInstance.CellsAutoFilterPutWorksheetFilter(name, sheetName, range, fieldIndex, criteria, matchBlanks, refresh, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsAutoFilterApi.CellsAutoFilterPutWorksheetFilter: " + e.Message );
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
 **range** | **string**|  | 
 **fieldIndex** | **int?**|  | 
 **criteria** | **string**|  | 
 **matchBlanks** | **bool?**|  | [optional] 
 **refresh** | **bool?**|  | [optional] 
 **folder** | **string**|  | [optional] 

### Return type

[**SaaSposeResponse**](SaaSposeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellsautofilterputworksheetfiltertop10"></a>
# **CellsAutoFilterPutWorksheetFilterTop10**
> SaaSposeResponse CellsAutoFilterPutWorksheetFilterTop10 (string name, string sheetName, string range, int? fieldIndex, bool? isTop, bool? isPercent, int? itemCount, bool? matchBlanks = null, bool? refresh = null, string folder = null)

Filter the top 10 item in the list

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsAutoFilterPutWorksheetFilterTop10Example
    {
        public void main()
        {
            var apiInstance = new CellsAutoFilterApi();
            var name = name_example;  // string | 
            var sheetName = sheetName_example;  // string | 
            var range = range_example;  // string | 
            var fieldIndex = 56;  // int? | 
            var isTop = true;  // bool? | 
            var isPercent = true;  // bool? | 
            var itemCount = 56;  // int? | 
            var matchBlanks = true;  // bool? |  (optional) 
            var refresh = true;  // bool? |  (optional) 
            var folder = folder_example;  // string |  (optional) 

            try
            {
                // Filter the top 10 item in the list
                SaaSposeResponse result = apiInstance.CellsAutoFilterPutWorksheetFilterTop10(name, sheetName, range, fieldIndex, isTop, isPercent, itemCount, matchBlanks, refresh, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsAutoFilterApi.CellsAutoFilterPutWorksheetFilterTop10: " + e.Message );
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
 **range** | **string**|  | 
 **fieldIndex** | **int?**|  | 
 **isTop** | **bool?**|  | 
 **isPercent** | **bool?**|  | 
 **itemCount** | **int?**|  | 
 **matchBlanks** | **bool?**|  | [optional] 
 **refresh** | **bool?**|  | [optional] 
 **folder** | **string**|  | [optional] 

### Return type

[**SaaSposeResponse**](SaaSposeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellsautofilterputworksheeticonfilter"></a>
# **CellsAutoFilterPutWorksheetIconFilter**
> SaaSposeResponse CellsAutoFilterPutWorksheetIconFilter (string name, string sheetName, string range, int? fieldIndex, string iconSetType, int? iconId, bool? matchBlanks = null, bool? refresh = null, string folder = null)

Adds an icon filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsAutoFilterPutWorksheetIconFilterExample
    {
        public void main()
        {
            var apiInstance = new CellsAutoFilterApi();
            var name = name_example;  // string | 
            var sheetName = sheetName_example;  // string | 
            var range = range_example;  // string | 
            var fieldIndex = 56;  // int? | 
            var iconSetType = iconSetType_example;  // string | 
            var iconId = 56;  // int? | 
            var matchBlanks = true;  // bool? |  (optional) 
            var refresh = true;  // bool? |  (optional) 
            var folder = folder_example;  // string |  (optional) 

            try
            {
                // Adds an icon filter.
                SaaSposeResponse result = apiInstance.CellsAutoFilterPutWorksheetIconFilter(name, sheetName, range, fieldIndex, iconSetType, iconId, matchBlanks, refresh, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsAutoFilterApi.CellsAutoFilterPutWorksheetIconFilter: " + e.Message );
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
 **range** | **string**|  | 
 **fieldIndex** | **int?**|  | 
 **iconSetType** | **string**|  | 
 **iconId** | **int?**|  | 
 **matchBlanks** | **bool?**|  | [optional] 
 **refresh** | **bool?**|  | [optional] 
 **folder** | **string**|  | [optional] 

### Return type

[**SaaSposeResponse**](SaaSposeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

