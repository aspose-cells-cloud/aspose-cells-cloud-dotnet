// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="FormatCondition.cs">
//   Copyright (c) 2021 Aspose.Cells Cloud
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
  public class FormatCondition 
  {                       
        /// <summary>
        /// Gets or sets Link
        /// </summary>  
		[DataMember(Name="link", EmitDefaultValue=false)]
        public Link Link { get; set; }

        /// <summary>
        /// Gets or sets AboveAverage
        /// </summary>  
		[DataMember(Name="AboveAverage", EmitDefaultValue=false)]
        public AboveAverage AboveAverage { get; set; }

        /// <summary>
        /// Gets or sets Formula2
        /// </summary>  
		[DataMember(Name="Formula2", EmitDefaultValue=false)]
        public string Formula2 { get; set; }

        /// <summary>
        /// Gets or sets Style
        /// </summary>  
		[DataMember(Name="Style", EmitDefaultValue=false)]
        public Style Style { get; set; }

        /// <summary>
        /// Gets or sets Formula1
        /// </summary>  
		[DataMember(Name="Formula1", EmitDefaultValue=false)]
        public string Formula1 { get; set; }

        /// <summary>
        /// Gets or sets ColorScale
        /// </summary>  
		[DataMember(Name="ColorScale", EmitDefaultValue=false)]
        public ColorScale ColorScale { get; set; }

        /// <summary>
        /// Gets or sets DataBar
        /// </summary>  
		[DataMember(Name="DataBar", EmitDefaultValue=false)]
        public DataBar DataBar { get; set; }

        /// <summary>
        /// Gets or sets Text
        /// </summary>  
		[DataMember(Name="Text", EmitDefaultValue=false)]
        public string Text { get; set; }

        /// <summary>
        /// True, no rules with lower priority may be applied over this rule, when this     rule evaluates to true.  Only applies for Excel 2007;
        /// </summary>  
		[DataMember(Name="StopIfTrue", EmitDefaultValue=false)]
        public bool? StopIfTrue { get; set; }

        /// <summary>
        /// The priority of this conditional formatting rule. This value is used to determine     which format should be evaluated and rendered. Lower numeric values are higher     priority than higher numeric values, where '1' is the highest priority.
        /// </summary>  
		[DataMember(Name="Priority", EmitDefaultValue=false)]
        public int? Priority { get; set; }

        /// <summary>
        /// Gets or sets Top10
        /// </summary>  
		[DataMember(Name="Top10", EmitDefaultValue=false)]
        public Top10 Top10 { get; set; }

        /// <summary>
        /// Gets or sets Operator
        /// </summary>  
		[DataMember(Name="Operator", EmitDefaultValue=false)]
        public string Operator { get; set; }

        /// <summary>
        /// Gets or sets IconSet
        /// </summary>  
		[DataMember(Name="IconSet", EmitDefaultValue=false)]
        public IconSet IconSet { get; set; }

        /// <summary>
        /// Gets and sets whether the conditional format Type.             
        /// </summary>  
		[DataMember(Name="Type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets TimePeriod
        /// </summary>  
		[DataMember(Name="TimePeriod", EmitDefaultValue=false)]
        public string TimePeriod { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class FormatCondition {\n");
          sb.Append("  Link: ").Append(this.Link).Append("\n");
          sb.Append("  AboveAverage: ").Append(this.AboveAverage).Append("\n");
          sb.Append("  Formula2: ").Append(this.Formula2).Append("\n");
          sb.Append("  Style: ").Append(this.Style).Append("\n");
          sb.Append("  Formula1: ").Append(this.Formula1).Append("\n");
          sb.Append("  ColorScale: ").Append(this.ColorScale).Append("\n");
          sb.Append("  DataBar: ").Append(this.DataBar).Append("\n");
          sb.Append("  Text: ").Append(this.Text).Append("\n");
          sb.Append("  StopIfTrue: ").Append(this.StopIfTrue).Append("\n");
          sb.Append("  Priority: ").Append(this.Priority).Append("\n");
          sb.Append("  Top10: ").Append(this.Top10).Append("\n");
          sb.Append("  Operator: ").Append(this.Operator).Append("\n");
          sb.Append("  IconSet: ").Append(this.IconSet).Append("\n");
          sb.Append("  Type: ").Append(this.Type).Append("\n");
          sb.Append("  TimePeriod: ").Append(this.TimePeriod).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
