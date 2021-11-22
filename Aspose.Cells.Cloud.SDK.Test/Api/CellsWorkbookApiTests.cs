namespace Aspose.Cells.Cloud.SDK.Test
{
    using System;
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
    public class CellsWorkbookApiTests : CellsBaseTest
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


        /// <summary>
        /// Test CellsWorkbookDeleteDecryptDocument
        /// </summary>
        [Test]
        public void CellsWorkbookDeleteDecryptDocumentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            WorkbookEncryptionRequest encryption = new WorkbookEncryptionRequest();
            encryption.Password = "123456";
            encryption.KeyLength = 128;
            encryption.EncryptionType = "XOR";
            string folder = TEMPFOLDER;
            UpdateDataFile(instance, folder, name);
            var response = instance.CellsWorkbookDeleteDecryptDocument(name, encryption, folder);
            Assert.IsInstanceOf<CellsCloudResponse>(response, "response is CellsCloudResponse");
            Assert.AreEqual(response.Code, 200);
        }

        /// <summary>
        /// Test CellsWorkbookDeleteDocumentUnProtectFromChanges
        /// </summary>
        [Test]
        public void CellsWorkbookDeleteDocumentUnProtectFromChangesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            string folder = TEMPFOLDER;
            UpdateDataFile(instance, folder, name);
            var response = instance.CellsWorkbookDeleteDocumentUnprotectFromChanges(name, folder);
            Assert.IsInstanceOf<CellsCloudResponse>(response, "response is CellsCloudResponse");
            Assert.AreEqual(response.Code, 200);
        }

        /// <summary>
        /// Test CellsWorkbookDeleteUnProtectDocument
        /// </summary>
        [Test]
        public void CellsWorkbookDeleteUnProtectDocumentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            WorkbookProtectionRequest protection = new WorkbookProtectionRequest();
            protection.Password = "123";
            protection.ProtectionType = "All";
            string folder = TEMPFOLDER;
            UpdateDataFile(instance, folder, name);
            var response = instance.CellsWorkbookDeleteUnprotectDocument(name, protection, folder);
            Assert.IsInstanceOf<CellsCloudResponse>(response, "response is CellsCloudResponse");
            Assert.AreEqual(response.Code, 200);
        }

        /// <summary>
        /// Test CellsWorkbookDeleteWorkbookName
        /// </summary>
        [Test]
        public void CellsWorkbookDeleteWorkbookNameTest()
        {
            string name = BOOK1;
            string folder = TEMPFOLDER;
            UpdateDataFile(instance, folder, name);
            var response = instance.CellsWorkbookDeleteWorkbookName(name, "Name_2", folder);
            Assert.IsInstanceOf<CellsCloudResponse>(response, "response is CellsCloudResponse");
            Assert.AreEqual(response.Code, 200);
        }

        /// <summary>
        /// Test CellsWorkbookDeleteWorkbookNames
        /// </summary>
        [Test]
        public void CellsWorkbookDeleteWorkbookNamesTest()
        {
            string name = BOOK1;
            string folder = TEMPFOLDER;
            UpdateDataFile(instance, folder, name);
            var response = instance.CellsWorkbookDeleteWorkbookNames(name, folder);
            Assert.IsInstanceOf<CellsCloudResponse>(response, "response is CellsCloudResponse");
            Assert.AreEqual(response.Code, 200);
        }

        /// <summary>
        /// Test CellsWorkbookGetWorkbookNameValue
        /// </summary>
        [Test]
        public void CellsWorkbookGetWorkbookNameValueTest()
        {
            string name = BOOK1;
            string folder = TEMPFOLDER;
            UpdateDataFile(instance, folder, name);
            var response = instance.CellsWorkbookGetWorkbookNameValue(name, "Name_2", folder);
            Assert.IsInstanceOf<CellsCloudResponse>(response, "response is CellsCloudResponse");
            Assert.AreEqual(response.Code, 200);
        }

        /// <summary>
        /// Test CellsWorkbookGetWorkBook
        /// </summary>
        [Test]
        public void CellsWorkbookGetWorkBookTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            string password = null;
            string format = "XPS";
            bool? isAutoFit = true;
            bool? onlySaveTable = true;
            string folder = TEMPFOLDER;
            string outPath = null;
            UpdateDataFile(instance, folder, name);
            var response = instance.CellsWorkbookGetWorkbook(name, password, format, isAutoFit, onlySaveTable, folder, null, outPath);
            Assert.IsInstanceOf<System.IO.Stream>(response, "response is System.IO.Stream");
        }
        /// <summary>
        /// Test CellsWorkbookGetWorkBook
        /// </summary>
        [Test]
        public void CellsWorkbookGetMarkdownFormatTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            string password = null;
            string format = "md";
            bool? isAutoFit = true;
            bool? onlySaveTable = true;
            string folder = TEMPFOLDER;
            string outPath = null;
            UpdateDataFile(instance, folder, name);
            var response = instance.CellsWorkbookGetWorkbook(name, password, format, isAutoFit, onlySaveTable, folder, null, outPath);
            Assert.IsInstanceOf<System.IO.Stream>(response, "response is System.IO.Stream");
            WriteResponseStream("markdowntest.md", response);
        }
        /// <summary>
        /// Test CellsWorkbookGetWorkBookDefaultStyle
        /// </summary>
        [Test]
        public void CellsWorkbookGetWorkBookDefaultStyleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            string folder = TEMPFOLDER;
            UpdateDataFile(instance, folder, name);
            var response = instance.CellsWorkbookGetWorkbookDefaultStyle(name, folder);
            Assert.IsInstanceOf<StyleResponse>(response, "response is StyleResponse");
            Assert.AreEqual(response.Code, 200);

        }

        /// <summary>
        /// Test CellsWorkbookGetWorkBookName
        /// </summary>
        [Test]
        public void CellsWorkbookGetWorkBookNameTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            string nameName = "Name_2";
            string folder = TEMPFOLDER;
            UpdateDataFile(instance, folder, name);
            var response = instance.CellsWorkbookGetWorkbookName(name, nameName, folder);
            Assert.IsInstanceOf<NameResponse>(response, "response is NameResponse");
            Assert.AreEqual(response.Code, 200);
        }

        /// <summary>
        /// Test CellsWorkbookGetWorkBookNames
        /// </summary>
        [Test]
        public void CellsWorkbookGetWorkBookNamesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            string folder = TEMPFOLDER;
            UpdateDataFile(instance, folder, name);
            var response = instance.CellsWorkbookGetWorkbookNames(name, folder);
            Assert.IsInstanceOf<NamesResponse>(response, "response is NamesResponse");
            Assert.AreEqual(response.Code, 200);
        }

        /// <summary>
        /// Test CellsWorkbookGetWorkBookTextItems
        /// </summary>
        [Test]
        public void CellsWorkbookGetWorkBookTextItemsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            string folder = TEMPFOLDER;
            UpdateDataFile(instance, folder, name);
            var response = instance.CellsWorkbookGetWorkbookTextItems(name, folder);
            Assert.IsInstanceOf<TextItemsResponse>(response, "response is TextItemsResponse");
            Assert.AreEqual(response.Code, 200);
        }

        /// <summary>
        /// Test CellsWorkbookGetWorkbookSettings
        /// </summary>
        [Test]
        public void CellsWorkbookGetWorkbookSettingsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            string folder = TEMPFOLDER;
            UpdateDataFile(instance, folder, name);
            var response = instance.CellsWorkbookGetWorkbookSettings(name, folder);
            Assert.IsInstanceOf<WorkbookSettingsResponse>(response, "response is WorkbookSettingsResponse");
            Assert.AreEqual(response.Code, 200);
        }

        /// <summary>
        /// Test CellsWorkbookPostAutofitWorkbookRows
        /// </summary>
        [Test]
        public void CellsWorkbookPostAutofitWorkbookRowsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            AutoFitterOptions autoFitterOptions = new AutoFitterOptions();
            int? startRow = 1;
            int? endRow = 100;
            bool? onlyAuto = true;
            string folder = TEMPFOLDER;
            UpdateDataFile(instance, folder, name);
            var response = instance.CellsWorkbookPostAutofitWorkbookRows(name, autoFitterOptions, startRow, endRow, onlyAuto, folder);
            Assert.IsInstanceOf<CellsCloudResponse>(response, "response is CellsCloudResponse");
            Assert.AreEqual(response.Code, 200);
        }
        /// <summary>
        /// Test CellsWorkbookPostAutofitWorkbookRows
        /// </summary>
        [Test]
        public void CellsWorkbookPostAutofitWorkbookColumnsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            AutoFitterOptions autoFitterOptions = new AutoFitterOptions();
            int? startColumn = 1;
            int? endColumn = 100;
            string folder = TEMPFOLDER;
            UpdateDataFile(instance, folder, name);
            var response = instance.CellsWorkbookPostAutofitWorkbookColumns(name, autoFitterOptions, startColumn, endColumn,  folder);
            Assert.IsInstanceOf<CellsCloudResponse>(response, "response is CellsCloudResponse");
            Assert.AreEqual(response.Code, 200);
        }

        /// <summary>
        /// Test CellsWorkbookPostEncryptDocument
        /// </summary>
        [Test]
        public void CellsWorkbookPostEncryptDocumentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            WorkbookEncryptionRequest encryption = new WorkbookEncryptionRequest();
            encryption.Password = "123456";
            encryption.KeyLength = 128;
            encryption.EncryptionType = "XOR";
            string folder = TEMPFOLDER;
            UpdateDataFile(instance, folder, name);
            var response = instance.CellsWorkbookPostEncryptDocument(name, encryption, folder);
            Assert.IsInstanceOf<CellsCloudResponse>(response, "response is CellsCloudResponse");
            Assert.AreEqual(response.Code, 200);
        }

        /// <summary>
        /// Test CellsWorkbookPostImportData
        /// </summary>
        [Test]
        public void CellsWorkbookPostImportDataTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            ImportIntArrayOption data = new ImportIntArrayOption();
            data.DestinationWorksheet = SHEET1;
            data.FirstColumn = 1;
            data.FirstRow = 3;
            data.ImportDataType = "IntArray";
            data.IsVertical = true;
            data.Data = new List<int?> { 1, 2, 3, 4 };
            string folder = TEMPFOLDER;
            UpdateDataFile(instance, TEMPFOLDER, BOOK1);
            var response = instance.CellsWorkbookPostImportData(name, data, folder);
            Assert.IsInstanceOf<CellsCloudResponse>(response, "response is CellsCloudResponse");

            Assert.AreEqual(response.Code, 200);
        }

        /// <summary>
        /// Test CellsWorkbookPostProtectDocument
        /// </summary>
        [Test]
        public void CellsWorkbookPostProtectDocumentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            WorkbookProtectionRequest protection = new WorkbookProtectionRequest();
            protection.Password = "123";
            protection.ProtectionType = "All";
            string folder = TEMPFOLDER;
            UpdateDataFile(instance, folder, name);
            var response = instance.CellsWorkbookPostProtectDocument(name, protection, folder);
            Assert.IsInstanceOf<CellsCloudResponse>(response, "response is CellsCloudResponse");
            Assert.AreEqual(response.Code, 200);
        }

        /// <summary>
        /// Test CellsWorkbookPostWorkbookCalculateFormula
        /// </summary>
        [Test]
        public void CellsWorkbookPostWorkbookCalculateFormulaTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            CalculationOptions options = new CalculationOptions();
            options.IgnoreError = true;
            bool? ignoreError = true;
            string folder = TEMPFOLDER;
            UpdateDataFile(instance, folder, name);
            var response = instance.CellsWorkbookPostWorkbookCalculateFormula(name, options, ignoreError, folder);
            Assert.IsInstanceOf<CellsCloudResponse>(response, "response is CellsCloudResponse");
            Assert.AreEqual(response.Code, 200);
        }

        /// <summary>
        /// Test CellsWorkbookPostWorkbookGetSmartMarkerResult
        /// </summary>
        [Test]
        public void CellsWorkbookPostWorkbookGetSmartMarkerResultTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            string xmlFile = "ReportData.xml";
            string folder = TEMPFOLDER;
            string outPath = null;
            UpdateDataFile(instance, folder, name);
            UpdateDataFile(instance, xmlFile);
            var response = instance.CellsWorkbookPostWorkbookGetSmartMarkerResult(name, xmlFile, folder, outPath);
            Assert.IsInstanceOf<System.IO.Stream>(response, "response is System.IO.Stream");
        }

        /// <summary>
        /// Test CellsWorkbookPostWorkbookSettings
        /// </summary>
        [Test]
        public void CellsWorkbookPostWorkbookSettingsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            WorkbookSettings settings = new WorkbookSettings();
            settings.AutoCompressPictures = true;
            string folder = TEMPFOLDER;
            UpdateDataFile(instance, folder, name);
            var response = instance.CellsWorkbookPostWorkbookSettings(name, settings, folder);
            Assert.IsInstanceOf<CellsCloudResponse>(response, "response is CellsCloudResponse");
            Assert.AreEqual(response.Code, 200);
        }

        /// <summary>
        /// Test CellsWorkbookPostWorkbookSplit
        /// </summary>
        [Test]
        public void CellsWorkbookPostWorkbookSplitTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            string format = "png";
            int? from = 1;
            int? to = 3;
            int? horizontalResolution = 100;
            int? verticalResolution = 90;
            string folder = TEMPFOLDER;
            UpdateDataFile(instance, folder, name);
            var response = instance.CellsWorkbookPostWorkbookSplit(name, format, from, to, horizontalResolution, verticalResolution, folder);
            Assert.IsInstanceOf<SplitResultResponse>(response, "response is SplitResultResponse");
            Assert.AreEqual(response.Code, 200);
        }

        /// <summary>
        /// Test CellsWorkbookPostWorkbooksMerge
        /// </summary>
        [Test]
        public void CellsWorkbookPostWorkbooksMergeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            string mergeWith = "myDocument.xlsx";
            string folder = TEMPFOLDER;
            UpdateDataFile(instance, folder, name);
            UpdateDataFile(instance, mergeWith);
            var response = instance.CellsWorkbookPostWorkbooksMerge(name, mergeWith, folder);
            Assert.IsInstanceOf<WorkbookResponse>(response, "response is WorkbookResponse");
            Assert.AreEqual(response.Code, 200);
        }

        /// <summary>
        /// Test CellsWorkbookPostWorkbooksTextReplace
        /// </summary>
        [Test]
        public void CellsWorkbookPostWorkbooksTextReplaceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            string oldValue = "!22";
            string newValue = "22";
            string folder = TEMPFOLDER;
            UpdateDataFile(instance, folder, name);
            var response = instance.CellsWorkbookPostWorkbooksTextReplace(name, oldValue, newValue, folder);
            Assert.IsInstanceOf<WorkbookReplaceResponse>(response, "response is WorkbookReplaceResponse");
        }

        /// <summary>
        /// Test CellsWorkbookPostWorkbooksTextSearch
        /// </summary>
        [Test]
        public void CellsWorkbookPostWorkbooksTextSearchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            string text = "test";
            string folder = TEMPFOLDER;
            UpdateDataFile(instance, folder, name);
            var response = instance.CellsWorkbookPostWorkbooksTextSearch(name, text, folder);
            Assert.IsInstanceOf<TextItemsResponse>(response, "response is TextItemsResponse");
            Assert.AreEqual(response.Code, 200);

        }

        /// <summary>
        /// Test CellsWorkbookPutConvertWorkBook
        /// </summary>
        [Test]
        public void CellsWorkbookPutConvertWorkBookTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string workbook = BOOK1;
            string format = "pdf";
            string password = null;
            string outPath = null;
            UpdateDataFile(instance, TEMPFOLDER, BOOK1);
            var response = instance.CellsWorkbookPutConvertWorkbook(GetTestDataStream(workbook), format, password, outPath);
            Assert.IsInstanceOf<System.IO.Stream>(response, "response is System.IO.Stream");
            //WriteResponseStream(workbook + "." + format, response);
        }

        /// <summary>
        /// Test CellsWorkbookPutConvertWorkBook
        /// </summary>
        [Test]
        public void CellsWorkbookPutConvertMDTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string workbook = BOOK1;
            string format = "md";
            string password = null;
            string outPath = null;
            UpdateDataFile(instance, TEMPFOLDER, BOOK1);
            var response = instance.CellsWorkbookPutConvertWorkbook(GetTestDataStream(workbook), format, password, outPath);
            Assert.IsInstanceOf<System.IO.Stream>(response, "response is System.IO.Stream");
            //WriteResponseStream(workbook + "." + format, response);
        }

        /// <summary>
        /// Test CellsWorkbookPutDocumentProtectFromChanges
        /// </summary>
        [Test]
        public void CellsWorkbookPutDocumentProtectFromChangesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            PasswordRequest password = new PasswordRequest();
            password.Password = "123456";
            string folder = TEMPFOLDER;
            UpdateDataFile(instance, folder, name);
            var response = instance.CellsWorkbookPutDocumentProtectFromChanges(name, password, folder);
            Assert.IsInstanceOf<CellsCloudResponse>(response, "response is CellsCloudResponse");
            Assert.AreEqual(response.Code, 200);

        }

        /// <summary>
        /// Test CellsWorkbookPutWorkbookCreate
        /// </summary>
        [Test]
        public void CellsWorkbookPutWorkbookCreateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = "NewBook" + Guid.NewGuid().ToString() + ".xlsx";
            string templateFile = BOOK1;
            string dataFile = "ReportData.xml";
            string folder = TEMPFOLDER;
            UpdateDataFile(instance, folder, templateFile);
            UpdateDataFile(instance, folder, dataFile);
            var response = instance.CellsWorkbookPutWorkbookCreate(name, folder + "/" + templateFile, folder + "/" + dataFile, false, folder);
            Assert.IsInstanceOf<WorkbookResponse>(response, "response is WorkbookResponse");
            Assert.AreEqual(response.Code, 200);

        }

        //[Ignore("Ignore DropBox")]
        [Test]
        public void CellsWorkbookPostWorkbooksTextSearchTestForDropBox()
        {
            if(IsDockerTest)
            {
                Assert.IsTrue(true);
                return;
            }
            string name = BOOK1;
            string text = "test";
            string folder = TEMPFOLDER;
            UpdateDataFileToOtherStorage(instance, folder, name, "DropBox");
            var response = instance.CellsWorkbookPostWorkbooksTextSearch(name, text, folder, "DropBox");
            Assert.IsInstanceOf<TextItemsResponse>(response, "response is TextItemsResponse");
            Assert.AreEqual(response.Code, 200);
        }

        [Test]
        public void CellsWorkbookPostWorkbookSaveAsTestForDropBox()
        {
            if (IsDockerTest)
            {
                Assert.IsTrue(true);
                return;
            }
            string name = BOOK1;
            string folder = TEMPFOLDER;
            UpdateDataFileToOtherStorage(instance, folder, name, "DropBox");
            SaveOptions saveOptions = new SaveOptions();
            saveOptions.SaveFormat = "xml";
            var response = instance.CellsSaveAsPostDocumentSaveAs(name, saveOptions,  BOOK1+".xml", null,null,folder, "DropBox");
            Assert.IsInstanceOf<SaveResponse>(response, "response is SaveResponse");
            Assert.AreEqual(response.Code, 200);
        }
        /// <summary>
        /// Test CellsWorkbookPutBackgroupTest
        /// </summary>
        [Test]
        public void CellsWorkbookPutBackgroupTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            string folder = TEMPFOLDER;
            UpdateDataFile(instance, folder, name);
            var response = instance.CellsWorkbookPutWorkbookBackground(name, GetTestDataByteArray("WaterMark.png"), folder);
            Assert.IsInstanceOf<CellsCloudResponse>(response, "response is WorkbookResponse");
            Assert.AreEqual(response.Code, 200);

        }

        /// <summary>
        /// Test CellsWorkbookPutBackgroupTest
        /// </summary>
        [Test]
        public void CellsWorkbookDeleteBackgroupTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            string folder = TEMPFOLDER;
            UpdateDataFile(instance, folder, name);
            var response = instance.CellsWorkbookDeleteWorkbookBackground(name, folder);
            Assert.IsInstanceOf<CellsCloudResponse>(response, "response is WorkbookResponse");
            Assert.AreEqual(response.Code, 200);
        }

        /// <summary>
        /// Test CellsWorkbookPutWorkbookCreate
        /// </summary>
        [Test]
        public void CellsWorkbookPutWorkbookCreateNewTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = "NewBook" + DateTime.Now.ToString("yymmddhhmiss") + ".xlsx";
            string templateFile = BOOK1;
            string dataFile = "ReportData.xml";
            string folder = TEMPFOLDER;
            UpdateDataFile(instance, folder, templateFile);
            UpdateDataFile(instance, folder, dataFile);
            var response = instance.CellsWorkbookPutWorkbookCreate(name, folder + "/" + templateFile, folder + "/" + dataFile, false, folder);
            Assert.IsInstanceOf<CellsCloudResponse>(response, "response is WorkbookResponse");
            Assert.AreEqual(response.Code, 200);

        }

        [Test]
        public void CellsWorkbookPutWorkbookWatermarkerTest()
        {
            // TODO uncomment below to test the method and replace null with proper value

            string name = BOOK1;
            string folder = TEMPFOLDER;
            TextWaterMarkerRequest textWaterMarkerRequest = new TextWaterMarkerRequest();
            textWaterMarkerRequest.Text = "Aspose.Cells Cloud";
            textWaterMarkerRequest.FontSize = 25;
            UpdateDataFile(instance, folder, name);
            var response = instance.CellsWorkbookPutWorkbookWaterMarker(name, folder , null, textWaterMarkerRequest);
            Assert.IsInstanceOf<CellsCloudResponse>(response, "response is WorkbookResponse");
            Assert.AreEqual(response.Code, 200);
        }

        [Test]
        public void CellsWorkbookGetPageCountTest()
        {
            // TODO uncomment below to test the method and replace null with proper value

            string name = BOOK1;
            string folder = TEMPFOLDER;
           
            UpdateDataFile(instance, folder, name);
            var response = instance.CellsWorkbookGetPageCount(name, folder);
            Assert.IsInstanceOf<long>(response, "response is WorkbookResponse");
            Assert.Greater((long)response ,0);
        }
    }

}
