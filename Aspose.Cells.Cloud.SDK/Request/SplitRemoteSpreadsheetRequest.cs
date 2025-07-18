// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="SplitRemoteSpreadsheetRequest.cs">
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
    /// Request model for <see cref="Aspose.Cells.Cloud.SDK.Api.CellsApi.SplitRemoteSpreadsheet" /> operation.
    /// </summary>
    public class SplitRemoteSpreadsheetRequest : IRequestModel
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="SplitRemoteSpreadsheetRequest"/> class.
        /// </summary>
        public SplitRemoteSpreadsheetRequest()
        {

        }
            /// <summary>
            /// Initializes a new instance of the <see cref="SplitRemoteSpreadsheetRequest"/> class.
            /// </summary>
            /// <param name="name">The name of the workbook file to be split.</param>
            /// <param name="folder">The folder path where the workbook is stored.</param>
            /// <param name="from">Begin worksheet index.</param>
            /// <param name="to">End worksheet index.</param>
            /// <param name="outFormat">The desired output format (e.g., "Xlsx", "Pdf", "Csv").</param>
            /// <param name="storageName">(Optional) The name of the storage if using custom cloud storage. Use default storage if omitted.</param>
            /// <param name="outPath">(Optional) The folder path where the workbook is stored. The default is null.</param>
            /// <param name="outStorageName">Output file Storage Name.</param>
            /// <param name="fontsLocation">Use Custom fonts.</param>
            /// <param name="regoin">The spreadsheet region setting.</param>
            /// <param name="password">The password for opening spreadsheet file.</param>
            public SplitRemoteSpreadsheetRequest(string  name, string  folder = null, int?  from = null, int?  to = null, string  outFormat = null, string  storageName = null, string  outPath = null, string  outStorageName = null, string  fontsLocation = null, string  regoin = null, string  password = null)
            {
                this.name = name;
                this.folder = folder;
                this.from = from;
                this.to = to;
                this.outFormat = outFormat;
                this.storageName = storageName;
                this.outPath = outPath;
                this.outStorageName = outStorageName;
                this.fontsLocation = fontsLocation;
                this.regoin = regoin;
                this.password = password;
            }
        
        /// <summary>
        /// The name of the workbook file to be split.
        /// </summary>
        public string name { get; set; }


        /// <summary>
        /// The folder path where the workbook is stored.
        /// </summary>
        public string folder { get; set; }


        /// <summary>
        /// Begin worksheet index.
        /// </summary>
        public int? from { get; set; }


        /// <summary>
        /// End worksheet index.
        /// </summary>
        public int? to { get; set; }


        /// <summary>
        /// The desired output format (e.g., "Xlsx", "Pdf", "Csv").
        /// </summary>
        public string outFormat { get; set; }


        /// <summary>
        /// (Optional) The name of the storage if using custom cloud storage. Use default storage if omitted.
        /// </summary>
        public string storageName { get; set; }


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
            // verify the required parameter 'name' is set
            if (string.IsNullOrEmpty (this.name ))
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling SplitRemoteSpreadsheet");
            }

            var path = baseUri + "/cells/{name}/split/spreadsheet";
            path = Regex
                    .Replace(path, "\\*", string.Empty)
                    .Replace("&amp;", "&")
                    .Replace("/?", "?");

            path = UrlHelper.AddPathParameter(path, "name", this.name);
            if (!string.IsNullOrEmpty(this.folder))  path = UrlHelper.AddQueryParameterToUrl(path, "folder", this.folder);
            if(this.from != null)  path = UrlHelper.AddQueryParameterToUrl(path, "from", this.from);
            if(this.to != null)  path = UrlHelper.AddQueryParameterToUrl(path, "to", this.to);
            if (!string.IsNullOrEmpty(this.outFormat))  path = UrlHelper.AddQueryParameterToUrl(path, "outFormat", this.outFormat);
            if (!string.IsNullOrEmpty(this.storageName))  path = UrlHelper.AddQueryParameterToUrl(path, "storageName", this.storageName);
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


            return UrlHelper.PrepareRequest(path, "PUT", localVarFileParams, localVarHeaderParams, localVarPostBody, localVarHttpContentType, defaultHeaderMap, requestHandlers);
        }
    }
}
