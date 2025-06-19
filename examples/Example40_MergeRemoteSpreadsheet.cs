using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Model;
using Aspose.Cells.Cloud.SDK.Request;
using System;
using System.IO;
using System.Collections.Generic;
using Range = Aspose.Cells.Cloud.SDK.Model.Range;

public static class Example40_MergeRemoteSpreadsheet
{
    public static void Run()
    {
        CellsApi cellsApi = new CellsApi("xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx", "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
        string remoteFolder = "TestData/In";
        string book1Xlsx = "Book1.xlsx";
        string bookTextXlsx = "BookText.xlsx";

        var request = new MergeRemoteSpreadsheetRequest(
             name: bookTextXlsx,
             mergedSpreadsheet: remoteFolder + "/" + book1Xlsx,
             folder: remoteFolder
        );
        cellsApi.MergeRemoteSpreadsheet(request);
    }
}