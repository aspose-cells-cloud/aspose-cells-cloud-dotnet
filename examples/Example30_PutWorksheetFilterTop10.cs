using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Model;
using Aspose.Cells.Cloud.SDK.Request;
using System;
using System.IO;
using System.Collections.Generic;
using Range = Aspose.Cells.Cloud.SDK.Model.Range;

public static class Example30_PutWorksheetFilterTop10
{
    public static void Run()
    {
        CellsApi cellsApi = new CellsApi("xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx", "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
        string remoteFolder = "TestData/In";

        string localName = "Book1.xlsx";
        string remoteName = "Book1.xlsx";

        var request = new PutWorksheetFilterTop10Request(
            name: remoteName,
            sheetName: "Sheet1",
            range: "A1:B1",
            fieldIndex: 0,
            isTop: true,
            isPercent: true,
            itemCount: 1,
            matchBlanks: false,
            refresh: true,
            folder: remoteFolder,
            storageName: ""
        );
        cellsApi.PutWorksheetFilterTop10(request);
    }
}