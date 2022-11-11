namespace Aspose.Cells.Cloud.SDK.Test
{
    using NUnit.Framework;
    using Aspose.Cells.Cloud.SDK.Api;

    /// <summary>
    ///  Class for testing CellsWorkbookApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class Freeing2210Tests : CellsBaseTest
    {
        private CellsApi instance;
        private LightCellsApi lightInstance;
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
        public void CellsCELLSCLOUD_PostConvertPNG()
        {
            var fileInfo = instance.PostConvertWorkbookToPNG(GetTestDataStream(BOOK1));
            Assert.IsInstanceOf<Model.FileInfo>(fileInfo, "response is AccessTokenResponse");
        }
        [Test]
        public void CellsCELLSCLOUD_PostConvertPDF()
        {
            var fileInfo = instance.PostConvertWorkbookToPDF(GetTestDataStream(BOOK1));
            Assert.IsInstanceOf<Model.FileInfo>(fileInfo, "response is AccessTokenResponse");
        }
        [Test]
        public void CellsCELLSCLOUD_PostConvertDocx()
        {
            var fileInfo = instance.PostConvertWorkbookToDocx(GetTestDataStream(BOOK1));
            Assert.IsInstanceOf<Model.FileInfo>(fileInfo, "response is AccessTokenResponse");
        }
    }
}
