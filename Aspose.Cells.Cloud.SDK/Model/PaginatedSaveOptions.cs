// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PaginatedSaveOptions.cs">
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
    /// Represents the options for pagination.
    /// </summary>
    public class PaginatedSaveOptions : SaveOptions
    {
        /// <summary>
        /// When characters in the Excel are Unicode and not be set with correct font in cell style,They may appear as block in pdf,image.Set the DefaultFont such as MingLiu or MS Gothic to show these characters. If this property is not set, Aspose.Cells will use system default font to show these unicode characters.
        /// </summary>
        public virtual string DefaultFont { get; set; }

        /// <summary>
        /// When characters in the Excel are Unicode and not be set with correct font in cell style,They may appear as block in pdf,image.Set this to true to try to use workbook's default font to show these characters first.
        /// </summary>
        public virtual bool? CheckWorkbookDefaultFont { get; set; }

        /// <summary>
        /// Indicates whether to check font compatibility for every character in text.
        /// </summary>
        public virtual bool? CheckFontCompatibility { get; set; }

        /// <summary>
        /// Indicates whether to only substitute the font of character when the cell font is not compatibility for it.
        /// </summary>
        public virtual bool? IsFontSubstitutionCharGranularity { get; set; }

        /// <summary>
        /// If OnePagePerSheet is true , all content of one sheet will output to only one page in result.The paper size of pagesetup will be invalid, and the other settings of pagesetup will still take effect.
        /// </summary>
        public virtual bool? OnePagePerSheet { get; set; }

        /// <summary>
        /// If AllColumnsInOnePagePerSheet is true , all column content of one sheet will output to only one page in result.The width of paper size of pagesetup will be ignored, and the other settings of pagesetup will still take effect.
        /// </summary>
        public virtual bool? AllColumnsInOnePagePerSheet { get; set; }

        /// <summary>
        /// Indicates if you need to hide the error while rendering.The error can be error in shape, image, chart rendering, etc.
        /// </summary>
        public virtual bool? IgnoreError { get; set; }

        /// <summary>
        /// Indicates whether to output a blank page when there is nothing to print.
        /// </summary>
        public virtual bool? OutputBlankPageWhenNothingToPrint { get; set; }

        /// <summary>
        /// Gets or sets the 0-based index of the first page to save.
        /// </summary>
        public virtual int? PageIndex { get; set; }

        /// <summary>
        /// Gets or sets the number of pages to save.
        /// </summary>
        public virtual int? PageCount { get; set; }

        /// <summary>
        /// Indicates which pages will not be printed.
        /// </summary>
        public virtual string PrintingPageType { get; set; }

        /// <summary>
        /// Gets or sets gridline type.
        /// </summary>
        public virtual string GridlineType { get; set; }

        /// <summary>
        /// Gets or sets displaying text type when the text width is larger than cell width.
        /// </summary>
        public virtual string TextCrossType { get; set; }

        /// <summary>
        /// Gets or sets default edit language.
        /// </summary>
        public virtual string DefaultEditLanguage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual string EmfRenderSetting { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual bool? MergeAreas { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual bool? SortExternalNames { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual bool? UpdateSmartArt { get; set; }

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
            sb.Append("class PaginatedSaveOptions {\n");
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
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
