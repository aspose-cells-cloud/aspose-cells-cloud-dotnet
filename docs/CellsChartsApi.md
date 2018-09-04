# Aspose.Cells.Cloud.SDK.Api.CellsChartsApi

All URIs are relative to *https://api.aspose.cloud/v1.1/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CellsChartsDeleteWorksheetChartLegend**](CellsChartsApi.md#cellschartsdeleteworksheetchartlegend) | **DELETE** /cells/{name}/worksheets/{sheetName}/charts/{chartIndex}/legend | Hide legend in chart
[**CellsChartsDeleteWorksheetChartTitle**](CellsChartsApi.md#cellschartsdeleteworksheetcharttitle) | **DELETE** /cells/{name}/worksheets/{sheetName}/charts/{chartIndex}/title | Hide title in chart
[**CellsChartsDeleteWorksheetClearCharts**](CellsChartsApi.md#cellschartsdeleteworksheetclearcharts) | **DELETE** /cells/{name}/worksheets/{sheetName}/charts | Clear the charts.
[**CellsChartsDeleteWorksheetDeleteChart**](CellsChartsApi.md#cellschartsdeleteworksheetdeletechart) | **DELETE** /cells/{name}/worksheets/{sheetName}/charts/{chartIndex} | Delete worksheet chart by index.
[**CellsChartsGetWorksheetChart**](CellsChartsApi.md#cellschartsgetworksheetchart) | **GET** /cells/{name}/worksheets/{sheetName}/charts/{chartNumber} | Get chart info.
[**CellsChartsGetWorksheetChartLegend**](CellsChartsApi.md#cellschartsgetworksheetchartlegend) | **GET** /cells/{name}/worksheets/{sheetName}/charts/{chartIndex}/legend | Get chart legend
[**CellsChartsGetWorksheetChartTitle**](CellsChartsApi.md#cellschartsgetworksheetcharttitle) | **GET** /cells/{name}/worksheets/{sheetName}/charts/{chartIndex}/title | Get chart title
[**CellsChartsGetWorksheetCharts**](CellsChartsApi.md#cellschartsgetworksheetcharts) | **GET** /cells/{name}/worksheets/{sheetName}/charts | Get worksheet charts info.
[**CellsChartsPostWorksheetChart**](CellsChartsApi.md#cellschartspostworksheetchart) | **POST** /cells/{name}/worksheets/{sheetName}/charts/{chartIndex} | Update chart propreties
[**CellsChartsPostWorksheetChartLegend**](CellsChartsApi.md#cellschartspostworksheetchartlegend) | **POST** /cells/{name}/worksheets/{sheetName}/charts/{chartIndex}/legend | Update chart legend
[**CellsChartsPostWorksheetChartTitle**](CellsChartsApi.md#cellschartspostworksheetcharttitle) | **POST** /cells/{name}/worksheets/{sheetName}/charts/{chartIndex}/title | Update chart title
[**CellsChartsPutWorksheetAddChart**](CellsChartsApi.md#cellschartsputworksheetaddchart) | **PUT** /cells/{name}/worksheets/{sheetName}/charts | Add new chart to worksheet.
[**CellsChartsPutWorksheetChartLegend**](CellsChartsApi.md#cellschartsputworksheetchartlegend) | **PUT** /cells/{name}/worksheets/{sheetName}/charts/{chartIndex}/legend | Show legend in chart
[**CellsChartsPutWorksheetChartTitle**](CellsChartsApi.md#cellschartsputworksheetcharttitle) | **PUT** /cells/{name}/worksheets/{sheetName}/charts/{chartIndex}/title | Add chart title / Set chart title visible


<a name="cellschartsdeleteworksheetchartlegend"></a>
# **CellsChartsDeleteWorksheetChartLegend**
> SaaSposeResponse CellsChartsDeleteWorksheetChartLegend (string name, string sheetName, int? chartIndex, string folder = null, string storage = null)

Hide legend in chart

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsChartsDeleteWorksheetChartLegendExample
    {
        public void main()
        {
            var apiInstance = new CellsChartsApi();
            var name = name_example;  // string | Workbook name.
            var sheetName = sheetName_example;  // string | Worksheet name.
            var chartIndex = 56;  // int? | The chart index.
            var folder = folder_example;  // string | The workbook folder. (optional) 
            var storage = storage_example;  // string | storage name. (optional) 

            try
            {
                // Hide legend in chart
                SaaSposeResponse result = apiInstance.CellsChartsDeleteWorksheetChartLegend(name, sheetName, chartIndex, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsChartsApi.CellsChartsDeleteWorksheetChartLegend: " + e.Message );
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

<a name="cellschartsdeleteworksheetcharttitle"></a>
# **CellsChartsDeleteWorksheetChartTitle**
> SaaSposeResponse CellsChartsDeleteWorksheetChartTitle (string name, string sheetName, int? chartIndex, string folder = null, string storage = null)

Hide title in chart

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsChartsDeleteWorksheetChartTitleExample
    {
        public void main()
        {
            var apiInstance = new CellsChartsApi();
            var name = name_example;  // string | Workbook name.
            var sheetName = sheetName_example;  // string | Worksheet name.
            var chartIndex = 56;  // int? | The chart index.
            var folder = folder_example;  // string | The workbook folder. (optional) 
            var storage = storage_example;  // string | storage name. (optional) 

            try
            {
                // Hide title in chart
                SaaSposeResponse result = apiInstance.CellsChartsDeleteWorksheetChartTitle(name, sheetName, chartIndex, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsChartsApi.CellsChartsDeleteWorksheetChartTitle: " + e.Message );
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

<a name="cellschartsdeleteworksheetclearcharts"></a>
# **CellsChartsDeleteWorksheetClearCharts**
> SaaSposeResponse CellsChartsDeleteWorksheetClearCharts (string name, string sheetName, string folder = null, string storage = null)

Clear the charts.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsChartsDeleteWorksheetClearChartsExample
    {
        public void main()
        {
            var apiInstance = new CellsChartsApi();
            var name = name_example;  // string | Workbook name.
            var sheetName = sheetName_example;  // string | The worksheet name.
            var folder = folder_example;  // string | The workbook folder. (optional) 
            var storage = storage_example;  // string | storage name. (optional) 

            try
            {
                // Clear the charts.
                SaaSposeResponse result = apiInstance.CellsChartsDeleteWorksheetClearCharts(name, sheetName, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsChartsApi.CellsChartsDeleteWorksheetClearCharts: " + e.Message );
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

<a name="cellschartsdeleteworksheetdeletechart"></a>
# **CellsChartsDeleteWorksheetDeleteChart**
> ChartsResponse CellsChartsDeleteWorksheetDeleteChart (string name, string sheetName, int? chartIndex, string folder = null, string storage = null)

Delete worksheet chart by index.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsChartsDeleteWorksheetDeleteChartExample
    {
        public void main()
        {
            var apiInstance = new CellsChartsApi();
            var name = name_example;  // string | Workbook name.
            var sheetName = sheetName_example;  // string | Worksheet name.
            var chartIndex = 56;  // int? | The chart index.
            var folder = folder_example;  // string | The workbook folder. (optional) 
            var storage = storage_example;  // string | storage name. (optional) 

            try
            {
                // Delete worksheet chart by index.
                ChartsResponse result = apiInstance.CellsChartsDeleteWorksheetDeleteChart(name, sheetName, chartIndex, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsChartsApi.CellsChartsDeleteWorksheetDeleteChart: " + e.Message );
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
 **folder** | **string**| The workbook folder. | [optional] 
 **storage** | **string**| storage name. | [optional] 

### Return type

[**ChartsResponse**](ChartsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellschartsgetworksheetchart"></a>
# **CellsChartsGetWorksheetChart**
> System.IO.Stream CellsChartsGetWorksheetChart (string name, string sheetName, int? chartNumber, string format = null, string folder = null, string storage = null)

Get chart info.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsChartsGetWorksheetChartExample
    {
        public void main()
        {
            var apiInstance = new CellsChartsApi();
            var name = name_example;  // string | Document name.
            var sheetName = sheetName_example;  // string | Worksheet name.
            var chartNumber = 56;  // int? | The chart number.
            var format = format_example;  // string | The exported file format. (optional) 
            var folder = folder_example;  // string | The document folder. (optional) 
            var storage = storage_example;  // string | storage name. (optional) 

            try
            {
                // Get chart info.
                System.IO.Stream result = apiInstance.CellsChartsGetWorksheetChart(name, sheetName, chartNumber, format, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsChartsApi.CellsChartsGetWorksheetChart: " + e.Message );
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
 **chartNumber** | **int?**| The chart number. | 
 **format** | **string**| The exported file format. | [optional] 
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

<a name="cellschartsgetworksheetchartlegend"></a>
# **CellsChartsGetWorksheetChartLegend**
> LegendResponse CellsChartsGetWorksheetChartLegend (string name, string sheetName, int? chartIndex, string folder = null, string storage = null)

Get chart legend

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsChartsGetWorksheetChartLegendExample
    {
        public void main()
        {
            var apiInstance = new CellsChartsApi();
            var name = name_example;  // string | Workbook name.
            var sheetName = sheetName_example;  // string | Worksheet name.
            var chartIndex = 56;  // int? | The chart index.
            var folder = folder_example;  // string | The workbook folder. (optional) 
            var storage = storage_example;  // string | storage name. (optional) 

            try
            {
                // Get chart legend
                LegendResponse result = apiInstance.CellsChartsGetWorksheetChartLegend(name, sheetName, chartIndex, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsChartsApi.CellsChartsGetWorksheetChartLegend: " + e.Message );
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
 **folder** | **string**| The workbook folder. | [optional] 
 **storage** | **string**| storage name. | [optional] 

### Return type

[**LegendResponse**](LegendResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellschartsgetworksheetcharttitle"></a>
# **CellsChartsGetWorksheetChartTitle**
> TitleResponse CellsChartsGetWorksheetChartTitle (string name, string sheetName, int? chartIndex, string folder = null, string storage = null)

Get chart title

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsChartsGetWorksheetChartTitleExample
    {
        public void main()
        {
            var apiInstance = new CellsChartsApi();
            var name = name_example;  // string | Workbook name.
            var sheetName = sheetName_example;  // string | Worksheet name.
            var chartIndex = 56;  // int? | The chart index.
            var folder = folder_example;  // string | The workbook folder. (optional) 
            var storage = storage_example;  // string | storage name. (optional) 

            try
            {
                // Get chart title
                TitleResponse result = apiInstance.CellsChartsGetWorksheetChartTitle(name, sheetName, chartIndex, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsChartsApi.CellsChartsGetWorksheetChartTitle: " + e.Message );
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
 **folder** | **string**| The workbook folder. | [optional] 
 **storage** | **string**| storage name. | [optional] 

### Return type

[**TitleResponse**](TitleResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellschartsgetworksheetcharts"></a>
# **CellsChartsGetWorksheetCharts**
> ChartsResponse CellsChartsGetWorksheetCharts (string name, string sheetName, string folder = null, string storage = null)

Get worksheet charts info.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsChartsGetWorksheetChartsExample
    {
        public void main()
        {
            var apiInstance = new CellsChartsApi();
            var name = name_example;  // string | Document name.
            var sheetName = sheetName_example;  // string | The worksheet name.
            var folder = folder_example;  // string | Document's folder. (optional) 
            var storage = storage_example;  // string | storage name. (optional) 

            try
            {
                // Get worksheet charts info.
                ChartsResponse result = apiInstance.CellsChartsGetWorksheetCharts(name, sheetName, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsChartsApi.CellsChartsGetWorksheetCharts: " + e.Message );
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

[**ChartsResponse**](ChartsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellschartspostworksheetchart"></a>
# **CellsChartsPostWorksheetChart**
> SaaSposeResponse CellsChartsPostWorksheetChart (string name, string sheetName, int? chartIndex, Chart chart = null, string folder = null, string storage = null)

Update chart propreties

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsChartsPostWorksheetChartExample
    {
        public void main()
        {
            var apiInstance = new CellsChartsApi();
            var name = name_example;  // string | 
            var sheetName = sheetName_example;  // string | 
            var chartIndex = 56;  // int? | 
            var chart = new Chart(); // Chart |  (optional) 
            var folder = folder_example;  // string |  (optional) 
            var storage = storage_example;  // string | storage name. (optional) 

            try
            {
                // Update chart propreties
                SaaSposeResponse result = apiInstance.CellsChartsPostWorksheetChart(name, sheetName, chartIndex, chart, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsChartsApi.CellsChartsPostWorksheetChart: " + e.Message );
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
 **chartIndex** | **int?**|  | 
 **chart** | [**Chart**](Chart.md)|  | [optional] 
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

<a name="cellschartspostworksheetchartlegend"></a>
# **CellsChartsPostWorksheetChartLegend**
> LegendResponse CellsChartsPostWorksheetChartLegend (string name, string sheetName, int? chartIndex, Legend legend = null, string folder = null, string storage = null)

Update chart legend

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsChartsPostWorksheetChartLegendExample
    {
        public void main()
        {
            var apiInstance = new CellsChartsApi();
            var name = name_example;  // string | Workbook name.
            var sheetName = sheetName_example;  // string | Worksheet name.
            var chartIndex = 56;  // int? | The chart index.
            var legend = new Legend(); // Legend |  (optional) 
            var folder = folder_example;  // string | The workbook folder. (optional) 
            var storage = storage_example;  // string | storage name. (optional) 

            try
            {
                // Update chart legend
                LegendResponse result = apiInstance.CellsChartsPostWorksheetChartLegend(name, sheetName, chartIndex, legend, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsChartsApi.CellsChartsPostWorksheetChartLegend: " + e.Message );
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
 **legend** | [**Legend**](Legend.md)|  | [optional] 
 **folder** | **string**| The workbook folder. | [optional] 
 **storage** | **string**| storage name. | [optional] 

### Return type

[**LegendResponse**](LegendResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellschartspostworksheetcharttitle"></a>
# **CellsChartsPostWorksheetChartTitle**
> TitleResponse CellsChartsPostWorksheetChartTitle (string name, string sheetName, int? chartIndex, Title title = null, string folder = null, string storage = null)

Update chart title

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsChartsPostWorksheetChartTitleExample
    {
        public void main()
        {
            var apiInstance = new CellsChartsApi();
            var name = name_example;  // string | Workbook name.
            var sheetName = sheetName_example;  // string | Worksheet name.
            var chartIndex = 56;  // int? | The chart index.
            var title = new Title(); // Title | Chart title (optional) 
            var folder = folder_example;  // string | The workbook folder. (optional) 
            var storage = storage_example;  // string | storage name. (optional) 

            try
            {
                // Update chart title
                TitleResponse result = apiInstance.CellsChartsPostWorksheetChartTitle(name, sheetName, chartIndex, title, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsChartsApi.CellsChartsPostWorksheetChartTitle: " + e.Message );
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
 **title** | [**Title**](Title.md)| Chart title | [optional] 
 **folder** | **string**| The workbook folder. | [optional] 
 **storage** | **string**| storage name. | [optional] 

### Return type

[**TitleResponse**](TitleResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellschartsputworksheetaddchart"></a>
# **CellsChartsPutWorksheetAddChart**
> ChartsResponse CellsChartsPutWorksheetAddChart (string name, string sheetName, string chartType, int? upperLeftRow = null, int? upperLeftColumn = null, int? lowerRightRow = null, int? lowerRightColumn = null, string area = null, bool? isVertical = null, string categoryData = null, bool? isAutoGetSerialName = null, string title = null, string folder = null, string storage = null)

Add new chart to worksheet.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsChartsPutWorksheetAddChartExample
    {
        public void main()
        {
            var apiInstance = new CellsChartsApi();
            var name = name_example;  // string | Workbook name.
            var sheetName = sheetName_example;  // string | The worksheet name.
            var chartType = chartType_example;  // string | Chart type, please refer property Type in chart resource.
            var upperLeftRow = 56;  // int? | New chart upper left row. (optional)  (default to 0)
            var upperLeftColumn = 56;  // int? | New chart upperleft column. (optional)  (default to 0)
            var lowerRightRow = 56;  // int? | New chart lower right row. (optional)  (default to 0)
            var lowerRightColumn = 56;  // int? | New chart lower right column. (optional)  (default to 0)
            var area = area_example;  // string | Specifies values from which to plot the data series.  (optional) 
            var isVertical = true;  // bool? | Specifies whether to plot the series from a range of cell values by row or by column.  (optional)  (default to true)
            var categoryData = categoryData_example;  // string | Gets or sets the range of category Axis values. It can be a range of cells (such as, \"d1:e10\").  (optional) 
            var isAutoGetSerialName = true;  // bool? | Specifies whether auto update serial name.  (optional)  (default to true)
            var title = title_example;  // string | Specifies chart title name. (optional) 
            var folder = folder_example;  // string | The workbook folder. (optional) 
            var storage = storage_example;  // string | storage name. (optional) 

            try
            {
                // Add new chart to worksheet.
                ChartsResponse result = apiInstance.CellsChartsPutWorksheetAddChart(name, sheetName, chartType, upperLeftRow, upperLeftColumn, lowerRightRow, lowerRightColumn, area, isVertical, categoryData, isAutoGetSerialName, title, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsChartsApi.CellsChartsPutWorksheetAddChart: " + e.Message );
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
 **chartType** | **string**| Chart type, please refer property Type in chart resource. | 
 **upperLeftRow** | **int?**| New chart upper left row. | [optional] [default to 0]
 **upperLeftColumn** | **int?**| New chart upperleft column. | [optional] [default to 0]
 **lowerRightRow** | **int?**| New chart lower right row. | [optional] [default to 0]
 **lowerRightColumn** | **int?**| New chart lower right column. | [optional] [default to 0]
 **area** | **string**| Specifies values from which to plot the data series.  | [optional] 
 **isVertical** | **bool?**| Specifies whether to plot the series from a range of cell values by row or by column.  | [optional] [default to true]
 **categoryData** | **string**| Gets or sets the range of category Axis values. It can be a range of cells (such as, \&quot;d1:e10\&quot;).  | [optional] 
 **isAutoGetSerialName** | **bool?**| Specifies whether auto update serial name.  | [optional] [default to true]
 **title** | **string**| Specifies chart title name. | [optional] 
 **folder** | **string**| The workbook folder. | [optional] 
 **storage** | **string**| storage name. | [optional] 

### Return type

[**ChartsResponse**](ChartsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellschartsputworksheetchartlegend"></a>
# **CellsChartsPutWorksheetChartLegend**
> SaaSposeResponse CellsChartsPutWorksheetChartLegend (string name, string sheetName, int? chartIndex, string folder = null, string storage = null)

Show legend in chart

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsChartsPutWorksheetChartLegendExample
    {
        public void main()
        {
            var apiInstance = new CellsChartsApi();
            var name = name_example;  // string | Workbook name.
            var sheetName = sheetName_example;  // string | Worksheet name.
            var chartIndex = 56;  // int? | The chart index.
            var folder = folder_example;  // string | The workbook folder. (optional) 
            var storage = storage_example;  // string | storage name. (optional) 

            try
            {
                // Show legend in chart
                SaaSposeResponse result = apiInstance.CellsChartsPutWorksheetChartLegend(name, sheetName, chartIndex, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsChartsApi.CellsChartsPutWorksheetChartLegend: " + e.Message );
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

<a name="cellschartsputworksheetcharttitle"></a>
# **CellsChartsPutWorksheetChartTitle**
> TitleResponse CellsChartsPutWorksheetChartTitle (string name, string sheetName, int? chartIndex, Title title = null, string folder = null, string storage = null)

Add chart title / Set chart title visible

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsChartsPutWorksheetChartTitleExample
    {
        public void main()
        {
            var apiInstance = new CellsChartsApi();
            var name = name_example;  // string | Workbook name.
            var sheetName = sheetName_example;  // string | Worksheet name.
            var chartIndex = 56;  // int? | The chart index.
            var title = new Title(); // Title | Chart title. (optional) 
            var folder = folder_example;  // string | The workbook folder. (optional) 
            var storage = storage_example;  // string | storage name. (optional) 

            try
            {
                // Add chart title / Set chart title visible
                TitleResponse result = apiInstance.CellsChartsPutWorksheetChartTitle(name, sheetName, chartIndex, title, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsChartsApi.CellsChartsPutWorksheetChartTitle: " + e.Message );
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
 **title** | [**Title**](Title.md)| Chart title. | [optional] 
 **folder** | **string**| The workbook folder. | [optional] 
 **storage** | **string**| storage name. | [optional] 

### Return type

[**TitleResponse**](TitleResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

