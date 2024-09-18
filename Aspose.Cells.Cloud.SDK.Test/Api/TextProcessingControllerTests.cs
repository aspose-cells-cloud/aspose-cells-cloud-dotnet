// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="TextProcessingControllerTests.cs">
//   Copyright (c) 2024 Aspose.Cells Cloud
// </copyright>
// <summary>
//   Permission is hereby granted, free of charge, to any person obtaining a copy
//  of this software and associated documentation files (the "Software"), to deal
//  in the Software without restriction, including without limitation the rights
//  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//  copies of the Software, and to permit persons to whom the Software is
//  furnished to do so, subject to the following conditions:
// 
//  The above copyright notice and this permission notice shall be included in all
//  copies or substantial portions of the Software.
// 
//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//  SOFTWARE.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Aspose.Cells.Cloud.SDK.Tests.Api.Api
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;    
    using Aspose.Cells.Cloud.SDK.Model;
    using Aspose.Cells.Cloud.SDK.Request;
    using System.Collections.Generic;
    /// <summary>
    /// Test case of TextProcessingController.
    /// </summary>
    [TestClass]
    public class TextProcessingControllerTests : CellsTestCommon
    {
        private readonly string remoteFolder = "TestData/In";

        /// <summary>
        /// Test for PostAddTextContent of TextProcessingController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestPostAddTextContent()
        {
            string localName = "BookText.xlsx";
            string remoteName = "BookText.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var addTextOptionsDataSource = new DataSource()
            {
                DataSourceType = "CloudFileSystem",
                DataPath = "BookText.xlsx"
            };
            var addTextOptions = new AddTextOptions()
            {
                DataSource = addTextOptionsDataSource,
                Text = "Aspose.Cells Cloud is an excellent product.",
                Worksheet = "202401",
                SelectPoistion = "AtTheBeginning",
                SkipEmptyCells = true
            };
            var request = new PostAddTextContentRequest(
                addTextOptions: addTextOptions
            );
            var actual =  this.CellsApi.PostAddTextContent(request);
            Assert.IsNotNull(actual);
        }

        /// <summary>
        /// Test for PostTrimContent of TextProcessingController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestPostTrimContent()
        {
            string localName = "BookText.xlsx";
            string remoteName = "BookText.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var trimContentOptionsDataSource = new DataSource()
            {
                DataSourceType = "CloudFileSystem",
                DataPath = "BookText.xlsx"
            };
            var trimContentOptionsScopeOptions = new ScopeOptions()
            {
                Scope = "EntireWorkbook"
            };
            var trimContentOptions = new TrimContentOptions()
            {
                DataSource = trimContentOptionsDataSource,
                TrimLeading = true,
                TrimTrailing = true,
                TrimSpaceBetweenWordTo1 = true,
                RemoveAllLineBreaks = true,
                ScopeOptions = trimContentOptionsScopeOptions
            };
            var request = new PostTrimContentRequest(
                trimContentOptions: trimContentOptions
            );
            var actual =  this.CellsApi.PostTrimContent(request);
            Assert.IsNotNull(actual);
        }

        /// <summary>
        /// Test for PostUpdateWordCase of TextProcessingController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestPostUpdateWordCase()
        {
            string localName = "BookText.xlsx";
            string remoteName = "BookText.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var wordCaseOptionsDataSource = new DataSource()
            {
                DataSourceType = "CloudFileSystem",
                DataPath = "BookText.xlsx"
            };
            var wordCaseOptionsScopeOptions = new ScopeOptions()
            {
                Scope = "EntireWorkbook"
            };
            var wordCaseOptions = new WordCaseOptions()
            {
                DataSource = wordCaseOptionsDataSource,
                WordCaseType = "None",
                ScopeOptions = wordCaseOptionsScopeOptions
            };
            var request = new PostUpdateWordCaseRequest(
                wordCaseOptions: wordCaseOptions
            );
            var actual =  this.CellsApi.PostUpdateWordCase(request);
            Assert.IsNotNull(actual);
        }
    }
}
