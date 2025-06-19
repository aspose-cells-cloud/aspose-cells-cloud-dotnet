using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Model;
using Aspose.Cells.Cloud.SDK.Request;
using System;
using System.IO;
using System.Collections.Generic;
using Range = Aspose.Cells.Cloud.SDK.Model.Range;

public static class Example30_PostWorksheetHyperlink
{
    public static void Run()
    {
        CellsApi cellsApi = new CellsApi("xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx", "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
        string remoteFolder = "TestData/In";

        string localName = "Book1.xlsx";
        string remoteName = "Book1.xlsx";

        var hyperlink = new Hyperlink()
        {
            Address = "https://products.aspose.cloud/cells/"
        };
        var request = new PostWorksheetHyperlinkRequest(
            name: remoteName,
            sheetName: "Sheet1",
            hyperlinkIndex: 0,
            hyperlink: hyperlink,
            folder: remoteFolder,
            storageName: ""
        );
        cellsApi.PostWorksheetHyperlink(request);
    }
}