// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="CommonStatusCode.cs">
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
    using System.Net;
    /// <summary>
    ///     The error codes for RestApi Products
    /// </summary>
    public static class CommonStatusCode
    {
        /// <summary>
        ///     Successful Operation.
        /// </summary>
        public static StatusCode Success = new StatusCode()
        {
            Code = "success",
            HttpStatusCode = HttpStatusCode.OK,
            Description = "Successful Operation."
        };

        /// <summary>
        ///     Partial Successful Operation.
        /// </summary>
        public static StatusCode SuccessPartial = new StatusCode()
        {
            Code = "successPartial",
            HttpStatusCode = HttpStatusCode.OK,
            Description = "Partial Successful Operation."
        };

        /// <summary>
        ///     Operation Failed. General Error.
        /// </summary>
        public static StatusCode Error = new StatusCode()
        {
            Code = "error",
            HttpStatusCode = HttpStatusCode.BadRequest,
            Description = "Operation Failed. General Error."
        };

        /// <summary>
        ///     Operation Failed. The input data did not pass validation.
        /// </summary>
        public static StatusCode ErrorInvalidInputData = new StatusCode()
        {
            Code = "errorInvalidInputData",
            HttpStatusCode = HttpStatusCode.BadRequest,
            Description = "Operation Failed. The input data is not valid."
        };

        /// <summary>
        ///     Operation Failed. Not allowed in test mode.
        /// </summary>
        public static StatusCode ErrorNotAllowedInTestMode = new StatusCode()
        {
            Code = "errorNotAllowedInTestMode",
            HttpStatusCode = HttpStatusCode.BadRequest,
            Description = "Operation Failed. Not allowed in test mode."
        };

        /// <summary>
        ///     Operation Failed. Invalid Email.
        /// </summary>
        public static StatusCode ErrorInvalidEmail = new StatusCode()
        {
            Code = "errorInvalidEmail",
            HttpStatusCode = HttpStatusCode.BadRequest,
            Description = "Operation Failed. Invalid Email."
        };

        /// <summary>
        ///     Operation Failed. The authentication data is incorrect.
        /// </summary>
        public static StatusCode ErrorAuthentication = new StatusCode()
        {
            Code = "errorAuthentication",
            HttpStatusCode = HttpStatusCode.Unauthorized,
            Description = "Operation Failed. The authentication data is incorrect."
        };

        /// <summary>
        ///     Operation Failed. The authorization data is incorrect.
        /// </summary>
        public static StatusCode ErrorAuthorization = new StatusCode()
        {
            Code = "errorAuthorization",
            HttpStatusCode = HttpStatusCode.Unauthorized,
            Description = "Operation Failed. The authorization data is incorrect."
        };

        /// <summary>
        ///     Operation Failed. Item Not Found.
        /// </summary>
        public static StatusCode ErrorItemNotFound = new StatusCode()
        {
            Code = "errorItemNotFound",
            HttpStatusCode = HttpStatusCode.NotFound,
            Description = "Operation Failed. Item Not Found."
        };

        /// <summary>
        ///     Operation Failed. It is not allowed due to given restrictions.
        /// </summary>
        public static StatusCode ErrorNotAllowed = new StatusCode()
        {
            Code = "errorNotAllowed",
            HttpStatusCode = HttpStatusCode.MethodNotAllowed,
            Description = "Operation Failed. It is not allowed due to given restrictions."
        };

        /// <summary>
        ///     Operation Failed. Request timeout.
        /// </summary>
        public static StatusCode RequestTimeout = new StatusCode()
        {
            Code = "requestTimeout",
            HttpStatusCode = HttpStatusCode.RequestTimeout,
            Description = "Operation Failed. Request timeout."
        };

        /// <summary>
        ///     Operation Failed. Duplicate Item Constraint .
        /// </summary>
        public static StatusCode ErrorDuplicateItem = new StatusCode()
        {
            Code = "errorDuplicateItem",
            HttpStatusCode = HttpStatusCode.Conflict,
            Description = "Operation Failed. Duplicate Item Constraint."
        };

        /// <summary>
        ///     Operation Failed. The requested range cannot be satisfied.
        /// </summary>
        public static StatusCode InvalidRange = new StatusCode()
        {
            Code = "invalidRange",
            HttpStatusCode = HttpStatusCode.RequestedRangeNotSatisfiable,
            Description = "Operation Failed. The requested range cannot be satisfied."
        };

        /// <summary>
        ///     Operation Failed. Internal error.
        /// </summary>
        public static StatusCode InternalError = new StatusCode()
        {
            Code = "internalError",
            HttpStatusCode = HttpStatusCode.InternalServerError,
            Description = "Operation Failed. Internal error."
        };

        /// <summary>
        ///     Operation Failed. Not implemented.
        /// </summary>
        public static StatusCode ErrorNotImplemented = new StatusCode()
        {
            Code = "errorNotImplemented",
            HttpStatusCode = HttpStatusCode.NotImplemented,
            Description = "Operation Failed. Not implemented."
        };

        /// <summary>
        ///     Operation Failed. The service is not available.
        /// </summary>
        public static StatusCode ErrorDownForMaintenance = new StatusCode()
        {
            Code = "errorDownForMaintenance",
            HttpStatusCode = HttpStatusCode.ServiceUnavailable,
            Description = "Operation Failed. The service is not available."
        };
    }
}


