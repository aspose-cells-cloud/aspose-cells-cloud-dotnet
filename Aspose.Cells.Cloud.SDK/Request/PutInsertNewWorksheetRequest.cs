// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PutInsertNewWorksheetRequest.cs">
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
    /// Request model for <see cref="Aspose.Cells.Cloud.SDK.Api.CellsApi.PutInsertNewWorksheet" /> operation.
    /// </summary>
    public class PutInsertNewWorksheetRequest : IRequestModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PutInsertNewWorksheetRequest"/> class.
        /// </summary>
        public PutInsertNewWorksheetRequest()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PutInsertNewWorksheetRequest"/> class.
        /// </summary>
        /// <param name="name">The workbook name.</param>
        /// <param name="sheetName">The worksheet name.</param>
        /// <param name="index"></param>
        /// <param name="sheettype">Specifies the worksheet type(VB/Worksheet/Chart/BIFF4Macro/InternationalMacro/Other/Dialog).</param>
        /// <param name="newsheetname"></param>
        /// <param name="folder">Original workbook folder.</param>
        /// <param name="storageName">Storage name.</param>
        public PutInsertNewWorksheetRequest(string name, string sheetName, int? index, string sheettype, string newsheetname = null, string folder = null, string storageName = null)
        {
            this.name = name;
            this.sheetName = sheetName;
            this.index = index;
            this.sheettype = sheettype;
            this.newsheetname = newsheetname;
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
        /// Gets or sets index.
        /// </summary>
        public int? index { get; set; }

        /// <summary>
        /// Specifies the worksheet type(VB/Worksheet/Chart/BIFF4Macro/InternationalMacro/Other/Dialog).
        /// </summary>
        public string sheettype { get; set; }

        /// <summary>
        /// Gets or sets newsheetname.
        /// </summary>
        public string newsheetname { get; set; }

        /// <summary>
        /// Original workbook folder.
        /// </summary>
        public string folder { get; set; }

        /// <summary>
        /// Storage name.
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
                throw new ApiException(400, "Missing required parameter 'name' when calling PutInsertNewWorksheet");
            }

            // verify the required parameter 'sheetName' is set
            if (string.IsNullOrEmpty (this.sheetName ))
            {
                throw new ApiException(400, "Missing required parameter 'sheetName' when calling PutInsertNewWorksheet");
            }

            // verify the required parameter 'index' is set
            if ( this.index == null)
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling PutInsertNewWorksheet");
            }

            // verify the required parameter 'sheettype' is set
            if (string.IsNullOrEmpty (this.sheettype ))
            {
                throw new ApiException(400, "Missing required parameter 'sheettype' when calling PutInsertNewWorksheet");
            }

            var path = baseUri + "/cells/{name}/worksheets/insert";
            path = Regex
                    .Replace(path, "\\*", string.Empty)
                    .Replace("&amp;", "&")
                    .Replace("/?", "?");

            path = UrlHelper.AddPathParameter(path, "name", this.name);
            path = UrlHelper.AddQueryParameterToUrl(path, "sheetName", this.sheetName);
            path = UrlHelper.AddQueryParameterToUrl(path, "index", this.index);
            path = UrlHelper.AddQueryParameterToUrl(path, "sheettype", this.sheettype);
            if (!string.IsNullOrEmpty(this.newsheetname))  path = UrlHelper.AddQueryParameterToUrl(path, "newsheetname", this.newsheetname);
            if (!string.IsNullOrEmpty(this.folder))  path = UrlHelper.AddQueryParameterToUrl(path, "folder", this.folder);
            if (!string.IsNullOrEmpty(this.storageName))  path = UrlHelper.AddQueryParameterToUrl(path, "storageName", this.storageName);
            if (this.extendQueryParameterMap != null)
            {
                foreach (KeyValuePair<string, string> kvp in extendQueryParameterMap)
                {
                    UrlHelper.AddQueryParameterToUrl(path, kvp.Key, kvp.Value);
                }
            }

            return UrlHelper.PrepareRequest(path, "PUT", localVarFileParams, localVarHeaderParams, localVarPostBody, localVarHttpContentType, defaultHeaderMap, requestHandlers);
        }
    }
}
