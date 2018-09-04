# Aspose.Cells.Cloud.SDK.Api.CellsAutoshapesApi

All URIs are relative to *https://api.aspose.cloud/v1.1/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CellsAutoshapesGetWorksheetAutoshape**](CellsAutoshapesApi.md#cellsautoshapesgetworksheetautoshape) | **GET** /cells/{name}/worksheets/{sheetName}/autoshapes/{autoshapeNumber} | Get autoshape info.
[**CellsAutoshapesGetWorksheetAutoshapes**](CellsAutoshapesApi.md#cellsautoshapesgetworksheetautoshapes) | **GET** /cells/{name}/worksheets/{sheetName}/autoshapes | Get worksheet autoshapes info.


<a name="cellsautoshapesgetworksheetautoshape"></a>
# **CellsAutoshapesGetWorksheetAutoshape**
> System.IO.Stream CellsAutoshapesGetWorksheetAutoshape (string name, string sheetName, int? autoshapeNumber, string format = null, string folder = null, string storage = null)

Get autoshape info.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsAutoshapesGetWorksheetAutoshapeExample
    {
        public void main()
        {
            var apiInstance = new CellsAutoshapesApi();
            var name = name_example;  // string | Document name.
            var sheetName = sheetName_example;  // string | Worksheet name.
            var autoshapeNumber = 56;  // int? | The autoshape number.
            var format = format_example;  // string | Exported format. (optional) 
            var folder = folder_example;  // string | The document folder. (optional) 
            var storage = storage_example;  // string | storage name. (optional) 

            try
            {
                // Get autoshape info.
                System.IO.Stream result = apiInstance.CellsAutoshapesGetWorksheetAutoshape(name, sheetName, autoshapeNumber, format, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsAutoshapesApi.CellsAutoshapesGetWorksheetAutoshape: " + e.Message );
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
 **autoshapeNumber** | **int?**| The autoshape number. | 
 **format** | **string**| Exported format. | [optional] 
 **folder** | **string**| The document folder. | [optional] 
 **storage** | **string**| storage name. | [optional] 

### Return type

**System.IO.Stream**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellsautoshapesgetworksheetautoshapes"></a>
# **CellsAutoshapesGetWorksheetAutoshapes**
> AutoShapesResponse CellsAutoshapesGetWorksheetAutoshapes (string name, string sheetName, string folder = null, string storage = null)

Get worksheet autoshapes info.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsAutoshapesGetWorksheetAutoshapesExample
    {
        public void main()
        {
            var apiInstance = new CellsAutoshapesApi();
            var name = name_example;  // string | Document name.
            var sheetName = sheetName_example;  // string | The worksheet name.
            var folder = folder_example;  // string | Document's folder. (optional) 
            var storage = storage_example;  // string | storage name. (optional) 

            try
            {
                // Get worksheet autoshapes info.
                AutoShapesResponse result = apiInstance.CellsAutoshapesGetWorksheetAutoshapes(name, sheetName, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsAutoshapesApi.CellsAutoshapesGetWorksheetAutoshapes: " + e.Message );
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

[**AutoShapesResponse**](AutoShapesResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

