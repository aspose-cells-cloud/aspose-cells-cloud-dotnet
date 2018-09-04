# Aspose.Cells.Cloud.SDK.Api.CellsListObjectsApi

All URIs are relative to *https://api.aspose.cloud/v1.1/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CellsListObjectsDeleteWorksheetListObject**](CellsListObjectsApi.md#cellslistobjectsdeleteworksheetlistobject) | **DELETE** /cells/{name}/worksheets/{sheetName}/listobjects/{listObjectIndex} | Delete worksheet list object by index
[**CellsListObjectsDeleteWorksheetListObjects**](CellsListObjectsApi.md#cellslistobjectsdeleteworksheetlistobjects) | **DELETE** /cells/{name}/worksheets/{sheetName}/listobjects | Delete worksheet list objects
[**CellsListObjectsGetWorksheetListObject**](CellsListObjectsApi.md#cellslistobjectsgetworksheetlistobject) | **GET** /cells/{name}/worksheets/{sheetName}/listobjects/{listobjectindex} | Get worksheet list object info by index.
[**CellsListObjectsGetWorksheetListObjects**](CellsListObjectsApi.md#cellslistobjectsgetworksheetlistobjects) | **GET** /cells/{name}/worksheets/{sheetName}/listobjects | Get worksheet listobjects info.
[**CellsListObjectsPostWorksheetListObject**](CellsListObjectsApi.md#cellslistobjectspostworksheetlistobject) | **POST** /cells/{name}/worksheets/{sheetName}/listobjects/{listObjectIndex} | Update  list object 
[**CellsListObjectsPostWorksheetListObjectConvertToRange**](CellsListObjectsApi.md#cellslistobjectspostworksheetlistobjectconverttorange) | **POST** /cells/{name}/worksheets/{sheetName}/listobjects/{listObjectIndex}/ConvertToRange | 
[**CellsListObjectsPostWorksheetListObjectSortTable**](CellsListObjectsApi.md#cellslistobjectspostworksheetlistobjectsorttable) | **POST** /cells/{name}/worksheets/{sheetName}/listobjects/{listObjectIndex}/sort | 
[**CellsListObjectsPostWorksheetListObjectSummarizeWithPivotTable**](CellsListObjectsApi.md#cellslistobjectspostworksheetlistobjectsummarizewithpivottable) | **POST** /cells/{name}/worksheets/{sheetName}/listobjects/{listObjectIndex}/SummarizeWithPivotTable | 
[**CellsListObjectsPutWorksheetListObject**](CellsListObjectsApi.md#cellslistobjectsputworksheetlistobject) | **PUT** /cells/{name}/worksheets/{sheetName}/listobjects | Add a list object into worksheet.


<a name="cellslistobjectsdeleteworksheetlistobject"></a>
# **CellsListObjectsDeleteWorksheetListObject**
> SaaSposeResponse CellsListObjectsDeleteWorksheetListObject (string name, string sheetName, int? listObjectIndex, string folder = null, string storage = null)

Delete worksheet list object by index

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsListObjectsDeleteWorksheetListObjectExample
    {
        public void main()
        {
            var apiInstance = new CellsListObjectsApi();
            var name = name_example;  // string | Document name.
            var sheetName = sheetName_example;  // string | The worksheet name.
            var listObjectIndex = 56;  // int? | List object index
            var folder = folder_example;  // string | Document's folder. (optional) 
            var storage = storage_example;  // string | storage name. (optional) 

            try
            {
                // Delete worksheet list object by index
                SaaSposeResponse result = apiInstance.CellsListObjectsDeleteWorksheetListObject(name, sheetName, listObjectIndex, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsListObjectsApi.CellsListObjectsDeleteWorksheetListObject: " + e.Message );
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
 **listObjectIndex** | **int?**| List object index | 
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

<a name="cellslistobjectsdeleteworksheetlistobjects"></a>
# **CellsListObjectsDeleteWorksheetListObjects**
> SaaSposeResponse CellsListObjectsDeleteWorksheetListObjects (string name, string sheetName, string folder = null, string storage = null)

Delete worksheet list objects

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsListObjectsDeleteWorksheetListObjectsExample
    {
        public void main()
        {
            var apiInstance = new CellsListObjectsApi();
            var name = name_example;  // string | Document name.
            var sheetName = sheetName_example;  // string | The worksheet name.
            var folder = folder_example;  // string | Document's folder. (optional) 
            var storage = storage_example;  // string | storage name. (optional) 

            try
            {
                // Delete worksheet list objects
                SaaSposeResponse result = apiInstance.CellsListObjectsDeleteWorksheetListObjects(name, sheetName, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsListObjectsApi.CellsListObjectsDeleteWorksheetListObjects: " + e.Message );
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

<a name="cellslistobjectsgetworksheetlistobject"></a>
# **CellsListObjectsGetWorksheetListObject**
> ListObjectResponse CellsListObjectsGetWorksheetListObject (string name, string sheetName, int? listobjectindex, string folder = null, string storage = null)

Get worksheet list object info by index.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsListObjectsGetWorksheetListObjectExample
    {
        public void main()
        {
            var apiInstance = new CellsListObjectsApi();
            var name = name_example;  // string | Document name.
            var sheetName = sheetName_example;  // string | The worksheet name.
            var listobjectindex = 56;  // int? | list object index.
            var folder = folder_example;  // string | Document's folder. (optional) 
            var storage = storage_example;  // string | storage name. (optional) 

            try
            {
                // Get worksheet list object info by index.
                ListObjectResponse result = apiInstance.CellsListObjectsGetWorksheetListObject(name, sheetName, listobjectindex, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsListObjectsApi.CellsListObjectsGetWorksheetListObject: " + e.Message );
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
 **listobjectindex** | **int?**| list object index. | 
 **folder** | **string**| Document&#39;s folder. | [optional] 
 **storage** | **string**| storage name. | [optional] 

### Return type

[**ListObjectResponse**](ListObjectResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellslistobjectsgetworksheetlistobjects"></a>
# **CellsListObjectsGetWorksheetListObjects**
> ListObjectsResponse CellsListObjectsGetWorksheetListObjects (string name, string sheetName, string folder = null, string storage = null)

Get worksheet listobjects info.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsListObjectsGetWorksheetListObjectsExample
    {
        public void main()
        {
            var apiInstance = new CellsListObjectsApi();
            var name = name_example;  // string | Document name.
            var sheetName = sheetName_example;  // string | The worksheet name.
            var folder = folder_example;  // string | Document's folder. (optional) 
            var storage = storage_example;  // string | storage name. (optional) 

            try
            {
                // Get worksheet listobjects info.
                ListObjectsResponse result = apiInstance.CellsListObjectsGetWorksheetListObjects(name, sheetName, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsListObjectsApi.CellsListObjectsGetWorksheetListObjects: " + e.Message );
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

[**ListObjectsResponse**](ListObjectsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellslistobjectspostworksheetlistobject"></a>
# **CellsListObjectsPostWorksheetListObject**
> SaaSposeResponse CellsListObjectsPostWorksheetListObject (string name, string sheetName, int? listObjectIndex, ListObject listObject = null, string folder = null, string storage = null)

Update  list object 

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsListObjectsPostWorksheetListObjectExample
    {
        public void main()
        {
            var apiInstance = new CellsListObjectsApi();
            var name = name_example;  // string | Document name.
            var sheetName = sheetName_example;  // string | The worksheet name.
            var listObjectIndex = 56;  // int? | list Object index
            var listObject = new ListObject(); // ListObject | listObject dto in request body. (optional) 
            var folder = folder_example;  // string | Document's folder. (optional) 
            var storage = storage_example;  // string | storage name. (optional) 

            try
            {
                // Update  list object 
                SaaSposeResponse result = apiInstance.CellsListObjectsPostWorksheetListObject(name, sheetName, listObjectIndex, listObject, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsListObjectsApi.CellsListObjectsPostWorksheetListObject: " + e.Message );
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
 **listObjectIndex** | **int?**| list Object index | 
 **listObject** | [**ListObject**](ListObject.md)| listObject dto in request body. | [optional] 
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

<a name="cellslistobjectspostworksheetlistobjectconverttorange"></a>
# **CellsListObjectsPostWorksheetListObjectConvertToRange**
> SaaSposeResponse CellsListObjectsPostWorksheetListObjectConvertToRange (string name, string sheetName, int? listObjectIndex, string folder = null, string storage = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsListObjectsPostWorksheetListObjectConvertToRangeExample
    {
        public void main()
        {
            var apiInstance = new CellsListObjectsApi();
            var name = name_example;  // string | 
            var sheetName = sheetName_example;  // string | 
            var listObjectIndex = 56;  // int? | 
            var folder = folder_example;  // string |  (optional) 
            var storage = storage_example;  // string | storage name. (optional) 

            try
            {
                SaaSposeResponse result = apiInstance.CellsListObjectsPostWorksheetListObjectConvertToRange(name, sheetName, listObjectIndex, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsListObjectsApi.CellsListObjectsPostWorksheetListObjectConvertToRange: " + e.Message );
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
 **listObjectIndex** | **int?**|  | 
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

<a name="cellslistobjectspostworksheetlistobjectsorttable"></a>
# **CellsListObjectsPostWorksheetListObjectSortTable**
> SaaSposeResponse CellsListObjectsPostWorksheetListObjectSortTable (string name, string sheetName, int? listObjectIndex, DataSorter dataSorter = null, string folder = null, string storage = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsListObjectsPostWorksheetListObjectSortTableExample
    {
        public void main()
        {
            var apiInstance = new CellsListObjectsApi();
            var name = name_example;  // string | 
            var sheetName = sheetName_example;  // string | 
            var listObjectIndex = 56;  // int? | 
            var dataSorter = new DataSorter(); // DataSorter |  (optional) 
            var folder = folder_example;  // string |  (optional) 
            var storage = storage_example;  // string | storage name. (optional) 

            try
            {
                SaaSposeResponse result = apiInstance.CellsListObjectsPostWorksheetListObjectSortTable(name, sheetName, listObjectIndex, dataSorter, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsListObjectsApi.CellsListObjectsPostWorksheetListObjectSortTable: " + e.Message );
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
 **listObjectIndex** | **int?**|  | 
 **dataSorter** | [**DataSorter**](DataSorter.md)|  | [optional] 
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

<a name="cellslistobjectspostworksheetlistobjectsummarizewithpivottable"></a>
# **CellsListObjectsPostWorksheetListObjectSummarizeWithPivotTable**
> SaaSposeResponse CellsListObjectsPostWorksheetListObjectSummarizeWithPivotTable (string name, string sheetName, int? listObjectIndex, string destsheetName, CreatePivotTableRequest request = null, string folder = null, string storage = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsListObjectsPostWorksheetListObjectSummarizeWithPivotTableExample
    {
        public void main()
        {
            var apiInstance = new CellsListObjectsApi();
            var name = name_example;  // string | 
            var sheetName = sheetName_example;  // string | 
            var listObjectIndex = 56;  // int? | 
            var destsheetName = destsheetName_example;  // string | 
            var request = new CreatePivotTableRequest(); // CreatePivotTableRequest |  (optional) 
            var folder = folder_example;  // string |  (optional) 
            var storage = storage_example;  // string | storage name. (optional) 

            try
            {
                SaaSposeResponse result = apiInstance.CellsListObjectsPostWorksheetListObjectSummarizeWithPivotTable(name, sheetName, listObjectIndex, destsheetName, request, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsListObjectsApi.CellsListObjectsPostWorksheetListObjectSummarizeWithPivotTable: " + e.Message );
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
 **listObjectIndex** | **int?**|  | 
 **destsheetName** | **string**|  | 
 **request** | [**CreatePivotTableRequest**](CreatePivotTableRequest.md)|  | [optional] 
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

<a name="cellslistobjectsputworksheetlistobject"></a>
# **CellsListObjectsPutWorksheetListObject**
> ListObjectResponse CellsListObjectsPutWorksheetListObject (string name, string sheetName, int? startRow, int? startColumn, int? endRow, int? endColumn, string folder = null, string storage = null, bool? hasHeaders = null)

Add a list object into worksheet.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsListObjectsPutWorksheetListObjectExample
    {
        public void main()
        {
            var apiInstance = new CellsListObjectsApi();
            var name = name_example;  // string | Document name.
            var sheetName = sheetName_example;  // string | The worksheet name.
            var startRow = 56;  // int? | The start row of the list range.
            var startColumn = 56;  // int? | The start row of the list range.
            var endRow = 56;  // int? | The start row of the list range.
            var endColumn = 56;  // int? | The start row of the list range.
            var folder = folder_example;  // string | Document's folder. (optional) 
            var storage = storage_example;  // string | storage name. (optional) 
            var hasHeaders = true;  // bool? | Whether the range has headers. (optional)  (default to true)

            try
            {
                // Add a list object into worksheet.
                ListObjectResponse result = apiInstance.CellsListObjectsPutWorksheetListObject(name, sheetName, startRow, startColumn, endRow, endColumn, folder, storage, hasHeaders);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsListObjectsApi.CellsListObjectsPutWorksheetListObject: " + e.Message );
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
 **startRow** | **int?**| The start row of the list range. | 
 **startColumn** | **int?**| The start row of the list range. | 
 **endRow** | **int?**| The start row of the list range. | 
 **endColumn** | **int?**| The start row of the list range. | 
 **folder** | **string**| Document&#39;s folder. | [optional] 
 **storage** | **string**| storage name. | [optional] 
 **hasHeaders** | **bool?**| Whether the range has headers. | [optional] [default to true]

### Return type

[**ListObjectResponse**](ListObjectResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

