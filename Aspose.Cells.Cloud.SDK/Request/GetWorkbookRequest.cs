// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="GetWorkbookRequest.cs">
//   Copyright (c) 2023 Aspose.Cells Cloud
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
    /// Request model for <see cref="Aspose.Cells.Cloud.SDK.Api.CellsApi.GetWorkbook" /> operation.
    /// </summary>
    public class GetWorkbookRequest : IRequestModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetWorkbookRequest"/> class.
        /// </summary>
        public GetWorkbookRequest()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWorkbookRequest"/> class.
        /// </summary>
        /// <param name="name">The workbook name.</param>
        /// <param name="format">The conversion format(CSV/XLS/HTML/MHTML/ODS/PDF/XML/TXT/TIFF/XLSB/XLSM/XLSX/XLTM/XLTX/XPS/PNG/JPG/JPEG/GIF/EMF/BMP/MD[Markdown]/Numbers).</param>
        /// <param name="password">The excel password.</param>
        /// <param name="isAutoFit">Specifies whether set workbook rows to be autofit.</param>
        /// <param name="onlySaveTable">Specifies whether only save table data.Only use pdf to excel.</param>
        /// <param name="folder">Original workbook folder.</param>
        /// <param name="outPath">Path to save result</param>
        /// <param name="storageName">Storage name.</param>
        /// <param name="outStorageName">Storage name.</param>
        /// <param name="checkExcelRestriction"></param>
        public GetWorkbookRequest(string name, string format = null, string password = null, bool? isAutoFit = null, bool? onlySaveTable = null, string folder = null, string outPath = null, string storageName = null, string outStorageName = null, bool? checkExcelRestriction = null)
        {
            this.name = name;
            this.format = format;
            this.password = password;
            this.isAutoFit = isAutoFit;
            this.onlySaveTable = onlySaveTable;
            this.folder = folder;
            this.outPath = outPath;
            this.storageName = storageName;
            this.outStorageName = outStorageName;
            this.checkExcelRestriction = checkExcelRestriction;
        }

        /// <summary>
        /// The workbook name.
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// The conversion format(CSV/XLS/HTML/MHTML/ODS/PDF/XML/TXT/TIFF/XLSB/XLSM/XLSX/XLTM/XLTX/XPS/PNG/JPG/JPEG/GIF/EMF/BMP/MD[Markdown]/Numbers).
        /// </summary>
        public string format { get; set; }

        /// <summary>
        /// The excel password.
        /// </summary>
        public string password { get; set; }

        /// <summary>
        /// Specifies whether set workbook rows to be autofit.
        /// </summary>
        public bool? isAutoFit { get; set; }

        /// <summary>
        /// Specifies whether only save table data.Only use pdf to excel.
        /// </summary>
        public bool? onlySaveTable { get; set; }

        /// <summary>
        /// Original workbook folder.
        /// </summary>
        public string folder { get; set; }

        /// <summary>
        /// Path to save result
        /// </summary>
        public string outPath { get; set; }

        /// <summary>
        /// Storage name.
        /// </summary>
        public string storageName { get; set; }

        /// <summary>
        /// Storage name.
        /// </summary>
        public string outStorageName { get; set; }

        /// <summary>
        /// Gets or sets checkExcelRestriction.
        /// </summary>
        public bool? checkExcelRestriction { get; set; }


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
                throw new ApiException(400, "Missing required parameter 'name' when calling GetWorkbook");
            }

            var path = baseUri + "/cells/{name}";
            path = Regex
                    .Replace(path, "\\*", string.Empty)
                    .Replace("&amp;", "&")
                    .Replace("/?", "?");

            path = UrlHelper.AddPathParameter(path, "name", this.name);
            if (!string.IsNullOrEmpty(this.format))  path = UrlHelper.AddQueryParameterToUrl(path, "format", this.format);
            if (!string.IsNullOrEmpty(this.password))  path = UrlHelper.AddQueryParameterToUrl(path, "password", this.password);
            if(this.isAutoFit != null)  path = UrlHelper.AddQueryParameterToUrl(path, "isAutoFit", this.isAutoFit);
            if(this.onlySaveTable != null)  path = UrlHelper.AddQueryParameterToUrl(path, "onlySaveTable", this.onlySaveTable);
            if (!string.IsNullOrEmpty(this.folder))  path = UrlHelper.AddQueryParameterToUrl(path, "folder", this.folder);
            if (!string.IsNullOrEmpty(this.outPath))  path = UrlHelper.AddQueryParameterToUrl(path, "outPath", this.outPath);
            if (!string.IsNullOrEmpty(this.storageName))  path = UrlHelper.AddQueryParameterToUrl(path, "storageName", this.storageName);
            if (!string.IsNullOrEmpty(this.outStorageName))  path = UrlHelper.AddQueryParameterToUrl(path, "outStorageName", this.outStorageName);
            if(this.checkExcelRestriction != null)  path = UrlHelper.AddQueryParameterToUrl(path, "checkExcelRestriction", this.checkExcelRestriction);
            if (this.extendQueryParameterMap != null)
            {
                foreach (KeyValuePair<string, string> kvp in extendQueryParameterMap)
                {
                    UrlHelper.AddQueryParameterToUrl(path, kvp.Key, kvp.Value);
                }
            }

            return UrlHelper.PrepareRequest(path, "GET", localVarFileParams, localVarHeaderParams, localVarPostBody, localVarHttpContentType, defaultHeaderMap, requestHandlers);
        }
    }
}
