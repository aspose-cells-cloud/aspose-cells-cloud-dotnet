using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Model;
using Aspose.Cells.Cloud.SDK.Request;
using System;
using System.IO;
using System.Collections.Generic;

CellsApi cellsApi = new CellsApi("xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx", "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
string assemblyTestXlsx = "assemblytest.xlsx";
string book1Xlsx = "Book1.xlsx";

IDictionary<string, Stream> mapFiles =new Dictionary<string,Stream>(); 
AddFileParameter(assemblyTestXlsx,mapFiles);       
AddFileParameter(book1Xlsx,mapFiles);       
var request = new PostExportRequest(
    file: mapFiles,
    objectType: objectType,
    format: format
);
this.CellsApi.PostExport(request);
