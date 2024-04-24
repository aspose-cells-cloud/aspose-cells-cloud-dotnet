// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="GradientFill.cs">
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
    public class GradientFill
    {
        /// <summary>
        /// Gets the gradient fill type.
        ///  
        /// </summary>
        public virtual string FillType { get; set; }

        /// <summary>
        /// Gets the gradient direction type.
        ///  
        /// </summary>
        public virtual string DirectionType { get; set; }

        /// <summary>
        /// The angle of linear fill.
        ///  
        /// </summary>
        public virtual double? Angle { get; set; }

        /// <summary>
        /// Represents the gradient stop collection.
        ///  
        /// </summary>
        public virtual IList<GradientFillStop> GradientStops { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GradientFill {\n");
            sb.Append("  FillType: ").Append(this.FillType).Append("\n");
            sb.Append("  DirectionType: ").Append(this.DirectionType).Append("\n");
            sb.Append("  Angle: ").Append(this.Angle).Append("\n");
            sb.Append("  GradientStops: ").Append(this.GradientStops).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
