// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="StyleFormatCondition.cs">
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
    /// Represents style format condition.
    /// </summary>
    public class StyleFormatCondition : FormatCondition
    {
        /// <summary>
        /// Gets or sets Priority.
        /// </summary>
        public override int? Priority { get; set; }

        /// <summary>
        /// Gets or sets Type.
        /// </summary>
        public override string Type { get; set; }

        /// <summary>
        /// Gets or sets StopIfTrue.
        /// </summary>
        public override bool? StopIfTrue { get; set; }

        /// <summary>
        /// Gets or sets AboveAverage.
        /// </summary>
        public override AboveAverage AboveAverage { get; set; }

        /// <summary>
        /// Gets or sets ColorScale.
        /// </summary>
        public override ColorScale ColorScale { get; set; }

        /// <summary>
        /// Gets or sets DataBar.
        /// </summary>
        public override DataBar DataBar { get; set; }

        /// <summary>
        /// Gets or sets Formula1.
        /// </summary>
        public override string Formula1 { get; set; }

        /// <summary>
        /// Gets or sets Formula2.
        /// </summary>
        public override string Formula2 { get; set; }

        /// <summary>
        /// Gets or sets IconSet.
        /// </summary>
        public override IconSet IconSet { get; set; }

        /// <summary>
        /// Gets or sets Operator.
        /// </summary>
        public override string Operator { get; set; }

        /// <summary>
        /// Gets or sets Style.
        /// </summary>
        public override Style Style { get; set; }

        /// <summary>
        /// Gets or sets Text.
        /// </summary>
        public override string Text { get; set; }

        /// <summary>
        /// Gets or sets TimePeriod.
        /// </summary>
        public override string TimePeriod { get; set; }

        /// <summary>
        /// Gets or sets Top10.
        /// </summary>
        public override Top10 Top10 { get; set; }

        /// <summary>
        /// Gets or sets link.
        /// </summary>
        public override Link link { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StyleFormatCondition {\n");
            sb.Append("  Priority: ").Append(this.Priority).Append("\n");
            sb.Append("  Type: ").Append(this.Type).Append("\n");
            sb.Append("  StopIfTrue: ").Append(this.StopIfTrue).Append("\n");
            sb.Append("  AboveAverage: ").Append(this.AboveAverage).Append("\n");
            sb.Append("  ColorScale: ").Append(this.ColorScale).Append("\n");
            sb.Append("  DataBar: ").Append(this.DataBar).Append("\n");
            sb.Append("  Formula1: ").Append(this.Formula1).Append("\n");
            sb.Append("  Formula2: ").Append(this.Formula2).Append("\n");
            sb.Append("  IconSet: ").Append(this.IconSet).Append("\n");
            sb.Append("  Operator: ").Append(this.Operator).Append("\n");
            sb.Append("  Style: ").Append(this.Style).Append("\n");
            sb.Append("  Text: ").Append(this.Text).Append("\n");
            sb.Append("  TimePeriod: ").Append(this.TimePeriod).Append("\n");
            sb.Append("  Top10: ").Append(this.Top10).Append("\n");
            sb.Append("  link: ").Append(this.link).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
