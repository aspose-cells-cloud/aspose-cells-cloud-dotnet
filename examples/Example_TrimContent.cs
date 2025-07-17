public static class Example_TrimContent
{
    public static void Run()
    {
        // Get your Client ID and Client Secret from https://dashboard.aspose.cloud (free registration is required).
        var cellsApi = new Aspose.Cells.Cloud.SDK.Api.CellsApi(System.Environment.GetEnvironmentVariable("ProductClientId"), System.Environment.GetEnvironmentVariable("ProductClientSecret"));
        // Build trim content request parameters 
        var request = new Aspose.Cells.Cloud.SDK.Request.PostTrimContentRequest
        {
            trimContentOptions = new Aspose.Cells.Cloud.SDK.Model.TrimContentOptions
            {
                DataSource = new Aspose.Cells.Cloud.SDK.Model.DataSource { DataSourceType = "RequestFiles" },
                // Set the source file information. Convert file data to base64 encoded string.
                FileInfo = new Aspose.Cells.Cloud.SDK.Model.FileInfo { Filename = "BookText.xlsx", FileContent = System.Convert.ToBase64String(System.IO.File.ReadAllBytes("BookText.xlsx")) },
                RemoveAllLineBreaks = true,
                RemoveExtraLineBreaks = true,
                TrimSpaceBetweenWordTo1 = true,
                ScopeOptions = new Aspose.Cells.Cloud.SDK.Model.ScopeOptions
                {
                    Scope = "SelectionOlny",
                    ScopeItems = new System.Collections.Generic.List<Aspose.Cells.Cloud.SDK.Model.ScopeItem> { new Aspose.Cells.Cloud.SDK.Model.ScopeItem { Worksheet = "Sales", Ranges = new System.Collections.Generic.List<string> { "B1:B3"} } }
                }
            }
        };
        // Post trim content Web API request.
        var response = cellsApi.PostTrimContent(request);
        // Save result: convert base64 string to file.
        System.IO.File.WriteAllBytes("BookText_TrimContent.xlsx", System.Convert.FromBase64String(response.FileContent));
    }
}