// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PdfSecurityOptions.cs">
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
    /// Options for encrypting and access permissions for a PDF document.            PDF/A does not allow security setting.
    /// </summary>
    public class PdfSecurityOptions
    {
        /// <summary>
        /// Indicates whether to allow to add or modify text annotations, fill in interactive form fields.
        /// </summary>
        public virtual bool? AnnotationsPermission { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual bool? AssembleDocumentPermission { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual bool? ExtractContentPermission { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual bool? FillFormsPermission { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual bool? FullQualityPrintPermission { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual bool? ModifyDocumentPermission { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual string OwnerPassword { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual bool? PrintPermission { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual string UserPassword { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PdfSecurityOptions {\n");
            sb.Append("  AnnotationsPermission: ").Append(this.AnnotationsPermission).Append("\n");
            sb.Append("  AssembleDocumentPermission: ").Append(this.AssembleDocumentPermission).Append("\n");
            sb.Append("  ExtractContentPermission: ").Append(this.ExtractContentPermission).Append("\n");
            sb.Append("  FillFormsPermission: ").Append(this.FillFormsPermission).Append("\n");
            sb.Append("  FullQualityPrintPermission: ").Append(this.FullQualityPrintPermission).Append("\n");
            sb.Append("  ModifyDocumentPermission: ").Append(this.ModifyDocumentPermission).Append("\n");
            sb.Append("  OwnerPassword: ").Append(this.OwnerPassword).Append("\n");
            sb.Append("  PrintPermission: ").Append(this.PrintPermission).Append("\n");
            sb.Append("  UserPassword: ").Append(this.UserPassword).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
