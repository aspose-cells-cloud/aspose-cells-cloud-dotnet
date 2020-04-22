# .NET REST API for Spreadsheet Processing in Cloud

This Cloud SDK enhances your C#, ASP.NET, & other .NET cloud-based apps to [process & manipulate Microsoft Excel spreadsheets](https://products.aspose.cloud/cells/net) in the cloud, without MS Office.

## Spreadsheet Processing Features

- Add, update or delete charts, worksheet pictures, shapes, hyperlinks & validations.
- Add or remove cells area for conditional formatting, or OleObjects from Excel worksheets.
- Insert or delete, horizontal or vertical page breaks
- Add ListObject at a specific place within an Excel file & convert them to a range of cells.
- Delete specific or all ListObjects in a worksheet or summarize its data with pivot table.
- Apply custom criteria to list filters of various types.
- Get, update, show or hide chart legend & titles.
- Manipulate page setup, header & footer.
- Create, update, fetch or delete document properties.
- Fetch the required shape from worksheet.
- Load & Process Excel Spreadsheets via Cloud SDK.
- Cloud SDK to Read & Process Excel Worksheets.
- Leverage the Power of Pivot Tables & Ranges.

## Feature & Enhancements in Version 20.4

- Support to export area or page of sheet to JPEG.
- Support to add background for workbook.
- Enhancement for splitting workbook.
- Enhancement for create workbook.

## Read & Write Spreadsheet Formats

**Microsoft Excel:** XLS, XLSX, XLSB, XLSM, XLT, XLTX, XLTM
**OpenOffice:** ODS
**SpreadsheetML:** XML
**Text:** CSV, TSV, TXT (TabDelimited)
**Web:** HTML, MHTML
**PDF**

## Save Spreadsheet As

DIF, HTML, MHTML,PNG,JPG, TIFF, XPS, SVG, MD (Markdown), ODS ,xlsx,xls,xlsb, PDF,XML,TXT,CSV

## Read Spreadsheet Formats

SXC, FODS

## Storage API Support

Since version 19.9, SDK includes support of storage operations for better user experience and unification, so now there's no need to use 2 different SDKs!

It gives you an ability to:

- Upload, download, copy, move and delete files, including versions handling (if you are using Cloud storage that supports this feature - true by default).
- Create, copy, move and delete folders.
- Copy and move files and folders across separate storages in scope of a single operation.
- Check if certain file, folder or storage exists.


## Getting Started with Aspose.Cells Cloud SDK for .NET

You do not need to install anything to get started with Aspose.Cells Cloud SDK for .NET. Just create an account at [Aspose for Cloud](https://dashboard.aspose.cloud/#/apps) and get your application information.

Simply execute `Install-Package Aspose.Cells-Cloud` from the Package Manager Console in Visual Studio to fetch & reference Aspose.Cells assembly in your project. If you already have Aspose.Cells Cloud SDK for .NET and want to upgrade it, please execute `Update-Package Aspose.Cells-Cloud` to get the latest version.

Please check the [GitHub Repository](https://github.com/aspose-cells-cloud/aspose-cells-cloud-dotnet) for other common usage scenarios.

## Using C# to Add a New Worksheet to an Excel File

The following code snippet demonstrates how to add a new worksheet to a Microsoft Excel document using C# code:

```csharp
CellsApi cellsApi =CellsApi(clientId, clientSecret);;
string name = "Input.xlsx";
string sheetName = "Sheet1";
int? position = 1;
string sheettype = "VB";
string folder = null;
UpdateDataFile(folder, name);
var response = cellsApi.CellsWorksheetsPutAddNewWorksheet(name, sheetName, position, sheettype, folder);
```

## Using C# to Convert an Excel File to another File Format

The following code example elaborates how you can use C# code to convert an Excel document to another file format in the cloud:

```csharp
// Upload source file to aspose cloud storage
cellsApi.UploadFile(folder + @"\" + filename, stream);

// Invoke Aspose.Cells Cloud SDK API to convert excel workbook to different format
SaveResponse apiResponse = cellsApi.CellsSaveAsPostDocumentSaveAs(name, saveOptions, newfilename, isAutoFitRows, isAutoFitColumns, folder);
```
## Tests

[Tests](https://github.com/aspose-cells-cloud/aspose-cells-cloud-dotnet/tree/master/Aspose.Cells.Cloud.SDK.Test) contain various examples of using the SDK.

## Licensing

All Aspose.Cells Cloud SDKs are licensed under [MIT License](https://github.com/aspose-cells-cloud/aspose-cells-cloud-dotnet/blob/master/LICENSE).

[Product Page](https://products.aspose.cloud/cells/ruby) | [Documentation](https://docs.aspose.cloud/display/cellscloud/Home) | [Live Demo](https://products.aspose.app/cells/family) | [API Reference](https://apireference.aspose.cloud/cells/) | [Code Samples](https://github.com/aspose-cells-cloud/aspose-cells-cloud-ruby) | [Blog](https://blog.aspose.cloud/category/cells/) | [Free Support](https://forum.aspose.cloud/c/cells) | [Free Trial](https://dashboard.aspose.cloud/#/apps)
