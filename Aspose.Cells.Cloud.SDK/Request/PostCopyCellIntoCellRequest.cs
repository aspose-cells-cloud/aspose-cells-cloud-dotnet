// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PostCopyCellIntoCellRequest.cs">
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
    /// Request model for <see cref="Aspose.Cells.Cloud.SDK.Api.CellsApi.PostCopyCellIntoCell" /> operation.
    /// </summary>
    public class PostCopyCellIntoCellRequest : IRequestModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PostCopyCellIntoCellRequest"/> class.
        /// </summary>
        public PostCopyCellIntoCellRequest()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostCopyCellIntoCellRequest"/> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="destCellName"></param>
        /// <param name="sheetName"></param>
        /// <param name="worksheet"></param>
        /// <param name="cellname"></param>
        /// <param name="row"></param>
        /// <param name="column"></param>
        /// <param name="folder"></param>
        /// <param name="storageName"></param>
        public PostCopyCellIntoCellRequest(string name, string destCellName, string sheetName, string worksheet, string cellname = null, int? row = null, int? column = null, string folder = null, string storageName = null)
        {
            this.name = name;
            this.destCellName = destCellName;
            this.sheetName = sheetName;
            this.worksheet = worksheet;
            this.cellname = cellname;
            this.row = row;
            this.column = column;
            this.folder = folder;
            this.storageName = storageName;
        }

        /// <summary>
        /// Gets or sets name.
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// Gets or sets destCellName.
        /// </summary>
        public string destCellName { get; set; }

        /// <summary>
        /// Gets or sets sheetName.
        /// </summary>
        public string sheetName { get; set; }

        /// <summary>
        /// Gets or sets worksheet.
        /// </summary>
        public string worksheet { get; set; }

        /// <summary>
        /// Gets or sets cellname.
        /// </summary>
        public string cellname { get; set; }

        /// <summary>
        /// Gets or sets row.
        /// </summary>
        public int? row { get; set; }

        /// <summary>
        /// Gets or sets column.
        /// </summary>
        public int? column { get; set; }

        /// <summary>
        /// Gets or sets folder.
        /// </summary>
        public string folder { get; set; }

        /// <summary>
        /// Gets or sets storageName.
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
                throw new ApiException(400, "Missing required parameter 'name' when calling PostCopyCellIntoCell");
            }

            // verify the required parameter 'destCellName' is set
            if (string.IsNullOrEmpty (this.destCellName ))
            {
                throw new ApiException(400, "Missing required parameter 'destCellName' when calling PostCopyCellIntoCell");
            }

            // verify the required parameter 'sheetName' is set
            if (string.IsNullOrEmpty (this.sheetName ))
            {
                throw new ApiException(400, "Missing required parameter 'sheetName' when calling PostCopyCellIntoCell");
            }

            // verify the required parameter 'worksheet' is set
            if (string.IsNullOrEmpty (this.worksheet ))
            {
                throw new ApiException(400, "Missing required parameter 'worksheet' when calling PostCopyCellIntoCell");
            }

            var path = baseUri + "/cells/{name}/worksheets/{sheetName}/cells/{destCellName}/copy";
            path = Regex
                    .Replace(path, "\\*", string.Empty)
                    .Replace("&amp;", "&")
                    .Replace("/?", "?");

            path = UrlHelper.AddPathParameter(path, "name", this.name);
            path = UrlHelper.AddPathParameter(path, "destCellName", this.destCellName);
            path = UrlHelper.AddPathParameter(path, "sheetName", this.sheetName);
            path = UrlHelper.AddQueryParameterToUrl(path, "worksheet", this.worksheet);
            if (!string.IsNullOrEmpty(this.cellname))  path = UrlHelper.AddQueryParameterToUrl(path, "cellname", this.cellname);
            if(this.row != null)  path = UrlHelper.AddQueryParameterToUrl(path, "row", this.row);
            if(this.column != null)  path = UrlHelper.AddQueryParameterToUrl(path, "column", this.column);
            if (!string.IsNullOrEmpty(this.folder))  path = UrlHelper.AddQueryParameterToUrl(path, "folder", this.folder);
            if (!string.IsNullOrEmpty(this.storageName))  path = UrlHelper.AddQueryParameterToUrl(path, "storageName", this.storageName);
            if (this.extendQueryParameterMap != null)
            {
                foreach (KeyValuePair<string, string> kvp in extendQueryParameterMap)
                {
                    UrlHelper.AddQueryParameterToUrl(path, kvp.Key, kvp.Value);
                }
            }

            return UrlHelper.PrepareRequest(path, "POST", localVarFileParams, localVarHeaderParams, localVarPostBody, localVarHttpContentType, defaultHeaderMap, requestHandlers);
        }
    }
}
