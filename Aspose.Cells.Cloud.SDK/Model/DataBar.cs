// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="DataBar.cs">
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
    /// DataBar.
    /// </summary>
    public class DataBar
    {
        /// <summary>
        /// Gets or sets AxisColor.
        /// </summary>
        public virtual Color AxisColor { get; set; }

        /// <summary>
        /// Gets or sets AxisPosition.
        /// </summary>
        public virtual string AxisPosition { get; set; }

        /// <summary>
        /// Gets or sets BarBorder.
        /// </summary>
        public virtual DataBarBorder BarBorder { get; set; }

        /// <summary>
        /// Gets or sets BarFillType.
        /// </summary>
        public virtual string BarFillType { get; set; }

        /// <summary>
        /// Gets or sets Color.
        /// </summary>
        public virtual Color Color { get; set; }

        /// <summary>
        /// Gets or sets Direction.
        /// </summary>
        public virtual string Direction { get; set; }

        /// <summary>
        /// Gets or sets MaxCfvo.
        /// </summary>
        public virtual ConditionalFormattingValue MaxCfvo { get; set; }

        /// <summary>
        /// Gets or sets MaxLength.
        /// </summary>
        public virtual int? MaxLength { get; set; }

        /// <summary>
        /// Gets or sets MinCfvo.
        /// </summary>
        public virtual ConditionalFormattingValue MinCfvo { get; set; }

        /// <summary>
        /// Gets or sets MinLength.
        /// </summary>
        public virtual int? MinLength { get; set; }

        /// <summary>
        /// Gets or sets NegativeBarFormat.
        /// </summary>
        public virtual NegativeBarFormat NegativeBarFormat { get; set; }

        /// <summary>
        /// Gets or sets ShowValue.
        /// </summary>
        public virtual bool? ShowValue { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DataBar {\n");
            sb.Append("  AxisColor: ").Append(this.AxisColor).Append("\n");
            sb.Append("  AxisPosition: ").Append(this.AxisPosition).Append("\n");
            sb.Append("  BarBorder: ").Append(this.BarBorder).Append("\n");
            sb.Append("  BarFillType: ").Append(this.BarFillType).Append("\n");
            sb.Append("  Color: ").Append(this.Color).Append("\n");
            sb.Append("  Direction: ").Append(this.Direction).Append("\n");
            sb.Append("  MaxCfvo: ").Append(this.MaxCfvo).Append("\n");
            sb.Append("  MaxLength: ").Append(this.MaxLength).Append("\n");
            sb.Append("  MinCfvo: ").Append(this.MinCfvo).Append("\n");
            sb.Append("  MinLength: ").Append(this.MinLength).Append("\n");
            sb.Append("  NegativeBarFormat: ").Append(this.NegativeBarFormat).Append("\n");
            sb.Append("  ShowValue: ").Append(this.ShowValue).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
