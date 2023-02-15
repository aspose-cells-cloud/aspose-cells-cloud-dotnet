// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PutWorksheetShapeRequest.cs">
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
        /// <param name="name"></param>
        /// <param name="sheetName"></param>
        /// <param name="shapeDTO"></param>
        /// <param name="drawingType"></param>
        /// <param name="upperLeftRow"></param>
        /// <param name="upperLeftColumn"></param>
        /// <param name="top"></param>
        /// <param name="left"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="folder"></param>
        /// <param name="storageName"></param>
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
        /// Gets or sets name.
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// Gets or sets sheetName.
        /// </summary>
        public string sheetName { get; set; }

        /// <summary>
        /// Gets or sets shapeDTO.
        /// </summary>
        public Shape shapeDTO { get; set; }

        /// <summary>
        /// Gets or sets DrawingType.
        /// </summary>
        public string DrawingType { get; set; }

        /// <summary>
        /// Gets or sets upperLeftRow.
        /// </summary>
        public int? upperLeftRow { get; set; }

        /// <summary>
        /// Gets or sets upperLeftColumn.
        /// </summary>
        public int? upperLeftColumn { get; set; }

        /// <summary>
        /// Gets or sets top.
        /// </summary>
        public int? top { get; set; }

        /// <summary>
        /// Gets or sets left.
        /// </summary>
        public int? left { get; set; }

        /// <summary>
        /// Gets or sets width.
        /// </summary>
        public int? width { get; set; }

        /// <summary>
        /// Gets or sets height.
        /// </summary>
        public int? height { get; set; }

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
                    UrlHelper.AddQueryParameterToUrl(path, kvp.Key, kvp.Value);
                }
            }

            localVarPostBody = ( this.shapeDTO != null ? JsonConvert.SerializeObject(this.shapeDTO) : null);
            return UrlHelper.PrepareRequest(path, "PUT", localVarFileParams, localVarHeaderParams, localVarPostBody, localVarHttpContentType, defaultHeaderMap, requestHandlers);
        }
    }
}
