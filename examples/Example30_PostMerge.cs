using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Model;
using Aspose.Cells.Cloud.SDK.Request;
using System;
using System.IO;
using System.Collections.Generic;
using Range = Aspose.Cells.Cloud.SDK.Model.Range;

public static class Example30_PostMerge
{
    public static void Run()
    {
        CellsApi cellsApi = new CellsApi("xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx", "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
        IDictionary<string, System.IO.Stream> mapFiles =new Dictionary<string, System.IO.Stream>(); 
        string assemblyTestXlsx = "assemblytest.xlsx";
        string dataSourceXlsx = "datasource.xlsx";

        var format = "html";
        var mergeToOneSheet = true;
         mapFiles.Add(assemblyTestXlsx, File.OpenRead(assemblyTestXlsx)); 
         mapFiles.Add(dataSourceXlsx, File.OpenRead(dataSourceXlsx)); 
        var request = new PostMergeRequest(
            file:   mapFiles ,
            outFormat: format,
            mergeToOneSheet: mergeToOneSheet
        );
        cellsApi.PostMerge(request);
    }
}