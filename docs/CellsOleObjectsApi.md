# Aspose.Cells.Cloud.SDK.Api.CellsOleObjectsApi

All URIs are relative to *https://api.aspose.cloud/v1.1/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CellsOleObjectsDeleteWorksheetOleObject**](CellsOleObjectsApi.md#cellsoleobjectsdeleteworksheetoleobject) | **DELETE** /cells/{name}/worksheets/{sheetName}/oleobjects/{oleObjectIndex} | Delete OLE object.
[**CellsOleObjectsDeleteWorksheetOleObjects**](CellsOleObjectsApi.md#cellsoleobjectsdeleteworksheetoleobjects) | **DELETE** /cells/{name}/worksheets/{sheetName}/oleobjects | Delete all OLE objects.
[**CellsOleObjectsGetWorksheetOleObject**](CellsOleObjectsApi.md#cellsoleobjectsgetworksheetoleobject) | **GET** /cells/{name}/worksheets/{sheetName}/oleobjects/{objectNumber} | Get OLE object info.
[**CellsOleObjectsGetWorksheetOleObjects**](CellsOleObjectsApi.md#cellsoleobjectsgetworksheetoleobjects) | **GET** /cells/{name}/worksheets/{sheetName}/oleobjects | Get worksheet OLE objects info.
[**CellsOleObjectsPostUpdateWorksheetOleObject**](CellsOleObjectsApi.md#cellsoleobjectspostupdateworksheetoleobject) | **POST** /cells/{name}/worksheets/{sheetName}/oleobjects/{oleObjectIndex} | Update OLE object.
[**CellsOleObjectsPutWorksheetOleObject**](CellsOleObjectsApi.md#cellsoleobjectsputworksheetoleobject) | **PUT** /cells/{name}/worksheets/{sheetName}/oleobjects | Add OLE object


<a name="cellsoleobjectsdeleteworksheetoleobject"></a>
# **CellsOleObjectsDeleteWorksheetOleObject**
> SaaSposeResponse CellsOleObjectsDeleteWorksheetOleObject (string name, string sheetName, int? oleObjectIndex, string folder = null)

Delete OLE object.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsOleObjectsDeleteWorksheetOleObjectExample
    {
        public void main()
        {
            var apiInstance = new CellsOleObjectsApi();
            var name = name_example;  // string | The workbook name.
            var sheetName = sheetName_example;  // string | The worsheet name.
            var oleObjectIndex = 56;  // int? | Ole object index
            var folder = folder_example;  // string | The workbook folder. (optional) 

            try
            {
                // Delete OLE object.
                SaaSposeResponse result = apiInstance.CellsOleObjectsDeleteWorksheetOleObject(name, sheetName, oleObjectIndex, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsOleObjectsApi.CellsOleObjectsDeleteWorksheetOleObject: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The workbook name. | 
 **sheetName** | **string**| The worsheet name. | 
 **oleObjectIndex** | **int?**| Ole object index | 
 **folder** | **string**| The workbook folder. | [optional] 

### Return type

[**SaaSposeResponse**](SaaSposeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellsoleobjectsdeleteworksheetoleobjects"></a>
# **CellsOleObjectsDeleteWorksheetOleObjects**
> SaaSposeResponse CellsOleObjectsDeleteWorksheetOleObjects (string name, string sheetName, string folder = null)

Delete all OLE objects.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsOleObjectsDeleteWorksheetOleObjectsExample
    {
        public void main()
        {
            var apiInstance = new CellsOleObjectsApi();
            var name = name_example;  // string | The workbook name.
            var sheetName = sheetName_example;  // string | The worsheet name.
            var folder = folder_example;  // string | The workbook folder. (optional) 

            try
            {
                // Delete all OLE objects.
                SaaSposeResponse result = apiInstance.CellsOleObjectsDeleteWorksheetOleObjects(name, sheetName, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsOleObjectsApi.CellsOleObjectsDeleteWorksheetOleObjects: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The workbook name. | 
 **sheetName** | **string**| The worsheet name. | 
 **folder** | **string**| The workbook folder. | [optional] 

### Return type

[**SaaSposeResponse**](SaaSposeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellsoleobjectsgetworksheetoleobject"></a>
# **CellsOleObjectsGetWorksheetOleObject**
> System.IO.Stream CellsOleObjectsGetWorksheetOleObject (string name, string sheetName, int? objectNumber, string folder = null)

Get OLE object info.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsOleObjectsGetWorksheetOleObjectExample
    {
        public void main()
        {
            var apiInstance = new CellsOleObjectsApi();
            var name = name_example;  // string | Document name.
            var sheetName = sheetName_example;  // string | Worksheet name.
            var objectNumber = 56;  // int? | The object number.
            var folder = folder_example;  // string | The document folder. (optional) 

            try
            {
                // Get OLE object info.
                System.IO.Stream result = apiInstance.CellsOleObjectsGetWorksheetOleObject(name, sheetName, objectNumber, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsOleObjectsApi.CellsOleObjectsGetWorksheetOleObject: " + e.Message );
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
 **objectNumber** | **int?**| The object number. | 
 **folder** | **string**| The document folder. | [optional] 

### Return type

**System.IO.Stream**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellsoleobjectsgetworksheetoleobjects"></a>
# **CellsOleObjectsGetWorksheetOleObjects**
> OleObjectsResponse CellsOleObjectsGetWorksheetOleObjects (string name, string sheetName, string folder = null)

Get worksheet OLE objects info.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsOleObjectsGetWorksheetOleObjectsExample
    {
        public void main()
        {
            var apiInstance = new CellsOleObjectsApi();
            var name = name_example;  // string | Document name.
            var sheetName = sheetName_example;  // string | The worksheet name.
            var folder = folder_example;  // string | Document's folder. (optional) 

            try
            {
                // Get worksheet OLE objects info.
                OleObjectsResponse result = apiInstance.CellsOleObjectsGetWorksheetOleObjects(name, sheetName, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsOleObjectsApi.CellsOleObjectsGetWorksheetOleObjects: " + e.Message );
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

### Return type

[**OleObjectsResponse**](OleObjectsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellsoleobjectspostupdateworksheetoleobject"></a>
# **CellsOleObjectsPostUpdateWorksheetOleObject**
> SaaSposeResponse CellsOleObjectsPostUpdateWorksheetOleObject (string name, string sheetName, int? oleObjectIndex, OleObject ole = null, string folder = null)

Update OLE object.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsOleObjectsPostUpdateWorksheetOleObjectExample
    {
        public void main()
        {
            var apiInstance = new CellsOleObjectsApi();
            var name = name_example;  // string | The workbook name.
            var sheetName = sheetName_example;  // string | The worsheet name.
            var oleObjectIndex = 56;  // int? | Ole object index
            var ole = new OleObject(); // OleObject | Ole Object (optional) 
            var folder = folder_example;  // string | The workbook folder. (optional) 

            try
            {
                // Update OLE object.
                SaaSposeResponse result = apiInstance.CellsOleObjectsPostUpdateWorksheetOleObject(name, sheetName, oleObjectIndex, ole, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsOleObjectsApi.CellsOleObjectsPostUpdateWorksheetOleObject: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The workbook name. | 
 **sheetName** | **string**| The worsheet name. | 
 **oleObjectIndex** | **int?**| Ole object index | 
 **ole** | [**OleObject**](OleObject.md)| Ole Object | [optional] 
 **folder** | **string**| The workbook folder. | [optional] 

### Return type

[**SaaSposeResponse**](SaaSposeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellsoleobjectsputworksheetoleobject"></a>
# **CellsOleObjectsPutWorksheetOleObject**
> OleObjectResponse CellsOleObjectsPutWorksheetOleObject (string name, string sheetName, OleObject oleObject = null, int? upperLeftRow = null, int? upperLeftColumn = null, int? height = null, int? width = null, string oleFile = null, string imageFile = null, string folder = null)

Add OLE object

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsOleObjectsPutWorksheetOleObjectExample
    {
        public void main()
        {
            var apiInstance = new CellsOleObjectsApi();
            var name = name_example;  // string | The workbook name.
            var sheetName = sheetName_example;  // string | The worsheet name.
            var oleObject = new OleObject(); // OleObject | Ole Object (optional) 
            var upperLeftRow = 56;  // int? | Upper left row index (optional)  (default to 0)
            var upperLeftColumn = 56;  // int? | Upper left column index (optional)  (default to 0)
            var height = 56;  // int? | Height of oleObject, in unit of pixel (optional)  (default to 0)
            var width = 56;  // int? | Width of oleObject, in unit of pixel (optional)  (default to 0)
            var oleFile = oleFile_example;  // string | OLE filename (optional) 
            var imageFile = imageFile_example;  // string | Image filename (optional) 
            var folder = folder_example;  // string | The workbook folder. (optional) 

            try
            {
                // Add OLE object
                OleObjectResponse result = apiInstance.CellsOleObjectsPutWorksheetOleObject(name, sheetName, oleObject, upperLeftRow, upperLeftColumn, height, width, oleFile, imageFile, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsOleObjectsApi.CellsOleObjectsPutWorksheetOleObject: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The workbook name. | 
 **sheetName** | **string**| The worsheet name. | 
 **oleObject** | [**OleObject**](OleObject.md)| Ole Object | [optional] 
 **upperLeftRow** | **int?**| Upper left row index | [optional] [default to 0]
 **upperLeftColumn** | **int?**| Upper left column index | [optional] [default to 0]
 **height** | **int?**| Height of oleObject, in unit of pixel | [optional] [default to 0]
 **width** | **int?**| Width of oleObject, in unit of pixel | [optional] [default to 0]
 **oleFile** | **string**| OLE filename | [optional] 
 **imageFile** | **string**| Image filename | [optional] 
 **folder** | **string**| The workbook folder. | [optional] 

### Return type

[**OleObjectResponse**](OleObjectResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

