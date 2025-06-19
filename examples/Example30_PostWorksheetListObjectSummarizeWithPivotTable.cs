using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Model;
using Aspose.Cells.Cloud.SDK.Request;
using System;
using System.IO;
using System.Collections.Generic;
using Range = Aspose.Cells.Cloud.SDK.Model.Range;

public static class Example30_PostWorksheetListObjectSummarizeWithPivotTable
{
    public static void Run()
    {
        CellsApi cellsApi = new CellsApi("xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx", "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
        string remoteFolder = "TestData/In";

        string localName = "Book1.xlsx";
        string remoteName = "Book1.xlsx";

        var createPivotTableRequestPivotFieldColumns = new List<int?>()
        {
            2
        };
        var createPivotTableRequestPivotFieldData = new List<int?>()
        {
            1
        };
        var createPivotTableRequestPivotFieldRows = new List<int?>()
        {
            0
        };
        var createPivotTableRequest = new CreatePivotTableRequest()
        {
            DestCellName = "C1",
            Name = "testp",
            SourceData = "=Sheet2!A1:E8",
            UseSameSource = true,
            PivotFieldColumns = createPivotTableRequestPivotFieldColumns,
            PivotFieldData = createPivotTableRequestPivotFieldData,
            PivotFieldRows = createPivotTableRequestPivotFieldRows
        };
        var request = new PostWorksheetListObjectSummarizeWithPivotTableRequest(
            name: remoteName,
            sheetName: "Sheet7",
            listObjectIndex: 0,
            destsheetName: "Sheet2",
            createPivotTableRequest: createPivotTableRequest,
            folder: remoteFolder,
            storageName: ""
        );
        cellsApi.PostWorksheetListObjectSummarizeWithPivotTable(request);
    }
}