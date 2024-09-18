// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="JwtTokenRequestHandler.cs">
//   Copyright (c) 2024 Aspose.Cells Cloud
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

    using Newtonsoft.Json;
    using System.Collections.Generic;
    using System.IO;
    using System.Net;

    /// <summary>
    ///     Access Token Handler
    /// </summary>
    internal class JwtTokenRequestHandler : IRequestHandler
    {
        private readonly string baseApiUrl;
        private readonly string clientId;
        private readonly string clientSecret;
        private readonly ApiInvoker apiInvoker;
        private string accessToken;

        internal JwtTokenRequestHandler(string baseApiUrl, string clientId, string clientSecret)
        {
            this.baseApiUrl = baseApiUrl;
            this.clientId = clientId;
            this.clientSecret = clientSecret;

            var requestHandlers = new List<IRequestHandler>();
            requestHandlers.Add(new ApiExceptionRequestHandler());
            apiInvoker = new ApiInvoker(requestHandlers);
        }

        public string ProcessUrl(string url)
        {
            if (string.IsNullOrEmpty(accessToken))
                RequestToken();

            return url;
        }

        public void BeforeSend(WebRequest request, Stream streamToSend)
        {
            request.Headers.Add("Authorization", "Bearer " + accessToken);
        }

        public void ProcessResponse(HttpWebResponse response, Stream resultStream)
        {
            if (response.StatusCode == HttpStatusCode.Unauthorized)
            {
                RequestToken();

                throw new NeedRepeatRequestException();
            }
        }

        private void RequestToken()
        {
            var requestUrl = baseApiUrl + "/v3.0/cells/connect/token";

            var postData = "grant_type=client_credentials";
            postData += "&client_id=" + clientId;
            postData += "&client_secret=" + clientSecret;

            var responseString = apiInvoker.InvokeApiAsync<string>(
                requestUrl,
                "POST",
                postData,
                contentType: "application/x-www-form-urlencoded")
                .Result;

            var result =
                (GetAccessTokenResult)JsonSerializationHelper.Deserialize(responseString, typeof(GetAccessTokenResult));

            accessToken = result.AccessToken;
        }
        private class GetAccessTokenResult
        {
            [JsonProperty(PropertyName = "access_token")]
            public string AccessToken { get; set; }
        }

    }
}
