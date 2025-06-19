using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Model;
using Aspose.Cells.Cloud.SDK.Request;
using System;
using System.IO;
using System.Collections.Generic;
using Range = Aspose.Cells.Cloud.SDK.Model.Range;

public static class Example40_ConvertChartToImage
{
    public static void Run()
    {
        CellsApi cellsApi = new CellsApi("xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx", "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
        string localName = "EmployeeSalesSummary.xlsx";

        var format = "svg";
        var request = new ConvertChartToImageRequest(
             spreadsheet: "TestData/" + localName,
             worksheet: "Sales",
             chartIndex: 0,
             format: format
        );
        cellsApi.ConvertChartToImage(request);
    }
}