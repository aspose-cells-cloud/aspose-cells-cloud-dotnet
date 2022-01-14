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
    public class Freeing2201Tests : CellsBaseTest
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
        public void CellsCELLSCLOUD11305Test()
        {
            UpdateDataFile(instance, TEMPFOLDER, BOOK1);
            var response = instance.CellsWorkbookGetWorkbook(BOOK1,null,"pdf",null, null, TEMPFOLDER, null, "Freeing/CellsCELLSCLOUD11305Test.pdf", "DropBox");
            Assert.IsInstanceOf<Stream>(response, "response is System.IO.Stream");
        }

        [Test]
        public void CellsCELLSCLOUD11306Test()
        {
            UpdateDataFile(instance, TEMPFOLDER, BOOK1);
            var response = instance.CellsSaveAsPostDocumentSaveAs(BOOK1,null, "Freeing/CellsCELLSCLOUD11306Test.html" , null,null, TEMPFOLDER,null, "DropBox");
            Assert.IsInstanceOf<SaveResponse>(response, "response is System.IO.Stream");
        }

        [Test]
        public void CellsCELLSCLOUD11307Test()
        {
            UpdateDataFile(instance, TEMPFOLDER, BOOK1);
            UpdateDataFileToOtherStorage(instance, null, MYDOC, "DropBox");
            var response = instance.CellsWorkbookPostWorkbooksMerge(BOOK1, MYDOC,  TEMPFOLDER, null, "DropBox");
            Assert.IsInstanceOf<WorkbookResponse>(response, "response is System.IO.Stream");
        }
        [Test]
        public void CellsCELLSCLOUD11308Test()
        {
            UpdateDataFile(instance, TEMPFOLDER, BOOK1);
            
            var response = instance.CellsWorkbookPostWorkbookSplit(BOOK1, "html",null,null,null,null, TEMPFOLDER, "Freeing",null, "DropBox");
            Assert.IsInstanceOf<SplitResultResponse>(response, "response is System.IO.Stream");
        }
        [Test]
        public void CellsCELLSCLOUD11309Test()
        {
            UpdateDataFile(instance, TEMPFOLDER, BOOK1);
            UpdateDataFile(instance, null, "ReportData.xml");
            var response = instance.CellsWorkbookPostWorkbookGetSmartMarkerResult(BOOK1, "ReportData.xml", TEMPFOLDER, null, "Freeing/CellsCELLSCLOUD11309Test.pdf",  "DropBox");
            Assert.IsInstanceOf<Stream>(response, "response is System.IO.Stream");
        }
        [Test]
        public void CellsCELLSCLOUD11310Test()
        {
            UpdateDataFile(instance, TEMPFOLDER, BOOK1);
            UpdateDataFile(instance, TEMPFOLDER, BOOK2);
            UpdateDataFile(instance, TEMPFOLDER, AssemblyTest);
            UpdateDataFile(instance, TEMPFOLDER, DataSource);
            var response = instance.PostBatchConvert(new BatchConvertRequest { 
                Format ="html", SourceFolder = TEMPFOLDER , OutFolder="Freeing" , OutStorage= "DropBox",
                MatchCondition = new MatchConditionRequest {  RegexPattern = "(^Book)(.+)(xlsx$)" }
            });
            Assert.IsInstanceOf<Stream>(response, "response is System.IO.Stream");
        }
    }
}
