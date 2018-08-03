// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="FilterColumn.cs">
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
  public class FilterColumn 
  {                       
        /// <summary>
        /// Gets or sets FilterType
        /// </summary>  
		[DataMember(Name="FilterType", EmitDefaultValue=false)]
        public string FilterType { get; set; }

        /// <summary>
        /// Gets or sets MultipleFilters
        /// </summary>  
		[DataMember(Name="MultipleFilters", EmitDefaultValue=false)]
        public MultipleFilters MultipleFilters { get; set; }

        /// <summary>
        /// Gets or sets CustomFilters
        /// </summary>  
		[DataMember(Name="CustomFilters", EmitDefaultValue=false)]
        public List<CustomFilter> CustomFilters { get; set; }

        /// <summary>
        /// Gets or sets DynamicFilter
        /// </summary>  
		[DataMember(Name="DynamicFilter", EmitDefaultValue=false)]
        public DynamicFilter DynamicFilter { get; set; }

        /// <summary>
        /// Gets or sets ColorFilter
        /// </summary>  
		[DataMember(Name="ColorFilter", EmitDefaultValue=false)]
        public ColorFilter ColorFilter { get; set; }

        /// <summary>
        /// Gets or sets FieldIndex
        /// </summary>  
		[DataMember(Name="FieldIndex", EmitDefaultValue=false)]
        public int? FieldIndex { get; set; }

        /// <summary>
        /// Gets or sets Top10Filter
        /// </summary>  
		[DataMember(Name="Top10Filter", EmitDefaultValue=false)]
        public Top10Filter Top10Filter { get; set; }

        /// <summary>
        /// Gets or sets IconFilter
        /// </summary>  
		[DataMember(Name="IconFilter", EmitDefaultValue=false)]
        public IconFilter IconFilter { get; set; }

        /// <summary>
        /// Gets or sets Visibledropdown
        /// </summary>  
		[DataMember(Name="Visibledropdown", EmitDefaultValue=false)]
        public string Visibledropdown { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class FilterColumn {\n");
          sb.Append("  FilterType: ").Append(this.FilterType).Append("\n");
          sb.Append("  MultipleFilters: ").Append(this.MultipleFilters).Append("\n");
          sb.Append("  CustomFilters: ").Append(this.CustomFilters).Append("\n");
          sb.Append("  DynamicFilter: ").Append(this.DynamicFilter).Append("\n");
          sb.Append("  ColorFilter: ").Append(this.ColorFilter).Append("\n");
          sb.Append("  FieldIndex: ").Append(this.FieldIndex).Append("\n");
          sb.Append("  Top10Filter: ").Append(this.Top10Filter).Append("\n");
          sb.Append("  IconFilter: ").Append(this.IconFilter).Append("\n");
          sb.Append("  Visibledropdown: ").Append(this.Visibledropdown).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
