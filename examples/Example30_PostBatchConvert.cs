using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Model;
using Aspose.Cells.Cloud.SDK.Request;
using System;
using System.IO;
using System.Collections.Generic;
using Range = Aspose.Cells.Cloud.SDK.Model.Range;

public static class Example30_PostBatchConvert
{
    public static void Run()
    {
        CellsApi cellsApi = new CellsApi("xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx", "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
        string remoteFolder = "TestData/In";

        string localBook1 = "Book1.xlsx";
        string remoteBook1 = "Book1.xlsx";
        string localMyDoc = "myDocument.xlsx";
        string remoteMyDoc = "myDocument.xlsx";

        var batchConvertRequestMatchCondition = new MatchConditionRequest()
        {
            RegexPattern = "(^Book)(.+)(xlsx$)"
        };
        var batchConvertRequest = new BatchConvertRequest()
        {
            SourceFolder = remoteFolder,
            Format = "pdf",
            OutFolder = "OutResult",
            MatchCondition = batchConvertRequestMatchCondition
        };
        var request = new PostBatchConvertRequest(
            batchConvertRequest: batchConvertRequest
        );
        cellsApi.PostBatchConvert(request);
    }
}