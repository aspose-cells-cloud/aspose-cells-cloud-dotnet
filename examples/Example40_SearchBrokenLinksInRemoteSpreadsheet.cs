using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Model;
using Aspose.Cells.Cloud.SDK.Request;
using System;
using System.IO;
using System.Collections.Generic;
using Range = Aspose.Cells.Cloud.SDK.Model.Range;

public static class Example40_SearchBrokenLinksInRemoteSpreadsheet
{
    public static void Run()
    {
        CellsApi cellsApi = new CellsApi("xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx", "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
        string remoteFolder = "TestData/In";
        string bookFormulaXlsx = "BookFormula.xlsx";

        var request = new SearchBrokenLinksInRemoteSpreadsheetRequest(
             name: bookFormulaXlsx,
             folder: remoteFolder
        );
        cellsApi.SearchBrokenLinksInRemoteSpreadsheet(request);
    }
}