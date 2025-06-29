public static class ExampleBlog_TextProcessing_TrimContent
{
    public static void Run()
    {
        var cellsApi = new Aspose.Cells.Cloud.SDK.Api.CellsApi(System.Environment.GetEnvironmentVariable("ProductClientId"), System.Environment.GetEnvironmentVariable("ProductClientSecret"));
        var request = new Aspose.Cells.Cloud.SDK.Request.PostTrimContentRequest
        {
            trimContentOptions = new Aspose.Cells.Cloud.SDK.Model.TrimContentOptions
            {
                DataSource = new Aspose.Cells.Cloud.SDK.Model.DataSource { DataSourceType = "RequestFiles" },
                FileInfo = new Aspose.Cells.Cloud.SDK.Model.FileInfo
                {
                    Filename = "BookText.xlsx",
                    FileContent = System.Convert.ToBase64String(System.IO.File.ReadAllBytes("BookText.xlsx"))
                },
                RemoveAllLineBreaks = true,
                RemoveExtraLineBreaks = true,
                TrimSpaceBetweenWordTo1 = true,
                ScopeOptions = new Aspose.Cells.Cloud.SDK.Model.ScopeOptions
                {
                    Scope = "SelectionOlny",
                     ScopeItems = new System.Collections.Generic.List<Aspose.Cells.Cloud.SDK.Model.ScopeItem> {
                         new Aspose.Cells.Cloud.SDK.Model.ScopeItem { 
                             WorksheetName = "Sales",
                             Ranges = new System.Collections.Generic.List<string> { "B1:B3"}
                         } }
				}
            }
        };
        var response =  cellsApi.PostTrimContent(request);
        System.IO.File.WriteAllBytes("BookText_TrimContent.xlsx", System.Convert.FromBase64String(response.FileContent));
    }
}