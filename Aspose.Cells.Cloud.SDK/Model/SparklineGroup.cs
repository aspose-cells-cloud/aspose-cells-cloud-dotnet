// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="SparklineGroup.cs">
//   Copyright (c) 2016 Aspose.Cells for Cloud
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
  using Newtonsoft.Json;
  using Newtonsoft.Json.Converters;

  /// <summary>
  /// 
  /// </summary>  
  [DataContract]
  public class SparklineGroup 
  {                       
        /// <summary>
        /// Gets or sets DisplayHidden
        /// </summary>  
		[DataMember(Name="DisplayHidden", EmitDefaultValue=false)]
        public bool? DisplayHidden { get; set; }

        /// <summary>
        /// Gets or sets FirstPointColor
        /// </summary>  
		[DataMember(Name="FirstPointColor", EmitDefaultValue=false)]
        public CellsColor FirstPointColor { get; set; }

        /// <summary>
        /// Gets or sets HighPointColor
        /// </summary>  
		[DataMember(Name="HighPointColor", EmitDefaultValue=false)]
        public CellsColor HighPointColor { get; set; }

        /// <summary>
        /// Gets or sets HorizontalAxisColor
        /// </summary>  
		[DataMember(Name="HorizontalAxisColor", EmitDefaultValue=false)]
        public CellsColor HorizontalAxisColor { get; set; }

        /// <summary>
        /// Gets or sets HorizontalAxisDateRange
        /// </summary>  
		[DataMember(Name="HorizontalAxisDateRange", EmitDefaultValue=false)]
        public string HorizontalAxisDateRange { get; set; }

        /// <summary>
        /// Gets or sets LastPointColor
        /// </summary>  
		[DataMember(Name="LastPointColor", EmitDefaultValue=false)]
        public CellsColor LastPointColor { get; set; }

        /// <summary>
        /// Gets or sets LineWeight
        /// </summary>  
		[DataMember(Name="LineWeight", EmitDefaultValue=false)]
        public double? LineWeight { get; set; }

        /// <summary>
        /// Gets or sets LowPointColor
        /// </summary>  
		[DataMember(Name="LowPointColor", EmitDefaultValue=false)]
        public CellsColor LowPointColor { get; set; }

        /// <summary>
        /// Gets or sets MarkersColor
        /// </summary>  
		[DataMember(Name="MarkersColor", EmitDefaultValue=false)]
        public CellsColor MarkersColor { get; set; }

        /// <summary>
        /// Gets or sets NegativePointsColor
        /// </summary>  
		[DataMember(Name="NegativePointsColor", EmitDefaultValue=false)]
        public CellsColor NegativePointsColor { get; set; }

        /// <summary>
        /// Gets or sets PlotEmptyCellsType
        /// </summary>  
		[DataMember(Name="PlotEmptyCellsType", EmitDefaultValue=false)]
        public string PlotEmptyCellsType { get; set; }

        /// <summary>
        /// Gets or sets PlotRightToLeft
        /// </summary>  
		[DataMember(Name="PlotRightToLeft", EmitDefaultValue=false)]
        public bool? PlotRightToLeft { get; set; }

        /// <summary>
        /// Gets or sets PresetStyle
        /// </summary>  
		[DataMember(Name="PresetStyle", EmitDefaultValue=false)]
        public string PresetStyle { get; set; }

        /// <summary>
        /// Gets or sets SeriesColor
        /// </summary>  
		[DataMember(Name="SeriesColor", EmitDefaultValue=false)]
        public CellsColor SeriesColor { get; set; }

        /// <summary>
        /// Gets or sets ShowFirstPoint
        /// </summary>  
		[DataMember(Name="ShowFirstPoint", EmitDefaultValue=false)]
        public bool? ShowFirstPoint { get; set; }

        /// <summary>
        /// Gets or sets ShowHighPoint
        /// </summary>  
		[DataMember(Name="ShowHighPoint", EmitDefaultValue=false)]
        public bool? ShowHighPoint { get; set; }

        /// <summary>
        /// Gets or sets ShowHorizontalAxis
        /// </summary>  
		[DataMember(Name="ShowHorizontalAxis", EmitDefaultValue=false)]
        public bool? ShowHorizontalAxis { get; set; }

        /// <summary>
        /// Gets or sets ShowLastPoint
        /// </summary>  
		[DataMember(Name="ShowLastPoint", EmitDefaultValue=false)]
        public bool? ShowLastPoint { get; set; }

        /// <summary>
        /// Gets or sets ShowLowPoint
        /// </summary>  
		[DataMember(Name="ShowLowPoint", EmitDefaultValue=false)]
        public bool? ShowLowPoint { get; set; }

        /// <summary>
        /// Gets or sets ShowMarkers
        /// </summary>  
		[DataMember(Name="ShowMarkers", EmitDefaultValue=false)]
        public bool? ShowMarkers { get; set; }

        /// <summary>
        /// Gets or sets ShowNegativePoints
        /// </summary>  
		[DataMember(Name="ShowNegativePoints", EmitDefaultValue=false)]
        public bool? ShowNegativePoints { get; set; }

        /// <summary>
        /// Gets or sets SparklineCollection
        /// </summary>  
		[DataMember(Name="SparklineCollection", EmitDefaultValue=false)]
        public List<Sparkline> SparklineCollection { get; set; }

        /// <summary>
        /// Gets or sets Type
        /// </summary>  
		[DataMember(Name="Type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets VerticalAxisMaxValue
        /// </summary>  
		[DataMember(Name="VerticalAxisMaxValue", EmitDefaultValue=false)]
        public double? VerticalAxisMaxValue { get; set; }

        /// <summary>
        /// Gets or sets VerticalAxisMaxValueType
        /// </summary>  
		[DataMember(Name="VerticalAxisMaxValueType", EmitDefaultValue=false)]
        public string VerticalAxisMaxValueType { get; set; }

        /// <summary>
        /// Gets or sets VerticalAxisMinValue
        /// </summary>  
		[DataMember(Name="VerticalAxisMinValue", EmitDefaultValue=false)]
        public double? VerticalAxisMinValue { get; set; }

        /// <summary>
        /// Gets or sets VerticalAxisMinValueType
        /// </summary>  
		[DataMember(Name="VerticalAxisMinValueType", EmitDefaultValue=false)]
        public string VerticalAxisMinValueType { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
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
