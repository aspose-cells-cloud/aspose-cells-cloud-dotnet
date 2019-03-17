                   
    using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Model;

namespace cells_cloud_charp
{ 
    public class CellsWorkbookApiExamples
    {
        private CellsWorkbookApi instance;

        public void Init()
        {
            instance = new CellsWorkbookApi(new Config().GetConfiguration());
        }

        public void CellsWorkbookDeleteDecryptDocumentTest()
        {

            string name = "Book1.xlsx";
            WorkbookEncryptionRequest encryption = new WorkbookEncryptionRequest();
            encryption.Password = "123456";
            encryption.KeyLength = 128;
            encryption.EncryptionType = "XOR";
            string folder = null;
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsWorkbookDeleteDecryptDocument(name, encryption, folder);
            Console.WriteLine(response);
        }
        

        public void CellsWorkbookDeleteDocumentUnProtectFromChangesTest()
        {

            string name = "Book1.xlsx";
            string folder = null;
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsWorkbookDeleteDocumentUnprotectFromChanges(name, folder);
            Console.WriteLine(response);
        }
        

        public void CellsWorkbookDeleteUnProtectDocumentTest()
        {

            string name = "Book1.xlsx";
            WorkbookProtectionRequest protection = new WorkbookProtectionRequest();
            protection.Password = "123";
            protection.ProtectionType = "All";
            string folder = null;
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsWorkbookDeleteUnprotectDocument(name, protection, folder);
            Console.WriteLine(response);
        }


        public void CellsWorkbookDeleteWorkbookNameTest()
        {
            string name = "Book1.xlsx";
            string folder = null;
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsWorkbookDeleteWorkbookName(name, "Name_2", folder);
            Console.WriteLine(response);
        }

 
        public void CellsWorkbookDeleteWorkbookNamesTest()
        {
            string name = "Book1.xlsx";
            string folder = null;
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsWorkbookDeleteWorkbookNames(name, folder);
            Console.WriteLine(response);
        }


        public void CellsWorkbookGetWorkbookNameValueTest()
        {
            string name = "Book1.xlsx";
            string folder = null;
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsWorkbookGetWorkbookNameValue(name, "Name_2", folder);
            Console.WriteLine(response);
        }

        public void CellsWorkbookGetWorkBookTest()
        {

            string name = "Book1.xlsx";
            string password = null;
            string format = "XPS";
            bool? isAutoFit = true;
            bool? onlySaveTable = true;
            string folder = null;
            string outPath = null;
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsWorkbookGetWorkbook(name, password, format, isAutoFit, onlySaveTable, folder,null, outPath);
            Console.WriteLine(response);
        }
        
 
        public void CellsWorkbookGetWorkBookDefaultStyleTest()
        {

            string name = "Book1.xlsx";
            string folder = null;
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsWorkbookGetWorkbookDefaultStyle(name, folder);
            Console.WriteLine(response);

        }


        public void CellsWorkbookGetWorkBookNameTest()
        {

            string name = "Book1.xlsx";
            string nameName = "Name_2";
            string folder = null;
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsWorkbookGetWorkbookName(name, nameName, folder);
           Console.WriteLine(response);
        }

        public void CellsWorkbookGetWorkBookNamesTest()
        {

            string name = "Book1.xlsx";
            string folder = null;
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsWorkbookGetWorkbookNames(name, folder);
            Console.WriteLine(response);
        }
        

        public void CellsWorkbookGetWorkBookTextItemsTest()
        {

            string name = "Book1.xlsx";
            string folder = null;
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsWorkbookGetWorkbookTextItems(name, folder);
            Console.WriteLine(response);
        }
        

        public void CellsWorkbookGetWorkbookSettingsTest()
        {

            string name = "Book1.xlsx";
            string folder = null;
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsWorkbookGetWorkbookSettings(name, folder);
           Console.WriteLine(response);
        }

        public void CellsWorkbookPostAutofitWorkbookRowsTest()
        {

            string name = "Book1.xlsx";
            AutoFitterOptions autoFitterOptions = null;
            int? startRow = 1;
            int? endRow = 100;
            bool? onlyAuto = true;
            string folder = null;
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsWorkbookPostAutofitWorkbookRows(name, autoFitterOptions, startRow, endRow, onlyAuto, folder);
            Console.WriteLine(response);
        }
        

        public void CellsWorkbookPostEncryptDocumentTest()
        {

            string name = "Book1.xlsx";
            WorkbookEncryptionRequest encryption = new WorkbookEncryptionRequest ();
            encryption.Password = "123456";
            encryption.KeyLength = 128;
            encryption.EncryptionType = "XOR";
            string folder = null;
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsWorkbookPostEncryptDocument(name, encryption, folder);
            Console.WriteLine(response);
        }
        

