public static class ExampleBlog_TextProcessing_WordCase
{
    public static void Run()
    {
        var cellsApi = new Aspose.Cells.Cloud.SDK.Api.CellsApi(System.Environment.GetEnvironmentVariable("ProductClientId"), System.Environment.GetEnvironmentVariable("ProductClientSecret"));
		var request = new Aspose.Cells.Cloud.SDK.Request.PostUpdateWordCaseRequest
		{
			wordCaseOptions  = new Aspose.Cells.Cloud.SDK.Model.WordCaseOptions
            {
                DataSource = new Aspose.Cells.Cloud.SDK.Model.DataSource { DataSourceType = "RequestFiles" },
                FileInfo = new Aspose.Cells.Cloud.SDK.Model.FileInfo
                {
                    Filename = "BookText.xlsx",
                    FileContent = System.Convert.ToBase64String(System.IO.File.ReadAllBytes("BookText.xlsx"))
                },
                WordCaseType = "ProperCase",
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
        var response = cellsApi.PostUpdateWordCase(request);
        System.IO.File.WriteAllBytes("BookText_WordCase.xlsx", System.Convert.FromBase64String(response.FileContent));
    }
}