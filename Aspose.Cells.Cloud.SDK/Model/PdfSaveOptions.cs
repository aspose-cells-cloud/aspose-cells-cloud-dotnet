// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PdfSaveOptions.cs">
//   Copyright (c) 2024 Aspose.Cells Cloud
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
    /// Represents options of saving pdf file.
    /// </summary>
    public class PdfSaveOptions : SaveOptions
    {
        /// <summary>
        /// Indicates whether the window's title bar should display the document title.
        /// </summary>
        public virtual bool? DisplayDocTitle { get; set; }

        /// <summary>
        /// Indicates whether to export document structure.
        /// </summary>
        public virtual bool? ExportDocumentStructure { get; set; }

        /// <summary>
        /// Setting for rendering Emf metafile.
        /// </summary>
        public virtual string EmfRenderSetting { get; set; }

        /// <summary>
        /// Specifies the way CustomDocumentPropertyCollection are exported to PDF file.
        /// </summary>
        public virtual string CustomPropertiesExport { get; set; }

        /// <summary>
        /// Gets and sets pdf optimization type.
        /// </summary>
        public virtual string OptimizationType { get; set; }

        /// <summary>
        /// Gets and sets producer of generated pdf document.
        /// </summary>
        public virtual string Producer { get; set; }

        /// <summary>
        /// Indicate the compression algorithm.
        /// </summary>
        public virtual string PdfCompression { get; set; }

        /// <summary>
        /// Gets or sets embedded font encoding in pdf.
        /// </summary>
        public virtual string FontEncoding { get; set; }

        /// <summary>
        /// Gets or sets watermark to output.
        /// </summary>
        public virtual RenderingWatermark Watermark { get; set; }

        /// <summary>
        /// Indicates whether calculate formulas before saving pdf file.The default value is false.
        /// </summary>
        public virtual bool? CalculateFormula { get; set; }

        /// <summary>
        /// Indicates whether check font compatibility for every character in text.
        ///                 The default value is true.  Disable this property may give better performance.
        ///                  But when the default or specified font of text/character cannot be used
        ///                 to render it, unreadable characters(such as block) maybe occur in the generated
        ///                 pdf.  For such situation user should keep this property as true so that alternative
        ///                 font can be searched and used to render the text instead;
        /// </summary>
        public virtual bool? CheckFontCompatibility { get; set; }

        /// <summary>
        /// Workbook converts to pdf will according to PdfCompliance in this property.
        /// </summary>
        public virtual string Compliance { get; set; }

        /// <summary>
        /// When characters in the Excel are unicode and not be set with correct font in cell style, 
        ///              They may appear as block in pdf,image.  Set the DefaultFont such as MingLiu or MS Gothic to show these characters.  
        ///              If this property is not set, Aspose.Cells will use system default font to show these unicode characters.
        /// </summary>
        public virtual string DefaultFont { get; set; }

        /// <summary>
        /// If OnePagePerSheet is true , all content of one sheet will output to only
        ///             one page in result. The paper size of pagesetup will be invalid, and the
        ///                other settings of pagesetup will still take effect.
        /// </summary>
        public virtual bool? OnePagePerSheet { get; set; }

        /// <summary>
        /// Indicates which pages will not be printed.
        /// </summary>
        public virtual string PrintingPageType { get; set; }

        /// <summary>
        /// Set this options, when security is need in xls2pdf result.
        /// </summary>
        public virtual PdfSecurityOptions SecurityOptions { get; set; }

        /// <summary>
        /// Set desired PPI(pixels per inch) of resample images and jpeg quality  All images will be converted to JPEG with the specified quality setting, and images that are greater than the specified PPI (pixels per inch) will be resampled.
        ///               Desired pixels per inch. 220 high quality. 150 screen quality. 96 email quality.
        /// </summary>
        public virtual int? desiredPPI { get; set; }

        /// <summary>
        /// Set desired PPI(pixels per inch) of resample images and jpeg quality  All images will be converted to JPEG with the specified quality setting, and images that are greater than the specified PPI (pixels per inch) will be resampled.
        ///               0 - 100% JPEG quality.
        /// </summary>
        public virtual int? jpegQuality { get; set; }

        /// <summary>
        /// Represents the image type when converting the chart and shape .
        /// </summary>
        public virtual string ImageType { get; set; }

        /// <summary>
        /// Gets or sets SaveFormat.
        /// </summary>
        public override string SaveFormat { get; set; }

        /// <summary>
        /// Gets or sets CachedFileFolder.
        /// </summary>
        public override string CachedFileFolder { get; set; }

        /// <summary>
        /// Gets or sets ClearData.
        /// </summary>
        public override bool? ClearData { get; set; }

        /// <summary>
        /// Gets or sets CreateDirectory.
        /// </summary>
        public override bool? CreateDirectory { get; set; }

        /// <summary>
        /// Gets or sets EnableHTTPCompression.
        /// </summary>
        public override bool? EnableHTTPCompression { get; set; }

        /// <summary>
        /// Gets or sets RefreshChartCache.
        /// </summary>
        public override bool? RefreshChartCache { get; set; }

        /// <summary>
        /// Gets or sets SortNames.
        /// </summary>
        public override bool? SortNames { get; set; }

        /// <summary>
        /// Gets or sets ValidateMergedAreas.
        /// </summary>
        public override bool? ValidateMergedAreas { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PdfSaveOptions {\n");
            sb.Append("  DisplayDocTitle: ").Append(this.DisplayDocTitle).Append("\n");
            sb.Append("  ExportDocumentStructure: ").Append(this.ExportDocumentStructure).Append("\n");
            sb.Append("  EmfRenderSetting: ").Append(this.EmfRenderSetting).Append("\n");
            sb.Append("  CustomPropertiesExport: ").Append(this.CustomPropertiesExport).Append("\n");
            sb.Append("  OptimizationType: ").Append(this.OptimizationType).Append("\n");
            sb.Append("  Producer: ").Append(this.Producer).Append("\n");
            sb.Append("  PdfCompression: ").Append(this.PdfCompression).Append("\n");
            sb.Append("  FontEncoding: ").Append(this.FontEncoding).Append("\n");
            sb.Append("  Watermark: ").Append(this.Watermark).Append("\n");
            sb.Append("  CalculateFormula: ").Append(this.CalculateFormula).Append("\n");
            sb.Append("  CheckFontCompatibility: ").Append(this.CheckFontCompatibility).Append("\n");
            sb.Append("  Compliance: ").Append(this.Compliance).Append("\n");
            sb.Append("  DefaultFont: ").Append(this.DefaultFont).Append("\n");
            sb.Append("  OnePagePerSheet: ").Append(this.OnePagePerSheet).Append("\n");
            sb.Append("  PrintingPageType: ").Append(this.PrintingPageType).Append("\n");
            sb.Append("  SecurityOptions: ").Append(this.SecurityOptions).Append("\n");
            sb.Append("  desiredPPI: ").Append(this.desiredPPI).Append("\n");
            sb.Append("  jpegQuality: ").Append(this.jpegQuality).Append("\n");
            sb.Append("  ImageType: ").Append(this.ImageType).Append("\n");
            sb.Append("  SaveFormat: ").Append(this.SaveFormat).Append("\n");
            sb.Append("  CachedFileFolder: ").Append(this.CachedFileFolder).Append("\n");
            sb.Append("  ClearData: ").Append(this.ClearData).Append("\n");
            sb.Append("  CreateDirectory: ").Append(this.CreateDirectory).Append("\n");
            sb.Append("  EnableHTTPCompression: ").Append(this.EnableHTTPCompression).Append("\n");
            sb.Append("  RefreshChartCache: ").Append(this.RefreshChartCache).Append("\n");
            sb.Append("  SortNames: ").Append(this.SortNames).Append("\n");
            sb.Append("  ValidateMergedAreas: ").Append(this.ValidateMergedAreas).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
