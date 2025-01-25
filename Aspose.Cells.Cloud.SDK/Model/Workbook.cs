// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="Workbook.cs">
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
    ///            Represents a root object to create an Excel spreadsheet.
    ///            
    /// </summary>
    public class Workbook
    {
        /// <summary>
        /// Gets and sets the current file name.
        ///  
        /// </summary>
        public virtual string FileName { get; set; }

        /// <summary>
        /// Gets or sets Links.
        /// </summary>
        public virtual IList<Link> Links { get; set; }

        /// <summary>
        /// Gets the  collection in the spreadsheet.
        ///  
        /// </summary>
        public virtual LinkElement Worksheets { get; set; }

        /// <summary>
        /// Gets or sets the default  object of the workbook.
        ///  
        /// </summary>
        public virtual LinkElement DefaultStyle { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual LinkElement DocumentProperties { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual LinkElement Names { get; set; }

        /// <summary>
        /// Represents the workbook settings.
        ///  
        /// </summary>
        public virtual LinkElement Settings { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual string IsWriteProtected { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual string IsProtected { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual string IsEncryption { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual string Password { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Workbook {\n");
            sb.Append("  FileName: ").Append(this.FileName).Append("\n");
            sb.Append("  Links: ").Append(this.Links).Append("\n");
            sb.Append("  Worksheets: ").Append(this.Worksheets).Append("\n");
            sb.Append("  DefaultStyle: ").Append(this.DefaultStyle).Append("\n");
            sb.Append("  DocumentProperties: ").Append(this.DocumentProperties).Append("\n");
            sb.Append("  Names: ").Append(this.Names).Append("\n");
            sb.Append("  Settings: ").Append(this.Settings).Append("\n");
            sb.Append("  IsWriteProtected: ").Append(this.IsWriteProtected).Append("\n");
            sb.Append("  IsProtected: ").Append(this.IsProtected).Append("\n");
            sb.Append("  IsEncryption: ").Append(this.IsEncryption).Append("\n");
            sb.Append("  Password: ").Append(this.Password).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
