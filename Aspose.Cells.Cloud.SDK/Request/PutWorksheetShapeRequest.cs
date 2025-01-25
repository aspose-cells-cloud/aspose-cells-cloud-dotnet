// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PutWorksheetShapeRequest.cs">
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
    /// Request model for <see cref="Aspose.Cells.Cloud.SDK.Api.CellsApi.PutWorksheetShape" /> operation.
    /// </summary>
    public class PutWorksheetShapeRequest : IRequestModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PutWorksheetShapeRequest"/> class.
        /// </summary>
        public PutWorksheetShapeRequest()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PutWorksheetShapeRequest"/> class.
        /// </summary>
        /// <param name="name">The file name.</param>
        /// <param name="sheetName">The worksheet name.</param>
        /// <param name="shapeDTO"></param>
        /// <param name="drawingType">Shape object type</param>
        /// <param name="upperLeftRow">Upper left row index.</param>
        /// <param name="upperLeftColumn">Upper left column index.</param>
        /// <param name="top">Represents the vertical offset of Spinner from its left row, in unit of pixel.</param>
        /// <param name="left">Represents the horizontal offset of Spinner from its left column, in unit of pixel.</param>
        /// <param name="width">Represents the height of Spinner, in unit of pixel.</param>
        /// <param name="height">Represents the width of Spinner, in unit of pixel.</param>
        /// <param name="folder">The folder where the file is situated.</param>
        /// <param name="storageName">The storage name where the file is situated.</param>
        public PutWorksheetShapeRequest(string name, string sheetName, Shape shapeDTO = null, string drawingType = null, int? upperLeftRow = null, int? upperLeftColumn = null, int? top = null, int? left = null, int? width = null, int? height = null, string folder = null, string storageName = null)
        {
            this.name = name;
            this.sheetName = sheetName;
            this.shapeDTO = shapeDTO;
            this.DrawingType = drawingType;
            this.upperLeftRow = upperLeftRow;
            this.upperLeftColumn = upperLeftColumn;
            this.top = top;
            this.left = left;
            this.width = width;
            this.height = height;
            this.folder = folder;
            this.storageName = storageName;
        }

        /// <summary>
        /// The file name.
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// The worksheet name.
        /// </summary>
        public string sheetName { get; set; }

        /// <summary>
        /// Gets or sets shapeDTO.
        /// </summary>
        public Shape shapeDTO { get; set; }

        /// <summary>
        /// Shape object type
        /// </summary>
        public string DrawingType { get; set; }

        /// <summary>
        /// Upper left row index.
        /// </summary>
        public int? upperLeftRow { get; set; }

        /// <summary>
        /// Upper left column index.
        /// </summary>
        public int? upperLeftColumn { get; set; }

        /// <summary>
        /// Represents the vertical offset of Spinner from its left row, in unit of pixel.
        /// </summary>
        public int? top { get; set; }

        /// <summary>
        /// Represents the horizontal offset of Spinner from its left column, in unit of pixel.
        /// </summary>
        public int? left { get; set; }

        /// <summary>
        /// Represents the height of Spinner, in unit of pixel.
        /// </summary>
        public int? width { get; set; }

        /// <summary>
        /// Represents the width of Spinner, in unit of pixel.
        /// </summary>
        public int? height { get; set; }

        /// <summary>
        /// The folder where the file is situated.
        /// </summary>
        public string folder { get; set; }

        /// <summary>
        /// The storage name where the file is situated.
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
                throw new ApiException(400, "Missing required parameter 'name' when calling PutWorksheetShape");
            }

            // verify the required parameter 'sheetName' is set
            if (string.IsNullOrEmpty (this.sheetName ))
            {
                throw new ApiException(400, "Missing required parameter 'sheetName' when calling PutWorksheetShape");
            }

            var path = baseUri + "/cells/{name}/worksheets/{sheetName}/shapes";
            path = Regex
                    .Replace(path, "\\*", string.Empty)
                    .Replace("&amp;", "&")
                    .Replace("/?", "?");

            path = UrlHelper.AddPathParameter(path, "name", this.name);
            path = UrlHelper.AddPathParameter(path, "sheetName", this.sheetName);
            if (!string.IsNullOrEmpty(this.DrawingType))  path = UrlHelper.AddQueryParameterToUrl(path, "drawingType", this.DrawingType);
            if(this.upperLeftRow != null)  path = UrlHelper.AddQueryParameterToUrl(path, "upperLeftRow", this.upperLeftRow);
            if(this.upperLeftColumn != null)  path = UrlHelper.AddQueryParameterToUrl(path, "upperLeftColumn", this.upperLeftColumn);
            if(this.top != null)  path = UrlHelper.AddQueryParameterToUrl(path, "top", this.top);
            if(this.left != null)  path = UrlHelper.AddQueryParameterToUrl(path, "left", this.left);
            if(this.width != null)  path = UrlHelper.AddQueryParameterToUrl(path, "width", this.width);
            if(this.height != null)  path = UrlHelper.AddQueryParameterToUrl(path, "height", this.height);
            if (!string.IsNullOrEmpty(this.folder))  path = UrlHelper.AddQueryParameterToUrl(path, "folder", this.folder);
            if (!string.IsNullOrEmpty(this.storageName))  path = UrlHelper.AddQueryParameterToUrl(path, "storageName", this.storageName);
            if (this.extendQueryParameterMap != null)
            {
                foreach (KeyValuePair<string, string> kvp in extendQueryParameterMap)
                {
                    path = UrlHelper.AddQueryParameterToUrl(path, kvp.Key, kvp.Value);
                }
            }

            localVarPostBody = ( this.shapeDTO != null ? JsonConvert.SerializeObject(this.shapeDTO) : null);
            return UrlHelper.PrepareRequest(path, "PUT", localVarFileParams, localVarHeaderParams, localVarPostBody, localVarHttpContentType, defaultHeaderMap, requestHandlers);
        }
    }
}
