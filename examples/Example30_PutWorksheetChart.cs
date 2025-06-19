using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Model;
using Aspose.Cells.Cloud.SDK.Request;
using System;
using System.IO;
using System.Collections.Generic;
using Range = Aspose.Cells.Cloud.SDK.Model.Range;

public static class Example30_PutWorksheetChart
{
    public static void Run()
    {
        CellsApi cellsApi = new CellsApi("xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx", "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
        string remoteFolder = "TestData/In";

        string localName = "Book1.xlsx";
        string remoteName = "Book1.xlsx";

        var request = new PutWorksheetChartRequest(
            name: remoteName,
            sheetName: "Sheet4",
            chartType: "Pie",
            upperLeftRow: 5,
            upperLeftColumn: 5,
            lowerRightRow: 10,
            lowerRightColumn: 10,
            area: "C7:D11",
            isVertical: true,
            title: "Aspose Chart",
            folder: remoteFolder,
            storageName: ""
        );
        cellsApi.PutWorksheetChart(request);
    }
}