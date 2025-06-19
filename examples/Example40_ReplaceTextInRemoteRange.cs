using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Model;
using Aspose.Cells.Cloud.SDK.Request;
using System;
using System.IO;
using System.Collections.Generic;
using Range = Aspose.Cells.Cloud.SDK.Model.Range;

public static class Example40_ReplaceTextInRemoteRange
{
    public static void Run()
    {
        CellsApi cellsApi = new CellsApi("xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx", "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
        string remoteFolder = "TestData/In";
        string bookTextXlsx = "BookText.xlsx";

        var request = new ReplaceContentInRemoteRangeRequest(
             name: bookTextXlsx,
             searchText: "Bike",
             replaceText: "****",
             worksheet: "Sales",
             cellArea: "A1:A10",
             folder: remoteFolder
        );
        cellsApi.ReplaceContentInRemoteRange(request);
    }
}