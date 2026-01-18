// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ProtectWorkbookRequest.cs">
//   Copyright (c) 2026 Aspose.Cells Cloud
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
    /// Indicates protect workbook request
    /// </summary>
    public class ProtectWorkbookRequest
    {
        /// <summary>
        /// Indicates aways open read-only.
        /// </summary>
        public virtual bool? AwaysOpenReadOnly { get; set; }

        /// <summary>
        /// Indicates encrypt with password.
        /// </summary>
        public virtual string EncryptWithPassword { get; set; }

        /// <summary>
        /// Represents the various types of protection options available for a worksheet.
        ///             
        /// </summary>
        public virtual Protection ProtectCurrentSheet { get; set; }

        /// <summary>
        /// Represents the various types of protection options available for all worksheets.
        ///             
        /// </summary>
        public virtual Protection ProtectAllSheets { get; set; }

        /// <summary>
        /// Indicates protect workbook structure. All, Contents, Objects, Scenarios, Structure, Windows, and None.
        /// </summary>
        public virtual string ProtectWorkbookStructure { get; set; }

        /// <summary>
        /// Indicates signature in file.
        /// </summary>
        public virtual DigitalSignature DigitalSignature { get; set; }

        /// <summary>
        /// Indicates mark as final.
        /// </summary>
        public virtual bool? MarkAsFinal { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProtectWorkbookRequest {\n");
            sb.Append("  AwaysOpenReadOnly: ").Append(this.AwaysOpenReadOnly).Append("\n");
            sb.Append("  EncryptWithPassword: ").Append(this.EncryptWithPassword).Append("\n");
            sb.Append("  ProtectCurrentSheet: ").Append(this.ProtectCurrentSheet).Append("\n");
            sb.Append("  ProtectAllSheets: ").Append(this.ProtectAllSheets).Append("\n");
            sb.Append("  ProtectWorkbookStructure: ").Append(this.ProtectWorkbookStructure).Append("\n");
            sb.Append("  DigitalSignature: ").Append(this.DigitalSignature).Append("\n");
            sb.Append("  MarkAsFinal: ").Append(this.MarkAsFinal).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
