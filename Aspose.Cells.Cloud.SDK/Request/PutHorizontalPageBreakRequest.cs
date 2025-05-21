// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PutHorizontalPageBreakRequest.cs">
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
    /// Request model for <see cref="Aspose.Cells.Cloud.SDK.Api.CellsApi.PutHorizontalPageBreak" /> operation.
    /// </summary>
    public class PutHorizontalPageBreakRequest : IRequestModel
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="PutHorizontalPageBreakRequest"/> class.
        /// </summary>
        public PutHorizontalPageBreakRequest()
        {

        }
            /// <summary>
            /// Initializes a new instance of the <see cref="PutHorizontalPageBreakRequest"/> class.
            /// </summary>
            /// <param name="name">The workbook name.</param>
            /// <param name="sheetName">The worksheet name.</param>
            /// <param name="cellname">Cell name</param>
            /// <param name="row">Row index, zero based.</param>
            /// <param name="column">Column index, zero based.</param>
            /// <param name="startColumn">Start column index, zero based.</param>
            /// <param name="endColumn">End column index, zero based.</param>
            /// <param name="folder">The folder where the file is situated.</param>
            /// <param name="storageName">The storage name where the file is situated.</param>
            public PutHorizontalPageBreakRequest(string name, string sheetName, string cellname = null, int? row = null, int? column = null, int? startColumn = null, int? endColumn = null, string folder = null, string storageName = null)
            {
                this.name = name;
                this.sheetName = sheetName;
                this.cellname = cellname;
                this.row = row;
                this.column = column;
                this.startColumn = startColumn;
                this.endColumn = endColumn;
                this.folder = folder;
                this.storageName = storageName;
            }
        
        /// <summary>
        /// The workbook name.
        /// </summary>
        public string name { get; set; }


        /// <summary>
        /// The worksheet name.
        /// </summary>
        public string sheetName { get; set; }


        /// <summary>
        /// Cell name
        /// </summary>
        public string cellname { get; set; }


        /// <summary>
        /// Row index, zero based.
        /// </summary>
        public int? row { get; set; }


        /// <summary>
        /// Column index, zero based.
        /// </summary>
        public int? column { get; set; }


        /// <summary>
        /// Start column index, zero based.
        /// </summary>
        public int? startColumn { get; set; }


        /// <summary>
        /// End column index, zero based.
        /// </summary>
        public int? endColumn { get; set; }


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
                throw new ApiException(400, "Missing required parameter 'name' when calling PutHorizontalPageBreak");
            }

            // verify the required parameter 'sheetName' is set
            if (string.IsNullOrEmpty (this.sheetName ))
            {
                throw new ApiException(400, "Missing required parameter 'sheetName' when calling PutHorizontalPageBreak");
            }

            var path = baseUri + "/cells/{name}/worksheets/{sheetName}/horizontalpagebreaks";
            path = Regex
                    .Replace(path, "\\*", string.Empty)
                    .Replace("&amp;", "&")
                    .Replace("/?", "?");

            path = UrlHelper.AddPathParameter(path, "name", this.name);
            path = UrlHelper.AddPathParameter(path, "sheetName", this.sheetName);
            if (!string.IsNullOrEmpty(this.cellname))  path = UrlHelper.AddQueryParameterToUrl(path, "cellname", this.cellname);
            if(this.row != null)  path = UrlHelper.AddQueryParameterToUrl(path, "row", this.row);
            if(this.column != null)  path = UrlHelper.AddQueryParameterToUrl(path, "column", this.column);
            if(this.startColumn != null)  path = UrlHelper.AddQueryParameterToUrl(path, "startColumn", this.startColumn);
            if(this.endColumn != null)  path = UrlHelper.AddQueryParameterToUrl(path, "endColumn", this.endColumn);
            if (!string.IsNullOrEmpty(this.folder))  path = UrlHelper.AddQueryParameterToUrl(path, "folder", this.folder);
            if (!string.IsNullOrEmpty(this.storageName))  path = UrlHelper.AddQueryParameterToUrl(path, "storageName", this.storageName);
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
