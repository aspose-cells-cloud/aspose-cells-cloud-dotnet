# Aspose.Cells.Cloud.SDK.Api.CellsPicturesApi

All URIs are relative to *https://api.aspose.cloud/v1.1/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CellsPicturesDeleteWorksheetPicture**](CellsPicturesApi.md#cellspicturesdeleteworksheetpicture) | **DELETE** /cells/{name}/worksheets/{sheetName}/pictures/{pictureIndex} | Delete a picture object in worksheet
[**CellsPicturesDeleteWorksheetPictures**](CellsPicturesApi.md#cellspicturesdeleteworksheetpictures) | **DELETE** /cells/{name}/worksheets/{sheetName}/pictures | Delete all pictures in worksheet.
[**CellsPicturesGetWorksheetPicture**](CellsPicturesApi.md#cellspicturesgetworksheetpicture) | **GET** /cells/{name}/worksheets/{sheetName}/pictures/{pictureIndex} | GRead worksheet picture by number.
[**CellsPicturesGetWorksheetPictures**](CellsPicturesApi.md#cellspicturesgetworksheetpictures) | **GET** /cells/{name}/worksheets/{sheetName}/pictures | Read worksheet pictures.
[**CellsPicturesPostWorksheetPicture**](CellsPicturesApi.md#cellspicturespostworksheetpicture) | **POST** /cells/{name}/worksheets/{sheetName}/pictures/{pictureIndex} | Update worksheet picture by index.
[**CellsPicturesPutWorksheetAddPicture**](CellsPicturesApi.md#cellspicturesputworksheetaddpicture) | **PUT** /cells/{name}/worksheets/{sheetName}/pictures | Add a new worksheet picture.


<a name="cellspicturesdeleteworksheetpicture"></a>
# **CellsPicturesDeleteWorksheetPicture**
> SaaSposeResponse CellsPicturesDeleteWorksheetPicture (string name, string sheetName, int? pictureIndex, string folder = null, string storage = null)

Delete a picture object in worksheet

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsPicturesDeleteWorksheetPictureExample
    {
        public void main()
        {
            var apiInstance = new CellsPicturesApi();
            var name = name_example;  // string | The workbook name.
            var sheetName = sheetName_example;  // string | The worsheet name.
            var pictureIndex = 56;  // int? | Picture index
            var folder = folder_example;  // string | The workbook folder. (optional) 
            var storage = storage_example;  // string | storage name. (optional) 

            try
            {
                // Delete a picture object in worksheet
                SaaSposeResponse result = apiInstance.CellsPicturesDeleteWorksheetPicture(name, sheetName, pictureIndex, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsPicturesApi.CellsPicturesDeleteWorksheetPicture: " + e.Message );
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
 **pictureIndex** | **int?**| Picture index | 
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

<a name="cellspicturesdeleteworksheetpictures"></a>
# **CellsPicturesDeleteWorksheetPictures**
> SaaSposeResponse CellsPicturesDeleteWorksheetPictures (string name, string sheetName, string folder = null, string storage = null)

Delete all pictures in worksheet.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsPicturesDeleteWorksheetPicturesExample
    {
        public void main()
        {
            var apiInstance = new CellsPicturesApi();
            var name = name_example;  // string | Document name.
            var sheetName = sheetName_example;  // string | Worksheet name.
            var folder = folder_example;  // string | The document folder. (optional) 
            var storage = storage_example;  // string | storage name. (optional) 

            try
            {
                // Delete all pictures in worksheet.
                SaaSposeResponse result = apiInstance.CellsPicturesDeleteWorksheetPictures(name, sheetName, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsPicturesApi.CellsPicturesDeleteWorksheetPictures: " + e.Message );
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

<a name="cellspicturesgetworksheetpicture"></a>
# **CellsPicturesGetWorksheetPicture**
> System.IO.Stream CellsPicturesGetWorksheetPicture (string name, string sheetName, int? pictureIndex, string format = null, string folder = null, string storage = null)

GRead worksheet picture by number.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsPicturesGetWorksheetPictureExample
    {
        public void main()
        {
            var apiInstance = new CellsPicturesApi();
            var name = name_example;  // string | Document name.
            var sheetName = sheetName_example;  // string | Worksheet name.
            var pictureIndex = 56;  // int? | The picture index.
            var format = format_example;  // string | The exported object format. (optional) 
            var folder = folder_example;  // string | The document folder. (optional) 
            var storage = storage_example;  // string | storage name. (optional) 

            try
            {
                // GRead worksheet picture by number.
                System.IO.Stream result = apiInstance.CellsPicturesGetWorksheetPicture(name, sheetName, pictureIndex, format, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsPicturesApi.CellsPicturesGetWorksheetPicture: " + e.Message );
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
 **pictureIndex** | **int?**| The picture index. | 
 **format** | **string**| The exported object format. | [optional] 
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

<a name="cellspicturesgetworksheetpictures"></a>
# **CellsPicturesGetWorksheetPictures**
> PicturesResponse CellsPicturesGetWorksheetPictures (string name, string sheetName, string folder = null, string storage = null)

Read worksheet pictures.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsPicturesGetWorksheetPicturesExample
    {
        public void main()
        {
            var apiInstance = new CellsPicturesApi();
            var name = name_example;  // string | Document name.
            var sheetName = sheetName_example;  // string | The worksheet name.
            var folder = folder_example;  // string | Document's folder. (optional) 
            var storage = storage_example;  // string | storage name. (optional) 

            try
            {
                // Read worksheet pictures.
                PicturesResponse result = apiInstance.CellsPicturesGetWorksheetPictures(name, sheetName, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsPicturesApi.CellsPicturesGetWorksheetPictures: " + e.Message );
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

[**PicturesResponse**](PicturesResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellspicturespostworksheetpicture"></a>
# **CellsPicturesPostWorksheetPicture**
> PictureResponse CellsPicturesPostWorksheetPicture (string name, string sheetName, int? pictureIndex, Picture picture = null, string folder = null, string storage = null)

Update worksheet picture by index.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsPicturesPostWorksheetPictureExample
    {
        public void main()
        {
            var apiInstance = new CellsPicturesApi();
            var name = name_example;  // string | Document name.
            var sheetName = sheetName_example;  // string | Worksheet name.
            var pictureIndex = 56;  // int? | The picture's index.
            var picture = new Picture(); // Picture | Picture object (optional) 
            var folder = folder_example;  // string | The document folder. (optional) 
            var storage = storage_example;  // string | storage name. (optional) 

            try
            {
                // Update worksheet picture by index.
                PictureResponse result = apiInstance.CellsPicturesPostWorksheetPicture(name, sheetName, pictureIndex, picture, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsPicturesApi.CellsPicturesPostWorksheetPicture: " + e.Message );
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
 **pictureIndex** | **int?**| The picture&#39;s index. | 
 **picture** | [**Picture**](Picture.md)| Picture object | [optional] 
 **folder** | **string**| The document folder. | [optional] 
 **storage** | **string**| storage name. | [optional] 

### Return type

[**PictureResponse**](PictureResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellspicturesputworksheetaddpicture"></a>
# **CellsPicturesPutWorksheetAddPicture**
> PicturesResponse CellsPicturesPutWorksheetAddPicture (string name, string sheetName, Picture picture = null, int? upperLeftRow = null, int? upperLeftColumn = null, int? lowerRightRow = null, int? lowerRightColumn = null, string picturePath = null, string folder = null, string storage = null)

Add a new worksheet picture.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsPicturesPutWorksheetAddPictureExample
    {
        public void main()
        {
            var apiInstance = new CellsPicturesApi();
            var name = name_example;  // string | The workbook name.
            var sheetName = sheetName_example;  // string | The worsheet name.
            var picture = new Picture(); // Picture | Pictute object (optional) 
            var upperLeftRow = 56;  // int? | The image upper left row. (optional)  (default to 0)
            var upperLeftColumn = 56;  // int? | The image upper left column. (optional)  (default to 0)
            var lowerRightRow = 56;  // int? | The image low right row. (optional)  (default to 0)
            var lowerRightColumn = 56;  // int? | The image low right column. (optional)  (default to 0)
            var picturePath = picturePath_example;  // string | The picture path, if not provided the picture data is inspected in the request body. (optional) 
            var folder = folder_example;  // string | The workbook folder. (optional) 
            var storage = storage_example;  // string | storage name. (optional) 

            try
            {
                // Add a new worksheet picture.
                PicturesResponse result = apiInstance.CellsPicturesPutWorksheetAddPicture(name, sheetName, picture, upperLeftRow, upperLeftColumn, lowerRightRow, lowerRightColumn, picturePath, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsPicturesApi.CellsPicturesPutWorksheetAddPicture: " + e.Message );
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
 **picture** | [**Picture**](Picture.md)| Pictute object | [optional] 
 **upperLeftRow** | **int?**| The image upper left row. | [optional] [default to 0]
 **upperLeftColumn** | **int?**| The image upper left column. | [optional] [default to 0]
 **lowerRightRow** | **int?**| The image low right row. | [optional] [default to 0]
 **lowerRightColumn** | **int?**| The image low right column. | [optional] [default to 0]
 **picturePath** | **string**| The picture path, if not provided the picture data is inspected in the request body. | [optional] 
 **folder** | **string**| The workbook folder. | [optional] 
 **storage** | **string**| storage name. | [optional] 

### Return type

[**PicturesResponse**](PicturesResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

