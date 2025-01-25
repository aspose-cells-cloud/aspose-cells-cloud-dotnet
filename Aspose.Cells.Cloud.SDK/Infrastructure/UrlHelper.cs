// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="UrlHelper.cs">
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


namespace Aspose.Cells.Cloud.SDK
{
    using Aspose.Cells.Cloud.SDK.Invoker;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net;
    using System.Text;
    using System.Web;

    internal class UrlHelper
    {
        internal static string AddPathParameter(string url, string parameterName, object parameterValue)
        {
            if (parameterValue == null || string.IsNullOrEmpty(parameterValue.ToString()))
            {
                url = url.Replace("/{" + parameterName + "}", string.Empty);
            }
            else
            {
                url = url.Replace("{" + parameterName + "}", parameterValue.ToString());
            }

            return url;
        }

        internal static string AddQueryParameterToUrl(string url, string parameterName, object parameterValue)
        {
            if (url.Contains("{" + parameterName + "}"))
            {               
                url = AddPathParameter(url, parameterName, parameterValue);
                return url;
            }

            if (url.Contains("%7B" + parameterName + "%7D"))
            {
                url = url.Replace("%7B", "{").Replace("%7D", "}");
                url = AddPathParameter(url, parameterName, parameterValue);
                return url;
            }

            if (parameterValue == null)
            {
                return url;
            }

            url = AddParamToQuery(url, parameterName, parameterValue.ToString());           
            return url;
        }
        internal static Invoker.FileInfo ToFileInfo(Stream stream, string paramName)
        {
            string contentType = paramName.Equals("File", StringComparison.InvariantCultureIgnoreCase)
                ? "application/octet-stream"
                : (paramName.Equals("XML", StringComparison.InvariantCultureIgnoreCase) ? "application/xml" : "application/json");
            if (paramName.ToLower().EndsWith(".csv"))
            {
                contentType = "text/csv";
            }
            return new Invoker.FileInfo
            {
                Name = paramName,
                MimeType = contentType,
                FileContent = StreamHelper.ReadAsBytes(stream)
            };
        }
        internal static HttpWebRequest PrepareRequest(string path, string method, Dictionary<string, object> formParams,
            Dictionary<string, string> headerParams, string body, string contentType, IDictionary<string, string> defaultHeaderMap, List<IRequestHandler> requestHandlers )
        {
            var client = (HttpWebRequest)WebRequest.Create(path);

            client.Method = method;

            byte[] formData = null;
            if (formParams.Count > 0)
            {
                if (formParams.Count > 0)
                {
                    string formDataBoundary = Guid.NewGuid().ToString("D");
                    client.ContentType = "multipart/form-data; boundary=" + formDataBoundary;
                    formData = GetMultipartFormData(formParams, formDataBoundary);
                }
                else
                {
                    client.ContentType = "multipart/form-data";
                    formData = GetMultipartFormData(formParams, string.Empty);
                }

                client.ContentLength = formData.Length;
            }
            else
            {
                client.ContentType = contentType;
            }

            foreach (var headerParamsItem in headerParams)
            {
                if (headerParamsItem.Key == "Accept")
                    client.Accept = headerParamsItem.Value;
                else
                    client.Headers.Add(headerParamsItem.Key, headerParamsItem.Value);
            }

            foreach (var defaultHeaderMapItem in defaultHeaderMap)
                if (!headerParams.ContainsKey(defaultHeaderMapItem.Key))
                    client.Headers.Add(defaultHeaderMapItem.Key, defaultHeaderMapItem.Value);

            MemoryStream streamToSend = null;
            try
            {
                switch (method)
                {
                    case "GET":
                        break;
                    case "POST":
                    case "PUT":
                    case "DELETE":
                        streamToSend = new MemoryStream();

                        if (formData != null)
                            streamToSend.Write(formData, 0, formData.Length);

                        if (body != null)
                        {
                            var requestWriter = new StreamWriter(streamToSend);
                            requestWriter.Write(body);
                            requestWriter.Flush();
                        }

                        break;
                    default:
                        throw new HttpWebException("Unknown method type " + method, CommonStatusCode.InternalError);
                }

                requestHandlers.ForEach(p => p.BeforeSend(client, streamToSend));

                if (streamToSend != null)
                {
                    using (var requestStream = client.GetRequestStream())
                    {
                        StreamHelper.CopyTo(streamToSend, requestStream);
                    }
               }
            }
            finally
            {
                if (streamToSend != null)
                    streamToSend.Dispose();
            }

            return client;
        }
        private static byte[] GetMultipartFormData(Dictionary<string, object> postParameters, string boundary)
        {
            Stream formDataStream = new MemoryStream();
            var needsClrf = false;

            if (postParameters.Count > 1)
            {
                foreach (var param in postParameters)
                {
                    // Thanks to feedback from commenters, add a CRLF to allow multiple parameters to be added.
                    // Skip it on the first parameter, add it to subsequent parameters.
                    if (needsClrf)
                        formDataStream.Write(Encoding.UTF8.GetBytes("\r\n"), 0, Encoding.UTF8.GetByteCount("\r\n"));

                    needsClrf = true;

                    if (param.Value is Invoker.FileInfo)
                    {
                        var fileInfo = (Invoker.FileInfo)param.Value;
                        var postData =
                            string.Format(
                                "--{0}\r\nContent-Disposition: form-data; name=\"{1}\"; filename=\"{1}\"\r\nContent-Type: {2}\r\n\r\n",
                                boundary,
                                param.Key,
                                fileInfo.MimeType);
                        formDataStream.Write(Encoding.UTF8.GetBytes(postData), 0, Encoding.UTF8.GetByteCount(postData));

                        // Write the file data directly to the Stream, rather than serializing it to a string.
                        formDataStream.Write(fileInfo.FileContent, 0, fileInfo.FileContent.Length);
                    }
                    else
                    {
                        var stringData = JsonSerializationHelper.Serialize(param.Value);
                        var postData =
                            string.Format(
                                "--{0}\r\nContent-Disposition: form-data; name=\"{1}\"\r\n\r\n{2}",
                                boundary,
                                param.Key,
                                stringData);
                        formDataStream.Write(Encoding.UTF8.GetBytes(postData), 0, Encoding.UTF8.GetByteCount(postData));
                    }
                }

                // Add the end of the request.  Start with a newline
                var footer = "\r\n--" + boundary + "--\r\n";
                formDataStream.Write(Encoding.UTF8.GetBytes(footer), 0, Encoding.UTF8.GetByteCount(footer));
            }
            else
            {
                foreach (var param in postParameters)
                    if (param.Value is Invoker.FileInfo)
                    {
                        var fileInfo = (Invoker.FileInfo)param.Value;
                        //var fileInfo = (FileInfo)param.Value;
                        var postData =
                            string.Format(
                                "--{0}\r\nContent-Disposition: form-data; name=\"{1}\"; filename=\"{1}\"\r\nContent-Type: {2}\r\n\r\n",
                                boundary,
                                param.Key,
                                fileInfo.MimeType);
                        formDataStream.Write(Encoding.UTF8.GetBytes(postData), 0, Encoding.UTF8.GetByteCount(postData));
                        // Write the file data directly to the Stream, rather than serializing it to a string.
                        formDataStream.Write(fileInfo.FileContent, 0, fileInfo.FileContent.Length);
                        var footer = "\r\n--" + boundary + "--\r\n";
                        formDataStream.Write(Encoding.UTF8.GetBytes(footer), 0, Encoding.UTF8.GetByteCount(footer));
                        // Write the file data directly to the Stream, rather than serializing it to a string.
                        //formDataStream.Write(fileInfo.FileContent, 0, fileInfo.FileContent.Length);
                    }
                    else if (param.Value is byte[])
                    {
                        // Write the file data directly to the Stream, rather than serializing it to a string.
                        formDataStream.Write(param.Value as byte[], 0, (param.Value as byte[]).Length);
                    }
                    else
                    {
                        string postData;
                        if (!(param.Value is string))
                            postData = JsonSerializationHelper.Serialize(param.Value);
                        else
                            postData = (string)param.Value;

                        formDataStream.Write(Encoding.UTF8.GetBytes(postData), 0, Encoding.UTF8.GetByteCount(postData));
                    }
            }

            // Dump the Stream into a byte[]
            formDataStream.Position = 0;
            var formData = new byte[formDataStream.Length];
            formDataStream.Read(formData, 0, formData.Length);
            formDataStream.Close();

            return formData;
        }
        private static string AddParamToQuery(string url, string parameterName, string parameterValue)
        {

            if (url.Contains("?"))
            {
                url += "&";
            }
            else
            {
                url += "?";
            }

            //url += string.Format("{0}={1}", parameterName, HttpUtility.UrlEncode(parameterValue));
            //url += string.Format("{0}={1}", parameterName, Uri.EscapeUriString(parameterValue));
            url += string.Format("{0}={1}", parameterName, Uri.UnescapeDataString(parameterValue));
            return url;
        }


    }
}
