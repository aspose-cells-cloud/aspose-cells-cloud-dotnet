using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Model;
using Aspose.Cells.Cloud.SDK.Request;
using System;
using System.IO;
using System.Collections.Generic;
using Range = Aspose.Cells.Cloud.SDK.Model.Range;

public static class Example30_PostWorksheetCellsRangeRowHeight
{
    public static void Run()
    {
        CellsApi cellsApi = new CellsApi("xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx", "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
        string remoteFolder = "TestData/In";

        string localName = "Book1.xlsx";
        string remoteName = "Book1.xlsx";

        var range = new Range()
        {
            ColumnCount = 1,
            ColumnWidth = 10.0f,
            FirstRow = 1,
            RowCount = 10
        };
        var request = new PostWorksheetCellsRangeRowHeightRequest(
            name: remoteName,
            sheetName: "Sheet1",
            range: range,
            value: 10.9f,
            folder: remoteFolder,
            storageName: ""
        );
        cellsApi.PostWorksheetCellsRangeRowHeight(request);
    }
}