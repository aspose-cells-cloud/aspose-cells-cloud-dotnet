﻿
namespace Aspose.Cells.Cloud.SDK.Test
{
    using Aspose.Cells.Cloud.SDK.Client;
    using Aspose.Cells.Cloud.SDK.Api;
    using System.IO;
    public class CellsBaseTest
    {
        protected string testbaseurl = @"https://api-qa.aspose.cloud";
        protected string apiVersion = @"v3.0";
        protected ApiClient client;
        protected Client.Configuration config;
        protected string grantType = "client_credentials";
        protected string clientId = "91A2FD07-BBA1-4B32-9112-ABFB1FE8AEBD";
        protected string clientSecret = "0fbf678c5ecabdb5caca48452a736dd0";
        protected static string accesstoken;
        protected string refreshtoken;
        protected string BOOK1 = "Book1.xlsx";
        protected string MYDOC = "myDocument.xlsx";
        protected string PivTestFile = "TestCase.xlsx";
        protected string PivTestFile2 = "PivTestFile2.xlsx";
        protected string TEMPFOLDER = "DotnetTest";
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
        private string TestDataFolder = @"D:\Projects\Aspose\Aspose.Cells.Cloud.SDK\src\TestData\";
        
        protected void UpdateDataFile( CellsApi cellsApi, string folder, string filename)
        {
            bool? exist = cellsApi.ObjectExists(folder + @"\" + filename).Exists;
            if (exist.HasValue && exist.Value)
            {
                cellsApi.DeleteFile(folder + @"\" + filename);
            }
            Stream stream = GetTestDataStream(filename);
            var response = cellsApi.UploadFile(folder + @"\" + filename, stream);
        }
        protected void UpdateDataFile(CellsApi cellsApi,  string filename)
        {
            bool? exist = cellsApi.ObjectExists( filename).Exists;
            if (exist.HasValue && exist.Value)
            {
                cellsApi.DeleteFile(filename);
            }
            cellsApi.DeleteFile(  filename);
            Stream stream = GetTestDataStream(filename);
            var response = cellsApi.UploadFile( filename, stream);
        }
        protected void UpdateDataFileToOtherStorage(CellsApi cellsApi, string folder, string filename,string stroageName)
        {
            bool? exist = cellsApi.ObjectExists(folder + @"\" + filename, stroageName).Exists;
            if (exist.HasValue && exist.Value)
            {
                cellsApi.DeleteFile(folder + @"\" + filename, stroageName);
            }
            Stream stream = GetTestDataStream(filename);
            var response = cellsApi.UploadFile(folder + @"\" + filename, stream, stroageName);
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
