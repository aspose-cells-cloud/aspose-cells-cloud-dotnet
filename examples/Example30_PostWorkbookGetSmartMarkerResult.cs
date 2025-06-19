using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Model;
using Aspose.Cells.Cloud.SDK.Request;
using System;
using System.IO;
using System.Collections.Generic;
using Range = Aspose.Cells.Cloud.SDK.Model.Range;

public static class Example30_PostWorkbookGetSmartMarkerResult
{
    public static void Run()
    {
        CellsApi cellsApi = new CellsApi("xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx", "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
        string remoteFolder = "TestData/In";

        string localName = "Book1.xlsx";
        string reportDataXML = "ReportData.xml";
        string remoteName = "Book1.xlsx";

        var request = new PostWorkbookGetSmartMarkerResultRequest(
            name: remoteName,
            xmlFile: remoteFolder + "/ReportData.xml",
            folder: remoteFolder,
            outPath: "OutResult/SmartMarkerResult.xlsx",
            storageName: "",
            outStorageName: ""
        );
        cellsApi.PostWorkbookGetSmartMarkerResult(request);
    }
}