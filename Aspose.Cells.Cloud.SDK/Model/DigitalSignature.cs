// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="DigitalSignature.cs">
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

namespace Aspose.Cells.Cloud.SDK.Model
{
    using System;  
    using System.Collections;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using System.Text;
    using System.Drawing;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// Signature in file.
    ///             
    /// </summary>
    public class DigitalSignature
    {
        /// <summary>
        /// The purpose to signature.
        /// </summary>
        public virtual string Comments { get; set; }

        /// <summary>
        /// The time when the document was signed.
        /// </summary>
        public virtual string SignTime { get; set; }

        /// <summary>
        /// Specifies a GUID which can be cross-referenced with the GUID of the signature line stored in the document content. Default value is Empty (all zeroes) Guid.
        /// </summary>
        public virtual string Id { get; set; }

        /// <summary>
        /// Specifies the text of actual signature in the digital signature. Default value is Empty.
        ///             
        /// </summary>
        public virtual string Password { get; set; }

        /// <summary>
        /// Specifies an image for the digital signature. Default value is null.
        /// </summary>
        public virtual byte[] Image { get; set; }

        /// <summary>
        /// Specifies the class ID of the signature provider. Default value is Empty (all zeroes) Guid.
        ///             
        /// </summary>
        public virtual string ProviderId { get; set; }

        /// <summary>
        /// If this digital signature is valid and the document has not been tampered with, this value will be true.
        /// </summary>
        public virtual bool? IsValid { get; set; }

        /// <summary>
        /// XAdES type. Default value is None(XAdES is off).
        /// </summary>
        public virtual string XAdESType { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DigitalSignature {\n");
            sb.Append("  Comments: ").Append(this.Comments).Append("\n");
            sb.Append("  SignTime: ").Append(this.SignTime).Append("\n");
            sb.Append("  Id: ").Append(this.Id).Append("\n");
            sb.Append("  Password: ").Append(this.Password).Append("\n");
            sb.Append("  Image: ").Append(this.Image).Append("\n");
            sb.Append("  ProviderId: ").Append(this.ProviderId).Append("\n");
            sb.Append("  IsValid: ").Append(this.IsValid).Append("\n");
            sb.Append("  XAdESType: ").Append(this.XAdESType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
