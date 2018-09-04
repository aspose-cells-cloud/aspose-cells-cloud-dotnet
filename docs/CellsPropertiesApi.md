# Aspose.Cells.Cloud.SDK.Api.CellsPropertiesApi

All URIs are relative to *https://api.aspose.cloud/v1.1/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CellsPropertiesDeleteDocumentProperties**](CellsPropertiesApi.md#cellspropertiesdeletedocumentproperties) | **DELETE** /cells/{name}/documentproperties | Delete all custom document properties and clean built-in ones.
[**CellsPropertiesDeleteDocumentProperty**](CellsPropertiesApi.md#cellspropertiesdeletedocumentproperty) | **DELETE** /cells/{name}/documentproperties/{propertyName} | Delete document property.
[**CellsPropertiesGetDocumentProperties**](CellsPropertiesApi.md#cellspropertiesgetdocumentproperties) | **GET** /cells/{name}/documentproperties | Read document properties.
[**CellsPropertiesGetDocumentProperty**](CellsPropertiesApi.md#cellspropertiesgetdocumentproperty) | **GET** /cells/{name}/documentproperties/{propertyName} | Read document property by name.
[**CellsPropertiesPutDocumentProperty**](CellsPropertiesApi.md#cellspropertiesputdocumentproperty) | **PUT** /cells/{name}/documentproperties/{propertyName} | Set/create document property.


<a name="cellspropertiesdeletedocumentproperties"></a>
# **CellsPropertiesDeleteDocumentProperties**
> CellsDocumentPropertiesResponse CellsPropertiesDeleteDocumentProperties (string name, string folder = null, string storage = null)

Delete all custom document properties and clean built-in ones.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsPropertiesDeleteDocumentPropertiesExample
    {
        public void main()
        {
            var apiInstance = new CellsPropertiesApi();
            var name = name_example;  // string | The document name.
            var folder = folder_example;  // string | The document folder. (optional) 
            var storage = storage_example;  // string | storage name. (optional) 

            try
            {
                // Delete all custom document properties and clean built-in ones.
                CellsDocumentPropertiesResponse result = apiInstance.CellsPropertiesDeleteDocumentProperties(name, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsPropertiesApi.CellsPropertiesDeleteDocumentProperties: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **folder** | **string**| The document folder. | [optional] 
 **storage** | **string**| storage name. | [optional] 

### Return type

[**CellsDocumentPropertiesResponse**](CellsDocumentPropertiesResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellspropertiesdeletedocumentproperty"></a>
# **CellsPropertiesDeleteDocumentProperty**
> CellsDocumentPropertiesResponse CellsPropertiesDeleteDocumentProperty (string name, string propertyName, string folder = null, string storage = null)

Delete document property.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsPropertiesDeleteDocumentPropertyExample
    {
        public void main()
        {
            var apiInstance = new CellsPropertiesApi();
            var name = name_example;  // string | The document name.
            var propertyName = propertyName_example;  // string | The property name.
            var folder = folder_example;  // string | The document folder. (optional) 
            var storage = storage_example;  // string | storage name. (optional) 

            try
            {
                // Delete document property.
                CellsDocumentPropertiesResponse result = apiInstance.CellsPropertiesDeleteDocumentProperty(name, propertyName, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsPropertiesApi.CellsPropertiesDeleteDocumentProperty: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **propertyName** | **string**| The property name. | 
 **folder** | **string**| The document folder. | [optional] 
 **storage** | **string**| storage name. | [optional] 

### Return type

[**CellsDocumentPropertiesResponse**](CellsDocumentPropertiesResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellspropertiesgetdocumentproperties"></a>
# **CellsPropertiesGetDocumentProperties**
> CellsDocumentPropertiesResponse CellsPropertiesGetDocumentProperties (string name, string folder = null, string storage = null)

Read document properties.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsPropertiesGetDocumentPropertiesExample
    {
        public void main()
        {
            var apiInstance = new CellsPropertiesApi();
            var name = name_example;  // string | The document name.
            var folder = folder_example;  // string | The document folder. (optional) 
            var storage = storage_example;  // string | storage name. (optional) 

            try
            {
                // Read document properties.
                CellsDocumentPropertiesResponse result = apiInstance.CellsPropertiesGetDocumentProperties(name, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsPropertiesApi.CellsPropertiesGetDocumentProperties: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **folder** | **string**| The document folder. | [optional] 
 **storage** | **string**| storage name. | [optional] 

### Return type

[**CellsDocumentPropertiesResponse**](CellsDocumentPropertiesResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellspropertiesgetdocumentproperty"></a>
# **CellsPropertiesGetDocumentProperty**
> CellsDocumentPropertyResponse CellsPropertiesGetDocumentProperty (string name, string propertyName, string folder = null, string storage = null)

Read document property by name.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsPropertiesGetDocumentPropertyExample
    {
        public void main()
        {
            var apiInstance = new CellsPropertiesApi();
            var name = name_example;  // string | The document name.
            var propertyName = propertyName_example;  // string | The property name.
            var folder = folder_example;  // string | The document folder. (optional) 
            var storage = storage_example;  // string | storage name. (optional) 

            try
            {
                // Read document property by name.
                CellsDocumentPropertyResponse result = apiInstance.CellsPropertiesGetDocumentProperty(name, propertyName, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsPropertiesApi.CellsPropertiesGetDocumentProperty: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **propertyName** | **string**| The property name. | 
 **folder** | **string**| The document folder. | [optional] 
 **storage** | **string**| storage name. | [optional] 

### Return type

[**CellsDocumentPropertyResponse**](CellsDocumentPropertyResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellspropertiesputdocumentproperty"></a>
# **CellsPropertiesPutDocumentProperty**
> CellsDocumentPropertyResponse CellsPropertiesPutDocumentProperty (string name, string propertyName, CellsDocumentProperty property = null, string folder = null, string storage = null)

Set/create document property.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsPropertiesPutDocumentPropertyExample
    {
        public void main()
        {
            var apiInstance = new CellsPropertiesApi();
            var name = name_example;  // string | The document name.
            var propertyName = propertyName_example;  // string | The property name.
            var property = new CellsDocumentProperty(); // CellsDocumentProperty | with new property value. (optional) 
            var folder = folder_example;  // string | The document folder. (optional) 
            var storage = storage_example;  // string | storage name. (optional) 

            try
            {
                // Set/create document property.
                CellsDocumentPropertyResponse result = apiInstance.CellsPropertiesPutDocumentProperty(name, propertyName, property, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsPropertiesApi.CellsPropertiesPutDocumentProperty: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **propertyName** | **string**| The property name. | 
 **property** | [**CellsDocumentProperty**](CellsDocumentProperty.md)| with new property value. | [optional] 
 **folder** | **string**| The document folder. | [optional] 
 **storage** | **string**| storage name. | [optional] 

### Return type

[**CellsDocumentPropertyResponse**](CellsDocumentPropertyResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

