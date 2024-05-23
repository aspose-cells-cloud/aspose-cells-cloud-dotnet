// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ChartDataTable.cs">
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
    /// Represents a chart data table.
    /// </summary>
    public class ChartDataTable : LinkElement
    {
        /// <summary>
        /// True if the text in the object changes font size when the object size changes. 
        ///                         The default value is True.
        /// </summary>
        public virtual bool? AutoScaleFont { get; set; }

        /// <summary>
        /// Gets and sets the display mode of the background
        /// </summary>
        public virtual string BackgroundMode { get; set; }

        /// <summary>
        /// Returns a Border object that represents the border of the object
        /// </summary>
        public virtual Line Border { get; set; }

        /// <summary>
        /// Gets a  object which represents the font setting of the specified chart data table.
        /// </summary>
        public virtual Font Font { get; set; }

        /// <summary>
        /// True if the chart data table has horizontal cell borders
        /// </summary>
        public virtual bool? HasBorderHorizontal { get; set; }

        /// <summary>
        /// True if the chart data table has outline borders
        /// </summary>
        public virtual bool? HasBorderOutline { get; set; }

        /// <summary>
        /// True if the chart data table has vertical cell borders
        /// </summary>
        public virtual bool? HasBorderVertical { get; set; }

        /// <summary>
        /// True if the data label legend key is visible.
        /// </summary>
        public virtual bool? ShowLegendKey { get; set; }

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
            sb.Append("class ChartDataTable {\n");
            sb.Append("  AutoScaleFont: ").Append(this.AutoScaleFont).Append("\n");
            sb.Append("  BackgroundMode: ").Append(this.BackgroundMode).Append("\n");
            sb.Append("  Border: ").Append(this.Border).Append("\n");
            sb.Append("  Font: ").Append(this.Font).Append("\n");
            sb.Append("  HasBorderHorizontal: ").Append(this.HasBorderHorizontal).Append("\n");
            sb.Append("  HasBorderOutline: ").Append(this.HasBorderOutline).Append("\n");
            sb.Append("  HasBorderVertical: ").Append(this.HasBorderVertical).Append("\n");
            sb.Append("  ShowLegendKey: ").Append(this.ShowLegendKey).Append("\n");
            sb.Append("  link: ").Append(this.link).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
