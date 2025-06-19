using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Model;
using Aspose.Cells.Cloud.SDK.Request;
using System;
using System.IO;
using System.Collections.Generic;
using Range = Aspose.Cells.Cloud.SDK.Model.Range;

public static class Example40_SearchSpreadsheetBrokenLinks
{
    public static void Run()
    {
        CellsApi cellsApi = new CellsApi("xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx", "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
        string bookFormulaXlsx = "BookFormula.xlsx";

        var request = new SearchSpreadsheetBrokenLinksRequest(
             spreadsheet: "TestData/" + bookFormulaXlsx
        );
        cellsApi.SearchSpreadsheetBrokenLinks(request);
    }
}