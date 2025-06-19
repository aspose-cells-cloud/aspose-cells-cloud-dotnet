using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Model;
using Aspose.Cells.Cloud.SDK.Request;
using System;
using System.IO;
using System.Collections.Generic;
using Range = Aspose.Cells.Cloud.SDK.Model.Range;

public static class Example40_SearchTextInLocalFile
{
    public static void Run()
    {
        CellsApi cellsApi = new CellsApi("xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx", "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
        string bookTextXlsx = "BookText.xlsx";

        var request = new SearchSpreadsheetContentRequest(
             spreadsheet: "TestData/" + bookTextXlsx,
             searchText: "Bike",
             ignoringCase: false
        );
        cellsApi.SearchSpreadsheetContent(request);
    }
}