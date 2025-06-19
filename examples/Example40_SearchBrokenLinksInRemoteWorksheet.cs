using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Model;
using Aspose.Cells.Cloud.SDK.Request;
using System;
using System.IO;
using System.Collections.Generic;
using Range = Aspose.Cells.Cloud.SDK.Model.Range;

public static class Example40_SearchBrokenLinksInRemoteWorksheet
{
    public static void Run()
    {
        CellsApi cellsApi = new CellsApi("xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx", "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
        string remoteFolder = "TestData/In";
        string bookFormulaXlsx = "BookFormula.xlsx";

        var request = new SearchBrokenLinksInRemoteWorksheetRequest(
             name: bookFormulaXlsx,
             worksheet: "Sheet1",
             folder: remoteFolder
        );
        cellsApi.SearchBrokenLinksInRemoteWorksheet(request);
    }
}