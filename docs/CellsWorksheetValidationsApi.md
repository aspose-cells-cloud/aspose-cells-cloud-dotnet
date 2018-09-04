# Aspose.Cells.Cloud.SDK.Api.CellsWorksheetValidationsApi

All URIs are relative to *https://api.aspose.cloud/v1.1/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CellsWorksheetValidationsDeleteWorksheetValidation**](CellsWorksheetValidationsApi.md#cellsworksheetvalidationsdeleteworksheetvalidation) | **DELETE** /cells/{name}/worksheets/{sheetName}/validations/{validationIndex} | Delete worksheet validation by index.
[**CellsWorksheetValidationsGetWorksheetValidation**](CellsWorksheetValidationsApi.md#cellsworksheetvalidationsgetworksheetvalidation) | **GET** /cells/{name}/worksheets/{sheetName}/validations/{validationIndex} | Get worksheet validation by index.
[**CellsWorksheetValidationsGetWorksheetValidations**](CellsWorksheetValidationsApi.md#cellsworksheetvalidationsgetworksheetvalidations) | **GET** /cells/{name}/worksheets/{sheetName}/validations | Get worksheet validations.
[**CellsWorksheetValidationsPostWorksheetValidation**](CellsWorksheetValidationsApi.md#cellsworksheetvalidationspostworksheetvalidation) | **POST** /cells/{name}/worksheets/{sheetName}/validations/{validationIndex} | Update worksheet validation by index.
[**CellsWorksheetValidationsPutWorksheetValidation**](CellsWorksheetValidationsApi.md#cellsworksheetvalidationsputworksheetvalidation) | **PUT** /cells/{name}/worksheets/{sheetName}/validations | Add worksheet validation at index.


<a name="cellsworksheetvalidationsdeleteworksheetvalidation"></a>
# **CellsWorksheetValidationsDeleteWorksheetValidation**
> ValidationResponse CellsWorksheetValidationsDeleteWorksheetValidation (string name, string sheetName, int? validationIndex, string folder = null, string storage = null)

Delete worksheet validation by index.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsWorksheetValidationsDeleteWorksheetValidationExample
    {
        public void main()
        {
            var apiInstance = new CellsWorksheetValidationsApi();
            var name = name_example;  // string | Document name.
            var sheetName = sheetName_example;  // string | Worksheet name.
            var validationIndex = 56;  // int? | The validation index.
            var folder = folder_example;  // string | Document's folder. (optional) 
            var storage = storage_example;  // string | storage name. (optional) 

            try
            {
                // Delete worksheet validation by index.
                ValidationResponse result = apiInstance.CellsWorksheetValidationsDeleteWorksheetValidation(name, sheetName, validationIndex, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsWorksheetValidationsApi.CellsWorksheetValidationsDeleteWorksheetValidation: " + e.Message );
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
 **validationIndex** | **int?**| The validation index. | 
 **folder** | **string**| Document&#39;s folder. | [optional] 
 **storage** | **string**| storage name. | [optional] 

### Return type

[**ValidationResponse**](ValidationResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellsworksheetvalidationsgetworksheetvalidation"></a>
# **CellsWorksheetValidationsGetWorksheetValidation**
> ValidationResponse CellsWorksheetValidationsGetWorksheetValidation (string name, string sheetName, int? validationIndex, string folder = null, string storage = null)

Get worksheet validation by index.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsWorksheetValidationsGetWorksheetValidationExample
    {
        public void main()
        {
            var apiInstance = new CellsWorksheetValidationsApi();
            var name = name_example;  // string | Document name.
            var sheetName = sheetName_example;  // string | Worksheet name.
            var validationIndex = 56;  // int? | The validation index.
            var folder = folder_example;  // string | Document's folder. (optional) 
            var storage = storage_example;  // string | storage name. (optional) 

            try
            {
                // Get worksheet validation by index.
                ValidationResponse result = apiInstance.CellsWorksheetValidationsGetWorksheetValidation(name, sheetName, validationIndex, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsWorksheetValidationsApi.CellsWorksheetValidationsGetWorksheetValidation: " + e.Message );
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
 **validationIndex** | **int?**| The validation index. | 
 **folder** | **string**| Document&#39;s folder. | [optional] 
 **storage** | **string**| storage name. | [optional] 

### Return type

[**ValidationResponse**](ValidationResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellsworksheetvalidationsgetworksheetvalidations"></a>
# **CellsWorksheetValidationsGetWorksheetValidations**
> ValidationsResponse CellsWorksheetValidationsGetWorksheetValidations (string name, string sheetName, string folder = null, string storage = null)

Get worksheet validations.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsWorksheetValidationsGetWorksheetValidationsExample
    {
        public void main()
        {
            var apiInstance = new CellsWorksheetValidationsApi();
            var name = name_example;  // string | Document name.
            var sheetName = sheetName_example;  // string | Worksheet name.
            var folder = folder_example;  // string | Document folder. (optional) 
            var storage = storage_example;  // string | storage name. (optional) 

            try
            {
                // Get worksheet validations.
                ValidationsResponse result = apiInstance.CellsWorksheetValidationsGetWorksheetValidations(name, sheetName, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsWorksheetValidationsApi.CellsWorksheetValidationsGetWorksheetValidations: " + e.Message );
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
 **folder** | **string**| Document folder. | [optional] 
 **storage** | **string**| storage name. | [optional] 

### Return type

[**ValidationsResponse**](ValidationsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellsworksheetvalidationspostworksheetvalidation"></a>
# **CellsWorksheetValidationsPostWorksheetValidation**
> ValidationResponse CellsWorksheetValidationsPostWorksheetValidation (string name, string sheetName, int? validationIndex, Validation validation = null, string folder = null, string storage = null)

Update worksheet validation by index.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsWorksheetValidationsPostWorksheetValidationExample
    {
        public void main()
        {
            var apiInstance = new CellsWorksheetValidationsApi();
            var name = name_example;  // string | Document name.
            var sheetName = sheetName_example;  // string | Worksheet name.
            var validationIndex = 56;  // int? | The validation index.
            var validation = new Validation(); // Validation |  (optional) 
            var folder = folder_example;  // string | Document's folder. (optional) 
            var storage = storage_example;  // string | storage name. (optional) 

            try
            {
                // Update worksheet validation by index.
                ValidationResponse result = apiInstance.CellsWorksheetValidationsPostWorksheetValidation(name, sheetName, validationIndex, validation, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsWorksheetValidationsApi.CellsWorksheetValidationsPostWorksheetValidation: " + e.Message );
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
 **validationIndex** | **int?**| The validation index. | 
 **validation** | [**Validation**](Validation.md)|  | [optional] 
 **folder** | **string**| Document&#39;s folder. | [optional] 
 **storage** | **string**| storage name. | [optional] 

### Return type

[**ValidationResponse**](ValidationResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellsworksheetvalidationsputworksheetvalidation"></a>
# **CellsWorksheetValidationsPutWorksheetValidation**
> ValidationResponse CellsWorksheetValidationsPutWorksheetValidation (string name, string sheetName, string range = null, string folder = null, string storage = null)

Add worksheet validation at index.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsWorksheetValidationsPutWorksheetValidationExample
    {
        public void main()
        {
            var apiInstance = new CellsWorksheetValidationsApi();
            var name = name_example;  // string | Document name.
            var sheetName = sheetName_example;  // string | Worksheet name.
            var range = range_example;  // string | Specified cells area (optional) 
            var folder = folder_example;  // string | Document's folder. (optional) 
            var storage = storage_example;  // string | storage name. (optional) 

            try
            {
                // Add worksheet validation at index.
                ValidationResponse result = apiInstance.CellsWorksheetValidationsPutWorksheetValidation(name, sheetName, range, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsWorksheetValidationsApi.CellsWorksheetValidationsPutWorksheetValidation: " + e.Message );
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
 **range** | **string**| Specified cells area | [optional] 
 **folder** | **string**| Document&#39;s folder. | [optional] 
 **storage** | **string**| storage name. | [optional] 

### Return type

[**ValidationResponse**](ValidationResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

