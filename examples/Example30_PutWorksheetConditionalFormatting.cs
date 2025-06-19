using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Model;
using Aspose.Cells.Cloud.SDK.Request;
using System;
using System.IO;
using System.Collections.Generic;
using Range = Aspose.Cells.Cloud.SDK.Model.Range;

public static class Example30_PutWorksheetConditionalFormatting
{
    public static void Run()
    {
        CellsApi cellsApi = new CellsApi("xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx", "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
        string remoteFolder = "TestData/In";

        string localName = "Book1.xlsx";
        string remoteName = "Book1.xlsx";

        var formatcondition = new FormatCondition()
        {
            Type = "CellValue",
            Operator = "Between",
            Formula1 = "v1",
            Formula2 = "v2"
        };
        var request = new PutWorksheetConditionalFormattingRequest(
            name: remoteName,
            sheetName: "Sheet1",
            formatcondition: formatcondition,
            cellArea: "A1:C10",
            folder: remoteFolder,
            storageName: ""
        );
        cellsApi.PutWorksheetConditionalFormatting(request);
    }
}