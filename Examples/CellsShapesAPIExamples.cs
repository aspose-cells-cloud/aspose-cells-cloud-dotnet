           
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
    public class CellsShapesApiExamples
    {
        private CellsShapesApi instance= new CellsShapesApi(new Config().GetConfiguration());

        
        public void CellsShapesDeleteWorksheetShapeTest()
        {

            string name = "Book1.xlsx";
            string sheetName = "SHEET1";
            int? shapeindex = 0;
            string folder = null;
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsShapesDeleteWorksheetShape(name, sheetName, shapeindex, folder);
            Console.WriteLine(response);
        }
        

        public void CellsShapesDeleteWorksheetShapesTest()
        {

            string name = "Book1.xlsx";
            string sheetName = "SHEET1";
            string folder = null;
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsShapesDeleteWorksheetShapes(name, sheetName, folder);
            Console.WriteLine(response);

        }
        

        public void CellsShapesGetWorksheetShapeTest()
        {

            string name = "Book1.xlsx";
            string sheetName = "SHEET1";
            int? shapeindex = 0;
            string folder = null;
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsShapesGetWorksheetShape(name, sheetName, shapeindex, folder);
            Console.WriteLine(response);

        }
        
        public void CellsShapesGetWorksheetShapesTest()
        {

            string name = "Book1.xlsx";
            string sheetName = "SHEET1";
            string folder = null;
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsShapesGetWorksheetShapes(name, sheetName, folder);
            Console.WriteLine(response);

        }
        

        public void CellsShapesPostWorksheetShapeTest()
        {

            string name = "Book1.xlsx";
            string sheetName = "SHEET1";
            int? shapeindex = 0;
            Shape dto = new Shape();
            dto.LowerRightColumn = 10;
            string folder = null;
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsShapesPostWorksheetShape(name, sheetName, shapeindex, dto, folder);
            Console.WriteLine(response);

        }
        

        public void CellsShapesPutWorksheetShapeTest()
        {

            string name = "Book1.xlsx";
            string sheetName = "SHEET1";
            string drawingType = "button";
            int? upperLeftRow = 1;
            int? upperLeftColumn = 1;
            int? top = 10;
            int? left = 10;
            int? width = 100;
            int? height = 90;
            string folder = null;
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsShapesPutWorksheetShape(name, sheetName, drawingType, upperLeftRow, upperLeftColumn, top, left, width, height, folder);
            Console.WriteLine(response);

        }
        
    }
}