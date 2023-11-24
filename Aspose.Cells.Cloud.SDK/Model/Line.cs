// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="Line.cs">
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
    /// Encapsulates the object that represents the line format.
    /// </summary>
    public class Line
    {
        /// <summary>
        /// Specifies the length of the arrowhead for the begin of a line.
        ///  
        /// </summary>
        public virtual string BeginArrowLength { get; set; }

        /// <summary>
        /// Specifies the width of the arrowhead for the begin of a line.
        ///  
        /// </summary>
        public virtual string BeginArrowWidth { get; set; }

        /// <summary>
        /// Specifies an arrowhead for the begin of a line.
        ///  
        /// </summary>
        public virtual string BeginType { get; set; }

        /// <summary>
        /// Specifies the ending caps.
        ///  
        /// </summary>
        public virtual string CapType { get; set; }

        /// <summary>
        /// Represents the  of the line.
        ///  
        /// </summary>
        public virtual Color Color { get; set; }

        /// <summary>
        /// Specifies the compound line type
        ///  
        /// </summary>
        public virtual string CompoundType { get; set; }

        /// <summary>
        /// Specifies the dash line type
        ///  
        /// </summary>
        public virtual string DashType { get; set; }

        /// <summary>
        /// Specifies the length of the arrowhead for the end of a line.
        ///  
        /// </summary>
        public virtual string EndArrowLength { get; set; }

        /// <summary>
        /// Specifies the width of the arrowhead for the end of a line.
        ///  
        /// </summary>
        public virtual string EndArrowWidth { get; set; }

        /// <summary>
        /// Specifies an arrowhead for the end of a line.
        ///  
        /// </summary>
        public virtual string EndType { get; set; }

        /// <summary>
        /// Represents gradient fill.
        ///  
        /// </summary>
        public virtual GradientFill GradientFill { get; set; }

        /// <summary>
        /// Indicates whether this line style is auto assigned.
        ///  
        /// </summary>
        public virtual bool? IsAuto { get; set; }

        /// <summary>
        /// Indicates whether the color of line is automatic assigned.
        ///  
        /// </summary>
        public virtual bool? IsAutomaticColor { get; set; }

        /// <summary>
        /// Represents whether the line is visible.
        ///  
        /// </summary>
        public virtual bool? IsVisible { get; set; }

        /// <summary>
        /// Specifies the joining caps.
        ///  
        /// </summary>
        public virtual string JoinType { get; set; }

        /// <summary>
        /// Represents the style of the line.
        ///  
        /// </summary>
        public virtual string Style { get; set; }

        /// <summary>
        /// Returns or sets the degree of transparency of the line as a value from 0.0 (opaque) through 1.0 (clear).
        ///  
        /// </summary>
        public virtual double? Transparency { get; set; }

        /// <summary>
        /// Gets or sets the  of the line.
        ///  
        /// </summary>
        public virtual string Weight { get; set; }

        /// <summary>
        /// Gets or sets the weight of the line in unit of points.
        ///  
        /// </summary>
        public virtual double? WeightPt { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Line {\n");
            sb.Append("  BeginArrowLength: ").Append(this.BeginArrowLength).Append("\n");
            sb.Append("  BeginArrowWidth: ").Append(this.BeginArrowWidth).Append("\n");
            sb.Append("  BeginType: ").Append(this.BeginType).Append("\n");
            sb.Append("  CapType: ").Append(this.CapType).Append("\n");
            sb.Append("  Color: ").Append(this.Color).Append("\n");
            sb.Append("  CompoundType: ").Append(this.CompoundType).Append("\n");
            sb.Append("  DashType: ").Append(this.DashType).Append("\n");
            sb.Append("  EndArrowLength: ").Append(this.EndArrowLength).Append("\n");
            sb.Append("  EndArrowWidth: ").Append(this.EndArrowWidth).Append("\n");
            sb.Append("  EndType: ").Append(this.EndType).Append("\n");
            sb.Append("  GradientFill: ").Append(this.GradientFill).Append("\n");
            sb.Append("  IsAuto: ").Append(this.IsAuto).Append("\n");
            sb.Append("  IsAutomaticColor: ").Append(this.IsAutomaticColor).Append("\n");
            sb.Append("  IsVisible: ").Append(this.IsVisible).Append("\n");
            sb.Append("  JoinType: ").Append(this.JoinType).Append("\n");
            sb.Append("  Style: ").Append(this.Style).Append("\n");
            sb.Append("  Transparency: ").Append(this.Transparency).Append("\n");
            sb.Append("  Weight: ").Append(this.Weight).Append("\n");
            sb.Append("  WeightPt: ").Append(this.WeightPt).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
