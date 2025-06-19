using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Model;
using Aspose.Cells.Cloud.SDK.Request;
using System;
using System.IO;
using System.Collections.Generic;
using Range = Aspose.Cells.Cloud.SDK.Model.Range;

public static class Example30_PutPivotTableField
{
    public static void Run()
    {
        CellsApi cellsApi = new CellsApi("xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx", "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
        string remoteFolder = "TestData/In";

        string localName = "TestCase.xlsx";
        string remoteName = "TestCase.xlsx";

        var pivotTableFieldRequestData = new List<int?>()
        {
            0
        };
        var pivotTableFieldRequest = new PivotTableFieldRequest()
        {
            Data = pivotTableFieldRequestData
        };
        var request = new PutPivotTableFieldRequest(
            name: remoteName,
            sheetName: "Sheet4",
            pivotTableIndex: 0,
            pivotFieldType: "Row",
            pivotTableFieldRequest: pivotTableFieldRequest,
            needReCalculate: true,
            folder: remoteFolder,
            storageName: ""
        );
        cellsApi.PutPivotTableField(request);
    }
}