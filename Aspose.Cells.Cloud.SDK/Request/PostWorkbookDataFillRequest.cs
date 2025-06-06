// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PostWorkbookDataFillRequest.cs">
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
    /// Request model for <see cref="Aspose.Cells.Cloud.SDK.Api.CellsApi.PostWorkbookDataFill" /> operation.
    /// </summary>
    public class PostWorkbookDataFillRequest : IRequestModel
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="PostWorkbookDataFillRequest"/> class.
        /// </summary>
        public PostWorkbookDataFillRequest()
        {

        }
            /// <summary>
            /// Initializes a new instance of the <see cref="PostWorkbookDataFillRequest"/> class.
            /// </summary>
            /// <param name="name"></param>
            /// <param name="dataFill"></param>
            /// <param name="folder"></param>
            /// <param name="storageName"></param>
            /// <param name="password"></param>
            /// <param name="region"></param>
            /// <param name="checkExcelRestriction"></param>
            public PostWorkbookDataFillRequest(string  name, DataFill  dataFill, string  folder = null, string  storageName = null, string  password = null, string  region = null, bool?  checkExcelRestriction = null)
            {
                this.name = name;
                this.dataFill = dataFill;
                this.folder = folder;
                this.storageName = storageName;
                this.password = password;
                this.region = region;
                this.checkExcelRestriction = checkExcelRestriction;
            }
        
        /// <summary>
        /// Gets or sets name.
        /// </summary>
        public string name { get; set; }


        /// <summary>
        /// Gets or sets dataFill.
        /// </summary>
        public DataFill dataFill { get; set; }


        /// <summary>
        /// Gets or sets folder.
        /// </summary>
        public string folder { get; set; }


        /// <summary>
        /// Gets or sets storageName.
        /// </summary>
        public string storageName { get; set; }


        /// <summary>
        /// Gets or sets password.
        /// </summary>
        public string password { get; set; }


        /// <summary>
        /// Gets or sets region.
        /// </summary>
        public string region { get; set; }


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
                throw new ApiException(400, "Missing required parameter 'name' when calling PostWorkbookDataFill");
            }

            // verify the required parameter 'dataFill' is set
            if ( this.dataFill == null)
            {
                throw new ApiException(400, "Missing required parameter 'dataFill' when calling PostWorkbookDataFill");
            }

            var path = baseUri + "/cells/{name}/datafill";
            path = Regex
                    .Replace(path, "\\*", string.Empty)
                    .Replace("&amp;", "&")
                    .Replace("/?", "?");

            path = UrlHelper.AddPathParameter(path, "name", this.name);
            if (!string.IsNullOrEmpty(this.folder))  path = UrlHelper.AddQueryParameterToUrl(path, "folder", this.folder);
            if (!string.IsNullOrEmpty(this.storageName))  path = UrlHelper.AddQueryParameterToUrl(path, "storageName", this.storageName);
            if (!string.IsNullOrEmpty(this.password))  path = UrlHelper.AddQueryParameterToUrl(path, "password", this.password);
            if (!string.IsNullOrEmpty(this.region))  path = UrlHelper.AddQueryParameterToUrl(path, "region", this.region);
            if(this.checkExcelRestriction != null)  path = UrlHelper.AddQueryParameterToUrl(path, "checkExcelRestriction", this.checkExcelRestriction);
            if (this.extendQueryParameterMap != null)
            {
                foreach (KeyValuePair<string, string> kvp in extendQueryParameterMap)
                {
                    path = UrlHelper.AddQueryParameterToUrl(path, kvp.Key, kvp.Value);
                }
            }

            localVarPostBody = ( this.dataFill != null ? JsonConvert.SerializeObject(this.dataFill) : null);


            return UrlHelper.PrepareRequest(path, "POST", localVarFileParams, localVarHeaderParams, localVarPostBody, localVarHttpContentType, defaultHeaderMap, requestHandlers);
        }
    }
}
