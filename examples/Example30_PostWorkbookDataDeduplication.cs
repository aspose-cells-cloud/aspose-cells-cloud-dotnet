using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Model;
using Aspose.Cells.Cloud.SDK.Request;
using System;
using System.IO;
using System.Collections.Generic;
using Range = Aspose.Cells.Cloud.SDK.Model.Range;

public static class Example30_PostWorkbookDataDeduplication
{
    public static void Run()
    {
        CellsApi cellsApi = new CellsApi("xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx", "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
        string remoteFolder = "TestData/In";

        string localName = "BookCsvDuplicateData.csv";
        string remoteName = "BookCsvDuplicateData.csv";

        var deduplicationRegionRanges = new List<Range>()
        {
        };
        var deduplicationRegion = new DeduplicationRegion()
        {
            Ranges = deduplicationRegionRanges
        };
        var request = new PostWorkbookDataDeduplicationRequest(
            name: remoteName,
            deduplicationRegion: deduplicationRegion,
            folder: remoteFolder,
            storageName: ""
        );
        cellsApi.PostWorkbookDataDeduplication(request);
    }
}