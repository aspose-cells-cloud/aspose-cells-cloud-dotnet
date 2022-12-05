// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="Axis.cs">
//   Copyright (c) 2022 Aspose.Cells for Cloud
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
  public class Axis 
  {                       
        /// <summary>
        /// Gets or sets Area
        /// </summary>  
		[DataMember(Name="Area", EmitDefaultValue=false)]
        public Area Area { get; set; }

        /// <summary>
        ///  
        /// </summary>  
		[DataMember(Name="AxisBetweenCategories", EmitDefaultValue=false)]
        public bool? AxisBetweenCategories { get; set; }

        /// <summary>
        /// Gets or sets AxisLine
        /// </summary>  
		[DataMember(Name="AxisLine", EmitDefaultValue=false)]
        public Area AxisLine { get; set; }

        /// <summary>
        ///  
        /// </summary>  
		[DataMember(Name="BaseUnitScale", EmitDefaultValue=false)]
        public string BaseUnitScale { get; set; }

        /// <summary>
        ///  
        /// </summary>  
		[DataMember(Name="CategoryType", EmitDefaultValue=false)]
        public string CategoryType { get; set; }

        /// <summary>
        ///  
        /// </summary>  
		[DataMember(Name="CrossAt", EmitDefaultValue=false)]
        public double? CrossAt { get; set; }

        /// <summary>
        ///  
        /// </summary>  
		[DataMember(Name="CrossType", EmitDefaultValue=false)]
        public string CrossType { get; set; }

        /// <summary>
        ///  
        /// </summary>  
		[DataMember(Name="DisplayUnit", EmitDefaultValue=false)]
        public string DisplayUnit { get; set; }

        /// <summary>
        ///  
        /// </summary>  
		[DataMember(Name="HasMultiLevelLabels", EmitDefaultValue=false)]
        public bool? HasMultiLevelLabels { get; set; }

        /// <summary>
        ///  
        /// </summary>  
		[DataMember(Name="IsAutomaticMaxValue", EmitDefaultValue=false)]
        public bool? IsAutomaticMaxValue { get; set; }

        /// <summary>
        ///  
        /// </summary>  
		[DataMember(Name="IsAutomaticMinorUnit", EmitDefaultValue=false)]
        public bool? IsAutomaticMinorUnit { get; set; }

        /// <summary>
        ///  
        /// </summary>  
		[DataMember(Name="IsAutomaticMinValue", EmitDefaultValue=false)]
        public bool? IsAutomaticMinValue { get; set; }

        /// <summary>
        ///  
        /// </summary>  
		[DataMember(Name="IsDisplayUnitLabelShown", EmitDefaultValue=false)]
        public bool? IsDisplayUnitLabelShown { get; set; }

        /// <summary>
        ///  
        /// </summary>  
		[DataMember(Name="IsAutomaticMajorUnit", EmitDefaultValue=false)]
        public bool? IsAutomaticMajorUnit { get; set; }

        /// <summary>
        ///  
        /// </summary>  
		[DataMember(Name="IsLogarithmic", EmitDefaultValue=false)]
        public bool? IsLogarithmic { get; set; }

        /// <summary>
        ///  
        /// </summary>  
		[DataMember(Name="IsPlotOrderReversed", EmitDefaultValue=false)]
        public bool? IsPlotOrderReversed { get; set; }

        /// <summary>
        ///  
        /// </summary>  
		[DataMember(Name="IsVisible", EmitDefaultValue=false)]
        public bool? IsVisible { get; set; }

        /// <summary>
        ///  
        /// </summary>  
		[DataMember(Name="LogBase", EmitDefaultValue=false)]
        public double? LogBase { get; set; }

        /// <summary>
        /// Gets or sets MajorGridLines
        /// </summary>  
		[DataMember(Name="MajorGridLines", EmitDefaultValue=false)]
        public Line MajorGridLines { get; set; }

        /// <summary>
        ///  
        /// </summary>  
		[DataMember(Name="MajorTickMark", EmitDefaultValue=false)]
        public string MajorTickMark { get; set; }

        /// <summary>
        ///  
        /// </summary>  
		[DataMember(Name="MajorUnit", EmitDefaultValue=false)]
        public double? MajorUnit { get; set; }

        /// <summary>
        ///  
        /// </summary>  
		[DataMember(Name="MajorUnitScale", EmitDefaultValue=false)]
        public string MajorUnitScale { get; set; }

        /// <summary>
        ///  
        /// </summary>  
		[DataMember(Name="MaxValue", EmitDefaultValue=false)]
        public double? MaxValue { get; set; }

        /// <summary>
        /// Gets or sets MinorGridLines
        /// </summary>  
		[DataMember(Name="MinorGridLines", EmitDefaultValue=false)]
        public Line MinorGridLines { get; set; }

        /// <summary>
        ///  
        /// </summary>  
		[DataMember(Name="MinorTickMark", EmitDefaultValue=false)]
        public string MinorTickMark { get; set; }

        /// <summary>
        ///  
        /// </summary>  
		[DataMember(Name="MinorUnit", EmitDefaultValue=false)]
        public double? MinorUnit { get; set; }

        /// <summary>
        ///  
        /// </summary>  
		[DataMember(Name="MinorUnitScale", EmitDefaultValue=false)]
        public string MinorUnitScale { get; set; }

        /// <summary>
        ///  
        /// </summary>  
		[DataMember(Name="MinValue", EmitDefaultValue=false)]
        public double? MinValue { get; set; }

        /// <summary>
        ///  
        /// </summary>  
		[DataMember(Name="TickLabelPosition", EmitDefaultValue=false)]
        public string TickLabelPosition { get; set; }

        /// <summary>
        /// Gets or sets TickLabels
        /// </summary>  
		[DataMember(Name="TickLabels", EmitDefaultValue=false)]
        public TickLabels TickLabels { get; set; }

        /// <summary>
        /// Gets or sets TickLabelSpacing
        /// </summary>  
		[DataMember(Name="TickLabelSpacing", EmitDefaultValue=false)]
        public int? TickLabelSpacing { get; set; }

        /// <summary>
        /// Gets or sets TickMarkSpacing
        /// </summary>  
		[DataMember(Name="TickMarkSpacing", EmitDefaultValue=false)]
        public int? TickMarkSpacing { get; set; }

        /// <summary>
        /// Gets or sets Title
        /// </summary>  
		[DataMember(Name="Title", EmitDefaultValue=false)]
        public Title Title { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class Axis {\n");
          sb.Append("  Area: ").Append(this.Area).Append("\n");
          sb.Append("  AxisBetweenCategories: ").Append(this.AxisBetweenCategories).Append("\n");
          sb.Append("  AxisLine: ").Append(this.AxisLine).Append("\n");
          sb.Append("  BaseUnitScale: ").Append(this.BaseUnitScale).Append("\n");
          sb.Append("  CategoryType: ").Append(this.CategoryType).Append("\n");
          sb.Append("  CrossAt: ").Append(this.CrossAt).Append("\n");
          sb.Append("  CrossType: ").Append(this.CrossType).Append("\n");
          sb.Append("  DisplayUnit: ").Append(this.DisplayUnit).Append("\n");
          sb.Append("  HasMultiLevelLabels: ").Append(this.HasMultiLevelLabels).Append("\n");
          sb.Append("  IsAutomaticMaxValue: ").Append(this.IsAutomaticMaxValue).Append("\n");
          sb.Append("  IsAutomaticMinorUnit: ").Append(this.IsAutomaticMinorUnit).Append("\n");
          sb.Append("  IsAutomaticMinValue: ").Append(this.IsAutomaticMinValue).Append("\n");
          sb.Append("  IsDisplayUnitLabelShown: ").Append(this.IsDisplayUnitLabelShown).Append("\n");
          sb.Append("  IsAutomaticMajorUnit: ").Append(this.IsAutomaticMajorUnit).Append("\n");
          sb.Append("  IsLogarithmic: ").Append(this.IsLogarithmic).Append("\n");
          sb.Append("  IsPlotOrderReversed: ").Append(this.IsPlotOrderReversed).Append("\n");
          sb.Append("  IsVisible: ").Append(this.IsVisible).Append("\n");
          sb.Append("  LogBase: ").Append(this.LogBase).Append("\n");
          sb.Append("  MajorGridLines: ").Append(this.MajorGridLines).Append("\n");
          sb.Append("  MajorTickMark: ").Append(this.MajorTickMark).Append("\n");
          sb.Append("  MajorUnit: ").Append(this.MajorUnit).Append("\n");
          sb.Append("  MajorUnitScale: ").Append(this.MajorUnitScale).Append("\n");
          sb.Append("  MaxValue: ").Append(this.MaxValue).Append("\n");
          sb.Append("  MinorGridLines: ").Append(this.MinorGridLines).Append("\n");
          sb.Append("  MinorTickMark: ").Append(this.MinorTickMark).Append("\n");
          sb.Append("  MinorUnit: ").Append(this.MinorUnit).Append("\n");
          sb.Append("  MinorUnitScale: ").Append(this.MinorUnitScale).Append("\n");
          sb.Append("  MinValue: ").Append(this.MinValue).Append("\n");
          sb.Append("  TickLabelPosition: ").Append(this.TickLabelPosition).Append("\n");
          sb.Append("  TickLabels: ").Append(this.TickLabels).Append("\n");
          sb.Append("  TickLabelSpacing: ").Append(this.TickLabelSpacing).Append("\n");
          sb.Append("  TickMarkSpacing: ").Append(this.TickMarkSpacing).Append("\n");
          sb.Append("  Title: ").Append(this.Title).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
