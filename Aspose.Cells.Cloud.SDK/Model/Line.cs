// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="Line.cs">
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
  public class Line 
  {                       
        /// <summary>
        /// Gets or sets BeginArrowLength
        /// </summary>  
		[DataMember(Name="BeginArrowLength", EmitDefaultValue=false)]
        public string BeginArrowLength { get; set; }

        /// <summary>
        /// Gets or sets BeginArrowWidth
        /// </summary>  
		[DataMember(Name="BeginArrowWidth", EmitDefaultValue=false)]
        public string BeginArrowWidth { get; set; }

        /// <summary>
        /// Gets or sets BeginType
        /// </summary>  
		[DataMember(Name="BeginType", EmitDefaultValue=false)]
        public string BeginType { get; set; }

        /// <summary>
        /// Gets or sets CapType
        /// </summary>  
		[DataMember(Name="CapType", EmitDefaultValue=false)]
        public string CapType { get; set; }

        /// <summary>
        /// Gets or sets Color
        /// </summary>  
		[DataMember(Name="Color", EmitDefaultValue=false)]
        public Color Color { get; set; }

        /// <summary>
        /// Gets or sets CompoundType
        /// </summary>  
		[DataMember(Name="CompoundType", EmitDefaultValue=false)]
        public string CompoundType { get; set; }

        /// <summary>
        /// Gets or sets DashType
        /// </summary>  
		[DataMember(Name="DashType", EmitDefaultValue=false)]
        public string DashType { get; set; }

        /// <summary>
        /// Gets or sets EndArrowLength
        /// </summary>  
		[DataMember(Name="EndArrowLength", EmitDefaultValue=false)]
        public string EndArrowLength { get; set; }

        /// <summary>
        /// Gets or sets EndArrowWidth
        /// </summary>  
		[DataMember(Name="EndArrowWidth", EmitDefaultValue=false)]
        public string EndArrowWidth { get; set; }

        /// <summary>
        /// Gets or sets EndType
        /// </summary>  
		[DataMember(Name="EndType", EmitDefaultValue=false)]
        public string EndType { get; set; }

        /// <summary>
        /// Gets or sets GradientFill
        /// </summary>  
		[DataMember(Name="GradientFill", EmitDefaultValue=false)]
        public GradientFill GradientFill { get; set; }

        /// <summary>
        /// Gets or sets IsAuto
        /// </summary>  
		[DataMember(Name="IsAuto", EmitDefaultValue=false)]
        public bool? IsAuto { get; set; }

        /// <summary>
        /// Gets or sets IsAutomaticColor
        /// </summary>  
		[DataMember(Name="IsAutomaticColor", EmitDefaultValue=false)]
        public bool? IsAutomaticColor { get; set; }

        /// <summary>
        /// Gets or sets IsVisible
        /// </summary>  
		[DataMember(Name="IsVisible", EmitDefaultValue=false)]
        public bool? IsVisible { get; set; }

        /// <summary>
        /// Gets or sets JoinType
        /// </summary>  
		[DataMember(Name="JoinType", EmitDefaultValue=false)]
        public string JoinType { get; set; }

        /// <summary>
        /// Gets or sets Style
        /// </summary>  
		[DataMember(Name="Style", EmitDefaultValue=false)]
        public string Style { get; set; }

        /// <summary>
        /// Gets or sets Transparency
        /// </summary>  
		[DataMember(Name="Transparency", EmitDefaultValue=false)]
        public double? Transparency { get; set; }

        /// <summary>
        /// Gets or sets Weight
        /// </summary>  
		[DataMember(Name="Weight", EmitDefaultValue=false)]
        public string Weight { get; set; }

        /// <summary>
        /// Gets or sets WeightPt
        /// </summary>  
		[DataMember(Name="WeightPt", EmitDefaultValue=false)]
        public double? WeightPt { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class Line {\n");
          sb.Append("  BeginArrowLength: ").Append(this.BeginArrowLength).Append("\n");
          sb.Append("  BeginArrowWidth: ").Append(this.BeginArrowWidth).Append("\n");
          sb.Append("  BeginType: ").Append(this.BeginType).Append("\n");
          sb.Append("  CapType: ").Append(this.CapType).Append("\n");
          sb.Append("  Color: ").Append(this.Color).Append("\n");
          sb.Append("  CompoundType: ").Append(this.CompoundType).Append("\n");
          sb.Append("  DashType: ").Append(this.DashType).Append("\n");
          sb.Append("  EndArrowLength: ").Append(this.EndArrowLength).Append("\n");
          sb.Append("  EndArrowWidth: ").Append(this.EndArrowWidth).Append("\n");
          sb.Append("  EndType: ").Append(this.EndType).Append("\n");
          sb.Append("  GradientFill: ").Append(this.GradientFill).Append("\n");
          sb.Append("  IsAuto: ").Append(this.IsAuto).Append("\n");
          sb.Append("  IsAutomaticColor: ").Append(this.IsAutomaticColor).Append("\n");
          sb.Append("  IsVisible: ").Append(this.IsVisible).Append("\n");
          sb.Append("  JoinType: ").Append(this.JoinType).Append("\n");
          sb.Append("  Style: ").Append(this.Style).Append("\n");
          sb.Append("  Transparency: ").Append(this.Transparency).Append("\n");
          sb.Append("  Weight: ").Append(this.Weight).Append("\n");
          sb.Append("  WeightPt: ").Append(this.WeightPt).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
