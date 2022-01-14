// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="DataBar.cs">
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
  /// Describe the DataBar conditional formatting rule. This conditional formatting    rule displays a gradated data bar in the range of cells.
  /// </summary>  
  [DataContract]
  public class DataBar 
  {                       
        /// <summary>
        /// Gets or sets the direction the databar is displayed.
        /// </summary>  
		[DataMember(Name="Direction", EmitDefaultValue=false)]
        public string Direction { get; set; }

        /// <summary>
        /// Get or set this DataBar's max value object.  Cannot set null or CFValueObject    with type FormatConditionValueType.Min to it.             
        /// </summary>  
		[DataMember(Name="MaxCfvo", EmitDefaultValue=false)]
        public ConditionalFormattingValue MaxCfvo { get; set; }

        /// <summary>
        /// Get or set this DataBar's Color.             
        /// </summary>  
		[DataMember(Name="Color", EmitDefaultValue=false)]
        public Color Color { get; set; }

        /// <summary>
        /// Represents the min length of data bar .             
        /// </summary>  
		[DataMember(Name="MinLength", EmitDefaultValue=false)]
        public int? MinLength { get; set; }

        /// <summary>
        /// Gets or sets how a data bar is filled with color.
        /// </summary>  
		[DataMember(Name="BarFillType", EmitDefaultValue=false)]
        public string BarFillType { get; set; }

        /// <summary>
        /// Get or set this DataBar's min value object.  Cannot set null or CFValueObject   with type FormatConditionValueType.Max to it.             
        /// </summary>  
		[DataMember(Name="MinCfvo", EmitDefaultValue=false)]
        public ConditionalFormattingValue MinCfvo { get; set; }

        /// <summary>
        /// Gets or sets the position of the axis of the data bars specified by a conditional    formatting rule.
        /// </summary>  
		[DataMember(Name="AxisPosition", EmitDefaultValue=false)]
        public string AxisPosition { get; set; }

        /// <summary>
        /// Gets the NegativeBarFormat object associated with a data bar conditional     formatting rule.
        /// </summary>  
		[DataMember(Name="NegativeBarFormat", EmitDefaultValue=false)]
        public NegativeBarFormat NegativeBarFormat { get; set; }

        /// <summary>
        /// Gets an object that specifies the border of a data bar.
        /// </summary>  
		[DataMember(Name="BarBorder", EmitDefaultValue=false)]
        public DataBarBorder BarBorder { get; set; }

        /// <summary>
        /// Gets the color of the axis for cells with conditional formatting as data bars.
        /// </summary>  
		[DataMember(Name="AxisColor", EmitDefaultValue=false)]
        public Color AxisColor { get; set; }

        /// <summary>
        /// Represents the max length of data bar .
        /// </summary>  
		[DataMember(Name="MaxLength", EmitDefaultValue=false)]
        public int? MaxLength { get; set; }

        /// <summary>
        /// Get or set the flag indicating whether to show the values of the cells on   which this data bar is applied.  Default value is true.             
        /// </summary>  
		[DataMember(Name="ShowValue", EmitDefaultValue=false)]
        public bool? ShowValue { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class DataBar {\n");
          sb.Append("  Direction: ").Append(this.Direction).Append("\n");
          sb.Append("  MaxCfvo: ").Append(this.MaxCfvo).Append("\n");
          sb.Append("  Color: ").Append(this.Color).Append("\n");
          sb.Append("  MinLength: ").Append(this.MinLength).Append("\n");
          sb.Append("  BarFillType: ").Append(this.BarFillType).Append("\n");
          sb.Append("  MinCfvo: ").Append(this.MinCfvo).Append("\n");
          sb.Append("  AxisPosition: ").Append(this.AxisPosition).Append("\n");
          sb.Append("  NegativeBarFormat: ").Append(this.NegativeBarFormat).Append("\n");
          sb.Append("  BarBorder: ").Append(this.BarBorder).Append("\n");
          sb.Append("  AxisColor: ").Append(this.AxisColor).Append("\n");
          sb.Append("  MaxLength: ").Append(this.MaxLength).Append("\n");
          sb.Append("  ShowValue: ").Append(this.ShowValue).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
