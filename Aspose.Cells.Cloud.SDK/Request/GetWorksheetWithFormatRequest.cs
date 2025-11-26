// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="GetWorksheetWithFormatRequest.cs">
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
    /// Request model for <see cref="Aspose.Cells.Cloud.SDK.Api.CellsApi.GetWorksheetWithFormat" /> operation.
    /// </summary>
    public class GetWorksheetWithFormatRequest : IRequestModel
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWorksheetWithFormatRequest"/> class.
        /// </summary>
        public GetWorksheetWithFormatRequest()
        {

        }
            /// <summary>
            /// Initializes a new instance of the <see cref="GetWorksheetWithFormatRequest"/> class.
            /// </summary>
            /// <param name="name">The file name.</param>
            /// <param name="sheetName">The worksheet name.</param>
            /// <param name="format">Export format(CSV/XLS/HTML/MHTML/ODS/PDF/XML/TXT/TIFF/XLSB/XLSM/XLSX/XLTM/XLTX/XPS/PNG/JPG/JPEG/GIF/EMF/BMP/MD[Markdown]/Numbers).</param>
            /// <param name="verticalResolution">Image vertical resolution.</param>
            /// <param name="horizontalResolution">Image horizontal resolution.</param>
            /// <param name="area">Represents the range to be printed.</param>
            /// <param name="pageIndex">Represents the page to be printed</param>
            /// <param name="onePagePerSheet"></param>
            /// <param name="printHeadings"></param>
            /// <param name="folder">The folder where the file is situated.</param>
            /// <param name="storageName">The storage name where the file is situated.</param>
            public GetWorksheetWithFormatRequest(string  name, string  sheetName, string  format = null, int?  verticalResolution = null, int?  horizontalResolution = null, string  area = null, int?  pageIndex = null, bool?  onePagePerSheet = null, bool?  printHeadings = null, string  folder = null, string  storageName = null)
            {
                this.name = name;
                this.sheetName = sheetName;
                this.format = format;
                this.verticalResolution = verticalResolution;
                this.horizontalResolution = horizontalResolution;
                this.area = area;
                this.pageIndex = pageIndex;
                this.onePagePerSheet = onePagePerSheet;
                this.printHeadings = printHeadings;
                this.folder = folder;
                this.storageName = storageName;
            }
        
        /// <summary>
        /// The file name.
        /// </summary>
        public string name { get; set; }


        /// <summary>
        /// The worksheet name.
        /// </summary>
        public string sheetName { get; set; }


        /// <summary>
        /// Export format(CSV/XLS/HTML/MHTML/ODS/PDF/XML/TXT/TIFF/XLSB/XLSM/XLSX/XLTM/XLTX/XPS/PNG/JPG/JPEG/GIF/EMF/BMP/MD[Markdown]/Numbers).
        /// </summary>
        public string format { get; set; }


        /// <summary>
        /// Image vertical resolution.
        /// </summary>
        public int? verticalResolution { get; set; }


        /// <summary>
        /// Image horizontal resolution.
        /// </summary>
        public int? horizontalResolution { get; set; }


        /// <summary>
        /// Represents the range to be printed.
        /// </summary>
        public string area { get; set; }


        /// <summary>
        /// Represents the page to be printed
        /// </summary>
        public int? pageIndex { get; set; }


        /// <summary>
        /// Gets or sets onePagePerSheet.
        /// </summary>
        public bool? onePagePerSheet { get; set; }


        /// <summary>
        /// Gets or sets printHeadings.
        /// </summary>
        public bool? printHeadings { get; set; }


        /// <summary>
        /// The folder where the file is situated.
        /// </summary>
        public string folder { get; set; }


        /// <summary>
        /// The storage name where the file is situated.
        /// </summary>
        public string storageName { get; set; }
        

        /// <summary>
        /// Gets or sets extendQueryParameterMap.
        /// </summary>
        public IDictionary<string, string> extendQueryParameterMap = new Dictionary<string, string>{};

        public void AddExtendQueryParameter(string name ,string value)
        {
            extendQueryParameterMap.Add(name,value);
        }
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
                throw new ApiException(400, "Missing required parameter 'name' when calling GetWorksheetWithFormat");
            }

            // verify the required parameter 'sheetName' is set
            if (string.IsNullOrEmpty (this.sheetName ))
            {
                throw new ApiException(400, "Missing required parameter 'sheetName' when calling GetWorksheetWithFormat");
            }

            var path = baseUri + "/cells/{name}/worksheets/{sheetName}";
            path = Regex
                    .Replace(path, "\\*", string.Empty)
                    .Replace("&amp;", "&")
                    .Replace("/?", "?");

            path = UrlHelper.AddPathParameter(path, "name", this.name);
            path = UrlHelper.AddPathParameter(path, "sheetName", this.sheetName);
            if (!string.IsNullOrEmpty(this.format))  path = UrlHelper.AddQueryParameterToUrl(path, "format", this.format);
            if(this.verticalResolution != null)  path = UrlHelper.AddQueryParameterToUrl(path, "verticalResolution", this.verticalResolution);
            if(this.horizontalResolution != null)  path = UrlHelper.AddQueryParameterToUrl(path, "horizontalResolution", this.horizontalResolution);
            if (!string.IsNullOrEmpty(this.area))  path = UrlHelper.AddQueryParameterToUrl(path, "area", this.area);
            if(this.pageIndex != null)  path = UrlHelper.AddQueryParameterToUrl(path, "pageIndex", this.pageIndex);
            if(this.onePagePerSheet != null)  path = UrlHelper.AddQueryParameterToUrl(path, "onePagePerSheet", this.onePagePerSheet);
            if(this.printHeadings != null)  path = UrlHelper.AddQueryParameterToUrl(path, "printHeadings", this.printHeadings);
            if (!string.IsNullOrEmpty(this.folder))  path = UrlHelper.AddQueryParameterToUrl(path, "folder", this.folder);
            if (!string.IsNullOrEmpty(this.storageName))  path = UrlHelper.AddQueryParameterToUrl(path, "storageName", this.storageName);
            if (this.extendQueryParameterMap != null)
            {
                foreach (KeyValuePair<string, string> kvp in extendQueryParameterMap)
                {
                    path = UrlHelper.AddQueryParameterToUrl(path, kvp.Key, kvp.Value);
                }
            }


            return UrlHelper.PrepareRequest(path, "GET", localVarFileParams, localVarHeaderParams, localVarPostBody, localVarHttpContentType, defaultHeaderMap, requestHandlers);
        }
    }
}
