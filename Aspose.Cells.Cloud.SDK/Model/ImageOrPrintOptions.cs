// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ImageOrPrintOptions.cs">
//   Copyright (c) 2025 Aspose.Cells Cloud
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
    using System.Drawing;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// ImageOrPrintOptions.
    /// </summary>
    public class ImageOrPrintOptions
    {
        /// <summary>
        /// Gets or sets TextCrossType.
        /// </summary>
        public virtual string TextCrossType { get; set; }

        /// <summary>
        /// Gets or sets GridlineType.
        /// </summary>
        public virtual string GridlineType { get; set; }

        /// <summary>
        /// Gets or sets OutputBlankPageWhenNothingToPrint.
        /// </summary>
        public virtual bool? OutputBlankPageWhenNothingToPrint { get; set; }

        /// <summary>
        /// Gets or sets CheckWorkbookDefaultFont.
        /// </summary>
        public virtual bool? CheckWorkbookDefaultFont { get; set; }

        /// <summary>
        /// Gets or sets DefaultFont.
        /// </summary>
        public virtual string DefaultFont { get; set; }

        /// <summary>
        /// Gets or sets IsOptimized.
        /// </summary>
        public virtual bool? IsOptimized { get; set; }

        /// <summary>
        /// Gets or sets PageCount.
        /// </summary>
        public virtual int? PageCount { get; set; }

        /// <summary>
        /// Gets or sets PageIndex.
        /// </summary>
        public virtual int? PageIndex { get; set; }

        /// <summary>
        /// Gets or sets IsFontSubstitutionCharGranularity.
        /// </summary>
        public virtual bool? IsFontSubstitutionCharGranularity { get; set; }

        /// <summary>
        /// Gets or sets Transparent.
        /// </summary>
        public virtual bool? Transparent { get; set; }

        /// <summary>
        /// Gets or sets OnlyArea.
        /// </summary>
        public virtual bool? OnlyArea { get; set; }

        /// <summary>
        /// Gets or sets SVGFitToViewPort.
        /// </summary>
        public virtual bool? SVGFitToViewPort { get; set; }

        /// <summary>
        /// Gets or sets EmbededImageNameInSvg.
        /// </summary>
        public virtual string EmbededImageNameInSvg { get; set; }

        /// <summary>
        /// Gets or sets AllColumnsInOnePagePerSheet.
        /// </summary>
        public virtual bool? AllColumnsInOnePagePerSheet { get; set; }

        /// <summary>
        /// Gets or sets PrintWithStatusDialog.
        /// </summary>
        public virtual bool? PrintWithStatusDialog { get; set; }

        /// <summary>
        /// Gets or sets HorizontalResolution.
        /// </summary>
        public virtual int? HorizontalResolution { get; set; }

        /// <summary>
        /// Gets or sets VerticalResolution.
        /// </summary>
        public virtual int? VerticalResolution { get; set; }

        /// <summary>
        /// Gets or sets DefaultEditLanguage.
        /// </summary>
        public virtual string DefaultEditLanguage { get; set; }

        /// <summary>
        /// Gets or sets TiffColorDepth.
        /// </summary>
        public virtual string TiffColorDepth { get; set; }

        /// <summary>
        /// Gets or sets TiffCompression.
        /// </summary>
        public virtual string TiffCompression { get; set; }

        /// <summary>
        /// Gets or sets PrintingPage.
        /// </summary>
        public virtual string PrintingPage { get; set; }

        /// <summary>
        /// Gets or sets Quality.
        /// </summary>
        public virtual int? Quality { get; set; }

        /// <summary>
        /// Gets or sets ImageType.
        /// </summary>
        public virtual string ImageType { get; set; }

        /// <summary>
        /// Gets or sets OnePagePerSheet.
        /// </summary>
        public virtual bool? OnePagePerSheet { get; set; }

        /// <summary>
        /// Gets or sets TiffBinarizationMethod.
        /// </summary>
        public virtual string TiffBinarizationMethod { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ImageOrPrintOptions {\n");
            sb.Append("  TextCrossType: ").Append(this.TextCrossType).Append("\n");
            sb.Append("  GridlineType: ").Append(this.GridlineType).Append("\n");
            sb.Append("  OutputBlankPageWhenNothingToPrint: ").Append(this.OutputBlankPageWhenNothingToPrint).Append("\n");
            sb.Append("  CheckWorkbookDefaultFont: ").Append(this.CheckWorkbookDefaultFont).Append("\n");
            sb.Append("  DefaultFont: ").Append(this.DefaultFont).Append("\n");
            sb.Append("  IsOptimized: ").Append(this.IsOptimized).Append("\n");
            sb.Append("  PageCount: ").Append(this.PageCount).Append("\n");
            sb.Append("  PageIndex: ").Append(this.PageIndex).Append("\n");
            sb.Append("  IsFontSubstitutionCharGranularity: ").Append(this.IsFontSubstitutionCharGranularity).Append("\n");
            sb.Append("  Transparent: ").Append(this.Transparent).Append("\n");
            sb.Append("  OnlyArea: ").Append(this.OnlyArea).Append("\n");
            sb.Append("  SVGFitToViewPort: ").Append(this.SVGFitToViewPort).Append("\n");
            sb.Append("  EmbededImageNameInSvg: ").Append(this.EmbededImageNameInSvg).Append("\n");
            sb.Append("  AllColumnsInOnePagePerSheet: ").Append(this.AllColumnsInOnePagePerSheet).Append("\n");
            sb.Append("  PrintWithStatusDialog: ").Append(this.PrintWithStatusDialog).Append("\n");
            sb.Append("  HorizontalResolution: ").Append(this.HorizontalResolution).Append("\n");
            sb.Append("  VerticalResolution: ").Append(this.VerticalResolution).Append("\n");
            sb.Append("  DefaultEditLanguage: ").Append(this.DefaultEditLanguage).Append("\n");
            sb.Append("  TiffColorDepth: ").Append(this.TiffColorDepth).Append("\n");
            sb.Append("  TiffCompression: ").Append(this.TiffCompression).Append("\n");
            sb.Append("  PrintingPage: ").Append(this.PrintingPage).Append("\n");
            sb.Append("  Quality: ").Append(this.Quality).Append("\n");
            sb.Append("  ImageType: ").Append(this.ImageType).Append("\n");
            sb.Append("  OnePagePerSheet: ").Append(this.OnePagePerSheet).Append("\n");
            sb.Append("  TiffBinarizationMethod: ").Append(this.TiffBinarizationMethod).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
