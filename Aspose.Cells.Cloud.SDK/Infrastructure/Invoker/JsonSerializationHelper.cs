// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="JsonSerializationHelper.cs">
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
    using Newtonsoft.Json;
    using System;
    using System.IO;
    using System.Xml;
    /// <summary>
    ///     Internal serializers to serialize/deserialize data using JsonConvert
    /// </summary>
    internal class JsonSerializationHelper
    {
        /// <summary>
        ///     Serialize object
        /// </summary>
        /// <param name="obj">The object to serialize</param>
        internal static string Serialize(object obj)
        {
            try
            {
                if (obj == null) return null;

                var settings = new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore };
                return JsonConvert.SerializeObject(obj, settings);
            }
            catch (Exception exc)
            {
                throw new HttpWebException(exc.Message, CommonStatusCode.InternalError);
            }
        }

        /// <summary>
        ///     Deserializes an object into specified type
        /// </summary>
        /// <param name="json">The object serialized</param>
        /// <param name="type">The type</param>
        internal static object Deserialize(string json, Type type)
        {
            try
            {
                if (string.IsNullOrEmpty(json)) return null;

                if (json.StartsWith("{") || json.StartsWith("["))
                    return JsonConvert.DeserializeObject(json, type);

                var xmlDoc = new XmlDocument();
                xmlDoc.LoadXml(json);
                return JsonConvert.SerializeXmlNode(xmlDoc);
            }
            catch (IOException e)
            {
                throw new HttpWebException(e.Message, CommonStatusCode.InternalError);
            }
            catch (JsonSerializationException jse)
            {
                throw new HttpWebException(jse.Message, CommonStatusCode.InternalError);
            }
            catch (XmlException xmle)
            {
                throw new HttpWebException(xmle.Message, CommonStatusCode.InternalError);
            }
        }
    }
}
