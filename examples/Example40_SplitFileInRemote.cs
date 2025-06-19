using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Model;
using Aspose.Cells.Cloud.SDK.Request;
using System;
using System.IO;
using System.Collections.Generic;
using Range = Aspose.Cells.Cloud.SDK.Model.Range;

public static class Example40_SplitFileInRemote
{
    public static void Run()
    {
        CellsApi cellsApi = new CellsApi("xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx", "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
        string remoteFolder = "TestData/In";
        string book1Xlsx = "Book1.xlsx";
        string outFormat = "PDF";

        var request = new SplitRemoteSpreadsheetRequest(
             name: book1Xlsx,
             folder: remoteFolder,
             outFormat: outFormat,
             outPath: "TestData/Out"
        );
        cellsApi.SplitRemoteSpreadsheet(request);
    }
}