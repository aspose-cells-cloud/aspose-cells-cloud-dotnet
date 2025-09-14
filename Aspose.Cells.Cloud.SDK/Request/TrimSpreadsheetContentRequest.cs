// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="TrimSpreadsheetContentRequest.cs">
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
    /// Request model for <see cref="Aspose.Cells.Cloud.SDK.Api.CellsApi.TrimSpreadsheetContent" /> operation.
    /// </summary>
    public class TrimSpreadsheetContentRequest : IRequestModel
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="TrimSpreadsheetContentRequest"/> class.
        /// </summary>
        public TrimSpreadsheetContentRequest()
        {

        }
        /// <summary>
        /// Initializes a new instance of the <see cref="TrimSpreadsheetContentRequest"/> class.
        /// </summary>
        /// <param name="spreadsheet">Upload spreadsheet file.</param>
        /// <param name="trimContent"></param>
        /// <param name="trimLeading"></param>
        /// <param name="trimTrailing"></param>
        /// <param name="trimSpaceBetweenWordTo1"></param>
        /// <param name="trimNonBreakingSpaces"></param>
        /// <param name="removeExtraLineBreaks"></param>
        /// <param name="removeAllLineBreaks"></param>
        /// <param name="outPath">(Optional) The folder path where the workbook is stored. The default is null.</param>
        /// <param name="outStorageName">Output file Storage Name.</param>
        /// <param name="region">The spreadsheet region setting.</param>
        /// <param name="password">The password for opening spreadsheet file.</param>
        public TrimSpreadsheetContentRequest(string  spreadsheet, string  trimContent = null, bool?  trimLeading = null, bool?  trimTrailing = null, bool?  trimSpaceBetweenWordTo1 = null, bool?  trimNonBreakingSpaces = null, bool?  removeExtraLineBreaks = null, bool?  removeAllLineBreaks = null, string  outPath = null, string  outStorageName = null, string  region = null, string  password = null)
        {
            this.Spreadsheet = spreadsheet;
            this.trimContent = trimContent;
            this.trimLeading = trimLeading;
            this.trimTrailing = trimTrailing;
            this.trimSpaceBetweenWordTo1 = trimSpaceBetweenWordTo1;
            this.trimNonBreakingSpaces = trimNonBreakingSpaces;
            this.removeExtraLineBreaks = removeExtraLineBreaks;
            this.removeAllLineBreaks = removeAllLineBreaks;
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
        /// Gets or sets trimContent.
        /// </summary>
        public string trimContent { get; set; }


        /// <summary>
        /// Gets or sets trimLeading.
        /// </summary>
        public bool? trimLeading { get; set; }


        /// <summary>
        /// Gets or sets trimTrailing.
        /// </summary>
        public bool? trimTrailing { get; set; }


        /// <summary>
        /// Gets or sets trimSpaceBetweenWordTo1.
        /// </summary>
        public bool? trimSpaceBetweenWordTo1 { get; set; }


        /// <summary>
        /// Gets or sets trimNonBreakingSpaces.
        /// </summary>
        public bool? trimNonBreakingSpaces { get; set; }


        /// <summary>
        /// Gets or sets removeExtraLineBreaks.
        /// </summary>
        public bool? removeExtraLineBreaks { get; set; }


        /// <summary>
        /// Gets or sets removeAllLineBreaks.
        /// </summary>
        public bool? removeAllLineBreaks { get; set; }


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
            if (    string.IsNullOrEmpty(this.Spreadsheet)    )
            {
                throw new ApiException(400, "Missing required parameter 'spreadsheet' when calling TrimSpreadsheetContent");
            }

            var path = baseUri + "/cells/content/trim";
            path = Regex
                    .Replace(path, "\\*", string.Empty)
                    .Replace("&amp;", "&")
                    .Replace("/?", "?");

            if (!string.IsNullOrEmpty(this.trimContent))  path = UrlHelper.AddQueryParameterToUrl(path, "trimContent", this.trimContent);
            if(this.trimLeading != null)  path = UrlHelper.AddQueryParameterToUrl(path, "trimLeading", this.trimLeading);
            if(this.trimTrailing != null)  path = UrlHelper.AddQueryParameterToUrl(path, "trimTrailing", this.trimTrailing);
            if(this.trimSpaceBetweenWordTo1 != null)  path = UrlHelper.AddQueryParameterToUrl(path, "trimSpaceBetweenWordTo1", this.trimSpaceBetweenWordTo1);
            if(this.trimNonBreakingSpaces != null)  path = UrlHelper.AddQueryParameterToUrl(path, "trimNonBreakingSpaces", this.trimNonBreakingSpaces);
            if(this.removeExtraLineBreaks != null)  path = UrlHelper.AddQueryParameterToUrl(path, "removeExtraLineBreaks", this.removeExtraLineBreaks);
            if(this.removeAllLineBreaks != null)  path = UrlHelper.AddQueryParameterToUrl(path, "removeAllLineBreaks", this.removeAllLineBreaks);
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
