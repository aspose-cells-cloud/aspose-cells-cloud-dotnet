using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Model;
using Aspose.Cells.Cloud.SDK.Request;
using System;
using System.IO;
using System.Collections.Generic;
using Range = Aspose.Cells.Cloud.SDK.Model.Range;

public static class Example40_SplitLocalFile
{
    public static void Run()
    {
        CellsApi cellsApi = new CellsApi("xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx", "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
        string book1Xlsx = "Book1.xlsx";
        string outFormat = "PDF";

        var request = new SplitSpreadsheetRequest(
             spreadsheet: "TestData/" + book1Xlsx,
             outFormat: outFormat
        );
        cellsApi.SplitSpreadsheet(request);
    }
}