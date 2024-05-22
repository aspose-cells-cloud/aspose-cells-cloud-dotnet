// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ChartFrame.cs">
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
    public class ChartFrame
    {
        /// <summary>
        /// Gets the area.
        ///  
        /// </summary>
        public virtual Area Area { get; set; }

        /// <summary>
        /// True if the text in the object changes font size when the object size changes. The default value is True.
        ///  
        /// </summary>
        public virtual bool? AutoScaleFont { get; set; }

        /// <summary>
        /// Gets and sets the display mode of the background
        ///  
        /// </summary>
        public virtual string BackgroundMode { get; set; }

        /// <summary>
        /// Gets the border.
        ///  
        /// </summary>
        public virtual Line Border { get; set; }

        /// <summary>
        /// Gets a  object of the specified ChartFrame object.
        ///  
        /// </summary>
        public virtual Font Font { get; set; }

        /// <summary>
        /// Indicates whether the chart frame is automatic sized.
        ///  
        /// </summary>
        public virtual bool? IsAutomaticSize { get; set; }

        /// <summary>
        /// Indicates whether the size of the plot area size includes the tick marks, and the axis labels.
        ///             False specifies that the size shall determine the size of the plot area, the tick marks, and the axis labels.
        ///  
        /// </summary>
        public virtual bool? IsInnerMode { get; set; }

        /// <summary>
        /// True if the frame has a shadow.
        ///  
        /// </summary>
        public virtual bool? Shadow { get; set; }

        /// <summary>
        /// Gets the  object.
        ///  
        /// </summary>
        public virtual IList<LinkElement> ShapeProperties { get; set; }

        /// <summary>
        /// Gets or sets the width of frame in units of 1/4000 of the chart area.
        ///  
        /// </summary>
        public virtual int? Width { get; set; }

        /// <summary>
        /// Gets or sets the height of frame in units of 1/4000 of the chart area.
        ///  
        /// </summary>
        public virtual int? Height { get; set; }

        /// <summary>
        /// Gets or sets the x coordinate of the upper left corner in units of 1/4000 of the chart area.
        ///  
        /// </summary>
        public virtual int? X { get; set; }

        /// <summary>
        /// Gets or sets the y coordinate of the upper left corner in units of 1/4000 of the chart area.
        ///  
        /// </summary>
        public virtual int? Y { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChartFrame {\n");
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
