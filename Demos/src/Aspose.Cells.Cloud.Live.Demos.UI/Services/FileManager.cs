using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.IO;
using System.Diagnostics;
using System.Net.Http.Headers;
using Aspose.Cells.Cloud.Live.Demos.UI.Config;
using Aspose.Cells.Cloud.Live.Demos.UI.Models;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Model;
using System.Net;
using System.Web.Http;

namespace Aspose.Cells.Cloud.Live.Demos.UI.Services
{
    public static class FileManager
    {
		
		public static FileUploadResult UploadFile( System.Web.HttpPostedFileBase postedFile)
		{
			FileUploadResult uploadResult = null;
			string fn = "";
			CellsApi cellsApi = new CellsApi(Config.Configuration.AppSID, Config.Configuration.AppKey);
			try
			{
				string folderName = Guid.NewGuid().ToString();

				// Prepare a path in which the result file will be
				string uploadPath = Config.Configuration.WorkingDirectory + "\\" + folderName;

				// Check directroy already exist or not
				if (!Directory.Exists(uploadPath))
					Directory.CreateDirectory(uploadPath);

				// Check if File is available.
				if (postedFile != null && postedFile.ContentLength > 0)
				{
					fn = System.IO.Path.GetFileName(postedFile.FileName);

					postedFile.SaveAs(uploadPath + "\\" + fn);
				}

				// Upload original document to Cloud Storage
				cellsApi.UploadFile(fn, File.Open(uploadPath + "\\" + fn, FileMode.Open),  null);

				
				// Create response
				return new FileUploadResult
				{
					FileName = fn,
					FolderId = ""
				};
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex.Message);
			}
			return uploadResult;
		}
		
		
       
		
	}
}
