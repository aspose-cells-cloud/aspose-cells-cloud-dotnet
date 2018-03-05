# Aspose.Cells.Cloud.SDK.Api.CellsShapesApi

All URIs are relative to *https://api.aspose.cloud/v1.1/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CellsShapesDeleteWorksheetShape**](CellsShapesApi.md#cellsshapesdeleteworksheetshape) | **DELETE** /cells/{name}/worksheets/{sheetName}/shapes/{shapeindex} | Delete a shape in worksheet
[**CellsShapesDeleteWorksheetShapes**](CellsShapesApi.md#cellsshapesdeleteworksheetshapes) | **DELETE** /cells/{name}/worksheets/{sheetName}/shapes | delete all shapes in worksheet
[**CellsShapesGetWorksheetShape**](CellsShapesApi.md#cellsshapesgetworksheetshape) | **GET** /cells/{name}/worksheets/{sheetName}/shapes/{shapeindex} | Get worksheet shape
[**CellsShapesGetWorksheetShapes**](CellsShapesApi.md#cellsshapesgetworksheetshapes) | **GET** /cells/{name}/worksheets/{sheetName}/shapes | Get worksheet shapes 
[**CellsShapesPostWorksheetShape**](CellsShapesApi.md#cellsshapespostworksheetshape) | **POST** /cells/{name}/worksheets/{sheetName}/shapes/{shapeindex} | Update a shape in worksheet
[**CellsShapesPutWorksheetShape**](CellsShapesApi.md#cellsshapesputworksheetshape) | **PUT** /cells/{name}/worksheets/{sheetName}/shapes | Add shape in worksheet


<a name="cellsshapesdeleteworksheetshape"></a>
# **CellsShapesDeleteWorksheetShape**
> SaaSposeResponse CellsShapesDeleteWorksheetShape (string name, string sheetName, int? shapeindex, string folder = null)

Delete a shape in worksheet

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsShapesDeleteWorksheetShapeExample
    {
        public void main()
        {
            var apiInstance = new CellsShapesApi();
            var name = name_example;  // string | document name.
            var sheetName = sheetName_example;  // string | worksheet name.
            var shapeindex = 56;  // int? | shape index in worksheet shapes.
            var folder = folder_example;  // string | Document's folder. (optional) 

            try
            {
                // Delete a shape in worksheet
                SaaSposeResponse result = apiInstance.CellsShapesDeleteWorksheetShape(name, sheetName, shapeindex, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsShapesApi.CellsShapesDeleteWorksheetShape: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| document name. | 
 **sheetName** | **string**| worksheet name. | 
 **shapeindex** | **int?**| shape index in worksheet shapes. | 
 **folder** | **string**| Document&#39;s folder. | [optional] 

### Return type

[**SaaSposeResponse**](SaaSposeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellsshapesdeleteworksheetshapes"></a>
# **CellsShapesDeleteWorksheetShapes**
> SaaSposeResponse CellsShapesDeleteWorksheetShapes (string name, string sheetName, string folder = null)

delete all shapes in worksheet

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsShapesDeleteWorksheetShapesExample
    {
        public void main()
        {
            var apiInstance = new CellsShapesApi();
            var name = name_example;  // string | document name.
            var sheetName = sheetName_example;  // string | worksheet name.
            var folder = folder_example;  // string | Document's folder. (optional) 

            try
            {
                // delete all shapes in worksheet
                SaaSposeResponse result = apiInstance.CellsShapesDeleteWorksheetShapes(name, sheetName, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsShapesApi.CellsShapesDeleteWorksheetShapes: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| document name. | 
 **sheetName** | **string**| worksheet name. | 
 **folder** | **string**| Document&#39;s folder. | [optional] 

### Return type

[**SaaSposeResponse**](SaaSposeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellsshapesgetworksheetshape"></a>
# **CellsShapesGetWorksheetShape**
> ShapeResponse CellsShapesGetWorksheetShape (string name, string sheetName, int? shapeindex, string folder = null)

Get worksheet shape

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsShapesGetWorksheetShapeExample
    {
        public void main()
        {
            var apiInstance = new CellsShapesApi();
            var name = name_example;  // string | document name.
            var sheetName = sheetName_example;  // string | worksheet name.
            var shapeindex = 56;  // int? | shape index in worksheet shapes.
            var folder = folder_example;  // string | Document's folder. (optional) 

            try
            {
                // Get worksheet shape
                ShapeResponse result = apiInstance.CellsShapesGetWorksheetShape(name, sheetName, shapeindex, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsShapesApi.CellsShapesGetWorksheetShape: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| document name. | 
 **sheetName** | **string**| worksheet name. | 
 **shapeindex** | **int?**| shape index in worksheet shapes. | 
 **folder** | **string**| Document&#39;s folder. | [optional] 

### Return type

[**ShapeResponse**](ShapeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellsshapesgetworksheetshapes"></a>
# **CellsShapesGetWorksheetShapes**
> ShapesResponse CellsShapesGetWorksheetShapes (string name, string sheetName, string folder = null)

Get worksheet shapes 

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsShapesGetWorksheetShapesExample
    {
        public void main()
        {
            var apiInstance = new CellsShapesApi();
            var name = name_example;  // string | document name.
            var sheetName = sheetName_example;  // string | worksheet name.
            var folder = folder_example;  // string | Document's folder. (optional) 

            try
            {
                // Get worksheet shapes 
                ShapesResponse result = apiInstance.CellsShapesGetWorksheetShapes(name, sheetName, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsShapesApi.CellsShapesGetWorksheetShapes: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| document name. | 
 **sheetName** | **string**| worksheet name. | 
 **folder** | **string**| Document&#39;s folder. | [optional] 

### Return type

[**ShapesResponse**](ShapesResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellsshapespostworksheetshape"></a>
# **CellsShapesPostWorksheetShape**
> SaaSposeResponse CellsShapesPostWorksheetShape (string name, string sheetName, int? shapeindex, Shape dto = null, string folder = null)

Update a shape in worksheet

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsShapesPostWorksheetShapeExample
    {
        public void main()
        {
            var apiInstance = new CellsShapesApi();
            var name = name_example;  // string | document name.
            var sheetName = sheetName_example;  // string | worksheet name.
            var shapeindex = 56;  // int? | shape index in worksheet shapes.
            var dto = new Shape(); // Shape |  (optional) 
            var folder = folder_example;  // string | Document's folder. (optional) 

            try
            {
                // Update a shape in worksheet
                SaaSposeResponse result = apiInstance.CellsShapesPostWorksheetShape(name, sheetName, shapeindex, dto, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsShapesApi.CellsShapesPostWorksheetShape: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| document name. | 
 **sheetName** | **string**| worksheet name. | 
 **shapeindex** | **int?**| shape index in worksheet shapes. | 
 **dto** | [**Shape**](Shape.md)|  | [optional] 
 **folder** | **string**| Document&#39;s folder. | [optional] 

### Return type

[**SaaSposeResponse**](SaaSposeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellsshapesputworksheetshape"></a>
# **CellsShapesPutWorksheetShape**
> ShapeResponse CellsShapesPutWorksheetShape (string name, string sheetName, string drawingType, int? upperLeftRow, int? upperLeftColumn, int? top, int? left, int? width, int? height, string folder = null)

Add shape in worksheet

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsShapesPutWorksheetShapeExample
    {
        public void main()
        {
            var apiInstance = new CellsShapesApi();
            var name = name_example;  // string | document name.
            var sheetName = sheetName_example;  // string | worksheet name.
            var drawingType = drawingType_example;  // string | shape object type
            var upperLeftRow = 56;  // int? | Upper left row index.
            var upperLeftColumn = 56;  // int? | Upper left column index.
            var top = 56;  // int? | Represents the vertical offset of Spinner from its left row, in unit of pixel.
            var left = 56;  // int? | Represents the horizontal offset of Spinner from its left column, in unit of pixel.
            var width = 56;  // int? | Represents the height of Spinner, in unit of pixel.
            var height = 56;  // int? | Represents the width of Spinner, in unit of pixel.
            var folder = folder_example;  // string | Document's folder. (optional) 

            try
            {
                // Add shape in worksheet
                ShapeResponse result = apiInstance.CellsShapesPutWorksheetShape(name, sheetName, drawingType, upperLeftRow, upperLeftColumn, top, left, width, height, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsShapesApi.CellsShapesPutWorksheetShape: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| document name. | 
 **sheetName** | **string**| worksheet name. | 
 **drawingType** | **string**| shape object type | 
 **upperLeftRow** | **int?**| Upper left row index. | 
 **upperLeftColumn** | **int?**| Upper left column index. | 
 **top** | **int?**| Represents the vertical offset of Spinner from its left row, in unit of pixel. | 
 **left** | **int?**| Represents the horizontal offset of Spinner from its left column, in unit of pixel. | 
 **width** | **int?**| Represents the height of Spinner, in unit of pixel. | 
 **height** | **int?**| Represents the width of Spinner, in unit of pixel. | 
 **folder** | **string**| Document&#39;s folder. | [optional] 

### Return type

[**ShapeResponse**](ShapeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

