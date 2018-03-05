# Aspose.Cells.Cloud.SDK.Api.CellsConditionalFormattingsApi

All URIs are relative to *https://api.aspose.cloud/v1.1/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CellsConditionalFormattingsDeleteWorksheetConditionalFormatting**](CellsConditionalFormattingsApi.md#cellsconditionalformattingsdeleteworksheetconditionalformatting) | **DELETE** /cells/{name}/worksheets/{sheetName}/conditionalFormattings/{index} | Remove conditional formatting
[**CellsConditionalFormattingsDeleteWorksheetConditionalFormattingArea**](CellsConditionalFormattingsApi.md#cellsconditionalformattingsdeleteworksheetconditionalformattingarea) | **DELETE** /cells/{name}/worksheets/{sheetName}/conditionalFormattings/area | Remove cell area from conditional formatting.
[**CellsConditionalFormattingsDeleteWorksheetConditionalFormattings**](CellsConditionalFormattingsApi.md#cellsconditionalformattingsdeleteworksheetconditionalformattings) | **DELETE** /cells/{name}/worksheets/{sheetName}/conditionalFormattings | Clear all condition formattings
[**CellsConditionalFormattingsGetWorksheetConditionalFormatting**](CellsConditionalFormattingsApi.md#cellsconditionalformattingsgetworksheetconditionalformatting) | **GET** /cells/{name}/worksheets/{sheetName}/conditionalFormattings/{index} | Get conditional formatting
[**CellsConditionalFormattingsGetWorksheetConditionalFormattings**](CellsConditionalFormattingsApi.md#cellsconditionalformattingsgetworksheetconditionalformattings) | **GET** /cells/{name}/worksheets/{sheetName}/conditionalFormattings | Get conditional formattings 
[**CellsConditionalFormattingsPutWorksheetConditionalFormatting**](CellsConditionalFormattingsApi.md#cellsconditionalformattingsputworksheetconditionalformatting) | **PUT** /cells/{name}/worksheets/{sheetName}/conditionalFormattings | Add a condition formatting.
[**CellsConditionalFormattingsPutWorksheetFormatCondition**](CellsConditionalFormattingsApi.md#cellsconditionalformattingsputworksheetformatcondition) | **PUT** /cells/{name}/worksheets/{sheetName}/conditionalFormattings/{index} | Add a format condition.
[**CellsConditionalFormattingsPutWorksheetFormatConditionArea**](CellsConditionalFormattingsApi.md#cellsconditionalformattingsputworksheetformatconditionarea) | **PUT** /cells/{name}/worksheets/{sheetName}/conditionalFormattings/{index}/area | add a cell area for format condition             
[**CellsConditionalFormattingsPutWorksheetFormatConditionCondition**](CellsConditionalFormattingsApi.md#cellsconditionalformattingsputworksheetformatconditioncondition) | **PUT** /cells/{name}/worksheets/{sheetName}/conditionalFormattings/{index}/condition | Add a condition for format condition.


<a name="cellsconditionalformattingsdeleteworksheetconditionalformatting"></a>
# **CellsConditionalFormattingsDeleteWorksheetConditionalFormatting**
> SaaSposeResponse CellsConditionalFormattingsDeleteWorksheetConditionalFormatting (string name, string sheetName, int? index, string folder = null)

Remove conditional formatting

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsConditionalFormattingsDeleteWorksheetConditionalFormattingExample
    {
        public void main()
        {
            var apiInstance = new CellsConditionalFormattingsApi();
            var name = name_example;  // string | 
            var sheetName = sheetName_example;  // string | 
            var index = 56;  // int? | 
            var folder = folder_example;  // string |  (optional) 

            try
            {
                // Remove conditional formatting
                SaaSposeResponse result = apiInstance.CellsConditionalFormattingsDeleteWorksheetConditionalFormatting(name, sheetName, index, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsConditionalFormattingsApi.CellsConditionalFormattingsDeleteWorksheetConditionalFormatting: " + e.Message );
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

<a name="cellsconditionalformattingsdeleteworksheetconditionalformattingarea"></a>
# **CellsConditionalFormattingsDeleteWorksheetConditionalFormattingArea**
> SaaSposeResponse CellsConditionalFormattingsDeleteWorksheetConditionalFormattingArea (string name, string sheetName, int? startRow, int? startColumn, int? totalRows, int? totalColumns, string folder = null)

Remove cell area from conditional formatting.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsConditionalFormattingsDeleteWorksheetConditionalFormattingAreaExample
    {
        public void main()
        {
            var apiInstance = new CellsConditionalFormattingsApi();
            var name = name_example;  // string | 
            var sheetName = sheetName_example;  // string | 
            var startRow = 56;  // int? | 
            var startColumn = 56;  // int? | 
            var totalRows = 56;  // int? | 
            var totalColumns = 56;  // int? | 
            var folder = folder_example;  // string |  (optional) 

            try
            {
                // Remove cell area from conditional formatting.
                SaaSposeResponse result = apiInstance.CellsConditionalFormattingsDeleteWorksheetConditionalFormattingArea(name, sheetName, startRow, startColumn, totalRows, totalColumns, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsConditionalFormattingsApi.CellsConditionalFormattingsDeleteWorksheetConditionalFormattingArea: " + e.Message );
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
 **startRow** | **int?**|  | 
 **startColumn** | **int?**|  | 
 **totalRows** | **int?**|  | 
 **totalColumns** | **int?**|  | 
 **folder** | **string**|  | [optional] 

### Return type

[**SaaSposeResponse**](SaaSposeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellsconditionalformattingsdeleteworksheetconditionalformattings"></a>
# **CellsConditionalFormattingsDeleteWorksheetConditionalFormattings**
> SaaSposeResponse CellsConditionalFormattingsDeleteWorksheetConditionalFormattings (string name, string sheetName, string folder = null)

Clear all condition formattings

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsConditionalFormattingsDeleteWorksheetConditionalFormattingsExample
    {
        public void main()
        {
            var apiInstance = new CellsConditionalFormattingsApi();
            var name = name_example;  // string | 
            var sheetName = sheetName_example;  // string | 
            var folder = folder_example;  // string |  (optional) 

            try
            {
                // Clear all condition formattings
                SaaSposeResponse result = apiInstance.CellsConditionalFormattingsDeleteWorksheetConditionalFormattings(name, sheetName, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsConditionalFormattingsApi.CellsConditionalFormattingsDeleteWorksheetConditionalFormattings: " + e.Message );
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

<a name="cellsconditionalformattingsgetworksheetconditionalformatting"></a>
# **CellsConditionalFormattingsGetWorksheetConditionalFormatting**
> ConditionalFormattingResponse CellsConditionalFormattingsGetWorksheetConditionalFormatting (string name, string sheetName, int? index, string folder = null)

Get conditional formatting

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsConditionalFormattingsGetWorksheetConditionalFormattingExample
    {
        public void main()
        {
            var apiInstance = new CellsConditionalFormattingsApi();
            var name = name_example;  // string | 
            var sheetName = sheetName_example;  // string | 
            var index = 56;  // int? | 
            var folder = folder_example;  // string |  (optional) 

            try
            {
                // Get conditional formatting
                ConditionalFormattingResponse result = apiInstance.CellsConditionalFormattingsGetWorksheetConditionalFormatting(name, sheetName, index, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsConditionalFormattingsApi.CellsConditionalFormattingsGetWorksheetConditionalFormatting: " + e.Message );
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

[**ConditionalFormattingResponse**](ConditionalFormattingResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellsconditionalformattingsgetworksheetconditionalformattings"></a>
# **CellsConditionalFormattingsGetWorksheetConditionalFormattings**
> ConditionalFormattingsResponse CellsConditionalFormattingsGetWorksheetConditionalFormattings (string name, string sheetName, string folder = null)

Get conditional formattings 

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsConditionalFormattingsGetWorksheetConditionalFormattingsExample
    {
        public void main()
        {
            var apiInstance = new CellsConditionalFormattingsApi();
            var name = name_example;  // string | 
            var sheetName = sheetName_example;  // string | 
            var folder = folder_example;  // string |  (optional) 

            try
            {
                // Get conditional formattings 
                ConditionalFormattingsResponse result = apiInstance.CellsConditionalFormattingsGetWorksheetConditionalFormattings(name, sheetName, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsConditionalFormattingsApi.CellsConditionalFormattingsGetWorksheetConditionalFormattings: " + e.Message );
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

[**ConditionalFormattingsResponse**](ConditionalFormattingsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellsconditionalformattingsputworksheetconditionalformatting"></a>
# **CellsConditionalFormattingsPutWorksheetConditionalFormatting**
> SaaSposeResponse CellsConditionalFormattingsPutWorksheetConditionalFormatting (string name, string sheetName, string cellArea, FormatCondition formatcondition = null, string folder = null)

Add a condition formatting.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsConditionalFormattingsPutWorksheetConditionalFormattingExample
    {
        public void main()
        {
            var apiInstance = new CellsConditionalFormattingsApi();
            var name = name_example;  // string | 
            var sheetName = sheetName_example;  // string | 
            var cellArea = cellArea_example;  // string | 
            var formatcondition = new FormatCondition(); // FormatCondition |  (optional) 
            var folder = folder_example;  // string |  (optional) 

            try
            {
                // Add a condition formatting.
                SaaSposeResponse result = apiInstance.CellsConditionalFormattingsPutWorksheetConditionalFormatting(name, sheetName, cellArea, formatcondition, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsConditionalFormattingsApi.CellsConditionalFormattingsPutWorksheetConditionalFormatting: " + e.Message );
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
 **cellArea** | **string**|  | 
 **formatcondition** | [**FormatCondition**](FormatCondition.md)|  | [optional] 
 **folder** | **string**|  | [optional] 

### Return type

[**SaaSposeResponse**](SaaSposeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellsconditionalformattingsputworksheetformatcondition"></a>
# **CellsConditionalFormattingsPutWorksheetFormatCondition**
> SaaSposeResponse CellsConditionalFormattingsPutWorksheetFormatCondition (string name, string sheetName, int? index, string cellArea, string type, string operatorType, string formula1, string formula2, string folder = null)

Add a format condition.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsConditionalFormattingsPutWorksheetFormatConditionExample
    {
        public void main()
        {
            var apiInstance = new CellsConditionalFormattingsApi();
            var name = name_example;  // string | 
            var sheetName = sheetName_example;  // string | 
            var index = 56;  // int? | 
            var cellArea = cellArea_example;  // string | 
            var type = type_example;  // string | 
            var operatorType = operatorType_example;  // string | 
            var formula1 = formula1_example;  // string | 
            var formula2 = formula2_example;  // string | 
            var folder = folder_example;  // string |  (optional) 

            try
            {
                // Add a format condition.
                SaaSposeResponse result = apiInstance.CellsConditionalFormattingsPutWorksheetFormatCondition(name, sheetName, index, cellArea, type, operatorType, formula1, formula2, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsConditionalFormattingsApi.CellsConditionalFormattingsPutWorksheetFormatCondition: " + e.Message );
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
 **cellArea** | **string**|  | 
 **type** | **string**|  | 
 **operatorType** | **string**|  | 
 **formula1** | **string**|  | 
 **formula2** | **string**|  | 
 **folder** | **string**|  | [optional] 

### Return type

[**SaaSposeResponse**](SaaSposeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellsconditionalformattingsputworksheetformatconditionarea"></a>
# **CellsConditionalFormattingsPutWorksheetFormatConditionArea**
> SaaSposeResponse CellsConditionalFormattingsPutWorksheetFormatConditionArea (string name, string sheetName, int? index, string cellArea, string folder = null)

add a cell area for format condition             

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsConditionalFormattingsPutWorksheetFormatConditionAreaExample
    {
        public void main()
        {
            var apiInstance = new CellsConditionalFormattingsApi();
            var name = name_example;  // string | 
            var sheetName = sheetName_example;  // string | 
            var index = 56;  // int? | 
            var cellArea = cellArea_example;  // string | 
            var folder = folder_example;  // string |  (optional) 

            try
            {
                // add a cell area for format condition             
                SaaSposeResponse result = apiInstance.CellsConditionalFormattingsPutWorksheetFormatConditionArea(name, sheetName, index, cellArea, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsConditionalFormattingsApi.CellsConditionalFormattingsPutWorksheetFormatConditionArea: " + e.Message );
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
 **cellArea** | **string**|  | 
 **folder** | **string**|  | [optional] 

### Return type

[**SaaSposeResponse**](SaaSposeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellsconditionalformattingsputworksheetformatconditioncondition"></a>
# **CellsConditionalFormattingsPutWorksheetFormatConditionCondition**
> SaaSposeResponse CellsConditionalFormattingsPutWorksheetFormatConditionCondition (string name, string sheetName, int? index, string type, string operatorType, string formula1, string formula2, string folder = null)

Add a condition for format condition.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsConditionalFormattingsPutWorksheetFormatConditionConditionExample
    {
        public void main()
        {
            var apiInstance = new CellsConditionalFormattingsApi();
            var name = name_example;  // string | 
            var sheetName = sheetName_example;  // string | 
            var index = 56;  // int? | 
            var type = type_example;  // string | 
            var operatorType = operatorType_example;  // string | 
            var formula1 = formula1_example;  // string | 
            var formula2 = formula2_example;  // string | 
            var folder = folder_example;  // string |  (optional) 

            try
            {
                // Add a condition for format condition.
                SaaSposeResponse result = apiInstance.CellsConditionalFormattingsPutWorksheetFormatConditionCondition(name, sheetName, index, type, operatorType, formula1, formula2, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsConditionalFormattingsApi.CellsConditionalFormattingsPutWorksheetFormatConditionCondition: " + e.Message );
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
 **type** | **string**|  | 
 **operatorType** | **string**|  | 
 **formula1** | **string**|  | 
 **formula2** | **string**|  | 
 **folder** | **string**|  | [optional] 

### Return type

[**SaaSposeResponse**](SaaSposeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

