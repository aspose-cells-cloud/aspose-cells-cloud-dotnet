// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PutWorkbookCreateRequest.cs">
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
    /// Request model for <see cref="Aspose.Cells.Cloud.SDK.Api.CellsApi.PutWorkbookCreate" /> operation.
    /// </summary>
    public class PutWorkbookCreateRequest : IRequestModel
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="PutWorkbookCreateRequest"/> class.
        /// </summary>
        public PutWorkbookCreateRequest()
        {

        }
            /// <summary>
            /// Initializes a new instance of the <see cref="PutWorkbookCreateRequest"/> class.
            /// </summary>
            /// <param name="name">The new document name.</param>
            /// <param name="templateFile">The template file, if the data not provided default workbook is created.</param>
            /// <param name="dataFile">Smart marker data file, if the data not provided the request content is checked for the data.</param>
            /// <param name="isWriteOver">Specifies whether to write over targer file.</param>
            /// <param name="folder">The folder where the file is situated.</param>
            /// <param name="storageName">The storage name where the file is situated.</param>
            /// <param name="checkExcelRestriction"></param>
            public PutWorkbookCreateRequest(string  name, string  templateFile = null, string  dataFile = null, bool?  isWriteOver = null, string  folder = null, string  storageName = null, bool?  checkExcelRestriction = null)
            {
                this.name = name;
                this.templateFile = templateFile;
                this.dataFile = dataFile;
                this.isWriteOver = isWriteOver;
                this.folder = folder;
                this.storageName = storageName;
                this.checkExcelRestriction = checkExcelRestriction;
            }
        
        /// <summary>
        /// The new document name.
        /// </summary>
        public string name { get; set; }


        /// <summary>
        /// The template file, if the data not provided default workbook is created.
        /// </summary>
        public string templateFile { get; set; }


        /// <summary>
        /// Smart marker data file, if the data not provided the request content is checked for the data.
        /// </summary>
        public string dataFile { get; set; }


        /// <summary>
        /// Specifies whether to write over targer file.
        /// </summary>
        public bool? isWriteOver { get; set; }


        /// <summary>
        /// The folder where the file is situated.
        /// </summary>
        public string folder { get; set; }


        /// <summary>
        /// The storage name where the file is situated.
        /// </summary>
        public string storageName { get; set; }


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
                throw new ApiException(400, "Missing required parameter 'name' when calling PutWorkbookCreate");
            }

            var path = baseUri + "/cells/{name}";
            path = Regex
                    .Replace(path, "\\*", string.Empty)
                    .Replace("&amp;", "&")
                    .Replace("/?", "?");

            path = UrlHelper.AddPathParameter(path, "name", this.name);
            if (!string.IsNullOrEmpty(this.templateFile))  path = UrlHelper.AddQueryParameterToUrl(path, "templateFile", this.templateFile);
            if (!string.IsNullOrEmpty(this.dataFile))  path = UrlHelper.AddQueryParameterToUrl(path, "dataFile", this.dataFile);
            if(this.isWriteOver != null)  path = UrlHelper.AddQueryParameterToUrl(path, "isWriteOver", this.isWriteOver);
            if (!string.IsNullOrEmpty(this.folder))  path = UrlHelper.AddQueryParameterToUrl(path, "folder", this.folder);
            if (!string.IsNullOrEmpty(this.storageName))  path = UrlHelper.AddQueryParameterToUrl(path, "storageName", this.storageName);
            if(this.checkExcelRestriction != null)  path = UrlHelper.AddQueryParameterToUrl(path, "checkExcelRestriction", this.checkExcelRestriction);
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
