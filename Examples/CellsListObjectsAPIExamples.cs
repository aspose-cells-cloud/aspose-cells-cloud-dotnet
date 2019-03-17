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
    public class CellsListObjectsApiExamples
    {
        private CellsListObjectsApi instance = new CellsListObjectsApi(new Config().GetConfiguration());




        

        public void CellsListObjectsDeleteWorksheetListObjectTest()
        {

            string name =  "Book1.xlsx";
            string sheetName = "SHEET7";
            int? listObjectIndex = 0;
            string folder = null;
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsListObjectsDeleteWorksheetListObject(name, sheetName, listObjectIndex, folder);
           Console.WriteLine(response);
        }
        
 
        public void CellsListObjectsDeleteWorksheetListObjectsTest()
        {

            string name =  "Book1.xlsx";
            string sheetName = "SHEET7";
            string folder = null;
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsListObjectsDeleteWorksheetListObjects(name, sheetName, folder);
            Console.WriteLine(response);
        }


        public void CellsListObjectsGetWorksheetListObjectTest()
        {

            string name =  "Book1.xlsx";
            string sheetName = "SHEET7";
            int? listobjectindex = 0;
            string folder = null;
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsListObjectsGetWorksheetListObject(name, sheetName, listobjectindex, folder);
            Console.WriteLine(response);
        }


        public void CellsListObjectsGetWorksheetListObjectsTest()
        {

            string name =  "Book1.xlsx";
            string sheetName = "SHEET7";
            string folder = null;
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsListObjectsGetWorksheetListObjects(name, sheetName, folder);
            Console.WriteLine(response);
        }


        public void CellsListObjectsPostWorksheetListObjectTest()
        {

            string name =  "Book1.xlsx";
            string sheetName = "SHEET7";
            int? listObjectIndex = 0;
            ListObject listObject = new ListObject();
            listObject.ShowHeaderRow = true;
            string folder = null;
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsListObjectsPostWorksheetListObject(name, sheetName, listObjectIndex, listObject, folder);
           Console.WriteLine(response);
        }


        public void CellsListObjectsPostWorksheetListObjectConvertToRangeTest()
        {

            string name =  "Book1.xlsx";
            string sheetName = "SHEET7";
            int? listObjectIndex = 0;
            string folder = null;
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsListObjectsPostWorksheetListObjectConvertToRange(name, sheetName, listObjectIndex, folder);
            Console.WriteLine(response);
        }


        public void CellsListObjectsPostWorksheetListObjectSortTableTest()
        {

            string name =  "Book1.xlsx";
            string sheetName = "SHEET7";
            int? listObjectIndex = 0;
            DataSorter dataSorter = new DataSorter();
            dataSorter.CaseSensitive = true;
            string folder = null;
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsListObjectsPostWorksheetListObjectSortTable(name, sheetName, listObjectIndex, dataSorter, folder);
           Console.WriteLine(response);
        }

        public void CellsListObjectsPostWorksheetListObjectSummarizeWithPivotTableTest()
        {

            string name =  "Book1.xlsx";
            string sheetName = "SHEET7";
            int? listObjectIndex = 0;
            string destsheetName = "Sheet2";
            CreatePivotTableRequest request = new CreatePivotTableRequest ();
            request.DestCellName = "C1";
            request.Name = "testp";
            request.PivotFieldColumns = new List<int?>() { 2 };
            request.PivotFieldData = new List<int?>() { 1 };
            request.PivotFieldRows = new List<int?>() { 0 };
            request.SourceData = "=Sheet2!A1:E8";
            request.UseSameSource = true;
            string folder = null;
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsListObjectsPostWorksheetListObjectSummarizeWithPivotTable(name, sheetName, listObjectIndex, destsheetName, request, folder);
            Console.WriteLine(response);
        }


        public void CellsListObjectsPutWorksheetListObjectTest()
        {

            string name =  "Book1.xlsx";
            string sheetName = "SHEET7";
            int? startRow = 1;
            int? startColumn = 1;
            int? endRow = 6;
            int? endColumn = 6;
            string folder = null;
            bool? hasHeaders = null;
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsListObjectsPutWorksheetListObject(name, sheetName, startRow, startColumn, endRow, endColumn, folder,null, hasHeaders);
            Console.WriteLine(response);
        }

    }
}