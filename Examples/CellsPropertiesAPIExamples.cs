   
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
    public class CellsPropertiesApiTests
    {
        private CellsPropertiesApi instance= new CellsPropertiesApi(new Config().GetConfiguration());



        

        public void CellsPropertiesDeleteDocumentPropertiesTest()
        {

            string name = "Book1.xlsx";
            string folder = null;
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsPropertiesDeleteDocumentProperties(name, folder);
             Console.WriteLine(response);
        }
        

        public void CellsPropertiesDeleteDocumentPropertyTest()
        {

            string name = "Book1.xlsx";
            string propertyName = "Author";
            string folder = null;
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsPropertiesDeleteDocumentProperty(name, propertyName, folder);
            Console.WriteLine(response);
        }
        

        public void CellsPropertiesGetDocumentPropertiesTest()
        {

            string name = "Book1.xlsx";
            string folder = null;
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsPropertiesGetDocumentProperties(name, folder);
            Console.WriteLine(response);
        }
        

        public void CellsPropertiesGetDocumentPropertyTest()
        {

            string name = "Book1.xlsx";
            string propertyName = "Author";
            string folder = null;
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsPropertiesGetDocumentProperty(name, propertyName, folder);
            Console.WriteLine(response);
        }
        

        public void CellsPropertiesPutDocumentPropertyTest()
        {

            string name = "Book1.xlsx";
            string propertyName = "Name";
            CellsDocumentProperty property = new CellsDocumentProperty();
            //(null, "Author", "Val"
            property.Name = "Author";
            property.Value = "Val";
            string folder = null;
            new Config().UpdateDataFile(folder, name);
            var response = instance.CellsPropertiesPutDocumentProperty(name, propertyName, property, folder);
            Console.WriteLine(response);
        }
        
    }
}