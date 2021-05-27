// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="TilePicOption.cs">
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
  public class TilePicOption 
  {                       
        /// <summary>
        /// Gets or sets AlignmentType
        /// </summary>  
		[DataMember(Name="AlignmentType", EmitDefaultValue=false)]
        public string AlignmentType { get; set; }

        /// <summary>
        /// Gets or sets OffsetX
        /// </summary>  
		[DataMember(Name="OffsetX", EmitDefaultValue=false)]
        public double? OffsetX { get; set; }

        /// <summary>
        /// Gets or sets ScaleX
        /// </summary>  
		[DataMember(Name="ScaleX", EmitDefaultValue=false)]
        public double? ScaleX { get; set; }

        /// <summary>
        /// Gets or sets OffsetY
        /// </summary>  
		[DataMember(Name="OffsetY", EmitDefaultValue=false)]
        public double? OffsetY { get; set; }

        /// <summary>
        /// Gets or sets ScaleY
        /// </summary>  
		[DataMember(Name="ScaleY", EmitDefaultValue=false)]
        public double? ScaleY { get; set; }

        /// <summary>
        /// Gets or sets MirrorType
        /// </summary>  
		[DataMember(Name="MirrorType", EmitDefaultValue=false)]
        public string MirrorType { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class TilePicOption {\n");
          sb.Append("  AlignmentType: ").Append(this.AlignmentType).Append("\n");
          sb.Append("  OffsetX: ").Append(this.OffsetX).Append("\n");
          sb.Append("  ScaleX: ").Append(this.ScaleX).Append("\n");
          sb.Append("  OffsetY: ").Append(this.OffsetY).Append("\n");
          sb.Append("  ScaleY: ").Append(this.ScaleY).Append("\n");
          sb.Append("  MirrorType: ").Append(this.MirrorType).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
