// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ConvertTextRequest.cs">
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
    /// Request model for <see cref="Aspose.Cells.Cloud.SDK.Api.CellsApi.ConvertText" /> operation.
    /// </summary>
    public class ConvertTextRequest : IRequestModel
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="ConvertTextRequest"/> class.
        /// </summary>
        public ConvertTextRequest()
        {

        }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConvertTextRequest"/> class.
        /// </summary>
        /// <param name="spreadsheet">Upload spreadsheet file.</param>
        /// <param name="convertTextType"></param>
        /// <param name="sourceCharacters"></param>
        /// <param name="targetCharacters"></param>
        /// <param name="worksheet"></param>
        /// <param name="range"></param>
        /// <param name="outPath">(Optional) The folder path where the workbook is stored. The default is null.</param>
        /// <param name="outStorageName">Output file Storage Name.</param>
        /// <param name="region">The spreadsheet region setting.</param>
        /// <param name="password">The password for opening spreadsheet file.</param>
        public ConvertTextRequest(string spreadsheet,string convertTextType, string sourceCharacters =null , string targetCharacters = null, string worksheet = null, string range = null)
        {
            this.Spreadsheet = spreadsheet;
            this.convertTextType = convertTextType;
            this.sourceCharacters = sourceCharacters;
            this.targetCharacters = targetCharacters;
            this.worksheet = worksheet;
            this.range = range;
            this.outPath = outPath;
            this.outStorageName = outStorageName;
            this.region = region;
            this.password = password;
        }

        /// <summary>
        /// Upload spreadsheet file.
        /// </summary>
            public string Spreadsheet { get; set; }


        /// <summary>
        /// Gets or sets convertTextType.
        /// </summary>
        public string convertTextType { get; set; }


        /// <summary>
        /// Gets or sets sourceCharacters.
        /// </summary>
        public string sourceCharacters { get; set; }


        /// <summary>
        /// Gets or sets targetCharacters.
        /// </summary>
        public string targetCharacters { get; set; }


        /// <summary>
        /// Gets or sets worksheet.
        /// </summary>
        public string worksheet { get; set; }


        /// <summary>
        /// Gets or sets range.
        /// </summary>
        public string range { get; set; }


        /// <summary>
        /// (Optional) The folder path where the workbook is stored. The default is null.
        /// </summary>
        public string outPath { get; set; }


        /// <summary>
        /// Output file Storage Name.
        /// </summary>
        public string outStorageName { get; set; }


        /// <summary>
        /// The spreadsheet region setting.
        /// </summary>
        public string region { get; set; }


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
            // verify the required parameter 'spreadsheet' is set
            // if (    string.IsNullOrEmpty(this.Spreadsheet)    )
            // {
            //     throw new ApiException(400, "Missing required parameter 'spreadsheet' when calling ConvertText");
            // }

            // verify the required parameter 'convertTextType' is set
            if (string.IsNullOrEmpty (this.convertTextType ))
            {
                throw new ApiException(400, "Missing required parameter 'convertTextType' when calling ConvertText");
            }

            // verify the required parameter 'sourceCharacters' is set
            // if (string.IsNullOrEmpty (this.sourceCharacters ))
            // {
            //     throw new ApiException(400, "Missing required parameter 'sourceCharacters' when calling ConvertText");
            // }

            // verify the required parameter 'targetCharacters' is set
            // if (string.IsNullOrEmpty (this.targetCharacters ))
            // {
            //     throw new ApiException(400, "Missing required parameter 'targetCharacters' when calling ConvertText");
            // }

            var path = baseUri + "/cells/content/convert/text";
            path = Regex
                    .Replace(path, "\\*", string.Empty)
                    .Replace("&amp;", "&")
                    .Replace("/?", "?");

            path = UrlHelper.AddQueryParameterToUrl(path, "convertTextType", this.convertTextType);
            path = UrlHelper.AddQueryParameterToUrl(path, "sourceCharacters", this.sourceCharacters);
            path = UrlHelper.AddQueryParameterToUrl(path, "targetCharacters", this.targetCharacters);
            if (!string.IsNullOrEmpty(this.worksheet))  path = UrlHelper.AddQueryParameterToUrl(path, "worksheet", this.worksheet);
            if (!string.IsNullOrEmpty(this.range))  path = UrlHelper.AddQueryParameterToUrl(path, "range", this.range);
            if (!string.IsNullOrEmpty(this.outPath))  path = UrlHelper.AddQueryParameterToUrl(path, "outPath", this.outPath);
            if (!string.IsNullOrEmpty(this.outStorageName))  path = UrlHelper.AddQueryParameterToUrl(path, "outStorageName", this.outStorageName);
            if (!string.IsNullOrEmpty(this.region))  path = UrlHelper.AddQueryParameterToUrl(path, "region", this.region);
            if (!string.IsNullOrEmpty(this.password))  path = UrlHelper.AddQueryParameterToUrl(path, "password", this.password);
            if (this.extendQueryParameterMap != null)
            {
                foreach (KeyValuePair<string, string> kvp in extendQueryParameterMap)
                {
                    path = UrlHelper.AddQueryParameterToUrl(path, kvp.Key, kvp.Value);
                }
            }

             if (!string.IsNullOrEmpty(Spreadsheet ) && System.IO.File.Exists(Spreadsheet )) {
                 System.IO.FileInfo fileInfo = new System.IO.FileInfo(Spreadsheet);
                 localVarFileParams.Add(fileInfo.Name, UrlHelper.ToFileInfo(System.IO.File.OpenRead(Spreadsheet), fileInfo.Name));
             }



            return UrlHelper.PrepareRequest(path, "PUT", localVarFileParams, localVarHeaderParams, localVarPostBody, localVarHttpContentType, defaultHeaderMap, requestHandlers);
        }
    }
}
