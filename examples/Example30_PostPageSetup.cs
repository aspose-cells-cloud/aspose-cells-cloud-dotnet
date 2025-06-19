using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Model;
using Aspose.Cells.Cloud.SDK.Request;
using System;
using System.IO;
using System.Collections.Generic;
using Range = Aspose.Cells.Cloud.SDK.Model.Range;

public static class Example30_PostPageSetup
{
    public static void Run()
    {
        CellsApi cellsApi = new CellsApi("xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx", "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
        string remoteFolder = "TestData/In";

        string localName = "Book1.xlsx";
        string remoteName = "Book1.xlsx";

        var pageSetup = new PageSetup()
        {
            BlackAndWhite = true,
            CenterHorizontally = true,
            CenterVertically = true
        };
        var request = new PostPageSetupRequest(
            name: remoteName,
            sheetName: "Sheet1",
            pageSetup: pageSetup,
            folder: remoteFolder,
            storageName: ""
        );
        cellsApi.PostPageSetup(request);
    }
}