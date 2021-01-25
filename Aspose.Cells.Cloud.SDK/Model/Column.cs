// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="Column.cs">
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
  public class Column 
  {                       
        /// <summary>
        /// Gets or sets Link
        /// </summary>  
		[DataMember(Name="link", EmitDefaultValue=false)]
        public Link Link { get; set; }

        /// <summary>
        /// Gets or sets Index
        /// </summary>  
		[DataMember(Name="Index", EmitDefaultValue=false)]
        public int? Index { get; set; }

        /// <summary>
        /// Gets or sets Style
        /// </summary>  
		[DataMember(Name="Style", EmitDefaultValue=false)]
        public LinkElement Style { get; set; }

        /// <summary>
        /// Gets or sets GroupLevel
        /// </summary>  
		[DataMember(Name="GroupLevel", EmitDefaultValue=false)]
        public int? GroupLevel { get; set; }

        /// <summary>
        /// Gets or sets IsHidden
        /// </summary>  
		[DataMember(Name="IsHidden", EmitDefaultValue=false)]
        public bool? IsHidden { get; set; }

        /// <summary>
        /// Gets or sets Width
        /// </summary>  
		[DataMember(Name="Width", EmitDefaultValue=false)]
        public double? Width { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class Column {\n");
          sb.Append("  Link: ").Append(this.Link).Append("\n");
          sb.Append("  Index: ").Append(this.Index).Append("\n");
          sb.Append("  Style: ").Append(this.Style).Append("\n");
          sb.Append("  GroupLevel: ").Append(this.GroupLevel).Append("\n");
          sb.Append("  IsHidden: ").Append(this.IsHidden).Append("\n");
          sb.Append("  Width: ").Append(this.Width).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
