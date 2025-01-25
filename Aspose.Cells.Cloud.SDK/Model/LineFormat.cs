// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="LineFormat.cs">
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
    /// Represents all setting of the line.
    /// </summary>
    public class LineFormat : FillFormat
    {
        /// <summary>
        /// Gets and sets the begin arrow length type of the line.
        /// </summary>
        public virtual string BeginArrowheadLength { get; set; }

        /// <summary>
        /// Gets and sets the begin arrow type of the line.
        /// </summary>
        public virtual string BeginArrowheadStyle { get; set; }

        /// <summary>
        /// Gets and sets the begin arrow width type of the line.
        /// </summary>
        public virtual string BeginArrowheadWidth { get; set; }

        /// <summary>
        /// Specifies the ending caps.
        /// </summary>
        public virtual string CapType { get; set; }

        /// <summary>
        /// Specifies the line compound type.
        /// </summary>
        public virtual string CompoundType { get; set; }

        /// <summary>
        /// Specifies the line dash type.
        /// </summary>
        public virtual string DashStyle { get; set; }

        /// <summary>
        /// Gets and sets the end arrow length type of the line.
        /// </summary>
        public virtual string EndArrowheadLength { get; set; }

        /// <summary>
        /// Gets and sets the end arrow type of the line.
        /// </summary>
        public virtual string EndArrowheadStyle { get; set; }

        /// <summary>
        /// Gets and sets the end arrow width type of the line.
        /// </summary>
        public virtual string EndArrowheadWidth { get; set; }

        /// <summary>
        /// Specifies the line join type.
        /// </summary>
        public virtual string JoinType { get; set; }

        /// <summary>
        /// Gets or sets the weight of the line in unit of points.
        /// </summary>
        public virtual double? Weight { get; set; }

        /// <summary>
        /// Gets or sets Type.
        /// </summary>
        public override string Type { get; set; }

        /// <summary>
        /// Gets or sets SolidFill.
        /// </summary>
        public override SolidFill SolidFill { get; set; }

        /// <summary>
        /// Gets or sets PatternFill.
        /// </summary>
        public override PatternFill PatternFill { get; set; }

        /// <summary>
        /// Gets or sets TextureFill.
        /// </summary>
        public override TextureFill TextureFill { get; set; }

        /// <summary>
        /// Gets or sets GradientFill.
        /// </summary>
        public override GradientFill GradientFill { get; set; }

        /// <summary>
        /// Gets or sets ImageData.
        /// </summary>
        public override string ImageData { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LineFormat {\n");
            sb.Append("  BeginArrowheadLength: ").Append(this.BeginArrowheadLength).Append("\n");
            sb.Append("  BeginArrowheadStyle: ").Append(this.BeginArrowheadStyle).Append("\n");
            sb.Append("  BeginArrowheadWidth: ").Append(this.BeginArrowheadWidth).Append("\n");
            sb.Append("  CapType: ").Append(this.CapType).Append("\n");
            sb.Append("  CompoundType: ").Append(this.CompoundType).Append("\n");
            sb.Append("  DashStyle: ").Append(this.DashStyle).Append("\n");
            sb.Append("  EndArrowheadLength: ").Append(this.EndArrowheadLength).Append("\n");
            sb.Append("  EndArrowheadStyle: ").Append(this.EndArrowheadStyle).Append("\n");
            sb.Append("  EndArrowheadWidth: ").Append(this.EndArrowheadWidth).Append("\n");
            sb.Append("  JoinType: ").Append(this.JoinType).Append("\n");
            sb.Append("  Weight: ").Append(this.Weight).Append("\n");
            sb.Append("  Type: ").Append(this.Type).Append("\n");
            sb.Append("  SolidFill: ").Append(this.SolidFill).Append("\n");
            sb.Append("  PatternFill: ").Append(this.PatternFill).Append("\n");
            sb.Append("  TextureFill: ").Append(this.TextureFill).Append("\n");
            sb.Append("  GradientFill: ").Append(this.GradientFill).Append("\n");
            sb.Append("  ImageData: ").Append(this.ImageData).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
