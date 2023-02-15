// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ApiExceptionRequestHandler.cs">
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

namespace Aspose.Cells.Cloud.SDK.Invoker
{
    using System;
    using System.IO;
    using System.Net;

    /// <summary>
    ///     Api Exception Request Handler
    /// </summary>
    internal class ApiExceptionRequestHandler : IRequestHandler
    {
        private string method;

        public string ProcessUrl(string url)
        {
            return url;
        }

        public void BeforeSend(WebRequest request, Stream streamToSend)
        {
            method = request.Method;
        }

        public void ProcessResponse(HttpWebResponse response, Stream resultStream)
        {
            if (method == "DELETE" && response.StatusCode == HttpStatusCode.NoContent)
                return;

            if (method == "POST" && response.StatusCode == HttpStatusCode.Created)
                return;

            if (method == "PUT" && response.StatusCode == HttpStatusCode.Created)
                return;

            if (response.StatusCode != HttpStatusCode.OK)
                ThrowApiException(response, resultStream);
        }

        private void ThrowApiException(HttpWebResponse webResponse, Stream resultStream)
        {
            try
            {
                resultStream.Position = 0;
                using (var responseReader = new StreamReader(resultStream))
                {
                    var responseData = responseReader.ReadToEnd();
                    var errorResponse = (ApiErrorResponse)JsonSerializationHelper.Deserialize(responseData, typeof(ApiErrorResponse));

                    if (errorResponse == null)
                    {
                        errorResponse = new ApiErrorResponse();
                        errorResponse.Error = new HttpWebException(responseData, CommonStatusCode.Error.Code, webResponse.StatusCode);
                    }

                    throw errorResponse.Error;
                }
            }
            catch (HttpWebException)
            {
                throw;
            }
            catch (Exception)
            {
                throw new HttpWebException(webResponse.StatusDescription, CommonStatusCode.Error.Code, webResponse.StatusCode);
            }
        }
    }
}