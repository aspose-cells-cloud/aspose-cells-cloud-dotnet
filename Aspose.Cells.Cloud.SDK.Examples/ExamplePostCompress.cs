using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Model;
using Aspose.Cells.Cloud.SDK.Request;
using System;
using System.IO;
using System.Collections.Generic;

CellsApi cellsApi = new CellsApi("xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx", "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
string dataSourceXlsx = "datasource.xlsx";

IDictionary<string, Stream> mapFiles =new Dictionary<string,Stream>(); 
var request = new PostCompressRequest(
    file:    this.GetLocalFilePath(dataSourceXlsx) ,
    compressLevel: compressLevel
);
this.CellsApi.PostCompress(request);
