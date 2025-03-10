// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ChartPoint.cs">
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
    /// Represents a single point in a series in a chart.
    /// </summary>
    public class ChartPoint : LinkElement
    {
        /// <summary>
        /// Gets the area.
        /// </summary>
        public virtual Area Area { get; set; }

        /// <summary>
        /// Gets the border.
        /// </summary>
        public virtual Line Border { get; set; }

        /// <summary>
        /// Returns a DataLabels object that represents the data label associated with the point.
        /// </summary>
        public virtual DataLabels DataLabels { get; set; }

        /// <summary>
        /// The distance of an open pie slice from the center of the pie chart is expressed as a percentage of the pie diameter.
        /// </summary>
        public virtual int? Explosion { get; set; }

        /// <summary>
        /// Gets the marker.
        /// </summary>
        public virtual Marker Marker { get; set; }

        /// <summary>
        /// True if the chartpoint has a shadow.
        /// </summary>
        public virtual bool? Shadow { get; set; }

        /// <summary>
        /// Gets or sets the X value of the chart point.
        /// </summary>
        public virtual Object XValue { get; set; }

        /// <summary>
        /// Gets or sets the Y value of the chart point.
        /// </summary>
        public virtual Object YValue { get; set; }

        /// <summary>
        /// Gets or sets a value indicates whether this data points is in the second pie or bar on a pie of pie or bar of pie chart.
        /// </summary>
        public virtual bool? IsInSecondaryPlot { get; set; }

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
            sb.Append("class ChartPoint {\n");
            sb.Append("  Area: ").Append(this.Area).Append("\n");
            sb.Append("  Border: ").Append(this.Border).Append("\n");
            sb.Append("  DataLabels: ").Append(this.DataLabels).Append("\n");
            sb.Append("  Explosion: ").Append(this.Explosion).Append("\n");
            sb.Append("  Marker: ").Append(this.Marker).Append("\n");
            sb.Append("  Shadow: ").Append(this.Shadow).Append("\n");
            sb.Append("  XValue: ").Append(this.XValue).Append("\n");
            sb.Append("  YValue: ").Append(this.YValue).Append("\n");
            sb.Append("  IsInSecondaryPlot: ").Append(this.IsInSecondaryPlot).Append("\n");
            sb.Append("  link: ").Append(this.link).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
