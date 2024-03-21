// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="WorkbookSettings.cs">
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
    /// WorkbookSettings.
    /// </summary>
    public class WorkbookSettings
    {
        /// <summary>
        /// Specifies a boolean value that indicates the application automatically compressed pictures in the workbook.
        ///  
        /// </summary>
        public virtual bool? AutoCompressPictures { get; set; }

        /// <summary>
        /// Indicates whether the file is mark for auto-recovery.
        ///  
        /// </summary>
        public virtual bool? AutoRecover { get; set; }

        /// <summary>
        /// Specifies the incremental public release of the application.
        ///  
        /// </summary>
        public virtual string BuildVersion { get; set; }

        /// <summary>
        /// It specifies whether to calculate formulas manually,
        ///             automatically or automatically except for multiple table operations.
        ///  
        /// </summary>
        public virtual string CalcMode { get; set; }

        /// <summary>
        /// Specifies the version of the calculation engine used to calculate values in the workbook.
        ///  
        /// </summary>
        public virtual string CalculationId { get; set; }

        /// <summary>
        /// Indicates whether check comptiliblity when saving workbook.
        ///             
        ///              Remarks:
        ///  The default value is true.
        ///              
        /// </summary>
        public virtual bool? CheckComptiliblity { get; set; }

        /// <summary>
        /// Whether check restriction of excel file when user modify cells related objects.
        ///             For example, excel does not allow inputting string value longer than 32K.
        ///             When you input a value longer than 32K such as by Cell.PutValue(string), if this property is true, you will get an Exception.
        ///             If this property is false, we will accept your input string value as the cell's value so that later
        ///             you can output the complete string value for other file formats such as CSV.
        ///             However, if you have set such kind of value that is invalid for excel file format,
        ///             you should not save the workbook as excel file format later. Otherwise there may be unexpected error for the generated excel file.
        ///  
        /// </summary>
        public virtual bool? CheckExcelRestriction { get; set; }

        /// <summary>
        /// indicates whether the application last saved the workbook file after a crash.
        ///  
        /// </summary>
        public virtual bool? CrashSave { get; set; }

        /// <summary>
        /// Whether creates calculated formulas chain. Default is false.
        ///  
        /// </summary>
        public virtual bool? CreateCalcChain { get; set; }

        /// <summary>
        /// indicates whether the application last opened the workbook for data recovery.
        ///  
        /// </summary>
        public virtual bool? DataExtractLoad { get; set; }

        /// <summary>
        /// Gets or sets a value which represents if the workbook uses the 1904 date system.
        ///  
        /// </summary>
        public virtual bool? Date1904 { get; set; }

        /// <summary>
        /// Indicates whether and how to show objects in the workbook.
        ///  
        /// </summary>
        public virtual string DisplayDrawingObjects { get; set; }

        /// <summary>
        /// Enable macros;
        ///  
        /// </summary>
        public virtual bool? EnableMacros { get; set; }

        /// <summary>
        /// Gets or sets the first visible worksheet tab.
        ///  
        /// </summary>
        public virtual int? FirstVisibleTab { get; set; }

        /// <summary>
        /// Gets and sets whether hide the field list for the PivotTable.
        ///  
        /// </summary>
        public virtual bool? HidePivotFieldList { get; set; }

        /// <summary>
        /// Indicates whether encrypting the workbook with default password if Structure and Windows of the workbook are locked.
        ///  
        /// </summary>
        public virtual bool? IsDefaultEncrypted { get; set; }

        /// <summary>
        /// Indicates whether this workbook is hidden.
        ///  
        /// </summary>
        public virtual bool? IsHidden { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the generated spreadsheet will contain a horizontal scroll bar.
        ///  
        /// </summary>
        public virtual bool? IsHScrollBarVisible { get; set; }

        /// <summary>
        /// Represents whether the generated spreadsheet will be opened Minimized.
        ///  
        /// </summary>
        public virtual bool? IsMinimized { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the generated spreadsheet will contain a vertical scroll bar.
        ///  
        /// </summary>
        public virtual bool? IsVScrollBarVisible { get; set; }

        /// <summary>
        /// Indicates whether enable iterative calculation to resolve circular references.
        ///  
        /// </summary>
        public virtual bool? Iteration { get; set; }

        /// <summary>
        /// Gets or sets the user interface language of the Workbook version based on CountryCode that has saved the file.
        ///  
        /// </summary>
        public virtual string LanguageCode { get; set; }

        /// <summary>
        /// Returns or sets the maximum number of change to resolve a circular reference.
        ///  
        /// </summary>
        public virtual double? MaxChange { get; set; }

        /// <summary>
        /// Returns or sets the maximum number of iterations to resolve a circular reference.
        ///  
        /// </summary>
        public virtual int? MaxIteration { get; set; }

        /// <summary>
        /// Gets or sets the memory usage options. The new option will be taken as the default option for newly created worksheets but does not take effect for existing worksheets.
        ///  
        /// </summary>
        public virtual string MemorySetting { get; set; }

        /// <summary>
        /// Gets or sets the decimal separator for formatting/parsing numeric values. Default is the decimal separator of current Region.
        ///  
        /// </summary>
        public virtual string NumberDecimalSeparator { get; set; }

        /// <summary>
        /// Gets or sets the character that separates groups of digits to the left of the decimal in numeric values. Default is the group separator of current Region.
        ///  
        /// </summary>
        public virtual string NumberGroupSeparator { get; set; }

        /// <summary>
        /// Indicates whether parsing the formula when reading the file.
        ///  
        /// </summary>
        public virtual bool? ParsingFormulaOnOpen { get; set; }

        /// <summary>
        /// True if calculations in this workbook will be done using only the precision of the numbers as they're displayed
        ///  
        /// </summary>
        public virtual bool? PrecisionAsDisplayed { get; set; }

        /// <summary>
        /// Indicates whether to recalculate before saving the document.
        ///  
        /// </summary>
        public virtual bool? RecalculateBeforeSave { get; set; }

        /// <summary>
        /// Indicates whether re-calculate all formulas on opening file.
        ///  
        /// </summary>
        public virtual bool? ReCalculateOnOpen { get; set; }

        /// <summary>
        /// Indicates if the Read Only Recommended option is selected.
        ///             
        /// </summary>
        public virtual bool? RecommendReadOnly { get; set; }

        /// <summary>
        /// Gets or sets the regional settings for workbook.
        ///  
        /// </summary>
        public virtual string Region { get; set; }

        /// <summary>
        /// True if personal information can be removed from the specified workbook.
        ///  
        /// </summary>
        public virtual bool? RemovePersonalInformation { get; set; }

        /// <summary>
        /// Indicates whether the application last opened the workbook in safe or repair mode.
        ///  
        /// </summary>
        public virtual bool? RepairLoad { get; set; }

        /// <summary>
        /// Gets or sets a value that indicates whether the Workbook is shared.
        ///  
        /// </summary>
        public virtual bool? Shared { get; set; }

        /// <summary>
        /// Width of worksheet tab bar (in 1/1000 of window width).
        ///  
        /// </summary>
        public virtual int? SheetTabBarWidth { get; set; }

        /// <summary>
        /// Get or sets a value whether the Workbook tabs are displayed.
        ///  
        /// </summary>
        public virtual bool? ShowTabs { get; set; }

        /// <summary>
        /// Indicates whether update adjacent cells' border.
        ///  
        /// </summary>
        public virtual bool? UpdateAdjacentCellsBorder { get; set; }

        /// <summary>
        /// Gets and sets how updates external links when the workbook is opened.
        ///  
        /// </summary>
        public virtual string UpdateLinksType { get; set; }

        /// <summary>
        /// The height of the window, in unit of point.
        ///  
        /// </summary>
        public virtual double? WindowHeight { get; set; }

        /// <summary>
        /// The distance from the left edge of the client area to the left edge of the window, in unit of point.
        ///  
        /// </summary>
        public virtual double? WindowLeft { get; set; }

        /// <summary>
        /// The distance from the top edge of the client area to the top edge of the window, in unit of point.
        ///  
        /// </summary>
        public virtual double? WindowTop { get; set; }

        /// <summary>
        /// The width of the window, in unit of point.
        ///  
        /// </summary>
        public virtual double? WindowWidth { get; set; }

        /// <summary>
        /// Gets and sets the author of the file.
        ///  
        /// </summary>
        public virtual string Author { get; set; }

        /// <summary>
        /// Indicates whether checking custom number format when setting Style.Custom.
        ///  
        /// </summary>
        public virtual bool? CheckCustomNumberFormat { get; set; }

        /// <summary>
        /// Gets the protection type of the workbook.
        ///  
        /// </summary>
        public virtual string ProtectionType { get; set; }

        /// <summary>
        /// Gets and sets the globalization settings.
        ///  
        /// </summary>
        public virtual GlobalizationSettings GlobalizationSettings { get; set; }

        /// <summary>
        /// Represents Workbook file encryption password.
        ///  
        /// </summary>
        public virtual string Password { get; set; }

        /// <summary>
        /// Provides access to the workbook write protection options.
        ///  
        /// </summary>
        public virtual WriteProtection WriteProtection { get; set; }

        /// <summary>
        /// Gets a value that indicates whether a password is required to open this workbook.
        ///  
        /// </summary>
        public virtual bool? IsEncrypted { get; set; }

        /// <summary>
        /// Gets a value that indicates whether the structure or window of the Workbook is protected.
        ///  
        /// </summary>
        public virtual bool? IsProtected { get; set; }

        /// <summary>
        /// Gets the max row index, zero-based.
        ///  
        /// </summary>
        public virtual int? MaxRow { get; set; }

        /// <summary>
        /// Gets the max column index, zero-based.
        ///  
        /// </summary>
        public virtual int? MaxColumn { get; set; }

        /// <summary>
        /// Gets and sets the number of significant digits.
        ///             The default value is .
        ///  
        /// </summary>
        public virtual int? SignificantDigits { get; set; }

        /// <summary>
        /// Indicates whether check compatibility with earlier versions when saving workbook.
        ///  
        /// </summary>
        public virtual bool? CheckCompatibility { get; set; }

        /// <summary>
        /// Gets and sets the default print paper size.
        ///  
        /// </summary>
        public virtual string PaperSize { get; set; }

        /// <summary>
        /// Gets and sets the max row number of shared formula.
        ///  
        /// </summary>
        public virtual int? MaxRowsOfSharedFormula { get; set; }

        /// <summary>
        /// Specifies the OOXML version for the output document. The default value is Ecma376_2006.
        ///  
        /// </summary>
        public virtual string Compliance { get; set; }

        /// <summary>
        /// Indicates whether setting  property when entering the string value(which starts  with single quote mark ) to the cell
        ///  
        /// </summary>
        public virtual bool? QuotePrefixToStyle { get; set; }

        /// <summary>
        /// Gets the settings for formula-related features.
        ///  
        /// </summary>
        public virtual FormulaSettings FormulaSettings { get; set; }

        /// <summary>
        /// Fully calculates every time when a calculation is triggered.
        ///  
        /// </summary>
        public virtual bool? ForceFullCalculate { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkbookSettings {\n");
            sb.Append("  AutoCompressPictures: ").Append(this.AutoCompressPictures).Append("\n");
            sb.Append("  AutoRecover: ").Append(this.AutoRecover).Append("\n");
            sb.Append("  BuildVersion: ").Append(this.BuildVersion).Append("\n");
            sb.Append("  CalcMode: ").Append(this.CalcMode).Append("\n");
            sb.Append("  CalculationId: ").Append(this.CalculationId).Append("\n");
            sb.Append("  CheckComptiliblity: ").Append(this.CheckComptiliblity).Append("\n");
            sb.Append("  CheckExcelRestriction: ").Append(this.CheckExcelRestriction).Append("\n");
            sb.Append("  CrashSave: ").Append(this.CrashSave).Append("\n");
            sb.Append("  CreateCalcChain: ").Append(this.CreateCalcChain).Append("\n");
            sb.Append("  DataExtractLoad: ").Append(this.DataExtractLoad).Append("\n");
            sb.Append("  Date1904: ").Append(this.Date1904).Append("\n");
            sb.Append("  DisplayDrawingObjects: ").Append(this.DisplayDrawingObjects).Append("\n");
            sb.Append("  EnableMacros: ").Append(this.EnableMacros).Append("\n");
            sb.Append("  FirstVisibleTab: ").Append(this.FirstVisibleTab).Append("\n");
            sb.Append("  HidePivotFieldList: ").Append(this.HidePivotFieldList).Append("\n");
            sb.Append("  IsDefaultEncrypted: ").Append(this.IsDefaultEncrypted).Append("\n");
            sb.Append("  IsHidden: ").Append(this.IsHidden).Append("\n");
            sb.Append("  IsHScrollBarVisible: ").Append(this.IsHScrollBarVisible).Append("\n");
            sb.Append("  IsMinimized: ").Append(this.IsMinimized).Append("\n");
            sb.Append("  IsVScrollBarVisible: ").Append(this.IsVScrollBarVisible).Append("\n");
            sb.Append("  Iteration: ").Append(this.Iteration).Append("\n");
            sb.Append("  LanguageCode: ").Append(this.LanguageCode).Append("\n");
            sb.Append("  MaxChange: ").Append(this.MaxChange).Append("\n");
            sb.Append("  MaxIteration: ").Append(this.MaxIteration).Append("\n");
            sb.Append("  MemorySetting: ").Append(this.MemorySetting).Append("\n");
            sb.Append("  NumberDecimalSeparator: ").Append(this.NumberDecimalSeparator).Append("\n");
            sb.Append("  NumberGroupSeparator: ").Append(this.NumberGroupSeparator).Append("\n");
            sb.Append("  ParsingFormulaOnOpen: ").Append(this.ParsingFormulaOnOpen).Append("\n");
            sb.Append("  PrecisionAsDisplayed: ").Append(this.PrecisionAsDisplayed).Append("\n");
            sb.Append("  RecalculateBeforeSave: ").Append(this.RecalculateBeforeSave).Append("\n");
            sb.Append("  ReCalculateOnOpen: ").Append(this.ReCalculateOnOpen).Append("\n");
            sb.Append("  RecommendReadOnly: ").Append(this.RecommendReadOnly).Append("\n");
            sb.Append("  Region: ").Append(this.Region).Append("\n");
            sb.Append("  RemovePersonalInformation: ").Append(this.RemovePersonalInformation).Append("\n");
            sb.Append("  RepairLoad: ").Append(this.RepairLoad).Append("\n");
            sb.Append("  Shared: ").Append(this.Shared).Append("\n");
            sb.Append("  SheetTabBarWidth: ").Append(this.SheetTabBarWidth).Append("\n");
            sb.Append("  ShowTabs: ").Append(this.ShowTabs).Append("\n");
            sb.Append("  UpdateAdjacentCellsBorder: ").Append(this.UpdateAdjacentCellsBorder).Append("\n");
            sb.Append("  UpdateLinksType: ").Append(this.UpdateLinksType).Append("\n");
            sb.Append("  WindowHeight: ").Append(this.WindowHeight).Append("\n");
            sb.Append("  WindowLeft: ").Append(this.WindowLeft).Append("\n");
            sb.Append("  WindowTop: ").Append(this.WindowTop).Append("\n");
            sb.Append("  WindowWidth: ").Append(this.WindowWidth).Append("\n");
            sb.Append("  Author: ").Append(this.Author).Append("\n");
            sb.Append("  CheckCustomNumberFormat: ").Append(this.CheckCustomNumberFormat).Append("\n");
            sb.Append("  ProtectionType: ").Append(this.ProtectionType).Append("\n");
            sb.Append("  GlobalizationSettings: ").Append(this.GlobalizationSettings).Append("\n");
            sb.Append("  Password: ").Append(this.Password).Append("\n");
            sb.Append("  WriteProtection: ").Append(this.WriteProtection).Append("\n");
            sb.Append("  IsEncrypted: ").Append(this.IsEncrypted).Append("\n");
            sb.Append("  IsProtected: ").Append(this.IsProtected).Append("\n");
            sb.Append("  MaxRow: ").Append(this.MaxRow).Append("\n");
            sb.Append("  MaxColumn: ").Append(this.MaxColumn).Append("\n");
            sb.Append("  SignificantDigits: ").Append(this.SignificantDigits).Append("\n");
            sb.Append("  CheckCompatibility: ").Append(this.CheckCompatibility).Append("\n");
            sb.Append("  PaperSize: ").Append(this.PaperSize).Append("\n");
            sb.Append("  MaxRowsOfSharedFormula: ").Append(this.MaxRowsOfSharedFormula).Append("\n");
            sb.Append("  Compliance: ").Append(this.Compliance).Append("\n");
            sb.Append("  QuotePrefixToStyle: ").Append(this.QuotePrefixToStyle).Append("\n");
            sb.Append("  FormulaSettings: ").Append(this.FormulaSettings).Append("\n");
            sb.Append("  ForceFullCalculate: ").Append(this.ForceFullCalculate).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
