using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Model;
using Aspose.Cells.Cloud.SDK.Request;
using System;
using System.IO;
using System.Collections.Generic;
using Range = Aspose.Cells.Cloud.SDK.Model.Range;

public static class Example30_DeleteDecryptWorkbook
{
    public static void Run()
    {
        CellsApi cellsApi = new CellsApi("xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx", "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
        string remoteFolder = "TestData/In";

        string localName = "Book1.xlsx";
        string remoteName = "Book1.xlsx";

        var encryption = new WorkbookEncryptionRequest()
        {
            Password = "123456",
            EncryptionType = "XOR",
            KeyLength = 128
        };
        var request = new DeleteDecryptWorkbookRequest(
            name: remoteName,
            encryption: encryption,
            folder: remoteFolder,
            storageName: ""
        );
        cellsApi.DeleteDecryptWorkbook(request);
    }
}