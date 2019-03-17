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
   public class CellsChartsApiTests
    {      
        CellsChartsApi instance = new CellsChartsApi(new Config().GetConfiguration ());
        public void CellsChartsDeleteWorksheetChartLegendTest()
        {

            string name = "myDocument.xlsx";
            string sheetName = "SHEET3";
            int? chartIndex = 1;
            string folder = null;
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsChartsDeleteWorksheetChartLegend(name, sheetName, chartIndex, folder);
            Console.WriteLine(response);
        }

        public void CellsChartsDeleteWorksheetChartTitleTest()
        {

            string name = "myDocument.xlsx";
            string sheetName = "SHEET3";
            int? chartIndex = 0;
            string folder = null;
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsChartsDeleteWorksheetChartTitle(name, sheetName, chartIndex, folder);
            Console.WriteLine(response);
        }
        

        public void CellsChartsDeleteWorksheetClearChartsTest()
        {

            string name = "myDocument.xlsx";
            string sheetName = "SHEET3";
            string folder = null;
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsChartsDeleteWorksheetClearCharts(name, sheetName, folder);
            Console.WriteLine(response);
        }
        

        public void CellsChartsDeleteWorksheetDeleteChartTest()
        {

            string name = "myDocument.xlsx";
            string sheetName = "SHEET3";
            int? chartIndex = 0;
            string folder = null;
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsChartsDeleteWorksheetDeleteChart(name, sheetName, chartIndex, folder);
            Console.WriteLine(response);
        }
        

        public void CellsChartsGetWorksheetChartTest()
        {

            string name = "myDocument.xlsx";
            string sheetName = "SHEET3";
            int? chartNumber = 0;
            string folder = null;
            string format = "png";
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsChartsGetWorksheetChart(name, sheetName, chartNumber, format, folder);
            Console.WriteLine(response);
        }
        

        public void CellsChartsGetWorksheetChartLegendTest()
        {

            string name = "myDocument.xlsx";
            string sheetName = "SHEET3";
            int? chartIndex = 0;
            string folder = null;
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsChartsGetWorksheetChartLegend(name, sheetName, chartIndex, folder);
           Console.WriteLine(response);

        }


        public void CellsChartsGetWorksheetChartTitleTest()
        {

            string name =  "Book1.xlsx";
            string sheetName = "SHEET4";
            int? chartIndex = 0;
            string folder = null;
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsChartsGetWorksheetChartTitle(name, sheetName, chartIndex,  folder);
            Console.WriteLine(response);

        }

        public void CellsChartsGetWorksheetChartsTest()
        {

            string name = "myDocument.xlsx";
            string sheetName = "SHEET3";
            string folder = null;
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsChartsGetWorksheetCharts(name, sheetName, folder);
           Console.WriteLine(response);

        }

        public void CellsChartsPostWorksheetChartTest()
        {

            string name = "myDocument.xlsx";
            string sheetName = "SHEET3";
            int? chartIndex = 0;
            Chart chart = new Chart ();
            chart.AutoScaling = true;

            string folder = null;
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsChartsPostWorksheetChart(name, sheetName, chartIndex, chart, folder);
            Console.WriteLine(response);

        }


        public void CellsChartsPostWorksheetChartLegendTest()
        {

            string name = "myDocument.xlsx";
            string sheetName = "SHEET3";
            int? chartIndex = 0;
            Legend legend = new Legend();
            legend.Width = 10;
            string folder = null;
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsChartsPostWorksheetChartLegend(name, sheetName, chartIndex, legend, folder);
            Console.WriteLine(response);
        }
        

        public void CellsChartsPostWorksheetChartTitleTest()
        {

            string name = "myDocument.xlsx";
            string sheetName = "SHEET3";
            int? chartIndex = 0;
            Title title = new Title();
            title.Text = "Post title";
            string folder = null;
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsChartsPostWorksheetChartTitle(name, sheetName, chartIndex, title, folder);
            Console.WriteLine(response);
        }

        public void CellsChartsPutWorksheetAddChartTest()
        {

            string name = "myDocument.xlsx";
            string sheetName = "SHEET4";
            string chartType = "Pie";
            int? upperLeftRow = 5;
            int? upperLeftColumn = 5;
            int? lowerRightRow = 10;
            int? lowerRightColumn = 10;
            string area = "C7:D11";
            bool? isVertical = true;
            string categoryData = null;
            bool? isAutoGetSerialName = null;
            string title = null;
            string folder = null;
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsChartsPutWorksheetAddChart(name, sheetName, chartType, upperLeftRow, upperLeftColumn, lowerRightRow, lowerRightColumn, area, isVertical, categoryData, isAutoGetSerialName, title, folder);
            Console.WriteLine(response);
        }

        public void CellsChartsPutWorksheetChartLegendTest()
        {

            string name = "myDocument.xlsx";
            string sheetName = "SHEET3";
            int? chartIndex = 0;
            string folder = null;
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsChartsPutWorksheetChartLegend(name, sheetName, chartIndex, folder);
            Console.WriteLine(response);
        }
        

        public void CellsChartsPutWorksheetChartTitleTest()
        {

            string name = "myDocument.xlsx";
            string sheetName = "SHEET3";
            int? chartIndex = 0;
            Title title = new Title();
            title.Text = "New title";
            string folder = null;
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsChartsPutWorksheetChartTitle(name, sheetName, chartIndex, title, folder);
            Console.WriteLine(response);
        }
        
    }
}