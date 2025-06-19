using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Model;
using Aspose.Cells.Cloud.SDK.Request;
using System;
using System.IO;
using System.Collections.Generic;
using Range = Aspose.Cells.Cloud.SDK.Model.Range;

public static class Example40_ConvertChartToPdf
{
    public static void Run()
    {
        CellsApi cellsApi = new CellsApi("xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx", "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
        string localName = "EmployeeSalesSummary.xlsx";

        var request = new ConvertChartToPdfRequest(
             spreadsheet: "TestData/" + localName,
             worksheet: "Sales",
             chartIndex: 0
        );
        cellsApi.ConvertChartToPdf(request);
    }
}