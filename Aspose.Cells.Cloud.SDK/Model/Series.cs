// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="Series.cs">
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
    /// Encapsulates the object that represents a single data series in a chart.
    /// </summary>
    public class Series : LinkElement
    {
        /// <summary>
        /// Represents the background area of Series object.
        /// </summary>
        public virtual Area Area { get; set; }

        /// <summary>
        /// Gets or sets the 3D shape type used with the 3-D bar or column chart.
        /// </summary>
        public virtual string Bar3DShapeType { get; set; }

        /// <summary>
        /// Represents border of Series object.
        /// </summary>
        public virtual Line Border { get; set; }

        /// <summary>
        /// Gets or sets the scale factor for bubbles in the specified chart group. 
        ///                         It can be an integer value from 0 (zero) to 300, 
        ///                         corresponding to a percentage of the default size.
        ///                         Applies only to bubble charts.
        /// </summary>
        public virtual int? BubbleScale { get; set; }

        /// <summary>
        /// Gets or sets the bubble sizes values of the chart series.
        /// </summary>
        public virtual string BubbleSizes { get; set; }

        /// <summary>
        /// Gets the number of the data values.
        /// </summary>
        public virtual int? CountOfDataValues { get; set; }

        /// <summary>
        /// Represents the DataLabels object for the specified ASeries.
        /// </summary>
        public virtual DataLabels DataLabels { get; set; }

        /// <summary>
        /// Gets the series's name that displays on the chart graph.
        /// </summary>
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Returns or sets the size of the hole in a doughnut chart group. 
        ///                         The hole size is expressed as a percentage of the chart size, between 10 and 90 percent.
        /// </summary>
        public virtual int? DoughnutHoleSize { get; set; }

        /// <summary>
        /// Returns a  object that represents the down bars on a line chart.
        ///                         Applies only to line charts.
        /// </summary>
        public virtual DropBars DownBars { get; set; }

        /// <summary>
        /// Returns a  object that represents the drop lines for a series on the line chart or area chart.
        ///                         Applies only to line chart or area charts.
        /// </summary>
        public virtual Line DropLines { get; set; }

        /// <summary>
        /// The distance of an open pie slice from the center of the pie chart is expressed as a percentage of the pie diameter.
        /// </summary>
        public virtual int? Explosion { get; set; }

        /// <summary>
        /// Gets or sets the angle of the first pie-chart or doughnut-chart slice, in degrees (clockwise from vertical). 
        ///                         Applies only to pie, 3-D pie, and doughnut charts, 0 to 360.
        /// </summary>
        public virtual int? FirstSliceAngle { get; set; }

        /// <summary>
        /// Returns or sets the space between bar or column clusters, as a percentage of the bar or column width.
        ///                         The value of this property must be between 0 and 500.
        /// </summary>
        public virtual int? GapWidth { get; set; }

        /// <summary>
        /// True if the series has a three-dimensional appearance. 
        ///                         Applies only to bubble charts.
        /// </summary>
        public virtual bool? Has3DEffect { get; set; }

        /// <summary>
        /// True if the chart has drop lines.
        ///                         Applies only to line chart or area charts.
        /// </summary>
        public virtual bool? HasDropLines { get; set; }

        /// <summary>
        /// True if the line chart has high-low lines. 
        ///                          Applies only to line charts.
        /// </summary>
        public virtual bool? HasHiLoLines { get; set; }

        /// <summary>
        /// True if the series has leader lines.
        /// </summary>
        public virtual bool? HasLeaderLines { get; set; }

        /// <summary>
        /// True if a radar chart has category axis labels. Applies only to radar charts.
        /// </summary>
        public virtual bool? HasRadarAxisLabels { get; set; }

        /// <summary>
        /// True if a stacked column chart or bar chart has series lines or
        ///                         if a Pie of Pie chart or Bar of Pie chart has connector lines between the two sections. 
        ///                         Applies only to stacked column charts, bar charts, Pie of Pie charts, or Bar of Pie charts.
        /// </summary>
        public virtual bool? HasSeriesLines { get; set; }

        /// <summary>
        /// True if a line chart has up and down bars.
        ///                         Applies only to line charts.
        /// </summary>
        public virtual bool? HasUpDownBars { get; set; }

        /// <summary>
        /// Returns a HiLoLines object that represents the high-low lines for a series on a line chart. 
        ///                         Applies only to line charts.
        /// </summary>
        public virtual Line HiLoLines { get; set; }

        /// <summary>
        /// Indicates whether the threshold value is automatic.
        /// </summary>
        public virtual bool? IsAutoSplit { get; set; }

        /// <summary>
        /// Represents if the color of points is varied. 
        ///                         The chart must contain only one series.
        /// </summary>
        public virtual bool? IsColorVaried { get; set; }

        /// <summary>
        /// Represents leader lines on a chart. Leader lines connect data labels to data points. 
        ///                         This object isn’t a collection; there’s no object that represents a single leader line.
        /// </summary>
        public virtual Line LeaderLines { get; set; }

        /// <summary>
        /// Gets the legend entry according to this series.
        /// </summary>
        public virtual LegendEntry LegendEntry { get; set; }

        /// <summary>
        /// Gets the marker.
        /// </summary>
        public virtual Marker Marker { get; set; }

        /// <summary>
        /// Gets or sets the name of the data series.
        /// </summary>
        public virtual string Name { get; set; }

        /// <summary>
        /// Specifies how bars and columns are positioned.
        ///                         Can be a value between – 100 and 100. 
        ///                         Applies only to 2-D bar and 2-D column charts.
        /// </summary>
        public virtual int? Overlap { get; set; }

        /// <summary>
        /// Indicates if this series is plotted on second value axis.
        /// </summary>
        public virtual bool? PlotOnSecondAxis { get; set; }

        /// <summary>
        /// Gets the collection of points in a series in a chart.
        /// </summary>
        public virtual LinkElement Points { get; set; }

        /// <summary>
        /// Returns or sets the size of the secondary section of either a pie of pie chart or a bar of pie chart, 
        ///                         as a percentage of the size of the primary pie.
        ///                         Can be a value from 5 to 200.
        /// </summary>
        public virtual int? SecondPlotSize { get; set; }

        /// <summary>
        /// Returns a SeriesLines object that represents the series lines for a stacked bar chart or a stacked column chart.
        ///                         Applies only to stacked bar and stacked column charts.
        /// </summary>
        public virtual Line SeriesLines { get; set; }

        /// <summary>
        /// True if the series has a shadow.
        /// </summary>
        public virtual bool? Shadow { get; set; }

        /// <summary>
        /// True if negative bubbles are shown for the chart group. Valid only for bubble charts.
        /// </summary>
        public virtual bool? ShowNegativeBubbles { get; set; }

        /// <summary>
        /// Gets or sets what the bubble size represents on a bubble chart.
        /// </summary>
        public virtual string SizeRepresents { get; set; }

        /// <summary>
        /// Represents curve smoothing. 
        ///                         True if curve smoothing is turned on for the line chart or scatter chart.
        ///                         Applies only to line and scatter connected by lines charts.
        /// </summary>
        public virtual bool? Smooth { get; set; }

        /// <summary>
        /// Returns or sets a value that how to determine which data points are in the second pie or bar on a pie of pie or bar of
        ///                         pie chart.
        /// </summary>
        public virtual string SplitType { get; set; }

        /// <summary>
        /// Returns or sets a value that shall be used to determine which data points are in the second pie or bar on
        ///                         a pie of pie or bar of pie chart.
        /// </summary>
        public virtual double? SplitValue { get; set; }

        /// <summary>
        /// Returns an object that represents a collection of all the trendlines for the series.
        /// </summary>
        public virtual Trendlines TrendLines { get; set; }

        /// <summary>
        /// Gets or sets a data series' type.
        /// </summary>
        public virtual string Type { get; set; }

        /// <summary>
        /// Returns an DropBars object that represents the up bars on a line chart.
        ///                         Applies only to line charts.
        /// </summary>
        public virtual DropBars UpBars { get; set; }

        /// <summary>
        /// Represents the data of the chart series.
        /// </summary>
        public virtual string Values { get; set; }

        /// <summary>
        /// Represents X direction error bar of the series.
        /// </summary>
        public virtual ErrorBar XErrorBar { get; set; }

        /// <summary>
        /// Represents the x values of the chart series.
        /// </summary>
        public virtual string XValues { get; set; }

        /// <summary>
        /// Represents Y direction error bar of the series.
        /// </summary>
        public virtual ErrorBar YErrorBar { get; set; }

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
            sb.Append("class Series {\n");
            sb.Append("  Area: ").Append(this.Area).Append("\n");
            sb.Append("  Bar3DShapeType: ").Append(this.Bar3DShapeType).Append("\n");
            sb.Append("  Border: ").Append(this.Border).Append("\n");
            sb.Append("  BubbleScale: ").Append(this.BubbleScale).Append("\n");
            sb.Append("  BubbleSizes: ").Append(this.BubbleSizes).Append("\n");
            sb.Append("  CountOfDataValues: ").Append(this.CountOfDataValues).Append("\n");
            sb.Append("  DataLabels: ").Append(this.DataLabels).Append("\n");
            sb.Append("  DisplayName: ").Append(this.DisplayName).Append("\n");
            sb.Append("  DoughnutHoleSize: ").Append(this.DoughnutHoleSize).Append("\n");
            sb.Append("  DownBars: ").Append(this.DownBars).Append("\n");
            sb.Append("  DropLines: ").Append(this.DropLines).Append("\n");
            sb.Append("  Explosion: ").Append(this.Explosion).Append("\n");
            sb.Append("  FirstSliceAngle: ").Append(this.FirstSliceAngle).Append("\n");
            sb.Append("  GapWidth: ").Append(this.GapWidth).Append("\n");
            sb.Append("  Has3DEffect: ").Append(this.Has3DEffect).Append("\n");
            sb.Append("  HasDropLines: ").Append(this.HasDropLines).Append("\n");
            sb.Append("  HasHiLoLines: ").Append(this.HasHiLoLines).Append("\n");
            sb.Append("  HasLeaderLines: ").Append(this.HasLeaderLines).Append("\n");
            sb.Append("  HasRadarAxisLabels: ").Append(this.HasRadarAxisLabels).Append("\n");
            sb.Append("  HasSeriesLines: ").Append(this.HasSeriesLines).Append("\n");
            sb.Append("  HasUpDownBars: ").Append(this.HasUpDownBars).Append("\n");
            sb.Append("  HiLoLines: ").Append(this.HiLoLines).Append("\n");
            sb.Append("  IsAutoSplit: ").Append(this.IsAutoSplit).Append("\n");
            sb.Append("  IsColorVaried: ").Append(this.IsColorVaried).Append("\n");
            sb.Append("  LeaderLines: ").Append(this.LeaderLines).Append("\n");
            sb.Append("  LegendEntry: ").Append(this.LegendEntry).Append("\n");
            sb.Append("  Marker: ").Append(this.Marker).Append("\n");
            sb.Append("  Name: ").Append(this.Name).Append("\n");
            sb.Append("  Overlap: ").Append(this.Overlap).Append("\n");
            sb.Append("  PlotOnSecondAxis: ").Append(this.PlotOnSecondAxis).Append("\n");
            sb.Append("  Points: ").Append(this.Points).Append("\n");
            sb.Append("  SecondPlotSize: ").Append(this.SecondPlotSize).Append("\n");
            sb.Append("  SeriesLines: ").Append(this.SeriesLines).Append("\n");
            sb.Append("  Shadow: ").Append(this.Shadow).Append("\n");
            sb.Append("  ShowNegativeBubbles: ").Append(this.ShowNegativeBubbles).Append("\n");
            sb.Append("  SizeRepresents: ").Append(this.SizeRepresents).Append("\n");
            sb.Append("  Smooth: ").Append(this.Smooth).Append("\n");
            sb.Append("  SplitType: ").Append(this.SplitType).Append("\n");
            sb.Append("  SplitValue: ").Append(this.SplitValue).Append("\n");
            sb.Append("  TrendLines: ").Append(this.TrendLines).Append("\n");
            sb.Append("  Type: ").Append(this.Type).Append("\n");
            sb.Append("  UpBars: ").Append(this.UpBars).Append("\n");
            sb.Append("  Values: ").Append(this.Values).Append("\n");
            sb.Append("  XErrorBar: ").Append(this.XErrorBar).Append("\n");
            sb.Append("  XValues: ").Append(this.XValues).Append("\n");
            sb.Append("  YErrorBar: ").Append(this.YErrorBar).Append("\n");
            sb.Append("  link: ").Append(this.link).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
