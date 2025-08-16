// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="SearchSpreadsheetContentRequest.cs">
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
    /// Request model for <see cref="Aspose.Cells.Cloud.SDK.Api.CellsApi.SearchSpreadsheetContent" /> operation.
    /// </summary>
    public class SearchSpreadsheetContentRequest : IRequestModel
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchSpreadsheetContentRequest"/> class.
        /// </summary>
        public SearchSpreadsheetContentRequest()
        {

        }
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchSpreadsheetContentRequest"/> class.
        /// </summary>
        /// <param name="spreadsheet">Upload spreadsheet file.</param>
        /// <param name="searchText">The searched text.</param>
        /// <param name="ignoringCase">Ignore the text of the search.</param>
        /// <param name="worksheet">Specify the worksheet for the lookup.</param>
        /// <param name="cellArea">Specify the cell area for the lookup</param>
        /// <param name="regoin">The spreadsheet region setting.</param>
        /// <param name="password">The password for opening spreadsheet file.</param>
        public SearchSpreadsheetContentRequest(string  spreadsheet, string  searchText, bool?  ignoringCase = null, string  worksheet = null, string  cellArea = null, string  regoin = null, string  password = null)
        {
            this.Spreadsheet = spreadsheet;
            this.searchText = searchText;
            this.ignoringCase = ignoringCase;
            this.worksheet = worksheet;
            this.cellArea = cellArea;
            this.regoin = regoin;
            this.password = password;
        }
        
        /// <summary>
        /// Upload spreadsheet file.
        /// </summary>
            public string Spreadsheet { get; set; }


        /// <summary>
        /// The searched text.
        /// </summary>
        public string searchText { get; set; }


        /// <summary>
        /// Ignore the text of the search.
        /// </summary>
        public bool? ignoringCase { get; set; }


        /// <summary>
        /// Specify the worksheet for the lookup.
        /// </summary>
        public string worksheet { get; set; }


        /// <summary>
        /// Specify the cell area for the lookup
        /// </summary>
        public string cellArea { get; set; }


        /// <summary>
        /// The spreadsheet region setting.
        /// </summary>
        public string regoin { get; set; }


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
                throw new ApiException(400, "Missing required parameter 'spreadsheet' when calling SearchSpreadsheetContent");
            }

            // verify the required parameter 'searchText' is set
            if (string.IsNullOrEmpty (this.searchText ))
            {
                throw new ApiException(400, "Missing required parameter 'searchText' when calling SearchSpreadsheetContent");
            }

            var path = baseUri + "/cells/search/content";
            path = Regex
                    .Replace(path, "\\*", string.Empty)
                    .Replace("&amp;", "&")
                    .Replace("/?", "?");

            path = UrlHelper.AddQueryParameterToUrl(path, "searchText", this.searchText);
            if(this.ignoringCase != null)  path = UrlHelper.AddQueryParameterToUrl(path, "ignoringCase", this.ignoringCase);
            if (!string.IsNullOrEmpty(this.worksheet))  path = UrlHelper.AddQueryParameterToUrl(path, "worksheet", this.worksheet);
            if (!string.IsNullOrEmpty(this.cellArea))  path = UrlHelper.AddQueryParameterToUrl(path, "cellArea", this.cellArea);
            if (!string.IsNullOrEmpty(this.regoin))  path = UrlHelper.AddQueryParameterToUrl(path, "regoin", this.regoin);
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
