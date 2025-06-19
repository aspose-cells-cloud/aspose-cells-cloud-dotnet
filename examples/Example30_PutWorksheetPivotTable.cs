using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Model;
using Aspose.Cells.Cloud.SDK.Request;
using System;
using System.IO;
using System.Collections.Generic;
using Range = Aspose.Cells.Cloud.SDK.Model.Range;

public static class Example30_PutWorksheetPivotTable
{
    public static void Run()
    {
        CellsApi cellsApi = new CellsApi("xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx", "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
        string remoteFolder = "TestData/In";

        string localName = "TestCase.xlsx";
        string remoteName = "TestCase.xlsx";

        var request = new PutWorksheetPivotTableRequest(
            name: remoteName,
            sheetName: "Sheet4",
            folder: remoteFolder,
            sourceData: "=Sheet1!C6:E13",
            destCellName: "C1",
            tableName: "TestPivot",
            useSameSource: true,
            storageName: ""
        );
        cellsApi.PutWorksheetPivotTable(request);
    }
}