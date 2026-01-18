// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="SparklineGroup.cs">
//   Copyright (c) 2026 Aspose.Cells Cloud
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
    ///            is organized into sparkline group. A SparklineGroup contains a variable number of sparkline items.             A sparkline group specifies the type, display settings and axis settings for the sparklines.
    ///            
    /// </summary>
    public class SparklineGroup
    {
        /// <summary>
        /// Indicates whether to show data in hidden rows and columns.
        ///  
        /// </summary>
        public virtual bool? DisplayHidden { get; set; }

        /// <summary>
        /// Gets and sets the color of the first point of data in the sparkline group.
        ///  
        /// </summary>
        public virtual CellsColor FirstPointColor { get; set; }

        /// <summary>
        /// Gets and sets the color of the highest points of data in the sparkline group.
        ///  
        /// </summary>
        public virtual CellsColor HighPointColor { get; set; }

        /// <summary>
        /// Gets and sets the color of the horizontal axis in the sparkline group.
        ///  
        /// </summary>
        public virtual CellsColor HorizontalAxisColor { get; set; }

        /// <summary>
        /// Represents the range that contains the date values for the sparkline data.
        ///  
        /// </summary>
        public virtual string HorizontalAxisDateRange { get; set; }

        /// <summary>
        /// Gets and sets the color of the last point of data in the sparkline group.
        ///  
        /// </summary>
        public virtual CellsColor LastPointColor { get; set; }

        /// <summary>
        /// Gets and sets the line weight in each line sparkline in the sparkline group, in the unit of points.
        ///  
        /// </summary>
        public virtual double? LineWeight { get; set; }

        /// <summary>
        /// Gets and sets the color of the lowest points of data in the sparkline group.
        ///  
        /// </summary>
        public virtual CellsColor LowPointColor { get; set; }

        /// <summary>
        /// Gets and sets the color of points in each line sparkline in the sparkline group.
        ///  
        /// </summary>
        public virtual CellsColor MarkersColor { get; set; }

        /// <summary>
        /// Gets and sets the color of the negative values on the sparkline group.
        ///  
        /// </summary>
        public virtual CellsColor NegativePointsColor { get; set; }

        /// <summary>
        /// Indicates how to plot empty cells.
        ///  
        /// </summary>
        public virtual string PlotEmptyCellsType { get; set; }

        /// <summary>
        /// Indicates whether the plot data is right to left.
        ///  
        /// </summary>
        public virtual bool? PlotRightToLeft { get; set; }

        /// <summary>
        /// Gets and sets the preset style type of the sparkline group.
        ///  
        /// </summary>
        public virtual string PresetStyle { get; set; }

        /// <summary>
        /// Gets and sets the color of the sparklines in the sparkline group.
        ///  
        /// </summary>
        public virtual CellsColor SeriesColor { get; set; }

        /// <summary>
        /// Indicates whether to highlight the first point of data in the sparkline group.
        ///  
        /// </summary>
        public virtual bool? ShowFirstPoint { get; set; }

        /// <summary>
        /// Indicates whether to highlight the highest points of data in the sparkline group.
        ///  
        /// </summary>
        public virtual bool? ShowHighPoint { get; set; }

        /// <summary>
        /// Indicates whether to show the sparkline horizontal axis.
        ///             The horizontal axis appears if the sparkline has data that crosses the zero axis.
        ///  
        /// </summary>
        public virtual bool? ShowHorizontalAxis { get; set; }

        /// <summary>
        /// Indicates whether to highlight the last point of data in the sparkline group.
        ///  
        /// </summary>
        public virtual bool? ShowLastPoint { get; set; }

        /// <summary>
        /// Indicates whether to highlight the lowest points of data in the sparkline group.
        ///  
        /// </summary>
        public virtual bool? ShowLowPoint { get; set; }

        /// <summary>
        /// Indicates whether to highlight each point in each line sparkline in the sparkline group.
        ///  
        /// </summary>
        public virtual bool? ShowMarkers { get; set; }

        /// <summary>
        /// Indicates whether to highlight the negative values on the sparkline group with a different color or marker.
        ///  
        /// </summary>
        public virtual bool? ShowNegativePoints { get; set; }

        /// <summary>
        /// Gets the collection of  object.
        ///  
        /// </summary>
        public virtual IList<Sparkline> SparklineCollection { get; set; }

        /// <summary>
        /// Indicates the sparkline type of the sparkline group.
        ///  
        /// </summary>
        public virtual string Type { get; set; }

        /// <summary>
        /// Gets and sets the custom maximum value for the vertical axis.
        ///  
        /// </summary>
        public virtual double? VerticalAxisMaxValue { get; set; }

        /// <summary>
        /// Represents the vertical axis maximum value type.
        ///  
        /// </summary>
        public virtual string VerticalAxisMaxValueType { get; set; }

        /// <summary>
        /// Gets and sets the custom minimum value for the vertical axis.
        ///  
        /// </summary>
        public virtual double? VerticalAxisMinValue { get; set; }

        /// <summary>
        /// Represents the vertical axis minimum value type.
        ///  
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
