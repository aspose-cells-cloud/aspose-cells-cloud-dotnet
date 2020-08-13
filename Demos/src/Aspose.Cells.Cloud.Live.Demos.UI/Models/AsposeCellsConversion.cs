using System.Threading.Tasks;
using System.IO;
using System.Web.Http;
using Aspose.Cells.Cloud.Live.Demos.UI.Models;
using System.Diagnostics;
using Aspose.Cells.Cloud.SDK.Model;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Client;

namespace Aspose.Cells.Cloud.Live.Demos.UI.Models
{
	///<Summary>
	/// Aspose.Cells Cloud API convert method to convert word document file to other format
	///</Summary>
	
	public class AsposeCellsConversion : AsposeCellsCloudBase
    {        
        
		///<Summary>
		/// Convert method to convert file to other format
		///</Summary>
		public Response Convert(string fileName,  string outputType)
        {			
			string fileNamewithOutExtension = Path.GetFileNameWithoutExtension(fileName);
			string outputFileName = fileNamewithOutExtension + "." + outputType;

			bool isAutoFitRows = false;
			bool isAutoFitColumns = false;

			SaveOptions body = new SaveOptions();
			body.SaveFormat = outputType;

			if (cellsApi != null)
			{
				SaveResponse apiResponse = cellsApi.CellsSaveAsPostDocumentSaveAs(fileName, body, outputFileName, isAutoFitRows, isAutoFitColumns, null, null);

				return new Response
				{
					FileName = outputFileName,
					Status = "OK",
					StatusCode = 200,
				};
			}
			return new Response
			{
				FileName = null,
				Status = "Output type not found",
				StatusCode = 500
			};

			
		}
		
    }
}
