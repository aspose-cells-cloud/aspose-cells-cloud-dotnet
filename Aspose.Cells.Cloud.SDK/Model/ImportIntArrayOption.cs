// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ImportIntArrayOption.cs">
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
  public class ImportIntArrayOption : ImportOption 
  {                       
        /// <summary>
        /// Gets or sets Data
        /// </summary>  
		[DataMember(Name="Data", EmitDefaultValue=false)]
        public List<int?> Data { get; set; }

        /// <summary>
        /// Gets or sets IsVertical
        /// </summary>  
		[DataMember(Name="IsVertical", EmitDefaultValue=false)]
        public bool? IsVertical { get; set; }

        /// <summary>
        /// Gets or sets FirstRow
        /// </summary>  
		[DataMember(Name="FirstRow", EmitDefaultValue=false)]
        public int? FirstRow { get; set; }

        /// <summary>
        /// Gets or sets FirstColumn
        /// </summary>  
		[DataMember(Name="FirstColumn", EmitDefaultValue=false)]
        public int? FirstColumn { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class ImportIntArrayOption {\n");
          sb.Append("  Data: ").Append(this.Data).Append("\n");
          sb.Append("  IsVertical: ").Append(this.IsVertical).Append("\n");
          sb.Append("  FirstRow: ").Append(this.FirstRow).Append("\n");
          sb.Append("  FirstColumn: ").Append(this.FirstColumn).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
