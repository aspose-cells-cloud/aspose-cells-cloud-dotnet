using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Model;
using Aspose.Cells.Cloud.SDK.Request;
using System;
using System.IO;
using System.Collections.Generic;
using Range = Aspose.Cells.Cloud.SDK.Model.Range;

public static class Example30_PostMetadata
{
    public static void Run()
    {
        CellsApi cellsApi = new CellsApi("xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx", "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
        IDictionary<string, System.IO.Stream> mapFiles =new Dictionary<string, System.IO.Stream>(); 
        string book1Xlsx = "Book1.xlsx";

        var cellsDocumentscellsDocument0 = new CellsDocumentProperty()
        {
            Name = "Author",
            Value = "roy.wang"
        };
        var cellsDocuments = new List<CellsDocumentProperty>()
        {
            cellsDocumentscellsDocument0
        };

        var request = new PostMetadataRequest(
            localPath:    book1Xlsx ,
            cellsDocuments: cellsDocuments
        );
        cellsApi.PostMetadata(request);
    }
}