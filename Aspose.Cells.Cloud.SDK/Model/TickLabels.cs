// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="TickLabels.cs">
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
  public class TickLabels 
  {                       
        /// <summary>
        ///  
        /// </summary>  
		[DataMember(Name="AutoScaleFont", EmitDefaultValue=false)]
        public bool? AutoScaleFont { get; set; }

        /// <summary>
        /// Gets or sets Font
        /// </summary>  
		[DataMember(Name="Font", EmitDefaultValue=false)]
        public Font Font { get; set; }

        /// <summary>
        ///  
        /// </summary>  
		[DataMember(Name="BackgroundMode", EmitDefaultValue=false)]
        public string BackgroundMode { get; set; }

        /// <summary>
        /// Gets or sets Number
        /// </summary>  
		[DataMember(Name="Number", EmitDefaultValue=false)]
        public int? Number { get; set; }

        /// <summary>
        ///  
        /// </summary>  
		[DataMember(Name="NumberFormat", EmitDefaultValue=false)]
        public string NumberFormat { get; set; }

        /// <summary>
        ///  
        /// </summary>  
		[DataMember(Name="NumberFormatLinked", EmitDefaultValue=false)]
        public bool? NumberFormatLinked { get; set; }

        /// <summary>
        ///  
        /// </summary>  
		[DataMember(Name="Offset", EmitDefaultValue=false)]
        public int? Offset { get; set; }

        /// <summary>
        ///  
        /// </summary>  
		[DataMember(Name="RotationAngle", EmitDefaultValue=false)]
        public int? RotationAngle { get; set; }

        /// <summary>
        ///  
        /// </summary>  
		[DataMember(Name="TextDirection", EmitDefaultValue=false)]
        public string TextDirection { get; set; }

        /// <summary>
        ///  
        /// </summary>  
		[DataMember(Name="ReadingOrder", EmitDefaultValue=false)]
        public string ReadingOrder { get; set; }

        /// <summary>
        ///  
        /// </summary>  
		[DataMember(Name="DirectionType", EmitDefaultValue=false)]
        public string DirectionType { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class TickLabels {\n");
          sb.Append("  AutoScaleFont: ").Append(this.AutoScaleFont).Append("\n");
          sb.Append("  Font: ").Append(this.Font).Append("\n");
          sb.Append("  BackgroundMode: ").Append(this.BackgroundMode).Append("\n");
          sb.Append("  Number: ").Append(this.Number).Append("\n");
          sb.Append("  NumberFormat: ").Append(this.NumberFormat).Append("\n");
          sb.Append("  NumberFormatLinked: ").Append(this.NumberFormatLinked).Append("\n");
          sb.Append("  Offset: ").Append(this.Offset).Append("\n");
          sb.Append("  RotationAngle: ").Append(this.RotationAngle).Append("\n");
          sb.Append("  TextDirection: ").Append(this.TextDirection).Append("\n");
          sb.Append("  ReadingOrder: ").Append(this.ReadingOrder).Append("\n");
          sb.Append("  DirectionType: ").Append(this.DirectionType).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
