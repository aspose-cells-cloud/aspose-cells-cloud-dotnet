using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Model;
using Aspose.Cells.Cloud.SDK.Request;
using System;
using System.IO;
using System.Collections.Generic;
using Range = Aspose.Cells.Cloud.SDK.Model.Range;

public static class Example30_PostProtect
{
    public static void Run()
    {
        CellsApi cellsApi = new CellsApi("xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx", "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
        IDictionary<string, System.IO.Stream> mapFiles =new Dictionary<string, System.IO.Stream>(); 
        string assemblyTestXlsx = "assemblytest.xlsx";

        var protectWorkbookRequest = new ProtectWorkbookRequest()
        {
            AwaysOpenReadOnly = true,
            EncryptWithPassword = "123456"
        };

        var request = new PostProtectRequest(
            localPath:    assemblyTestXlsx ,
            protectWorkbookRequest: protectWorkbookRequest,
            password: "123456"
        );
        cellsApi.PostProtect(request);
    }
}