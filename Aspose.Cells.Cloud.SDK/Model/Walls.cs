// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="Walls.cs">
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
    /// Encapsulates the object that represents the walls of a 3-D chart.
    /// </summary>
    public class Walls : Floor
    {
        /// <summary>
        /// Gets the x coordinate of the left-bottom corner of Wall center in units of 1/4000 of chart's width after calls Chart.Calculate() method.
        /// </summary>
        public virtual int? CenterX { get; set; }

        /// <summary>
        /// Gets the y coordinate of the left-bottom corner of Wall center in units of 1/4000 of chart's height after calls Chart.Calculate() method.
        /// </summary>
        public virtual int? CenterY { get; set; }

        /// <summary>
        /// Gets the depth front to back in units of 1/4000 of chart's width after calls Chart.Calculate() method.
        /// </summary>
        public virtual int? Depth { get; set; }

        /// <summary>
        /// Gets the height of top to bottom in units of 1/4000 of chart's height after calls Chart.Calculate() method.
        /// </summary>
        public virtual int? Height { get; set; }

        /// <summary>
        /// Gets the width of left to right in units of 1/4000 of chart's width after calls Chart.Calculate() method.
        /// </summary>
        public virtual int? Width { get; set; }

        /// <summary>
        /// Gets or sets Border.
        /// </summary>
        public override Line Border { get; set; }

        /// <summary>
        /// Gets or sets BackgroundColor.
        /// </summary>
        public override Color BackgroundColor { get; set; }

        /// <summary>
        /// Gets or sets FillFormat.
        /// </summary>
        public override FillFormat FillFormat { get; set; }

        /// <summary>
        /// Gets or sets ForegroundColor.
        /// </summary>
        public override Color ForegroundColor { get; set; }

        /// <summary>
        /// Gets or sets Format.
        /// </summary>
        public override string Format { get; set; }

        /// <summary>
        /// Gets or sets InvertIfNegative.
        /// </summary>
        public override bool? InvertIfNegative { get; set; }

        /// <summary>
        /// Gets or sets Transparency.
        /// </summary>
        public override double? Transparency { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Walls {\n");
            sb.Append("  CenterX: ").Append(this.CenterX).Append("\n");
            sb.Append("  CenterY: ").Append(this.CenterY).Append("\n");
            sb.Append("  Depth: ").Append(this.Depth).Append("\n");
            sb.Append("  Height: ").Append(this.Height).Append("\n");
            sb.Append("  Width: ").Append(this.Width).Append("\n");
            sb.Append("  Border: ").Append(this.Border).Append("\n");
            sb.Append("  BackgroundColor: ").Append(this.BackgroundColor).Append("\n");
            sb.Append("  FillFormat: ").Append(this.FillFormat).Append("\n");
            sb.Append("  ForegroundColor: ").Append(this.ForegroundColor).Append("\n");
            sb.Append("  Format: ").Append(this.Format).Append("\n");
            sb.Append("  InvertIfNegative: ").Append(this.InvertIfNegative).Append("\n");
            sb.Append("  Transparency: ").Append(this.Transparency).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
