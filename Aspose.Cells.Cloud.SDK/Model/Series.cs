// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="Series.cs">
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
    /// Series.
    /// </summary>
    public class Series : LinkElement
    {
        /// <summary>
        /// Gets or sets Area.
        /// </summary>
        public virtual Area Area { get; set; }

        /// <summary>
        /// Gets or sets Bar3DShapeType.
        /// </summary>
        public virtual string Bar3DShapeType { get; set; }

        /// <summary>
        /// Gets or sets Border.
        /// </summary>
        public virtual Line Border { get; set; }

        /// <summary>
        /// Gets or sets BubbleScale.
        /// </summary>
        public virtual int? BubbleScale { get; set; }

        /// <summary>
        /// Gets or sets BubbleSizes.
        /// </summary>
        public virtual string BubbleSizes { get; set; }

        /// <summary>
        /// Gets or sets CountOfDataValues.
        /// </summary>
        public virtual int? CountOfDataValues { get; set; }

        /// <summary>
        /// Gets or sets DataLabels.
        /// </summary>
        public virtual LinkElement DataLabels { get; set; }

        /// <summary>
        /// Gets or sets DisplayName.
        /// </summary>
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets DoughnutHoleSize.
        /// </summary>
        public virtual int? DoughnutHoleSize { get; set; }

        /// <summary>
        /// Gets or sets DownBars.
        /// </summary>
        public virtual LinkElement DownBars { get; set; }

        /// <summary>
        /// Gets or sets DropLines.
        /// </summary>
        public virtual Line DropLines { get; set; }

        /// <summary>
        /// Gets or sets Explosion.
        /// </summary>
        public virtual int? Explosion { get; set; }

        /// <summary>
        /// Gets or sets FirstSliceAngle.
        /// </summary>
        public virtual int? FirstSliceAngle { get; set; }

        /// <summary>
        /// Gets or sets GapWidth.
        /// </summary>
        public virtual int? GapWidth { get; set; }

        /// <summary>
        /// Gets or sets Has3DEffect.
        /// </summary>
        public virtual bool? Has3DEffect { get; set; }

        /// <summary>
        /// Gets or sets HasDropLines.
        /// </summary>
        public virtual bool? HasDropLines { get; set; }

        /// <summary>
        /// Gets or sets HasHiLoLines.
        /// </summary>
        public virtual bool? HasHiLoLines { get; set; }

        /// <summary>
        /// Gets or sets HasLeaderLines.
        /// </summary>
        public virtual bool? HasLeaderLines { get; set; }

        /// <summary>
        /// Gets or sets HasRadarAxisLabels.
        /// </summary>
        public virtual bool? HasRadarAxisLabels { get; set; }

        /// <summary>
        /// Gets or sets HasSeriesLines.
        /// </summary>
        public virtual bool? HasSeriesLines { get; set; }

        /// <summary>
        /// Gets or sets HasUpDownBars.
        /// </summary>
        public virtual bool? HasUpDownBars { get; set; }

        /// <summary>
        /// Gets or sets HiLoLines.
        /// </summary>
        public virtual Line HiLoLines { get; set; }

        /// <summary>
        /// Gets or sets IsAutoSplit.
        /// </summary>
        public virtual bool? IsAutoSplit { get; set; }

        /// <summary>
        /// Gets or sets IsColorVaried.
        /// </summary>
        public virtual bool? IsColorVaried { get; set; }

        /// <summary>
        /// Gets or sets LeaderLines.
        /// </summary>
        public virtual Line LeaderLines { get; set; }

        /// <summary>
        /// Gets or sets LegendEntry.
        /// </summary>
        public virtual LinkElement LegendEntry { get; set; }

        /// <summary>
        /// Gets or sets Line.
        /// </summary>
        public virtual Line Line { get; set; }

        /// <summary>
        /// Gets or sets Marker.
        /// </summary>
        public virtual Marker Marker { get; set; }

        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        public virtual string Name { get; set; }

        /// <summary>
        /// Gets or sets Overlap.
        /// </summary>
        public virtual int? Overlap { get; set; }

        /// <summary>
        /// Gets or sets PlotOnSecondAxis.
        /// </summary>
        public virtual bool? PlotOnSecondAxis { get; set; }

        /// <summary>
        /// Gets or sets Points.
        /// </summary>
        public virtual LinkElement Points { get; set; }

        /// <summary>
        /// Gets or sets SecondPlotSize.
        /// </summary>
        public virtual int? SecondPlotSize { get; set; }

        /// <summary>
        /// Gets or sets SeriesLines.
        /// </summary>
        public virtual Line SeriesLines { get; set; }

        /// <summary>
        /// Gets or sets Shadow.
        /// </summary>
        public virtual bool? Shadow { get; set; }

        /// <summary>
        /// Gets or sets ShapeProperties.
        /// </summary>
        public virtual LinkElement ShapeProperties { get; set; }

        /// <summary>
        /// Gets or sets ShowNegativeBubbles.
        /// </summary>
        public virtual bool? ShowNegativeBubbles { get; set; }

        /// <summary>
        /// Gets or sets SizeRepresents.
        /// </summary>
        public virtual string SizeRepresents { get; set; }

        /// <summary>
        /// Gets or sets Smooth.
        /// </summary>
        public virtual bool? Smooth { get; set; }

        /// <summary>
        /// Gets or sets SplitType.
        /// </summary>
        public virtual string SplitType { get; set; }

        /// <summary>
        /// Gets or sets SplitValue.
        /// </summary>
        public virtual double? SplitValue { get; set; }

        /// <summary>
        /// Gets or sets TrendLines.
        /// </summary>
        public virtual LinkElement TrendLines { get; set; }

        /// <summary>
        /// Gets or sets Type.
        /// </summary>
        public virtual string Type { get; set; }

        /// <summary>
        /// Gets or sets UpBars.
        /// </summary>
        public virtual LinkElement UpBars { get; set; }

        /// <summary>
        /// Gets or sets Values.
        /// </summary>
        public virtual string Values { get; set; }

        /// <summary>
        /// Gets or sets XErrorBar.
        /// </summary>
        public virtual LinkElement XErrorBar { get; set; }

        /// <summary>
        /// Gets or sets XValues.
        /// </summary>
        public virtual string XValues { get; set; }

        /// <summary>
        /// Gets or sets YErrorBar.
        /// </summary>
        public virtual LinkElement YErrorBar { get; set; }

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
            sb.Append("  Line: ").Append(this.Line).Append("\n");
            sb.Append("  Marker: ").Append(this.Marker).Append("\n");
            sb.Append("  Name: ").Append(this.Name).Append("\n");
            sb.Append("  Overlap: ").Append(this.Overlap).Append("\n");
            sb.Append("  PlotOnSecondAxis: ").Append(this.PlotOnSecondAxis).Append("\n");
            sb.Append("  Points: ").Append(this.Points).Append("\n");
            sb.Append("  SecondPlotSize: ").Append(this.SecondPlotSize).Append("\n");
            sb.Append("  SeriesLines: ").Append(this.SeriesLines).Append("\n");
            sb.Append("  Shadow: ").Append(this.Shadow).Append("\n");
            sb.Append("  ShapeProperties: ").Append(this.ShapeProperties).Append("\n");
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
