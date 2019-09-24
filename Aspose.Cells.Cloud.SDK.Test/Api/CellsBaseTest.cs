
namespace Aspose.Cells.Cloud.SDK.Test
{
    using Aspose.Cells.Cloud.SDK.Client;
    using Aspose.Cells.Cloud.SDK.Api;
    using Aspose.Storage.Cloud.Sdk.Api;
    using Aspose.Storage.Cloud.Sdk.Model;
    using Aspose.Storage.Cloud.Sdk.Model.Requests;
    using System.IO;
    using System.Collections.Generic;
    public class CellsBaseTest
    {
        protected ApiClient client;
        protected Client.Configuration config;
        protected string grantType = "client_credentials";
        protected string clientId = "66164C51-693E-4904-A121-545961673EC1";
        protected string clientSecret = "536e76768419db9585afdd37bb5f7533";
        protected static string accesstoken;
        protected string refreshtoken;
        protected string BOOK1 = "Book1.xlsx";
        protected string MYDOC = "myDocument.xlsx";
        protected string PivTestFile = "TestCase.xlsx";
        protected string PivTestFile2 = "PivTestFile2.xlsx";
        protected string TEMPFOLDER = "Temp";
        protected string SHEET1 = "Sheet1";
        protected string SHEET2 = "Sheet2";
        protected string SHEET3 = "Sheet3";
        protected string SHEET4 = "Sheet4";
        protected string SHEET5 = "Sheet5";
        protected string SHEET6 = "Sheet6";
        protected string SHEET7 = "Sheet7";
        protected string SHEET8 = "Sheet8";
        protected string CellName = "A1";
        protected string RANGE = "A1:C10";
        protected string CELLAREA = "A1:C10";
        protected StorageApi storageApi;
        private string TestDataFolder = @"D:\Projects\Aspose\Aspose.Cloud\Aspose.Cells.Cloud.SDK\src\TestData\";
        
        protected void UpdateDataFile( CellsApi cellsApi, string folder, string filename)
        {
            cellsApi.DeleteFile(folder + @"\" + filename);
            Stream stream = GetTestDataStream(filename);
            var response = cellsApi.UploadFile(folder + @"\" + filename, stream);
        }
        protected void UpdateDataFile(CellsApi cellsApi,  string filename)
        {
            cellsApi.DeleteFile(  filename);
            Stream stream = GetTestDataStream(filename);
            var response = cellsApi.UploadFile( filename, stream);
        }
        protected void UpdateDataFileForDropBox(CellsApi cellsApi, string folder, string filename)
        {
            cellsApi.DeleteFile(folder + @"\" + filename, "DropBox");
            Stream stream = GetTestDataStream(filename);
            var response = cellsApi.UploadFile(folder + @"\" + filename, stream, "DropBox");
        }

        protected Stream GetTestDataStream( string filename)
        {
            MemoryStream ms = new MemoryStream();
            FileStream fs = File.OpenRead(TestDataFolder + filename);
            fs.CopyTo(ms);
            ms.Position = 0;
            return ms;
        }
        protected byte[] GetTestDataByteArray(string filename)
        {
            return File.ReadAllBytes(TestDataFolder + filename);
        }
        protected void WriteResponseStream(string filename, Stream stream)
        {
            FileStream fs = File.Create(TestDataFolder + filename);
            stream.CopyTo(fs);
            fs.Close();
        }
        
    }
}
