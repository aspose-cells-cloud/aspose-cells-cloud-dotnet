using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Model;
using Aspose.Cells.Cloud.SDK.Request;
using System;
using System.IO;
using System.Collections.Generic;

CellsApi cellsApi = new CellsApi("xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx", "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
string assemblyTestXlsx = "assemblytest.xlsx";

IDictionary<string, Stream> mapFiles =new Dictionary<string,Stream>(); 
var protectWorkbookRequest = new ProtectWorkbookRequest()
{
    AwaysOpenReadOnly = true,
    EncryptWithPassword = "123456"
};

var request = new PostProtectRequest(
    file:    this.GetLocalFilePath(assemblyTestXlsx) ,
    protectWorkbookRequest: protectWorkbookRequest,
    password: "123456"
);
this.CellsApi.PostProtect(request);
