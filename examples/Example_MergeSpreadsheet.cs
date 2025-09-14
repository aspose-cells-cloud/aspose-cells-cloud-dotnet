public static class Example_MergeSpreadsheet
{
    public static void Run()
    {
        MergedLocalFiles();
        MergeRemoteSpreadsheet();
        MergeSpreadsheetInRemoteFolder();
    }

    private static void MergedLocalFiles()
    {
        // Get your Client ID and Client Secret from https://dashboard.aspose.cloud (free registration is required).
        var cellsApi = new Aspose.Cells.Cloud.SDK.Api.CellsApi(System.Environment.GetEnvironmentVariable("ProductClientId"), System.Environment.GetEnvironmentVariable("ProductClientSecret"));
        // Build merge request parameters 
        var request = new Aspose.Cells.Cloud.SDK.Request.MergeSpreadsheetsRequest();
        IDictionary<string, System.IO.Stream> mapFiles = new Dictionary<string, System.IO.Stream>();
        mapFiles.Add("Book1.xlsx", File.OpenRead(@"c:\testdata\Book1.xlsx"));
        mapFiles.Add("Book2.xlsx", File.OpenRead(@"c:\testdata\Book2.xlsx"));
        request.Spreadsheet = mapFiles;
        request.outFormat = "pdf";
        cellsApi.MergeSpreadsheets(request, "MergedResultFile.pdf");
    }

    private static void MergeRemoteSpreadsheet()
    {
        // Get your Client ID and Client Secret from https://dashboard.aspose.cloud (free registration is required).
        var cellsApi = new Aspose.Cells.Cloud.SDK.Api.CellsApi(System.Environment.GetEnvironmentVariable("ProductClientId"), System.Environment.GetEnvironmentVariable("ProductClientSecret"));
        // Build merge request parameters 
        var request = new Aspose.Cells.Cloud.SDK.Request.MergeSpreadsheetsInRemoteFolderRequest();
        // Storage directory that needs to merge files
        request.folder = "RemoteFolder";
        request.fileMatchExpression = "*xlsx$";
        request.outFormat = "pdf";
        cellsApi.MergeSpreadsheetsInRemoteFolder(request, "MergedResultOutPutToLocalFile.pdf");
    }

    private static void MergeSpreadsheetInRemoteFolder()
    {
        // Get your Client ID and Client Secret from https://dashboard.aspose.cloud (free registration is required).
        var cellsApi = new Aspose.Cells.Cloud.SDK.Api.CellsApi(System.Environment.GetEnvironmentVariable("ProductClientId"), System.Environment.GetEnvironmentVariable("ProductClientSecret"));
        // Build merge request parameters 
        var request = new Aspose.Cells.Cloud.SDK.Request.MergeRemoteSpreadsheetRequest();

        request.name = "Book1.xlsx";
        request.folder = "RemoteFolder1";
        request.mergedSpreadsheet = "RemoteFolder2/Book2.xlsx";
        request.outFormat = "pdf";
        cellsApi.MergeRemoteSpreadsheet(request, "MergedResultOutPutToLocalFile.pdf");
    }
}