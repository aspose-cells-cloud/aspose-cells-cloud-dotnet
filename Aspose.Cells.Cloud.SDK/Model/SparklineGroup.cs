// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="SparklineGroup.cs">
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
    /// SparklineGroup.
    /// </summary>
    public class SparklineGroup
    {
        /// <summary>
        /// Gets or sets DisplayHidden.
        /// </summary>
        public virtual bool? DisplayHidden { get; set; }

        /// <summary>
        /// Gets or sets FirstPointColor.
        /// </summary>
        public virtual CellsColor FirstPointColor { get; set; }

        /// <summary>
        /// Gets or sets HighPointColor.
        /// </summary>
        public virtual CellsColor HighPointColor { get; set; }

        /// <summary>
        /// Gets or sets HorizontalAxisColor.
        /// </summary>
        public virtual CellsColor HorizontalAxisColor { get; set; }

        /// <summary>
        /// Gets or sets HorizontalAxisDateRange.
        /// </summary>
        public virtual string HorizontalAxisDateRange { get; set; }

        /// <summary>
        /// Gets or sets LastPointColor.
        /// </summary>
        public virtual CellsColor LastPointColor { get; set; }

        /// <summary>
        /// Gets or sets LineWeight.
        /// </summary>
        public virtual double? LineWeight { get; set; }

        /// <summary>
        /// Gets or sets LowPointColor.
        /// </summary>
        public virtual CellsColor LowPointColor { get; set; }

        /// <summary>
        /// Gets or sets MarkersColor.
        /// </summary>
        public virtual CellsColor MarkersColor { get; set; }

        /// <summary>
        /// Gets or sets NegativePointsColor.
        /// </summary>
        public virtual CellsColor NegativePointsColor { get; set; }

        /// <summary>
        /// Gets or sets PlotEmptyCellsType.
        /// </summary>
        public virtual string PlotEmptyCellsType { get; set; }

        /// <summary>
        /// Gets or sets PlotRightToLeft.
        /// </summary>
        public virtual bool? PlotRightToLeft { get; set; }

        /// <summary>
        /// Gets or sets PresetStyle.
        /// </summary>
        public virtual string PresetStyle { get; set; }

        /// <summary>
        /// Gets or sets SeriesColor.
        /// </summary>
        public virtual CellsColor SeriesColor { get; set; }

        /// <summary>
        /// Gets or sets ShowFirstPoint.
        /// </summary>
        public virtual bool? ShowFirstPoint { get; set; }

        /// <summary>
        /// Gets or sets ShowHighPoint.
        /// </summary>
        public virtual bool? ShowHighPoint { get; set; }

        /// <summary>
        /// Gets or sets ShowHorizontalAxis.
        /// </summary>
        public virtual bool? ShowHorizontalAxis { get; set; }

        /// <summary>
        /// Gets or sets ShowLastPoint.
        /// </summary>
        public virtual bool? ShowLastPoint { get; set; }

        /// <summary>
        /// Gets or sets ShowLowPoint.
        /// </summary>
        public virtual bool? ShowLowPoint { get; set; }

        /// <summary>
        /// Gets or sets ShowMarkers.
        /// </summary>
        public virtual bool? ShowMarkers { get; set; }

        /// <summary>
        /// Gets or sets ShowNegativePoints.
        /// </summary>
        public virtual bool? ShowNegativePoints { get; set; }

        /// <summary>
        /// Gets or sets SparklineCollection.
        /// </summary>
        public virtual IList<Sparkline> SparklineCollection { get; set; }

        /// <summary>
        /// Gets or sets Type.
        /// </summary>
        public virtual string Type { get; set; }

        /// <summary>
        /// Gets or sets VerticalAxisMaxValue.
        /// </summary>
        public virtual double? VerticalAxisMaxValue { get; set; }

        /// <summary>
        /// Gets or sets VerticalAxisMaxValueType.
        /// </summary>
        public virtual string VerticalAxisMaxValueType { get; set; }

        /// <summary>
        /// Gets or sets VerticalAxisMinValue.
        /// </summary>
        public virtual double? VerticalAxisMinValue { get; set; }

        /// <summary>
        /// Gets or sets VerticalAxisMinValueType.
        /// </summary>
        public virtual string VerticalAxisMinValueType { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SparklineGroup {\n");
            sb.Append("  DisplayHidden: ").Append(this.DisplayHidden).Append("\n");
            sb.Append("  FirstPointColor: ").Append(this.FirstPointColor).Append("\n");
            sb.Append("  HighPointColor: ").Append(this.HighPointColor).Append("\n");
            sb.Append("  HorizontalAxisColor: ").Append(this.HorizontalAxisColor).Append("\n");
            sb.Append("  HorizontalAxisDateRange: ").Append(this.HorizontalAxisDateRange).Append("\n");
            sb.Append("  LastPointColor: ").Append(this.LastPointColor).Append("\n");
            sb.Append("  LineWeight: ").Append(this.LineWeight).Append("\n");
            sb.Append("  LowPointColor: ").Append(this.LowPointColor).Append("\n");
            sb.Append("  MarkersColor: ").Append(this.MarkersColor).Append("\n");
            sb.Append("  NegativePointsColor: ").Append(this.NegativePointsColor).Append("\n");
            sb.Append("  PlotEmptyCellsType: ").Append(this.PlotEmptyCellsType).Append("\n");
            sb.Append("  PlotRightToLeft: ").Append(this.PlotRightToLeft).Append("\n");
            sb.Append("  PresetStyle: ").Append(this.PresetStyle).Append("\n");
            sb.Append("  SeriesColor: ").Append(this.SeriesColor).Append("\n");
            sb.Append("  ShowFirstPoint: ").Append(this.ShowFirstPoint).Append("\n");
            sb.Append("  ShowHighPoint: ").Append(this.ShowHighPoint).Append("\n");
            sb.Append("  ShowHorizontalAxis: ").Append(this.ShowHorizontalAxis).Append("\n");
            sb.Append("  ShowLastPoint: ").Append(this.ShowLastPoint).Append("\n");
            sb.Append("  ShowLowPoint: ").Append(this.ShowLowPoint).Append("\n");
            sb.Append("  ShowMarkers: ").Append(this.ShowMarkers).Append("\n");
            sb.Append("  ShowNegativePoints: ").Append(this.ShowNegativePoints).Append("\n");
            sb.Append("  SparklineCollection: ").Append(this.SparklineCollection).Append("\n");
            sb.Append("  Type: ").Append(this.Type).Append("\n");
            sb.Append("  VerticalAxisMaxValue: ").Append(this.VerticalAxisMaxValue).Append("\n");
            sb.Append("  VerticalAxisMaxValueType: ").Append(this.VerticalAxisMaxValueType).Append("\n");
            sb.Append("  VerticalAxisMinValue: ").Append(this.VerticalAxisMinValue).Append("\n");
            sb.Append("  VerticalAxisMinValueType: ").Append(this.VerticalAxisMinValueType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
