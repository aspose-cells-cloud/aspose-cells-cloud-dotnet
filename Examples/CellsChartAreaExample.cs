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
    public class CellsChartAreaApiExample
    {
        private CellsChartAreaApi instance= new CellsChartAreaApi(new Config().GetConfiguration());

        public void CellsChartAreaGetChartAreaExample()
        {
            string name = "myDocument.xlsx";
            string sheetName = "SHEET3";
            int? chartIndex = 0;
            string folder = null;
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsChartAreaGetChartArea(name, sheetName, chartIndex, folder);
            Console.WriteLine(response);
        }
        

        public void CellsChartAreaGetChartAreaBorderExample()
        {
            string name = "myDocument.xlsx";
            string sheetName = "SHEET3";
            int? chartIndex = 0;
            string folder = null;
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsChartAreaGetChartAreaBorder(name, sheetName, chartIndex, folder);
            Console.WriteLine(response);
        }
        

        public void CellsChartAreaGetChartAreaFillFormatExample()
        {
            string name = "myDocument.xlsx";
            string sheetName = "SHEET3";
            int? chartIndex = 0;
            string folder = null;
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsChartAreaGetChartAreaFillFormat(name, sheetName, chartIndex, folder);
            Console.WriteLine(response);
        }
        
    }
}