// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="Rows.cs">
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
  public class Rows 
  {                       
        /// <summary>
        /// Gets or sets Link
        /// </summary>  
		[DataMember(Name="link", EmitDefaultValue=false)]
        public Link Link { get; set; }

        /// <summary>
        /// Gets or sets MaxRow
        /// </summary>  
		[DataMember(Name="MaxRow", EmitDefaultValue=false)]
        public int? MaxRow { get; set; }

        /// <summary>
        /// Gets or sets RowsList
        /// </summary>  
		[DataMember(Name="RowsList", EmitDefaultValue=false)]
        public List<LinkElement> RowsList { get; set; }

        /// <summary>
        /// Gets or sets RowsCount
        /// </summary>  
		[DataMember(Name="RowsCount", EmitDefaultValue=false)]
        public int? RowsCount { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class Rows {\n");
          sb.Append("  Link: ").Append(this.Link).Append("\n");
          sb.Append("  MaxRow: ").Append(this.MaxRow).Append("\n");
          sb.Append("  RowsList: ").Append(this.RowsList).Append("\n");
          sb.Append("  RowsCount: ").Append(this.RowsCount).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
