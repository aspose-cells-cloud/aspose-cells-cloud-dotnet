// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="FillFormat.cs">
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
    /// FillFormat.
    /// </summary>
    public class FillFormat
    {
        /// <summary>
        /// Gets or sets Type.
        /// </summary>
        public virtual string Type { get; set; }

        /// <summary>
        /// Gets or sets SolidFill.
        /// </summary>
        public virtual SolidFill SolidFill { get; set; }

        /// <summary>
        /// Gets or sets PatternFill.
        /// </summary>
        public virtual PatternFill PatternFill { get; set; }

        /// <summary>
        /// Gets or sets TextureFill.
        /// </summary>
        public virtual TextureFill TextureFill { get; set; }

        /// <summary>
        /// Gets or sets GradientFill.
        /// </summary>
        public virtual GradientFill GradientFill { get; set; }

        /// <summary>
        /// Gets or sets ImageData.
        /// </summary>
        public virtual string ImageData { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FillFormat {\n");
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
