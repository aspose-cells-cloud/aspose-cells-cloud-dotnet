using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Model;
using Aspose.Cells.Cloud.SDK.Request;
using System;
using System.IO;
using System.Collections.Generic;

CellsApi cellsApi = new CellsApi("xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx", "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
string book1Xlsx = "Book1.xlsx";

IDictionary<string, Stream> mapFiles =new Dictionary<string,Stream>(); 
var request = new DeleteMetadataRequest(
    file:    this.GetLocalFilePath(book1Xlsx) ,
    type: "all"
);
this.CellsApi.DeleteMetadata(request);
