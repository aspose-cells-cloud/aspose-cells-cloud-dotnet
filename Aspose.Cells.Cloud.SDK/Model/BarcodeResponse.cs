// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="BarcodeResponse.cs">
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
  public class BarcodeResponse 
  {                       
        /// <summary>
        /// Gets or sets BarcodeValue
        /// </summary>  
		[DataMember(Name="BarcodeValue", EmitDefaultValue=false)]
        public string BarcodeValue { get; set; }

        /// <summary>
        /// Gets or sets BarcodeType
        /// </summary>  
		[DataMember(Name="BarcodeType", EmitDefaultValue=false)]
        public string BarcodeType { get; set; }

        /// <summary>
        /// Gets or sets Checksum
        /// </summary>  
		[DataMember(Name="Checksum", EmitDefaultValue=false)]
        public string Checksum { get; set; }

        /// <summary>
        /// Gets or sets Region
        /// </summary>  
		[DataMember(Name="Region", EmitDefaultValue=false)]
        public List<System.Drawing.Point> Region { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class BarcodeResponse {\n");
          sb.Append("  BarcodeValue: ").Append(this.BarcodeValue).Append("\n");
          sb.Append("  BarcodeType: ").Append(this.BarcodeType).Append("\n");
          sb.Append("  Checksum: ").Append(this.Checksum).Append("\n");
          sb.Append("  Region: ").Append(this.Region).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
