// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="Worksheet.cs">
//   Copyright (c) 2021 Aspose.Cells Cloud
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
  public class Worksheet 
  {                       
        /// <summary>
        /// Gets the index of sheet in the worksheets collection.             
        /// </summary>  
		[DataMember(Name="Index", EmitDefaultValue=false)]
        public int? Index { get; set; }

        /// <summary>
        /// Gets or sets Pictures
        /// </summary>  
		[DataMember(Name="Pictures", EmitDefaultValue=false)]
        public LinkElement Pictures { get; set; }

        /// <summary>
        /// Gets or sets Charts
        /// </summary>  
		[DataMember(Name="Charts", EmitDefaultValue=false)]
        public LinkElement Charts { get; set; }

        /// <summary>
        /// Gets or sets Comments
        /// </summary>  
		[DataMember(Name="Comments", EmitDefaultValue=false)]
        public LinkElement Comments { get; set; }

        /// <summary>
        /// Gets or sets Hyperlinks
        /// </summary>  
		[DataMember(Name="Hyperlinks", EmitDefaultValue=false)]
        public LinkElement Hyperlinks { get; set; }

        /// <summary>
        /// Represents if the worksheet is visible.             
        /// </summary>  
		[DataMember(Name="IsVisible", EmitDefaultValue=false)]
        public bool? IsVisible { get; set; }

        /// <summary>
        /// Gets and sets the view type.
        /// </summary>  
		[DataMember(Name="ViewType", EmitDefaultValue=false)]
        public string ViewType { get; set; }

        /// <summary>
        /// Represents worksheet type
        /// </summary>  
		[DataMember(Name="Type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the gridelines are visible.Default     is true.
        /// </summary>  
		[DataMember(Name="IsGridlinesVisible", EmitDefaultValue=false)]
        public bool? IsGridlinesVisible { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the worksheet will display row and column headers.Default is true.             
        /// </summary>  
		[DataMember(Name="IsRowColumnHeadersVisible", EmitDefaultValue=false)]
        public bool? IsRowColumnHeadersVisible { get; set; }

        /// <summary>
        /// Indications the specified worksheet is shown in normal view or page break preview.
        /// </summary>  
		[DataMember(Name="IsPageBreakPreview", EmitDefaultValue=false)]
        public bool? IsPageBreakPreview { get; set; }

        /// <summary>
        /// True if zero values are displayed.
        /// </summary>  
		[DataMember(Name="DisplayZeros", EmitDefaultValue=false)]
        public bool? DisplayZeros { get; set; }

        /// <summary>
        /// Flag indicating whether the Transition Formula Evaluation (Lotus compatibility) option is enabled.             
        /// </summary>  
		[DataMember(Name="TransitionEvaluation", EmitDefaultValue=false)]
        public bool? TransitionEvaluation { get; set; }

        /// <summary>
        /// Indicates if the specified worksheet is displayed from right to left instead    of from left to right.  Default is false.             
        /// </summary>  
		[DataMember(Name="DisplayRightToLeft", EmitDefaultValue=false)]
        public bool? DisplayRightToLeft { get; set; }

        /// <summary>
        /// Represents first visible column index.
        /// </summary>  
		[DataMember(Name="FirstVisibleColumn", EmitDefaultValue=false)]
        public int? FirstVisibleColumn { get; set; }

        /// <summary>
        /// Gets or sets OleObjects
        /// </summary>  
		[DataMember(Name="OleObjects", EmitDefaultValue=false)]
        public LinkElement OleObjects { get; set; }

        /// <summary>
        /// Indicates whether show outline.             
        /// </summary>  
		[DataMember(Name="IsOutlineShown", EmitDefaultValue=false)]
        public bool? IsOutlineShown { get; set; }

        /// <summary>
        /// Gets or sets the name of the worksheet.             
        /// </summary>  
		[DataMember(Name="Name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets AutoShapes
        /// </summary>  
		[DataMember(Name="AutoShapes", EmitDefaultValue=false)]
        public LinkElement AutoShapes { get; set; }

        /// <summary>
        /// Gets or sets Cells
        /// </summary>  
		[DataMember(Name="Cells", EmitDefaultValue=false)]
        public LinkElement Cells { get; set; }

        /// <summary>
        /// Gets or sets Validations
        /// </summary>  
		[DataMember(Name="Validations", EmitDefaultValue=false)]
        public LinkElement Validations { get; set; }

        /// <summary>
        /// Represents the scaling factor in percent. It should be btween 10 and 400.             
        /// </summary>  
		[DataMember(Name="Zoom", EmitDefaultValue=false)]
        public int? Zoom { get; set; }

        /// <summary>
        /// Gets or sets ConditionalFormattings
        /// </summary>  
		[DataMember(Name="ConditionalFormattings", EmitDefaultValue=false)]
        public LinkElement ConditionalFormattings { get; set; }

        /// <summary>
        /// Indicates whether this worksheet is selected when the workbook is opened.
        /// </summary>  
		[DataMember(Name="IsSelected", EmitDefaultValue=false)]
        public bool? IsSelected { get; set; }

        /// <summary>
        /// Represents worksheet tab color.
        /// </summary>  
		[DataMember(Name="TabColor", EmitDefaultValue=false)]
        public Color TabColor { get; set; }

        /// <summary>
        /// Represents first visible row index.             
        /// </summary>  
		[DataMember(Name="FirstVisibleRow", EmitDefaultValue=false)]
        public int? FirstVisibleRow { get; set; }

        /// <summary>
        /// Flag indicating whether the Transition Formula Entry (Lotus compatibility) option is enabled.
        /// </summary>  
		[DataMember(Name="TransitionEntry", EmitDefaultValue=false)]
        public bool? TransitionEntry { get; set; }

        /// <summary>
        /// Indicates the state for this sheet visibility             
        /// </summary>  
		[DataMember(Name="VisibilityType", EmitDefaultValue=false)]
        public string VisibilityType { get; set; }

        /// <summary>
        /// Indicates whether the ruler is visible. Only apply for page break preview.
        /// </summary>  
		[DataMember(Name="IsRulerVisible", EmitDefaultValue=false)]
        public bool? IsRulerVisible { get; set; }

        /// <summary>
        /// Gets or sets Links
        /// </summary>  
		[DataMember(Name="Links", EmitDefaultValue=false)]
        public List<Link> Links { get; set; }

        /// <summary>
        /// Indicates if the worksheet is protected.
        /// </summary>  
		[DataMember(Name="IsProtected", EmitDefaultValue=false)]
        public bool? IsProtected { get; set; }

        /// <summary>
        /// Gets or sets MergedCells
        /// </summary>  
		[DataMember(Name="MergedCells", EmitDefaultValue=false)]
        public LinkElement MergedCells { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class Worksheet {\n");
          sb.Append("  Index: ").Append(this.Index).Append("\n");
          sb.Append("  Pictures: ").Append(this.Pictures).Append("\n");
          sb.Append("  Charts: ").Append(this.Charts).Append("\n");
          sb.Append("  Comments: ").Append(this.Comments).Append("\n");
          sb.Append("  Hyperlinks: ").Append(this.Hyperlinks).Append("\n");
          sb.Append("  IsVisible: ").Append(this.IsVisible).Append("\n");
          sb.Append("  ViewType: ").Append(this.ViewType).Append("\n");
          sb.Append("  Type: ").Append(this.Type).Append("\n");
          sb.Append("  IsGridlinesVisible: ").Append(this.IsGridlinesVisible).Append("\n");
          sb.Append("  IsRowColumnHeadersVisible: ").Append(this.IsRowColumnHeadersVisible).Append("\n");
          sb.Append("  IsPageBreakPreview: ").Append(this.IsPageBreakPreview).Append("\n");
          sb.Append("  DisplayZeros: ").Append(this.DisplayZeros).Append("\n");
          sb.Append("  TransitionEvaluation: ").Append(this.TransitionEvaluation).Append("\n");
          sb.Append("  DisplayRightToLeft: ").Append(this.DisplayRightToLeft).Append("\n");
          sb.Append("  FirstVisibleColumn: ").Append(this.FirstVisibleColumn).Append("\n");
          sb.Append("  OleObjects: ").Append(this.OleObjects).Append("\n");
          sb.Append("  IsOutlineShown: ").Append(this.IsOutlineShown).Append("\n");
          sb.Append("  Name: ").Append(this.Name).Append("\n");
          sb.Append("  AutoShapes: ").Append(this.AutoShapes).Append("\n");
          sb.Append("  Cells: ").Append(this.Cells).Append("\n");
          sb.Append("  Validations: ").Append(this.Validations).Append("\n");
          sb.Append("  Zoom: ").Append(this.Zoom).Append("\n");
          sb.Append("  ConditionalFormattings: ").Append(this.ConditionalFormattings).Append("\n");
          sb.Append("  IsSelected: ").Append(this.IsSelected).Append("\n");
          sb.Append("  TabColor: ").Append(this.TabColor).Append("\n");
          sb.Append("  FirstVisibleRow: ").Append(this.FirstVisibleRow).Append("\n");
          sb.Append("  TransitionEntry: ").Append(this.TransitionEntry).Append("\n");
          sb.Append("  VisibilityType: ").Append(this.VisibilityType).Append("\n");
          sb.Append("  IsRulerVisible: ").Append(this.IsRulerVisible).Append("\n");
          sb.Append("  Links: ").Append(this.Links).Append("\n");
          sb.Append("  IsProtected: ").Append(this.IsProtected).Append("\n");
          sb.Append("  MergedCells: ").Append(this.MergedCells).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
