namespace Aspose.Cells.Cloud.SDK.Api.ExampleQuickstart
{
    using System;
    using System.IO;
    using System.Collections.Generic;
    using Aspose.Cells.Cloud.SDK.Api;
    using Aspose.Cells.Cloud.SDK.Model;
    using Aspose.Cells.Cloud.SDK.Request;

    public class CellsApiExample
    {
        CellsApi cellsApi = new CellsApi(Environment.GetEnvironmentVariable("ProductClientId"), Environment.GetEnvironmentVariable("ProductClientSecret"));
        public void ExampleQuickstart()
        {
            var request = new PutConvertWorkbookRequest { localPath = "EmployeeSalesSummary.xlsx", format = "pdf" };
            var response = cellsApi.PutConvertWorkbook(request);
            if (response != null && response.Length > 0)
            {
                File.WriteAllBytes("EmployeeSalesSummary.pdf", response);
                Console.WriteLine("File converted and saved.");
            }
        }
    }
}