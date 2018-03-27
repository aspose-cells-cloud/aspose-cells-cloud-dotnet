# Aspose.Cells.Cloud.SDK.Api.CellsRangesApi

All URIs are relative to *https://api.aspose.cloud/v1.1/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CellsRangesGetWorksheetCellsRangeValue**](CellsRangesApi.md#cellsrangesgetworksheetcellsrangevalue) | **GET** /cells/{name}/worksheets/{sheetName}/ranges/value | Get cells list in a range by range name or row column indexes  
[**CellsRangesPostWorksheetCellsRangeColumnWidth**](CellsRangesApi.md#cellsrangespostworksheetcellsrangecolumnwidth) | **POST** /cells/{name}/worksheets/{sheetName}/ranges/columnWidth | Set column width of range
[**CellsRangesPostWorksheetCellsRangeMerge**](CellsRangesApi.md#cellsrangespostworksheetcellsrangemerge) | **POST** /cells/{name}/worksheets/{sheetName}/ranges/merge | Combines a range of cells into a single cell.              
[**CellsRangesPostWorksheetCellsRangeMoveTo**](CellsRangesApi.md#cellsrangespostworksheetcellsrangemoveto) | **POST** /cells/{name}/worksheets/{sheetName}/ranges/moveto | Move the current range to the dest range.             
[**CellsRangesPostWorksheetCellsRangeOutlineBorder**](CellsRangesApi.md#cellsrangespostworksheetcellsrangeoutlineborder) | **POST** /cells/{name}/worksheets/{sheetName}/ranges/outlineBorder | Sets outline border around a range of cells.
[**CellsRangesPostWorksheetCellsRangeRowHeight**](CellsRangesApi.md#cellsrangespostworksheetcellsrangerowheight) | **POST** /cells/{name}/worksheets/{sheetName}/ranges/rowHeight | set row height of range
[**CellsRangesPostWorksheetCellsRangeStyle**](CellsRangesApi.md#cellsrangespostworksheetcellsrangestyle) | **POST** /cells/{name}/worksheets/{sheetName}/ranges/style | Sets the style of the range.             
[**CellsRangesPostWorksheetCellsRangeUnmerge**](CellsRangesApi.md#cellsrangespostworksheetcellsrangeunmerge) | **POST** /cells/{name}/worksheets/{sheetName}/ranges/unmerge | Unmerges merged cells of this range.             
[**CellsRangesPostWorksheetCellsRangeValue**](CellsRangesApi.md#cellsrangespostworksheetcellsrangevalue) | **POST** /cells/{name}/worksheets/{sheetName}/ranges/value | Puts a value into the range, if appropriate the value will be converted to other data type and cell&#39;s number format will be reset.             
[**CellsRangesPostWorksheetCellsRanges**](CellsRangesApi.md#cellsrangespostworksheetcellsranges) | **POST** /cells/{name}/worksheets/{sheetName}/ranges | copy range in the worksheet


<a name="cellsrangesgetworksheetcellsrangevalue"></a>
# **CellsRangesGetWorksheetCellsRangeValue**
> RangeValueResponse CellsRangesGetWorksheetCellsRangeValue (string name, string sheetName, string namerange = null, int? firstRow = null, int? firstColumn = null, int? rowCount = null, int? columnCount = null, string folder = null)

Get cells list in a range by range name or row column indexes  

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsRangesGetWorksheetCellsRangeValueExample
    {
        public void main()
        {
            var apiInstance = new CellsRangesApi();
            var name = name_example;  // string | workbook name
            var sheetName = sheetName_example;  // string | worksheet name
            var namerange = namerange_example;  // string | range name, for example: 'A1:B2' or 'range_name1' (optional) 
            var firstRow = 56;  // int? | the first row of the range (optional) 
            var firstColumn = 56;  // int? | the first column of the range (optional) 
            var rowCount = 56;  // int? | the count of rows in the range (optional) 
            var columnCount = 56;  // int? | the count of columns in the range (optional) 
            var folder = folder_example;  // string | Workbook folder. (optional) 

            try
            {
                // Get cells list in a range by range name or row column indexes  
                RangeValueResponse result = apiInstance.CellsRangesGetWorksheetCellsRangeValue(name, sheetName, namerange, firstRow, firstColumn, rowCount, columnCount, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsRangesApi.CellsRangesGetWorksheetCellsRangeValue: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| workbook name | 
 **sheetName** | **string**| worksheet name | 
 **namerange** | **string**| range name, for example: &#39;A1:B2&#39; or &#39;range_name1&#39; | [optional] 
 **firstRow** | **int?**| the first row of the range | [optional] 
 **firstColumn** | **int?**| the first column of the range | [optional] 
 **rowCount** | **int?**| the count of rows in the range | [optional] 
 **columnCount** | **int?**| the count of columns in the range | [optional] 
 **folder** | **string**| Workbook folder. | [optional] 

### Return type

[**RangeValueResponse**](RangeValueResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellsrangespostworksheetcellsrangecolumnwidth"></a>
# **CellsRangesPostWorksheetCellsRangeColumnWidth**
> SaaSposeResponse CellsRangesPostWorksheetCellsRangeColumnWidth (string name, string sheetName, double? value, Range range = null, string folder = null)

Set column width of range

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsRangesPostWorksheetCellsRangeColumnWidthExample
    {
        public void main()
        {
            var apiInstance = new CellsRangesApi();
            var name = name_example;  // string | 
            var sheetName = sheetName_example;  // string | 
            var value = 1.2;  // double? | 
            var range = new Range(); // Range |  (optional) 
            var folder = folder_example;  // string |  (optional) 

            try
            {
                // Set column width of range
                SaaSposeResponse result = apiInstance.CellsRangesPostWorksheetCellsRangeColumnWidth(name, sheetName, value, range, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsRangesApi.CellsRangesPostWorksheetCellsRangeColumnWidth: " + e.Message );
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
 **value** | **double?**|  | 
 **range** | [**Range**](Range.md)|  | [optional] 
 **folder** | **string**|  | [optional] 

### Return type

[**SaaSposeResponse**](SaaSposeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellsrangespostworksheetcellsrangemerge"></a>
# **CellsRangesPostWorksheetCellsRangeMerge**
> SaaSposeResponse CellsRangesPostWorksheetCellsRangeMerge (string name, string sheetName, Range range = null, string folder = null)

Combines a range of cells into a single cell.              

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsRangesPostWorksheetCellsRangeMergeExample
    {
        public void main()
        {
            var apiInstance = new CellsRangesApi();
            var name = name_example;  // string | workbook name
            var sheetName = sheetName_example;  // string | worksheet name
            var range = new Range(); // Range | range in worksheet  (optional) 
            var folder = folder_example;  // string | Workbook folder. (optional) 

            try
            {
                // Combines a range of cells into a single cell.              
                SaaSposeResponse result = apiInstance.CellsRangesPostWorksheetCellsRangeMerge(name, sheetName, range, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsRangesApi.CellsRangesPostWorksheetCellsRangeMerge: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| workbook name | 
 **sheetName** | **string**| worksheet name | 
 **range** | [**Range**](Range.md)| range in worksheet  | [optional] 
 **folder** | **string**| Workbook folder. | [optional] 

### Return type

[**SaaSposeResponse**](SaaSposeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellsrangespostworksheetcellsrangemoveto"></a>
# **CellsRangesPostWorksheetCellsRangeMoveTo**
> SaaSposeResponse CellsRangesPostWorksheetCellsRangeMoveTo (string name, string sheetName, int? destRow, int? destColumn, Range range = null, string folder = null)

Move the current range to the dest range.             

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsRangesPostWorksheetCellsRangeMoveToExample
    {
        public void main()
        {
            var apiInstance = new CellsRangesApi();
            var name = name_example;  // string | workbook name
            var sheetName = sheetName_example;  // string | worksheet name
            var destRow = 56;  // int? | The start row of the dest range.
            var destColumn = 56;  // int? | The start column of the dest range.
            var range = new Range(); // Range | range in worksheet  (optional) 
            var folder = folder_example;  // string | Workbook folder. (optional) 

            try
            {
                // Move the current range to the dest range.             
                SaaSposeResponse result = apiInstance.CellsRangesPostWorksheetCellsRangeMoveTo(name, sheetName, destRow, destColumn, range, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsRangesApi.CellsRangesPostWorksheetCellsRangeMoveTo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| workbook name | 
 **sheetName** | **string**| worksheet name | 
 **destRow** | **int?**| The start row of the dest range. | 
 **destColumn** | **int?**| The start column of the dest range. | 
 **range** | [**Range**](Range.md)| range in worksheet  | [optional] 
 **folder** | **string**| Workbook folder. | [optional] 

### Return type

[**SaaSposeResponse**](SaaSposeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellsrangespostworksheetcellsrangeoutlineborder"></a>
# **CellsRangesPostWorksheetCellsRangeOutlineBorder**
> SaaSposeResponse CellsRangesPostWorksheetCellsRangeOutlineBorder (string name, string sheetName, RangeSetOutlineBorderRequest rangeOperate = null, string folder = null)

Sets outline border around a range of cells.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsRangesPostWorksheetCellsRangeOutlineBorderExample
    {
        public void main()
        {
            var apiInstance = new CellsRangesApi();
            var name = name_example;  // string | workbook name
            var sheetName = sheetName_example;  // string | worksheet name
            var rangeOperate = new RangeSetOutlineBorderRequest(); // RangeSetOutlineBorderRequest | Range Set OutlineBorder Request  (optional) 
            var folder = folder_example;  // string | Workbook folder. (optional) 

            try
            {
                // Sets outline border around a range of cells.
                SaaSposeResponse result = apiInstance.CellsRangesPostWorksheetCellsRangeOutlineBorder(name, sheetName, rangeOperate, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsRangesApi.CellsRangesPostWorksheetCellsRangeOutlineBorder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| workbook name | 
 **sheetName** | **string**| worksheet name | 
 **rangeOperate** | [**RangeSetOutlineBorderRequest**](RangeSetOutlineBorderRequest.md)| Range Set OutlineBorder Request  | [optional] 
 **folder** | **string**| Workbook folder. | [optional] 

### Return type

[**SaaSposeResponse**](SaaSposeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellsrangespostworksheetcellsrangerowheight"></a>
# **CellsRangesPostWorksheetCellsRangeRowHeight**
> SaaSposeResponse CellsRangesPostWorksheetCellsRangeRowHeight (string name, string sheetName, double? value, Range range = null, string folder = null)

set row height of range

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsRangesPostWorksheetCellsRangeRowHeightExample
    {
        public void main()
        {
            var apiInstance = new CellsRangesApi();
            var name = name_example;  // string | 
            var sheetName = sheetName_example;  // string | 
            var value = 1.2;  // double? | 
            var range = new Range(); // Range |  (optional) 
            var folder = folder_example;  // string |  (optional) 

            try
            {
                // set row height of range
                SaaSposeResponse result = apiInstance.CellsRangesPostWorksheetCellsRangeRowHeight(name, sheetName, value, range, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsRangesApi.CellsRangesPostWorksheetCellsRangeRowHeight: " + e.Message );
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
 **value** | **double?**|  | 
 **range** | [**Range**](Range.md)|  | [optional] 
 **folder** | **string**|  | [optional] 

### Return type

[**SaaSposeResponse**](SaaSposeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellsrangespostworksheetcellsrangestyle"></a>
# **CellsRangesPostWorksheetCellsRangeStyle**
> SaaSposeResponse CellsRangesPostWorksheetCellsRangeStyle (string name, string sheetName, RangeSetStyleRequest rangeOperate = null, string folder = null)

Sets the style of the range.             

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsRangesPostWorksheetCellsRangeStyleExample
    {
        public void main()
        {
            var apiInstance = new CellsRangesApi();
            var name = name_example;  // string | workbook name
            var sheetName = sheetName_example;  // string | worksheet name
            var rangeOperate = new RangeSetStyleRequest(); // RangeSetStyleRequest | Range Set Style Request  (optional) 
            var folder = folder_example;  // string | Workbook folder. (optional) 

            try
            {
                // Sets the style of the range.             
                SaaSposeResponse result = apiInstance.CellsRangesPostWorksheetCellsRangeStyle(name, sheetName, rangeOperate, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsRangesApi.CellsRangesPostWorksheetCellsRangeStyle: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| workbook name | 
 **sheetName** | **string**| worksheet name | 
 **rangeOperate** | [**RangeSetStyleRequest**](RangeSetStyleRequest.md)| Range Set Style Request  | [optional] 
 **folder** | **string**| Workbook folder. | [optional] 

### Return type

[**SaaSposeResponse**](SaaSposeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellsrangespostworksheetcellsrangeunmerge"></a>
# **CellsRangesPostWorksheetCellsRangeUnmerge**
> SaaSposeResponse CellsRangesPostWorksheetCellsRangeUnmerge (string name, string sheetName, Range range = null, string folder = null)

Unmerges merged cells of this range.             

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsRangesPostWorksheetCellsRangeUnmergeExample
    {
        public void main()
        {
            var apiInstance = new CellsRangesApi();
            var name = name_example;  // string | workbook name
            var sheetName = sheetName_example;  // string | worksheet name
            var range = new Range(); // Range | range in worksheet  (optional) 
            var folder = folder_example;  // string | Workbook folder. (optional) 

            try
            {
                // Unmerges merged cells of this range.             
                SaaSposeResponse result = apiInstance.CellsRangesPostWorksheetCellsRangeUnmerge(name, sheetName, range, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsRangesApi.CellsRangesPostWorksheetCellsRangeUnmerge: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| workbook name | 
 **sheetName** | **string**| worksheet name | 
 **range** | [**Range**](Range.md)| range in worksheet  | [optional] 
 **folder** | **string**| Workbook folder. | [optional] 

### Return type

[**SaaSposeResponse**](SaaSposeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellsrangespostworksheetcellsrangevalue"></a>
# **CellsRangesPostWorksheetCellsRangeValue**
> SaaSposeResponse CellsRangesPostWorksheetCellsRangeValue (string name, string sheetName, string value, Range range = null, bool? isConverted = null, bool? setStyle = null, string folder = null)

Puts a value into the range, if appropriate the value will be converted to other data type and cell's number format will be reset.             

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsRangesPostWorksheetCellsRangeValueExample
    {
        public void main()
        {
            var apiInstance = new CellsRangesApi();
            var name = name_example;  // string | workbook name
            var sheetName = sheetName_example;  // string | worksheet name
            var value = value_example;  // string | Input value
            var range = new Range(); // Range | range in worksheet  (optional) 
            var isConverted = true;  // bool? | True: converted to other data type if appropriate. (optional)  (default to false)
            var setStyle = true;  // bool? | True: set the number format to cell's style when converting to other data type (optional)  (default to false)
            var folder = folder_example;  // string | Workbook folder. (optional) 

            try
            {
                // Puts a value into the range, if appropriate the value will be converted to other data type and cell's number format will be reset.             
                SaaSposeResponse result = apiInstance.CellsRangesPostWorksheetCellsRangeValue(name, sheetName, value, range, isConverted, setStyle, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsRangesApi.CellsRangesPostWorksheetCellsRangeValue: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| workbook name | 
 **sheetName** | **string**| worksheet name | 
 **value** | **string**| Input value | 
 **range** | [**Range**](Range.md)| range in worksheet  | [optional] 
 **isConverted** | **bool?**| True: converted to other data type if appropriate. | [optional] [default to false]
 **setStyle** | **bool?**| True: set the number format to cell&#39;s style when converting to other data type | [optional] [default to false]
 **folder** | **string**| Workbook folder. | [optional] 

### Return type

[**SaaSposeResponse**](SaaSposeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellsrangespostworksheetcellsranges"></a>
# **CellsRangesPostWorksheetCellsRanges**
> SaaSposeResponse CellsRangesPostWorksheetCellsRanges (string name, string sheetName, RangeCopyRequest rangeOperate = null, string folder = null)

copy range in the worksheet

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsRangesPostWorksheetCellsRangesExample
    {
        public void main()
        {
            var apiInstance = new CellsRangesApi();
            var name = name_example;  // string | workbook name
            var sheetName = sheetName_example;  // string | worksheet name
            var rangeOperate = new RangeCopyRequest(); // RangeCopyRequest | copydata,copystyle,copyto,copyvalue (optional) 
            var folder = folder_example;  // string | Workbook folder. (optional) 

            try
            {
                // copy range in the worksheet
                SaaSposeResponse result = apiInstance.CellsRangesPostWorksheetCellsRanges(name, sheetName, rangeOperate, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsRangesApi.CellsRangesPostWorksheetCellsRanges: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| workbook name | 
 **sheetName** | **string**| worksheet name | 
 **rangeOperate** | [**RangeCopyRequest**](RangeCopyRequest.md)| copydata,copystyle,copyto,copyvalue | [optional] 
 **folder** | **string**| Workbook folder. | [optional] 

### Return type

[**SaaSposeResponse**](SaaSposeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

