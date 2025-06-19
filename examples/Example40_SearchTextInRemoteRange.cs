using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Model;
using Aspose.Cells.Cloud.SDK.Request;
using System;
using System.IO;
using System.Collections.Generic;
using Range = Aspose.Cells.Cloud.SDK.Model.Range;

public static class Example40_SearchTextInRemoteRange
{
    public static void Run()
    {
        CellsApi cellsApi = new CellsApi("xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx", "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
        string remoteFolder = "TestData/In";
        string bookTextXlsx = "BookText.xlsx";

        var request = new SearchContentInRemoteRangeRequest(
             name: bookTextXlsx,
             worksheet: "Sales",
             cellArea: "A1:A10",
             searchText: "Bike",
             ignoringCase: false,
             folder: remoteFolder
        );
        cellsApi.SearchContentInRemoteRange(request);
    }
}