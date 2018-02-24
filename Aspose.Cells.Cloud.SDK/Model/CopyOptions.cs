// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="CopyOptions.cs">
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
  /// Represents the copy options.
  /// </summary>  
  [DataContract]
  public class CopyOptions 
  {                       
        /// <summary>
        /// Indicates whether copying column width in unit of characters.
        /// </summary>  
		[DataMember(Name="ColumnCharacterWidth", EmitDefaultValue=false)]
        public bool? ColumnCharacterWidth { get; set; }

        /// <summary>
        /// If the formula is not valid for the dest destination, only copy values.
        /// </summary>  
		[DataMember(Name="CopyInvalidFormulasAsValues", EmitDefaultValue=false)]
        public bool? CopyInvalidFormulasAsValues { get; set; }

        /// <summary>
        /// Indicates whether copying the names.
        /// </summary>  
		[DataMember(Name="CopyNames", EmitDefaultValue=false)]
        public bool? CopyNames { get; set; }

        /// <summary>
        /// Indicates whether extend ranges when copying the range to adjacent range.
        /// </summary>  
		[DataMember(Name="ExtendToAdjacentRange", EmitDefaultValue=false)]
        public bool? ExtendToAdjacentRange { get; set; }

        /// <summary>
        /// When copying the range in the same file and the chart refers to the source sheet,   False means the copied chart's data source will not be changed. True means the   copied chart's data source refers to the destination sheet.             
        /// </summary>  
		[DataMember(Name="ReferToDestinationSheet", EmitDefaultValue=false)]
        public bool? ReferToDestinationSheet { get; set; }

        /// <summary>
        /// Gets or sets ReferToSheetWithSameName
        /// </summary>  
		[DataMember(Name="ReferToSheetWithSameName", EmitDefaultValue=false)]
        public bool? ReferToSheetWithSameName { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class CopyOptions {\n");
          sb.Append("  ColumnCharacterWidth: ").Append(this.ColumnCharacterWidth).Append("\n");
          sb.Append("  CopyInvalidFormulasAsValues: ").Append(this.CopyInvalidFormulasAsValues).Append("\n");
          sb.Append("  CopyNames: ").Append(this.CopyNames).Append("\n");
          sb.Append("  ExtendToAdjacentRange: ").Append(this.ExtendToAdjacentRange).Append("\n");
          sb.Append("  ReferToDestinationSheet: ").Append(this.ReferToDestinationSheet).Append("\n");
          sb.Append("  ReferToSheetWithSameName: ").Append(this.ReferToSheetWithSameName).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
