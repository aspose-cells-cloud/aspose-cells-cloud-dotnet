// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="AboveAverage.cs">
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
    /// Describe the AboveAverage conditional formatting rule. This conditional formatting
    ///     rule highlights cells that are above or below the average for all values
    ///     in the range.
    /// </summary>
    public class AboveAverage
    {
        /// <summary>
        /// Get or set the flag indicating whether the rule is an "above average" rule.
        ///    'true' indicates 'above average'.  Default value is true.
        ///             
        /// </summary>
        public virtual bool? IsAboveAverage { get; set; }

        /// <summary>
        /// Get or set the flag indicating whether the 'aboveAverage' and 'belowAverage'
        ///    criteria is inclusive of the average itself, or exclusive of that value.
        ///    'true' indicates to include the average value in the criteria.  Default value
        ///    is false.
        ///             
        /// </summary>
        public virtual bool? IsEqualAverage { get; set; }

        /// <summary>
        /// Get or set the number of standard deviations to include above or below the
        ///   average in the conditional formatting rule. The input value must between
        ///   0 and 3 (include 0 and 3). Setting this value to 0 means stdDev is not set.
        ///    The default value is 0.
        ///             
        /// </summary>
        public virtual int? StdDev { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AboveAverage {\n");
            sb.Append("  IsAboveAverage: ").Append(this.IsAboveAverage).Append("\n");
            sb.Append("  IsEqualAverage: ").Append(this.IsEqualAverage).Append("\n");
            sb.Append("  StdDev: ").Append(this.StdDev).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
