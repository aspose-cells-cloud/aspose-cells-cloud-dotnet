// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PutWorksheetFormatConditionConditionRequest.cs">
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
    /// Request model for <see cref="Aspose.Cells.Cloud.SDK.Api.CellsApi.PutWorksheetFormatConditionCondition" /> operation.
    /// </summary>
    public class PutWorksheetFormatConditionConditionRequest : IRequestModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PutWorksheetFormatConditionConditionRequest"/> class.
        /// </summary>
        public PutWorksheetFormatConditionConditionRequest()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PutWorksheetFormatConditionConditionRequest"/> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="sheetName"></param>
        /// <param name="index"></param>
        /// <param name="type"></param>
        /// <param name="operatorType"></param>
        /// <param name="formula1"></param>
        /// <param name="formula2"></param>
        /// <param name="folder"></param>
        /// <param name="storageName"></param>
        public PutWorksheetFormatConditionConditionRequest(string name, string sheetName, int? index, string type, string operatorType, string formula1, string formula2, string folder = null, string storageName = null)
        {
            this.name = name;
            this.sheetName = sheetName;
            this.index = index;
            this.type = type;
            this.operatorType = operatorType;
            this.formula1 = formula1;
            this.formula2 = formula2;
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
        /// Gets or sets index.
        /// </summary>
        public int? index { get; set; }

        /// <summary>
        /// Gets or sets type.
        /// </summary>
        public string type { get; set; }

        /// <summary>
        /// Gets or sets operatorType.
        /// </summary>
        public string operatorType { get; set; }

        /// <summary>
        /// Gets or sets formula1.
        /// </summary>
        public string formula1 { get; set; }

        /// <summary>
        /// Gets or sets formula2.
        /// </summary>
        public string formula2 { get; set; }

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
                throw new ApiException(400, "Missing required parameter 'name' when calling PutWorksheetFormatConditionCondition");
            }

            // verify the required parameter 'sheetName' is set
            if (string.IsNullOrEmpty (this.sheetName ))
            {
                throw new ApiException(400, "Missing required parameter 'sheetName' when calling PutWorksheetFormatConditionCondition");
            }

            // verify the required parameter 'index' is set
            if ( this.index == null)
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling PutWorksheetFormatConditionCondition");
            }

            // verify the required parameter 'type' is set
            if (string.IsNullOrEmpty (this.type ))
            {
                throw new ApiException(400, "Missing required parameter 'type' when calling PutWorksheetFormatConditionCondition");
            }

            // verify the required parameter 'operatorType' is set
            if (string.IsNullOrEmpty (this.operatorType ))
            {
                throw new ApiException(400, "Missing required parameter 'operatorType' when calling PutWorksheetFormatConditionCondition");
            }

            // verify the required parameter 'formula1' is set
            if (string.IsNullOrEmpty (this.formula1 ))
            {
                throw new ApiException(400, "Missing required parameter 'formula1' when calling PutWorksheetFormatConditionCondition");
            }

            // verify the required parameter 'formula2' is set
            if (string.IsNullOrEmpty (this.formula2 ))
            {
                throw new ApiException(400, "Missing required parameter 'formula2' when calling PutWorksheetFormatConditionCondition");
            }

            var path = baseUri + "/cells/{name}/worksheets/{sheetName}/conditionalFormattings/{index}/condition";
            path = Regex
                    .Replace(path, "\\*", string.Empty)
                    .Replace("&amp;", "&")
                    .Replace("/?", "?");

            path = UrlHelper.AddPathParameter(path, "name", this.name);
            path = UrlHelper.AddPathParameter(path, "sheetName", this.sheetName);
            path = UrlHelper.AddPathParameter(path, "index", this.index);
            path = UrlHelper.AddQueryParameterToUrl(path, "type", this.type);
            path = UrlHelper.AddQueryParameterToUrl(path, "operatorType", this.operatorType);
            path = UrlHelper.AddQueryParameterToUrl(path, "formula1", this.formula1);
            path = UrlHelper.AddQueryParameterToUrl(path, "formula2", this.formula2);
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