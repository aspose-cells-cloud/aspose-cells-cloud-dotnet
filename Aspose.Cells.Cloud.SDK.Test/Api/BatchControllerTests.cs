// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="BatchControllerTests.cs">
//   Copyright (c) 2023 Aspose.Cells Cloud
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
    /// Test case of BatchController.
    /// </summary>
    [TestClass]
    public class BatchControllerTests : CellsTestCommon
    {
        private readonly string remoteFolder = "TestData/In";

        /// <summary>
        /// Test for PostBatchConvert of BatchController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestPostBatchConvert()
        {
            string localBook1 = "Book1.xlsx";
            string remoteBook1 = "Book1.xlsx";
            string localMyDoc = "myDocument.xlsx";
            string remoteMyDoc = "myDocument.xlsx";

            this.UploadFile( localBook1, remoteFolder + "/" + remoteBook1, "");
            this.UploadFile( localMyDoc, remoteFolder + "/" + remoteMyDoc, "");

            var batchConvertRequestMatchCondition = new MatchConditionRequest()
            {
                RegexPattern = "(^Book)(.+)(xlsx$)"
            };
            var batchConvertRequest = new BatchConvertRequest()
            {
                SourceFolder = remoteFolder,
                Format = "pdf",
                OutFolder = "pdf",
                MatchCondition = batchConvertRequestMatchCondition
            };
            var request = new PostBatchConvertRequest(
                batchConvertRequest: batchConvertRequest
            );
            var actual =  this.CellsApi.PostBatchConvert(request);
            Assert.IsNotNull(actual);
        }
    }
}
