using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Model;
using Aspose.Cells.Cloud.SDK.Request;
using System;
using System.IO;
using System.Collections.Generic;
using Range = Aspose.Cells.Cloud.SDK.Model.Range;

public static class Example30_DeleteWorksheetFreezePanes
{
    public static void Run()
    {
        CellsApi cellsApi = new CellsApi("xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx", "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
        string remoteFolder = "TestData/In";

        string localName = "Book1.xlsx";
        string remoteName = "Book1.xlsx";

        var request = new DeleteWorksheetFreezePanesRequest(
            name: remoteName,
            sheetName: "Sheet1",
            row: 1,
            column: 1,
            freezedRows: 4,
            freezedColumns: 5,
            folder: remoteFolder,
            storageName: ""
        );
        cellsApi.DeleteWorksheetFreezePanes(request);
    }
}