// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ColorScale.cs">
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
    /// Describe the ColorScale conditional formatting rule. This conditional formatting
    ///    rule creates a gradated color scale on the cells.
    ///             
    /// </summary>
    public class ColorScale
    {
        /// <summary>
        /// Get or set this ColorScale's max value object.
        ///             Cannot set null or CFValueObject with type FormatConditionValueType.Min to it.
        ///  
        /// </summary>
        public virtual ConditionalFormattingValue MaxCfvo { get; set; }

        /// <summary>
        /// Get or set the gradient color for the maximum value in the range.
        ///  
        /// </summary>
        public virtual Color MaxColor { get; set; }

        /// <summary>
        /// Get or set this ColorScale's mid value object.
        ///             Cannot set CFValueObject with type FormatConditionValueType.Max or FormatConditionValueType.Min to it.
        ///  
        /// </summary>
        public virtual ConditionalFormattingValue MidCfvo { get; set; }

        /// <summary>
        /// Get or set the gradient color for the middle value in the range.
        ///  
        /// </summary>
        public virtual Color MidColor { get; set; }

        /// <summary>
        /// Get or set this ColorScale's min value object.
        ///             Cannot set null or CFValueObject with type FormatConditionValueType.Max to it.
        ///  
        /// </summary>
        public virtual ConditionalFormattingValue MinCfvo { get; set; }

        /// <summary>
        /// Get or set the gradient color for the minimum value in the range.
        ///  
        /// </summary>
        public virtual Color MinColor { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ColorScale {\n");
            sb.Append("  MaxCfvo: ").Append(this.MaxCfvo).Append("\n");
            sb.Append("  MaxColor: ").Append(this.MaxColor).Append("\n");
            sb.Append("  MidCfvo: ").Append(this.MidCfvo).Append("\n");
            sb.Append("  MidColor: ").Append(this.MidColor).Append("\n");
            sb.Append("  MinCfvo: ").Append(this.MinCfvo).Append("\n");
            sb.Append("  MinColor: ").Append(this.MinColor).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
