// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="AutoFitterOptions.cs">
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
  public class AutoFitterOptions 
  {                       
        /// <summary>
        /// Gets or sets IgnoreHidden
        /// </summary>  
		[DataMember(Name="IgnoreHidden", EmitDefaultValue=false)]
        public bool? IgnoreHidden { get; set; }

        /// <summary>
        /// Gets or sets OnlyAuto
        /// </summary>  
		[DataMember(Name="OnlyAuto", EmitDefaultValue=false)]
        public bool? OnlyAuto { get; set; }

        /// <summary>
        /// Gets or sets AutoFitMergedCells
        /// </summary>  
		[DataMember(Name="AutoFitMergedCells", EmitDefaultValue=false)]
        public bool? AutoFitMergedCells { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class AutoFitterOptions {\n");
          sb.Append("  IgnoreHidden: ").Append(this.IgnoreHidden).Append("\n");
          sb.Append("  OnlyAuto: ").Append(this.OnlyAuto).Append("\n");
          sb.Append("  AutoFitMergedCells: ").Append(this.AutoFitMergedCells).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
