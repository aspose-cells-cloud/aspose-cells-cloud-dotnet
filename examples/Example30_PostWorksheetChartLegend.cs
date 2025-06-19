using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Model;
using Aspose.Cells.Cloud.SDK.Request;
using System;
using System.IO;
using System.Collections.Generic;
using Range = Aspose.Cells.Cloud.SDK.Model.Range;

public static class Example30_PostWorksheetChartLegend
{
    public static void Run()
    {
        CellsApi cellsApi = new CellsApi("xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx", "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
        string remoteFolder = "TestData/In";

        string localName = "Book1.xlsx";
        string remoteName = "Book1.xlsx";

        var legend = new Legend()
        {
            Position = "Top"
        };
        var request = new PostWorksheetChartLegendRequest(
            name: remoteName,
            sheetName: "Sheet4",
            chartIndex: 0,
            legend: legend,
            folder: remoteFolder,
            storageName: ""
        );
        cellsApi.PostWorksheetChartLegend(request);
    }
}