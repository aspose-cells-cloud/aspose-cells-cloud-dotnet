// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="AggregateResultByColor.cs">
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
    /// AggregateResultByColor.
    /// </summary>
    public class AggregateResultByColor
    {
        /// <summary>
        /// Gets or sets AggregateOperation.
        /// </summary>
        public virtual string AggregateOperation { get; set; }

        /// <summary>
        /// Gets or sets ColorName.
        /// </summary>
        public virtual string ColorName { get; set; }

        /// <summary>
        /// Gets or sets Count.
        /// </summary>
        public virtual int? Count { get; set; }

        /// <summary>
        /// Gets or sets Sum.
        /// </summary>
        public virtual double? Sum { get; set; }

        /// <summary>
        /// Gets or sets MaxValue.
        /// </summary>
        public virtual double? MaxValue { get; set; }

        /// <summary>
        /// Gets or sets MinValue.
        /// </summary>
        public virtual double? MinValue { get; set; }

        /// <summary>
        /// Gets or sets AverageValue.
        /// </summary>
        public virtual double? AverageValue { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AggregateResultByColor {\n");
            sb.Append("  AggregateOperation: ").Append(this.AggregateOperation).Append("\n");
            sb.Append("  ColorName: ").Append(this.ColorName).Append("\n");
            sb.Append("  Count: ").Append(this.Count).Append("\n");
            sb.Append("  Sum: ").Append(this.Sum).Append("\n");
            sb.Append("  MaxValue: ").Append(this.MaxValue).Append("\n");
            sb.Append("  MinValue: ").Append(this.MinValue).Append("\n");
            sb.Append("  AverageValue: ").Append(this.AverageValue).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
