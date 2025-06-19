using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Model;
using Aspose.Cells.Cloud.SDK.Request;
using System;
using System.IO;
using System.Collections.Generic;
using Range = Aspose.Cells.Cloud.SDK.Model.Range;

public static class Example30_PostProtectWorkbook
{
    public static void Run()
    {
        CellsApi cellsApi = new CellsApi("xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx", "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
        string remoteFolder = "TestData/In";

        string localName = "Book1.xlsx";
        string remoteName = "Book1.xlsx";

        var protectWorkbookRequest = new ProtectWorkbookRequest()
        {
            EncryptWithPassword = "123456",
            ProtectWorkbookStructure = "ALL"
        };
        var request = new PostProtectWorkbookRequest(
            name: remoteName,
            protectWorkbookRequest: protectWorkbookRequest,
            folder: remoteFolder,
            storageName: ""
        );
        cellsApi.PostProtectWorkbook(request);
    }
}