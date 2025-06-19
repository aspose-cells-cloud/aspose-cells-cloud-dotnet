using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Model;
using Aspose.Cells.Cloud.SDK.Request;
using System;
using System.IO;
using System.Collections.Generic;
using Range = Aspose.Cells.Cloud.SDK.Model.Range;

public static class Example30_PostPivotTableStyle
{
    public static void Run()
    {
        CellsApi cellsApi = new CellsApi("xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx", "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
        string remoteFolder = "TestData/In";

        string localName = "TestCase.xlsx";
        string remoteName = "TestCase.xlsx";

        var styleFont = new Font()
        {
            Size = 16
        };
        var style = new Style()
        {
            Font = styleFont
        };
        var request = new PostPivotTableStyleRequest(
            name: remoteName,
            sheetName: "Sheet4",
            pivotTableIndex: 0,
            style: style,
            needReCalculate: true,
            folder: remoteFolder,
            storageName: ""
        );
        cellsApi.PostPivotTableStyle(request);
    }
}