        public void CellsWorkbookPostImportDataTest()
        {

            string name = "Book1.xlsx";
            ImportIntArrayOption data = new ImportIntArrayOption();
            data.DestinationWorksheet = SHEET1;
            data.FirstColumn = 1;
            data.FirstRow = 3;
            data.ImportDataType = "IntArray";
            data.IsVertical = true;
            data.Data = new List<int?> { 1, 2, 3, 4 };
            string folder = null;
            new Config().UpdateDataFile(null, "Book1.xlsx");
            var response = instance.CellsWorkbookPostImportData(name, data, folder);
            Console.WriteLine(response);
        }
        

        public void CellsWorkbookPostProtectDocumentTest()
        {

            string name = "Book1.xlsx";
            WorkbookProtectionRequest protection = new WorkbookProtectionRequest();
            protection.Password = "123";
            protection.ProtectionType = "All";
            string folder = null;
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsWorkbookPostProtectDocument(name, protection, folder);
            Console.WriteLine(response);
        }

        public void CellsWorkbookPostWorkbookCalculateFormulaTest()
        {

            string name = "Book1.xlsx";
            CalculationOptions options = new CalculationOptions ();
            options.IgnoreError = true;
            bool? ignoreError = true;
            string folder = null;
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsWorkbookPostWorkbookCalculateFormula(name, options, ignoreError, folder);
            Console.WriteLine(response);
        }
        

        public void CellsWorkbookPostWorkbookGetSmartMarkerResultTest()
        {

            string name = "Book1.xlsx";
            string xmlFile = "ReportData.xml";
            string folder = null;
            string outPath = null;
            new Config().UpdateDataFile(folder, name);
            new Config().UpdateDataFile("", xmlFile);
            var response = instance.CellsWorkbookPostWorkbookGetSmartMarkerResult(name, xmlFile, folder, outPath);
            Console.WriteLine(response);
        }
        

        public void CellsWorkbookPostWorkbookSettingsTest()
        {

            string name = "Book1.xlsx";
            WorkbookSettings settings = new WorkbookSettings();
            settings.AutoCompressPictures = true;
            string folder = null;
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsWorkbookPostWorkbookSettings(name, settings, folder);
            Console.WriteLine(response);
        }
        

        public void CellsWorkbookPostWorkbookSplitTest()
        {

            string name = "Book1.xlsx";
            string format = "png";
            int? from = 1;
            int? to = 3;
            int? horizontalResolution = 100;
            int? verticalResolution = 90;
            string folder = null;
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsWorkbookPostWorkbookSplit(name, format, from, to, horizontalResolution, verticalResolution, folder);
            Console.WriteLine(response);
        }
        

        public void CellsWorkbookPostWorkbooksMergeTest()
        {

            string name = "Book1.xlsx";
            string mergeWith = "myDocument.xlsx";
            string folder = null;
            new Config().UpdateDataFile(folder, name);
            new Config().UpdateDataFile("", mergeWith);
            var response = instance.CellsWorkbookPostWorkbooksMerge(name, mergeWith, folder);
            Console.WriteLine(response);
        }
        

        public void CellsWorkbookPostWorkbooksTextReplaceTest()
        {

            string name = "Book1.xlsx";
            string oldValue = "!22";
            string newValue = "22";
            string folder = null;
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsWorkbookPostWorkbooksTextReplace(name, oldValue, newValue, folder);
            Console.WriteLine(response);
        }
        

        public void CellsWorkbookPostWorkbooksTextSearchTest()
        {

            string name = "Book1.xlsx";
            string text = "test";
            string folder = null;
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsWorkbookPostWorkbooksTextSearch(name, text, folder);
           Console.WriteLine(response);

        }





        public void CellsWorkbookPutDocumentProtectFromChangesTest()
        {

            string name = "Book1.xlsx";
            PasswordRequest password = new PasswordRequest();
            password.Password = "123456";
            string folder = null;
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsWorkbookPutDocumentProtectFromChanges(name, password, folder);
            Console.WriteLine(response);

        }
        public void CellsWorkbookPutWorkbookCreateTest()
        {

            string name ="NewBook" + DateTime.Now.ToString("yymmddhhmiss")+".xlsx" ;
            string templateFile = "Book1.xlsx";
            string dataFile = "ReportData.xml";
            string folder = null;
            new Config().UpdateDataFile(folder, templateFile);
            new Config().UpdateDataFile(folder, dataFile);
            var response = instance.CellsWorkbookPutWorkbookCreate(name, folder + "/" + templateFile, folder +"/"+ dataFile, folder);
            Console.WriteLine(response);

        }

       
    }
}