using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Model;
using Aspose.Cells.Cloud.SDK.Request;
using System;
using System.IO;
using System.Collections.Generic;
using Range = Aspose.Cells.Cloud.SDK.Model.Range;

public static class Example30_DeleteWorksheetDateFilter
{
    public static void Run()
    {
        CellsApi cellsApi = new CellsApi("xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx", "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
        string remoteFolder = "TestData/In";

        string localName = "Book1.xlsx";
        string remoteName = "Book1.xlsx";

        var request = new DeleteWorksheetDateFilterRequest(
            name: remoteName,
            sheetName: "Sheet1",
            fieldIndex: 0,
            dateTimeGroupingType: "Year",
            year: 1920,
            folder: remoteFolder,
            storageName: ""
        );
        cellsApi.DeleteWorksheetDateFilter(request);
    }
}