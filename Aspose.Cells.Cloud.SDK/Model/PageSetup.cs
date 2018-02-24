// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PageSetup.cs">
//   Copyright (c) 2016 Aspose.Cells for Cloud
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
  /// excel print page setting
  /// </summary>  
  [DataContract]
  public class PageSetup 
  {                       
        /// <summary>
        /// Gets or sets Link
        /// </summary>  
		[DataMember(Name="link", EmitDefaultValue=false)]
        public Link Link { get; set; }

        /// <summary>
        /// Represents if elements of the document will be printed in black and white. True/False
        /// </summary>  
		[DataMember(Name="BlackAndWhite", EmitDefaultValue=false)]
        public bool? BlackAndWhite { get; set; }

        /// <summary>
        /// Represents the size of the bottom margin, in unit of centimeters.
        /// </summary>  
		[DataMember(Name="BottomMargin", EmitDefaultValue=false)]
        public double? BottomMargin { get; set; }

        /// <summary>
        /// Represent if the sheet is printed centered horizontally.
        /// </summary>  
		[DataMember(Name="CenterHorizontally", EmitDefaultValue=false)]
        public bool? CenterHorizontally { get; set; }

        /// <summary>
        /// Represent if the sheet is printed centered vertically.
        /// </summary>  
		[DataMember(Name="CenterVertically", EmitDefaultValue=false)]
        public bool? CenterVertically { get; set; }

        /// <summary>
        /// Represents the first page number that will be used when this sheet is printed.
        /// </summary>  
		[DataMember(Name="FirstPageNumber", EmitDefaultValue=false)]
        public int? FirstPageNumber { get; set; }

        /// <summary>
        /// Represents the number of pages tall the worksheet will be scaled to when it's printed.
        /// </summary>  
		[DataMember(Name="FitToPagesTall", EmitDefaultValue=false)]
        public int? FitToPagesTall { get; set; }

        /// <summary>
        /// Represents the number of pages wide the worksheet will be scaled to when it's printed.
        /// </summary>  
		[DataMember(Name="FitToPagesWide", EmitDefaultValue=false)]
        public int? FitToPagesWide { get; set; }

        /// <summary>
        /// Represents the distance from the bottom of the page to the footer, in unit of centimeters.
        /// </summary>  
		[DataMember(Name="FooterMargin", EmitDefaultValue=false)]
        public double? FooterMargin { get; set; }

        /// <summary>
        /// Represents the distance from the top of the page to the header, in unit of centimeters.
        /// </summary>  
		[DataMember(Name="HeaderMargin", EmitDefaultValue=false)]
        public double? HeaderMargin { get; set; }

        /// <summary>
        /// Indicates whether the first the page number is automatically assigned.
        /// </summary>  
		[DataMember(Name="IsAutoFirstPageNumber", EmitDefaultValue=false)]
        public bool? IsAutoFirstPageNumber { get; set; }

        /// <summary>
        /// Indicates whether header and footer margins are aligned with the page margins.Only applies for Excel 2007.
        /// </summary>  
		[DataMember(Name="IsHFAlignMargins", EmitDefaultValue=false)]
        public bool? IsHFAlignMargins { get; set; }

        /// <summary>
        /// True means that the header/footer of the first page is different with other pages.
        /// </summary>  
		[DataMember(Name="IsHFDiffFirst", EmitDefaultValue=false)]
        public bool? IsHFDiffFirst { get; set; }

        /// <summary>
        /// True means that the header/footer of the odd pages is different with odd pages.
        /// </summary>  
		[DataMember(Name="IsHFDiffOddEven", EmitDefaultValue=false)]
        public bool? IsHFDiffOddEven { get; set; }

        /// <summary>
        /// Indicates whether header and footer are scaled with document scaling.Only applies for Excel 2007. 
        /// </summary>  
		[DataMember(Name="IsHFScaleWithDoc", EmitDefaultValue=false)]
        public bool? IsHFScaleWithDoc { get; set; }

        /// <summary>
        /// If this property is False, the FitToPagesWide and FitToPagesTall properties control how the worksheet is scaled.
        /// </summary>  
		[DataMember(Name="IsPercentScale", EmitDefaultValue=false)]
        public bool? IsPercentScale { get; set; }

        /// <summary>
        /// Represents the size of the left margin, in unit of centimeters.
        /// </summary>  
		[DataMember(Name="LeftMargin", EmitDefaultValue=false)]
        public double? LeftMargin { get; set; }

        /// <summary>
        /// Represents the order that Microsoft Excel uses to number pages when printing a large worksheet.
        /// </summary>  
		[DataMember(Name="Order", EmitDefaultValue=false)]
        public string Order { get; set; }

        /// <summary>
        /// Represents page print orientation.
        /// </summary>  
		[DataMember(Name="Orientation", EmitDefaultValue=false)]
        public string Orientation { get; set; }

        /// <summary>
        /// Represents the size of the paper.
        /// </summary>  
		[DataMember(Name="PaperSize", EmitDefaultValue=false)]
        public string PaperSize { get; set; }

        /// <summary>
        /// Represents the range to be printed.
        /// </summary>  
		[DataMember(Name="PrintArea", EmitDefaultValue=false)]
        public string PrintArea { get; set; }

        /// <summary>
        /// Represents the way comments are printed with the sheet.
        /// </summary>  
		[DataMember(Name="PrintComments", EmitDefaultValue=false)]
        public string PrintComments { get; set; }

        /// <summary>
        /// Get and sets number of copies to print.
        /// </summary>  
		[DataMember(Name="PrintCopies", EmitDefaultValue=false)]
        public int? PrintCopies { get; set; }

        /// <summary>
        /// Represents if the sheet will be printed without graphics.
        /// </summary>  
		[DataMember(Name="PrintDraft", EmitDefaultValue=false)]
        public bool? PrintDraft { get; set; }

        /// <summary>
        /// Specifies the type of print error displayed.
        /// </summary>  
		[DataMember(Name="PrintErrors", EmitDefaultValue=false)]
        public string PrintErrors { get; set; }

        /// <summary>
        /// Represents if cell gridlines are printed on the page.
        /// </summary>  
		[DataMember(Name="PrintGridlines", EmitDefaultValue=false)]
        public bool? PrintGridlines { get; set; }

        /// <summary>
        /// Represents if row and column headings are printed with this page.
        /// </summary>  
		[DataMember(Name="PrintHeadings", EmitDefaultValue=false)]
        public bool? PrintHeadings { get; set; }

        /// <summary>
        /// Represents the print quality.
        /// </summary>  
		[DataMember(Name="PrintQuality", EmitDefaultValue=false)]
        public int? PrintQuality { get; set; }

        /// <summary>
        /// Represents the columns that contain the cells to be repeated on the left side of each page.
        /// </summary>  
		[DataMember(Name="PrintTitleColumns", EmitDefaultValue=false)]
        public string PrintTitleColumns { get; set; }

        /// <summary>
        /// Represents the rows that contain the cells to be repeated at the top of each page.
        /// </summary>  
		[DataMember(Name="PrintTitleRows", EmitDefaultValue=false)]
        public string PrintTitleRows { get; set; }

        /// <summary>
        /// Represents the size of the right margin, in unit of centimeters.
        /// </summary>  
		[DataMember(Name="RightMargin", EmitDefaultValue=false)]
        public double? RightMargin { get; set; }

        /// <summary>
        /// Represents the size of the top margin, in unit of centimeters.
        /// </summary>  
		[DataMember(Name="TopMargin", EmitDefaultValue=false)]
        public double? TopMargin { get; set; }

        /// <summary>
        /// Represents the scaling factor in percent. It should be between 10 and 400.
        /// </summary>  
		[DataMember(Name="Zoom", EmitDefaultValue=false)]
        public int? Zoom { get; set; }

        /// <summary>
        /// Represents the page header.
        /// </summary>  
		[DataMember(Name="Header", EmitDefaultValue=false)]
        public List<PageSection> Header { get; set; }

        /// <summary>
        /// Represents the page footor.
        /// </summary>  
		[DataMember(Name="Footer", EmitDefaultValue=false)]
        public List<PageSection> Footer { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class PageSetup {\n");
          sb.Append("  Link: ").Append(this.Link).Append("\n");
          sb.Append("  BlackAndWhite: ").Append(this.BlackAndWhite).Append("\n");
          sb.Append("  BottomMargin: ").Append(this.BottomMargin).Append("\n");
          sb.Append("  CenterHorizontally: ").Append(this.CenterHorizontally).Append("\n");
          sb.Append("  CenterVertically: ").Append(this.CenterVertically).Append("\n");
          sb.Append("  FirstPageNumber: ").Append(this.FirstPageNumber).Append("\n");
          sb.Append("  FitToPagesTall: ").Append(this.FitToPagesTall).Append("\n");
          sb.Append("  FitToPagesWide: ").Append(this.FitToPagesWide).Append("\n");
          sb.Append("  FooterMargin: ").Append(this.FooterMargin).Append("\n");
          sb.Append("  HeaderMargin: ").Append(this.HeaderMargin).Append("\n");
          sb.Append("  IsAutoFirstPageNumber: ").Append(this.IsAutoFirstPageNumber).Append("\n");
          sb.Append("  IsHFAlignMargins: ").Append(this.IsHFAlignMargins).Append("\n");
          sb.Append("  IsHFDiffFirst: ").Append(this.IsHFDiffFirst).Append("\n");
          sb.Append("  IsHFDiffOddEven: ").Append(this.IsHFDiffOddEven).Append("\n");
          sb.Append("  IsHFScaleWithDoc: ").Append(this.IsHFScaleWithDoc).Append("\n");
          sb.Append("  IsPercentScale: ").Append(this.IsPercentScale).Append("\n");
          sb.Append("  LeftMargin: ").Append(this.LeftMargin).Append("\n");
          sb.Append("  Order: ").Append(this.Order).Append("\n");
          sb.Append("  Orientation: ").Append(this.Orientation).Append("\n");
          sb.Append("  PaperSize: ").Append(this.PaperSize).Append("\n");
          sb.Append("  PrintArea: ").Append(this.PrintArea).Append("\n");
          sb.Append("  PrintComments: ").Append(this.PrintComments).Append("\n");
          sb.Append("  PrintCopies: ").Append(this.PrintCopies).Append("\n");
          sb.Append("  PrintDraft: ").Append(this.PrintDraft).Append("\n");
          sb.Append("  PrintErrors: ").Append(this.PrintErrors).Append("\n");
          sb.Append("  PrintGridlines: ").Append(this.PrintGridlines).Append("\n");
          sb.Append("  PrintHeadings: ").Append(this.PrintHeadings).Append("\n");
          sb.Append("  PrintQuality: ").Append(this.PrintQuality).Append("\n");
          sb.Append("  PrintTitleColumns: ").Append(this.PrintTitleColumns).Append("\n");
          sb.Append("  PrintTitleRows: ").Append(this.PrintTitleRows).Append("\n");
          sb.Append("  RightMargin: ").Append(this.RightMargin).Append("\n");
          sb.Append("  TopMargin: ").Append(this.TopMargin).Append("\n");
          sb.Append("  Zoom: ").Append(this.Zoom).Append("\n");
          sb.Append("  Header: ").Append(this.Header).Append("\n");
          sb.Append("  Footer: ").Append(this.Footer).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
