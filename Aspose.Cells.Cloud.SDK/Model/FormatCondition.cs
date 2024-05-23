// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="FormatCondition.cs">
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
    /// Represents conditional formatting condition.
    /// </summary>
    public class FormatCondition : LinkElement
    {
        /// <summary>
        /// The priority of this conditional formatting rule. This value is used to determine which
        ///                         format should be evaluated and rendered. Lower numeric values are higher priority than
        ///                         higher numeric values, where '1' is the highest priority.
        /// </summary>
        public virtual int? Priority { get; set; }

        /// <summary>
        /// Gets and sets whether the conditional format Type.
        /// </summary>
        public virtual string Type { get; set; }

        /// <summary>
        /// True, no rules with lower priority may be applied over this rule, when this rule evaluates to true.
        ///                         Only applies for Excel 2007;
        /// </summary>
        public virtual bool? StopIfTrue { get; set; }

        /// <summary>
        /// Get the conditional formatting's "AboveAverage" instance.
        ///                         The default instance's rule highlights cells that are 
        ///                         above the average for all values in the range.
        ///                         Valid only for type = AboveAverage.
        /// </summary>
        public virtual AboveAverage AboveAverage { get; set; }

        /// <summary>
        /// Get the conditional formatting's "ColorScale" instance.
        ///                         The default instance is a "green-yellow-red" 3ColorScale .
        ///                         Valid only for type = ColorScale.
        /// </summary>
        public virtual ColorScale ColorScale { get; set; }

        /// <summary>
        /// Get the conditional formatting's "DataBar" instance.
        ///                         The default instance's color is blue.
        ///                         Valid only for type is DataBar.
        /// </summary>
        public virtual DataBar DataBar { get; set; }

        /// <summary>
        /// Gets and sets the value or expression associated with conditional formatting.
        /// </summary>
        public virtual string Formula1 { get; set; }

        /// <summary>
        /// Gets and sets the value or expression associated with conditional formatting.
        /// </summary>
        public virtual string Formula2 { get; set; }

        /// <summary>
        /// Get the conditional formatting's "IconSet" instance.
        ///                         The default instance's IconSetType is TrafficLights31.
        ///                         Valid only for type = IconSet.
        /// </summary>
        public virtual IconSet IconSet { get; set; }

        /// <summary>
        /// Gets and sets the conditional format operator type.
        /// </summary>
        public virtual string Operator { get; set; }

        /// <summary>
        /// Gets or setts style of conditional formatted cell ranges.
        /// </summary>
        public virtual Style Style { get; set; }

        /// <summary>
        /// The text value in a "text contains" conditional formatting rule. 
        ///                         Valid only for type = containsText, notContainsText, beginsWith and endsWith.
        ///                         The default value is null.
        /// </summary>
        public virtual string Text { get; set; }

        /// <summary>
        /// The applicable time period in a "date occurring…" conditional formatting rule. 
        ///                         Valid only for type = timePeriod.
        ///                         The default value is TimePeriodType.Today.
        /// </summary>
        public virtual string TimePeriod { get; set; }

        /// <summary>
        /// Get the conditional formatting's "Top10" instance.
        ///                         The default instance's rule highlights cells whose
        ///                         values fall in the top 10 bracket.
        ///                         Valid only for type is Top10.
        /// </summary>
        public virtual Top10 Top10 { get; set; }

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
            sb.Append("class FormatCondition {\n");
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
