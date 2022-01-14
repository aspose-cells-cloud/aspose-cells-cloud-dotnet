// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="HtmlSaveOptions.cs">
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
  public class HtmlSaveOptions : SaveOptions 
  {                       
        /// <summary>
        /// Gets or sets SaveAsSingleFile
        /// </summary>  
		[DataMember(Name="SaveAsSingleFile", EmitDefaultValue=false)]
        public string SaveAsSingleFile { get; set; }

        /// <summary>
        /// Gets or sets ExportHiddenWorksheet
        /// </summary>  
		[DataMember(Name="ExportHiddenWorksheet", EmitDefaultValue=false)]
        public string ExportHiddenWorksheet { get; set; }

        /// <summary>
        /// Gets or sets ExportGridLines
        /// </summary>  
		[DataMember(Name="ExportGridLines", EmitDefaultValue=false)]
        public string ExportGridLines { get; set; }

        /// <summary>
        /// Gets or sets PresentationPreference
        /// </summary>  
		[DataMember(Name="PresentationPreference", EmitDefaultValue=false)]
        public string PresentationPreference { get; set; }

        /// <summary>
        /// Gets or sets CellCssPrefix
        /// </summary>  
		[DataMember(Name="CellCssPrefix", EmitDefaultValue=false)]
        public string CellCssPrefix { get; set; }

        /// <summary>
        /// Gets or sets TableCssId
        /// </summary>  
		[DataMember(Name="TableCssId", EmitDefaultValue=false)]
        public string TableCssId { get; set; }

        /// <summary>
        /// Gets or sets IsFullPathLink
        /// </summary>  
		[DataMember(Name="IsFullPathLink", EmitDefaultValue=false)]
        public string IsFullPathLink { get; set; }

        /// <summary>
        /// Gets or sets ExportWorksheetCSSSeparately
        /// </summary>  
		[DataMember(Name="ExportWorksheetCSSSeparately", EmitDefaultValue=false)]
        public string ExportWorksheetCSSSeparately { get; set; }

        /// <summary>
        /// Gets or sets ExportSimilarBorderStyle
        /// </summary>  
		[DataMember(Name="ExportSimilarBorderStyle", EmitDefaultValue=false)]
        public string ExportSimilarBorderStyle { get; set; }

        /// <summary>
        /// Gets or sets MergeEmptyTdForcely
        /// </summary>  
		[DataMember(Name="MergeEmptyTdForcely", EmitDefaultValue=false)]
        public string MergeEmptyTdForcely { get; set; }

        /// <summary>
        /// Gets or sets ExportCellCoordinate
        /// </summary>  
		[DataMember(Name="ExportCellCoordinate", EmitDefaultValue=false)]
        public string ExportCellCoordinate { get; set; }

        /// <summary>
        /// Gets or sets ExportExtraHeadings
        /// </summary>  
		[DataMember(Name="ExportExtraHeadings", EmitDefaultValue=false)]
        public string ExportExtraHeadings { get; set; }

        /// <summary>
        /// Gets or sets ExportHeadings
        /// </summary>  
		[DataMember(Name="ExportHeadings", EmitDefaultValue=false)]
        public string ExportHeadings { get; set; }

        /// <summary>
        /// Gets or sets ExportFormula
        /// </summary>  
		[DataMember(Name="ExportFormula", EmitDefaultValue=false)]
        public string ExportFormula { get; set; }

        /// <summary>
        /// Gets or sets AddTooltipText
        /// </summary>  
		[DataMember(Name="AddTooltipText", EmitDefaultValue=false)]
        public string AddTooltipText { get; set; }

        /// <summary>
        /// Gets or sets ExportBogusRowData
        /// </summary>  
		[DataMember(Name="ExportBogusRowData", EmitDefaultValue=false)]
        public string ExportBogusRowData { get; set; }

        /// <summary>
        /// Gets or sets ExcludeUnusedStyles
        /// </summary>  
		[DataMember(Name="ExcludeUnusedStyles", EmitDefaultValue=false)]
        public string ExcludeUnusedStyles { get; set; }

        /// <summary>
        /// Gets or sets ExportDocumentProperties
        /// </summary>  
		[DataMember(Name="ExportDocumentProperties", EmitDefaultValue=false)]
        public string ExportDocumentProperties { get; set; }

        /// <summary>
        /// Gets or sets ExportWorksheetProperties
        /// </summary>  
		[DataMember(Name="ExportWorksheetProperties", EmitDefaultValue=false)]
        public string ExportWorksheetProperties { get; set; }

        /// <summary>
        /// Gets or sets ExportWorkbookProperties
        /// </summary>  
		[DataMember(Name="ExportWorkbookProperties", EmitDefaultValue=false)]
        public string ExportWorkbookProperties { get; set; }

        /// <summary>
        /// Gets or sets ExportFrameScriptsAndProperties
        /// </summary>  
		[DataMember(Name="ExportFrameScriptsAndProperties", EmitDefaultValue=false)]
        public string ExportFrameScriptsAndProperties { get; set; }

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
          sb.Append("class HtmlSaveOptions {\n");
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
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
