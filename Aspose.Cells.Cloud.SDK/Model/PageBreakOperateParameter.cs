// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PageBreakOperateParameter.cs">
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
    /// Represents page break operate parameter.
    /// </summary>
    public class PageBreakOperateParameter : OperateParameter
    {
        /// <summary>
        /// Represents page break type.
        /// </summary>
        public virtual string PageBreakType { get; set; }

        /// <summary>
        /// Represents page break index.
        /// </summary>
        public virtual int? Index { get; set; }

        /// <summary>
        /// Represents row index of page break.
        /// </summary>
        public virtual int? Row { get; set; }

        /// <summary>
        /// Represents column index of page break.
        /// </summary>
        public virtual int? Column { get; set; }

        /// <summary>
        /// Represents start row index of page break.
        /// </summary>
        public virtual int? StartIndex { get; set; }

        /// <summary>
        /// Represents end row index of page break.
        /// </summary>
        public virtual int? EndIndex { get; set; }

        /// <summary>
        /// Gets or sets OperateType.
        /// </summary>
        public override string OperateType { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PageBreakOperateParameter {\n");
            sb.Append("  PageBreakType: ").Append(this.PageBreakType).Append("\n");
            sb.Append("  Index: ").Append(this.Index).Append("\n");
            sb.Append("  Row: ").Append(this.Row).Append("\n");
            sb.Append("  Column: ").Append(this.Column).Append("\n");
            sb.Append("  StartIndex: ").Append(this.StartIndex).Append("\n");
            sb.Append("  EndIndex: ").Append(this.EndIndex).Append("\n");
            sb.Append("  OperateType: ").Append(this.OperateType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
