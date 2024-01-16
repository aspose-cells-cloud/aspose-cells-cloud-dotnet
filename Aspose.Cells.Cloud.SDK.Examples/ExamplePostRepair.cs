using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Model;
using Aspose.Cells.Cloud.SDK.Request;
using System;
using System.IO;
using System.Collections.Generic;

CellsApi cellsApi = new CellsApi("xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx", "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
string book1Xlsx = "Book1.xlsx";

IDictionary<string, Stream> mapFiles =new Dictionary<string,Stream>(); 
AddFileParameter(book1Xlsx,mapFiles);       
var request = new PostRepairRequest(
    file: mapFiles,
    outFormat: format
);
this.CellsApi.PostRepair(request);
