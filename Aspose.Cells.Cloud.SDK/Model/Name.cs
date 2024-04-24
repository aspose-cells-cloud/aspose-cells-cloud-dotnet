// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="Name.cs">
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
    /// 
    /// </summary>
    public class Name : LinkElement
    {
        /// <summary>
        /// Gets and sets the comment of the name.
        ///                         Only applies for Excel 2007.
        /// </summary>
        public virtual string Comment { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual int? WorksheetIndex { get; set; }

        /// <summary>
        /// Indicates whether this name is referred by other formulas.
        /// </summary>
        public virtual bool? IsReferred { get; set; }

        /// <summary>
        /// Indicates whether the name is visible.
        /// </summary>
        public virtual bool? IsVisible { get; set; }

        /// <summary>
        /// Gets or sets a R1C1 reference of the .
        /// </summary>
        public virtual string R1C1RefersTo { get; set; }

        /// <summary>
        /// Returns or sets the formula that the name is defined to refer to, beginning with an equal sign.
        /// </summary>
        public virtual string RefersTo { get; set; }

        /// <summary>
        /// Gets the name text of the object.
        /// </summary>
        public virtual string Text { get; set; }

        /// <summary>
        /// Gets or sets link.
        /// </summary>
        public override Link link { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Name {\n");
            sb.Append("  Comment: ").Append(this.Comment).Append("\n");
            sb.Append("  WorksheetIndex: ").Append(this.WorksheetIndex).Append("\n");
            sb.Append("  IsReferred: ").Append(this.IsReferred).Append("\n");
            sb.Append("  IsVisible: ").Append(this.IsVisible).Append("\n");
            sb.Append("  R1C1RefersTo: ").Append(this.R1C1RefersTo).Append("\n");
            sb.Append("  RefersTo: ").Append(this.RefersTo).Append("\n");
            sb.Append("  Text: ").Append(this.Text).Append("\n");
            sb.Append("  link: ").Append(this.link).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
