// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PlotArea.cs">
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
    /// PlotArea.
    /// </summary>
    public class PlotArea : ChartFrame
    {
        /// <summary>
        /// Gets or sets InnerHeight.
        /// </summary>
        public virtual int? InnerHeight { get; set; }

        /// <summary>
        /// Gets or sets InnerWidth.
        /// </summary>
        public virtual int? InnerWidth { get; set; }

        /// <summary>
        /// Gets or sets InnerX.
        /// </summary>
        public virtual int? InnerX { get; set; }

        /// <summary>
        /// Gets or sets InnerY.
        /// </summary>
        public virtual int? InnerY { get; set; }

        /// <summary>
        /// Gets or sets Area.
        /// </summary>
        public override Area Area { get; set; }

        /// <summary>
        /// Gets or sets AutoScaleFont.
        /// </summary>
        public override bool? AutoScaleFont { get; set; }

        /// <summary>
        /// Gets or sets BackgroundMode.
        /// </summary>
        public override string BackgroundMode { get; set; }

        /// <summary>
        /// Gets or sets Border.
        /// </summary>
        public override Line Border { get; set; }

        /// <summary>
        /// Gets or sets Font.
        /// </summary>
        public override Font Font { get; set; }

        /// <summary>
        /// Gets or sets IsAutomaticSize.
        /// </summary>
        public override bool? IsAutomaticSize { get; set; }

        /// <summary>
        /// Gets or sets IsInnerMode.
        /// </summary>
        public override bool? IsInnerMode { get; set; }

        /// <summary>
        /// Gets or sets Shadow.
        /// </summary>
        public override bool? Shadow { get; set; }

        /// <summary>
        /// Gets or sets ShapeProperties.
        /// </summary>
        public override IList<LinkElement> ShapeProperties { get; set; }

        /// <summary>
        /// Gets or sets Width.
        /// </summary>
        public override int? Width { get; set; }

        /// <summary>
        /// Gets or sets Height.
        /// </summary>
        public override int? Height { get; set; }

        /// <summary>
        /// Gets or sets X.
        /// </summary>
        public override int? X { get; set; }

        /// <summary>
        /// Gets or sets Y.
        /// </summary>
        public override int? Y { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PlotArea {\n");
            sb.Append("  InnerHeight: ").Append(this.InnerHeight).Append("\n");
            sb.Append("  InnerWidth: ").Append(this.InnerWidth).Append("\n");
            sb.Append("  InnerX: ").Append(this.InnerX).Append("\n");
            sb.Append("  InnerY: ").Append(this.InnerY).Append("\n");
            sb.Append("  Area: ").Append(this.Area).Append("\n");
            sb.Append("  AutoScaleFont: ").Append(this.AutoScaleFont).Append("\n");
            sb.Append("  BackgroundMode: ").Append(this.BackgroundMode).Append("\n");
            sb.Append("  Border: ").Append(this.Border).Append("\n");
            sb.Append("  Font: ").Append(this.Font).Append("\n");
            sb.Append("  IsAutomaticSize: ").Append(this.IsAutomaticSize).Append("\n");
            sb.Append("  IsInnerMode: ").Append(this.IsInnerMode).Append("\n");
            sb.Append("  Shadow: ").Append(this.Shadow).Append("\n");
            sb.Append("  ShapeProperties: ").Append(this.ShapeProperties).Append("\n");
            sb.Append("  Width: ").Append(this.Width).Append("\n");
            sb.Append("  Height: ").Append(this.Height).Append("\n");
            sb.Append("  X: ").Append(this.X).Append("\n");
            sb.Append("  Y: ").Append(this.Y).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
