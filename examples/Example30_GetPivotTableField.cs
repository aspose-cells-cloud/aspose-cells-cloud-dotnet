using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Model;
using Aspose.Cells.Cloud.SDK.Request;
using System;
using System.IO;
using System.Collections.Generic;
using Range = Aspose.Cells.Cloud.SDK.Model.Range;

public static class Example30_GetPivotTableField
{
    public static void Run()
    {
        CellsApi cellsApi = new CellsApi("xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx", "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
        string remoteFolder = "TestData/In";

        string localName = "TestCase.xlsx";
        string remoteName = "TestCase.xlsx";

        var request = new GetPivotTableFieldRequest(
            name: remoteName,
            sheetName: "Sheet4",
            pivotTableIndex: 0,
            pivotFieldIndex: 0,
            pivotFieldType: "Row",
            folder: remoteFolder,
            storageName: ""
        );
        cellsApi.GetPivotTableField(request);
    }
}