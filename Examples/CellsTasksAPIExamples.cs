               
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
    public class CellsTaskApiExamples
    {
        private CellsTaskApi instance;

        public void Init()
        {
            instance = new CellsTaskApi(new Config().GetConfiguration());
        }

        public void CellsTaskPostRunTaskTest()
        {
            string name = "Book1.xlsx";
            string sheetName = "SHEET6";
            string folder = null;
            new Config().UpdateDataFile(folder, name);

            TaskData taskData = new TaskData();
            taskData.Tasks = new List<TaskDescription>();
            TaskDescription task1 = new TaskDescription();
            task1.TaskType = "SplitWorkbook";

            SplitWorkbookTaskParameter param1 = new SplitWorkbookTaskParameter();
            param1.DestinationFileFormat = "xlsx";
            param1.DestinationFilePosition = new FileSource();
            param1.DestinationFilePosition.FilePath = null;
            param1.DestinationFilePosition.FileSourceType = "CloudFileSystem";
            param1.SplitNameRule = "sheetname";
            param1.Workbook = new FileSource();
            param1.Workbook.FileSourceType = "CloudFileSystem";
            param1.Workbook.FilePath = "Book1.xlsx";
            task1.TaskParameter = param1;
            taskData.Tasks.Add(task1);
            var response = instance.CellsTaskPostRunTask(taskData);
            Console.WriteLine(response);
        }
        
    }
}