

namespace Aspose.Cells.Cloud.SDK.Test.ShortCodes
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using NUnit.Framework;
    using Aspose.Cells.Cloud.SDK.Api;
    using Aspose.Cells.Cloud.SDK.Model;
    [TestFixture]
    public class ConversionTests : CellsBaseTest
    {
        private ICellsApi instance;

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
        /// <summary>
        /// Test OAuthPost
        /// </summary>
        [Test]
        public void ShortCodeTests_Convertsion()
        {
            Requests.ConversionRequest conversionRequest =
                  new Requests.ConversionRequest { InputPath =GetInputFilePath( BOOK1), OutputPath = GetOutFilePath( BOOK1 + ".pdf") };
            instance.Convert(conversionRequest);
        }


        ///// <summary>
        ///// Test OAuthPost
        ///// </summary>
        //[Test]
        //public void ShortCodeTests_Convertsion_saveoptio()
        //{
        //    PdfSaveOptions pdfSaveOptions = new PdfSaveOptions();
        //    pdfSaveOptions.SaveFormat = "pdf";
        //    pdfSaveOptions.OnePagePerSheet = false;
        //    Requests.ConversionRequest conversionRequest =
        //          new Requests.ConversionRequest { InputPath = GetInputFilePath(BOOK1),
        //              OutputPath = GetOutFilePath(BOOK1 + "_saveoption.pdf") ,
        //          SaveOptions = pdfSaveOptions};
        //    instance.Convert(conversionRequest);
        //}
    }
}

