// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="CellsColor.cs">
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
  public class CellsColor 
  {                       
        /// <summary>
        /// Gets or sets Color
        /// </summary>  
		[DataMember(Name="Color", EmitDefaultValue=false)]
        public Color Color { get; set; }

        /// <summary>
        /// Gets or sets Type
        /// </summary>  
		[DataMember(Name="Type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets ThemeColor
        /// </summary>  
		[DataMember(Name="ThemeColor", EmitDefaultValue=false)]
        public ThemeColor ThemeColor { get; set; }

        /// <summary>
        /// Gets or sets IsShapeColor
        /// </summary>  
		[DataMember(Name="IsShapeColor", EmitDefaultValue=false)]
        public bool? IsShapeColor { get; set; }

        /// <summary>
        /// Gets or sets ColorIndex
        /// </summary>  
		[DataMember(Name="ColorIndex", EmitDefaultValue=false)]
        public int? ColorIndex { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class CellsColor {\n");
          sb.Append("  Color: ").Append(this.Color).Append("\n");
          sb.Append("  Type: ").Append(this.Type).Append("\n");
          sb.Append("  ThemeColor: ").Append(this.ThemeColor).Append("\n");
          sb.Append("  IsShapeColor: ").Append(this.IsShapeColor).Append("\n");
          sb.Append("  ColorIndex: ").Append(this.ColorIndex).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
