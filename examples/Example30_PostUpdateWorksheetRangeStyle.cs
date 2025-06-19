using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Model;
using Aspose.Cells.Cloud.SDK.Request;
using System;
using System.IO;
using System.Collections.Generic;
using Range = Aspose.Cells.Cloud.SDK.Model.Range;

public static class Example30_PostUpdateWorksheetRangeStyle
{
    public static void Run()
    {
        CellsApi cellsApi = new CellsApi("xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx", "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
        string remoteFolder = "TestData/In";

        string localName = "Book1.xlsx";
        string remoteName = "Book1.xlsx";

        var styleFont = new Font()
        {
            Size = 16
        };
        var style = new Style()
        {
            Font = styleFont
        };
        var request = new PostUpdateWorksheetRangeStyleRequest(
            name: remoteName,
            sheetName: "Sheet1",
            range: "A1:C10",
            style: style,
            folder: remoteFolder,
            storageName: ""
        );
        cellsApi.PostUpdateWorksheetRangeStyle(request);
    }
}