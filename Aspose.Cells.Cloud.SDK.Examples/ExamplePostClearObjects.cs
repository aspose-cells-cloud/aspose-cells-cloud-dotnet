using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Model;
using Aspose.Cells.Cloud.SDK.Request;
using System;
using System.IO;
using System.Collections.Generic;

CellsApi cellsApi = new CellsApi("xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx", "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
string book1Xlsx = "Book1.xlsx";
string dataSourceXlsx = "datasource.xlsx";

IDictionary<string, Stream> mapFiles =new Dictionary<string,Stream>(); 
AddFileParameter(book1Xlsx,mapFiles);       
AddFileParameter(dataSourceXlsx,mapFiles);       
var request = new PostClearObjectsRequest(
    file: mapFiles,
    objecttype: objecttype
);
this.CellsApi.PostClearObjects(request);
