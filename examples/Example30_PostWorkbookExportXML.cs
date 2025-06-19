using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Model;
using Aspose.Cells.Cloud.SDK.Request;
using System;
using System.IO;
using System.Collections.Generic;
using Range = Aspose.Cells.Cloud.SDK.Model.Range;

public static class Example30_PostWorkbookExportXML
{
    public static void Run()
    {
        CellsApi cellsApi = new CellsApi("xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx", "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
        string remoteFolder = "TestData/In";

        string localName = "Template.xlsx";
        string remoteName = "Template.xlsx";

        var request = new PostWorkbookExportXMLRequest(
            name: remoteName,
            folder: remoteFolder,
            storageName: ""
        );
        cellsApi.PostWorkbookExportXML(request);
    }
}