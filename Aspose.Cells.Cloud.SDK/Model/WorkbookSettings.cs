// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="WorkbookSettings.cs">
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
  public class WorkbookSettings 
  {                       
        /// <summary>
        /// Gets or sets NumberGroupSeparator
        /// </summary>  
		[DataMember(Name="NumberGroupSeparator", EmitDefaultValue=false)]
        public string NumberGroupSeparator { get; set; }

        /// <summary>
        /// Gets or sets HidePivotFieldList
        /// </summary>  
		[DataMember(Name="HidePivotFieldList", EmitDefaultValue=false)]
        public bool? HidePivotFieldList { get; set; }

        /// <summary>
        /// Represents whether the generated spreadsheet will be opened Minimized.             
        /// </summary>  
		[DataMember(Name="IsMinimized", EmitDefaultValue=false)]
        public bool? IsMinimized { get; set; }

        /// <summary>
        /// Specifies the version of the calculation engine used to calculate values in the workbook.             
        /// </summary>  
		[DataMember(Name="CalculationId", EmitDefaultValue=false)]
        public string CalculationId { get; set; }

        /// <summary>
        /// Indicates whether re-calculate all formulas on opening file.             
        /// </summary>  
		[DataMember(Name="ReCalculateOnOpen", EmitDefaultValue=false)]
        public bool? ReCalculateOnOpen { get; set; }

        /// <summary>
        /// Whether check restriction of excel file when user modify cells related objects.  For example, excel does not allow inputting string value longer than 32K.  When you input a value longer than 32K such as by Cell.PutValue(string), if this property is true, you will get an Exception.  If this property is false, we will accept your input string value as the cell's value so that later you can output the complete string value for other file formats such as CSV.  However, if you have set such kind of value that is invalid for excel file format, you should not save the workbook as excel file format later. Otherwise there may be unexpected error for the generated excel file.             
        /// </summary>  
		[DataMember(Name="CheckExcelRestriction", EmitDefaultValue=false)]
        public bool? CheckExcelRestriction { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the generated spreadsheet will contain a horizontal scroll bar.                           Remarks: The default value is true.              
        /// </summary>  
		[DataMember(Name="IsHScrollBarVisible", EmitDefaultValue=false)]
        public bool? IsHScrollBarVisible { get; set; }

        /// <summary>
        /// The height of the window, in unit of point.             
        /// </summary>  
		[DataMember(Name="WindowHeight", EmitDefaultValue=false)]
        public double? WindowHeight { get; set; }

        /// <summary>
        /// The distance from the left edge of the client area to the left edge of the window, in unit of point.             
        /// </summary>  
		[DataMember(Name="WindowLeft", EmitDefaultValue=false)]
        public double? WindowLeft { get; set; }

        /// <summary>
        /// Specifies the stack size for calculating cells recursively.  The large value for this size will give better performance when there are lots of cells need to be calculated recursively.  On the other hand, larger value will raise the stakes of StackOverflowException.  If use gets StackOverflowException when calculating formulas, this value should be decreased.             
        /// </summary>  
		[DataMember(Name="CalcStackSize", EmitDefaultValue=false)]
        public int? CalcStackSize { get; set; }

        /// <summary>
        /// Gets or sets a value that indicates whether the Workbook is shared.                           Remarks: The default value is false.              
        /// </summary>  
		[DataMember(Name="Shared", EmitDefaultValue=false)]
        public bool? Shared { get; set; }

        /// <summary>
        /// Gets or sets RemovePersonalInformation
        /// </summary>  
		[DataMember(Name="RemovePersonalInformation", EmitDefaultValue=false)]
        public bool? RemovePersonalInformation { get; set; }

        /// <summary>
        /// Gets or sets the user interface language of the Workbook version based on CountryCode that has saved the file.             
        /// </summary>  
		[DataMember(Name="LanguageCode", EmitDefaultValue=false)]
        public string LanguageCode { get; set; }

        /// <summary>
        /// Gets or sets EnableMacros
        /// </summary>  
		[DataMember(Name="EnableMacros", EmitDefaultValue=false)]
        public bool? EnableMacros { get; set; }

        /// <summary>
        /// Gets or sets IsDefaultEncrypted
        /// </summary>  
		[DataMember(Name="IsDefaultEncrypted", EmitDefaultValue=false)]
        public bool? IsDefaultEncrypted { get; set; }

        /// <summary>
        /// Indicates whether to recalculate before saving the document.             
        /// </summary>  
		[DataMember(Name="RecalculateBeforeSave", EmitDefaultValue=false)]
        public bool? RecalculateBeforeSave { get; set; }

        /// <summary>
        /// Indicates whether parsing the formula when reading the file.                           Remarks: Only applies for Excel Xlsx,Xltx, Xltm,Xlsm file because the formulas in the files are stored with a string formula.              
        /// </summary>  
		[DataMember(Name="ParsingFormulaOnOpen", EmitDefaultValue=false)]
        public bool? ParsingFormulaOnOpen { get; set; }

        /// <summary>
        /// The distance from the top edge of the client area to the top edge of the window, in unit of point.             
        /// </summary>  
		[DataMember(Name="WindowTop", EmitDefaultValue=false)]
        public double? WindowTop { get; set; }

        /// <summary>
        /// Gets or sets the system regional settings based on CountryCode at the time the file was saved.                           Remarks: If you do not want to use the region saved in the file, please reset it after reading the file.              
        /// </summary>  
		[DataMember(Name="Region", EmitDefaultValue=false)]
        public string Region { get; set; }

        /// <summary>
        /// Gets or sets MemorySetting
        /// </summary>  
		[DataMember(Name="MemorySetting", EmitDefaultValue=false)]
        public string MemorySetting { get; set; }

        /// <summary>
        /// Indicates whether update adjacent cells' border.                           Remarks: The default value is true.  For example: the bottom border of the cell A1 is update, the top border of the cell A2 should be changed too.              
        /// </summary>  
		[DataMember(Name="UpdateAdjacentCellsBorder", EmitDefaultValue=false)]
        public bool? UpdateAdjacentCellsBorder { get; set; }

        /// <summary>
        /// Gets or sets CrashSave
        /// </summary>  
		[DataMember(Name="CrashSave", EmitDefaultValue=false)]
        public bool? CrashSave { get; set; }

        /// <summary>
        /// Get or sets a value whether the Workbook tabs are displayed.                           Remarks: The default value is true.              
        /// </summary>  
		[DataMember(Name="ShowTabs", EmitDefaultValue=false)]
        public bool? ShowTabs { get; set; }

        /// <summary>
        /// True if calculations in this workbook will be done using only the precision of the numbers as they're displayed             
        /// </summary>  
		[DataMember(Name="PrecisionAsDisplayed", EmitDefaultValue=false)]
        public bool? PrecisionAsDisplayed { get; set; }

        /// <summary>
        /// It specifies whether to calculate formulas manually, automatically or automatically except for multiple table operations.             
        /// </summary>  
		[DataMember(Name="CalcMode", EmitDefaultValue=false)]
        public string CalcMode { get; set; }

        /// <summary>
        /// Gets or sets AutoCompressPictures
        /// </summary>  
		[DataMember(Name="AutoCompressPictures", EmitDefaultValue=false)]
        public bool? AutoCompressPictures { get; set; }

        /// <summary>
        /// Gets or sets a value which represents if the workbook uses the 1904 date system.             
        /// </summary>  
		[DataMember(Name="Date1904", EmitDefaultValue=false)]
        public bool? Date1904 { get; set; }

        /// <summary>
        /// Gets or sets NumberDecimalSeparator
        /// </summary>  
		[DataMember(Name="NumberDecimalSeparator", EmitDefaultValue=false)]
        public string NumberDecimalSeparator { get; set; }

        /// <summary>
        /// Indicates if Aspose.Cells will use iteration to resolve circular references.             
        /// </summary>  
		[DataMember(Name="Iteration", EmitDefaultValue=false)]
        public bool? Iteration { get; set; }

        /// <summary>
        /// Indicates whether check comptiliblity when saving workbook.                           Remarks:  The default value is true.              
        /// </summary>  
		[DataMember(Name="CheckComptiliblity", EmitDefaultValue=false)]
        public bool? CheckComptiliblity { get; set; }

        /// <summary>
        /// Gets or sets AutoRecover
        /// </summary>  
		[DataMember(Name="AutoRecover", EmitDefaultValue=false)]
        public bool? AutoRecover { get; set; }

        /// <summary>
        /// Returns or sets the maximum number of change that Microsoft Excel can use to resolve a circular reference.             
        /// </summary>  
		[DataMember(Name="MaxChange", EmitDefaultValue=false)]
        public double? MaxChange { get; set; }

        /// <summary>
        /// Gets or sets DataExtractLoad
        /// </summary>  
		[DataMember(Name="DataExtractLoad", EmitDefaultValue=false)]
        public bool? DataExtractLoad { get; set; }

        /// <summary>
        /// Gets or sets the first visible worksheet tab.             
        /// </summary>  
		[DataMember(Name="FirstVisibleTab", EmitDefaultValue=false)]
        public int? FirstVisibleTab { get; set; }

        /// <summary>
        /// Indicates whether this workbook is hidden.             
        /// </summary>  
		[DataMember(Name="IsHidden", EmitDefaultValue=false)]
        public bool? IsHidden { get; set; }

        /// <summary>
        /// Indicates if the Read Only Recommended option is selected.             
        /// </summary>  
		[DataMember(Name="RecommendReadOnly", EmitDefaultValue=false)]
        public bool? RecommendReadOnly { get; set; }

        /// <summary>
        /// Indicates whether and how to show objects in the workbook.             
        /// </summary>  
		[DataMember(Name="DisplayDrawingObjects", EmitDefaultValue=false)]
        public string DisplayDrawingObjects { get; set; }

        /// <summary>
        /// Specifies the incremental public release of the application.             
        /// </summary>  
		[DataMember(Name="BuildVersion", EmitDefaultValue=false)]
        public string BuildVersion { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the generated spreadsheet will contain a vertical scroll bar.                           Remarks: The default value is true.              
        /// </summary>  
		[DataMember(Name="IsVScrollBarVisible", EmitDefaultValue=false)]
        public bool? IsVScrollBarVisible { get; set; }

        /// <summary>
        /// The width of the window, in unit of point.             
        /// </summary>  
		[DataMember(Name="WindowWidth", EmitDefaultValue=false)]
        public double? WindowWidth { get; set; }

        /// <summary>
        /// Indicates whether create calculated formulas chain.             
        /// </summary>  
		[DataMember(Name="CreateCalcChain", EmitDefaultValue=false)]
        public bool? CreateCalcChain { get; set; }

        /// <summary>
        /// Returns or sets the maximum number of iterations that Aspose.Cells can use to resolve a circular reference.             
        /// </summary>  
		[DataMember(Name="MaxIteration", EmitDefaultValue=false)]
        public int? MaxIteration { get; set; }

        /// <summary>
        /// Gets or sets RepairLoad
        /// </summary>  
		[DataMember(Name="RepairLoad", EmitDefaultValue=false)]
        public bool? RepairLoad { get; set; }

        /// <summary>
        /// Gets or sets UpdateLinksType
        /// </summary>  
		[DataMember(Name="UpdateLinksType", EmitDefaultValue=false)]
        public string UpdateLinksType { get; set; }

        /// <summary>
        /// Width of worksheet tab bar (in 1/1000 of window width).             
        /// </summary>  
		[DataMember(Name="SheetTabBarWidth", EmitDefaultValue=false)]
        public int? SheetTabBarWidth { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class WorkbookSettings {\n");
          sb.Append("  NumberGroupSeparator: ").Append(this.NumberGroupSeparator).Append("\n");
          sb.Append("  HidePivotFieldList: ").Append(this.HidePivotFieldList).Append("\n");
          sb.Append("  IsMinimized: ").Append(this.IsMinimized).Append("\n");
          sb.Append("  CalculationId: ").Append(this.CalculationId).Append("\n");
          sb.Append("  ReCalculateOnOpen: ").Append(this.ReCalculateOnOpen).Append("\n");
          sb.Append("  CheckExcelRestriction: ").Append(this.CheckExcelRestriction).Append("\n");
          sb.Append("  IsHScrollBarVisible: ").Append(this.IsHScrollBarVisible).Append("\n");
          sb.Append("  WindowHeight: ").Append(this.WindowHeight).Append("\n");
          sb.Append("  WindowLeft: ").Append(this.WindowLeft).Append("\n");
          sb.Append("  CalcStackSize: ").Append(this.CalcStackSize).Append("\n");
          sb.Append("  Shared: ").Append(this.Shared).Append("\n");
          sb.Append("  RemovePersonalInformation: ").Append(this.RemovePersonalInformation).Append("\n");
          sb.Append("  LanguageCode: ").Append(this.LanguageCode).Append("\n");
          sb.Append("  EnableMacros: ").Append(this.EnableMacros).Append("\n");
          sb.Append("  IsDefaultEncrypted: ").Append(this.IsDefaultEncrypted).Append("\n");
          sb.Append("  RecalculateBeforeSave: ").Append(this.RecalculateBeforeSave).Append("\n");
          sb.Append("  ParsingFormulaOnOpen: ").Append(this.ParsingFormulaOnOpen).Append("\n");
          sb.Append("  WindowTop: ").Append(this.WindowTop).Append("\n");
          sb.Append("  Region: ").Append(this.Region).Append("\n");
          sb.Append("  MemorySetting: ").Append(this.MemorySetting).Append("\n");
          sb.Append("  UpdateAdjacentCellsBorder: ").Append(this.UpdateAdjacentCellsBorder).Append("\n");
          sb.Append("  CrashSave: ").Append(this.CrashSave).Append("\n");
          sb.Append("  ShowTabs: ").Append(this.ShowTabs).Append("\n");
          sb.Append("  PrecisionAsDisplayed: ").Append(this.PrecisionAsDisplayed).Append("\n");
          sb.Append("  CalcMode: ").Append(this.CalcMode).Append("\n");
          sb.Append("  AutoCompressPictures: ").Append(this.AutoCompressPictures).Append("\n");
          sb.Append("  Date1904: ").Append(this.Date1904).Append("\n");
          sb.Append("  NumberDecimalSeparator: ").Append(this.NumberDecimalSeparator).Append("\n");
          sb.Append("  Iteration: ").Append(this.Iteration).Append("\n");
          sb.Append("  CheckComptiliblity: ").Append(this.CheckComptiliblity).Append("\n");
          sb.Append("  AutoRecover: ").Append(this.AutoRecover).Append("\n");
          sb.Append("  MaxChange: ").Append(this.MaxChange).Append("\n");
          sb.Append("  DataExtractLoad: ").Append(this.DataExtractLoad).Append("\n");
          sb.Append("  FirstVisibleTab: ").Append(this.FirstVisibleTab).Append("\n");
          sb.Append("  IsHidden: ").Append(this.IsHidden).Append("\n");
          sb.Append("  RecommendReadOnly: ").Append(this.RecommendReadOnly).Append("\n");
          sb.Append("  DisplayDrawingObjects: ").Append(this.DisplayDrawingObjects).Append("\n");
          sb.Append("  BuildVersion: ").Append(this.BuildVersion).Append("\n");
          sb.Append("  IsVScrollBarVisible: ").Append(this.IsVScrollBarVisible).Append("\n");
          sb.Append("  WindowWidth: ").Append(this.WindowWidth).Append("\n");
          sb.Append("  CreateCalcChain: ").Append(this.CreateCalcChain).Append("\n");
          sb.Append("  MaxIteration: ").Append(this.MaxIteration).Append("\n");
          sb.Append("  RepairLoad: ").Append(this.RepairLoad).Append("\n");
          sb.Append("  UpdateLinksType: ").Append(this.UpdateLinksType).Append("\n");
          sb.Append("  SheetTabBarWidth: ").Append(this.SheetTabBarWidth).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
