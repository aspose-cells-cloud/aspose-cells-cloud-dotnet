namespace Aspose.Cells.Cloud.SDK.Test
{
    using System.IO;
    using System.Collections.Generic;
    using NUnit.Framework;
    using Aspose.Cells.Cloud.SDK.Api;
    using Aspose.Cells.Cloud.SDK.Model;
    /// <summary>
    ///  Class for testing CellsWorkbookApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class CellsCustomTests : CellsBaseTest
    {
        private CellsApi instance;
        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new CellsApi(clientId, clientSecret, apiVersion, testbaseurl);
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }


        [Test]
        public void CellsCELLSCLOUD10927Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string workbook = "customerOutput.xlsx";
            string format = "pdf";
            string password = null;
            string outPath = null;
            UpdateDataFile(instance, TEMPFOLDER, BOOK1);
            var response = instance.CellsWorkbookPutConvertWorkbook(GetTestDataStream(workbook), format, password, outPath);
            Assert.IsInstanceOf<System.IO.Stream>(response, "response is System.IO.Stream");

            using (FileStream fileStream = File.Create("test_dotnet.pdf"))
            {
                fileStream.Position = 0;
                response.CopyTo(fileStream);
                fileStream.Close();
            }
        }
        [Test]
        public void CELLSCLOUD17020Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            instance.CellsWorkbookPutWorkbookCreate("CELLSCLOUD17020Test.xlsx", null, null, null, "Custom");
            instance.CellsPostWorksheetCellSetValue("CELLSCLOUD17020Test.xlsx", "Sheet1", "A1", "10", "int", null, "Custom");
            instance.CellsPostWorksheetCellSetValue("CELLSCLOUD17020Test.xlsx", "Sheet1", "B1", "10", "int", null, "Custom");
            instance.CellsPostWorksheetCellSetValue("CELLSCLOUD17020Test.xlsx", "Sheet1", "C1", "10", "int", null, "Custom");
            instance.CellsPostWorksheetCellSetValue("CELLSCLOUD17020Test.xlsx", "Sheet1", "D1", "10", "int", null, "Custom");
            instance.CellsPostWorksheetCellSetValue("CELLSCLOUD17020Test.xlsx", "Sheet1", "A2", null, null, "=Sum(A1,B1,C1,D1)", "Custom");
            instance.CellsWorksheetsPostRenameWorksheet("CELLSCLOUD17020Test.xlsx", "Sheet1", "Start", "Custom");
            instance.CellsWorksheetsPutAddNewWorksheet("CELLSCLOUD17020Test.xlsx", "Other data", null, null, "Custom");
            Comment comment = new Comment();
            comment.Note = "TEST";
            instance.CellsWorksheetsPutWorksheetComment("CELLSCLOUD17020Test.xlsx", "Start", "A1", comment, "Custom");
            comment.Link = new Link();
            comment.Link.Href = "CELLSCLOUD17020Test.xlsx/worksheets/Start/comments/A2/";
            comment.Link.Rel = "self";
            comment.AutoSize = true;
            comment.Author = "Wo_0NDeR";
            comment.IsVisible = true;
            comment.TextOrientationType = "NoRotation";
            comment.TextHorizontalAlignment = "Left";
            comment.Height = 10;
            comment.Width = 10;
            comment.TextVerticalAlignment = "Top";
            comment.HtmlNote = "This is a note from Wo_0NDeR";
            comment.Note = "This is a note from Wo_0NDeR";
            comment.CellName = "A2";
            instance.CellsWorksheetsPostWorksheetComment("CELLSCLOUD17020Test.xlsx", "Start", "A1", comment, "Custom");
        }
    }

}
