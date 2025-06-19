using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Model;
using Aspose.Cells.Cloud.SDK.Request;
using System;
using System.IO;
using System.Collections.Generic;
using Range = Aspose.Cells.Cloud.SDK.Model.Range;

public static class Example30_PostWorksheetCellsRangeSort
{
    public static void Run()
    {
        CellsApi cellsApi = new CellsApi("xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx", "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
        string remoteFolder = "TestData/In";

        string localName = "Group.xlsx";
        string remoteName = "Group.xlsx";

        var rangeSortRequestDataSorter = new DataSorter()
        {
            CaseSensitive = true
        };
        var rangeSortRequestCellArea = new Range()
        {
            ColumnCount = 3,
            FirstColumn = 0,
            FirstRow = 0,
            RowCount = 15
        };
        var rangeSortRequest = new RangeSortRequest()
        {
            DataSorter = rangeSortRequestDataSorter,
            CellArea = rangeSortRequestCellArea
        };
        var request = new PostWorksheetCellsRangeSortRequest(
            name: remoteName,
            sheetName: "book1",
            rangeSortRequest: rangeSortRequest,
            folder: remoteFolder,
            storageName: ""
        );
        cellsApi.PostWorksheetCellsRangeSort(request);
    }
}