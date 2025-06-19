using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Model;
using Aspose.Cells.Cloud.SDK.Request;
using System;
using System.IO;
using System.Collections.Generic;
using Range = Aspose.Cells.Cloud.SDK.Model.Range;

public static class Example30_PostUpdateWorksheetOleObject
{
    public static void Run()
    {
        CellsApi cellsApi = new CellsApi("xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx", "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
        string remoteFolder = "TestData/In";

        string localName = "Book1.xlsx";
        string remoteName = "Book1.xlsx";

        var ole = new OleObject()
        {
            Left = 10,
            Right = 10,
            Height = 90,
            Width = 78
        };
        var request = new PostUpdateWorksheetOleObjectRequest(
            name: remoteName,
            sheetName: "Sheet6",
            oleObjectIndex: 0,
            ole: ole,
            folder: remoteFolder,
            storageName: ""
        );
        cellsApi.PostUpdateWorksheetOleObject(request);
    }
}