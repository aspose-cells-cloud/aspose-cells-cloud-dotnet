// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ImageSaveOptions.cs">
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
  public class ImageSaveOptions : SaveOptions 
  {                       
        /// <summary>
        /// Gets or sets ChartImageType
        /// </summary>  
		[DataMember(Name="ChartImageType", EmitDefaultValue=false)]
        public string ChartImageType { get; set; }

        /// <summary>
        /// Gets or sets EmbededImageNameInSvg
        /// </summary>  
		[DataMember(Name="EmbededImageNameInSvg", EmitDefaultValue=false)]
        public string EmbededImageNameInSvg { get; set; }

        /// <summary>
        /// Gets or sets HorizontalResolution
        /// </summary>  
		[DataMember(Name="HorizontalResolution", EmitDefaultValue=false)]
        public int? HorizontalResolution { get; set; }

        /// <summary>
        /// Gets or sets ImageFormat
        /// </summary>  
		[DataMember(Name="ImageFormat", EmitDefaultValue=false)]
        public string ImageFormat { get; set; }

        /// <summary>
        /// Gets or sets IsCellAutoFit
        /// </summary>  
		[DataMember(Name="IsCellAutoFit", EmitDefaultValue=false)]
        public bool? IsCellAutoFit { get; set; }

        /// <summary>
        /// Gets or sets OnePagePerSheet
        /// </summary>  
		[DataMember(Name="OnePagePerSheet", EmitDefaultValue=false)]
        public bool? OnePagePerSheet { get; set; }

        /// <summary>
        /// Gets or sets OnlyArea
        /// </summary>  
		[DataMember(Name="OnlyArea", EmitDefaultValue=false)]
        public bool? OnlyArea { get; set; }

        /// <summary>
        /// Gets or sets PrintingPage
        /// </summary>  
		[DataMember(Name="PrintingPage", EmitDefaultValue=false)]
        public string PrintingPage { get; set; }

        /// <summary>
        /// Gets or sets PrintWithStatusDialog
        /// </summary>  
		[DataMember(Name="PrintWithStatusDialog", EmitDefaultValue=false)]
        public int? PrintWithStatusDialog { get; set; }

        /// <summary>
        /// Gets or sets Quality
        /// </summary>  
		[DataMember(Name="Quality", EmitDefaultValue=false)]
        public int? Quality { get; set; }

        /// <summary>
        /// Gets or sets TiffCompression
        /// </summary>  
		[DataMember(Name="TiffCompression", EmitDefaultValue=false)]
        public string TiffCompression { get; set; }

        /// <summary>
        /// Gets or sets VerticalResolution
        /// </summary>  
		[DataMember(Name="VerticalResolution", EmitDefaultValue=false)]
        public int? VerticalResolution { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class ImageSaveOptions {\n");
          sb.Append("  ChartImageType: ").Append(this.ChartImageType).Append("\n");
          sb.Append("  EmbededImageNameInSvg: ").Append(this.EmbededImageNameInSvg).Append("\n");
          sb.Append("  HorizontalResolution: ").Append(this.HorizontalResolution).Append("\n");
          sb.Append("  ImageFormat: ").Append(this.ImageFormat).Append("\n");
          sb.Append("  IsCellAutoFit: ").Append(this.IsCellAutoFit).Append("\n");
          sb.Append("  OnePagePerSheet: ").Append(this.OnePagePerSheet).Append("\n");
          sb.Append("  OnlyArea: ").Append(this.OnlyArea).Append("\n");
          sb.Append("  PrintingPage: ").Append(this.PrintingPage).Append("\n");
          sb.Append("  PrintWithStatusDialog: ").Append(this.PrintWithStatusDialog).Append("\n");
          sb.Append("  Quality: ").Append(this.Quality).Append("\n");
          sb.Append("  TiffCompression: ").Append(this.TiffCompression).Append("\n");
          sb.Append("  VerticalResolution: ").Append(this.VerticalResolution).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
