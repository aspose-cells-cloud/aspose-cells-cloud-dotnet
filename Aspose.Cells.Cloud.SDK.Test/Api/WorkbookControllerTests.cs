// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="WorkbookControllerTests.cs">
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
    /// Test case of WorkbookController.
    /// </summary>
    [TestClass]
    public class WorkbookControllerTests : CellsTestCommon
    {
        private readonly string remoteFolder = "TestData/In";

        /// <summary>
        /// Test for PostDigitalSignature of WorkbookController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestPostDigitalSignature()
        {
            string localName = "Book1.xlsx";
            string roywangPFX = "roywang.pfx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");
            this.UploadFile( roywangPFX, remoteFolder + "/roywang.pfx", "");

            var request = new PostDigitalSignatureRequest(
                name: remoteName,
                digitalsignaturefile: remoteFolder + "/roywang.pfx",
                password: "123456",
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.PostDigitalSignature(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for PostEncryptWorkbook of WorkbookController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestPostEncryptWorkbook()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var encryption = new WorkbookEncryptionRequest()
            {
                Password = "123456",
                EncryptionType = "XOR",
                KeyLength = 128
            };
            var request = new PostEncryptWorkbookRequest(
                name: remoteName,
                encryption: encryption,
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.PostEncryptWorkbook(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for DeleteDecryptWorkbook of WorkbookController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestDeleteDecryptWorkbook()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var encryption = new WorkbookEncryptionRequest()
            {
                Password = "123456",
                EncryptionType = "XOR",
                KeyLength = 128
            };
            var request = new DeleteDecryptWorkbookRequest(
                name: remoteName,
                encryption: encryption,
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.DeleteDecryptWorkbook(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for PostProtectWorkbook of WorkbookController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestPostProtectWorkbook()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var protection = new ProtectWorkbookRequest()
            {
                EncryptWithPassword = "123456",
                AwaysOpenReadOnly = true
            };
            var request = new PostProtectWorkbookRequest(
                name: remoteName,
                protectWorkbookRequest: protection,
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.PostProtectWorkbook(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for DeleteUnProtectWorkbook of WorkbookController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestDeleteUnProtectWorkbook()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new DeleteUnProtectWorkbookRequest(
                name: remoteName,
                folder: remoteFolder,
                password : "123456",
                storageName: ""
            );
            var actual =  this.CellsApi.DeleteUnProtectWorkbook(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for GetWorkbookDefaultStyle of WorkbookController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestGetWorkbookDefaultStyle()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new GetWorkbookDefaultStyleRequest(
                name: remoteName,
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.GetWorkbookDefaultStyle(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for GetWorkbookTextItems of WorkbookController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestGetWorkbookTextItems()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new GetWorkbookTextItemsRequest(
                name: remoteName,
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.GetWorkbookTextItems(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for GetWorkbookNames of WorkbookController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestGetWorkbookNames()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new GetWorkbookNamesRequest(
                name: remoteName,
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.GetWorkbookNames(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for PutWorkbookName of WorkbookController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestPutWorkbookName()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var newName = new Name()
            {
                Text = "name_1804",
                Comment = "KeepSourceFormatting",
                RefersTo = "=Sheet1!$I$4"
            };
            var request = new PutWorkbookNameRequest(
                name: remoteName,
                newName: newName,
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.PutWorkbookName(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for GetWorkbookName of WorkbookController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestGetWorkbookName()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new GetWorkbookNameRequest(
                name: remoteName,
                nameName: "Name_2",
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.GetWorkbookName(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for PostWorkbookName of WorkbookController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestPostWorkbookName()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var newName = new Name()
            {
                Text = "name_1804",
                Comment = "KeepSourceFormatting",
                RefersTo = "=Sheet1!$I$4"
            };
            var request = new PostWorkbookNameRequest(
                name: remoteName,
                nameName: "Name_2",
                newName: newName,
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.PostWorkbookName(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for GetWorkbookNameValue of WorkbookController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestGetWorkbookNameValue()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new GetWorkbookNameValueRequest(
                name: remoteName,
                nameName: "Name_2",
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.GetWorkbookNameValue(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for DeleteWorkbookNames of WorkbookController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestDeleteWorkbookNames()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new DeleteWorkbookNamesRequest(
                name: remoteName,
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.DeleteWorkbookNames(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for DeleteWorkbookName of WorkbookController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestDeleteWorkbookName()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new DeleteWorkbookNameRequest(
                name: remoteName,
                nameName: "Name_2",
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.DeleteWorkbookName(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for PutDocumentProtectFromChanges of WorkbookController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestPutDocumentProtectFromChanges()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var password = new PasswordRequest()
            {
                Password = "123456"
            };
            var request = new PutDocumentProtectFromChangesRequest(
                name: remoteName,
                password: password,
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.PutDocumentProtectFromChanges(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for DeleteDocumentUnProtectFromChanges of WorkbookController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestDeleteDocumentUnProtectFromChanges()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new DeleteDocumentUnProtectFromChangesRequest(
                name: remoteName,
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.DeleteDocumentUnProtectFromChanges(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for PostWorkbooksMerge of WorkbookController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestPostWorkbooksMerge()
        {
            string localName = "Book1.xlsx";
            string myDocumentXLSX = "myDocument.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");
            this.UploadFile( myDocumentXLSX, remoteFolder + "/myDocument.xlsx", "");

            var request = new PostWorkbooksMergeRequest(
                name: remoteName,
                mergeWith: remoteFolder + "/myDocument.xlsx",
                folder: remoteFolder,
                storageName: "",
                mergedStorageName: ""
            );
            var actual =  this.CellsApi.PostWorkbooksMerge(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for PostWorkbooksTextSearch of WorkbookController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestPostWorkbooksTextSearch()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new PostWorkbooksTextSearchRequest(
                name: remoteName,
                text: "1234",
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.PostWorkbooksTextSearch(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for PostWorkbooksTextReplace of WorkbookController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestPostWorkbookTextReplace()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new PostWorkbookTextReplaceRequest(
                name: remoteName,
                oldValue: "1234",
                newValue: "5678",
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.PostWorkbookTextReplace(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for PostWorkbookGetSmartMarkerResult of WorkbookController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestPostWorkbookGetSmartMarkerResult()
        {
            string localName = "Book1.xlsx";
            string reportDataXML = "ReportData.xml";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");
            this.UploadFile( reportDataXML, remoteFolder + "/ReportData.xml", "");

            var request = new PostWorkbookGetSmartMarkerResultRequest(
                name: remoteName,
                xmlFile: remoteFolder + "/ReportData.xml",
                folder: remoteFolder,
                outPath: "OutResult/SmartMarkerResult.xlsx",
                storageName: "",
                outStorageName: ""
            );
            var actual =  this.CellsApi.PostWorkbookGetSmartMarkerResult(request);
            Assert.IsNotNull(actual);
        }

        /// <summary>
        /// Test for PutWorkbookCreate of WorkbookController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestPutWorkbookCreate()
        {
            string localName = "Book1.xlsx";
            string reportDataXML = "ReportData.xml";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");
            this.UploadFile( reportDataXML, remoteFolder + "/ReportData.xml", "");

            var request = new PutWorkbookCreateRequest(
                name: "PutWorkbookCreate.xlsx",
                templateFile: remoteFolder + "/" + remoteName,
                dataFile: remoteFolder + "/ReportData.xml",
                isWriteOver: true,
                folder: remoteFolder,
                storageName: "",
                checkExcelRestriction: true
            );
            var actual =  this.CellsApi.PutWorkbookCreate(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for PostWorkbookSplit of WorkbookController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestPostWorkbookSplit()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new PostWorkbookSplitRequest(
                name: remoteName,
                format: "png",
                outFolder: "OutResult",
                from: 1,
                to: 5,
                splitNameRule: "sheetname",
                folder: remoteFolder,
                storageName: "",
                outStorageName: ""
            );
            var actual =  this.CellsApi.PostWorkbookSplit(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for PostImportData of WorkbookController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestPostImportData()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var importOptionData = new List<int?>()
            {
                1,
                2,
                3,
                4
            };
            var importOption = new ImportIntArrayOption()
            {
                DestinationWorksheet = "Sheet1",
                FirstColumn = 1,
                FirstRow = 3,
                ImportDataType = "IntArray",
                IsInsert = true,
                IsVertical = true,
                Data = importOptionData
            };
            var request = new PostImportDataRequest(
                name: remoteName,
                importOption: importOption,
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.PostImportData(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for PostWorkbookCalculateFormula of WorkbookController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestPostWorkbookCalculateFormula()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var options = new CalculationOptions()
            {
                IgnoreError = true,
                Recursive = true
            };
            var request = new PostWorkbookCalculateFormulaRequest(
                name: remoteName,
                options: options,
                ignoreError: true,
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.PostWorkbookCalculateFormula(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for PostAutofitWorkbookRows of WorkbookController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestPostAutofitWorkbookRows()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new PostAutofitWorkbookRowsRequest(
                name: remoteName,
                startRow: 1,
                endRow: 100,
                onlyAuto: true,
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.PostAutofitWorkbookRows(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for PostAutofitWorkbookColumns of WorkbookController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestPostAutofitWorkbookColumns()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new PostAutofitWorkbookColumnsRequest(
                name: remoteName,
                startColumn: 1,
                endColumn: 20,
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.PostAutofitWorkbookColumns(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for GetWorkbookSettings of WorkbookController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestGetWorkbookSettings()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new GetWorkbookSettingsRequest(
                name: remoteName,
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.GetWorkbookSettings(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for PostWorkbookSettings of WorkbookController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestPostWorkbookSettings()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var settings = new WorkbookSettings()
            {
                AutoCompressPictures = true,
                HidePivotFieldList = true
            };
            var request = new PostWorkbookSettingsRequest(
                name: remoteName,
                settings: settings,
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.PostWorkbookSettings(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for PutWorkbookBackground of WorkbookController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestPutWorkbookBackground()
        {
            string localName = "Book1.xlsx";
            string waterMarkPNG = "WaterMark.png";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");
            this.UploadFile( waterMarkPNG, remoteFolder + "/WaterMark.png", "");

            var request = new PutWorkbookBackgroundRequest(
                name: remoteName,
                picPath: remoteFolder + "/WaterMark.png",
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.PutWorkbookBackground(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for DeleteWorkbookBackground of WorkbookController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestDeleteWorkbookBackground()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new DeleteWorkbookBackgroundRequest(
                name: remoteName,
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.DeleteWorkbookBackground(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for PutWorkbookWaterMarker of WorkbookController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestPutWorkbookWaterMarker()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var textWaterMarkerRequest = new TextWaterMarkerRequest()
            {
                Text = "Aspose Cells Cloud",
                FontSize = 12
            };
            var request = new PutWorkbookWaterMarkerRequest(
                name: remoteName,
                textWaterMarkerRequest: textWaterMarkerRequest,
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.PutWorkbookWaterMarker(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for GetPageCount of WorkbookController.
        /// </summary>
        [TestCategory(ProductName)]
        [TestMethod]
        public void TestGetPageCount()
        {
            string localName = "Book1.xlsx";
            string remoteName = "Book1.xlsx";

            this.UploadFile( localName, remoteFolder + "/" + remoteName, "");

            var request = new GetPageCountRequest(
                name: remoteName,
                folder: remoteFolder,
                storageName: ""
            );
            var actual =  this.CellsApi.GetPageCount(request);
            Assert.IsNotNull(actual);
        }
    }
}
