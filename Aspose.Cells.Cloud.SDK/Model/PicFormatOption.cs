// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PicFormatOption.cs">
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
  public class PicFormatOption 
  {                       
        /// <summary>
        /// Gets or sets Right
        /// </summary>  
		[DataMember(Name="Right", EmitDefaultValue=false)]
        public double? Right { get; set; }

        /// <summary>
        /// Gets or sets Bottom
        /// </summary>  
		[DataMember(Name="Bottom", EmitDefaultValue=false)]
        public double? Bottom { get; set; }

        /// <summary>
        /// Gets or sets Top
        /// </summary>  
		[DataMember(Name="Top", EmitDefaultValue=false)]
        public double? Top { get; set; }

        /// <summary>
        /// Gets or sets Scale
        /// </summary>  
		[DataMember(Name="Scale", EmitDefaultValue=false)]
        public double? Scale { get; set; }

        /// <summary>
        /// Gets or sets Type
        /// </summary>  
		[DataMember(Name="Type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets Left
        /// </summary>  
		[DataMember(Name="Left", EmitDefaultValue=false)]
        public double? Left { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class PicFormatOption {\n");
          sb.Append("  Right: ").Append(this.Right).Append("\n");
          sb.Append("  Bottom: ").Append(this.Bottom).Append("\n");
          sb.Append("  Top: ").Append(this.Top).Append("\n");
          sb.Append("  Scale: ").Append(this.Scale).Append("\n");
          sb.Append("  Type: ").Append(this.Type).Append("\n");
          sb.Append("  Left: ").Append(this.Left).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
