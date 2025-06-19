using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Model;
using Aspose.Cells.Cloud.SDK.Request;
using System;
using System.IO;
using System.Collections.Generic;
using Range = Aspose.Cells.Cloud.SDK.Model.Range;

public static class Example30_PostDigitalSignature
{
    public static void Run()
    {
        CellsApi cellsApi = new CellsApi("xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx", "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
        string remoteFolder = "TestData/In";

        string localName = "Book1.xlsx";
        string roywangPFX = "roywang.pfx";
        string remoteName = "Book1.xlsx";

        var request = new PostDigitalSignatureRequest(
            name: remoteName,
            digitalsignaturefile: remoteFolder + "/roywang.pfx",
            password: "123456",
            folder: remoteFolder,
            storageName: ""
        );
        cellsApi.PostDigitalSignature(request);
    }
}