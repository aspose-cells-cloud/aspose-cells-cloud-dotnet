// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="AddPictureInCellRequest.cs">
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
    /// Request model for <see cref="Aspose.Cells.Cloud.SDK.Api.CellsApi.AddPictureInCell" /> operation.
    /// </summary>
    public class AddPictureInCellRequest : IRequestModel
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="AddPictureInCellRequest"/> class.
        /// </summary>
        public AddPictureInCellRequest()
        {

        }
            /// <summary>
            /// Initializes a new instance of the <see cref="AddPictureInCellRequest"/> class.
            /// </summary>
            /// <param name="name"></param>
            /// <param name="sheetName"></param>
            /// <param name="cellName"></param>
            /// <param name="picturePath"></param>
            /// <param name="folder"></param>
            /// <param name="storageName"></param>
            public AddPictureInCellRequest(string  name, string  sheetName, string  cellName, string  picturePath, string  folder = null, string  storageName = null)
            {
                this.name = name;
                this.sheetName = sheetName;
                this.cellName = cellName;
                this.picturePath = picturePath;
                this.folder = folder;
                this.storageName = storageName;
            }
        
        /// <summary>
        /// Gets or sets name.
        /// </summary>
        public string name { get; set; }


        /// <summary>
        /// Gets or sets sheetName.
        /// </summary>
        public string sheetName { get; set; }


        /// <summary>
        /// Gets or sets cellName.
        /// </summary>
        public string cellName { get; set; }


        /// <summary>
        /// Gets or sets picturePath.
        /// </summary>
        public string picturePath { get; set; }


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
                throw new ApiException(400, "Missing required parameter 'name' when calling AddPictureInCell");
            }

            // verify the required parameter 'sheetName' is set
            if (string.IsNullOrEmpty (this.sheetName ))
            {
                throw new ApiException(400, "Missing required parameter 'sheetName' when calling AddPictureInCell");
            }

            // verify the required parameter 'cellName' is set
            if (string.IsNullOrEmpty (this.cellName ))
            {
                throw new ApiException(400, "Missing required parameter 'cellName' when calling AddPictureInCell");
            }

            // verify the required parameter 'picturePath' is set
            if (string.IsNullOrEmpty (this.picturePath ))
            {
                throw new ApiException(400, "Missing required parameter 'picturePath' when calling AddPictureInCell");
            }

            var path = baseUri + "/cells/{name}/worksheets/{sheetName}/pictures/addPictureInCell";
            path = Regex
                    .Replace(path, "\\*", string.Empty)
                    .Replace("&amp;", "&")
                    .Replace("/?", "?");

            path = UrlHelper.AddPathParameter(path, "name", this.name);
            path = UrlHelper.AddPathParameter(path, "sheetName", this.sheetName);
            path = UrlHelper.AddQueryParameterToUrl(path, "cellName", this.cellName);
            path = UrlHelper.AddQueryParameterToUrl(path, "picturePath", this.picturePath);
            if (!string.IsNullOrEmpty(this.folder))  path = UrlHelper.AddQueryParameterToUrl(path, "folder", this.folder);
            if (!string.IsNullOrEmpty(this.storageName))  path = UrlHelper.AddQueryParameterToUrl(path, "storageName", this.storageName);
            if (this.extendQueryParameterMap != null)
            {
                foreach (KeyValuePair<string, string> kvp in extendQueryParameterMap)
                {
                    path = UrlHelper.AddQueryParameterToUrl(path, kvp.Key, kvp.Value);
                }
            }


            return UrlHelper.PrepareRequest(path, "POST", localVarFileParams, localVarHeaderParams, localVarPostBody, localVarHttpContentType, defaultHeaderMap, requestHandlers);
        }
    }
}
