using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Model;
using Aspose.Cells.Cloud.SDK.Request;
using System;
using System.IO;
using System.Collections.Generic;
using Range = Aspose.Cells.Cloud.SDK.Model.Range;

public static class Example30_PostWorksheetSparklineGroup
{
    public static void Run()
    {
        CellsApi cellsApi = new CellsApi("xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx", "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
        string remoteFolder = "TestData/In";

        string localName = "TestCase.xlsx";
        string remoteName = "TestCase.xlsx";

        var sparklineGroup = new SparklineGroup()
        {
            DisplayHidden = true,
            PlotRightToLeft = true
        };
        var request = new PostWorksheetSparklineGroupRequest(
            name: remoteName,
            sheetName: "Sheet1",
            sparklineGroupIndex: 0,
            sparklineGroup: sparklineGroup,
            folder: remoteFolder,
            storageName: ""
        );
        cellsApi.PostWorksheetSparklineGroup(request);
    }
}