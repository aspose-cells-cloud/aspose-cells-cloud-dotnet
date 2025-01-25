// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="StreamHelper  .cs">
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

namespace Aspose.Cells.Cloud.SDK.Invoker
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Serialization;
    using System.IO;
    using System.Text;

    /// <summary>
    ///     Stream helper
    /// </summary>
    internal static class StreamHelper
    {
        /// <summary>
        ///     Copy a stream to destination stream
        /// </summary>
        /// <param name="source">The source stream</param>
        /// <param name="destination">The destination stream</param>
        /// <param name="bufferSize">The size of the buffer</param>
        internal static void CopyTo(Stream source, Stream destination, int bufferSize = 81920)
        {
            if (source.CanSeek)
            {
                source.Flush();
                source.Position = 0;
            }

            var array = new byte[bufferSize];
            int count;
            while ((count = source.Read(array, 0, array.Length)) != 0)
                destination.Write(array, 0, count);
        }

        /// <summary>
        ///     ReadAsBytes
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        internal static byte[] ReadAsBytes(Stream input)
        {
            var buffer = new byte[16 * 1024];
            using (var ms = new MemoryStream())
            {
                int read;
                while ((read = input.Read(buffer, 0, buffer.Length)) > 0)
                    ms.Write(buffer, 0, read);

                return ms.ToArray();
            }
        }

        /// <summary>
        ///     CopyStreamToStringBuilder
        /// </summary>
        /// <param name="sb"></param>
        /// <param name="stream"></param>
        internal static void CopyStreamToStringBuilder(StringBuilder sb, Stream stream)
        {
            if (stream == null || !stream.CanRead)
                return;

            Stream streamToRead;
            if (!stream.CanSeek)
            {
                streamToRead = new MemoryStream(1024);
                CopyTo(stream, streamToRead);
            }
            else
            {
                streamToRead = stream;
            }

            streamToRead.Seek(0, SeekOrigin.Begin);
            var bodyReader = new StreamReader(streamToRead);
            if (bodyReader.Peek() != -1)
            {
                var content = bodyReader.ReadToEnd();
                streamToRead.Seek(0, SeekOrigin.Begin);

                sb.AppendLine("Body:");
                sb.AppendLine(content);
            }
        }

        /// <summary>
        ///     Convert object to <see cref="Stream"/>
        /// </summary>
        /// <param name="obj">The object</param>
        /// <param name="camelCase">Set if the response should be camel case or not</param>
        internal static Stream ToStream(this object obj, bool camelCase = true)
        {
            var str = string.Empty;

            if (camelCase)
            {
                var settings = new JsonSerializerSettings();
                settings.ContractResolver = new CamelCasePropertyNamesContractResolver();
                str = JsonConvert.SerializeObject(obj, settings);
            }
            else
            {
                str = JsonConvert.SerializeObject(obj);
            }

            var array = Encoding.UTF8.GetBytes(str);
            var stream = new MemoryStream(array);
            stream.Seek(0, SeekOrigin.Begin);

            return stream;
        }

        /// <summary>
        ///     Convert <see cref="Stream"/> to <see cref="String"/>
        /// </summary>
        /// <param name="stream">The stream</param>
        internal static string StreamToString(Stream stream)
        {
            stream.Position = 0;
            using (var reader = new StreamReader(stream))
            {
                return reader.ReadToEnd();
            }
        }
    }
}
