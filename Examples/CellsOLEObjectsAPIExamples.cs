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
    public class CellsOleObjectsApiExamples
    {
        private CellsOleObjectsApi instance= new CellsOleObjectsApi(new Config().GetConfiguration ());

        public void CellsOleObjectsDeleteWorksheetOleObjectTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = "Book1.xlsx";
            string sheetName = "SHEET6";
            int? oleObjectIndex = 0;
            string folder = null;
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsOleObjectsDeleteWorksheetOleObject(name, sheetName, oleObjectIndex, folder);
           Console.WriteLine(response);
        }


        public void CellsOleObjectsDeleteWorksheetOleObjectsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = "Book1.xlsx";
            string sheetName = "SHEET6";
            string folder = null;
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsOleObjectsDeleteWorksheetOleObjects(name, sheetName, folder);
            Console.WriteLine(response);
        }


        public void CellsOleObjectsGetWorksheetOleObjectTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = "Book1.xlsx";
            string sheetName = "SHEET6";
            int? objectNumber = 0;
            string format = null;
            string folder = null;
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsOleObjectsGetWorksheetOleObject(name, sheetName, objectNumber, format, folder);
            Console.WriteLine(response);
        }


        public void CellsOleObjectsGetWorksheetOleObjectsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = "Book1.xlsx";
            string sheetName = "SHEET6";
            string folder = null;
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsOleObjectsGetWorksheetOleObjects(name, sheetName, folder);
            Console.WriteLine(response);
        }

        public void CellsOleObjectsPostUpdateWorksheetOleObjectTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = "Book1.xlsx";
            string sheetName = "SHEET6";
            int? oleObjectIndex = 0;
            OleObject ole = new OleObject();
            ole.Left = 10;
            ole.Right = 10;
            ole.Height = 90;
            ole.Width = 78;
            string folder = null;
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsOleObjectsPostUpdateWorksheetOleObject(name, sheetName, oleObjectIndex, ole, folder);
            Console.WriteLine(response);
        }

        public void CellsOleObjectsPutWorksheetOleObjectTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = "Book1.xlsx";
            string sheetName = "SHEET6";
            OleObject oleObject = null;
            int? upperLeftRow = 1;
            int? upperLeftColumn = 1;
            int? height = 100;
            int? width = 80;
            string oleFile = "OLEDoc.docx";
            string imageFile = "word.jpg";
            string folder = null;
            new Config().UpdateDataFile(folder, name);
            new Config().UpdateDataFile(folder, oleFile);
            new Config().UpdateDataFile(folder, imageFile);
            var response = instance.CellsOleObjectsPutWorksheetOleObject(name, sheetName, oleObject, upperLeftRow, upperLeftColumn, height, width, folder +"/"+ oleFile, folder + "/" + imageFile, folder);
           Console.WriteLine(response);
        }

    }
}