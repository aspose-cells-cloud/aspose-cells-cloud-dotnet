using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Model;
using Aspose.Cells.Cloud.SDK.Request;
using System;
using System.IO;
using System.Collections.Generic;
using Range = Aspose.Cells.Cloud.SDK.Model.Range;

public static class Example30_PostWorksheetListObjectRemoveDuplicates
{
    public static void Run()
    {
        CellsApi cellsApi = new CellsApi("xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx", "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
        string remoteFolder = "TestData/In";

        string localName = "TestTables.xlsx";
        string remoteName = "TestTables.xlsx";

        var request = new PostWorksheetListObjectRemoveDuplicatesRequest(
            name: remoteName,
            sheetName: "Sheet2",
            listObjectIndex: 0,
            folder: remoteFolder,
            storageName: ""
        );
        cellsApi.PostWorksheetListObjectRemoveDuplicates(request);
    }
}