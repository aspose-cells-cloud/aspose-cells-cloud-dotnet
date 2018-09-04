# Aspose.Cells.Cloud.SDK.Api.CellsPivotTablesApi

All URIs are relative to *https://api.aspose.cloud/v1.1/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CellsPivotTablesDeletePivotTableField**](CellsPivotTablesApi.md#cellspivottablesdeletepivottablefield) | **DELETE** /cells/{name}/worksheets/{sheetName}/pivottables/{pivotTableIndex}/PivotField | Delete pivot field into into pivot table
[**CellsPivotTablesDeleteWorksheetPivotTable**](CellsPivotTablesApi.md#cellspivottablesdeleteworksheetpivottable) | **DELETE** /cells/{name}/worksheets/{sheetName}/pivottables/{pivotTableIndex} | Delete worksheet pivot table by index
[**CellsPivotTablesDeleteWorksheetPivotTableFilter**](CellsPivotTablesApi.md#cellspivottablesdeleteworksheetpivottablefilter) | **DELETE** /cells/{name}/worksheets/{sheetName}/pivottables/{pivotTableIndex}/PivotFilters/{fieldIndex} | delete  pivot filter for piovt table             
[**CellsPivotTablesDeleteWorksheetPivotTableFilters**](CellsPivotTablesApi.md#cellspivottablesdeleteworksheetpivottablefilters) | **DELETE** /cells/{name}/worksheets/{sheetName}/pivottables/{pivotTableIndex}/PivotFilters | delete all pivot filters for piovt table
[**CellsPivotTablesDeleteWorksheetPivotTables**](CellsPivotTablesApi.md#cellspivottablesdeleteworksheetpivottables) | **DELETE** /cells/{name}/worksheets/{sheetName}/pivottables | Delete worksheet pivot tables
[**CellsPivotTablesGetPivotTableField**](CellsPivotTablesApi.md#cellspivottablesgetpivottablefield) | **GET** /cells/{name}/worksheets/{sheetName}/pivottables/{pivotTableIndex}/PivotField | Get pivot field into into pivot table
[**CellsPivotTablesGetWorksheetPivotTable**](CellsPivotTablesApi.md#cellspivottablesgetworksheetpivottable) | **GET** /cells/{name}/worksheets/{sheetName}/pivottables/{pivottableIndex} | Get worksheet pivottable info by index.
[**CellsPivotTablesGetWorksheetPivotTableFilter**](CellsPivotTablesApi.md#cellspivottablesgetworksheetpivottablefilter) | **GET** /cells/{name}/worksheets/{sheetName}/pivottables/{pivotTableIndex}/PivotFilters/{filterIndex} | 
[**CellsPivotTablesGetWorksheetPivotTableFilters**](CellsPivotTablesApi.md#cellspivottablesgetworksheetpivottablefilters) | **GET** /cells/{name}/worksheets/{sheetName}/pivottables/{pivotTableIndex}/PivotFilters | 
[**CellsPivotTablesGetWorksheetPivotTables**](CellsPivotTablesApi.md#cellspivottablesgetworksheetpivottables) | **GET** /cells/{name}/worksheets/{sheetName}/pivottables | Get worksheet pivottables info.
[**CellsPivotTablesPostPivotTableCellStyle**](CellsPivotTablesApi.md#cellspivottablespostpivottablecellstyle) | **POST** /cells/{name}/worksheets/{sheetName}/pivottables/{pivotTableIndex}/Format | Update cell style for pivot table
[**CellsPivotTablesPostPivotTableFieldHideItem**](CellsPivotTablesApi.md#cellspivottablespostpivottablefieldhideitem) | **POST** /cells/{name}/worksheets/{sheetName}/pivottables/{pivotTableIndex}/PivotField/Hide | 
[**CellsPivotTablesPostPivotTableFieldMoveTo**](CellsPivotTablesApi.md#cellspivottablespostpivottablefieldmoveto) | **POST** /cells/{name}/worksheets/{sheetName}/pivottables/{pivotTableIndex}/PivotField/Move | 
[**CellsPivotTablesPostPivotTableStyle**](CellsPivotTablesApi.md#cellspivottablespostpivottablestyle) | **POST** /cells/{name}/worksheets/{sheetName}/pivottables/{pivotTableIndex}/FormatAll | Update style for pivot table
[**CellsPivotTablesPostWorksheetPivotTableCalculate**](CellsPivotTablesApi.md#cellspivottablespostworksheetpivottablecalculate) | **POST** /cells/{name}/worksheets/{sheetName}/pivottables/{pivotTableIndex}/Calculate | Calculates pivottable&#39;s data to cells.
[**CellsPivotTablesPostWorksheetPivotTableMove**](CellsPivotTablesApi.md#cellspivottablespostworksheetpivottablemove) | **POST** /cells/{name}/worksheets/{sheetName}/pivottables/{pivotTableIndex}/Move | 
[**CellsPivotTablesPutPivotTableField**](CellsPivotTablesApi.md#cellspivottablesputpivottablefield) | **PUT** /cells/{name}/worksheets/{sheetName}/pivottables/{pivotTableIndex}/PivotField | Add pivot field into into pivot table
[**CellsPivotTablesPutWorksheetPivotTable**](CellsPivotTablesApi.md#cellspivottablesputworksheetpivottable) | **PUT** /cells/{name}/worksheets/{sheetName}/pivottables | Add a pivot table into worksheet.
[**CellsPivotTablesPutWorksheetPivotTableFilter**](CellsPivotTablesApi.md#cellspivottablesputworksheetpivottablefilter) | **PUT** /cells/{name}/worksheets/{sheetName}/pivottables/{pivotTableIndex}/PivotFilters | Add pivot filter for piovt table index


<a name="cellspivottablesdeletepivottablefield"></a>
# **CellsPivotTablesDeletePivotTableField**
> SaaSposeResponse CellsPivotTablesDeletePivotTableField (string name, string sheetName, int? pivotTableIndex, string pivotFieldType, PivotTableFieldRequest request = null, string folder = null, string storage = null)

Delete pivot field into into pivot table

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsPivotTablesDeletePivotTableFieldExample
    {
        public void main()
        {
            var apiInstance = new CellsPivotTablesApi();
            var name = name_example;  // string | Document name.
            var sheetName = sheetName_example;  // string | The worksheet name.
            var pivotTableIndex = 56;  // int? | Pivot table index
            var pivotFieldType = pivotFieldType_example;  // string | The fields area type.
            var request = new PivotTableFieldRequest(); // PivotTableFieldRequest | Dto that conrains field indexes (optional) 
            var folder = folder_example;  // string | Document's folder. (optional) 
            var storage = storage_example;  // string | storage name. (optional) 

            try
            {
                // Delete pivot field into into pivot table
                SaaSposeResponse result = apiInstance.CellsPivotTablesDeletePivotTableField(name, sheetName, pivotTableIndex, pivotFieldType, request, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsPivotTablesApi.CellsPivotTablesDeletePivotTableField: " + e.Message );
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
 **pivotTableIndex** | **int?**| Pivot table index | 
 **pivotFieldType** | **string**| The fields area type. | 
 **request** | [**PivotTableFieldRequest**](PivotTableFieldRequest.md)| Dto that conrains field indexes | [optional] 
 **folder** | **string**| Document&#39;s folder. | [optional] 
 **storage** | **string**| storage name. | [optional] 

### Return type

[**SaaSposeResponse**](SaaSposeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellspivottablesdeleteworksheetpivottable"></a>
# **CellsPivotTablesDeleteWorksheetPivotTable**
> SaaSposeResponse CellsPivotTablesDeleteWorksheetPivotTable (string name, string sheetName, int? pivotTableIndex, string folder = null, string storage = null)

Delete worksheet pivot table by index

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsPivotTablesDeleteWorksheetPivotTableExample
    {
        public void main()
        {
            var apiInstance = new CellsPivotTablesApi();
            var name = name_example;  // string | Document name.
            var sheetName = sheetName_example;  // string | The worksheet name.
            var pivotTableIndex = 56;  // int? | Pivot table index
            var folder = folder_example;  // string | Document's folder. (optional) 
            var storage = storage_example;  // string | storage name. (optional) 

            try
            {
                // Delete worksheet pivot table by index
                SaaSposeResponse result = apiInstance.CellsPivotTablesDeleteWorksheetPivotTable(name, sheetName, pivotTableIndex, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsPivotTablesApi.CellsPivotTablesDeleteWorksheetPivotTable: " + e.Message );
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
 **pivotTableIndex** | **int?**| Pivot table index | 
 **folder** | **string**| Document&#39;s folder. | [optional] 
 **storage** | **string**| storage name. | [optional] 

### Return type

[**SaaSposeResponse**](SaaSposeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellspivottablesdeleteworksheetpivottablefilter"></a>
# **CellsPivotTablesDeleteWorksheetPivotTableFilter**
> SaaSposeResponse CellsPivotTablesDeleteWorksheetPivotTableFilter (string name, string sheetName, int? pivotTableIndex, int? fieldIndex, bool? needReCalculate = null, string folder = null, string storage = null)

delete  pivot filter for piovt table             

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsPivotTablesDeleteWorksheetPivotTableFilterExample
    {
        public void main()
        {
            var apiInstance = new CellsPivotTablesApi();
            var name = name_example;  // string | 
            var sheetName = sheetName_example;  // string | 
            var pivotTableIndex = 56;  // int? | 
            var fieldIndex = 56;  // int? | 
            var needReCalculate = true;  // bool? |  (optional)  (default to false)
            var folder = folder_example;  // string |  (optional) 
            var storage = storage_example;  // string | storage name. (optional) 

            try
            {
                // delete  pivot filter for piovt table             
                SaaSposeResponse result = apiInstance.CellsPivotTablesDeleteWorksheetPivotTableFilter(name, sheetName, pivotTableIndex, fieldIndex, needReCalculate, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsPivotTablesApi.CellsPivotTablesDeleteWorksheetPivotTableFilter: " + e.Message );
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
 **pivotTableIndex** | **int?**|  | 
 **fieldIndex** | **int?**|  | 
 **needReCalculate** | **bool?**|  | [optional] [default to false]
 **folder** | **string**|  | [optional] 
 **storage** | **string**| storage name. | [optional] 

### Return type

[**SaaSposeResponse**](SaaSposeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellspivottablesdeleteworksheetpivottablefilters"></a>
# **CellsPivotTablesDeleteWorksheetPivotTableFilters**
> SaaSposeResponse CellsPivotTablesDeleteWorksheetPivotTableFilters (string name, string sheetName, int? pivotTableIndex, bool? needReCalculate = null, string folder = null, string storage = null)

delete all pivot filters for piovt table

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsPivotTablesDeleteWorksheetPivotTableFiltersExample
    {
        public void main()
        {
            var apiInstance = new CellsPivotTablesApi();
            var name = name_example;  // string | 
            var sheetName = sheetName_example;  // string | 
            var pivotTableIndex = 56;  // int? | 
            var needReCalculate = true;  // bool? |  (optional)  (default to false)
            var folder = folder_example;  // string |  (optional) 
            var storage = storage_example;  // string | storage name. (optional) 

            try
            {
                // delete all pivot filters for piovt table
                SaaSposeResponse result = apiInstance.CellsPivotTablesDeleteWorksheetPivotTableFilters(name, sheetName, pivotTableIndex, needReCalculate, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsPivotTablesApi.CellsPivotTablesDeleteWorksheetPivotTableFilters: " + e.Message );
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
 **pivotTableIndex** | **int?**|  | 
 **needReCalculate** | **bool?**|  | [optional] [default to false]
 **folder** | **string**|  | [optional] 
 **storage** | **string**| storage name. | [optional] 

### Return type

[**SaaSposeResponse**](SaaSposeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellspivottablesdeleteworksheetpivottables"></a>
# **CellsPivotTablesDeleteWorksheetPivotTables**
> SaaSposeResponse CellsPivotTablesDeleteWorksheetPivotTables (string name, string sheetName, string folder = null, string storage = null)

Delete worksheet pivot tables

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsPivotTablesDeleteWorksheetPivotTablesExample
    {
        public void main()
        {
            var apiInstance = new CellsPivotTablesApi();
            var name = name_example;  // string | Document name.
            var sheetName = sheetName_example;  // string | The worksheet name.
            var folder = folder_example;  // string | Document's folder. (optional) 
            var storage = storage_example;  // string | storage name. (optional) 

            try
            {
                // Delete worksheet pivot tables
                SaaSposeResponse result = apiInstance.CellsPivotTablesDeleteWorksheetPivotTables(name, sheetName, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsPivotTablesApi.CellsPivotTablesDeleteWorksheetPivotTables: " + e.Message );
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

[**SaaSposeResponse**](SaaSposeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellspivottablesgetpivottablefield"></a>
# **CellsPivotTablesGetPivotTableField**
> PivotFieldResponse CellsPivotTablesGetPivotTableField (string name, string sheetName, int? pivotTableIndex, int? pivotFieldIndex, string pivotFieldType, string folder = null, string storage = null)

Get pivot field into into pivot table

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsPivotTablesGetPivotTableFieldExample
    {
        public void main()
        {
            var apiInstance = new CellsPivotTablesApi();
            var name = name_example;  // string | Document name.
            var sheetName = sheetName_example;  // string | The worksheet name.
            var pivotTableIndex = 56;  // int? | Pivot table index
            var pivotFieldIndex = 56;  // int? | The field index in the base fields.
            var pivotFieldType = pivotFieldType_example;  // string | The fields area type.
            var folder = folder_example;  // string | Document's folder. (optional) 
            var storage = storage_example;  // string | storage name. (optional) 

            try
            {
                // Get pivot field into into pivot table
                PivotFieldResponse result = apiInstance.CellsPivotTablesGetPivotTableField(name, sheetName, pivotTableIndex, pivotFieldIndex, pivotFieldType, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsPivotTablesApi.CellsPivotTablesGetPivotTableField: " + e.Message );
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
 **pivotTableIndex** | **int?**| Pivot table index | 
 **pivotFieldIndex** | **int?**| The field index in the base fields. | 
 **pivotFieldType** | **string**| The fields area type. | 
 **folder** | **string**| Document&#39;s folder. | [optional] 
 **storage** | **string**| storage name. | [optional] 

### Return type

[**PivotFieldResponse**](PivotFieldResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellspivottablesgetworksheetpivottable"></a>
# **CellsPivotTablesGetWorksheetPivotTable**
> PivotTableResponse CellsPivotTablesGetWorksheetPivotTable (string name, string sheetName, int? pivottableIndex, string folder = null, string storage = null)

Get worksheet pivottable info by index.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsPivotTablesGetWorksheetPivotTableExample
    {
        public void main()
        {
            var apiInstance = new CellsPivotTablesApi();
            var name = name_example;  // string | Document name.
            var sheetName = sheetName_example;  // string | The worksheet name.
            var pivottableIndex = 56;  // int? | 
            var folder = folder_example;  // string | Document's folder. (optional) 
            var storage = storage_example;  // string | storage name. (optional) 

            try
            {
                // Get worksheet pivottable info by index.
                PivotTableResponse result = apiInstance.CellsPivotTablesGetWorksheetPivotTable(name, sheetName, pivottableIndex, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsPivotTablesApi.CellsPivotTablesGetWorksheetPivotTable: " + e.Message );
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
 **pivottableIndex** | **int?**|  | 
 **folder** | **string**| Document&#39;s folder. | [optional] 
 **storage** | **string**| storage name. | [optional] 

### Return type

[**PivotTableResponse**](PivotTableResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellspivottablesgetworksheetpivottablefilter"></a>
# **CellsPivotTablesGetWorksheetPivotTableFilter**
> PivotFilterResponse CellsPivotTablesGetWorksheetPivotTableFilter (string name, string sheetName, int? pivotTableIndex, int? filterIndex, string folder = null, string storage = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsPivotTablesGetWorksheetPivotTableFilterExample
    {
        public void main()
        {
            var apiInstance = new CellsPivotTablesApi();
            var name = name_example;  // string | 
            var sheetName = sheetName_example;  // string | 
            var pivotTableIndex = 56;  // int? | 
            var filterIndex = 56;  // int? | 
            var folder = folder_example;  // string |  (optional) 
            var storage = storage_example;  // string | storage name. (optional) 

            try
            {
                PivotFilterResponse result = apiInstance.CellsPivotTablesGetWorksheetPivotTableFilter(name, sheetName, pivotTableIndex, filterIndex, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsPivotTablesApi.CellsPivotTablesGetWorksheetPivotTableFilter: " + e.Message );
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
 **pivotTableIndex** | **int?**|  | 
 **filterIndex** | **int?**|  | 
 **folder** | **string**|  | [optional] 
 **storage** | **string**| storage name. | [optional] 

### Return type

[**PivotFilterResponse**](PivotFilterResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellspivottablesgetworksheetpivottablefilters"></a>
# **CellsPivotTablesGetWorksheetPivotTableFilters**
> PivotFiltersResponse CellsPivotTablesGetWorksheetPivotTableFilters (string name, string sheetName, int? pivotTableIndex, string folder = null, string storage = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsPivotTablesGetWorksheetPivotTableFiltersExample
    {
        public void main()
        {
            var apiInstance = new CellsPivotTablesApi();
            var name = name_example;  // string | 
            var sheetName = sheetName_example;  // string | 
            var pivotTableIndex = 56;  // int? | 
            var folder = folder_example;  // string |  (optional) 
            var storage = storage_example;  // string | storage name. (optional) 

            try
            {
                PivotFiltersResponse result = apiInstance.CellsPivotTablesGetWorksheetPivotTableFilters(name, sheetName, pivotTableIndex, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsPivotTablesApi.CellsPivotTablesGetWorksheetPivotTableFilters: " + e.Message );
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
 **pivotTableIndex** | **int?**|  | 
 **folder** | **string**|  | [optional] 
 **storage** | **string**| storage name. | [optional] 

### Return type

[**PivotFiltersResponse**](PivotFiltersResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellspivottablesgetworksheetpivottables"></a>
# **CellsPivotTablesGetWorksheetPivotTables**
> PivotTablesResponse CellsPivotTablesGetWorksheetPivotTables (string name, string sheetName, string folder = null, string storage = null)

Get worksheet pivottables info.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsPivotTablesGetWorksheetPivotTablesExample
    {
        public void main()
        {
            var apiInstance = new CellsPivotTablesApi();
            var name = name_example;  // string | Document name.
            var sheetName = sheetName_example;  // string | The worksheet name.
            var folder = folder_example;  // string | Document's folder. (optional) 
            var storage = storage_example;  // string | storage name. (optional) 

            try
            {
                // Get worksheet pivottables info.
                PivotTablesResponse result = apiInstance.CellsPivotTablesGetWorksheetPivotTables(name, sheetName, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsPivotTablesApi.CellsPivotTablesGetWorksheetPivotTables: " + e.Message );
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

[**PivotTablesResponse**](PivotTablesResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellspivottablespostpivottablecellstyle"></a>
# **CellsPivotTablesPostPivotTableCellStyle**
> SaaSposeResponse CellsPivotTablesPostPivotTableCellStyle (string name, string sheetName, int? pivotTableIndex, int? column, int? row, Style style = null, bool? needReCalculate = null, string folder = null, string storage = null)

Update cell style for pivot table

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsPivotTablesPostPivotTableCellStyleExample
    {
        public void main()
        {
            var apiInstance = new CellsPivotTablesApi();
            var name = name_example;  // string | Document name.
            var sheetName = sheetName_example;  // string | The worksheet name.
            var pivotTableIndex = 56;  // int? | Pivot table index
            var column = 56;  // int? | 
            var row = 56;  // int? | 
            var style = new Style(); // Style | Style dto in request body. (optional) 
            var needReCalculate = true;  // bool? |  (optional)  (default to false)
            var folder = folder_example;  // string | Document's folder. (optional) 
            var storage = storage_example;  // string | storage name. (optional) 

            try
            {
                // Update cell style for pivot table
                SaaSposeResponse result = apiInstance.CellsPivotTablesPostPivotTableCellStyle(name, sheetName, pivotTableIndex, column, row, style, needReCalculate, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsPivotTablesApi.CellsPivotTablesPostPivotTableCellStyle: " + e.Message );
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
 **pivotTableIndex** | **int?**| Pivot table index | 
 **column** | **int?**|  | 
 **row** | **int?**|  | 
 **style** | [**Style**](Style.md)| Style dto in request body. | [optional] 
 **needReCalculate** | **bool?**|  | [optional] [default to false]
 **folder** | **string**| Document&#39;s folder. | [optional] 
 **storage** | **string**| storage name. | [optional] 

### Return type

[**SaaSposeResponse**](SaaSposeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellspivottablespostpivottablefieldhideitem"></a>
# **CellsPivotTablesPostPivotTableFieldHideItem**
> SaaSposeResponse CellsPivotTablesPostPivotTableFieldHideItem (string name, string sheetName, int? pivotTableIndex, string pivotFieldType, int? fieldIndex, int? itemIndex, bool? isHide, bool? needReCalculate = null, string folder = null, string storage = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsPivotTablesPostPivotTableFieldHideItemExample
    {
        public void main()
        {
            var apiInstance = new CellsPivotTablesApi();
            var name = name_example;  // string | 
            var sheetName = sheetName_example;  // string | 
            var pivotTableIndex = 56;  // int? | 
            var pivotFieldType = pivotFieldType_example;  // string | 
            var fieldIndex = 56;  // int? | 
            var itemIndex = 56;  // int? | 
            var isHide = true;  // bool? | 
            var needReCalculate = true;  // bool? |  (optional)  (default to false)
            var folder = folder_example;  // string |  (optional) 
            var storage = storage_example;  // string | storage name. (optional) 

            try
            {
                SaaSposeResponse result = apiInstance.CellsPivotTablesPostPivotTableFieldHideItem(name, sheetName, pivotTableIndex, pivotFieldType, fieldIndex, itemIndex, isHide, needReCalculate, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsPivotTablesApi.CellsPivotTablesPostPivotTableFieldHideItem: " + e.Message );
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
 **pivotTableIndex** | **int?**|  | 
 **pivotFieldType** | **string**|  | 
 **fieldIndex** | **int?**|  | 
 **itemIndex** | **int?**|  | 
 **isHide** | **bool?**|  | 
 **needReCalculate** | **bool?**|  | [optional] [default to false]
 **folder** | **string**|  | [optional] 
 **storage** | **string**| storage name. | [optional] 

### Return type

[**SaaSposeResponse**](SaaSposeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellspivottablespostpivottablefieldmoveto"></a>
# **CellsPivotTablesPostPivotTableFieldMoveTo**
> SaaSposeResponse CellsPivotTablesPostPivotTableFieldMoveTo (string name, string sheetName, int? pivotTableIndex, int? fieldIndex, string from, string to, string folder = null, string storage = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsPivotTablesPostPivotTableFieldMoveToExample
    {
        public void main()
        {
            var apiInstance = new CellsPivotTablesApi();
            var name = name_example;  // string | 
            var sheetName = sheetName_example;  // string | 
            var pivotTableIndex = 56;  // int? | 
            var fieldIndex = 56;  // int? | 
            var from = from_example;  // string | 
            var to = to_example;  // string | 
            var folder = folder_example;  // string |  (optional) 
            var storage = storage_example;  // string | storage name. (optional) 

            try
            {
                SaaSposeResponse result = apiInstance.CellsPivotTablesPostPivotTableFieldMoveTo(name, sheetName, pivotTableIndex, fieldIndex, from, to, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsPivotTablesApi.CellsPivotTablesPostPivotTableFieldMoveTo: " + e.Message );
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
 **pivotTableIndex** | **int?**|  | 
 **fieldIndex** | **int?**|  | 
 **from** | **string**|  | 
 **to** | **string**|  | 
 **folder** | **string**|  | [optional] 
 **storage** | **string**| storage name. | [optional] 

### Return type

[**SaaSposeResponse**](SaaSposeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellspivottablespostpivottablestyle"></a>
# **CellsPivotTablesPostPivotTableStyle**
> SaaSposeResponse CellsPivotTablesPostPivotTableStyle (string name, string sheetName, int? pivotTableIndex, Style style = null, bool? needReCalculate = null, string folder = null, string storage = null)

Update style for pivot table

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsPivotTablesPostPivotTableStyleExample
    {
        public void main()
        {
            var apiInstance = new CellsPivotTablesApi();
            var name = name_example;  // string | Document name.
            var sheetName = sheetName_example;  // string | The worksheet name.
            var pivotTableIndex = 56;  // int? | Pivot table index
            var style = new Style(); // Style | Style dto in request body. (optional) 
            var needReCalculate = true;  // bool? |  (optional)  (default to false)
            var folder = folder_example;  // string | Document's folder. (optional) 
            var storage = storage_example;  // string | storage name. (optional) 

            try
            {
                // Update style for pivot table
                SaaSposeResponse result = apiInstance.CellsPivotTablesPostPivotTableStyle(name, sheetName, pivotTableIndex, style, needReCalculate, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsPivotTablesApi.CellsPivotTablesPostPivotTableStyle: " + e.Message );
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
 **pivotTableIndex** | **int?**| Pivot table index | 
 **style** | [**Style**](Style.md)| Style dto in request body. | [optional] 
 **needReCalculate** | **bool?**|  | [optional] [default to false]
 **folder** | **string**| Document&#39;s folder. | [optional] 
 **storage** | **string**| storage name. | [optional] 

### Return type

[**SaaSposeResponse**](SaaSposeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellspivottablespostworksheetpivottablecalculate"></a>
# **CellsPivotTablesPostWorksheetPivotTableCalculate**
> SaaSposeResponse CellsPivotTablesPostWorksheetPivotTableCalculate (string name, string sheetName, int? pivotTableIndex, string folder = null, string storage = null)

Calculates pivottable's data to cells.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsPivotTablesPostWorksheetPivotTableCalculateExample
    {
        public void main()
        {
            var apiInstance = new CellsPivotTablesApi();
            var name = name_example;  // string | Document name.
            var sheetName = sheetName_example;  // string | The worksheet name.
            var pivotTableIndex = 56;  // int? | Pivot table index
            var folder = folder_example;  // string | Document's folder. (optional) 
            var storage = storage_example;  // string | storage name. (optional) 

            try
            {
                // Calculates pivottable's data to cells.
                SaaSposeResponse result = apiInstance.CellsPivotTablesPostWorksheetPivotTableCalculate(name, sheetName, pivotTableIndex, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsPivotTablesApi.CellsPivotTablesPostWorksheetPivotTableCalculate: " + e.Message );
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
 **pivotTableIndex** | **int?**| Pivot table index | 
 **folder** | **string**| Document&#39;s folder. | [optional] 
 **storage** | **string**| storage name. | [optional] 

### Return type

[**SaaSposeResponse**](SaaSposeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellspivottablespostworksheetpivottablemove"></a>
# **CellsPivotTablesPostWorksheetPivotTableMove**
> SaaSposeResponse CellsPivotTablesPostWorksheetPivotTableMove (string name, string sheetName, int? pivotTableIndex, int? row = null, int? column = null, string destCellName = null, string folder = null, string storage = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsPivotTablesPostWorksheetPivotTableMoveExample
    {
        public void main()
        {
            var apiInstance = new CellsPivotTablesApi();
            var name = name_example;  // string | 
            var sheetName = sheetName_example;  // string | 
            var pivotTableIndex = 56;  // int? | 
            var row = 56;  // int? |  (optional) 
            var column = 56;  // int? |  (optional) 
            var destCellName = destCellName_example;  // string |  (optional) 
            var folder = folder_example;  // string |  (optional) 
            var storage = storage_example;  // string | storage name. (optional) 

            try
            {
                SaaSposeResponse result = apiInstance.CellsPivotTablesPostWorksheetPivotTableMove(name, sheetName, pivotTableIndex, row, column, destCellName, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsPivotTablesApi.CellsPivotTablesPostWorksheetPivotTableMove: " + e.Message );
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
 **pivotTableIndex** | **int?**|  | 
 **row** | **int?**|  | [optional] 
 **column** | **int?**|  | [optional] 
 **destCellName** | **string**|  | [optional] 
 **folder** | **string**|  | [optional] 
 **storage** | **string**| storage name. | [optional] 

### Return type

[**SaaSposeResponse**](SaaSposeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellspivottablesputpivottablefield"></a>
# **CellsPivotTablesPutPivotTableField**
> SaaSposeResponse CellsPivotTablesPutPivotTableField (string name, string sheetName, int? pivotTableIndex, string pivotFieldType, PivotTableFieldRequest request = null, bool? needReCalculate = null, string folder = null, string storage = null)

Add pivot field into into pivot table

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsPivotTablesPutPivotTableFieldExample
    {
        public void main()
        {
            var apiInstance = new CellsPivotTablesApi();
            var name = name_example;  // string | Document name.
            var sheetName = sheetName_example;  // string | The worksheet name.
            var pivotTableIndex = 56;  // int? | Pivot table index
            var pivotFieldType = pivotFieldType_example;  // string | The fields area type.
            var request = new PivotTableFieldRequest(); // PivotTableFieldRequest | Dto that conrains field indexes (optional) 
            var needReCalculate = true;  // bool? |  (optional)  (default to false)
            var folder = folder_example;  // string | Document's folder. (optional) 
            var storage = storage_example;  // string | storage name. (optional) 

            try
            {
                // Add pivot field into into pivot table
                SaaSposeResponse result = apiInstance.CellsPivotTablesPutPivotTableField(name, sheetName, pivotTableIndex, pivotFieldType, request, needReCalculate, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsPivotTablesApi.CellsPivotTablesPutPivotTableField: " + e.Message );
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
 **pivotTableIndex** | **int?**| Pivot table index | 
 **pivotFieldType** | **string**| The fields area type. | 
 **request** | [**PivotTableFieldRequest**](PivotTableFieldRequest.md)| Dto that conrains field indexes | [optional] 
 **needReCalculate** | **bool?**|  | [optional] [default to false]
 **folder** | **string**| Document&#39;s folder. | [optional] 
 **storage** | **string**| storage name. | [optional] 

### Return type

[**SaaSposeResponse**](SaaSposeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellspivottablesputworksheetpivottable"></a>
# **CellsPivotTablesPutWorksheetPivotTable**
> PivotTableResponse CellsPivotTablesPutWorksheetPivotTable (string name, string sheetName, CreatePivotTableRequest request = null, string folder = null, string storage = null, string sourceData = null, string destCellName = null, string tableName = null, bool? useSameSource = null)

Add a pivot table into worksheet.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsPivotTablesPutWorksheetPivotTableExample
    {
        public void main()
        {
            var apiInstance = new CellsPivotTablesApi();
            var name = name_example;  // string | Document name.
            var sheetName = sheetName_example;  // string | The worksheet name.
            var request = new CreatePivotTableRequest(); // CreatePivotTableRequest | CreatePivotTableRequest dto in request body. (optional) 
            var folder = folder_example;  // string | Document's folder. (optional) 
            var storage = storage_example;  // string | storage name. (optional) 
            var sourceData = sourceData_example;  // string | The data for the new PivotTable cache. (optional) 
            var destCellName = destCellName_example;  // string | The cell in the upper-left corner of the PivotTable report's destination range. (optional) 
            var tableName = tableName_example;  // string | The name of the new PivotTable report. (optional) 
            var useSameSource = true;  // bool? | Indicates whether using same data source when another existing pivot table has used this data source. If the property is true, it will save memory. (optional) 

            try
            {
                // Add a pivot table into worksheet.
                PivotTableResponse result = apiInstance.CellsPivotTablesPutWorksheetPivotTable(name, sheetName, request, folder, storage, sourceData, destCellName, tableName, useSameSource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsPivotTablesApi.CellsPivotTablesPutWorksheetPivotTable: " + e.Message );
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
 **request** | [**CreatePivotTableRequest**](CreatePivotTableRequest.md)| CreatePivotTableRequest dto in request body. | [optional] 
 **folder** | **string**| Document&#39;s folder. | [optional] 
 **storage** | **string**| storage name. | [optional] 
 **sourceData** | **string**| The data for the new PivotTable cache. | [optional] 
 **destCellName** | **string**| The cell in the upper-left corner of the PivotTable report&#39;s destination range. | [optional] 
 **tableName** | **string**| The name of the new PivotTable report. | [optional] 
 **useSameSource** | **bool?**| Indicates whether using same data source when another existing pivot table has used this data source. If the property is true, it will save memory. | [optional] 

### Return type

[**PivotTableResponse**](PivotTableResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellspivottablesputworksheetpivottablefilter"></a>
# **CellsPivotTablesPutWorksheetPivotTableFilter**
> SaaSposeResponse CellsPivotTablesPutWorksheetPivotTableFilter (string name, string sheetName, int? pivotTableIndex, PivotFilter filter = null, bool? needReCalculate = null, string folder = null, string storage = null)

Add pivot filter for piovt table index

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsPivotTablesPutWorksheetPivotTableFilterExample
    {
        public void main()
        {
            var apiInstance = new CellsPivotTablesApi();
            var name = name_example;  // string | 
            var sheetName = sheetName_example;  // string | 
            var pivotTableIndex = 56;  // int? | 
            var filter = new PivotFilter(); // PivotFilter |  (optional) 
            var needReCalculate = true;  // bool? |  (optional)  (default to false)
            var folder = folder_example;  // string |  (optional) 
            var storage = storage_example;  // string | storage name. (optional) 

            try
            {
                // Add pivot filter for piovt table index
                SaaSposeResponse result = apiInstance.CellsPivotTablesPutWorksheetPivotTableFilter(name, sheetName, pivotTableIndex, filter, needReCalculate, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsPivotTablesApi.CellsPivotTablesPutWorksheetPivotTableFilter: " + e.Message );
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
 **pivotTableIndex** | **int?**|  | 
 **filter** | [**PivotFilter**](PivotFilter.md)|  | [optional] 
 **needReCalculate** | **bool?**|  | [optional] [default to false]
 **folder** | **string**|  | [optional] 
 **storage** | **string**| storage name. | [optional] 

### Return type

[**SaaSposeResponse**](SaaSposeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

