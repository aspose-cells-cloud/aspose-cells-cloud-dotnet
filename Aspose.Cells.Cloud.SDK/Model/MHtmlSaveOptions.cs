// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="MHtmlSaveOptions.cs">
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
  public class MHtmlSaveOptions : SaveOptions 
  {                       
        /// <summary>
        /// Gets or sets AttachedFilesDirectory
        /// </summary>  
		[DataMember(Name="AttachedFilesDirectory", EmitDefaultValue=false)]
        public string AttachedFilesDirectory { get; set; }

        /// <summary>
        /// Gets or sets AttachedFilesUrlPrefix
        /// </summary>  
		[DataMember(Name="AttachedFilesUrlPrefix", EmitDefaultValue=false)]
        public string AttachedFilesUrlPrefix { get; set; }

        /// <summary>
        /// Gets or sets Encoding
        /// </summary>  
		[DataMember(Name="Encoding", EmitDefaultValue=false)]
        public string Encoding { get; set; }

        /// <summary>
        /// Gets or sets ExportActiveWorksheetOnly
        /// </summary>  
		[DataMember(Name="ExportActiveWorksheetOnly", EmitDefaultValue=false)]
        public bool? ExportActiveWorksheetOnly { get; set; }

        /// <summary>
        /// Gets or sets ExportChartImageFormat
        /// </summary>  
		[DataMember(Name="ExportChartImageFormat", EmitDefaultValue=false)]
        public string ExportChartImageFormat { get; set; }

        /// <summary>
        /// Gets or sets ExportImagesAsBase64
        /// </summary>  
		[DataMember(Name="ExportImagesAsBase64", EmitDefaultValue=false)]
        public bool? ExportImagesAsBase64 { get; set; }

        /// <summary>
        /// Gets or sets HiddenColDisplayType
        /// </summary>  
		[DataMember(Name="HiddenColDisplayType", EmitDefaultValue=false)]
        public string HiddenColDisplayType { get; set; }

        /// <summary>
        /// Gets or sets HiddenRowDisplayType
        /// </summary>  
		[DataMember(Name="HiddenRowDisplayType", EmitDefaultValue=false)]
        public string HiddenRowDisplayType { get; set; }

        /// <summary>
        /// Gets or sets HtmlCrossStringType
        /// </summary>  
		[DataMember(Name="HtmlCrossStringType", EmitDefaultValue=false)]
        public string HtmlCrossStringType { get; set; }

        /// <summary>
        /// Gets or sets IsExpImageToTempDir
        /// </summary>  
		[DataMember(Name="IsExpImageToTempDir", EmitDefaultValue=false)]
        public bool? IsExpImageToTempDir { get; set; }

        /// <summary>
        /// Gets or sets PageTitle
        /// </summary>  
		[DataMember(Name="PageTitle", EmitDefaultValue=false)]
        public string PageTitle { get; set; }

        /// <summary>
        /// Gets or sets ParseHtmlTagInCell
        /// </summary>  
		[DataMember(Name="ParseHtmlTagInCell", EmitDefaultValue=false)]
        public bool? ParseHtmlTagInCell { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class MHtmlSaveOptions {\n");
          sb.Append("  AttachedFilesDirectory: ").Append(this.AttachedFilesDirectory).Append("\n");
          sb.Append("  AttachedFilesUrlPrefix: ").Append(this.AttachedFilesUrlPrefix).Append("\n");
          sb.Append("  Encoding: ").Append(this.Encoding).Append("\n");
          sb.Append("  ExportActiveWorksheetOnly: ").Append(this.ExportActiveWorksheetOnly).Append("\n");
          sb.Append("  ExportChartImageFormat: ").Append(this.ExportChartImageFormat).Append("\n");
          sb.Append("  ExportImagesAsBase64: ").Append(this.ExportImagesAsBase64).Append("\n");
          sb.Append("  HiddenColDisplayType: ").Append(this.HiddenColDisplayType).Append("\n");
          sb.Append("  HiddenRowDisplayType: ").Append(this.HiddenRowDisplayType).Append("\n");
          sb.Append("  HtmlCrossStringType: ").Append(this.HtmlCrossStringType).Append("\n");
          sb.Append("  IsExpImageToTempDir: ").Append(this.IsExpImageToTempDir).Append("\n");
          sb.Append("  PageTitle: ").Append(this.PageTitle).Append("\n");
          sb.Append("  ParseHtmlTagInCell: ").Append(this.ParseHtmlTagInCell).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
