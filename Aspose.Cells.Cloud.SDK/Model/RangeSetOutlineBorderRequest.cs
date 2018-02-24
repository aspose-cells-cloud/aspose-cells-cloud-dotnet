// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="RangeSetOutlineBorderRequest.cs">
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
  public class RangeSetOutlineBorderRequest 
  {                       
        /// <summary>
        /// Gets or sets Range
        /// </summary>  
		[DataMember(Name="Range", EmitDefaultValue=false)]
        public Range Range { get; set; }

        /// <summary>
        /// Gets or sets BorderEdge
        /// </summary>  
		[DataMember(Name="borderEdge", EmitDefaultValue=false)]
        public string BorderEdge { get; set; }

        /// <summary>
        /// Gets or sets BorderStyle
        /// </summary>  
		[DataMember(Name="borderStyle", EmitDefaultValue=false)]
        public string BorderStyle { get; set; }

        /// <summary>
        /// Gets or sets BorderColor
        /// </summary>  
		[DataMember(Name="borderColor", EmitDefaultValue=false)]
        public Color BorderColor { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class RangeSetOutlineBorderRequest {\n");
          sb.Append("  Range: ").Append(this.Range).Append("\n");
          sb.Append("  BorderEdge: ").Append(this.BorderEdge).Append("\n");
          sb.Append("  BorderStyle: ").Append(this.BorderStyle).Append("\n");
          sb.Append("  BorderColor: ").Append(this.BorderColor).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
