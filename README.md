![Nuget](https://img.shields.io/nuget/v/Aspose.Cells-Cloud) ![Nuget](https://img.shields.io/nuget/dt/Aspose.Cells-Cloud) ![](https://img.shields.io/badge/REST%20API-v3.0-lightgrey) [![GitHub license](https://img.shields.io/github/license/aspose-cells-cloud/aspose-cells-cloud-dotnet)](https://github.com/aspose-cells-cloud/aspose-cells-cloud-dotnet/blob/master/LICENSE) ![GitHub commits since latest release (by date)](https://img.shields.io/github/commits-since/aspose-cells-cloud/aspose-cells-cloud-dotnet/23.6)

# .NET SDK for Spreadsheet Processing in the Cloud

The Cloud SDK enhances your C#, ASP.NET, & other .NET-based cloud apps to [process & manipulate Microsoft Excel spreadsheets](https://products.aspose.cloud/cells/net) in the Cloud.

## Cloud Spreadsheet Processor in a Nutshell

- Create spreadsheets via APIs or Smart Marker templates.
- Load & process Excel Spreadsheets via Cloud SDK.
- Add, update or delete charts, worksheet pictures, shapes, hyperlinks & validations.
- Add or remove cells area for conditional formatting, or OleObjects from Excel worksheets.
- [Insert or delete, horizontal or vertical page breaks](https://docs.aspose.cloud/cells/working-with-pagebreaks/).
- Add ListObject at a specific place within an Excel file & convert them to a range of cells.
- Delete specific or all ListObjects in a worksheet or summarize its data with pivot table.
- Apply custom criteria to list filters of various types.
- Get, update, show or hide chart legend & titles.
- Manipulate page setup, header & footer.
- Create, update, fetch or delete document properties.
- Fetch the required shape from worksheet.
- [Leverage the power of Pivot Tables](https://docs.aspose.cloud/cells/working-with-pivot-tables/) & Ranges.


## Feature & Enhancements in Version 23.6

- Support to batch lock multi-files.
- Support to batch unlock multi-files.
- Support to protect lock multi-files.
- Support to split lock multi-files.
- Fix put document property api..
 
## Read & Write Spreadsheet Formats

**Microsoft Excel:** XLS, XLSX, XLSB, XLSM, XLT, XLTX, XLTM
**OpenOffice:** ODS
**SpreadsheetML:** XML
**Text:** CSV, TSV, TXT (TabDelimited)
**Web:** HTML, MHTML
**PDF**

## Save Spreadsheet As

DIF, HTML, MHTML, PNG, JPG, TIFF, XPS, SVG, MD (Markdown), ODS, XLSX, XLS, XLSB, PDF, XML, TXT, CSV

## Read Other Formats

SXC, FODS

## Integrated Storage API

Since version 19.9, the SDK includes support of storage operations for better user experience and unification, so now there's no need to use 2 different SDKs!

It gives you an ability to:

- Upload, download, copy, move and delete files, including versions handling (if you are using Cloud storage that supports this feature - true by default).
- Create, copy, move and delete folders.
- Copy and move files and folders across separate storages in scope of a single operation.
- Check if certain file, folder or storage exists.


## Get Started with Aspose.Cells Cloud SDK for .NET

You do not need to install anything to get started with Aspose.Cells Cloud SDK for .NET. Just create an account at [Aspose for Cloud](https://dashboard.aspose.cloud/#/apps) and get your application information.

Next, execute `Install-Package Aspose.Cells-Cloud` from the Package Manager Console in Visual Studio to fetch & reference Aspose.Cells Cloud SDK assembly in your project. If you already have Aspose.Cells Cloud SDK for .NET and want to upgrade it, please execute `Update-Package Aspose.Cells-Cloud` to get the latest version.

## Add a Worksheet to an Excel File in the Cloud

The following code snippet demonstrates how to add a new worksheet to a Microsoft Excel document using C# code:

```csharp
CellsApi cellsApi =CellsApi(clientId, clientSecret);
string localName = "Book1.xlsx";
string remoteName = "Book1.xlsx";

this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

var request = new PutAddNewWorksheetRequest(
    name: remoteName,
    sheetName: "Sheet1",
    position: 0,
    sheettype: "VB",
    folder: remoteFolder,
    storageName: ""
);
cellsApi.PutAddNewWorksheet(request);

```

## Convert Excel Files via C# Code

The following code example elaborates Aspose.Cells REST API to convert an Excel file to another format in the cloud:

```csharp
CellsApi cellsApi =CellsApi(clientId, clientSecret);
// Upload source file to aspose cloud storage
string localName = "Book1.xlsx";
string remoteName = "Book1.xlsx";

this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

var saveOptions = new PdfSaveOptions()
{
    SaveFormat = format
};
var request = new PostWorkbookSaveAsRequest(
    name: remoteName,
    newfilename: newfilename,
    saveOptions: saveOptions,
    folder: remoteFolder
);
cellsApi.PostWorkbookSaveAs(request);
```
## Tests

[Tests](https://github.com/aspose-cells-cloud/aspose-cells-cloud-dotnet/tree/master/Aspose.Cells.Cloud.SDK.Test) contain various examples of using the SDK.

## Aspose.Cells Cloud SDKs in Popular Languages

| Java | PHP | Python | Ruby | Node.js | Android | Swift | Perl | GO |
|---|---|---|---|---|---|---|---|---|
| [GitHub](https://github.com/aspose-cells-cloud/aspose-cells-cloud-java) | [GitHub](https://github.com/aspose-cells-cloud/aspose-cells-cloud-php) | [GitHub](https://github.com/aspose-cells-cloud/aspose-cells-cloud-python) | [GitHub](https://github.com/aspose-cells-cloud/aspose-cells-cloud-ruby)  | [GitHub](https://github.com/aspose-cells-cloud/aspose-cells-cloud-node) | [GitHub](https://github.com/aspose-cells-cloud/aspose-cells-cloud-android)  | [GitHub](https://github.com/aspose-cells-cloud/aspose-cells-cloud-swift) | [GitHub](https://github.com/aspose-cells-cloud/aspose-cells-cloud-perl) | [GitHub](https://github.com/aspose-cells-cloud/aspose-cells-cloud-go) |
| [Maven](https://repository.aspose.cloud/webapp/#/artifacts/browse/tree/General/repo/com/aspose/aspose-cells-cloud) | [Composer](https://packagist.org/packages/aspose/cells-sdk-php) | [PIP](https://pypi.org/project/asposecellscloud/) | [GEM](https://rubygems.org/gems/aspose_cells_cloud)  | [NPM](https://www.npmjs.com/package/asposecellscloud) | [Maven](https://repository.aspose.cloud/webapp/#/artifacts/browse/tree/General/repo/com/aspose/aspose-cells-cloud-android) | [POD](https://cocoapods.org/pods/AsposeCellsCloud) |  [CPAN](https://metacpan.org/release/AsposeCellsCloud-CellsApi) | [GO](https://pkg.go.dev/github.com/aspose-cells-cloud/aspose-cells-cloud-go/v20?tab=overview) |

[Product Page](https://products.aspose.cloud/cells/net) | [Documentation](https://docs.aspose.cloud/cells/) | [Live Demo](https://products.aspose.app/cells/family) | [API Reference](https://apireference.aspose.cloud/cells/) | [Code Samples](https://github.com/aspose-cells-cloud/aspose-cells-cloud-dotnet/tree/master/Examples) | [Blog](https://blog.aspose.cloud/category/cells/) | [Free Support](https://forum.aspose.cloud/c/cells) | [Free Trial](https://dashboard.aspose.cloud/#/apps)

