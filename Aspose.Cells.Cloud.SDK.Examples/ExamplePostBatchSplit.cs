using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Model;
using Aspose.Cells.Cloud.SDK.Request;
using System;
using System.IO;
using System.Collections.Generic;

CellsApi cellsApi = new CellsApi("xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx", "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
string remoteFolder = "TestData/In";

string localBook1 = "Book1.xlsx";
string remoteBook1 = "Book1.xlsx";
string localMyDoc = "myDocument.xlsx";
string remoteMyDoc = "myDocument.xlsx";

this.UploadFile( localBook1, remoteFolder + "/" + remoteBook1, "");
this.UploadFile( localMyDoc, remoteFolder + "/" + remoteMyDoc, "");

var batchSplitRequestMatchCondition = new MatchConditionRequest()
{
    RegexPattern = "(^Book)(.+)(xlsx$)"
};
var batchSplitRequest = new BatchSplitRequest()
{
    SourceFolder = remoteFolder,
    Format = "Pdf",
    OutFolder = "OutResult",
    MatchCondition = batchSplitRequestMatchCondition
};
var request = new PostBatchSplitRequest(
    batchSplitRequest: batchSplitRequest
);
this.CellsApi.PostBatchSplit(request);
