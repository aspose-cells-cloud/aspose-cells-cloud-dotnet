// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="Top10.cs">
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
  /// Describe the Top10 conditional formatting rule. This conditional formatting     rule highlights cells whose values fall in the top N or bottom N bracket,     as specified.
  /// </summary>  
  [DataContract]
  public class Top10 
  {                       
        /// <summary>
        /// Get or set the flag indicating whether a \"top/bottom n\" rule is a \"bottom    n\" rule. '1' indicates 'bottom'.  Default value is false.             
        /// </summary>  
		[DataMember(Name="IsBottom", EmitDefaultValue=false)]
        public bool? IsBottom { get; set; }

        /// <summary>
        /// Get or set the flag indicating whether a \"top/bottom n\" rule is a \"top/bottom     n percent\" rule.  Default value is false.
        /// </summary>  
		[DataMember(Name="IsPercent", EmitDefaultValue=false)]
        public bool? IsPercent { get; set; }

        /// <summary>
        /// Get or set the value of \"n\" in a \"top/bottom n\" conditional formatting rule.      If IsPercent is true, the value must between 0 and 100.  Otherwise it must     between 0 and 1000.  Default value is 10.
        /// </summary>  
		[DataMember(Name="Rank", EmitDefaultValue=false)]
        public int? Rank { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class Top10 {\n");
          sb.Append("  IsBottom: ").Append(this.IsBottom).Append("\n");
          sb.Append("  IsPercent: ").Append(this.IsPercent).Append("\n");
          sb.Append("  Rank: ").Append(this.Rank).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
