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
    public class Freeing2209Tests : CellsBaseTest
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
        public void CellsCELLSCLOUD_PostConvertPptx()
        {
            var fileInfo = instance.PostConvertWorkbookToPptx(GetTestDataStream(BOOK1));
            Assert.IsInstanceOf<Model.FileInfo>(fileInfo, "response is AccessTokenResponse");
        }
        [Test]
        public void CellsCELLSCLOUD_PostConvertHtml()
        {
            var fileInfo = instance.PostConvertWorkbookToHtml(GetTestDataStream(BOOK1));
            Assert.IsInstanceOf<Model.FileInfo>(fileInfo, "response is AccessTokenResponse");
        }
        [Test]
        public void CellsCELLSCLOUD_PostConvertMarkdown()
        {
            var fileInfo = instance.PostConvertWorkbookToMarkdown(GetTestDataStream(BOOK1));
            Assert.IsInstanceOf<Model.FileInfo>(fileInfo, "response is AccessTokenResponse");
        }
    }
}
