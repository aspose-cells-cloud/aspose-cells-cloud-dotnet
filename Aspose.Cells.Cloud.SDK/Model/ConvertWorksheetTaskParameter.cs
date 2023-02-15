// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ConvertWorksheetTaskParameter.cs">
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
    /// ConvertWorksheetTaskParameter.
    /// </summary>
    public class ConvertWorksheetTaskParameter : TaskParameter
    {
        /// <summary>
        /// Gets or sets Workbook.
        /// </summary>
        public virtual FileSource Workbook { get; set; }

        /// <summary>
        /// Gets or sets Sheet.
        /// </summary>
        public virtual string Sheet { get; set; }

        /// <summary>
        /// Gets or sets Target.
        /// </summary>
        public virtual FileSource Target { get; set; }

        /// <summary>
        /// Gets or sets Format.
        /// </summary>
        public virtual string Format { get; set; }

        /// <summary>
        /// Gets or sets Area.
        /// </summary>
        public virtual string Area { get; set; }

        /// <summary>
        /// Gets or sets PageIndex.
        /// </summary>
        public virtual int? PageIndex { get; set; }

        /// <summary>
        /// Gets or sets VerticalResolution.
        /// </summary>
        public virtual int? VerticalResolution { get; set; }

        /// <summary>
        /// Gets or sets HorizontalResolution.
        /// </summary>
        public virtual int? HorizontalResolution { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConvertWorksheetTaskParameter {\n");
            sb.Append("  Workbook: ").Append(this.Workbook).Append("\n");
            sb.Append("  Sheet: ").Append(this.Sheet).Append("\n");
            sb.Append("  Target: ").Append(this.Target).Append("\n");
            sb.Append("  Format: ").Append(this.Format).Append("\n");
            sb.Append("  Area: ").Append(this.Area).Append("\n");
            sb.Append("  PageIndex: ").Append(this.PageIndex).Append("\n");
            sb.Append("  VerticalResolution: ").Append(this.VerticalResolution).Append("\n");
            sb.Append("  HorizontalResolution: ").Append(this.HorizontalResolution).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
