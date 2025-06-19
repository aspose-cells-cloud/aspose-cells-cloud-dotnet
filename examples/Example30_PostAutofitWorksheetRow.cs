using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Model;
using Aspose.Cells.Cloud.SDK.Request;
using System;
using System.IO;
using System.Collections.Generic;
using Range = Aspose.Cells.Cloud.SDK.Model.Range;

public static class Example30_PostAutofitWorksheetRow
{
    public static void Run()
    {
        CellsApi cellsApi = new CellsApi("xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx", "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
        string remoteFolder = "TestData/In";

        string localName = "Book1.xlsx";
        string remoteName = "Book1.xlsx";

        var request = new PostAutofitWorksheetRowRequest(
            name: remoteName,
            sheetName: "Sheet1",
            rowIndex: 1,
            firstColumn: 1,
            lastColumn: 8,
            folder: remoteFolder,
            storageName: "",
            rowCount: 1
        );
        cellsApi.PostAutofitWorksheetRow(request);
    }
}