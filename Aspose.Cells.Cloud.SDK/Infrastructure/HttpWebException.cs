// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="HttpWebException.cs">
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

namespace Aspose.Cells.Cloud.SDK
{
    using Newtonsoft.Json;
    using System;
    using System.Net;
    /// <summary>
    ///     Http Web Exception
    /// </summary>
    public class HttpWebException : Exception
    {
        #region Public Constructors

        /// <summary>
        ///     Public constructor
        /// </summary>
        /// <param name="message">Message</param>
        /// <param name="error">Error as <see cref="StatusCode"/></param>
        public HttpWebException(string message, StatusCode error) : base(message)
        {
            Code = error.Code;
            HttpStatusCode = error.HttpStatusCode;
            Description = error.Description;
        }

        /// <summary>
        ///     Public constructor
        /// </summary>
        /// <param name="message">Message</param>
        /// <param name="code">Error code</param>
        /// <param name="httpStatusCode">Status code as <see cref="System.Net.HttpStatusCode"/></param>
        /// <param name="description">Description</param>
        [JsonConstructor]
        public HttpWebException(string message, string code, HttpStatusCode httpStatusCode, string description = null)
            : base(message)
        {
            Code = code;
            HttpStatusCode = httpStatusCode;
            Description = !string.IsNullOrEmpty(description) && description.Contains("Operation Failed")
                ? description
                : "Operation Failed. " + description;
        }

        #endregion

        #region Methods

        /// <summary>
        ///     Get Description from error code and inner exception
        /// </summary>
        /// <param name="error"></param>
        /// <param name="innerException"></param>
        /// <param name="errorMessage"></param>
        protected string GetDescription(StatusCode error, Exception innerException, string errorMessage)
        {
            if (innerException != null
                && !string.IsNullOrEmpty(innerException.Message)
                && innerException.Message != errorMessage)
                return innerException.Message;

            return error.Description;
        }

        #endregion

        #region Public properties

        /// <summary>
        ///     Code
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        ///     Http Status Code
        /// </summary>
        public HttpStatusCode HttpStatusCode { get; set; }

        /// <summary>
        ///     Description
        /// </summary>
        public string Description { get; set; }

        #endregion
    }
}
