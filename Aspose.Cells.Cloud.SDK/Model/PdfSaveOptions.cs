// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PdfSaveOptions.cs">
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
  /// 
  /// </summary>  
  [DataContract]
  public class PdfSaveOptions : SaveOptions 
  {                       
        /// <summary>
        /// Gets or sets CalculateFormula
        /// </summary>  
		[DataMember(Name="CalculateFormula", EmitDefaultValue=false)]
        public bool? CalculateFormula { get; set; }

        /// <summary>
        /// Gets or sets CheckFontCompatibility
        /// </summary>  
		[DataMember(Name="CheckFontCompatibility", EmitDefaultValue=false)]
        public bool? CheckFontCompatibility { get; set; }

        /// <summary>
        /// Gets or sets OnePagePerSheet
        /// </summary>  
		[DataMember(Name="OnePagePerSheet", EmitDefaultValue=false)]
        public bool? OnePagePerSheet { get; set; }

        /// <summary>
        /// Gets or sets Compliance
        /// </summary>  
		[DataMember(Name="Compliance", EmitDefaultValue=false)]
        public string Compliance { get; set; }

        /// <summary>
        /// Gets or sets DefaultFont
        /// </summary>  
		[DataMember(Name="DefaultFont", EmitDefaultValue=false)]
        public string DefaultFont { get; set; }

        /// <summary>
        /// Gets or sets PrintingPageType
        /// </summary>  
		[DataMember(Name="PrintingPageType", EmitDefaultValue=false)]
        public string PrintingPageType { get; set; }

        /// <summary>
        /// Gets or sets ImageType
        /// </summary>  
		[DataMember(Name="ImageType", EmitDefaultValue=false)]
        public string ImageType { get; set; }

        /// <summary>
        /// Gets or sets DesiredPPI
        /// </summary>  
		[DataMember(Name="desiredPPI", EmitDefaultValue=false)]
        public int? DesiredPPI { get; set; }

        /// <summary>
        /// Gets or sets JpegQuality
        /// </summary>  
		[DataMember(Name="jpegQuality", EmitDefaultValue=false)]
        public int? JpegQuality { get; set; }

        /// <summary>
        /// Gets or sets SecurityOptions
        /// </summary>  
		[DataMember(Name="SecurityOptions", EmitDefaultValue=false)]
        public PdfSecurityOptions SecurityOptions { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class PdfSaveOptions {\n");
          sb.Append("  CalculateFormula: ").Append(this.CalculateFormula).Append("\n");
          sb.Append("  CheckFontCompatibility: ").Append(this.CheckFontCompatibility).Append("\n");
          sb.Append("  OnePagePerSheet: ").Append(this.OnePagePerSheet).Append("\n");
          sb.Append("  Compliance: ").Append(this.Compliance).Append("\n");
          sb.Append("  DefaultFont: ").Append(this.DefaultFont).Append("\n");
          sb.Append("  PrintingPageType: ").Append(this.PrintingPageType).Append("\n");
          sb.Append("  ImageType: ").Append(this.ImageType).Append("\n");
          sb.Append("  DesiredPPI: ").Append(this.DesiredPPI).Append("\n");
          sb.Append("  JpegQuality: ").Append(this.JpegQuality).Append("\n");
          sb.Append("  SecurityOptions: ").Append(this.SecurityOptions).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
