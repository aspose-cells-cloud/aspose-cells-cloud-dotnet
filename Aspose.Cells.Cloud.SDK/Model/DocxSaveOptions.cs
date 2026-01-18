// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="DocxSaveOptions.cs">
//   Copyright (c) 2026 Aspose.Cells Cloud
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
    /// DocxSaveOptions.
    /// </summary>
    public class DocxSaveOptions : PaginatedSaveOptions
    {
        /// <summary>
        /// Gets or sets DefaultFont.
        /// </summary>
        public override string DefaultFont { get; set; }

        /// <summary>
        /// Gets or sets CheckWorkbookDefaultFont.
        /// </summary>
        public override bool? CheckWorkbookDefaultFont { get; set; }

        /// <summary>
        /// Gets or sets CheckFontCompatibility.
        /// </summary>
        public override bool? CheckFontCompatibility { get; set; }

        /// <summary>
        /// Gets or sets IsFontSubstitutionCharGranularity.
        /// </summary>
        public override bool? IsFontSubstitutionCharGranularity { get; set; }

        /// <summary>
        /// Gets or sets OnePagePerSheet.
        /// </summary>
        public override bool? OnePagePerSheet { get; set; }

        /// <summary>
        /// Gets or sets AllColumnsInOnePagePerSheet.
        /// </summary>
        public override bool? AllColumnsInOnePagePerSheet { get; set; }

        /// <summary>
        /// Gets or sets IgnoreError.
        /// </summary>
        public override bool? IgnoreError { get; set; }

        /// <summary>
        /// Gets or sets OutputBlankPageWhenNothingToPrint.
        /// </summary>
        public override bool? OutputBlankPageWhenNothingToPrint { get; set; }

        /// <summary>
        /// Gets or sets PageIndex.
        /// </summary>
        public override int? PageIndex { get; set; }

        /// <summary>
        /// Gets or sets PageCount.
        /// </summary>
        public override int? PageCount { get; set; }

        /// <summary>
        /// Gets or sets PrintingPageType.
        /// </summary>
        public override string PrintingPageType { get; set; }

        /// <summary>
        /// Gets or sets GridlineType.
        /// </summary>
        public override string GridlineType { get; set; }

        /// <summary>
        /// Gets or sets TextCrossType.
        /// </summary>
        public override string TextCrossType { get; set; }

        /// <summary>
        /// Gets or sets DefaultEditLanguage.
        /// </summary>
        public override string DefaultEditLanguage { get; set; }

        /// <summary>
        /// Gets or sets EmfRenderSetting.
        /// </summary>
        public override string EmfRenderSetting { get; set; }

        /// <summary>
        /// Gets or sets MergeAreas.
        /// </summary>
        public override bool? MergeAreas { get; set; }

        /// <summary>
        /// Gets or sets SortExternalNames.
        /// </summary>
        public override bool? SortExternalNames { get; set; }

        /// <summary>
        /// Gets or sets UpdateSmartArt.
        /// </summary>
        public override bool? UpdateSmartArt { get; set; }

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
        /// Gets or sets CheckExcelRestriction.
        /// </summary>
        public override bool? CheckExcelRestriction { get; set; }

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
            sb.Append("class DocxSaveOptions {\n");
            sb.Append("  DefaultFont: ").Append(this.DefaultFont).Append("\n");
            sb.Append("  CheckWorkbookDefaultFont: ").Append(this.CheckWorkbookDefaultFont).Append("\n");
            sb.Append("  CheckFontCompatibility: ").Append(this.CheckFontCompatibility).Append("\n");
            sb.Append("  IsFontSubstitutionCharGranularity: ").Append(this.IsFontSubstitutionCharGranularity).Append("\n");
            sb.Append("  OnePagePerSheet: ").Append(this.OnePagePerSheet).Append("\n");
            sb.Append("  AllColumnsInOnePagePerSheet: ").Append(this.AllColumnsInOnePagePerSheet).Append("\n");
            sb.Append("  IgnoreError: ").Append(this.IgnoreError).Append("\n");
            sb.Append("  OutputBlankPageWhenNothingToPrint: ").Append(this.OutputBlankPageWhenNothingToPrint).Append("\n");
            sb.Append("  PageIndex: ").Append(this.PageIndex).Append("\n");
            sb.Append("  PageCount: ").Append(this.PageCount).Append("\n");
            sb.Append("  PrintingPageType: ").Append(this.PrintingPageType).Append("\n");
            sb.Append("  GridlineType: ").Append(this.GridlineType).Append("\n");
            sb.Append("  TextCrossType: ").Append(this.TextCrossType).Append("\n");
            sb.Append("  DefaultEditLanguage: ").Append(this.DefaultEditLanguage).Append("\n");
            sb.Append("  EmfRenderSetting: ").Append(this.EmfRenderSetting).Append("\n");
            sb.Append("  MergeAreas: ").Append(this.MergeAreas).Append("\n");
            sb.Append("  SortExternalNames: ").Append(this.SortExternalNames).Append("\n");
            sb.Append("  UpdateSmartArt: ").Append(this.UpdateSmartArt).Append("\n");
            sb.Append("  SaveFormat: ").Append(this.SaveFormat).Append("\n");
            sb.Append("  CachedFileFolder: ").Append(this.CachedFileFolder).Append("\n");
            sb.Append("  ClearData: ").Append(this.ClearData).Append("\n");
            sb.Append("  CreateDirectory: ").Append(this.CreateDirectory).Append("\n");
            sb.Append("  EnableHTTPCompression: ").Append(this.EnableHTTPCompression).Append("\n");
            sb.Append("  RefreshChartCache: ").Append(this.RefreshChartCache).Append("\n");
            sb.Append("  SortNames: ").Append(this.SortNames).Append("\n");
            sb.Append("  ValidateMergedAreas: ").Append(this.ValidateMergedAreas).Append("\n");
            sb.Append("  CheckExcelRestriction: ").Append(this.CheckExcelRestriction).Append("\n");
            sb.Append("  EncryptDocumentProperties: ").Append(this.EncryptDocumentProperties).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
