using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Model;
using Aspose.Cells.Cloud.SDK.Request;
using FileInfo = Aspose.Cells.Cloud.SDK.Model.FileInfo;

public static class ExampleBlog_TextProcessing_TrimContent
{
    public static void Run()
    {
        CellsApi cellsApi = new CellsApi("xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx", "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
        PostTrimContentRequest request = new PostTrimContentRequest
        {
            trimContentOptions = new TrimContentOptions
            {
                DataSource = new DataSource { DataSourceType = "RequestFiles" },
                FileInfo = new FileInfo
                {
                    Filename = "BookText.xlsx",
                    FileContent = System.Convert.ToBase64String(System.IO.File.ReadAllBytes("BookText.xlsx"))
                },
                RemoveAllLineBreaks = true,
                RemoveExtraLineBreaks = true,
                TrimSpaceBetweenWordTo1 = true,
                ScopeOptions = new ScopeOptions
                {
                    Scope = "SelectionOlny",
                     ScopeItems = new System.Collections.Generic.List<ScopeItem> {
                         new ScopeItem { 
                             WorksheetName = "Sales",
                             Ranges = new System.Collections.Generic.List<string> { "B1:B3"}
                         } }
				}
            }
        };
        cellsApi.PostTrimContent(request);
    }
}