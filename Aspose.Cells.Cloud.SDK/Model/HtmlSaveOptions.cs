// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="HtmlSaveOptions.cs">
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
    /// Represents options of saving .html file.
    /// </summary>
    public class HtmlSaveOptions : SaveOptions
    {
        /// <summary>
        /// Gets or sets ExportPageHeaders.
        /// </summary>
        public virtual bool? ExportPageHeaders { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual bool? ExportPageFooters { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual bool? ExportRowColumnHeadings { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual bool? ShowAllSheets { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual ImageOrPrintOptions ImageOptions { get; set; }

        /// <summary>
        /// Indicates whether save the html as single file. The default value is false.
        /// </summary>
        public virtual bool? SaveAsSingleFile { get; set; }

        /// <summary>
        /// Indicates whether save the html as single file. The default value is false.
        /// </summary>
        public virtual bool? ExportHiddenWorksheet { get; set; }

        /// <summary>
        /// Indicating whether exporting the gridlines.The default value is false.
        /// </summary>
        public virtual bool? ExportGridLines { get; set; }

        /// <summary>
        /// Indicating if html or mht file is presentation preference.The default value is
        ///              false.if you want to get more beautiful presentation,please set the value to
        ///                 true.
        /// </summary>
        public virtual bool? PresentationPreference { get; set; }

        /// <summary>
        /// Gets and sets the prefix of the css name,the default value is "".
        /// </summary>
        public virtual string CellCssPrefix { get; set; }

        /// <summary>
        /// Gets and sets the prefix of the type css name such as tr,col,td and so on, they
        ///                 are contained in the table element which has the specific TableCssId attribute.
        ///                 The default value is "".
        /// </summary>
        public virtual string TableCssId { get; set; }

        /// <summary>
        /// Indicating whether using full path link in sheet00x.htm,filelist.xml and tabstrip.htm.
        ///                 The default value is false.
        /// </summary>
        public virtual bool? IsFullPathLink { get; set; }

        /// <summary>
        /// Indicating whether export the worksheet css separately.The default value is false.
        /// </summary>
        public virtual bool? ExportWorksheetCSSSeparately { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual bool? ExportSimilarBorderStyle { get; set; }

        /// <summary>
        /// Indicates whether merging empty TD element forcely when exporting file to html.
        ///                 The size of html file will be reduced significantly after setting value to true.
        ///                 The default value is false. If you want to import the html file to excel or export
        ///                 perfect grid lines when saving file to html, please keep the default value.
        /// </summary>
        public virtual bool? MergeEmptyTdForcely { get; set; }

        /// <summary>
        /// Indicates whether exporting excel coordinate of nonblank cells when saving file
        ///                 to html. The default value is false. If you want to import the output html to
        ///                 excel, please keep the default value.
        /// </summary>
        public virtual bool? ExportCellCoordinate { get; set; }

        /// <summary>
        /// Indicates whether exporting extra headings when the length of text is longer
        ///                 than max display column. The default value is false. If you want to import the
        ///                 html file to excel, please keep the default value.
        /// </summary>
        public virtual bool? ExportExtraHeadings { get; set; }

        /// <summary>
        /// Indicates whether exporting headings when saving file to html.The default value
        ///                 is false. If you want to import the html file to excel, please keep the default
        ///                 value.
        /// </summary>
        public virtual bool? ExportHeadings { get; set; }

        /// <summary>
        /// Indicates whether exporting formula when saving file to html. The default value
        ///                 is true. If you want to import the output html to excel, please keep the default
        ///                 value
        /// </summary>
        public virtual bool? ExportFormula { get; set; }

        /// <summary>
        /// Indicates whether adding tooltip text when the data can't be fully displayed.
        /// </summary>
        public virtual bool? AddTooltipText { get; set; }

        /// <summary>
        /// Indicating whether exporting bogus bottom row data. The default value is true.If you want to import the html or mht file to excel, please keep the default value.
        /// </summary>
        public virtual bool? ExportBogusRowData { get; set; }

        /// <summary>
        /// Indicating whether excluding unused styles.The default value is false.If you  want to import the html or mht file to excel, please keep the default value.
        /// </summary>
        public virtual bool? ExcludeUnusedStyles { get; set; }

        /// <summary>
        /// Indicating whether exporting document properties.The default value is true.If  you want to import the html or mht file to excel, please keep the default value.
        /// </summary>
        public virtual bool? ExportDocumentProperties { get; set; }

        /// <summary>
        /// Indicating whether exporting worksheet properties.The default value is true.If  you want to import the html or mht file to excel, please keep the default value.
        /// </summary>
        public virtual bool? ExportWorksheetProperties { get; set; }

        /// <summary>
        /// Indicating whether exporting workbook properties.The default value is true.If  you want to import the html or mht file to excel, please keep the default value.
        /// </summary>
        public virtual bool? ExportWorkbookProperties { get; set; }

        /// <summary>
        /// Indicating whether exporting frame scripts and document properties. The default  value is true.If you want to import the html or mht file to excel, please keep the default value.
        /// </summary>
        public virtual bool? ExportFrameScriptsAndProperties { get; set; }

        /// <summary>
        /// The directory that the attached files will be saved to.  Only for saving to html stream.
        /// </summary>
        public virtual string AttachedFilesDirectory { get; set; }

        /// <summary>
        /// Specify the Url prefix of attached files such as image in the html file. Only for saving to html stream.
        /// </summary>
        public virtual string AttachedFilesUrlPrefix { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual string Encoding { get; set; }

        /// <summary>
        /// Indicates if exporting the whole workbook to html file.
        /// </summary>
        public virtual bool? ExportActiveWorksheetOnly { get; set; }

        /// <summary>
        /// Get or set the format of chart image before exporting
        /// </summary>
        public virtual string ExportChartImageFormat { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual bool? ExportImagesAsBase64 { get; set; }

        /// <summary>
        /// Hidden column(the width of this column is 0) in excel,before save this into
        ///                html format, if HtmlHiddenColDisplayType is "Remove",the hidden column would
        ///                ont been output, if the value is "Hidden", the column would been output,but was hidden,the default value is "Hidden"
        /// </summary>
        public virtual string HiddenColDisplayType { get; set; }

        /// <summary>
        /// Hidden row(the height of this row is 0) in excel,before save this into html
        ///                format, if HtmlHiddenRowDisplayType is "Remove",the hidden row would ont
        ///                been output, if the value is "Hidden", the row would been output,but was
        ///                hidden,the default value is "Hidden"
        /// </summary>
        public virtual string HiddenRowDisplayType { get; set; }

        /// <summary>
        /// Indicates if a cross-cell string will be displayed in the same way as MS
        ///                Excel when saving an Excel file in html format.  By default the value is
        ///                Default, so, for cross-cell strings, there is little difference between the
        ///                html files created by Aspose.Cells and MS Excel. But the performance for
        ///                creating large html files,setting the value to Cross would be several times
        ///                faster than setting it to Default or Fit2Cell.
        /// </summary>
        public virtual string HtmlCrossStringType { get; set; }

        /// <summary>
        /// Indicates if export image files to temp directory.  Only for saving to html  stream.
        /// </summary>
        public virtual bool? IsExpImageToTempDir { get; set; }

        /// <summary>
        /// The title of the html page.  Only for saving to html stream.
        /// </summary>
        public virtual string PageTitle { get; set; }

        /// <summary>
        /// Parse html tag in cell,like ,as cell value,or as html tag,default is true
        /// </summary>
        public virtual bool? ParseHtmlTagInCell { get; set; }

        /// <summary>
        /// Gets or sets CellNameAttribute.
        /// </summary>
        public virtual string CellNameAttribute { get; set; }

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
            sb.Append("class HtmlSaveOptions {\n");
            sb.Append("  ExportPageHeaders: ").Append(this.ExportPageHeaders).Append("\n");
            sb.Append("  ExportPageFooters: ").Append(this.ExportPageFooters).Append("\n");
            sb.Append("  ExportRowColumnHeadings: ").Append(this.ExportRowColumnHeadings).Append("\n");
            sb.Append("  ShowAllSheets: ").Append(this.ShowAllSheets).Append("\n");
            sb.Append("  ImageOptions: ").Append(this.ImageOptions).Append("\n");
            sb.Append("  SaveAsSingleFile: ").Append(this.SaveAsSingleFile).Append("\n");
            sb.Append("  ExportHiddenWorksheet: ").Append(this.ExportHiddenWorksheet).Append("\n");
            sb.Append("  ExportGridLines: ").Append(this.ExportGridLines).Append("\n");
            sb.Append("  PresentationPreference: ").Append(this.PresentationPreference).Append("\n");
            sb.Append("  CellCssPrefix: ").Append(this.CellCssPrefix).Append("\n");
            sb.Append("  TableCssId: ").Append(this.TableCssId).Append("\n");
            sb.Append("  IsFullPathLink: ").Append(this.IsFullPathLink).Append("\n");
            sb.Append("  ExportWorksheetCSSSeparately: ").Append(this.ExportWorksheetCSSSeparately).Append("\n");
            sb.Append("  ExportSimilarBorderStyle: ").Append(this.ExportSimilarBorderStyle).Append("\n");
            sb.Append("  MergeEmptyTdForcely: ").Append(this.MergeEmptyTdForcely).Append("\n");
            sb.Append("  ExportCellCoordinate: ").Append(this.ExportCellCoordinate).Append("\n");
            sb.Append("  ExportExtraHeadings: ").Append(this.ExportExtraHeadings).Append("\n");
            sb.Append("  ExportHeadings: ").Append(this.ExportHeadings).Append("\n");
            sb.Append("  ExportFormula: ").Append(this.ExportFormula).Append("\n");
            sb.Append("  AddTooltipText: ").Append(this.AddTooltipText).Append("\n");
            sb.Append("  ExportBogusRowData: ").Append(this.ExportBogusRowData).Append("\n");
            sb.Append("  ExcludeUnusedStyles: ").Append(this.ExcludeUnusedStyles).Append("\n");
            sb.Append("  ExportDocumentProperties: ").Append(this.ExportDocumentProperties).Append("\n");
            sb.Append("  ExportWorksheetProperties: ").Append(this.ExportWorksheetProperties).Append("\n");
            sb.Append("  ExportWorkbookProperties: ").Append(this.ExportWorkbookProperties).Append("\n");
            sb.Append("  ExportFrameScriptsAndProperties: ").Append(this.ExportFrameScriptsAndProperties).Append("\n");
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
            sb.Append("  CellNameAttribute: ").Append(this.CellNameAttribute).Append("\n");
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
