// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="RemoveCharactersRequest.cs">
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
    /// Request model for <see cref="Aspose.Cells.Cloud.SDK.Api.CellsApi.RemoveCharacters" /> operation.
    /// </summary>
    public class RemoveCharactersRequest : IRequestModel
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="RemoveCharactersRequest"/> class.
        /// </summary>
        public RemoveCharactersRequest()
        {

        }
        /// <summary>
        /// Initializes a new instance of the <see cref="RemoveCharactersRequest"/> class.
        /// </summary>
        /// <param name="spreadsheet">Upload spreadsheet file.</param>
        /// <param name="theFirstNCharacters"></param>
        /// <param name="theLastNCharacters"></param>
        /// <param name="allCharactersBeforeText"></param>
        /// <param name="allCharactersAfterText"></param>
        /// <param name="removeTextMethod"></param>
        /// <param name="characterSets"></param>
        /// <param name="removeCustomValue"></param>
        /// <param name="worksheet"></param>
        /// <param name="range"></param>
        /// <param name="outPath">(Optional) The folder path where the workbook is stored. The default is null.</param>
        /// <param name="outStorageName">Output file Storage Name.</param>
        /// <param name="region">The spreadsheet region setting.</param>
        /// <param name="password">The password for opening spreadsheet file.</param>
        public RemoveCharactersRequest(string  spreadsheet, int?  theFirstNCharacters, int?  theLastNCharacters, string  allCharactersBeforeText, string  allCharactersAfterText, string  removeTextMethod, string  characterSets, string  removeCustomValue, string  worksheet, string  range, string  outPath = null, string  outStorageName = null, string  region = null, string  password = null)
        {
            this.Spreadsheet = spreadsheet;
            this.theFirstNCharacters = theFirstNCharacters;
            this.theLastNCharacters = theLastNCharacters;
            this.allCharactersBeforeText = allCharactersBeforeText;
            this.allCharactersAfterText = allCharactersAfterText;
            this.removeTextMethod = removeTextMethod;
            this.characterSets = characterSets;
            this.removeCustomValue = removeCustomValue;
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
        /// Gets or sets theFirstNCharacters.
        /// </summary>
        public int? theFirstNCharacters { get; set; }


        /// <summary>
        /// Gets or sets theLastNCharacters.
        /// </summary>
        public int? theLastNCharacters { get; set; }


        /// <summary>
        /// Gets or sets allCharactersBeforeText.
        /// </summary>
        public string allCharactersBeforeText { get; set; }


        /// <summary>
        /// Gets or sets allCharactersAfterText.
        /// </summary>
        public string allCharactersAfterText { get; set; }


        /// <summary>
        /// Gets or sets removeTextMethod.
        /// </summary>
        public string removeTextMethod { get; set; }


        /// <summary>
        /// Gets or sets characterSets.
        /// </summary>
        public string characterSets { get; set; }


        /// <summary>
        /// Gets or sets removeCustomValue.
        /// </summary>
        public string removeCustomValue { get; set; }


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
            if (    string.IsNullOrEmpty(this.Spreadsheet)    )
            {
                throw new ApiException(400, "Missing required parameter 'spreadsheet' when calling RemoveCharacters");
            }

            // verify the required parameter 'theFirstNCharacters' is set
            if ( this.theFirstNCharacters == null)
            {
                throw new ApiException(400, "Missing required parameter 'theFirstNCharacters' when calling RemoveCharacters");
            }

            // verify the required parameter 'theLastNCharacters' is set
            if ( this.theLastNCharacters == null)
            {
                throw new ApiException(400, "Missing required parameter 'theLastNCharacters' when calling RemoveCharacters");
            }

            // verify the required parameter 'allCharactersBeforeText' is set
            if (string.IsNullOrEmpty (this.allCharactersBeforeText ))
            {
                throw new ApiException(400, "Missing required parameter 'allCharactersBeforeText' when calling RemoveCharacters");
            }

            // verify the required parameter 'allCharactersAfterText' is set
            if (string.IsNullOrEmpty (this.allCharactersAfterText ))
            {
                throw new ApiException(400, "Missing required parameter 'allCharactersAfterText' when calling RemoveCharacters");
            }

            // verify the required parameter 'removeTextMethod' is set
            if (string.IsNullOrEmpty (this.removeTextMethod ))
            {
                throw new ApiException(400, "Missing required parameter 'removeTextMethod' when calling RemoveCharacters");
            }

            // verify the required parameter 'characterSets' is set
            if (string.IsNullOrEmpty (this.characterSets ))
            {
                throw new ApiException(400, "Missing required parameter 'characterSets' when calling RemoveCharacters");
            }

            // verify the required parameter 'removeCustomValue' is set
            if (string.IsNullOrEmpty (this.removeCustomValue ))
            {
                throw new ApiException(400, "Missing required parameter 'removeCustomValue' when calling RemoveCharacters");
            }

            // verify the required parameter 'worksheet' is set
            if (string.IsNullOrEmpty (this.worksheet ))
            {
                throw new ApiException(400, "Missing required parameter 'worksheet' when calling RemoveCharacters");
            }

            // verify the required parameter 'range' is set
            if (string.IsNullOrEmpty (this.range ))
            {
                throw new ApiException(400, "Missing required parameter 'range' when calling RemoveCharacters");
            }

            var path = baseUri + "/cells/content/remove/characters";
            path = Regex
                    .Replace(path, "\\*", string.Empty)
                    .Replace("&amp;", "&")
                    .Replace("/?", "?");

            path = UrlHelper.AddQueryParameterToUrl(path, "theFirstNCharacters", this.theFirstNCharacters);
            path = UrlHelper.AddQueryParameterToUrl(path, "theLastNCharacters", this.theLastNCharacters);
            path = UrlHelper.AddQueryParameterToUrl(path, "allCharactersBeforeText", this.allCharactersBeforeText);
            path = UrlHelper.AddQueryParameterToUrl(path, "allCharactersAfterText", this.allCharactersAfterText);
            path = UrlHelper.AddQueryParameterToUrl(path, "removeTextMethod", this.removeTextMethod);
            path = UrlHelper.AddQueryParameterToUrl(path, "characterSets", this.characterSets);
            path = UrlHelper.AddQueryParameterToUrl(path, "removeCustomValue", this.removeCustomValue);
            path = UrlHelper.AddQueryParameterToUrl(path, "worksheet", this.worksheet);
            path = UrlHelper.AddQueryParameterToUrl(path, "range", this.range);
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
