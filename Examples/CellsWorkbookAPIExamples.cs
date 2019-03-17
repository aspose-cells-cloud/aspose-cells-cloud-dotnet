                      
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
    public class CellsWorksheetValidationsApiExamples
    {
        private CellsWorksheetValidationsApi instance= new CellsWorksheetValidationsApi(new Config().GetConfiguration());


        public void CellsWorksheetValidationsDeleteWorkSheetValidationTest()
        {

            string name = "Book1.xlsx";
            string sheetName = "SHEET1";
            int? validationIndex = 0;
            string folder = null;
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsWorksheetValidationsDeleteWorksheetValidation(name, sheetName, validationIndex, folder);
            Console.WriteLine(response);
        }

        public void CellsWorksheetValidationsGetWorkSheetValidationTest()
        {

            string name = "Book1.xlsx";
            string sheetName = "SHEET1";
            int? validationIndex = 0;
            string folder = null;
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsWorksheetValidationsGetWorksheetValidation(name, sheetName, validationIndex, folder);
            Console.WriteLine(response);
        }
        

        public void CellsWorksheetValidationsGetWorkSheetValidationsTest()
        {

            string name = "Book1.xlsx";
            string sheetName = "SHEET1";
            string folder = null;
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsWorksheetValidationsGetWorksheetValidations(name, sheetName, folder);
            Console.WriteLine(response);
        }
        

        public void CellsWorksheetValidationsPostWorkSheetValidationTest()
        {

            string name = "Book1.xlsx";
            string sheetName = "SHEET1";
            int? validationIndex = 0;
            Validation validation = new Validation();
            CellArea area = new CellArea();
            area.StartRow = 0;
            area.EndRow = 0;
            area.StartColumn = 0;
            area.EndColumn = 0;
            validation.AreaList = new List<CellArea>();
            validation.AreaList.Add(area);
            validation.Formula1 = "=(OR(A1=\"Yes\",A1=\"No\"))";
            validation.Type = "Custom";
            validation.IgnoreBlank = true;
            string folder = null;
            new Config().UpdateDataFile(folder, name);
            new Config().UpdateDataFile(null, "Book1.xlsx");
            var response = instance.CellsWorksheetValidationsPostWorksheetValidation(name, sheetName, validationIndex, validation, folder);
            Console.WriteLine(response);
        }
        

        public void CellsWorksheetValidationsPutWorkSheetValidationTest()
        {

            string name = "Book1.xlsx";
            string sheetName = "SHEET1";
            string range = "a1:a10";
            string folder = null;
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsWorksheetValidationsPutWorksheetValidation(name, sheetName, range, folder);
            Console.WriteLine(response);
        }
        
    }
}