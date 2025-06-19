using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Model;
using Aspose.Cells.Cloud.SDK.Request;
using System;
using System.IO;
using System.Collections.Generic;
using Range = Aspose.Cells.Cloud.SDK.Model.Range;

public static class Example30_PostWorksheetGroupShape
{
    public static void Run()
    {
        CellsApi cellsApi = new CellsApi("xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx", "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
        string remoteFolder = "TestData/In";

        string localName = "Book1.xlsx";
        string remoteName = "Book1.xlsx";

        var listShape = new List<int?>()
        {
            0,
            1
        };
        var request = new PostWorksheetGroupShapeRequest(
            name: remoteName,
            sheetName: "Sheet6",
            listShape: listShape,
            folder: remoteFolder,
            storageName: ""
        );
        cellsApi.PostWorksheetGroupShape(request);
    }
}