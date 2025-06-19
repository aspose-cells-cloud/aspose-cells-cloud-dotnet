using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Model;
using Aspose.Cells.Cloud.SDK.Request;
using System;
using System.IO;
using System.Collections.Generic;
using Range = Aspose.Cells.Cloud.SDK.Model.Range;

public static class Example30_PutWorksheetListObject
{
    public static void Run()
    {
        CellsApi cellsApi = new CellsApi("xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx", "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
        string remoteFolder = "TestData/In";

        string localName = "Book1.xlsx";
        string remoteName = "Book1.xlsx";

        var request = new PutWorksheetListObjectRequest(
            name: remoteName,
            sheetName: "Sheet7",
            startRow: 1,
            startColumn: 1,
            endRow: 6,
            endColumn: 6,
            folder: remoteFolder,
            hasHeaders: true,
            displayName: "true",
            showTotals: false,
            storageName: ""
        );
        cellsApi.PutWorksheetListObject(request);
    }
}