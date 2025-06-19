using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Model;
using Aspose.Cells.Cloud.SDK.Request;
using System;
using System.IO;
using System.Collections.Generic;
using Range = Aspose.Cells.Cloud.SDK.Model.Range;

public static class Example30_PutWorksheetFormatConditionCondition
{
    public static void Run()
    {
        CellsApi cellsApi = new CellsApi("xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx", "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
        string remoteFolder = "TestData/In";

        string localName = "Book1.xlsx";
        string remoteName = "Book1.xlsx";

        var request = new PutWorksheetFormatConditionConditionRequest(
            name: remoteName,
            sheetName: "Sheet1",
            index: 0,
            type: "CellValue",
            operatorType: "Between",
            formula1: "v1",
            formula2: "v2",
            folder: remoteFolder,
            storageName: ""
        );
        cellsApi.PutWorksheetFormatConditionCondition(request);
    }
}