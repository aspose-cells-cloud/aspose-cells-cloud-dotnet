using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Model;
using Aspose.Cells.Cloud.SDK.Request;
using System;
using System.IO;
using System.Collections.Generic;
using Range = Aspose.Cells.Cloud.SDK.Model.Range;

public static class Example30_PostWorkbookName
{
    public static void Run()
    {
        CellsApi cellsApi = new CellsApi("xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx", "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
        string remoteFolder = "TestData/In";

        string localName = "Book1.xlsx";
        string remoteName = "Book1.xlsx";

        var newName = new Name()
        {
            Text = "name_1804",
            Comment = "KeepSourceFormatting",
            RefersTo = "=Sheet1!$I$4"
        };
        var request = new PostWorkbookNameRequest(
            name: remoteName,
            nameName: "Name_2",
            newName: newName,
            folder: remoteFolder,
            storageName: ""
        );
        cellsApi.PostWorkbookName(request);
    }
}