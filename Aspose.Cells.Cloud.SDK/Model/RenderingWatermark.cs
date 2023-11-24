// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="RenderingWatermark.cs">
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
    /// 
    /// </summary>
    public class RenderingWatermark
    {
        /// <summary>
        /// 
        /// </summary>
        public virtual double? Rotation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual int? ScaleToPagePercent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual double? Opacity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual bool? IsBackground { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual string Text { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual RenderingFont Font { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual byte[] Image { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual string HAlignment { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual string VAlignment { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual double? OffsetX { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual double? OffsetY { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RenderingWatermark {\n");
            sb.Append("  Rotation: ").Append(this.Rotation).Append("\n");
            sb.Append("  ScaleToPagePercent: ").Append(this.ScaleToPagePercent).Append("\n");
            sb.Append("  Opacity: ").Append(this.Opacity).Append("\n");
            sb.Append("  IsBackground: ").Append(this.IsBackground).Append("\n");
            sb.Append("  Text: ").Append(this.Text).Append("\n");
            sb.Append("  Font: ").Append(this.Font).Append("\n");
            sb.Append("  Image: ").Append(this.Image).Append("\n");
            sb.Append("  HAlignment: ").Append(this.HAlignment).Append("\n");
            sb.Append("  VAlignment: ").Append(this.VAlignment).Append("\n");
            sb.Append("  OffsetX: ").Append(this.OffsetX).Append("\n");
            sb.Append("  OffsetY: ").Append(this.OffsetY).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
