// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="Worksheet.cs">
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
    /// Worksheet.
    /// </summary>
    public class Worksheet
    {
        /// <summary>
        /// Gets or sets Links.
        /// </summary>
        public virtual IList<Link> Links { get; set; }

        /// <summary>
        /// Indicates if the specified worksheet is displayed from right to left instead of from left to right.
        ///             Default is false.
        ///  
        /// </summary>
        public virtual bool? DisplayRightToLeft { get; set; }

        /// <summary>
        /// True if zero values are displayed.
        ///  
        /// </summary>
        public virtual bool? DisplayZeros { get; set; }

        /// <summary>
        /// Represents first visible column index.
        ///  
        /// </summary>
        public virtual int? FirstVisibleColumn { get; set; }

        /// <summary>
        /// Represents first visible row index.
        ///  
        /// </summary>
        public virtual int? FirstVisibleRow { get; set; }

        /// <summary>
        /// Gets or sets the name of the worksheet.
        ///  
        /// </summary>
        public virtual string Name { get; set; }

        /// <summary>
        /// Gets the index of sheet in the worksheet collection.
        ///  
        /// </summary>
        public virtual int? Index { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the gridlines are visible.Default is true.
        ///  
        /// </summary>
        public virtual bool? IsGridlinesVisible { get; set; }

        /// <summary>
        /// Indicates whether to show outline.
        ///  
        /// </summary>
        public virtual bool? IsOutlineShown { get; set; }

        /// <summary>
        /// Indicates whether the specified worksheet is shown in normal view or page break preview.
        ///  
        /// </summary>
        public virtual bool? IsPageBreakPreview { get; set; }

        /// <summary>
        /// Represents if the worksheet is visible.
        ///  
        /// </summary>
        public virtual bool? IsVisible { get; set; }

        /// <summary>
        /// Indicates if the worksheet is protected.
        ///  
        /// </summary>
        public virtual bool? IsProtected { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the worksheet will display row and column headers.
        ///             Default is true.
        ///  
        /// </summary>
        public virtual bool? IsRowColumnHeadersVisible { get; set; }

        /// <summary>
        /// Indicates whether the ruler is visible. This property is only applied for page break preview.
        ///  
        /// </summary>
        public virtual bool? IsRulerVisible { get; set; }

        /// <summary>
        /// Indicates whether this worksheet is selected when the workbook is opened.
        ///  
        /// </summary>
        public virtual bool? IsSelected { get; set; }

        /// <summary>
        /// Represents worksheet tab color.
        ///  
        /// </summary>
        public virtual Color TabColor { get; set; }

        /// <summary>
        /// Indicates whether the Transition Formula Entry (Lotus compatibility) option is enabled.
        ///  
        /// </summary>
        public virtual bool? TransitionEntry { get; set; }

        /// <summary>
        /// Indicates whether the Transition Formula Evaluation (Lotus compatibility) option is enabled.
        ///  
        /// </summary>
        public virtual bool? TransitionEvaluation { get; set; }

        /// <summary>
        /// Represents worksheet type.
        ///  
        /// </summary>
        public virtual string Type { get; set; }

        /// <summary>
        /// Gets and sets the view type.
        ///  
        /// </summary>
        public virtual string ViewType { get; set; }

        /// <summary>
        /// Indicates the visible state for this sheet.
        ///  
        /// </summary>
        public virtual string VisibilityType { get; set; }

        /// <summary>
        /// Represents the scaling factor in percentage. It should be between 10 and 400.
        ///  
        /// </summary>
        public virtual int? Zoom { get; set; }

        /// <summary>
        /// Gets the  collection.
        ///  
        /// </summary>
        public virtual LinkElement Cells { get; set; }

        /// <summary>
        /// Gets a  collection
        ///  
        /// </summary>
        public virtual LinkElement Charts { get; set; }

        /// <summary>
        /// Gets or sets AutoShapes.
        /// </summary>
        public virtual LinkElement AutoShapes { get; set; }

        /// <summary>
        /// Represents a collection of  in a worksheet.
        ///  
        /// </summary>
        public virtual LinkElement OleObjects { get; set; }

        /// <summary>
        /// Gets the  collection.
        ///  
        /// </summary>
        public virtual LinkElement Comments { get; set; }

        /// <summary>
        /// Gets a  collection.
        ///  
        /// </summary>
        public virtual LinkElement Pictures { get; set; }

        /// <summary>
        /// Gets or sets MergedCells.
        /// </summary>
        public virtual LinkElement MergedCells { get; set; }

        /// <summary>
        /// Gets the data validation setting collection in the worksheet.
        ///  
        /// </summary>
        public virtual LinkElement Validations { get; set; }

        /// <summary>
        /// Gets the ConditionalFormattings in the worksheet.
        ///  
        /// </summary>
        public virtual LinkElement ConditionalFormattings { get; set; }

        /// <summary>
        /// Gets the  collection.
        ///  
        /// </summary>
        public virtual LinkElement Hyperlinks { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Worksheet {\n");
            sb.Append("  Links: ").Append(this.Links).Append("\n");
            sb.Append("  DisplayRightToLeft: ").Append(this.DisplayRightToLeft).Append("\n");
            sb.Append("  DisplayZeros: ").Append(this.DisplayZeros).Append("\n");
            sb.Append("  FirstVisibleColumn: ").Append(this.FirstVisibleColumn).Append("\n");
            sb.Append("  FirstVisibleRow: ").Append(this.FirstVisibleRow).Append("\n");
            sb.Append("  Name: ").Append(this.Name).Append("\n");
            sb.Append("  Index: ").Append(this.Index).Append("\n");
            sb.Append("  IsGridlinesVisible: ").Append(this.IsGridlinesVisible).Append("\n");
            sb.Append("  IsOutlineShown: ").Append(this.IsOutlineShown).Append("\n");
            sb.Append("  IsPageBreakPreview: ").Append(this.IsPageBreakPreview).Append("\n");
            sb.Append("  IsVisible: ").Append(this.IsVisible).Append("\n");
            sb.Append("  IsProtected: ").Append(this.IsProtected).Append("\n");
            sb.Append("  IsRowColumnHeadersVisible: ").Append(this.IsRowColumnHeadersVisible).Append("\n");
            sb.Append("  IsRulerVisible: ").Append(this.IsRulerVisible).Append("\n");
            sb.Append("  IsSelected: ").Append(this.IsSelected).Append("\n");
            sb.Append("  TabColor: ").Append(this.TabColor).Append("\n");
            sb.Append("  TransitionEntry: ").Append(this.TransitionEntry).Append("\n");
            sb.Append("  TransitionEvaluation: ").Append(this.TransitionEvaluation).Append("\n");
            sb.Append("  Type: ").Append(this.Type).Append("\n");
            sb.Append("  ViewType: ").Append(this.ViewType).Append("\n");
            sb.Append("  VisibilityType: ").Append(this.VisibilityType).Append("\n");
            sb.Append("  Zoom: ").Append(this.Zoom).Append("\n");
            sb.Append("  Cells: ").Append(this.Cells).Append("\n");
            sb.Append("  Charts: ").Append(this.Charts).Append("\n");
            sb.Append("  AutoShapes: ").Append(this.AutoShapes).Append("\n");
            sb.Append("  OleObjects: ").Append(this.OleObjects).Append("\n");
            sb.Append("  Comments: ").Append(this.Comments).Append("\n");
            sb.Append("  Pictures: ").Append(this.Pictures).Append("\n");
            sb.Append("  MergedCells: ").Append(this.MergedCells).Append("\n");
            sb.Append("  Validations: ").Append(this.Validations).Append("\n");
            sb.Append("  ConditionalFormattings: ").Append(this.ConditionalFormattings).Append("\n");
            sb.Append("  Hyperlinks: ").Append(this.Hyperlinks).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
