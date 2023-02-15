// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PageSetup.cs">
//   Copyright (c) 2023 Aspose.Cells Cloud
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
    /// PageSetup.
    /// </summary>
    public class PageSetup : LinkElement
    {
        /// <summary>
        /// Gets or sets BlackAndWhite.
        /// </summary>
        public virtual bool? BlackAndWhite { get; set; }

        /// <summary>
        /// Gets or sets BottomMargin.
        /// </summary>
        public virtual double? BottomMargin { get; set; }

        /// <summary>
        /// Gets or sets CenterHorizontally.
        /// </summary>
        public virtual bool? CenterHorizontally { get; set; }

        /// <summary>
        /// Gets or sets CenterVertically.
        /// </summary>
        public virtual bool? CenterVertically { get; set; }

        /// <summary>
        /// Gets or sets FirstPageNumber.
        /// </summary>
        public virtual int? FirstPageNumber { get; set; }

        /// <summary>
        /// Gets or sets FitToPagesTall.
        /// </summary>
        public virtual int? FitToPagesTall { get; set; }

        /// <summary>
        /// Gets or sets FitToPagesWide.
        /// </summary>
        public virtual int? FitToPagesWide { get; set; }

        /// <summary>
        /// Gets or sets FooterMargin.
        /// </summary>
        public virtual double? FooterMargin { get; set; }

        /// <summary>
        /// Gets or sets HeaderMargin.
        /// </summary>
        public virtual double? HeaderMargin { get; set; }

        /// <summary>
        /// Gets or sets IsAutoFirstPageNumber.
        /// </summary>
        public virtual bool? IsAutoFirstPageNumber { get; set; }

        /// <summary>
        /// Gets or sets IsHFAlignMargins.
        /// </summary>
        public virtual bool? IsHFAlignMargins { get; set; }

        /// <summary>
        /// Gets or sets IsHFDiffFirst.
        /// </summary>
        public virtual bool? IsHFDiffFirst { get; set; }

        /// <summary>
        /// Gets or sets IsHFDiffOddEven.
        /// </summary>
        public virtual bool? IsHFDiffOddEven { get; set; }

        /// <summary>
        /// Gets or sets IsHFScaleWithDoc.
        /// </summary>
        public virtual bool? IsHFScaleWithDoc { get; set; }

        /// <summary>
        /// Gets or sets IsPercentScale.
        /// </summary>
        public virtual bool? IsPercentScale { get; set; }

        /// <summary>
        /// Gets or sets LeftMargin.
        /// </summary>
        public virtual double? LeftMargin { get; set; }

        /// <summary>
        /// Gets or sets Order.
        /// </summary>
        public virtual string Order { get; set; }

        /// <summary>
        /// Gets or sets Orientation.
        /// </summary>
        public virtual string Orientation { get; set; }

        /// <summary>
        /// Gets or sets PaperSize.
        /// </summary>
        public virtual string PaperSize { get; set; }

        /// <summary>
        /// Gets or sets PrintArea.
        /// </summary>
        public virtual string PrintArea { get; set; }

        /// <summary>
        /// Gets or sets PrintComments.
        /// </summary>
        public virtual string PrintComments { get; set; }

        /// <summary>
        /// Gets or sets PrintCopies.
        /// </summary>
        public virtual int? PrintCopies { get; set; }

        /// <summary>
        /// Gets or sets PrintDraft.
        /// </summary>
        public virtual bool? PrintDraft { get; set; }

        /// <summary>
        /// Gets or sets PrintErrors.
        /// </summary>
        public virtual string PrintErrors { get; set; }

        /// <summary>
        /// Gets or sets PrintGridlines.
        /// </summary>
        public virtual bool? PrintGridlines { get; set; }

        /// <summary>
        /// Gets or sets PrintHeadings.
        /// </summary>
        public virtual bool? PrintHeadings { get; set; }

        /// <summary>
        /// Gets or sets PrintQuality.
        /// </summary>
        public virtual int? PrintQuality { get; set; }

        /// <summary>
        /// Gets or sets PrintTitleColumns.
        /// </summary>
        public virtual string PrintTitleColumns { get; set; }

        /// <summary>
        /// Gets or sets PrintTitleRows.
        /// </summary>
        public virtual string PrintTitleRows { get; set; }

        /// <summary>
        /// Gets or sets RightMargin.
        /// </summary>
        public virtual double? RightMargin { get; set; }

        /// <summary>
        /// Gets or sets TopMargin.
        /// </summary>
        public virtual double? TopMargin { get; set; }

        /// <summary>
        /// Gets or sets Zoom.
        /// </summary>
        public virtual int? Zoom { get; set; }

        /// <summary>
        /// Gets or sets Header.
        /// </summary>
        public virtual IList<PageSection> Header { get; set; }

        /// <summary>
        /// Gets or sets Footer.
        /// </summary>
        public virtual IList<PageSection> Footer { get; set; }

        /// <summary>
        /// Gets or sets link.
        /// </summary>
        public override Link link { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PageSetup {\n");
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
            sb.Append("  link: ").Append(this.link).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
