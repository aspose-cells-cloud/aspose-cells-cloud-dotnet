public static class Example_ReplaceContent
{
    public static void Run()
    {
        var cellsApi = new Aspose.Cells.Cloud.SDK.Api.CellsApi(System.Environment.GetEnvironmentVariable("ProductClientId"), System.Environment.GetEnvironmentVariable("ProductClientSecret"));
        cellsApi.ReplaceSpreadsheetContent(new Aspose.Cells.Cloud.SDK.Request.ReplaceSpreadsheetContentRequest("Aspose.Cells Product Readme.xlsx","Aspose.Cells","Aspose.Cells Cloud"), "Aspose.Cells Cloud Product Readme.xlsx");
    }
}