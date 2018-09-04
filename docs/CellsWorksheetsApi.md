# Aspose.Cells.Cloud.SDK.Api.CellsWorksheetsApi

All URIs are relative to *https://api.aspose.cloud/v1.1/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CellsWorksheetsDeleteUnprotectWorksheet**](CellsWorksheetsApi.md#cellsworksheetsdeleteunprotectworksheet) | **DELETE** /cells/{name}/worksheets/{sheetName}/protection | Unprotect worksheet.
[**CellsWorksheetsDeleteWorksheet**](CellsWorksheetsApi.md#cellsworksheetsdeleteworksheet) | **DELETE** /cells/{name}/worksheets/{sheetName} | Delete worksheet.
[**CellsWorksheetsDeleteWorksheetBackground**](CellsWorksheetsApi.md#cellsworksheetsdeleteworksheetbackground) | **DELETE** /cells/{name}/worksheets/{sheetName}/background | Set worksheet background image.
[**CellsWorksheetsDeleteWorksheetComment**](CellsWorksheetsApi.md#cellsworksheetsdeleteworksheetcomment) | **DELETE** /cells/{name}/worksheets/{sheetName}/comments/{cellName} | Delete worksheet&#39;s cell comment.
[**CellsWorksheetsDeleteWorksheetComments**](CellsWorksheetsApi.md#cellsworksheetsdeleteworksheetcomments) | **DELETE** /cells/{name}/worksheets/{sheetName}/comments | Delete all comments for worksheet.
[**CellsWorksheetsDeleteWorksheetFreezePanes**](CellsWorksheetsApi.md#cellsworksheetsdeleteworksheetfreezepanes) | **DELETE** /cells/{name}/worksheets/{sheetName}/freezepanes | Unfreeze panes
[**CellsWorksheetsGetNamedRanges**](CellsWorksheetsApi.md#cellsworksheetsgetnamedranges) | **GET** /cells/{name}/worksheets/ranges | Read worksheets ranges info.
[**CellsWorksheetsGetWorksheet**](CellsWorksheetsApi.md#cellsworksheetsgetworksheet) | **GET** /cells/{name}/worksheets/{sheetName} | Read worksheet info or export.
[**CellsWorksheetsGetWorksheetCalculateFormula**](CellsWorksheetsApi.md#cellsworksheetsgetworksheetcalculateformula) | **GET** /cells/{name}/worksheets/{sheetName}/formulaResult | Calculate formula value.
[**CellsWorksheetsGetWorksheetComment**](CellsWorksheetsApi.md#cellsworksheetsgetworksheetcomment) | **GET** /cells/{name}/worksheets/{sheetName}/comments/{cellName} | Get worksheet comment by cell name.
[**CellsWorksheetsGetWorksheetComments**](CellsWorksheetsApi.md#cellsworksheetsgetworksheetcomments) | **GET** /cells/{name}/worksheets/{sheetName}/comments | Get worksheet comments.
[**CellsWorksheetsGetWorksheetMergedCell**](CellsWorksheetsApi.md#cellsworksheetsgetworksheetmergedcell) | **GET** /cells/{name}/worksheets/{sheetName}/mergedCells/{mergedCellIndex} | Get worksheet merged cell by its index.
[**CellsWorksheetsGetWorksheetMergedCells**](CellsWorksheetsApi.md#cellsworksheetsgetworksheetmergedcells) | **GET** /cells/{name}/worksheets/{sheetName}/mergedCells | Get worksheet merged cells.
[**CellsWorksheetsGetWorksheetTextItems**](CellsWorksheetsApi.md#cellsworksheetsgetworksheettextitems) | **GET** /cells/{name}/worksheets/{sheetName}/textItems | Get worksheet text items.
[**CellsWorksheetsGetWorksheets**](CellsWorksheetsApi.md#cellsworksheetsgetworksheets) | **GET** /cells/{name}/worksheets | Read worksheets info.
[**CellsWorksheetsPostAutofitWorksheetColumns**](CellsWorksheetsApi.md#cellsworksheetspostautofitworksheetcolumns) | **POST** /cells/{name}/worksheets/{sheetName}/autofitcolumns | 
[**CellsWorksheetsPostAutofitWorksheetRow**](CellsWorksheetsApi.md#cellsworksheetspostautofitworksheetrow) | **POST** /cells/{name}/worksheets/{sheetName}/autofitrow | 
[**CellsWorksheetsPostAutofitWorksheetRows**](CellsWorksheetsApi.md#cellsworksheetspostautofitworksheetrows) | **POST** /cells/{name}/worksheets/{sheetName}/autofitrows | Autofit worksheet rows.
[**CellsWorksheetsPostCopyWorksheet**](CellsWorksheetsApi.md#cellsworksheetspostcopyworksheet) | **POST** /cells/{name}/worksheets/{sheetName}/copy | 
[**CellsWorksheetsPostMoveWorksheet**](CellsWorksheetsApi.md#cellsworksheetspostmoveworksheet) | **POST** /cells/{name}/worksheets/{sheetName}/position | Move worksheet.
[**CellsWorksheetsPostRenameWorksheet**](CellsWorksheetsApi.md#cellsworksheetspostrenameworksheet) | **POST** /cells/{name}/worksheets/{sheetName}/rename | Rename worksheet
[**CellsWorksheetsPostUpdateWorksheetProperty**](CellsWorksheetsApi.md#cellsworksheetspostupdateworksheetproperty) | **POST** /cells/{name}/worksheets/{sheetName} | Update worksheet property
[**CellsWorksheetsPostUpdateWorksheetZoom**](CellsWorksheetsApi.md#cellsworksheetspostupdateworksheetzoom) | **POST** /cells/{name}/worksheets/{sheetName}/zoom | 
[**CellsWorksheetsPostWorksheetComment**](CellsWorksheetsApi.md#cellsworksheetspostworksheetcomment) | **POST** /cells/{name}/worksheets/{sheetName}/comments/{cellName} | Update worksheet&#39;s cell comment.
[**CellsWorksheetsPostWorksheetRangeSort**](CellsWorksheetsApi.md#cellsworksheetspostworksheetrangesort) | **POST** /cells/{name}/worksheets/{sheetName}/sort | Sort worksheet range.
[**CellsWorksheetsPostWorksheetTextSearch**](CellsWorksheetsApi.md#cellsworksheetspostworksheettextsearch) | **POST** /cells/{name}/worksheets/{sheetName}/findText | Search text.
[**CellsWorksheetsPostWorsheetTextReplace**](CellsWorksheetsApi.md#cellsworksheetspostworsheettextreplace) | **POST** /cells/{name}/worksheets/{sheetName}/replaceText | Replace text.
[**CellsWorksheetsPutAddNewWorksheet**](CellsWorksheetsApi.md#cellsworksheetsputaddnewworksheet) | **PUT** /cells/{name}/worksheets/{sheetName} | Add new worksheet.
[**CellsWorksheetsPutChangeVisibilityWorksheet**](CellsWorksheetsApi.md#cellsworksheetsputchangevisibilityworksheet) | **PUT** /cells/{name}/worksheets/{sheetName}/visible | Change worksheet visibility.
[**CellsWorksheetsPutProtectWorksheet**](CellsWorksheetsApi.md#cellsworksheetsputprotectworksheet) | **PUT** /cells/{name}/worksheets/{sheetName}/protection | Protect worksheet.
[**CellsWorksheetsPutWorksheetBackground**](CellsWorksheetsApi.md#cellsworksheetsputworksheetbackground) | **PUT** /cells/{name}/worksheets/{sheetName}/background | Set worksheet background image.
[**CellsWorksheetsPutWorksheetComment**](CellsWorksheetsApi.md#cellsworksheetsputworksheetcomment) | **PUT** /cells/{name}/worksheets/{sheetName}/comments/{cellName} | Add worksheet&#39;s cell comment.
[**CellsWorksheetsPutWorksheetFreezePanes**](CellsWorksheetsApi.md#cellsworksheetsputworksheetfreezepanes) | **PUT** /cells/{name}/worksheets/{sheetName}/freezepanes | Set freeze panes


<a name="cellsworksheetsdeleteunprotectworksheet"></a>
# **CellsWorksheetsDeleteUnprotectWorksheet**
> WorksheetResponse CellsWorksheetsDeleteUnprotectWorksheet (string name, string sheetName, ProtectSheetParameter protectParameter = null, string folder = null, string storage = null)

Unprotect worksheet.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsWorksheetsDeleteUnprotectWorksheetExample
    {
        public void main()
        {
            var apiInstance = new CellsWorksheetsApi();
            var name = name_example;  // string | Document name.
            var sheetName = sheetName_example;  // string | The worksheet name.
            var protectParameter = new ProtectSheetParameter(); // ProtectSheetParameter | with protection settings. Only password is used here. (optional) 
            var folder = folder_example;  // string | Document folder. (optional) 
            var storage = storage_example;  // string | storage name. (optional) 

            try
            {
                // Unprotect worksheet.
                WorksheetResponse result = apiInstance.CellsWorksheetsDeleteUnprotectWorksheet(name, sheetName, protectParameter, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsWorksheetsApi.CellsWorksheetsDeleteUnprotectWorksheet: " + e.Message );
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
 **protectParameter** | [**ProtectSheetParameter**](ProtectSheetParameter.md)| with protection settings. Only password is used here. | [optional] 
 **folder** | **string**| Document folder. | [optional] 
 **storage** | **string**| storage name. | [optional] 

### Return type

[**WorksheetResponse**](WorksheetResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellsworksheetsdeleteworksheet"></a>
# **CellsWorksheetsDeleteWorksheet**
> WorksheetsResponse CellsWorksheetsDeleteWorksheet (string name, string sheetName, string folder = null, string storage = null)

Delete worksheet.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsWorksheetsDeleteWorksheetExample
    {
        public void main()
        {
            var apiInstance = new CellsWorksheetsApi();
            var name = name_example;  // string | Document name.
            var sheetName = sheetName_example;  // string | The worksheet name.
            var folder = folder_example;  // string | Document's folder. (optional) 
            var storage = storage_example;  // string | storage name. (optional) 

            try
            {
                // Delete worksheet.
                WorksheetsResponse result = apiInstance.CellsWorksheetsDeleteWorksheet(name, sheetName, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsWorksheetsApi.CellsWorksheetsDeleteWorksheet: " + e.Message );
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

[**WorksheetsResponse**](WorksheetsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellsworksheetsdeleteworksheetbackground"></a>
# **CellsWorksheetsDeleteWorksheetBackground**
> SaaSposeResponse CellsWorksheetsDeleteWorksheetBackground (string name, string sheetName, string folder = null, string storage = null)

Set worksheet background image.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsWorksheetsDeleteWorksheetBackgroundExample
    {
        public void main()
        {
            var apiInstance = new CellsWorksheetsApi();
            var name = name_example;  // string | 
            var sheetName = sheetName_example;  // string | 
            var folder = folder_example;  // string |  (optional) 
            var storage = storage_example;  // string | storage name. (optional) 

            try
            {
                // Set worksheet background image.
                SaaSposeResponse result = apiInstance.CellsWorksheetsDeleteWorksheetBackground(name, sheetName, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsWorksheetsApi.CellsWorksheetsDeleteWorksheetBackground: " + e.Message );
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
 **storage** | **string**| storage name. | [optional] 

### Return type

[**SaaSposeResponse**](SaaSposeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellsworksheetsdeleteworksheetcomment"></a>
# **CellsWorksheetsDeleteWorksheetComment**
> SaaSposeResponse CellsWorksheetsDeleteWorksheetComment (string name, string sheetName, string cellName, string folder = null, string storage = null)

Delete worksheet's cell comment.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsWorksheetsDeleteWorksheetCommentExample
    {
        public void main()
        {
            var apiInstance = new CellsWorksheetsApi();
            var name = name_example;  // string | The document name.
            var sheetName = sheetName_example;  // string | The worksheet name.
            var cellName = cellName_example;  // string | The cell name
            var folder = folder_example;  // string | The document folder. (optional) 
            var storage = storage_example;  // string | storage name. (optional) 

            try
            {
                // Delete worksheet's cell comment.
                SaaSposeResponse result = apiInstance.CellsWorksheetsDeleteWorksheetComment(name, sheetName, cellName, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsWorksheetsApi.CellsWorksheetsDeleteWorksheetComment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **sheetName** | **string**| The worksheet name. | 
 **cellName** | **string**| The cell name | 
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

<a name="cellsworksheetsdeleteworksheetcomments"></a>
# **CellsWorksheetsDeleteWorksheetComments**
> SaaSposeResponse CellsWorksheetsDeleteWorksheetComments (string name, string sheetName, string folder = null, string storage = null)

Delete all comments for worksheet.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsWorksheetsDeleteWorksheetCommentsExample
    {
        public void main()
        {
            var apiInstance = new CellsWorksheetsApi();
            var name = name_example;  // string | 
            var sheetName = sheetName_example;  // string | 
            var folder = folder_example;  // string |  (optional) 
            var storage = storage_example;  // string | storage name. (optional) 

            try
            {
                // Delete all comments for worksheet.
                SaaSposeResponse result = apiInstance.CellsWorksheetsDeleteWorksheetComments(name, sheetName, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsWorksheetsApi.CellsWorksheetsDeleteWorksheetComments: " + e.Message );
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
 **storage** | **string**| storage name. | [optional] 

### Return type

[**SaaSposeResponse**](SaaSposeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellsworksheetsdeleteworksheetfreezepanes"></a>
# **CellsWorksheetsDeleteWorksheetFreezePanes**
> SaaSposeResponse CellsWorksheetsDeleteWorksheetFreezePanes (string name, string sheetName, int? row, int? column, int? freezedRows, int? freezedColumns, string folder = null, string storage = null)

Unfreeze panes

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsWorksheetsDeleteWorksheetFreezePanesExample
    {
        public void main()
        {
            var apiInstance = new CellsWorksheetsApi();
            var name = name_example;  // string | 
            var sheetName = sheetName_example;  // string | 
            var row = 56;  // int? | 
            var column = 56;  // int? | 
            var freezedRows = 56;  // int? | 
            var freezedColumns = 56;  // int? | 
            var folder = folder_example;  // string |  (optional) 
            var storage = storage_example;  // string | storage name. (optional) 

            try
            {
                // Unfreeze panes
                SaaSposeResponse result = apiInstance.CellsWorksheetsDeleteWorksheetFreezePanes(name, sheetName, row, column, freezedRows, freezedColumns, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsWorksheetsApi.CellsWorksheetsDeleteWorksheetFreezePanes: " + e.Message );
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
 **row** | **int?**|  | 
 **column** | **int?**|  | 
 **freezedRows** | **int?**|  | 
 **freezedColumns** | **int?**|  | 
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

<a name="cellsworksheetsgetnamedranges"></a>
# **CellsWorksheetsGetNamedRanges**
> RangesResponse CellsWorksheetsGetNamedRanges (string name, string folder = null, string storage = null)

Read worksheets ranges info.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsWorksheetsGetNamedRangesExample
    {
        public void main()
        {
            var apiInstance = new CellsWorksheetsApi();
            var name = name_example;  // string | Document name.
            var folder = folder_example;  // string | Document folder. (optional) 
            var storage = storage_example;  // string | storage name. (optional) 

            try
            {
                // Read worksheets ranges info.
                RangesResponse result = apiInstance.CellsWorksheetsGetNamedRanges(name, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsWorksheetsApi.CellsWorksheetsGetNamedRanges: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Document name. | 
 **folder** | **string**| Document folder. | [optional] 
 **storage** | **string**| storage name. | [optional] 

### Return type

[**RangesResponse**](RangesResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellsworksheetsgetworksheet"></a>
# **CellsWorksheetsGetWorksheet**
> System.IO.Stream CellsWorksheetsGetWorksheet (string name, string sheetName, string format = null, int? verticalResolution = null, int? horizontalResolution = null, string folder = null, string storage = null)

Read worksheet info or export.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsWorksheetsGetWorksheetExample
    {
        public void main()
        {
            var apiInstance = new CellsWorksheetsApi();
            var name = name_example;  // string | The document name.
            var sheetName = sheetName_example;  // string | The worksheet name.
            var format = format_example;  // string | The exported file format. (optional) 
            var verticalResolution = 56;  // int? | Image vertical resolution. (optional)  (default to 0)
            var horizontalResolution = 56;  // int? | Image horizontal resolution. (optional)  (default to 0)
            var folder = folder_example;  // string | The document folder. (optional) 
            var storage = storage_example;  // string | storage name. (optional) 

            try
            {
                // Read worksheet info or export.
                System.IO.Stream result = apiInstance.CellsWorksheetsGetWorksheet(name, sheetName, format, verticalResolution, horizontalResolution, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsWorksheetsApi.CellsWorksheetsGetWorksheet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **sheetName** | **string**| The worksheet name. | 
 **format** | **string**| The exported file format. | [optional] 
 **verticalResolution** | **int?**| Image vertical resolution. | [optional] [default to 0]
 **horizontalResolution** | **int?**| Image horizontal resolution. | [optional] [default to 0]
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

<a name="cellsworksheetsgetworksheetcalculateformula"></a>
# **CellsWorksheetsGetWorksheetCalculateFormula**
> SingleValueResponse CellsWorksheetsGetWorksheetCalculateFormula (string name, string sheetName, string formula, string folder = null, string storage = null)

Calculate formula value.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsWorksheetsGetWorksheetCalculateFormulaExample
    {
        public void main()
        {
            var apiInstance = new CellsWorksheetsApi();
            var name = name_example;  // string | Document name.
            var sheetName = sheetName_example;  // string | Worksheet name.
            var formula = formula_example;  // string | The formula.
            var folder = folder_example;  // string | Document's folder. (optional) 
            var storage = storage_example;  // string | storage name. (optional) 

            try
            {
                // Calculate formula value.
                SingleValueResponse result = apiInstance.CellsWorksheetsGetWorksheetCalculateFormula(name, sheetName, formula, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsWorksheetsApi.CellsWorksheetsGetWorksheetCalculateFormula: " + e.Message );
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
 **formula** | **string**| The formula. | 
 **folder** | **string**| Document&#39;s folder. | [optional] 
 **storage** | **string**| storage name. | [optional] 

### Return type

[**SingleValueResponse**](SingleValueResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellsworksheetsgetworksheetcomment"></a>
# **CellsWorksheetsGetWorksheetComment**
> CommentResponse CellsWorksheetsGetWorksheetComment (string name, string sheetName, string cellName, string folder = null, string storage = null)

Get worksheet comment by cell name.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsWorksheetsGetWorksheetCommentExample
    {
        public void main()
        {
            var apiInstance = new CellsWorksheetsApi();
            var name = name_example;  // string | The document name.
            var sheetName = sheetName_example;  // string | The worksheet name.
            var cellName = cellName_example;  // string | The cell name
            var folder = folder_example;  // string | The document folder. (optional) 
            var storage = storage_example;  // string | storage name. (optional) 

            try
            {
                // Get worksheet comment by cell name.
                CommentResponse result = apiInstance.CellsWorksheetsGetWorksheetComment(name, sheetName, cellName, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsWorksheetsApi.CellsWorksheetsGetWorksheetComment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **sheetName** | **string**| The worksheet name. | 
 **cellName** | **string**| The cell name | 
 **folder** | **string**| The document folder. | [optional] 
 **storage** | **string**| storage name. | [optional] 

### Return type

[**CommentResponse**](CommentResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellsworksheetsgetworksheetcomments"></a>
# **CellsWorksheetsGetWorksheetComments**
> CommentsResponse CellsWorksheetsGetWorksheetComments (string name, string sheetName, string folder = null, string storage = null)

Get worksheet comments.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsWorksheetsGetWorksheetCommentsExample
    {
        public void main()
        {
            var apiInstance = new CellsWorksheetsApi();
            var name = name_example;  // string | Workbook name.
            var sheetName = sheetName_example;  // string | The worksheet name.
            var folder = folder_example;  // string | The document folder. (optional) 
            var storage = storage_example;  // string | storage name. (optional) 

            try
            {
                // Get worksheet comments.
                CommentsResponse result = apiInstance.CellsWorksheetsGetWorksheetComments(name, sheetName, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsWorksheetsApi.CellsWorksheetsGetWorksheetComments: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Workbook name. | 
 **sheetName** | **string**| The worksheet name. | 
 **folder** | **string**| The document folder. | [optional] 
 **storage** | **string**| storage name. | [optional] 

### Return type

[**CommentsResponse**](CommentsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellsworksheetsgetworksheetmergedcell"></a>
# **CellsWorksheetsGetWorksheetMergedCell**
> MergedCellResponse CellsWorksheetsGetWorksheetMergedCell (string name, string sheetName, int? mergedCellIndex, string folder = null, string storage = null)

Get worksheet merged cell by its index.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsWorksheetsGetWorksheetMergedCellExample
    {
        public void main()
        {
            var apiInstance = new CellsWorksheetsApi();
            var name = name_example;  // string | Document name.
            var sheetName = sheetName_example;  // string | Worksheet name.
            var mergedCellIndex = 56;  // int? | Merged cell index.
            var folder = folder_example;  // string | Document folder. (optional) 
            var storage = storage_example;  // string | storage name. (optional) 

            try
            {
                // Get worksheet merged cell by its index.
                MergedCellResponse result = apiInstance.CellsWorksheetsGetWorksheetMergedCell(name, sheetName, mergedCellIndex, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsWorksheetsApi.CellsWorksheetsGetWorksheetMergedCell: " + e.Message );
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
 **mergedCellIndex** | **int?**| Merged cell index. | 
 **folder** | **string**| Document folder. | [optional] 
 **storage** | **string**| storage name. | [optional] 

### Return type

[**MergedCellResponse**](MergedCellResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellsworksheetsgetworksheetmergedcells"></a>
# **CellsWorksheetsGetWorksheetMergedCells**
> MergedCellsResponse CellsWorksheetsGetWorksheetMergedCells (string name, string sheetName, string folder = null, string storage = null)

Get worksheet merged cells.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsWorksheetsGetWorksheetMergedCellsExample
    {
        public void main()
        {
            var apiInstance = new CellsWorksheetsApi();
            var name = name_example;  // string | Document name.
            var sheetName = sheetName_example;  // string | The workseet name.
            var folder = folder_example;  // string | Document folder. (optional) 
            var storage = storage_example;  // string | storage name. (optional) 

            try
            {
                // Get worksheet merged cells.
                MergedCellsResponse result = apiInstance.CellsWorksheetsGetWorksheetMergedCells(name, sheetName, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsWorksheetsApi.CellsWorksheetsGetWorksheetMergedCells: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Document name. | 
 **sheetName** | **string**| The workseet name. | 
 **folder** | **string**| Document folder. | [optional] 
 **storage** | **string**| storage name. | [optional] 

### Return type

[**MergedCellsResponse**](MergedCellsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellsworksheetsgetworksheettextitems"></a>
# **CellsWorksheetsGetWorksheetTextItems**
> TextItemsResponse CellsWorksheetsGetWorksheetTextItems (string name, string sheetName, string folder = null, string storage = null)

Get worksheet text items.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsWorksheetsGetWorksheetTextItemsExample
    {
        public void main()
        {
            var apiInstance = new CellsWorksheetsApi();
            var name = name_example;  // string | Workbook name.
            var sheetName = sheetName_example;  // string | The worksheet name.
            var folder = folder_example;  // string | The workbook's folder. (optional) 
            var storage = storage_example;  // string | storage name. (optional) 

            try
            {
                // Get worksheet text items.
                TextItemsResponse result = apiInstance.CellsWorksheetsGetWorksheetTextItems(name, sheetName, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsWorksheetsApi.CellsWorksheetsGetWorksheetTextItems: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Workbook name. | 
 **sheetName** | **string**| The worksheet name. | 
 **folder** | **string**| The workbook&#39;s folder. | [optional] 
 **storage** | **string**| storage name. | [optional] 

### Return type

[**TextItemsResponse**](TextItemsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellsworksheetsgetworksheets"></a>
# **CellsWorksheetsGetWorksheets**
> WorksheetsResponse CellsWorksheetsGetWorksheets (string name, string folder = null, string storage = null)

Read worksheets info.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsWorksheetsGetWorksheetsExample
    {
        public void main()
        {
            var apiInstance = new CellsWorksheetsApi();
            var name = name_example;  // string | Document name.
            var folder = folder_example;  // string | Document folder. (optional) 
            var storage = storage_example;  // string | storage name. (optional) 

            try
            {
                // Read worksheets info.
                WorksheetsResponse result = apiInstance.CellsWorksheetsGetWorksheets(name, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsWorksheetsApi.CellsWorksheetsGetWorksheets: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Document name. | 
 **folder** | **string**| Document folder. | [optional] 
 **storage** | **string**| storage name. | [optional] 

### Return type

[**WorksheetsResponse**](WorksheetsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellsworksheetspostautofitworksheetcolumns"></a>
# **CellsWorksheetsPostAutofitWorksheetColumns**
> SaaSposeResponse CellsWorksheetsPostAutofitWorksheetColumns (string name, string sheetName, int? firstColumn, int? lastColumn, AutoFitterOptions autoFitterOptions = null, int? firstRow = null, int? lastRow = null, string folder = null, string storage = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsWorksheetsPostAutofitWorksheetColumnsExample
    {
        public void main()
        {
            var apiInstance = new CellsWorksheetsApi();
            var name = name_example;  // string | 
            var sheetName = sheetName_example;  // string | 
            var firstColumn = 56;  // int? | 
            var lastColumn = 56;  // int? | 
            var autoFitterOptions = new AutoFitterOptions(); // AutoFitterOptions |  (optional) 
            var firstRow = 56;  // int? |  (optional) 
            var lastRow = 56;  // int? |  (optional) 
            var folder = folder_example;  // string |  (optional) 
            var storage = storage_example;  // string | storage name. (optional) 

            try
            {
                SaaSposeResponse result = apiInstance.CellsWorksheetsPostAutofitWorksheetColumns(name, sheetName, firstColumn, lastColumn, autoFitterOptions, firstRow, lastRow, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsWorksheetsApi.CellsWorksheetsPostAutofitWorksheetColumns: " + e.Message );
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
 **firstColumn** | **int?**|  | 
 **lastColumn** | **int?**|  | 
 **autoFitterOptions** | [**AutoFitterOptions**](AutoFitterOptions.md)|  | [optional] 
 **firstRow** | **int?**|  | [optional] 
 **lastRow** | **int?**|  | [optional] 
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

<a name="cellsworksheetspostautofitworksheetrow"></a>
# **CellsWorksheetsPostAutofitWorksheetRow**
> SaaSposeResponse CellsWorksheetsPostAutofitWorksheetRow (string name, string sheetName, int? rowIndex, int? firstColumn, int? lastColumn, AutoFitterOptions autoFitterOptions = null, string folder = null, string storage = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsWorksheetsPostAutofitWorksheetRowExample
    {
        public void main()
        {
            var apiInstance = new CellsWorksheetsApi();
            var name = name_example;  // string | 
            var sheetName = sheetName_example;  // string | 
            var rowIndex = 56;  // int? | 
            var firstColumn = 56;  // int? | 
            var lastColumn = 56;  // int? | 
            var autoFitterOptions = new AutoFitterOptions(); // AutoFitterOptions |  (optional) 
            var folder = folder_example;  // string |  (optional) 
            var storage = storage_example;  // string | storage name. (optional) 

            try
            {
                SaaSposeResponse result = apiInstance.CellsWorksheetsPostAutofitWorksheetRow(name, sheetName, rowIndex, firstColumn, lastColumn, autoFitterOptions, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsWorksheetsApi.CellsWorksheetsPostAutofitWorksheetRow: " + e.Message );
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
 **rowIndex** | **int?**|  | 
 **firstColumn** | **int?**|  | 
 **lastColumn** | **int?**|  | 
 **autoFitterOptions** | [**AutoFitterOptions**](AutoFitterOptions.md)|  | [optional] 
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

<a name="cellsworksheetspostautofitworksheetrows"></a>
# **CellsWorksheetsPostAutofitWorksheetRows**
> SaaSposeResponse CellsWorksheetsPostAutofitWorksheetRows (string name, string sheetName, AutoFitterOptions autoFitterOptions = null, int? startRow = null, int? endRow = null, bool? onlyAuto = null, string folder = null, string storage = null)

Autofit worksheet rows.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsWorksheetsPostAutofitWorksheetRowsExample
    {
        public void main()
        {
            var apiInstance = new CellsWorksheetsApi();
            var name = name_example;  // string | Document name.
            var sheetName = sheetName_example;  // string | The worksheet name.
            var autoFitterOptions = new AutoFitterOptions(); // AutoFitterOptions | Auto Fitter Options. (optional) 
            var startRow = 56;  // int? | Start row. (optional) 
            var endRow = 56;  // int? | End row. (optional) 
            var onlyAuto = true;  // bool? | Only auto. (optional)  (default to false)
            var folder = folder_example;  // string | Document's folder. (optional) 
            var storage = storage_example;  // string | storage name. (optional) 

            try
            {
                // Autofit worksheet rows.
                SaaSposeResponse result = apiInstance.CellsWorksheetsPostAutofitWorksheetRows(name, sheetName, autoFitterOptions, startRow, endRow, onlyAuto, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsWorksheetsApi.CellsWorksheetsPostAutofitWorksheetRows: " + e.Message );
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

<a name="cellsworksheetspostcopyworksheet"></a>
# **CellsWorksheetsPostCopyWorksheet**
> SaaSposeResponse CellsWorksheetsPostCopyWorksheet (string name, string sheetName, string sourceSheet, CopyOptions options = null, string sourceWorkbook = null, string sourceFolder = null, string folder = null, string storage = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsWorksheetsPostCopyWorksheetExample
    {
        public void main()
        {
            var apiInstance = new CellsWorksheetsApi();
            var name = name_example;  // string | 
            var sheetName = sheetName_example;  // string | 
            var sourceSheet = sourceSheet_example;  // string | 
            var options = new CopyOptions(); // CopyOptions |  (optional) 
            var sourceWorkbook = sourceWorkbook_example;  // string |  (optional) 
            var sourceFolder = sourceFolder_example;  // string |  (optional) 
            var folder = folder_example;  // string |  (optional) 
            var storage = storage_example;  // string | storage name. (optional) 

            try
            {
                SaaSposeResponse result = apiInstance.CellsWorksheetsPostCopyWorksheet(name, sheetName, sourceSheet, options, sourceWorkbook, sourceFolder, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsWorksheetsApi.CellsWorksheetsPostCopyWorksheet: " + e.Message );
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
 **sourceSheet** | **string**|  | 
 **options** | [**CopyOptions**](CopyOptions.md)|  | [optional] 
 **sourceWorkbook** | **string**|  | [optional] 
 **sourceFolder** | **string**|  | [optional] 
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

<a name="cellsworksheetspostmoveworksheet"></a>
# **CellsWorksheetsPostMoveWorksheet**
> WorksheetsResponse CellsWorksheetsPostMoveWorksheet (string name, string sheetName, WorksheetMovingRequest moving = null, string folder = null, string storage = null)

Move worksheet.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsWorksheetsPostMoveWorksheetExample
    {
        public void main()
        {
            var apiInstance = new CellsWorksheetsApi();
            var name = name_example;  // string | Document name.
            var sheetName = sheetName_example;  // string | The worksheet name.
            var moving = new WorksheetMovingRequest(); // WorksheetMovingRequest | with moving parameters. (optional) 
            var folder = folder_example;  // string | The document folder. (optional) 
            var storage = storage_example;  // string | storage name. (optional) 

            try
            {
                // Move worksheet.
                WorksheetsResponse result = apiInstance.CellsWorksheetsPostMoveWorksheet(name, sheetName, moving, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsWorksheetsApi.CellsWorksheetsPostMoveWorksheet: " + e.Message );
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
 **moving** | [**WorksheetMovingRequest**](WorksheetMovingRequest.md)| with moving parameters. | [optional] 
 **folder** | **string**| The document folder. | [optional] 
 **storage** | **string**| storage name. | [optional] 

### Return type

[**WorksheetsResponse**](WorksheetsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellsworksheetspostrenameworksheet"></a>
# **CellsWorksheetsPostRenameWorksheet**
> SaaSposeResponse CellsWorksheetsPostRenameWorksheet (string name, string sheetName, string newname, string folder = null, string storage = null)

Rename worksheet

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsWorksheetsPostRenameWorksheetExample
    {
        public void main()
        {
            var apiInstance = new CellsWorksheetsApi();
            var name = name_example;  // string | 
            var sheetName = sheetName_example;  // string | 
            var newname = newname_example;  // string | 
            var folder = folder_example;  // string |  (optional) 
            var storage = storage_example;  // string | storage name. (optional) 

            try
            {
                // Rename worksheet
                SaaSposeResponse result = apiInstance.CellsWorksheetsPostRenameWorksheet(name, sheetName, newname, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsWorksheetsApi.CellsWorksheetsPostRenameWorksheet: " + e.Message );
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
 **newname** | **string**|  | 
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

<a name="cellsworksheetspostupdateworksheetproperty"></a>
# **CellsWorksheetsPostUpdateWorksheetProperty**
> WorksheetResponse CellsWorksheetsPostUpdateWorksheetProperty (string name, string sheetName, Worksheet sheet = null, string folder = null, string storage = null)

Update worksheet property

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsWorksheetsPostUpdateWorksheetPropertyExample
    {
        public void main()
        {
            var apiInstance = new CellsWorksheetsApi();
            var name = name_example;  // string | 
            var sheetName = sheetName_example;  // string | 
            var sheet = new Worksheet(); // Worksheet |  (optional) 
            var folder = folder_example;  // string |  (optional) 
            var storage = storage_example;  // string | storage name. (optional) 

            try
            {
                // Update worksheet property
                WorksheetResponse result = apiInstance.CellsWorksheetsPostUpdateWorksheetProperty(name, sheetName, sheet, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsWorksheetsApi.CellsWorksheetsPostUpdateWorksheetProperty: " + e.Message );
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
 **sheet** | [**Worksheet**](Worksheet.md)|  | [optional] 
 **folder** | **string**|  | [optional] 
 **storage** | **string**| storage name. | [optional] 

### Return type

[**WorksheetResponse**](WorksheetResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellsworksheetspostupdateworksheetzoom"></a>
# **CellsWorksheetsPostUpdateWorksheetZoom**
> SaaSposeResponse CellsWorksheetsPostUpdateWorksheetZoom (string name, string sheetName, int? value, string folder = null, string storage = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsWorksheetsPostUpdateWorksheetZoomExample
    {
        public void main()
        {
            var apiInstance = new CellsWorksheetsApi();
            var name = name_example;  // string | 
            var sheetName = sheetName_example;  // string | 
            var value = 56;  // int? | 
            var folder = folder_example;  // string |  (optional) 
            var storage = storage_example;  // string | storage name. (optional) 

            try
            {
                SaaSposeResponse result = apiInstance.CellsWorksheetsPostUpdateWorksheetZoom(name, sheetName, value, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsWorksheetsApi.CellsWorksheetsPostUpdateWorksheetZoom: " + e.Message );
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
 **value** | **int?**|  | 
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

<a name="cellsworksheetspostworksheetcomment"></a>
# **CellsWorksheetsPostWorksheetComment**
> SaaSposeResponse CellsWorksheetsPostWorksheetComment (string name, string sheetName, string cellName, Comment comment = null, string folder = null, string storage = null)

Update worksheet's cell comment.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsWorksheetsPostWorksheetCommentExample
    {
        public void main()
        {
            var apiInstance = new CellsWorksheetsApi();
            var name = name_example;  // string | The document name.
            var sheetName = sheetName_example;  // string | The worksheet name.
            var cellName = cellName_example;  // string | The cell name
            var comment = new Comment(); // Comment | Comment object (optional) 
            var folder = folder_example;  // string | The document folder. (optional) 
            var storage = storage_example;  // string | storage name. (optional) 

            try
            {
                // Update worksheet's cell comment.
                SaaSposeResponse result = apiInstance.CellsWorksheetsPostWorksheetComment(name, sheetName, cellName, comment, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsWorksheetsApi.CellsWorksheetsPostWorksheetComment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **sheetName** | **string**| The worksheet name. | 
 **cellName** | **string**| The cell name | 
 **comment** | [**Comment**](Comment.md)| Comment object | [optional] 
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

<a name="cellsworksheetspostworksheetrangesort"></a>
# **CellsWorksheetsPostWorksheetRangeSort**
> SaaSposeResponse CellsWorksheetsPostWorksheetRangeSort (string name, string sheetName, string cellArea, DataSorter dataSorter = null, string folder = null, string storage = null)

Sort worksheet range.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsWorksheetsPostWorksheetRangeSortExample
    {
        public void main()
        {
            var apiInstance = new CellsWorksheetsApi();
            var name = name_example;  // string | The workbook name.
            var sheetName = sheetName_example;  // string | The worksheet name.
            var cellArea = cellArea_example;  // string | The range to sort.
            var dataSorter = new DataSorter(); // DataSorter | with sorting settings. (optional) 
            var folder = folder_example;  // string | The workbook folder. (optional) 
            var storage = storage_example;  // string | storage name. (optional) 

            try
            {
                // Sort worksheet range.
                SaaSposeResponse result = apiInstance.CellsWorksheetsPostWorksheetRangeSort(name, sheetName, cellArea, dataSorter, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsWorksheetsApi.CellsWorksheetsPostWorksheetRangeSort: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The workbook name. | 
 **sheetName** | **string**| The worksheet name. | 
 **cellArea** | **string**| The range to sort. | 
 **dataSorter** | [**DataSorter**](DataSorter.md)| with sorting settings. | [optional] 
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

<a name="cellsworksheetspostworksheettextsearch"></a>
# **CellsWorksheetsPostWorksheetTextSearch**
> TextItemsResponse CellsWorksheetsPostWorksheetTextSearch (string name, string sheetName, string text, string folder = null, string storage = null)

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
    public class CellsWorksheetsPostWorksheetTextSearchExample
    {
        public void main()
        {
            var apiInstance = new CellsWorksheetsApi();
            var name = name_example;  // string | Document name.
            var sheetName = sheetName_example;  // string | The worksheet name.
            var text = text_example;  // string | Text to search.
            var folder = folder_example;  // string | Document's folder. (optional) 
            var storage = storage_example;  // string | storage name. (optional) 

            try
            {
                // Search text.
                TextItemsResponse result = apiInstance.CellsWorksheetsPostWorksheetTextSearch(name, sheetName, text, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsWorksheetsApi.CellsWorksheetsPostWorksheetTextSearch: " + e.Message );
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
 **text** | **string**| Text to search. | 
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

<a name="cellsworksheetspostworsheettextreplace"></a>
# **CellsWorksheetsPostWorsheetTextReplace**
> WorksheetReplaceResponse CellsWorksheetsPostWorsheetTextReplace (string name, string sheetName, string oldValue, string newValue, string folder = null, string storage = null)

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
    public class CellsWorksheetsPostWorsheetTextReplaceExample
    {
        public void main()
        {
            var apiInstance = new CellsWorksheetsApi();
            var name = name_example;  // string | Document name.
            var sheetName = sheetName_example;  // string | Worksheet name.
            var oldValue = oldValue_example;  // string | The old text to replace.
            var newValue = newValue_example;  // string | The new text to replace by.
            var folder = folder_example;  // string | Document's folder. (optional) 
            var storage = storage_example;  // string | storage name. (optional) 

            try
            {
                // Replace text.
                WorksheetReplaceResponse result = apiInstance.CellsWorksheetsPostWorsheetTextReplace(name, sheetName, oldValue, newValue, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsWorksheetsApi.CellsWorksheetsPostWorsheetTextReplace: " + e.Message );
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
 **oldValue** | **string**| The old text to replace. | 
 **newValue** | **string**| The new text to replace by. | 
 **folder** | **string**| Document&#39;s folder. | [optional] 
 **storage** | **string**| storage name. | [optional] 

### Return type

[**WorksheetReplaceResponse**](WorksheetReplaceResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellsworksheetsputaddnewworksheet"></a>
# **CellsWorksheetsPutAddNewWorksheet**
> WorksheetsResponse CellsWorksheetsPutAddNewWorksheet (string name, string sheetName, int? position = null, string sheettype = null, string folder = null, string storage = null)

Add new worksheet.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsWorksheetsPutAddNewWorksheetExample
    {
        public void main()
        {
            var apiInstance = new CellsWorksheetsApi();
            var name = name_example;  // string | Document name.
            var sheetName = sheetName_example;  // string | The new sheet name.
            var position = 56;  // int? | The new sheet position. (optional) 
            var sheettype = sheettype_example;  // string | The new sheet type. (optional) 
            var folder = folder_example;  // string | Document folder. (optional) 
            var storage = storage_example;  // string | storage name. (optional) 

            try
            {
                // Add new worksheet.
                WorksheetsResponse result = apiInstance.CellsWorksheetsPutAddNewWorksheet(name, sheetName, position, sheettype, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsWorksheetsApi.CellsWorksheetsPutAddNewWorksheet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Document name. | 
 **sheetName** | **string**| The new sheet name. | 
 **position** | **int?**| The new sheet position. | [optional] 
 **sheettype** | **string**| The new sheet type. | [optional] 
 **folder** | **string**| Document folder. | [optional] 
 **storage** | **string**| storage name. | [optional] 

### Return type

[**WorksheetsResponse**](WorksheetsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellsworksheetsputchangevisibilityworksheet"></a>
# **CellsWorksheetsPutChangeVisibilityWorksheet**
> WorksheetResponse CellsWorksheetsPutChangeVisibilityWorksheet (string name, string sheetName, bool? isVisible, string folder = null, string storage = null)

Change worksheet visibility.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsWorksheetsPutChangeVisibilityWorksheetExample
    {
        public void main()
        {
            var apiInstance = new CellsWorksheetsApi();
            var name = name_example;  // string | Document name.
            var sheetName = sheetName_example;  // string | Worksheet name.
            var isVisible = true;  // bool? | New worksheet visibility value.
            var folder = folder_example;  // string | The document folder. (optional) 
            var storage = storage_example;  // string | storage name. (optional) 

            try
            {
                // Change worksheet visibility.
                WorksheetResponse result = apiInstance.CellsWorksheetsPutChangeVisibilityWorksheet(name, sheetName, isVisible, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsWorksheetsApi.CellsWorksheetsPutChangeVisibilityWorksheet: " + e.Message );
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
 **isVisible** | **bool?**| New worksheet visibility value. | 
 **folder** | **string**| The document folder. | [optional] 
 **storage** | **string**| storage name. | [optional] 

### Return type

[**WorksheetResponse**](WorksheetResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellsworksheetsputprotectworksheet"></a>
# **CellsWorksheetsPutProtectWorksheet**
> WorksheetResponse CellsWorksheetsPutProtectWorksheet (string name, string sheetName, ProtectSheetParameter protectParameter = null, string folder = null, string storage = null)

Protect worksheet.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsWorksheetsPutProtectWorksheetExample
    {
        public void main()
        {
            var apiInstance = new CellsWorksheetsApi();
            var name = name_example;  // string | Document name.
            var sheetName = sheetName_example;  // string | The worksheet name.
            var protectParameter = new ProtectSheetParameter(); // ProtectSheetParameter | with protection settings. (optional) 
            var folder = folder_example;  // string | Document folder. (optional) 
            var storage = storage_example;  // string | storage name. (optional) 

            try
            {
                // Protect worksheet.
                WorksheetResponse result = apiInstance.CellsWorksheetsPutProtectWorksheet(name, sheetName, protectParameter, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsWorksheetsApi.CellsWorksheetsPutProtectWorksheet: " + e.Message );
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
 **protectParameter** | [**ProtectSheetParameter**](ProtectSheetParameter.md)| with protection settings. | [optional] 
 **folder** | **string**| Document folder. | [optional] 
 **storage** | **string**| storage name. | [optional] 

### Return type

[**WorksheetResponse**](WorksheetResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellsworksheetsputworksheetbackground"></a>
# **CellsWorksheetsPutWorksheetBackground**
> SaaSposeResponse CellsWorksheetsPutWorksheetBackground (string name, string sheetName, byte[] png, string folder = null, string storage = null)

Set worksheet background image.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsWorksheetsPutWorksheetBackgroundExample
    {
        public void main()
        {
            var apiInstance = new CellsWorksheetsApi();
            var name = name_example;  // string | 
            var sheetName = sheetName_example;  // string | 
            var png = BINARY_DATA_HERE;  // byte[] | 
            var folder = folder_example;  // string |  (optional) 
            var storage = storage_example;  // string | storage name. (optional) 

            try
            {
                // Set worksheet background image.
                SaaSposeResponse result = apiInstance.CellsWorksheetsPutWorksheetBackground(name, sheetName, png, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsWorksheetsApi.CellsWorksheetsPutWorksheetBackground: " + e.Message );
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
 **png** | **byte[]**|  | 
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

<a name="cellsworksheetsputworksheetcomment"></a>
# **CellsWorksheetsPutWorksheetComment**
> CommentResponse CellsWorksheetsPutWorksheetComment (string name, string sheetName, string cellName, Comment comment = null, string folder = null, string storage = null)

Add worksheet's cell comment.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsWorksheetsPutWorksheetCommentExample
    {
        public void main()
        {
            var apiInstance = new CellsWorksheetsApi();
            var name = name_example;  // string | The document name.
            var sheetName = sheetName_example;  // string | The worksheet name.
            var cellName = cellName_example;  // string | The cell name
            var comment = new Comment(); // Comment | Comment object (optional) 
            var folder = folder_example;  // string | The document folder. (optional) 
            var storage = storage_example;  // string | storage name. (optional) 

            try
            {
                // Add worksheet's cell comment.
                CommentResponse result = apiInstance.CellsWorksheetsPutWorksheetComment(name, sheetName, cellName, comment, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsWorksheetsApi.CellsWorksheetsPutWorksheetComment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **sheetName** | **string**| The worksheet name. | 
 **cellName** | **string**| The cell name | 
 **comment** | [**Comment**](Comment.md)| Comment object | [optional] 
 **folder** | **string**| The document folder. | [optional] 
 **storage** | **string**| storage name. | [optional] 

### Return type

[**CommentResponse**](CommentResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellsworksheetsputworksheetfreezepanes"></a>
# **CellsWorksheetsPutWorksheetFreezePanes**
> SaaSposeResponse CellsWorksheetsPutWorksheetFreezePanes (string name, string sheetName, int? row, int? column, int? freezedRows, int? freezedColumns, string folder = null, string storage = null)

Set freeze panes

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsWorksheetsPutWorksheetFreezePanesExample
    {
        public void main()
        {
            var apiInstance = new CellsWorksheetsApi();
            var name = name_example;  // string | 
            var sheetName = sheetName_example;  // string | 
            var row = 56;  // int? | 
            var column = 56;  // int? | 
            var freezedRows = 56;  // int? | 
            var freezedColumns = 56;  // int? | 
            var folder = folder_example;  // string |  (optional) 
            var storage = storage_example;  // string | storage name. (optional) 

            try
            {
                // Set freeze panes
                SaaSposeResponse result = apiInstance.CellsWorksheetsPutWorksheetFreezePanes(name, sheetName, row, column, freezedRows, freezedColumns, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsWorksheetsApi.CellsWorksheetsPutWorksheetFreezePanes: " + e.Message );
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
 **row** | **int?**|  | 
 **column** | **int?**|  | 
 **freezedRows** | **int?**|  | 
 **freezedColumns** | **int?**|  | 
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

