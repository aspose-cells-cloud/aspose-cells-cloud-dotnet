// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ColorFilter.cs">
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
    /// Color filter.
    /// </summary>
    public class ColorFilter
    {
        /// <summary>
        /// Whether filter by the cell's fill color.
        ///             
        /// </summary>
        public virtual bool? FilterByFillColor { get; set; }

        /// <summary>
        /// A property "Pattern" of type string with a getter and setter is defined.
        /// </summary>
        public virtual string Pattern { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual CellsColor Color { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual CellsColor ForegroundColorColor { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual CellsColor BackgroundColor { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ColorFilter {\n");
            sb.Append("  FilterByFillColor: ").Append(this.FilterByFillColor).Append("\n");
            sb.Append("  Pattern: ").Append(this.Pattern).Append("\n");
            sb.Append("  Color: ").Append(this.Color).Append("\n");
            sb.Append("  ForegroundColorColor: ").Append(this.ForegroundColorColor).Append("\n");
            sb.Append("  BackgroundColor: ").Append(this.BackgroundColor).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
