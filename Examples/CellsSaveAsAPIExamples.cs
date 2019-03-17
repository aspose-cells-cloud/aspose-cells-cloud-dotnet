       
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
    public class CellsSaveAsApiExamples
    {
        private CellsSaveAsApi instance = new CellsSaveAsApi(new Config().GetConfiguration());


        public void CellsSaveAsPostDocumentSaveAsTest()
        {

            string name = "Book1.xlsx";
            SaveOptions saveOptions = null;
            string newfilename = "newbook.xlsx";
            bool? isAutoFitRows = true;
            bool? isAutoFitColumns = true;
            string folder = null;
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsSaveAsPostDocumentSaveAs(name, saveOptions, newfilename, isAutoFitRows, isAutoFitColumns, folder);
            Console.WriteLine(response);
        }

        public void CellsSaveAsPostDocumentSaveAsPDFTest()
        {

            string name = "Book1.xlsx";
            PdfSaveOptions saveOptions = new PdfSaveOptions();
            saveOptions.OnePagePerSheet = true;
            saveOptions.SaveFormat = "pdf";
            string newfilename = "newbook.xlsx";
            bool? isAutoFitRows = true;
            bool? isAutoFitColumns = true;
            string folder = null;
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsSaveAsPostDocumentSaveAs(name, saveOptions, newfilename, isAutoFitRows, isAutoFitColumns, folder);
            Console.WriteLine(response);
        }
    }
}