using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Model;
using Aspose.Cells.Cloud.SDK.Request;
using System;
using System.IO;
using System.Collections.Generic;
using Range = Aspose.Cells.Cloud.SDK.Model.Range;

public static class Example30_GetWorksheetPivotTableFilter
{
    public static void Run()
    {
        CellsApi cellsApi = new CellsApi("xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx", "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
        string remoteFolder = "TestData/In";

        string localName = "TestCase.xlsx";
        string remoteName = "TestCase.xlsx";

        var request = new GetWorksheetPivotTableFilterRequest(
            name: remoteName,
            sheetName: "Sheet3",
            pivotTableIndex: 0,
            filterIndex: 0,
            folder: remoteFolder,
            storageName: ""
        );
        cellsApi.GetWorksheetPivotTableFilter(request);
    }
}