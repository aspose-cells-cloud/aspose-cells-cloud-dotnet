using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Model;
using Aspose.Cells.Cloud.SDK.Request;
using System;
using System.IO;
using System.Collections.Generic;
using Range = Aspose.Cells.Cloud.SDK.Model.Range;

public static class Example30_PostWorksheetChart
{
    public static void Run()
    {
        CellsApi cellsApi = new CellsApi("xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx", "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
        string remoteFolder = "TestData/In";

        string localName = "Book1.xlsx";
        string remoteName = "Book1.xlsx";

        var chart = new Chart()
        {
            ShowLegend = true,
            ShowDataTable = true
        };
        var request = new PostWorksheetChartRequest(
            name: remoteName,
            sheetName: "Sheet4",
            chartIndex: 0,
            chart: chart,
            folder: remoteFolder,
            storageName: ""
        );
        cellsApi.PostWorksheetChart(request);
    }
}