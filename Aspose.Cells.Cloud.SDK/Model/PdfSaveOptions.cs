// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PdfSaveOptions.cs">
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
    /// PdfSaveOptions.
    /// </summary>
    public class PdfSaveOptions : SaveOptions
    {
        /// <summary>
        /// Gets or sets DisplayDocTitle.
        /// </summary>
        public virtual bool? DisplayDocTitle { get; set; }

        /// <summary>
        /// Gets or sets ExportDocumentStructure.
        /// </summary>
        public virtual bool? ExportDocumentStructure { get; set; }

        /// <summary>
        /// Gets or sets EmfRenderSetting.
        /// </summary>
        public virtual string EmfRenderSetting { get; set; }

        /// <summary>
        /// Gets or sets CustomPropertiesExport.
        /// </summary>
        public virtual string CustomPropertiesExport { get; set; }

        /// <summary>
        /// Gets or sets OptimizationType.
        /// </summary>
        public virtual string OptimizationType { get; set; }

        /// <summary>
        /// Gets or sets Producer.
        /// </summary>
        public virtual string Producer { get; set; }

        /// <summary>
        /// Gets or sets PdfCompression.
        /// </summary>
        public virtual string PdfCompression { get; set; }

        /// <summary>
        /// Gets or sets FontEncoding.
        /// </summary>
        public virtual string FontEncoding { get; set; }

        /// <summary>
        /// Gets or sets Watermark.
        /// </summary>
        public virtual RenderingWatermark Watermark { get; set; }

        /// <summary>
        /// Gets or sets CalculateFormula.
        /// </summary>
        public virtual bool? CalculateFormula { get; set; }

        /// <summary>
        /// Gets or sets CheckFontCompatibility.
        /// </summary>
        public virtual bool? CheckFontCompatibility { get; set; }

        /// <summary>
        /// Gets or sets Compliance.
        /// </summary>
        public virtual string Compliance { get; set; }

        /// <summary>
        /// Gets or sets DefaultFont.
        /// </summary>
        public virtual string DefaultFont { get; set; }

        /// <summary>
        /// Gets or sets OnePagePerSheet.
        /// </summary>
        public virtual bool? OnePagePerSheet { get; set; }

        /// <summary>
        /// Gets or sets PrintingPageType.
        /// </summary>
        public virtual string PrintingPageType { get; set; }

        /// <summary>
        /// Gets or sets SecurityOptions.
        /// </summary>
        public virtual PdfSecurityOptions SecurityOptions { get; set; }

        /// <summary>
        /// Gets or sets desiredPPI.
        /// </summary>
        public virtual int? desiredPPI { get; set; }

        /// <summary>
        /// Gets or sets jpegQuality.
        /// </summary>
        public virtual int? jpegQuality { get; set; }

        /// <summary>
        /// Gets or sets ImageType.
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
        /// Gets or sets MergeAreas.
        /// </summary>
        public override bool? MergeAreas { get; set; }

        /// <summary>
        /// Gets or sets SortExternalNames.
        /// </summary>
        public override bool? SortExternalNames { get; set; }

        /// <summary>
        /// Gets or sets CheckExcelRestriction.
        /// </summary>
        public override bool? CheckExcelRestriction { get; set; }

        /// <summary>
        /// Gets or sets UpdateSmartArt.
        /// </summary>
        public override bool? UpdateSmartArt { get; set; }

        /// <summary>
        /// Gets or sets EncryptDocumentProperties.
        /// </summary>
        public override bool? EncryptDocumentProperties { get; set; }

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
            sb.Append("  MergeAreas: ").Append(this.MergeAreas).Append("\n");
            sb.Append("  SortExternalNames: ").Append(this.SortExternalNames).Append("\n");
            sb.Append("  CheckExcelRestriction: ").Append(this.CheckExcelRestriction).Append("\n");
            sb.Append("  UpdateSmartArt: ").Append(this.UpdateSmartArt).Append("\n");
            sb.Append("  EncryptDocumentProperties: ").Append(this.EncryptDocumentProperties).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
