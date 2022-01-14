// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ImportPictureOption.cs">
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
  public class ImportPictureOption : ImportOption 
  {                       
        /// <summary>
        /// Upper Left Row.
        /// </summary>  
		[DataMember(Name="UpperLeftRow", EmitDefaultValue=false)]
        public int? UpperLeftRow { get; set; }

        /// <summary>
        /// Upper Left Column.
        /// </summary>  
		[DataMember(Name="UpperLeftColumn", EmitDefaultValue=false)]
        public int? UpperLeftColumn { get; set; }

        /// <summary>
        /// Lower Right Row.
        /// </summary>  
		[DataMember(Name="LowerRightRow", EmitDefaultValue=false)]
        public int? LowerRightRow { get; set; }

        /// <summary>
        /// Lower Right Column.
        /// </summary>  
		[DataMember(Name="LowerRightColumn", EmitDefaultValue=false)]
        public int? LowerRightColumn { get; set; }

        /// <summary>
        /// Filename.
        /// </summary>  
		[DataMember(Name="Filename", EmitDefaultValue=false)]
        public string Filename { get; set; }

        /// <summary>
        /// data : base64  string.
        /// </summary>  
		[DataMember(Name="Data", EmitDefaultValue=false)]
        public string Data { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class ImportPictureOption {\n");
          sb.Append("  UpperLeftRow: ").Append(this.UpperLeftRow).Append("\n");
          sb.Append("  UpperLeftColumn: ").Append(this.UpperLeftColumn).Append("\n");
          sb.Append("  LowerRightRow: ").Append(this.LowerRightRow).Append("\n");
          sb.Append("  LowerRightColumn: ").Append(this.LowerRightColumn).Append("\n");
          sb.Append("  Filename: ").Append(this.Filename).Append("\n");
          sb.Append("  Data: ").Append(this.Data).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
