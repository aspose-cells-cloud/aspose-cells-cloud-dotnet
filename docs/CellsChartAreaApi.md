# Aspose.Cells.Cloud.SDK.Api.CellsChartAreaApi

All URIs are relative to *https://api.aspose.cloud/v1.1/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CellsChartAreaGetChartArea**](CellsChartAreaApi.md#cellschartareagetchartarea) | **GET** /cells/{name}/worksheets/{sheetName}/charts/{chartIndex}/chartArea | Get chart area info.
[**CellsChartAreaGetChartAreaBorder**](CellsChartAreaApi.md#cellschartareagetchartareaborder) | **GET** /cells/{name}/worksheets/{sheetName}/charts/{chartIndex}/chartArea/border | Get chart area border info.
[**CellsChartAreaGetChartAreaFillFormat**](CellsChartAreaApi.md#cellschartareagetchartareafillformat) | **GET** /cells/{name}/worksheets/{sheetName}/charts/{chartIndex}/chartArea/fillFormat | Get chart area fill format info.


<a name="cellschartareagetchartarea"></a>
# **CellsChartAreaGetChartArea**
> ChartAreaResponse CellsChartAreaGetChartArea (string name, string sheetName, int? chartIndex, string folder = null)

Get chart area info.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsChartAreaGetChartAreaExample
    {
        public void main()
        {
            var apiInstance = new CellsChartAreaApi();
            var name = name_example;  // string | Workbook name.
            var sheetName = sheetName_example;  // string | Worksheet name.
            var chartIndex = 56;  // int? | The chart index.
            var folder = folder_example;  // string | Workbook folder. (optional) 

            try
            {
                // Get chart area info.
                ChartAreaResponse result = apiInstance.CellsChartAreaGetChartArea(name, sheetName, chartIndex, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsChartAreaApi.CellsChartAreaGetChartArea: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Workbook name. | 
 **sheetName** | **string**| Worksheet name. | 
 **chartIndex** | **int?**| The chart index. | 
 **folder** | **string**| Workbook folder. | [optional] 

### Return type

[**ChartAreaResponse**](ChartAreaResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellschartareagetchartareaborder"></a>
# **CellsChartAreaGetChartAreaBorder**
> LineResponse CellsChartAreaGetChartAreaBorder (string name, string sheetName, int? chartIndex, string folder = null)

Get chart area border info.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsChartAreaGetChartAreaBorderExample
    {
        public void main()
        {
            var apiInstance = new CellsChartAreaApi();
            var name = name_example;  // string | Workbook name.
            var sheetName = sheetName_example;  // string | Worksheet name.
            var chartIndex = 56;  // int? | The chart index.
            var folder = folder_example;  // string | Workbook folder. (optional) 

            try
            {
                // Get chart area border info.
                LineResponse result = apiInstance.CellsChartAreaGetChartAreaBorder(name, sheetName, chartIndex, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsChartAreaApi.CellsChartAreaGetChartAreaBorder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Workbook name. | 
 **sheetName** | **string**| Worksheet name. | 
 **chartIndex** | **int?**| The chart index. | 
 **folder** | **string**| Workbook folder. | [optional] 

### Return type

[**LineResponse**](LineResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellschartareagetchartareafillformat"></a>
# **CellsChartAreaGetChartAreaFillFormat**
> FillFormatResponse CellsChartAreaGetChartAreaFillFormat (string name, string sheetName, int? chartIndex, string folder = null)

Get chart area fill format info.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsChartAreaGetChartAreaFillFormatExample
    {
        public void main()
        {
            var apiInstance = new CellsChartAreaApi();
            var name = name_example;  // string | Workbook name.
            var sheetName = sheetName_example;  // string | Worksheet name.
            var chartIndex = 56;  // int? | The chart index.
            var folder = folder_example;  // string | Workbook folder. (optional) 

            try
            {
                // Get chart area fill format info.
                FillFormatResponse result = apiInstance.CellsChartAreaGetChartAreaFillFormat(name, sheetName, chartIndex, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsChartAreaApi.CellsChartAreaGetChartAreaFillFormat: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Workbook name. | 
 **sheetName** | **string**| Worksheet name. | 
 **chartIndex** | **int?**| The chart index. | 
 **folder** | **string**| Workbook folder. | [optional] 

### Return type

[**FillFormatResponse**](FillFormatResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

