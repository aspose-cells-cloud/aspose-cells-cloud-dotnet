# Aspose.Cells.Cloud.SDK.Api.CellsWorkbookApi

All URIs are relative to *https://api.aspose.cloud/v1.1/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CellsWorkbookDeleteDecryptDocument**](CellsWorkbookApi.md#cellsworkbookdeletedecryptdocument) | **DELETE** /cells/{name}/encryption | Decrypt document.
[**CellsWorkbookDeleteDocumentUnprotectFromChanges**](CellsWorkbookApi.md#cellsworkbookdeletedocumentunprotectfromchanges) | **DELETE** /cells/{name}/writeProtection | Unprotect document from changes.
[**CellsWorkbookDeleteUnprotectDocument**](CellsWorkbookApi.md#cellsworkbookdeleteunprotectdocument) | **DELETE** /cells/{name}/protection | Unprotect document.
[**CellsWorkbookDeleteWorkbookName**](CellsWorkbookApi.md#cellsworkbookdeleteworkbookname) | **DELETE** /cells/{name}/names/{nameName} | Clean workbook&#39;s names.
[**CellsWorkbookDeleteWorkbookNames**](CellsWorkbookApi.md#cellsworkbookdeleteworkbooknames) | **DELETE** /cells/{name}/names | Clean workbook&#39;s names.
[**CellsWorkbookGetWorkbook**](CellsWorkbookApi.md#cellsworkbookgetworkbook) | **GET** /cells/{name} | Read workbook info or export.
[**CellsWorkbookGetWorkbookDefaultStyle**](CellsWorkbookApi.md#cellsworkbookgetworkbookdefaultstyle) | **GET** /cells/{name}/defaultstyle | Read workbook default style info.
[**CellsWorkbookGetWorkbookName**](CellsWorkbookApi.md#cellsworkbookgetworkbookname) | **GET** /cells/{name}/names/{nameName} | Read workbook&#39;s name.
[**CellsWorkbookGetWorkbookNameValue**](CellsWorkbookApi.md#cellsworkbookgetworkbooknamevalue) | **GET** /cells/{name}/names/{nameName}/value | Get workbook&#39;s name value.
[**CellsWorkbookGetWorkbookNames**](CellsWorkbookApi.md#cellsworkbookgetworkbooknames) | **GET** /cells/{name}/names | Read workbook&#39;s names.
[**CellsWorkbookGetWorkbookSettings**](CellsWorkbookApi.md#cellsworkbookgetworkbooksettings) | **GET** /cells/{name}/settings | Get Workbook Settings DTO
[**CellsWorkbookGetWorkbookTextItems**](CellsWorkbookApi.md#cellsworkbookgetworkbooktextitems) | **GET** /cells/{name}/textItems | Read workbook&#39;s text items.
[**CellsWorkbookPostAutofitWorkbookRows**](CellsWorkbookApi.md#cellsworkbookpostautofitworkbookrows) | **POST** /cells/{name}/autofitrows | Autofit workbook rows.
[**CellsWorkbookPostEncryptDocument**](CellsWorkbookApi.md#cellsworkbookpostencryptdocument) | **POST** /cells/{name}/encryption | Encript document.
[**CellsWorkbookPostImportData**](CellsWorkbookApi.md#cellsworkbookpostimportdata) | **POST** /cells/{name}/importdata | 
[**CellsWorkbookPostProtectDocument**](CellsWorkbookApi.md#cellsworkbookpostprotectdocument) | **POST** /cells/{name}/protection | Protect document.
[**CellsWorkbookPostWorkbookCalculateFormula**](CellsWorkbookApi.md#cellsworkbookpostworkbookcalculateformula) | **POST** /cells/{name}/calculateformula | Calculate all formulas in workbook.
[**CellsWorkbookPostWorkbookGetSmartMarkerResult**](CellsWorkbookApi.md#cellsworkbookpostworkbookgetsmartmarkerresult) | **POST** /cells/{name}/smartmarker | Smart marker processing result.
[**CellsWorkbookPostWorkbookSettings**](CellsWorkbookApi.md#cellsworkbookpostworkbooksettings) | **POST** /cells/{name}/settings | Update Workbook setting 
[**CellsWorkbookPostWorkbookSplit**](CellsWorkbookApi.md#cellsworkbookpostworkbooksplit) | **POST** /cells/{name}/split | Split workbook.
[**CellsWorkbookPostWorkbooksMerge**](CellsWorkbookApi.md#cellsworkbookpostworkbooksmerge) | **POST** /cells/{name}/merge | Merge workbooks.
[**CellsWorkbookPostWorkbooksTextReplace**](CellsWorkbookApi.md#cellsworkbookpostworkbookstextreplace) | **POST** /cells/{name}/replaceText | Replace text.
[**CellsWorkbookPostWorkbooksTextSearch**](CellsWorkbookApi.md#cellsworkbookpostworkbookstextsearch) | **POST** /cells/{name}/findText | Search text.
[**CellsWorkbookPutConvertWorkbook**](CellsWorkbookApi.md#cellsworkbookputconvertworkbook) | **PUT** /cells/convert | Convert workbook from request content to some format.
[**CellsWorkbookPutDocumentProtectFromChanges**](CellsWorkbookApi.md#cellsworkbookputdocumentprotectfromchanges) | **PUT** /cells/{name}/writeProtection | Protect document from changes.
[**CellsWorkbookPutWorkbookCreate**](CellsWorkbookApi.md#cellsworkbookputworkbookcreate) | **PUT** /cells/{name} | Create new workbook using deferent methods.


<a name="cellsworkbookdeletedecryptdocument"></a>
# **CellsWorkbookDeleteDecryptDocument**
> SaaSposeResponse CellsWorkbookDeleteDecryptDocument (string name, WorkbookEncryptionRequest encryption = null, string folder = null, string storage = null)

Decrypt document.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsWorkbookDeleteDecryptDocumentExample
    {
        public void main()
        {
            var apiInstance = new CellsWorkbookApi();
            var name = name_example;  // string | The document name.
            var encryption = new WorkbookEncryptionRequest(); // WorkbookEncryptionRequest | Encryption settings, only password can be specified. (optional) 
            var folder = folder_example;  // string | The document folder. (optional) 
            var storage = storage_example;  // string | storage name. (optional) 

            try
            {
                // Decrypt document.
                SaaSposeResponse result = apiInstance.CellsWorkbookDeleteDecryptDocument(name, encryption, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsWorkbookApi.CellsWorkbookDeleteDecryptDocument: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **encryption** | [**WorkbookEncryptionRequest**](WorkbookEncryptionRequest.md)| Encryption settings, only password can be specified. | [optional] 
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

<a name="cellsworkbookdeletedocumentunprotectfromchanges"></a>
# **CellsWorkbookDeleteDocumentUnprotectFromChanges**
> SaaSposeResponse CellsWorkbookDeleteDocumentUnprotectFromChanges (string name, string folder = null, string storage = null)

Unprotect document from changes.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsWorkbookDeleteDocumentUnprotectFromChangesExample
    {
        public void main()
        {
            var apiInstance = new CellsWorkbookApi();
            var name = name_example;  // string | The document name.
            var folder = folder_example;  // string | Document's folder. (optional) 
            var storage = storage_example;  // string | storage name. (optional) 

            try
            {
                // Unprotect document from changes.
                SaaSposeResponse result = apiInstance.CellsWorkbookDeleteDocumentUnprotectFromChanges(name, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsWorkbookApi.CellsWorkbookDeleteDocumentUnprotectFromChanges: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
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

<a name="cellsworkbookdeleteunprotectdocument"></a>
# **CellsWorkbookDeleteUnprotectDocument**
> SaaSposeResponse CellsWorkbookDeleteUnprotectDocument (string name, WorkbookProtectionRequest protection = null, string folder = null, string storage = null)

Unprotect document.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsWorkbookDeleteUnprotectDocumentExample
    {
        public void main()
        {
            var apiInstance = new CellsWorkbookApi();
            var name = name_example;  // string | The document name.
            var protection = new WorkbookProtectionRequest(); // WorkbookProtectionRequest | Protection settings, only password can be specified. (optional) 
            var folder = folder_example;  // string | The document folder. (optional) 
            var storage = storage_example;  // string | storage name. (optional) 

            try
            {
                // Unprotect document.
                SaaSposeResponse result = apiInstance.CellsWorkbookDeleteUnprotectDocument(name, protection, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsWorkbookApi.CellsWorkbookDeleteUnprotectDocument: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **protection** | [**WorkbookProtectionRequest**](WorkbookProtectionRequest.md)| Protection settings, only password can be specified. | [optional] 
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

<a name="cellsworkbookdeleteworkbookname"></a>
# **CellsWorkbookDeleteWorkbookName**
> SaaSposeResponse CellsWorkbookDeleteWorkbookName (string name, string nameName, string folder = null, string storage = null)

Clean workbook's names.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsWorkbookDeleteWorkbookNameExample
    {
        public void main()
        {
            var apiInstance = new CellsWorkbookApi();
            var name = name_example;  // string | The workbook name.
            var nameName = nameName_example;  // string | The name.
            var folder = folder_example;  // string | The workbook folder. (optional) 
            var storage = storage_example;  // string | storage name. (optional) 

            try
            {
                // Clean workbook's names.
                SaaSposeResponse result = apiInstance.CellsWorkbookDeleteWorkbookName(name, nameName, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsWorkbookApi.CellsWorkbookDeleteWorkbookName: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The workbook name. | 
 **nameName** | **string**| The name. | 
 **folder** | **string**| The workbook folder. | [optional] 
 **storage** | **string**| storage name. | [optional] 

### Return type

[**SaaSposeResponse**](SaaSposeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellsworkbookdeleteworkbooknames"></a>
# **CellsWorkbookDeleteWorkbookNames**
> SaaSposeResponse CellsWorkbookDeleteWorkbookNames (string name, string folder = null, string storage = null)

Clean workbook's names.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsWorkbookDeleteWorkbookNamesExample
    {
        public void main()
        {
            var apiInstance = new CellsWorkbookApi();
            var name = name_example;  // string | The workbook name.
            var folder = folder_example;  // string | The workbook folder. (optional) 
            var storage = storage_example;  // string | storage name. (optional) 

            try
            {
                // Clean workbook's names.
                SaaSposeResponse result = apiInstance.CellsWorkbookDeleteWorkbookNames(name, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsWorkbookApi.CellsWorkbookDeleteWorkbookNames: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The workbook name. | 
 **folder** | **string**| The workbook folder. | [optional] 
 **storage** | **string**| storage name. | [optional] 

### Return type

[**SaaSposeResponse**](SaaSposeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellsworkbookgetworkbook"></a>
# **CellsWorkbookGetWorkbook**
> System.IO.Stream CellsWorkbookGetWorkbook (string name, string password = null, string format = null, bool? isAutoFit = null, bool? onlySaveTable = null, string folder = null, string storage = null, string outPath = null)

Read workbook info or export.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsWorkbookGetWorkbookExample
    {
        public void main()
        {
            var apiInstance = new CellsWorkbookApi();
            var name = name_example;  // string | The document name.
            var password = password_example;  // string | The document password. (optional) 
            var format = format_example;  // string | The exported file format. (optional) 
            var isAutoFit = true;  // bool? | Set document rows to be autofit. (optional)  (default to false)
            var onlySaveTable = true;  // bool? | Only save table data. (optional)  (default to false)
            var folder = folder_example;  // string | The document folder. (optional) 
            var storage = storage_example;  // string | storage name. (optional) 
            var outPath = outPath_example;  // string | The document output folder. (optional) 

            try
            {
                // Read workbook info or export.
                System.IO.Stream result = apiInstance.CellsWorkbookGetWorkbook(name, password, format, isAutoFit, onlySaveTable, folder, storage, outPath);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsWorkbookApi.CellsWorkbookGetWorkbook: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **password** | **string**| The document password. | [optional] 
 **format** | **string**| The exported file format. | [optional] 
 **isAutoFit** | **bool?**| Set document rows to be autofit. | [optional] [default to false]
 **onlySaveTable** | **bool?**| Only save table data. | [optional] [default to false]
 **folder** | **string**| The document folder. | [optional] 
 **storage** | **string**| storage name. | [optional] 
 **outPath** | **string**| The document output folder. | [optional] 

### Return type

**System.IO.Stream**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellsworkbookgetworkbookdefaultstyle"></a>
# **CellsWorkbookGetWorkbookDefaultStyle**
> StyleResponse CellsWorkbookGetWorkbookDefaultStyle (string name, string folder = null, string storage = null)

Read workbook default style info.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsWorkbookGetWorkbookDefaultStyleExample
    {
        public void main()
        {
            var apiInstance = new CellsWorkbookApi();
            var name = name_example;  // string | The workbook name.
            var folder = folder_example;  // string | The document's folder. (optional) 
            var storage = storage_example;  // string | storage name. (optional) 

            try
            {
                // Read workbook default style info.
                StyleResponse result = apiInstance.CellsWorkbookGetWorkbookDefaultStyle(name, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsWorkbookApi.CellsWorkbookGetWorkbookDefaultStyle: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The workbook name. | 
 **folder** | **string**| The document&#39;s folder. | [optional] 
 **storage** | **string**| storage name. | [optional] 

### Return type

[**StyleResponse**](StyleResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellsworkbookgetworkbookname"></a>
# **CellsWorkbookGetWorkbookName**
> NameResponse CellsWorkbookGetWorkbookName (string name, string nameName, string folder = null, string storage = null)

Read workbook's name.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsWorkbookGetWorkbookNameExample
    {
        public void main()
        {
            var apiInstance = new CellsWorkbookApi();
            var name = name_example;  // string | The workbook name.
            var nameName = nameName_example;  // string | The name.
            var folder = folder_example;  // string | The workbook folder. (optional) 
            var storage = storage_example;  // string | storage name. (optional) 

            try
            {
                // Read workbook's name.
                NameResponse result = apiInstance.CellsWorkbookGetWorkbookName(name, nameName, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsWorkbookApi.CellsWorkbookGetWorkbookName: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The workbook name. | 
 **nameName** | **string**| The name. | 
 **folder** | **string**| The workbook folder. | [optional] 
 **storage** | **string**| storage name. | [optional] 

### Return type

[**NameResponse**](NameResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellsworkbookgetworkbooknamevalue"></a>
# **CellsWorkbookGetWorkbookNameValue**
> RangeValueResponse CellsWorkbookGetWorkbookNameValue (string name, string nameName, string folder = null, string storage = null)

Get workbook's name value.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsWorkbookGetWorkbookNameValueExample
    {
        public void main()
        {
            var apiInstance = new CellsWorkbookApi();
            var name = name_example;  // string | The workbook name.
            var nameName = nameName_example;  // string | The name.
            var folder = folder_example;  // string | The workbook folder. (optional) 
            var storage = storage_example;  // string | storage name. (optional) 

            try
            {
                // Get workbook's name value.
                RangeValueResponse result = apiInstance.CellsWorkbookGetWorkbookNameValue(name, nameName, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsWorkbookApi.CellsWorkbookGetWorkbookNameValue: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The workbook name. | 
 **nameName** | **string**| The name. | 
 **folder** | **string**| The workbook folder. | [optional] 
 **storage** | **string**| storage name. | [optional] 

### Return type

[**RangeValueResponse**](RangeValueResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellsworkbookgetworkbooknames"></a>
# **CellsWorkbookGetWorkbookNames**
> NamesResponse CellsWorkbookGetWorkbookNames (string name, string folder = null, string storage = null)

Read workbook's names.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsWorkbookGetWorkbookNamesExample
    {
        public void main()
        {
            var apiInstance = new CellsWorkbookApi();
            var name = name_example;  // string | The workbook name.
            var folder = folder_example;  // string | The workbook folder. (optional) 
            var storage = storage_example;  // string | storage name. (optional) 

            try
            {
                // Read workbook's names.
                NamesResponse result = apiInstance.CellsWorkbookGetWorkbookNames(name, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsWorkbookApi.CellsWorkbookGetWorkbookNames: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The workbook name. | 
 **folder** | **string**| The workbook folder. | [optional] 
 **storage** | **string**| storage name. | [optional] 

### Return type

[**NamesResponse**](NamesResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellsworkbookgetworkbooksettings"></a>
# **CellsWorkbookGetWorkbookSettings**
> WorkbookSettingsResponse CellsWorkbookGetWorkbookSettings (string name, string folder = null, string storage = null)

Get Workbook Settings DTO

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsWorkbookGetWorkbookSettingsExample
    {
        public void main()
        {
            var apiInstance = new CellsWorkbookApi();
            var name = name_example;  // string | Document name.
            var folder = folder_example;  // string | Document's folder. (optional) 
            var storage = storage_example;  // string | storage name. (optional) 

            try
            {
                // Get Workbook Settings DTO
                WorkbookSettingsResponse result = apiInstance.CellsWorkbookGetWorkbookSettings(name, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsWorkbookApi.CellsWorkbookGetWorkbookSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Document name. | 
 **folder** | **string**| Document&#39;s folder. | [optional] 
 **storage** | **string**| storage name. | [optional] 

### Return type

[**WorkbookSettingsResponse**](WorkbookSettingsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellsworkbookgetworkbooktextitems"></a>
# **CellsWorkbookGetWorkbookTextItems**
> TextItemsResponse CellsWorkbookGetWorkbookTextItems (string name, string folder = null, string storage = null)

Read workbook's text items.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsWorkbookGetWorkbookTextItemsExample
    {
        public void main()
        {
            var apiInstance = new CellsWorkbookApi();
            var name = name_example;  // string | The workbook name.
            var folder = folder_example;  // string | The workbook folder. (optional) 
            var storage = storage_example;  // string | storage name. (optional) 

            try
            {
                // Read workbook's text items.
                TextItemsResponse result = apiInstance.CellsWorkbookGetWorkbookTextItems(name, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsWorkbookApi.CellsWorkbookGetWorkbookTextItems: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The workbook name. | 
 **folder** | **string**| The workbook folder. | [optional] 
 **storage** | **string**| storage name. | [optional] 

### Return type

[**TextItemsResponse**](TextItemsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellsworkbookpostautofitworkbookrows"></a>
# **CellsWorkbookPostAutofitWorkbookRows**
> SaaSposeResponse CellsWorkbookPostAutofitWorkbookRows (string name, AutoFitterOptions autoFitterOptions = null, int? startRow = null, int? endRow = null, bool? onlyAuto = null, string folder = null, string storage = null)

Autofit workbook rows.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsWorkbookPostAutofitWorkbookRowsExample
    {
        public void main()
        {
            var apiInstance = new CellsWorkbookApi();
            var name = name_example;  // string | Document name.
            var autoFitterOptions = new AutoFitterOptions(); // AutoFitterOptions | Auto Fitter Options. (optional) 
            var startRow = 56;  // int? | Start row. (optional) 
            var endRow = 56;  // int? | End row. (optional) 
            var onlyAuto = true;  // bool? | Only auto. (optional)  (default to false)
            var folder = folder_example;  // string | Document's folder. (optional) 
            var storage = storage_example;  // string | storage name. (optional) 

            try
            {
                // Autofit workbook rows.
                SaaSposeResponse result = apiInstance.CellsWorkbookPostAutofitWorkbookRows(name, autoFitterOptions, startRow, endRow, onlyAuto, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsWorkbookApi.CellsWorkbookPostAutofitWorkbookRows: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Document name. | 
 **autoFitterOptions** | [**AutoFitterOptions**](AutoFitterOptions.md)| Auto Fitter Options. | [optional] 
 **startRow** | **int?**| Start row. | [optional] 
 **endRow** | **int?**| End row. | [optional] 
 **onlyAuto** | **bool?**| Only auto. | [optional] [default to false]
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

<a name="cellsworkbookpostencryptdocument"></a>
# **CellsWorkbookPostEncryptDocument**
> SaaSposeResponse CellsWorkbookPostEncryptDocument (string name, WorkbookEncryptionRequest encryption = null, string folder = null, string storage = null)

Encript document.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsWorkbookPostEncryptDocumentExample
    {
        public void main()
        {
            var apiInstance = new CellsWorkbookApi();
            var name = name_example;  // string | The document name.
            var encryption = new WorkbookEncryptionRequest(); // WorkbookEncryptionRequest | Encryption parameters. (optional) 
            var folder = folder_example;  // string | The document folder. (optional) 
            var storage = storage_example;  // string | storage name. (optional) 

            try
            {
                // Encript document.
                SaaSposeResponse result = apiInstance.CellsWorkbookPostEncryptDocument(name, encryption, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsWorkbookApi.CellsWorkbookPostEncryptDocument: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **encryption** | [**WorkbookEncryptionRequest**](WorkbookEncryptionRequest.md)| Encryption parameters. | [optional] 
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

<a name="cellsworkbookpostimportdata"></a>
# **CellsWorkbookPostImportData**
> SaaSposeResponse CellsWorkbookPostImportData (string name, ImportOption importdata, string folder = null, string storage = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsWorkbookPostImportDataExample
    {
        public void main()
        {
            var apiInstance = new CellsWorkbookApi();
            var name = name_example;  // string | 
            var importdata = new ImportOption(); // ImportOption | 
            var folder = folder_example;  // string |  (optional) 
            var storage = storage_example;  // string | storage name. (optional) 

            try
            {
                SaaSposeResponse result = apiInstance.CellsWorkbookPostImportData(name, importdata, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsWorkbookApi.CellsWorkbookPostImportData: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**|  | 
 **importdata** | [**ImportOption**](ImportOption.md)|  | 
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

<a name="cellsworkbookpostprotectdocument"></a>
# **CellsWorkbookPostProtectDocument**
> SaaSposeResponse CellsWorkbookPostProtectDocument (string name, WorkbookProtectionRequest protection = null, string folder = null, string storage = null)

Protect document.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsWorkbookPostProtectDocumentExample
    {
        public void main()
        {
            var apiInstance = new CellsWorkbookApi();
            var name = name_example;  // string | The document name.
            var protection = new WorkbookProtectionRequest(); // WorkbookProtectionRequest | The protection settings. (optional) 
            var folder = folder_example;  // string | The document folder. (optional) 
            var storage = storage_example;  // string | storage name. (optional) 

            try
            {
                // Protect document.
                SaaSposeResponse result = apiInstance.CellsWorkbookPostProtectDocument(name, protection, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsWorkbookApi.CellsWorkbookPostProtectDocument: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **protection** | [**WorkbookProtectionRequest**](WorkbookProtectionRequest.md)| The protection settings. | [optional] 
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

<a name="cellsworkbookpostworkbookcalculateformula"></a>
# **CellsWorkbookPostWorkbookCalculateFormula**
> SaaSposeResponse CellsWorkbookPostWorkbookCalculateFormula (string name, CalculationOptions options = null, bool? ignoreError = null, string folder = null, string storage = null)

Calculate all formulas in workbook.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsWorkbookPostWorkbookCalculateFormulaExample
    {
        public void main()
        {
            var apiInstance = new CellsWorkbookApi();
            var name = name_example;  // string | Document name.
            var options = new CalculationOptions(); // CalculationOptions | Calculation Options. (optional) 
            var ignoreError = true;  // bool? | ignore Error. (optional) 
            var folder = folder_example;  // string | Document's folder. (optional) 
            var storage = storage_example;  // string | storage name. (optional) 

            try
            {
                // Calculate all formulas in workbook.
                SaaSposeResponse result = apiInstance.CellsWorkbookPostWorkbookCalculateFormula(name, options, ignoreError, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsWorkbookApi.CellsWorkbookPostWorkbookCalculateFormula: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Document name. | 
 **options** | [**CalculationOptions**](CalculationOptions.md)| Calculation Options. | [optional] 
 **ignoreError** | **bool?**| ignore Error. | [optional] 
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

<a name="cellsworkbookpostworkbookgetsmartmarkerresult"></a>
# **CellsWorkbookPostWorkbookGetSmartMarkerResult**
> System.IO.Stream CellsWorkbookPostWorkbookGetSmartMarkerResult (string name, string xmlFile = null, string folder = null, string storage = null, string outPath = null)

Smart marker processing result.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsWorkbookPostWorkbookGetSmartMarkerResultExample
    {
        public void main()
        {
            var apiInstance = new CellsWorkbookApi();
            var name = name_example;  // string | The workbook name.
            var xmlFile = xmlFile_example;  // string | The xml file full path, if empty the data is read from request body. (optional) 
            var folder = folder_example;  // string | The workbook folder full path. (optional) 
            var storage = storage_example;  // string | storage name. (optional) 
            var outPath = outPath_example;  // string | Path to save result (optional) 

            try
            {
                // Smart marker processing result.
                System.IO.Stream result = apiInstance.CellsWorkbookPostWorkbookGetSmartMarkerResult(name, xmlFile, folder, storage, outPath);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsWorkbookApi.CellsWorkbookPostWorkbookGetSmartMarkerResult: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The workbook name. | 
 **xmlFile** | **string**| The xml file full path, if empty the data is read from request body. | [optional] 
 **folder** | **string**| The workbook folder full path. | [optional] 
 **storage** | **string**| storage name. | [optional] 
 **outPath** | **string**| Path to save result | [optional] 

### Return type

**System.IO.Stream**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellsworkbookpostworkbooksettings"></a>
# **CellsWorkbookPostWorkbookSettings**
> SaaSposeResponse CellsWorkbookPostWorkbookSettings (string name, WorkbookSettings settings = null, string folder = null, string storage = null)

Update Workbook setting 

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsWorkbookPostWorkbookSettingsExample
    {
        public void main()
        {
            var apiInstance = new CellsWorkbookApi();
            var name = name_example;  // string | Document name.
            var settings = new WorkbookSettings(); // WorkbookSettings | Workbook Setting DTO (optional) 
            var folder = folder_example;  // string | Document's folder. (optional) 
            var storage = storage_example;  // string | storage name. (optional) 

            try
            {
                // Update Workbook setting 
                SaaSposeResponse result = apiInstance.CellsWorkbookPostWorkbookSettings(name, settings, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsWorkbookApi.CellsWorkbookPostWorkbookSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Document name. | 
 **settings** | [**WorkbookSettings**](WorkbookSettings.md)| Workbook Setting DTO | [optional] 
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

<a name="cellsworkbookpostworkbooksplit"></a>
# **CellsWorkbookPostWorkbookSplit**
> SplitResultResponse CellsWorkbookPostWorkbookSplit (string name, string format = null, int? from = null, int? to = null, int? horizontalResolution = null, int? verticalResolution = null, string folder = null, string storage = null)

Split workbook.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsWorkbookPostWorkbookSplitExample
    {
        public void main()
        {
            var apiInstance = new CellsWorkbookApi();
            var name = name_example;  // string | The workbook name.
            var format = format_example;  // string | Split format. (optional) 
            var from = 56;  // int? | Start worksheet index. (optional)  (default to 0)
            var to = 56;  // int? | End worksheet index. (optional)  (default to 0)
            var horizontalResolution = 56;  // int? | Image horizontal resolution. (optional)  (default to 0)
            var verticalResolution = 56;  // int? | Image vertical resolution. (optional)  (default to 0)
            var folder = folder_example;  // string | The workbook folder. (optional) 
            var storage = storage_example;  // string | storage name. (optional) 

            try
            {
                // Split workbook.
                SplitResultResponse result = apiInstance.CellsWorkbookPostWorkbookSplit(name, format, from, to, horizontalResolution, verticalResolution, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsWorkbookApi.CellsWorkbookPostWorkbookSplit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The workbook name. | 
 **format** | **string**| Split format. | [optional] 
 **from** | **int?**| Start worksheet index. | [optional] [default to 0]
 **to** | **int?**| End worksheet index. | [optional] [default to 0]
 **horizontalResolution** | **int?**| Image horizontal resolution. | [optional] [default to 0]
 **verticalResolution** | **int?**| Image vertical resolution. | [optional] [default to 0]
 **folder** | **string**| The workbook folder. | [optional] 
 **storage** | **string**| storage name. | [optional] 

### Return type

[**SplitResultResponse**](SplitResultResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellsworkbookpostworkbooksmerge"></a>
# **CellsWorkbookPostWorkbooksMerge**
> WorkbookResponse CellsWorkbookPostWorkbooksMerge (string name, string mergeWith, string folder = null, string storage = null)

Merge workbooks.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsWorkbookPostWorkbooksMergeExample
    {
        public void main()
        {
            var apiInstance = new CellsWorkbookApi();
            var name = name_example;  // string | Workbook name.
            var mergeWith = mergeWith_example;  // string | The workbook to merge with.
            var folder = folder_example;  // string | Source workbook folder. (optional) 
            var storage = storage_example;  // string | storage name. (optional) 

            try
            {
                // Merge workbooks.
                WorkbookResponse result = apiInstance.CellsWorkbookPostWorkbooksMerge(name, mergeWith, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsWorkbookApi.CellsWorkbookPostWorkbooksMerge: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Workbook name. | 
 **mergeWith** | **string**| The workbook to merge with. | 
 **folder** | **string**| Source workbook folder. | [optional] 
 **storage** | **string**| storage name. | [optional] 

### Return type

[**WorkbookResponse**](WorkbookResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellsworkbookpostworkbookstextreplace"></a>
# **CellsWorkbookPostWorkbooksTextReplace**
> WorkbookReplaceResponse CellsWorkbookPostWorkbooksTextReplace (string name, string oldValue, string newValue, string folder = null, string storage = null)

Replace text.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsWorkbookPostWorkbooksTextReplaceExample
    {
        public void main()
        {
            var apiInstance = new CellsWorkbookApi();
            var name = name_example;  // string | Document name.
            var oldValue = oldValue_example;  // string | The old value.
            var newValue = newValue_example;  // string | The new value.
            var folder = folder_example;  // string | Document's folder. (optional) 
            var storage = storage_example;  // string | storage name. (optional) 

            try
            {
                // Replace text.
                WorkbookReplaceResponse result = apiInstance.CellsWorkbookPostWorkbooksTextReplace(name, oldValue, newValue, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsWorkbookApi.CellsWorkbookPostWorkbooksTextReplace: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Document name. | 
 **oldValue** | **string**| The old value. | 
 **newValue** | **string**| The new value. | 
 **folder** | **string**| Document&#39;s folder. | [optional] 
 **storage** | **string**| storage name. | [optional] 

### Return type

[**WorkbookReplaceResponse**](WorkbookReplaceResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellsworkbookpostworkbookstextsearch"></a>
# **CellsWorkbookPostWorkbooksTextSearch**
> TextItemsResponse CellsWorkbookPostWorkbooksTextSearch (string name, string text, string folder = null, string storage = null)

Search text.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsWorkbookPostWorkbooksTextSearchExample
    {
        public void main()
        {
            var apiInstance = new CellsWorkbookApi();
            var name = name_example;  // string | Document name.
            var text = text_example;  // string | Text sample.
            var folder = folder_example;  // string | Document's folder. (optional) 
            var storage = storage_example;  // string | storage name. (optional) 

            try
            {
                // Search text.
                TextItemsResponse result = apiInstance.CellsWorkbookPostWorkbooksTextSearch(name, text, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsWorkbookApi.CellsWorkbookPostWorkbooksTextSearch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Document name. | 
 **text** | **string**| Text sample. | 
 **folder** | **string**| Document&#39;s folder. | [optional] 
 **storage** | **string**| storage name. | [optional] 

### Return type

[**TextItemsResponse**](TextItemsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellsworkbookputconvertworkbook"></a>
# **CellsWorkbookPutConvertWorkbook**
> System.IO.Stream CellsWorkbookPutConvertWorkbook (byte[] workbook, string format = null, string password = null, string outPath = null)

Convert workbook from request content to some format.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsWorkbookPutConvertWorkbookExample
    {
        public void main()
        {
            var apiInstance = new CellsWorkbookApi();
            var workbook = BINARY_DATA_HERE;  // byte[] | 
            var format = format_example;  // string | The format to convert. (optional) 
            var password = password_example;  // string | The workbook password. (optional) 
            var outPath = outPath_example;  // string | Path to save result (optional) 

            try
            {
                // Convert workbook from request content to some format.
                System.IO.Stream result = apiInstance.CellsWorkbookPutConvertWorkbook(workbook, format, password, outPath);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsWorkbookApi.CellsWorkbookPutConvertWorkbook: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workbook** | **byte[]**|  | 
 **format** | **string**| The format to convert. | [optional] 
 **password** | **string**| The workbook password. | [optional] 
 **outPath** | **string**| Path to save result | [optional] 

### Return type

**System.IO.Stream**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellsworkbookputdocumentprotectfromchanges"></a>
# **CellsWorkbookPutDocumentProtectFromChanges**
> SaaSposeResponse CellsWorkbookPutDocumentProtectFromChanges (string name, PasswordRequest password = null, string folder = null, string storage = null)

Protect document from changes.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsWorkbookPutDocumentProtectFromChangesExample
    {
        public void main()
        {
            var apiInstance = new CellsWorkbookApi();
            var name = name_example;  // string | Document name.
            var password = new PasswordRequest(); // PasswordRequest | Modification password. (optional) 
            var folder = folder_example;  // string | Document's folder. (optional) 
            var storage = storage_example;  // string | storage name. (optional) 

            try
            {
                // Protect document from changes.
                SaaSposeResponse result = apiInstance.CellsWorkbookPutDocumentProtectFromChanges(name, password, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsWorkbookApi.CellsWorkbookPutDocumentProtectFromChanges: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Document name. | 
 **password** | [**PasswordRequest**](PasswordRequest.md)| Modification password. | [optional] 
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

<a name="cellsworkbookputworkbookcreate"></a>
# **CellsWorkbookPutWorkbookCreate**
> WorkbookResponse CellsWorkbookPutWorkbookCreate (string name, string templateFile = null, string dataFile = null, string folder = null, string storage = null)

Create new workbook using deferent methods.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsWorkbookPutWorkbookCreateExample
    {
        public void main()
        {
            var apiInstance = new CellsWorkbookApi();
            var name = name_example;  // string | The new document name.
            var templateFile = templateFile_example;  // string | The template file, if the data not provided default workbook is created. (optional) 
            var dataFile = dataFile_example;  // string | Smart marker data file, if the data not provided the request content is checked for the data. (optional) 
            var folder = folder_example;  // string | The new document folder. (optional) 
            var storage = storage_example;  // string | storage name. (optional) 

            try
            {
                // Create new workbook using deferent methods.
                WorkbookResponse result = apiInstance.CellsWorkbookPutWorkbookCreate(name, templateFile, dataFile, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsWorkbookApi.CellsWorkbookPutWorkbookCreate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The new document name. | 
 **templateFile** | **string**| The template file, if the data not provided default workbook is created. | [optional] 
 **dataFile** | **string**| Smart marker data file, if the data not provided the request content is checked for the data. | [optional] 
 **folder** | **string**| The new document folder. | [optional] 
 **storage** | **string**| storage name. | [optional] 

### Return type

[**WorkbookResponse**](WorkbookResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

