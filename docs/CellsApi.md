# Aspose.Cells.Cloud.SDK.Api.CellsApi

All URIs are relative to *https://api.aspose.cloud/v1.1/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CellsDeleteWorksheetColumns**](CellsApi.md#cellsdeleteworksheetcolumns) | **DELETE** /cells/{name}/worksheets/{sheetName}/cells/columns/{columnIndex} | Delete worksheet columns.
[**CellsDeleteWorksheetRow**](CellsApi.md#cellsdeleteworksheetrow) | **DELETE** /cells/{name}/worksheets/{sheetName}/cells/rows/{rowIndex} | Delete worksheet row.
[**CellsDeleteWorksheetRows**](CellsApi.md#cellsdeleteworksheetrows) | **DELETE** /cells/{name}/worksheets/{sheetName}/cells/rows | Delete several worksheet rows.
[**CellsGetWorksheetCell**](CellsApi.md#cellsgetworksheetcell) | **GET** /cells/{name}/worksheets/{sheetName}/cells/{cellOrMethodName} | Read cell data by cell&#39;s name.
[**CellsGetWorksheetCellStyle**](CellsApi.md#cellsgetworksheetcellstyle) | **GET** /cells/{name}/worksheets/{sheetName}/cells/{cellName}/style | Read cell&#39;s style info.
[**CellsGetWorksheetCells**](CellsApi.md#cellsgetworksheetcells) | **GET** /cells/{name}/worksheets/{sheetName}/cells | Get cells info.
[**CellsGetWorksheetColumn**](CellsApi.md#cellsgetworksheetcolumn) | **GET** /cells/{name}/worksheets/{sheetName}/cells/columns/{columnIndex} | Read worksheet column data by column&#39;s index.
[**CellsGetWorksheetColumns**](CellsApi.md#cellsgetworksheetcolumns) | **GET** /cells/{name}/worksheets/{sheetName}/cells/columns | Read worksheet columns info.
[**CellsGetWorksheetRow**](CellsApi.md#cellsgetworksheetrow) | **GET** /cells/{name}/worksheets/{sheetName}/cells/rows/{rowIndex} | Read worksheet row data by row&#39;s index.
[**CellsGetWorksheetRows**](CellsApi.md#cellsgetworksheetrows) | **GET** /cells/{name}/worksheets/{sheetName}/cells/rows | Read worksheet rows info.
[**CellsPostCellCalculate**](CellsApi.md#cellspostcellcalculate) | **POST** /cells/{name}/worksheets/{sheetName}/cells/{cellName}/calculate | Cell calculate formula
[**CellsPostCellCharacters**](CellsApi.md#cellspostcellcharacters) | **POST** /cells/{name}/worksheets/{sheetName}/cells/{cellName}/characters | Set cell characters 
[**CellsPostClearContents**](CellsApi.md#cellspostclearcontents) | **POST** /cells/{name}/worksheets/{sheetName}/cells/clearcontents | Clear cells contents.
[**CellsPostClearFormats**](CellsApi.md#cellspostclearformats) | **POST** /cells/{name}/worksheets/{sheetName}/cells/clearformats | Clear cells contents.
[**CellsPostColumnStyle**](CellsApi.md#cellspostcolumnstyle) | **POST** /cells/{name}/worksheets/{sheetName}/cells/columns/{columnIndex}/style | Set column style
[**CellsPostCopyCellIntoCell**](CellsApi.md#cellspostcopycellintocell) | **POST** /cells/{name}/worksheets/{sheetName}/cells/{destCellName}/copy | Copy cell into cell
[**CellsPostCopyWorksheetColumns**](CellsApi.md#cellspostcopyworksheetcolumns) | **POST** /cells/{name}/worksheets/{sheetName}/cells/columns/copy | Copy worksheet columns.
[**CellsPostCopyWorksheetRows**](CellsApi.md#cellspostcopyworksheetrows) | **POST** /cells/{name}/worksheets/{sheetName}/cells/rows/copy | Copy worksheet rows.
[**CellsPostGroupWorksheetColumns**](CellsApi.md#cellspostgroupworksheetcolumns) | **POST** /cells/{name}/worksheets/{sheetName}/cells/columns/group | Group worksheet columns.
[**CellsPostGroupWorksheetRows**](CellsApi.md#cellspostgroupworksheetrows) | **POST** /cells/{name}/worksheets/{sheetName}/cells/rows/group | Group worksheet rows.
[**CellsPostHideWorksheetColumns**](CellsApi.md#cellsposthideworksheetcolumns) | **POST** /cells/{name}/worksheets/{sheetName}/cells/columns/hide | Hide worksheet columns.
[**CellsPostHideWorksheetRows**](CellsApi.md#cellsposthideworksheetrows) | **POST** /cells/{name}/worksheets/{sheetName}/cells/rows/hide | Hide worksheet rows.
[**CellsPostRowStyle**](CellsApi.md#cellspostrowstyle) | **POST** /cells/{name}/worksheets/{sheetName}/cells/rows/{rowIndex}/style | Set row style.
[**CellsPostSetCellHtmlString**](CellsApi.md#cellspostsetcellhtmlstring) | **POST** /cells/{name}/worksheets/{sheetName}/cells/{cellName}/htmlstring | Set htmlstring value into cell
[**CellsPostSetCellRangeValue**](CellsApi.md#cellspostsetcellrangevalue) | **POST** /cells/{name}/worksheets/{sheetName}/cells | Set cell range value 
[**CellsPostSetWorksheetColumnWidth**](CellsApi.md#cellspostsetworksheetcolumnwidth) | **POST** /cells/{name}/worksheets/{sheetName}/cells/columns/{columnIndex} | Set worksheet column width.
[**CellsPostUngroupWorksheetColumns**](CellsApi.md#cellspostungroupworksheetcolumns) | **POST** /cells/{name}/worksheets/{sheetName}/cells/columns/ungroup | Ungroup worksheet columns.
[**CellsPostUngroupWorksheetRows**](CellsApi.md#cellspostungroupworksheetrows) | **POST** /cells/{name}/worksheets/{sheetName}/cells/rows/ungroup | Ungroup worksheet rows.
[**CellsPostUnhideWorksheetColumns**](CellsApi.md#cellspostunhideworksheetcolumns) | **POST** /cells/{name}/worksheets/{sheetName}/cells/columns/unhide | Unhide worksheet columns.
[**CellsPostUnhideWorksheetRows**](CellsApi.md#cellspostunhideworksheetrows) | **POST** /cells/{name}/worksheets/{sheetName}/cells/rows/unhide | Unhide worksheet rows.
[**CellsPostUpdateWorksheetCellStyle**](CellsApi.md#cellspostupdateworksheetcellstyle) | **POST** /cells/{name}/worksheets/{sheetName}/cells/{cellName}/style | Update cell&#39;s style.
[**CellsPostUpdateWorksheetRangeStyle**](CellsApi.md#cellspostupdateworksheetrangestyle) | **POST** /cells/{name}/worksheets/{sheetName}/cells/style | Update cell&#39;s range style.
[**CellsPostUpdateWorksheetRow**](CellsApi.md#cellspostupdateworksheetrow) | **POST** /cells/{name}/worksheets/{sheetName}/cells/rows/{rowIndex} | Update worksheet row.
[**CellsPostWorksheetCellSetValue**](CellsApi.md#cellspostworksheetcellsetvalue) | **POST** /cells/{name}/worksheets/{sheetName}/cells/{cellName} | Set cell value.
[**CellsPostWorksheetMerge**](CellsApi.md#cellspostworksheetmerge) | **POST** /cells/{name}/worksheets/{sheetName}/cells/merge | Merge cells.
[**CellsPostWorksheetUnmerge**](CellsApi.md#cellspostworksheetunmerge) | **POST** /cells/{name}/worksheets/{sheetName}/cells/unmerge | Unmerge cells.
[**CellsPutInsertWorksheetColumns**](CellsApi.md#cellsputinsertworksheetcolumns) | **PUT** /cells/{name}/worksheets/{sheetName}/cells/columns/{columnIndex} | Insert worksheet columns.
[**CellsPutInsertWorksheetRow**](CellsApi.md#cellsputinsertworksheetrow) | **PUT** /cells/{name}/worksheets/{sheetName}/cells/rows/{rowIndex} | Insert new worksheet row.
[**CellsPutInsertWorksheetRows**](CellsApi.md#cellsputinsertworksheetrows) | **PUT** /cells/{name}/worksheets/{sheetName}/cells/rows | Insert several new worksheet rows.


<a name="cellsdeleteworksheetcolumns"></a>
# **CellsDeleteWorksheetColumns**
> ColumnsResponse CellsDeleteWorksheetColumns (string name, string sheetName, int? columnIndex, int? columns, bool? updateReference, string folder = null)

Delete worksheet columns.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsDeleteWorksheetColumnsExample
    {
        public void main()
        {
            var apiInstance = new CellsApi();
            var name = name_example;  // string | The workbook name.
            var sheetName = sheetName_example;  // string | The worksheet name.
            var columnIndex = 56;  // int? | The column index.
            var columns = 56;  // int? | The columns.
            var updateReference = true;  // bool? | The update reference.
            var folder = folder_example;  // string | The workbook folder. (optional) 

            try
            {
                // Delete worksheet columns.
                ColumnsResponse result = apiInstance.CellsDeleteWorksheetColumns(name, sheetName, columnIndex, columns, updateReference, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsApi.CellsDeleteWorksheetColumns: " + e.Message );
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
 **columnIndex** | **int?**| The column index. | 
 **columns** | **int?**| The columns. | 
 **updateReference** | **bool?**| The update reference. | 
 **folder** | **string**| The workbook folder. | [optional] 

### Return type

[**ColumnsResponse**](ColumnsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellsdeleteworksheetrow"></a>
# **CellsDeleteWorksheetRow**
> SaaSposeResponse CellsDeleteWorksheetRow (string name, string sheetName, int? rowIndex, string folder = null)

Delete worksheet row.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsDeleteWorksheetRowExample
    {
        public void main()
        {
            var apiInstance = new CellsApi();
            var name = name_example;  // string | The workbook name.
            var sheetName = sheetName_example;  // string | The worksheet bame.
            var rowIndex = 56;  // int? | The row index.
            var folder = folder_example;  // string | The document folder. (optional) 

            try
            {
                // Delete worksheet row.
                SaaSposeResponse result = apiInstance.CellsDeleteWorksheetRow(name, sheetName, rowIndex, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsApi.CellsDeleteWorksheetRow: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The workbook name. | 
 **sheetName** | **string**| The worksheet bame. | 
 **rowIndex** | **int?**| The row index. | 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**SaaSposeResponse**](SaaSposeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellsdeleteworksheetrows"></a>
# **CellsDeleteWorksheetRows**
> SaaSposeResponse CellsDeleteWorksheetRows (string name, string sheetName, int? startrow, int? totalRows = null, bool? updateReference = null, string folder = null)

Delete several worksheet rows.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsDeleteWorksheetRowsExample
    {
        public void main()
        {
            var apiInstance = new CellsApi();
            var name = name_example;  // string | The workbook name.
            var sheetName = sheetName_example;  // string | The worksheet bame.
            var startrow = 56;  // int? | The begin row index to be operated.
            var totalRows = 56;  // int? | Number of rows to be operated. (optional)  (default to 1)
            var updateReference = true;  // bool? | Indicates if update references in other worksheets. (optional)  (default to true)
            var folder = folder_example;  // string | The document folder. (optional) 

            try
            {
                // Delete several worksheet rows.
                SaaSposeResponse result = apiInstance.CellsDeleteWorksheetRows(name, sheetName, startrow, totalRows, updateReference, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsApi.CellsDeleteWorksheetRows: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The workbook name. | 
 **sheetName** | **string**| The worksheet bame. | 
 **startrow** | **int?**| The begin row index to be operated. | 
 **totalRows** | **int?**| Number of rows to be operated. | [optional] [default to 1]
 **updateReference** | **bool?**| Indicates if update references in other worksheets. | [optional] [default to true]
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**SaaSposeResponse**](SaaSposeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellsgetworksheetcell"></a>
# **CellsGetWorksheetCell**
> System.IO.Stream CellsGetWorksheetCell (string name, string sheetName, string cellOrMethodName, string folder = null)

Read cell data by cell's name.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsGetWorksheetCellExample
    {
        public void main()
        {
            var apiInstance = new CellsApi();
            var name = name_example;  // string | Document name.
            var sheetName = sheetName_example;  // string | Worksheet name.
            var cellOrMethodName = cellOrMethodName_example;  // string | The cell's or method name. (Method name like firstcell, endcell etc.)
            var folder = folder_example;  // string | Document's folder. (optional) 

            try
            {
                // Read cell data by cell's name.
                System.IO.Stream result = apiInstance.CellsGetWorksheetCell(name, sheetName, cellOrMethodName, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsApi.CellsGetWorksheetCell: " + e.Message );
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
 **cellOrMethodName** | **string**| The cell&#39;s or method name. (Method name like firstcell, endcell etc.) | 
 **folder** | **string**| Document&#39;s folder. | [optional] 

### Return type

**System.IO.Stream**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellsgetworksheetcellstyle"></a>
# **CellsGetWorksheetCellStyle**
> StyleResponse CellsGetWorksheetCellStyle (string name, string sheetName, string cellName, string folder = null)

Read cell's style info.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsGetWorksheetCellStyleExample
    {
        public void main()
        {
            var apiInstance = new CellsApi();
            var name = name_example;  // string | Document name.
            var sheetName = sheetName_example;  // string | Worksheet name.
            var cellName = cellName_example;  // string | Cell's name.
            var folder = folder_example;  // string | Document's folder. (optional) 

            try
            {
                // Read cell's style info.
                StyleResponse result = apiInstance.CellsGetWorksheetCellStyle(name, sheetName, cellName, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsApi.CellsGetWorksheetCellStyle: " + e.Message );
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
 **cellName** | **string**| Cell&#39;s name. | 
 **folder** | **string**| Document&#39;s folder. | [optional] 

### Return type

[**StyleResponse**](StyleResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellsgetworksheetcells"></a>
# **CellsGetWorksheetCells**
> CellsResponse CellsGetWorksheetCells (string name, string sheetName, int? offest = null, int? count = null, string folder = null)

Get cells info.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsGetWorksheetCellsExample
    {
        public void main()
        {
            var apiInstance = new CellsApi();
            var name = name_example;  // string | Document name.
            var sheetName = sheetName_example;  // string | Worksheet name.
            var offest = 56;  // int? | Begginig offset. (optional)  (default to 0)
            var count = 56;  // int? | Maximum amount of cells in the response. (optional)  (default to 0)
            var folder = folder_example;  // string | Document's folder name. (optional) 

            try
            {
                // Get cells info.
                CellsResponse result = apiInstance.CellsGetWorksheetCells(name, sheetName, offest, count, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsApi.CellsGetWorksheetCells: " + e.Message );
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
 **offest** | **int?**| Begginig offset. | [optional] [default to 0]
 **count** | **int?**| Maximum amount of cells in the response. | [optional] [default to 0]
 **folder** | **string**| Document&#39;s folder name. | [optional] 

### Return type

[**CellsResponse**](CellsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellsgetworksheetcolumn"></a>
# **CellsGetWorksheetColumn**
> ColumnResponse CellsGetWorksheetColumn (string name, string sheetName, int? columnIndex, string folder = null)

Read worksheet column data by column's index.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsGetWorksheetColumnExample
    {
        public void main()
        {
            var apiInstance = new CellsApi();
            var name = name_example;  // string | The workbook name.
            var sheetName = sheetName_example;  // string | The worksheet name.
            var columnIndex = 56;  // int? | The column index.
            var folder = folder_example;  // string | The workbook folder. (optional) 

            try
            {
                // Read worksheet column data by column's index.
                ColumnResponse result = apiInstance.CellsGetWorksheetColumn(name, sheetName, columnIndex, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsApi.CellsGetWorksheetColumn: " + e.Message );
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
 **columnIndex** | **int?**| The column index. | 
 **folder** | **string**| The workbook folder. | [optional] 

### Return type

[**ColumnResponse**](ColumnResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellsgetworksheetcolumns"></a>
# **CellsGetWorksheetColumns**
> ColumnsResponse CellsGetWorksheetColumns (string name, string sheetName, string folder = null)

Read worksheet columns info.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsGetWorksheetColumnsExample
    {
        public void main()
        {
            var apiInstance = new CellsApi();
            var name = name_example;  // string | The workbook name.
            var sheetName = sheetName_example;  // string | The worksheet name.
            var folder = folder_example;  // string | The workdook folder. (optional) 

            try
            {
                // Read worksheet columns info.
                ColumnsResponse result = apiInstance.CellsGetWorksheetColumns(name, sheetName, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsApi.CellsGetWorksheetColumns: " + e.Message );
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
 **folder** | **string**| The workdook folder. | [optional] 

### Return type

[**ColumnsResponse**](ColumnsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellsgetworksheetrow"></a>
# **CellsGetWorksheetRow**
> RowResponse CellsGetWorksheetRow (string name, string sheetName, int? rowIndex, string folder = null)

Read worksheet row data by row's index.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsGetWorksheetRowExample
    {
        public void main()
        {
            var apiInstance = new CellsApi();
            var name = name_example;  // string | The workbook name.
            var sheetName = sheetName_example;  // string | The worksheet name.
            var rowIndex = 56;  // int? | The row index.
            var folder = folder_example;  // string | The workbook folder. (optional) 

            try
            {
                // Read worksheet row data by row's index.
                RowResponse result = apiInstance.CellsGetWorksheetRow(name, sheetName, rowIndex, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsApi.CellsGetWorksheetRow: " + e.Message );
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
 **rowIndex** | **int?**| The row index. | 
 **folder** | **string**| The workbook folder. | [optional] 

### Return type

[**RowResponse**](RowResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellsgetworksheetrows"></a>
# **CellsGetWorksheetRows**
> RowsResponse CellsGetWorksheetRows (string name, string sheetName, string folder = null)

Read worksheet rows info.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsGetWorksheetRowsExample
    {
        public void main()
        {
            var apiInstance = new CellsApi();
            var name = name_example;  // string | The workbook name.
            var sheetName = sheetName_example;  // string | The worksheet name.
            var folder = folder_example;  // string | The workdook folder. (optional) 

            try
            {
                // Read worksheet rows info.
                RowsResponse result = apiInstance.CellsGetWorksheetRows(name, sheetName, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsApi.CellsGetWorksheetRows: " + e.Message );
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
 **folder** | **string**| The workdook folder. | [optional] 

### Return type

[**RowsResponse**](RowsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellspostcellcalculate"></a>
# **CellsPostCellCalculate**
> SaaSposeResponse CellsPostCellCalculate (string name, string sheetName, string cellName, CalculationOptions options = null, string folder = null)

Cell calculate formula

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsPostCellCalculateExample
    {
        public void main()
        {
            var apiInstance = new CellsApi();
            var name = name_example;  // string | 
            var sheetName = sheetName_example;  // string | 
            var cellName = cellName_example;  // string | 
            var options = new CalculationOptions(); // CalculationOptions |  (optional) 
            var folder = folder_example;  // string |  (optional) 

            try
            {
                // Cell calculate formula
                SaaSposeResponse result = apiInstance.CellsPostCellCalculate(name, sheetName, cellName, options, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsApi.CellsPostCellCalculate: " + e.Message );
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
 **cellName** | **string**|  | 
 **options** | [**CalculationOptions**](CalculationOptions.md)|  | [optional] 
 **folder** | **string**|  | [optional] 

### Return type

[**SaaSposeResponse**](SaaSposeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellspostcellcharacters"></a>
# **CellsPostCellCharacters**
> SaaSposeResponse CellsPostCellCharacters (string name, string sheetName, string cellName, List<FontSetting> options = null, string folder = null)

Set cell characters 

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsPostCellCharactersExample
    {
        public void main()
        {
            var apiInstance = new CellsApi();
            var name = name_example;  // string | 
            var sheetName = sheetName_example;  // string | 
            var cellName = cellName_example;  // string | 
            var options = new List<FontSetting>(); // List<FontSetting> |  (optional) 
            var folder = folder_example;  // string |  (optional) 

            try
            {
                // Set cell characters 
                SaaSposeResponse result = apiInstance.CellsPostCellCharacters(name, sheetName, cellName, options, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsApi.CellsPostCellCharacters: " + e.Message );
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
 **cellName** | **string**|  | 
 **options** | [**List&lt;FontSetting&gt;**](FontSetting.md)|  | [optional] 
 **folder** | **string**|  | [optional] 

### Return type

[**SaaSposeResponse**](SaaSposeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellspostclearcontents"></a>
# **CellsPostClearContents**
> SaaSposeResponse CellsPostClearContents (string name, string sheetName, string range = null, int? startRow = null, int? startColumn = null, int? endRow = null, int? endColumn = null, string folder = null)

Clear cells contents.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsPostClearContentsExample
    {
        public void main()
        {
            var apiInstance = new CellsApi();
            var name = name_example;  // string | Workbook name.
            var sheetName = sheetName_example;  // string | Worksheet name.
            var range = range_example;  // string | The range. (optional) 
            var startRow = 56;  // int? | The start row. (optional) 
            var startColumn = 56;  // int? | The start column. (optional) 
            var endRow = 56;  // int? | The end row. (optional) 
            var endColumn = 56;  // int? | The end column. (optional) 
            var folder = folder_example;  // string | The workbook folder. (optional) 

            try
            {
                // Clear cells contents.
                SaaSposeResponse result = apiInstance.CellsPostClearContents(name, sheetName, range, startRow, startColumn, endRow, endColumn, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsApi.CellsPostClearContents: " + e.Message );
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
 **range** | **string**| The range. | [optional] 
 **startRow** | **int?**| The start row. | [optional] 
 **startColumn** | **int?**| The start column. | [optional] 
 **endRow** | **int?**| The end row. | [optional] 
 **endColumn** | **int?**| The end column. | [optional] 
 **folder** | **string**| The workbook folder. | [optional] 

### Return type

[**SaaSposeResponse**](SaaSposeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellspostclearformats"></a>
# **CellsPostClearFormats**
> SaaSposeResponse CellsPostClearFormats (string name, string sheetName, string range = null, int? startRow = null, int? startColumn = null, int? endRow = null, int? endColumn = null, string folder = null)

Clear cells contents.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsPostClearFormatsExample
    {
        public void main()
        {
            var apiInstance = new CellsApi();
            var name = name_example;  // string | Workbook name.
            var sheetName = sheetName_example;  // string | Worksheet name.
            var range = range_example;  // string | The range. (optional) 
            var startRow = 56;  // int? | The start row. (optional) 
            var startColumn = 56;  // int? | The start column. (optional) 
            var endRow = 56;  // int? | The end row. (optional) 
            var endColumn = 56;  // int? | The end column. (optional) 
            var folder = folder_example;  // string | The workbook folder. (optional) 

            try
            {
                // Clear cells contents.
                SaaSposeResponse result = apiInstance.CellsPostClearFormats(name, sheetName, range, startRow, startColumn, endRow, endColumn, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsApi.CellsPostClearFormats: " + e.Message );
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
 **range** | **string**| The range. | [optional] 
 **startRow** | **int?**| The start row. | [optional] 
 **startColumn** | **int?**| The start column. | [optional] 
 **endRow** | **int?**| The end row. | [optional] 
 **endColumn** | **int?**| The end column. | [optional] 
 **folder** | **string**| The workbook folder. | [optional] 

### Return type

[**SaaSposeResponse**](SaaSposeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellspostcolumnstyle"></a>
# **CellsPostColumnStyle**
> SaaSposeResponse CellsPostColumnStyle (string name, string sheetName, int? columnIndex, Style style = null, string folder = null)

Set column style

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsPostColumnStyleExample
    {
        public void main()
        {
            var apiInstance = new CellsApi();
            var name = name_example;  // string | The workbook name.
            var sheetName = sheetName_example;  // string | The worksheet name.
            var columnIndex = 56;  // int? | The column index.
            var style = new Style(); // Style | Style dto (optional) 
            var folder = folder_example;  // string | The workbook folder. (optional) 

            try
            {
                // Set column style
                SaaSposeResponse result = apiInstance.CellsPostColumnStyle(name, sheetName, columnIndex, style, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsApi.CellsPostColumnStyle: " + e.Message );
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
 **columnIndex** | **int?**| The column index. | 
 **style** | [**Style**](Style.md)| Style dto | [optional] 
 **folder** | **string**| The workbook folder. | [optional] 

### Return type

[**SaaSposeResponse**](SaaSposeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellspostcopycellintocell"></a>
# **CellsPostCopyCellIntoCell**
> SaaSposeResponse CellsPostCopyCellIntoCell (string name, string destCellName, string sheetName, string worksheet, string cellname = null, int? row = null, int? column = null, string folder = null)

Copy cell into cell

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsPostCopyCellIntoCellExample
    {
        public void main()
        {
            var apiInstance = new CellsApi();
            var name = name_example;  // string | Workbook name.
            var destCellName = destCellName_example;  // string | Destination cell name
            var sheetName = sheetName_example;  // string | Destination worksheet name.
            var worksheet = worksheet_example;  // string | Source worksheet name.
            var cellname = cellname_example;  // string | Source cell name (optional) 
            var row = 56;  // int? | Source row (optional) 
            var column = 56;  // int? | Source column (optional) 
            var folder = folder_example;  // string | Folder name (optional) 

            try
            {
                // Copy cell into cell
                SaaSposeResponse result = apiInstance.CellsPostCopyCellIntoCell(name, destCellName, sheetName, worksheet, cellname, row, column, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsApi.CellsPostCopyCellIntoCell: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Workbook name. | 
 **destCellName** | **string**| Destination cell name | 
 **sheetName** | **string**| Destination worksheet name. | 
 **worksheet** | **string**| Source worksheet name. | 
 **cellname** | **string**| Source cell name | [optional] 
 **row** | **int?**| Source row | [optional] 
 **column** | **int?**| Source column | [optional] 
 **folder** | **string**| Folder name | [optional] 

### Return type

[**SaaSposeResponse**](SaaSposeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellspostcopyworksheetcolumns"></a>
# **CellsPostCopyWorksheetColumns**
> SaaSposeResponse CellsPostCopyWorksheetColumns (string name, string sheetName, int? sourceColumnIndex, int? destinationColumnIndex, int? columnNumber, string worksheet = null, string folder = null)

Copy worksheet columns.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsPostCopyWorksheetColumnsExample
    {
        public void main()
        {
            var apiInstance = new CellsApi();
            var name = name_example;  // string | The workbook name.
            var sheetName = sheetName_example;  // string | The worksheet name.
            var sourceColumnIndex = 56;  // int? | Source column index
            var destinationColumnIndex = 56;  // int? | Destination column index
            var columnNumber = 56;  // int? | The copied column number
            var worksheet = worksheet_example;  // string | The Worksheet (optional)  (default to )
            var folder = folder_example;  // string | The document folder. (optional) 

            try
            {
                // Copy worksheet columns.
                SaaSposeResponse result = apiInstance.CellsPostCopyWorksheetColumns(name, sheetName, sourceColumnIndex, destinationColumnIndex, columnNumber, worksheet, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsApi.CellsPostCopyWorksheetColumns: " + e.Message );
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
 **sourceColumnIndex** | **int?**| Source column index | 
 **destinationColumnIndex** | **int?**| Destination column index | 
 **columnNumber** | **int?**| The copied column number | 
 **worksheet** | **string**| The Worksheet | [optional] [default to ]
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**SaaSposeResponse**](SaaSposeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellspostcopyworksheetrows"></a>
# **CellsPostCopyWorksheetRows**
> SaaSposeResponse CellsPostCopyWorksheetRows (string name, string sheetName, int? sourceRowIndex, int? destinationRowIndex, int? rowNumber, string worksheet = null, string folder = null)

Copy worksheet rows.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsPostCopyWorksheetRowsExample
    {
        public void main()
        {
            var apiInstance = new CellsApi();
            var name = name_example;  // string | The workbook name.
            var sheetName = sheetName_example;  // string | The worksheet name.
            var sourceRowIndex = 56;  // int? | Source row index
            var destinationRowIndex = 56;  // int? | Destination row index
            var rowNumber = 56;  // int? | The copied row number
            var worksheet = worksheet_example;  // string | worksheet (optional) 
            var folder = folder_example;  // string | The document folder. (optional) 

            try
            {
                // Copy worksheet rows.
                SaaSposeResponse result = apiInstance.CellsPostCopyWorksheetRows(name, sheetName, sourceRowIndex, destinationRowIndex, rowNumber, worksheet, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsApi.CellsPostCopyWorksheetRows: " + e.Message );
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
 **sourceRowIndex** | **int?**| Source row index | 
 **destinationRowIndex** | **int?**| Destination row index | 
 **rowNumber** | **int?**| The copied row number | 
 **worksheet** | **string**| worksheet | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**SaaSposeResponse**](SaaSposeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellspostgroupworksheetcolumns"></a>
# **CellsPostGroupWorksheetColumns**
> SaaSposeResponse CellsPostGroupWorksheetColumns (string name, string sheetName, int? firstIndex, int? lastIndex, bool? hide = null, string folder = null)

Group worksheet columns.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsPostGroupWorksheetColumnsExample
    {
        public void main()
        {
            var apiInstance = new CellsApi();
            var name = name_example;  // string | The workbook name.
            var sheetName = sheetName_example;  // string | The worksheet name.
            var firstIndex = 56;  // int? | The first column index to be operated.
            var lastIndex = 56;  // int? | The last column index to be operated.
            var hide = true;  // bool? | columns visible state (optional) 
            var folder = folder_example;  // string | The document folder. (optional) 

            try
            {
                // Group worksheet columns.
                SaaSposeResponse result = apiInstance.CellsPostGroupWorksheetColumns(name, sheetName, firstIndex, lastIndex, hide, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsApi.CellsPostGroupWorksheetColumns: " + e.Message );
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
 **firstIndex** | **int?**| The first column index to be operated. | 
 **lastIndex** | **int?**| The last column index to be operated. | 
 **hide** | **bool?**| columns visible state | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**SaaSposeResponse**](SaaSposeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellspostgroupworksheetrows"></a>
# **CellsPostGroupWorksheetRows**
> SaaSposeResponse CellsPostGroupWorksheetRows (string name, string sheetName, int? firstIndex, int? lastIndex, bool? hide = null, string folder = null)

Group worksheet rows.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsPostGroupWorksheetRowsExample
    {
        public void main()
        {
            var apiInstance = new CellsApi();
            var name = name_example;  // string | The workbook name.
            var sheetName = sheetName_example;  // string | The worksheet name.
            var firstIndex = 56;  // int? | The first row index to be operated.
            var lastIndex = 56;  // int? | The last row index to be operated.
            var hide = true;  // bool? | rows visible state (optional) 
            var folder = folder_example;  // string | The document folder. (optional) 

            try
            {
                // Group worksheet rows.
                SaaSposeResponse result = apiInstance.CellsPostGroupWorksheetRows(name, sheetName, firstIndex, lastIndex, hide, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsApi.CellsPostGroupWorksheetRows: " + e.Message );
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
 **firstIndex** | **int?**| The first row index to be operated. | 
 **lastIndex** | **int?**| The last row index to be operated. | 
 **hide** | **bool?**| rows visible state | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**SaaSposeResponse**](SaaSposeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellsposthideworksheetcolumns"></a>
# **CellsPostHideWorksheetColumns**
> SaaSposeResponse CellsPostHideWorksheetColumns (string name, string sheetName, int? startColumn, int? totalColumns, string folder = null)

Hide worksheet columns.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsPostHideWorksheetColumnsExample
    {
        public void main()
        {
            var apiInstance = new CellsApi();
            var name = name_example;  // string | The workbook name.
            var sheetName = sheetName_example;  // string | The worksheet name.
            var startColumn = 56;  // int? | The begin column index to be operated.
            var totalColumns = 56;  // int? | Number of columns to be operated.
            var folder = folder_example;  // string | The document folder. (optional) 

            try
            {
                // Hide worksheet columns.
                SaaSposeResponse result = apiInstance.CellsPostHideWorksheetColumns(name, sheetName, startColumn, totalColumns, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsApi.CellsPostHideWorksheetColumns: " + e.Message );
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
 **startColumn** | **int?**| The begin column index to be operated. | 
 **totalColumns** | **int?**| Number of columns to be operated. | 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**SaaSposeResponse**](SaaSposeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellsposthideworksheetrows"></a>
# **CellsPostHideWorksheetRows**
> SaaSposeResponse CellsPostHideWorksheetRows (string name, string sheetName, int? startrow, int? totalRows, string folder = null)

Hide worksheet rows.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsPostHideWorksheetRowsExample
    {
        public void main()
        {
            var apiInstance = new CellsApi();
            var name = name_example;  // string | The workbook name.
            var sheetName = sheetName_example;  // string | The worksheet name.
            var startrow = 56;  // int? | The begin row index to be operated.
            var totalRows = 56;  // int? | Number of rows to be operated.
            var folder = folder_example;  // string | The document folder. (optional) 

            try
            {
                // Hide worksheet rows.
                SaaSposeResponse result = apiInstance.CellsPostHideWorksheetRows(name, sheetName, startrow, totalRows, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsApi.CellsPostHideWorksheetRows: " + e.Message );
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
 **startrow** | **int?**| The begin row index to be operated. | 
 **totalRows** | **int?**| Number of rows to be operated. | 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**SaaSposeResponse**](SaaSposeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellspostrowstyle"></a>
# **CellsPostRowStyle**
> SaaSposeResponse CellsPostRowStyle (string name, string sheetName, int? rowIndex, Style style = null, string folder = null)

Set row style.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsPostRowStyleExample
    {
        public void main()
        {
            var apiInstance = new CellsApi();
            var name = name_example;  // string | The workbook name.
            var sheetName = sheetName_example;  // string | The worksheet name.
            var rowIndex = 56;  // int? | The row index.
            var style = new Style(); // Style | Style dto (optional) 
            var folder = folder_example;  // string | The document folder. (optional) 

            try
            {
                // Set row style.
                SaaSposeResponse result = apiInstance.CellsPostRowStyle(name, sheetName, rowIndex, style, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsApi.CellsPostRowStyle: " + e.Message );
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
 **rowIndex** | **int?**| The row index. | 
 **style** | [**Style**](Style.md)| Style dto | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**SaaSposeResponse**](SaaSposeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellspostsetcellhtmlstring"></a>
# **CellsPostSetCellHtmlString**
> CellResponse CellsPostSetCellHtmlString (string name, string sheetName, string cellName, string folder = null)

Set htmlstring value into cell

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsPostSetCellHtmlStringExample
    {
        public void main()
        {
            var apiInstance = new CellsApi();
            var name = name_example;  // string | Workbook name.
            var sheetName = sheetName_example;  // string | Worksheet name.
            var cellName = cellName_example;  // string | The cell name.
            var folder = folder_example;  // string | The workbook folder. (optional) 

            try
            {
                // Set htmlstring value into cell
                CellResponse result = apiInstance.CellsPostSetCellHtmlString(name, sheetName, cellName, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsApi.CellsPostSetCellHtmlString: " + e.Message );
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
 **cellName** | **string**| The cell name. | 
 **folder** | **string**| The workbook folder. | [optional] 

### Return type

[**CellResponse**](CellResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellspostsetcellrangevalue"></a>
# **CellsPostSetCellRangeValue**
> SaaSposeResponse CellsPostSetCellRangeValue (string name, string sheetName, string cellarea, string value, string type, string folder = null)

Set cell range value 

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsPostSetCellRangeValueExample
    {
        public void main()
        {
            var apiInstance = new CellsApi();
            var name = name_example;  // string | Workbook name.
            var sheetName = sheetName_example;  // string | Worksheet name.
            var cellarea = cellarea_example;  // string | Cell area (like \"A1:C2\")
            var value = value_example;  // string | Range value
            var type = type_example;  // string | Value data type (like \"int\")
            var folder = folder_example;  // string | Folder name (optional) 

            try
            {
                // Set cell range value 
                SaaSposeResponse result = apiInstance.CellsPostSetCellRangeValue(name, sheetName, cellarea, value, type, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsApi.CellsPostSetCellRangeValue: " + e.Message );
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
 **cellarea** | **string**| Cell area (like \&quot;A1:C2\&quot;) | 
 **value** | **string**| Range value | 
 **type** | **string**| Value data type (like \&quot;int\&quot;) | 
 **folder** | **string**| Folder name | [optional] 

### Return type

[**SaaSposeResponse**](SaaSposeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellspostsetworksheetcolumnwidth"></a>
# **CellsPostSetWorksheetColumnWidth**
> ColumnResponse CellsPostSetWorksheetColumnWidth (string name, string sheetName, int? columnIndex, double? width, string folder = null)

Set worksheet column width.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsPostSetWorksheetColumnWidthExample
    {
        public void main()
        {
            var apiInstance = new CellsApi();
            var name = name_example;  // string | The workbook name.
            var sheetName = sheetName_example;  // string | The worksheet name.
            var columnIndex = 56;  // int? | The column index.
            var width = 1.2;  // double? | The width.
            var folder = folder_example;  // string | The workbook folder. (optional) 

            try
            {
                // Set worksheet column width.
                ColumnResponse result = apiInstance.CellsPostSetWorksheetColumnWidth(name, sheetName, columnIndex, width, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsApi.CellsPostSetWorksheetColumnWidth: " + e.Message );
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
 **columnIndex** | **int?**| The column index. | 
 **width** | **double?**| The width. | 
 **folder** | **string**| The workbook folder. | [optional] 

### Return type

[**ColumnResponse**](ColumnResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellspostungroupworksheetcolumns"></a>
# **CellsPostUngroupWorksheetColumns**
> SaaSposeResponse CellsPostUngroupWorksheetColumns (string name, string sheetName, int? firstIndex, int? lastIndex, string folder = null)

Ungroup worksheet columns.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsPostUngroupWorksheetColumnsExample
    {
        public void main()
        {
            var apiInstance = new CellsApi();
            var name = name_example;  // string | The workbook name.
            var sheetName = sheetName_example;  // string | The worksheet name.
            var firstIndex = 56;  // int? | The first column index to be operated.
            var lastIndex = 56;  // int? | The last column index to be operated.
            var folder = folder_example;  // string | The document folder. (optional) 

            try
            {
                // Ungroup worksheet columns.
                SaaSposeResponse result = apiInstance.CellsPostUngroupWorksheetColumns(name, sheetName, firstIndex, lastIndex, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsApi.CellsPostUngroupWorksheetColumns: " + e.Message );
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
 **firstIndex** | **int?**| The first column index to be operated. | 
 **lastIndex** | **int?**| The last column index to be operated. | 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**SaaSposeResponse**](SaaSposeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellspostungroupworksheetrows"></a>
# **CellsPostUngroupWorksheetRows**
> SaaSposeResponse CellsPostUngroupWorksheetRows (string name, string sheetName, int? firstIndex, int? lastIndex, bool? isAll = null, string folder = null)

Ungroup worksheet rows.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsPostUngroupWorksheetRowsExample
    {
        public void main()
        {
            var apiInstance = new CellsApi();
            var name = name_example;  // string | The workbook name.
            var sheetName = sheetName_example;  // string | The worksheet name.
            var firstIndex = 56;  // int? | The first row index to be operated.
            var lastIndex = 56;  // int? | The last row index to be operated.
            var isAll = true;  // bool? | Is all row to be operated (optional) 
            var folder = folder_example;  // string | The document folder. (optional) 

            try
            {
                // Ungroup worksheet rows.
                SaaSposeResponse result = apiInstance.CellsPostUngroupWorksheetRows(name, sheetName, firstIndex, lastIndex, isAll, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsApi.CellsPostUngroupWorksheetRows: " + e.Message );
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
 **firstIndex** | **int?**| The first row index to be operated. | 
 **lastIndex** | **int?**| The last row index to be operated. | 
 **isAll** | **bool?**| Is all row to be operated | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**SaaSposeResponse**](SaaSposeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellspostunhideworksheetcolumns"></a>
# **CellsPostUnhideWorksheetColumns**
> SaaSposeResponse CellsPostUnhideWorksheetColumns (string name, string sheetName, int? startcolumn, int? totalColumns, double? width = null, string folder = null)

Unhide worksheet columns.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsPostUnhideWorksheetColumnsExample
    {
        public void main()
        {
            var apiInstance = new CellsApi();
            var name = name_example;  // string | The workbook name.
            var sheetName = sheetName_example;  // string | The worksheet name.
            var startcolumn = 56;  // int? | The begin column index to be operated.
            var totalColumns = 56;  // int? | Number of columns to be operated.
            var width = 1.2;  // double? | The new column width. (optional)  (default to 50.0)
            var folder = folder_example;  // string | The document folder. (optional) 

            try
            {
                // Unhide worksheet columns.
                SaaSposeResponse result = apiInstance.CellsPostUnhideWorksheetColumns(name, sheetName, startcolumn, totalColumns, width, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsApi.CellsPostUnhideWorksheetColumns: " + e.Message );
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
 **startcolumn** | **int?**| The begin column index to be operated. | 
 **totalColumns** | **int?**| Number of columns to be operated. | 
 **width** | **double?**| The new column width. | [optional] [default to 50.0]
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**SaaSposeResponse**](SaaSposeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellspostunhideworksheetrows"></a>
# **CellsPostUnhideWorksheetRows**
> SaaSposeResponse CellsPostUnhideWorksheetRows (string name, string sheetName, int? startrow, int? totalRows, double? height = null, string folder = null)

Unhide worksheet rows.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsPostUnhideWorksheetRowsExample
    {
        public void main()
        {
            var apiInstance = new CellsApi();
            var name = name_example;  // string | The workbook name.
            var sheetName = sheetName_example;  // string | The worksheet name.
            var startrow = 56;  // int? | The begin row index to be operated.
            var totalRows = 56;  // int? | Number of rows to be operated.
            var height = 1.2;  // double? | The new row height. (optional)  (default to 15.0)
            var folder = folder_example;  // string | The document folder. (optional) 

            try
            {
                // Unhide worksheet rows.
                SaaSposeResponse result = apiInstance.CellsPostUnhideWorksheetRows(name, sheetName, startrow, totalRows, height, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsApi.CellsPostUnhideWorksheetRows: " + e.Message );
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
 **startrow** | **int?**| The begin row index to be operated. | 
 **totalRows** | **int?**| Number of rows to be operated. | 
 **height** | **double?**| The new row height. | [optional] [default to 15.0]
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**SaaSposeResponse**](SaaSposeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellspostupdateworksheetcellstyle"></a>
# **CellsPostUpdateWorksheetCellStyle**
> StyleResponse CellsPostUpdateWorksheetCellStyle (string name, string sheetName, string cellName, Style style = null, string folder = null)

Update cell's style.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsPostUpdateWorksheetCellStyleExample
    {
        public void main()
        {
            var apiInstance = new CellsApi();
            var name = name_example;  // string | Workbook name.
            var sheetName = sheetName_example;  // string | Worksheet name.
            var cellName = cellName_example;  // string | The cell name.
            var style = new Style(); // Style | with update style settings. (optional) 
            var folder = folder_example;  // string | The workbook folder. (optional) 

            try
            {
                // Update cell's style.
                StyleResponse result = apiInstance.CellsPostUpdateWorksheetCellStyle(name, sheetName, cellName, style, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsApi.CellsPostUpdateWorksheetCellStyle: " + e.Message );
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
 **cellName** | **string**| The cell name. | 
 **style** | [**Style**](Style.md)| with update style settings. | [optional] 
 **folder** | **string**| The workbook folder. | [optional] 

### Return type

[**StyleResponse**](StyleResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellspostupdateworksheetrangestyle"></a>
# **CellsPostUpdateWorksheetRangeStyle**
> SaaSposeResponse CellsPostUpdateWorksheetRangeStyle (string name, string sheetName, string range, Style style = null, string folder = null)

Update cell's range style.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsPostUpdateWorksheetRangeStyleExample
    {
        public void main()
        {
            var apiInstance = new CellsApi();
            var name = name_example;  // string | Workbook name.
            var sheetName = sheetName_example;  // string | Worksheet name.
            var range = range_example;  // string | The range.
            var style = new Style(); // Style | with update style settings. (optional) 
            var folder = folder_example;  // string | The workbook folder. (optional) 

            try
            {
                // Update cell's range style.
                SaaSposeResponse result = apiInstance.CellsPostUpdateWorksheetRangeStyle(name, sheetName, range, style, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsApi.CellsPostUpdateWorksheetRangeStyle: " + e.Message );
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
 **range** | **string**| The range. | 
 **style** | [**Style**](Style.md)| with update style settings. | [optional] 
 **folder** | **string**| The workbook folder. | [optional] 

### Return type

[**SaaSposeResponse**](SaaSposeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellspostupdateworksheetrow"></a>
# **CellsPostUpdateWorksheetRow**
> RowResponse CellsPostUpdateWorksheetRow (string name, string sheetName, int? rowIndex, double? height = null, string folder = null)

Update worksheet row.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsPostUpdateWorksheetRowExample
    {
        public void main()
        {
            var apiInstance = new CellsApi();
            var name = name_example;  // string | The workbook name.
            var sheetName = sheetName_example;  // string | The worksheet name.
            var rowIndex = 56;  // int? | The row index.
            var height = 1.2;  // double? | The new row height. (optional)  (default to 0.0)
            var folder = folder_example;  // string | The document folder. (optional) 

            try
            {
                // Update worksheet row.
                RowResponse result = apiInstance.CellsPostUpdateWorksheetRow(name, sheetName, rowIndex, height, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsApi.CellsPostUpdateWorksheetRow: " + e.Message );
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
 **rowIndex** | **int?**| The row index. | 
 **height** | **double?**| The new row height. | [optional] [default to 0.0]
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**RowResponse**](RowResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellspostworksheetcellsetvalue"></a>
# **CellsPostWorksheetCellSetValue**
> CellResponse CellsPostWorksheetCellSetValue (string name, string sheetName, string cellName, string value = null, string type = null, string formula = null, string folder = null)

Set cell value.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsPostWorksheetCellSetValueExample
    {
        public void main()
        {
            var apiInstance = new CellsApi();
            var name = name_example;  // string | The document name.
            var sheetName = sheetName_example;  // string | The worksheet name.
            var cellName = cellName_example;  // string | The cell name.
            var value = value_example;  // string | The cell value. (optional) 
            var type = type_example;  // string | The value type. (optional) 
            var formula = formula_example;  // string | Formula for cell (optional) 
            var folder = folder_example;  // string | The document folder. (optional) 

            try
            {
                // Set cell value.
                CellResponse result = apiInstance.CellsPostWorksheetCellSetValue(name, sheetName, cellName, value, type, formula, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsApi.CellsPostWorksheetCellSetValue: " + e.Message );
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
 **cellName** | **string**| The cell name. | 
 **value** | **string**| The cell value. | [optional] 
 **type** | **string**| The value type. | [optional] 
 **formula** | **string**| Formula for cell | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**CellResponse**](CellResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellspostworksheetmerge"></a>
# **CellsPostWorksheetMerge**
> SaaSposeResponse CellsPostWorksheetMerge (string name, string sheetName, int? startRow, int? startColumn, int? totalRows, int? totalColumns, string folder = null)

Merge cells.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsPostWorksheetMergeExample
    {
        public void main()
        {
            var apiInstance = new CellsApi();
            var name = name_example;  // string | The workbook name.
            var sheetName = sheetName_example;  // string | The worksheet name.
            var startRow = 56;  // int? | The start row.
            var startColumn = 56;  // int? | The start column.
            var totalRows = 56;  // int? | The total rows
            var totalColumns = 56;  // int? | The total columns.
            var folder = folder_example;  // string | The workbook folder. (optional) 

            try
            {
                // Merge cells.
                SaaSposeResponse result = apiInstance.CellsPostWorksheetMerge(name, sheetName, startRow, startColumn, totalRows, totalColumns, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsApi.CellsPostWorksheetMerge: " + e.Message );
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
 **startRow** | **int?**| The start row. | 
 **startColumn** | **int?**| The start column. | 
 **totalRows** | **int?**| The total rows | 
 **totalColumns** | **int?**| The total columns. | 
 **folder** | **string**| The workbook folder. | [optional] 

### Return type

[**SaaSposeResponse**](SaaSposeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellspostworksheetunmerge"></a>
# **CellsPostWorksheetUnmerge**
> SaaSposeResponse CellsPostWorksheetUnmerge (string name, string sheetName, int? startRow, int? startColumn, int? totalRows, int? totalColumns, string folder = null)

Unmerge cells.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsPostWorksheetUnmergeExample
    {
        public void main()
        {
            var apiInstance = new CellsApi();
            var name = name_example;  // string | The workbook name.
            var sheetName = sheetName_example;  // string | The worksheet name.
            var startRow = 56;  // int? | The start row.
            var startColumn = 56;  // int? | The start column.
            var totalRows = 56;  // int? | The total rows
            var totalColumns = 56;  // int? | The total columns.
            var folder = folder_example;  // string | The workbook folder. (optional) 

            try
            {
                // Unmerge cells.
                SaaSposeResponse result = apiInstance.CellsPostWorksheetUnmerge(name, sheetName, startRow, startColumn, totalRows, totalColumns, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsApi.CellsPostWorksheetUnmerge: " + e.Message );
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
 **startRow** | **int?**| The start row. | 
 **startColumn** | **int?**| The start column. | 
 **totalRows** | **int?**| The total rows | 
 **totalColumns** | **int?**| The total columns. | 
 **folder** | **string**| The workbook folder. | [optional] 

### Return type

[**SaaSposeResponse**](SaaSposeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellsputinsertworksheetcolumns"></a>
# **CellsPutInsertWorksheetColumns**
> ColumnsResponse CellsPutInsertWorksheetColumns (string name, string sheetName, int? columnIndex, int? columns, bool? updateReference = null, string folder = null)

Insert worksheet columns.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsPutInsertWorksheetColumnsExample
    {
        public void main()
        {
            var apiInstance = new CellsApi();
            var name = name_example;  // string | The workbook name.
            var sheetName = sheetName_example;  // string | The worksheet name.
            var columnIndex = 56;  // int? | The column index.
            var columns = 56;  // int? | The columns.
            var updateReference = true;  // bool? | The update reference. (optional)  (default to true)
            var folder = folder_example;  // string | The workbook folder. (optional) 

            try
            {
                // Insert worksheet columns.
                ColumnsResponse result = apiInstance.CellsPutInsertWorksheetColumns(name, sheetName, columnIndex, columns, updateReference, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsApi.CellsPutInsertWorksheetColumns: " + e.Message );
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
 **columnIndex** | **int?**| The column index. | 
 **columns** | **int?**| The columns. | 
 **updateReference** | **bool?**| The update reference. | [optional] [default to true]
 **folder** | **string**| The workbook folder. | [optional] 

### Return type

[**ColumnsResponse**](ColumnsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellsputinsertworksheetrow"></a>
# **CellsPutInsertWorksheetRow**
> RowResponse CellsPutInsertWorksheetRow (string name, string sheetName, int? rowIndex, string folder = null)

Insert new worksheet row.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsPutInsertWorksheetRowExample
    {
        public void main()
        {
            var apiInstance = new CellsApi();
            var name = name_example;  // string | The workbook name.
            var sheetName = sheetName_example;  // string | The worksheet name.
            var rowIndex = 56;  // int? | The new row index.
            var folder = folder_example;  // string | The document folder. (optional) 

            try
            {
                // Insert new worksheet row.
                RowResponse result = apiInstance.CellsPutInsertWorksheetRow(name, sheetName, rowIndex, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsApi.CellsPutInsertWorksheetRow: " + e.Message );
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
 **rowIndex** | **int?**| The new row index. | 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**RowResponse**](RowResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cellsputinsertworksheetrows"></a>
# **CellsPutInsertWorksheetRows**
> SaaSposeResponse CellsPutInsertWorksheetRows (string name, string sheetName, int? startrow, int? totalRows = null, bool? updateReference = null, string folder = null)

Insert several new worksheet rows.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Example
{
    public class CellsPutInsertWorksheetRowsExample
    {
        public void main()
        {
            var apiInstance = new CellsApi();
            var name = name_example;  // string | The workbook name.
            var sheetName = sheetName_example;  // string | The worksheet name.
            var startrow = 56;  // int? | The begin row index to be operated.
            var totalRows = 56;  // int? | Number of rows to be operated. (optional)  (default to 1)
            var updateReference = true;  // bool? | Indicates if update references in other worksheets. (optional)  (default to true)
            var folder = folder_example;  // string | The document folder. (optional) 

            try
            {
                // Insert several new worksheet rows.
                SaaSposeResponse result = apiInstance.CellsPutInsertWorksheetRows(name, sheetName, startrow, totalRows, updateReference, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CellsApi.CellsPutInsertWorksheetRows: " + e.Message );
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
 **startrow** | **int?**| The begin row index to be operated. | 
 **totalRows** | **int?**| Number of rows to be operated. | [optional] [default to 1]
 **updateReference** | **bool?**| Indicates if update references in other worksheets. | [optional] [default to true]
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**SaaSposeResponse**](SaaSposeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

