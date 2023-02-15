// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ChartFrame.cs">
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
    /// ChartFrame.
    /// </summary>
    public class ChartFrame
    {
        /// <summary>
        /// Gets or sets Area.
        /// </summary>
        public virtual Area Area { get; set; }

        /// <summary>
        /// Gets or sets AutoScaleFont.
        /// </summary>
        public virtual bool? AutoScaleFont { get; set; }

        /// <summary>
        /// Gets or sets BackgroundMode.
        /// </summary>
        public virtual string BackgroundMode { get; set; }

        /// <summary>
        /// Gets or sets Border.
        /// </summary>
        public virtual Line Border { get; set; }

        /// <summary>
        /// Gets or sets Font.
        /// </summary>
        public virtual Font Font { get; set; }

        /// <summary>
        /// Gets or sets IsAutomaticSize.
        /// </summary>
        public virtual bool? IsAutomaticSize { get; set; }

        /// <summary>
        /// Gets or sets IsInnerMode.
        /// </summary>
        public virtual bool? IsInnerMode { get; set; }

        /// <summary>
        /// Gets or sets Shadow.
        /// </summary>
        public virtual bool? Shadow { get; set; }

        /// <summary>
        /// Gets or sets ShapeProperties.
        /// </summary>
        public virtual IList<LinkElement> ShapeProperties { get; set; }

        /// <summary>
        /// Gets or sets Width.
        /// </summary>
        public virtual int? Width { get; set; }

        /// <summary>
        /// Gets or sets Height.
        /// </summary>
        public virtual int? Height { get; set; }

        /// <summary>
        /// Gets or sets X.
        /// </summary>
        public virtual int? X { get; set; }

        /// <summary>
        /// Gets or sets Y.
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
