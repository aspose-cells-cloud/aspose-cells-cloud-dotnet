using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Model;
using Aspose.Cells.Cloud.SDK.Request;
using System;
using System.IO;
using System.Collections.Generic;

CellsApi cellsApi = new CellsApi("xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx", "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
string needUnlockXlsx = "needUnlock.xlsx";

IDictionary<string, Stream> mapFiles =new Dictionary<string,Stream>(); 
AddFileParameter(needUnlockXlsx,mapFiles);       
var request = new PostUnlockRequest(
    file: mapFiles,
    password: "123456"
);
this.CellsApi.PostUnlock(request);
