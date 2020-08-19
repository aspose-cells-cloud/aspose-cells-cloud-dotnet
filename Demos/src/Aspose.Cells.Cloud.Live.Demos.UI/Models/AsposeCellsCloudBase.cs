using System;
using System.IO;
using System.Web.Http;
using System.Threading.Tasks;
using System.IO.Compression;
using System.Drawing;
using System.Drawing.Imaging;
using Aspose.Cells.Cloud.SDK.Model;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;

namespace  Aspose.Cells.Cloud.Live.Demos.UI.Models
{
	///<Summary>
	/// AsposeCellsCloudBase class to have base methods
	///</Summary>

	public abstract class AsposeCellsCloudBase : ApiController
    {
	 protected	CellsApi cellsApi = new CellsApi(Config.Configuration.AppSID, Config.Configuration.AppKey);
		///<Summary>
		/// Get File extension
		///</Summary>
		protected string GetoutFileExtension(string fileName, string folderName)
        {
			string sourceFolder = Config.Configuration.WorkingDirectory + folderName;
            fileName = sourceFolder + "\\" + fileName;
            return Path.GetExtension(fileName);
        }
		
       
		
    }
}
