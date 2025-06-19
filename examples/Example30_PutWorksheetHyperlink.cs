using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Model;
using Aspose.Cells.Cloud.SDK.Request;
using System;
using System.IO;
using System.Collections.Generic;
using Range = Aspose.Cells.Cloud.SDK.Model.Range;

public static class Example30_PutWorksheetHyperlink
{
    public static void Run()
    {
        CellsApi cellsApi = new CellsApi("xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx", "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
        string remoteFolder = "TestData/In";

        string localName = "Book1.xlsx";
        string remoteName = "Book1.xlsx";

        var request = new PutWorksheetHyperlinkRequest(
            name: remoteName,
            sheetName: "Sheet1",
            firstRow: 1,
            firstColumn: 1,
            totalRows: 2,
            totalColumns: 3,
            address: "https://products.aspose.cloud/cells/",
            folder: remoteFolder,
            storageName: ""
        );
        cellsApi.PutWorksheetHyperlink(request);
    }
}