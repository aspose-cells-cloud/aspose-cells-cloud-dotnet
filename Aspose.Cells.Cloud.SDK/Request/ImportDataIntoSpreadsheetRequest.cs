// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ImportDataIntoSpreadsheetRequest.cs">
//   Copyright (c) 2025 Aspose.Cells Cloud
// </copyright>
// <summary>
//   Permission is hereby granted, free of charge, to any person obtaining a copy
//  of this software and associated documentation files (the "Software"), to deal
//  in the Software without restriction, including without limitation the rights
//  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//  copies of the Software, and to permit persons to whom the Software is
//  furnished to do so, subject to the following conditions:
// 
//  The above copyright notice and this permission notice shall be included in all
//  copies or substantial portions of the Software.
// 
//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//  SOFTWARE.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Aspose.Cells.Cloud.SDK.Request
{
    using Aspose.Cells.Cloud.SDK.Model;
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using System.Net;
    using System.Text.RegularExpressions;

    /// <summary>
    /// Request model for <see cref="Aspose.Cells.Cloud.SDK.Api.CellsApi.ImportDataIntoSpreadsheet" /> operation.
    /// </summary>
    public class ImportDataIntoSpreadsheetRequest : IRequestModel
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="ImportDataIntoSpreadsheetRequest"/> class.
        /// </summary>
        public ImportDataIntoSpreadsheetRequest()
        {

        }
        /// <summary>
        /// Initializes a new instance of the <see cref="ImportDataIntoSpreadsheetRequest"/> class.
        /// </summary>
        /// <param name="datafile">Upload data file.</param>
        /// <param name="spreadsheet">Upload spreadsheet file.</param>
        /// <param name="worksheet"></param>
        /// <param name="startcell"></param>
        /// <param name="insert"></param>
        /// <param name="convertNumericData"></param>
        /// <param name="splitter"></param>
        /// <param name="outPath">(Optional) The folder path where the workbook is stored. The default is null.</param>
        /// <param name="outStorageName">Output file Storage Name.</param>
        /// <param name="fontsLocation">Use Custom fonts.</param>
        /// <param name="regoin">The spreadsheet region setting.</param>
        /// <param name="password">The password for opening spreadsheet file.</param>
        public ImportDataIntoSpreadsheetRequest(string  datafile, string  spreadsheet, string  worksheet, string  startcell, bool?  insert = null, bool?  convertNumericData = null, string  splitter = null, string  outPath = null, string  outStorageName = null, string  fontsLocation = null, string  regoin = null, string  password = null)
        {
            this.datafile = datafile;
            this.Spreadsheet = spreadsheet;
            this.worksheet = worksheet;
            this.startcell = startcell;
            this.insert = insert;
            this.convertNumericData = convertNumericData;
            this.splitter = splitter;
            this.outPath = outPath;
            this.outStorageName = outStorageName;
            this.fontsLocation = fontsLocation;
            this.regoin = regoin;
            this.password = password;
        }
        
        /// <summary>
        /// Upload data file.
        /// </summary>
            public string datafile { get; set; }


        /// <summary>
        /// Upload spreadsheet file.
        /// </summary>
            public string Spreadsheet { get; set; }


        /// <summary>
        /// Gets or sets worksheet.
        /// </summary>
        public string worksheet { get; set; }


        /// <summary>
        /// Gets or sets startcell.
        /// </summary>
        public string startcell { get; set; }


        /// <summary>
        /// Gets or sets insert.
        /// </summary>
        public bool? insert { get; set; }


        /// <summary>
        /// Gets or sets convertNumericData.
        /// </summary>
        public bool? convertNumericData { get; set; }


        /// <summary>
        /// Gets or sets splitter.
        /// </summary>
        public string splitter { get; set; }


        /// <summary>
        /// (Optional) The folder path where the workbook is stored. The default is null.
        /// </summary>
        public string outPath { get; set; }


        /// <summary>
        /// Output file Storage Name.
        /// </summary>
        public string outStorageName { get; set; }


        /// <summary>
        /// Use Custom fonts.
        /// </summary>
        public string fontsLocation { get; set; }


        /// <summary>
        /// The spreadsheet region setting.
        /// </summary>
        public string regoin { get; set; }


        /// <summary>
        /// The password for opening spreadsheet file.
        /// </summary>
        public string password { get; set; }
        

        /// <summary>
        /// Gets or sets extendQueryParameterMap.
        /// </summary>
        public IDictionary<string, string> extendQueryParameterMap ;

        /// <summary>
        /// Creates the http request based on this request.
        /// </summary>
        /// <param name="baseUri">Api base uri.</param>
        /// <returns>The http request instance.</returns>
        public HttpWebRequest CreateHttpRequest(string baseUri,IDictionary<string, string> defaultHeaderMap, List<Invoker.IRequestHandler> requestHandlers)
        {
            var localVarHeaderParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, object>();
            string localVarPostBody ="";
            string localVarHttpContentType = "application/json";
            // verify the required parameter 'datafile' is set
            if (    string.IsNullOrEmpty(this.datafile)    )
            {
                throw new ApiException(400, "Missing required parameter 'datafile' when calling ImportDataIntoSpreadsheet");
            }

            // verify the required parameter 'spreadsheet' is set
            if (    string.IsNullOrEmpty(this.Spreadsheet)    )
            {
                throw new ApiException(400, "Missing required parameter 'spreadsheet' when calling ImportDataIntoSpreadsheet");
            }

            // verify the required parameter 'worksheet' is set
            if (string.IsNullOrEmpty (this.worksheet ))
            {
                throw new ApiException(400, "Missing required parameter 'worksheet' when calling ImportDataIntoSpreadsheet");
            }

            // verify the required parameter 'startcell' is set
            if (string.IsNullOrEmpty (this.startcell ))
            {
                throw new ApiException(400, "Missing required parameter 'startcell' when calling ImportDataIntoSpreadsheet");
            }

            var path = baseUri + "/cells/import/data";
            path = Regex
                    .Replace(path, "\\*", string.Empty)
                    .Replace("&amp;", "&")
                    .Replace("/?", "?");

            path = UrlHelper.AddQueryParameterToUrl(path, "worksheet", this.worksheet);
            path = UrlHelper.AddQueryParameterToUrl(path, "startcell", this.startcell);
            if(this.insert != null)  path = UrlHelper.AddQueryParameterToUrl(path, "insert", this.insert);
            if(this.convertNumericData != null)  path = UrlHelper.AddQueryParameterToUrl(path, "convertNumericData", this.convertNumericData);
            if (!string.IsNullOrEmpty(this.splitter))  path = UrlHelper.AddQueryParameterToUrl(path, "splitter", this.splitter);
            if (!string.IsNullOrEmpty(this.outPath))  path = UrlHelper.AddQueryParameterToUrl(path, "outPath", this.outPath);
            if (!string.IsNullOrEmpty(this.outStorageName))  path = UrlHelper.AddQueryParameterToUrl(path, "outStorageName", this.outStorageName);
            if (!string.IsNullOrEmpty(this.fontsLocation))  path = UrlHelper.AddQueryParameterToUrl(path, "fontsLocation", this.fontsLocation);
            if (!string.IsNullOrEmpty(this.regoin))  path = UrlHelper.AddQueryParameterToUrl(path, "regoin", this.regoin);
            if (!string.IsNullOrEmpty(this.password))  path = UrlHelper.AddQueryParameterToUrl(path, "password", this.password);
            if (this.extendQueryParameterMap != null)
            {
                foreach (KeyValuePair<string, string> kvp in extendQueryParameterMap)
                {
                    path = UrlHelper.AddQueryParameterToUrl(path, kvp.Key, kvp.Value);
                }
            }

             if (!string.IsNullOrEmpty(datafile ) && System.IO.File.Exists(datafile )) {
                 System.IO.FileInfo fileInfo = new System.IO.FileInfo(datafile);
                 localVarFileParams.Add(fileInfo.Name, UrlHelper.ToFileInfo(System.IO.File.OpenRead(datafile), fileInfo.Name));
             } 
             if (!string.IsNullOrEmpty(Spreadsheet ) && System.IO.File.Exists(Spreadsheet )) {
                 System.IO.FileInfo fileInfo = new System.IO.FileInfo(Spreadsheet);
                 localVarFileParams.Add(fileInfo.Name, UrlHelper.ToFileInfo(System.IO.File.OpenRead(Spreadsheet), fileInfo.Name));
             } 



            return UrlHelper.PrepareRequest(path, "PUT", localVarFileParams, localVarHeaderParams, localVarPostBody, localVarHttpContentType, defaultHeaderMap, requestHandlers);
        }
    }
}
