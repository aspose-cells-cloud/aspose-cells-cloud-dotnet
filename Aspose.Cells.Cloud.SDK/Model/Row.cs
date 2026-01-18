// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="Row.cs">
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
    /// Represents a single row in a worksheet.
    /// </summary>
    public class Row : LinkElement
    {
        /// <summary>
        /// Gets the group level of the row.
        /// </summary>
        public virtual int? GroupLevel { get; set; }

        /// <summary>
        /// Gets and sets the row height in unit of Points.
        /// </summary>
        public virtual double? Height { get; set; }

        /// <summary>
        /// Gets the index of this row.
        /// </summary>
        public virtual int? Index { get; set; }

        /// <summary>
        /// Indicates whether the row contains any data
        /// </summary>
        public virtual bool? IsBlank { get; set; }

        /// <summary>
        /// Indicates that row height and default font height matches.
        /// </summary>
        public virtual bool? IsHeightMatched { get; set; }

        /// <summary>
        /// Indicates whether the row is hidden.
        /// </summary>
        public virtual bool? IsHidden { get; set; }

        /// <summary>
        /// Represents the style of this row.
        /// </summary>
        public virtual LinkElement Style { get; set; }

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
            sb.Append("class Row {\n");
            sb.Append("  GroupLevel: ").Append(this.GroupLevel).Append("\n");
            sb.Append("  Height: ").Append(this.Height).Append("\n");
            sb.Append("  Index: ").Append(this.Index).Append("\n");
            sb.Append("  IsBlank: ").Append(this.IsBlank).Append("\n");
            sb.Append("  IsHeightMatched: ").Append(this.IsHeightMatched).Append("\n");
            sb.Append("  IsHidden: ").Append(this.IsHidden).Append("\n");
            sb.Append("  Style: ").Append(this.Style).Append("\n");
            sb.Append("  link: ").Append(this.link).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
