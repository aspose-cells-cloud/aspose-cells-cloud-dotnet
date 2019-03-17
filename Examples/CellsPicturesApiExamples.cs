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
   public class CellsPicturesApExamples
    {
        private CellsPicturesApi instance = new CellsPicturesApi(new Config().GetConfiguration());


        public void CellsPicturesDeleteWorkSheetPicturesTest()
        {

            string name = "Book1.xlsx";
            string sheetName = "SHEET6";
            string folder = null;
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsPicturesDeleteWorksheetPictures(name, sheetName, folder);
            Console.WriteLine(response);
        }
        

        public void CellsPicturesDeleteWorksheetPictureTest()
        {

            string name = "Book1.xlsx";
            string sheetName = "SHEET6";
            int? pictureIndex = 0;
            string folder = null;
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsPicturesDeleteWorksheetPicture(name, sheetName, pictureIndex, folder);
            Console.WriteLine(response);
        }

        public void CellsPicturesGetWorksheetPictureTest()
        {

            string name = "Book1.xlsx";
            string sheetName = "SHEET6";
            int? pictureNumber = 0;
            string format = null;
            string folder = null;
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsPicturesGetWorksheetPicture(name, sheetName, pictureNumber, format,folder);
            Console.WriteLine(response);
        }
        

        public void CellsPicturesGetWorksheetPicturesTest()
        {

            string name = "Book1.xlsx";
            string sheetName = "SHEET6";
            string folder = null;
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsPicturesGetWorksheetPictures(name, sheetName, folder);
            Console.WriteLine(response);

        }

        public void CellsPicturesPostWorkSheetPictureTest()
        {

            string name = "Book1.xlsx";
            string sheetName = "SHEET6";
            int? pictureIndex = 0;
            Picture picture = new Picture ();
            picture.Left = 10;
            string folder = null;
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsPicturesPostWorksheetPicture(name, sheetName, pictureIndex, picture, folder);
            Console.WriteLine(response);

        }


        public void CellsPicturesPutWorksheetAddPictureTest()
        {

            string name = "Book1.xlsx";
            string sheetName = "SHEET6";
            Picture picture =null;
            int? upperLeftRow = 1;
            int? upperLeftColumn = 1;
            int? lowerRightRow = 10;
            int? lowerRightColumn = 10;
            string picturePath = "WaterMark.png";
            string folder = null;
            new Config().UpdateDataFile(folder, name);
            new Config().UpdateDataFile(folder, picturePath);
            var response = instance.CellsPicturesPutWorksheetAddPicture(name, sheetName,picture, upperLeftRow, upperLeftColumn, lowerRightRow, lowerRightColumn, folder + "/" + picturePath, folder);
           Console.WriteLine(response);

        }

    }
}