using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Model;
using Aspose.Cells.Cloud.SDK.Request;
using System;
using System.IO;
using System.Collections.Generic;
using Range = Aspose.Cells.Cloud.SDK.Model.Range;

public static class Example40_ExportChartAsFormat
{
    public static void Run()
    {
        CellsApi cellsApi = new CellsApi("xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx", "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
        string localName = "EmployeeSalesSummary.xlsx";
        string remoteName = "EmployeeSalesSummary.xlsx";
        string remoteFolder = "TestData/In";

        var format = "svg";
        var request = new ExportChartAsFormatRequest(
             name: localName,
             worksheet: "Sales",
             chartIndex: 0,
             format: format,
             folder: remoteFolder
        );
        cellsApi.ExportChartAsFormat(request);
    }
}