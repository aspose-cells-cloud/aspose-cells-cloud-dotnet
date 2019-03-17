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
    public class CellsAutoshapesApiExamples
    {


        private CellsAutoshapesApi instance=new CellsAutoshapesApi(new Config().GetConfiguration());

        
        public void CellsAutoshapesGetWorksheetAutoshapeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = "myDocument.xlsx";
            string sheetName = "SHEET2";
            int? autoshapeNumber = 4;
            string folder = null;
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsAutoshapesGetWorksheetAutoshape(name, sheetName, autoshapeNumber, "PNG", folder);
            Console.WriteLine(response);
        }

        public void CellsAutoshapesGetWorksheetAutoshapeDTOTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = "myDocument.xlsx";
            string sheetName = "SHEET2";
            int? autoshapeNumber = 4;
            string folder = null;
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsAutoshapesGetWorksheetAutoshape(name, sheetName, autoshapeNumber, null, folder);
            Console.WriteLine(response);
        }

        public void CellsAutoshapesGetWorksheetAutoshapesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = "myDocument.xlsx";
            string sheetName = "SHEET2";
            string folder = null;
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsAutoshapesGetWorksheetAutoshapes(name, sheetName, folder);
            Console.WriteLine(response);
        }
    }
}