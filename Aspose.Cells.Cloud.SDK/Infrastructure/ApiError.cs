// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ApiError.cs">
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
    using System;
    /// <summary>
    ///     Api Error
    /// </summary>
    internal static class ApiError
    {
        /// <summary>
        ///     Generate error response
        /// </summary>
        /// <param name="code">Api error code</param>
        /// <param name="message">Message</param>
        /// <param name="description">Description</param>
        /// <param name="requestId">RequestId</param>
        /// <param name="dateTime">The date and time</param>
        internal static object Generate(string code, string message, string description, string requestId, DateTime dateTime)
        {
            return new
            {
                Error = new
                {
                    Code = code,
                    Message = message,
                    Description = description,
                    InnerError = new
                    {
                        RequestId = requestId,
                        Date = dateTime
                    }
                }
            };
        }
    }
}

