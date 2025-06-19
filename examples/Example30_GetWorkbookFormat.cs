using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Model;
using Aspose.Cells.Cloud.SDK.Request;
using System;
using System.IO;
using System.Collections.Generic;
using Range = Aspose.Cells.Cloud.SDK.Model.Range;

public static class Example30_GetWorkbookFormat
{
    public static void Run()
    {
        CellsApi cellsApi = new CellsApi("xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx", "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
        string localName = "Book1.xlsx";
        string remoteName = "Book1.xlsx";
        string remoteFolder = "TestData/In";

        var format = "csv";
        var request = new GetWorkbookRequest(
            name: remoteName,
            format: format,
            folder: remoteFolder
        );
        cellsApi.GetWorkbook(request);
    }
}