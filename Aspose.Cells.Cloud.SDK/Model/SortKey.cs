// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="SortKey.cs">
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
  public class SortKey 
  {                       
        /// <summary>
        /// Gets or sets CustomList
        /// </summary>  
		[DataMember(Name="CustomList", EmitDefaultValue=false)]
        public List<string> CustomList { get; set; }

        /// <summary>
        /// Gets or sets SortOrder
        /// </summary>  
		[DataMember(Name="SortOrder", EmitDefaultValue=false)]
        public string SortOrder { get; set; }

        /// <summary>
        /// Gets or sets Key
        /// </summary>  
		[DataMember(Name="Key", EmitDefaultValue=false)]
        public int? Key { get; set; }

        /// <summary>
        /// Gets or sets Order
        /// </summary>  
		[DataMember(Name="Order", EmitDefaultValue=false)]
        public string Order { get; set; }

        /// <summary>
        /// Gets or sets Type
        /// </summary>  
		[DataMember(Name="Type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets Index
        /// </summary>  
		[DataMember(Name="Index", EmitDefaultValue=false)]
        public int? Index { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class SortKey {\n");
          sb.Append("  CustomList: ").Append(this.CustomList).Append("\n");
          sb.Append("  SortOrder: ").Append(this.SortOrder).Append("\n");
          sb.Append("  Key: ").Append(this.Key).Append("\n");
          sb.Append("  Order: ").Append(this.Order).Append("\n");
          sb.Append("  Type: ").Append(this.Type).Append("\n");
          sb.Append("  Index: ").Append(this.Index).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
