// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="NegativeBarFormat.cs">
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
  /// Represents the color settings of the data bars for negative values that are    defined by a data bar conditional formating rule.             
  /// </summary>  
  [DataContract]
  public class NegativeBarFormat 
  {                       
        /// <summary>
        /// Gets or sets a FormatColor object that you can use to specify the border    color for negative data bars.             
        /// </summary>  
		[DataMember(Name="BorderColor", EmitDefaultValue=false)]
        public Color BorderColor { get; set; }

        /// <summary>
        /// Gets whether to use the same border color as positive data bars.             
        /// </summary>  
		[DataMember(Name="BorderColorType", EmitDefaultValue=false)]
        public string BorderColorType { get; set; }

        /// <summary>
        /// Gets or sets a FormatColor object that you can use to specify the fill color    for negative data bars.             
        /// </summary>  
		[DataMember(Name="Color", EmitDefaultValue=false)]
        public Color Color { get; set; }

        /// <summary>
        /// Gets or sets whether to use the same fill color as positive data bars.
        /// </summary>  
		[DataMember(Name="ColorType", EmitDefaultValue=false)]
        public string ColorType { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class NegativeBarFormat {\n");
          sb.Append("  BorderColor: ").Append(this.BorderColor).Append("\n");
          sb.Append("  BorderColorType: ").Append(this.BorderColorType).Append("\n");
          sb.Append("  Color: ").Append(this.Color).Append("\n");
          sb.Append("  ColorType: ").Append(this.ColorType).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
