// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="SvgSaveOptions.cs">
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
    /// SvgSaveOptions.
    /// </summary>
    public class SvgSaveOptions : SaveOptions
    {
        /// <summary>
        /// Gets or sets SheetIndex.
        /// </summary>
        public virtual int? SheetIndex { get; set; }

        /// <summary>
        /// Gets or sets ChartImageType.
        /// </summary>
        public virtual string ChartImageType { get; set; }

        /// <summary>
        /// Gets or sets EmbededImageNameInSvg.
        /// </summary>
        public virtual string EmbededImageNameInSvg { get; set; }

        /// <summary>
        /// Gets or sets HorizontalResolution.
        /// </summary>
        public virtual int? HorizontalResolution { get; set; }

        /// <summary>
        /// Gets or sets ImageFormat.
        /// </summary>
        public virtual string ImageFormat { get; set; }

        /// <summary>
        /// Gets or sets IsCellAutoFit.
        /// </summary>
        public virtual bool? IsCellAutoFit { get; set; }

        /// <summary>
        /// Gets or sets OnePagePerSheet.
        /// </summary>
        public virtual bool? OnePagePerSheet { get; set; }

        /// <summary>
        /// Gets or sets OnlyArea.
        /// </summary>
        public virtual bool? OnlyArea { get; set; }

        /// <summary>
        /// Gets or sets PrintingPage.
        /// </summary>
        public virtual string PrintingPage { get; set; }

        /// <summary>
        /// Gets or sets PrintWithStatusDialog.
        /// </summary>
        public virtual bool? PrintWithStatusDialog { get; set; }

        /// <summary>
        /// Gets or sets Quality.
        /// </summary>
        public virtual int? Quality { get; set; }

        /// <summary>
        /// Gets or sets TiffCompression.
        /// </summary>
        public virtual string TiffCompression { get; set; }

        /// <summary>
        /// Gets or sets VerticalResolution.
        /// </summary>
        public virtual int? VerticalResolution { get; set; }

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
            sb.Append("class SvgSaveOptions {\n");
            sb.Append("  SheetIndex: ").Append(this.SheetIndex).Append("\n");
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
