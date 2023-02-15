// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="WorkbookSettings.cs">
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
    /// WorkbookSettings.
    /// </summary>
    public class WorkbookSettings
    {
        /// <summary>
        /// Gets or sets AutoCompressPictures.
        /// </summary>
        public virtual bool? AutoCompressPictures { get; set; }

        /// <summary>
        /// Gets or sets AutoRecover.
        /// </summary>
        public virtual bool? AutoRecover { get; set; }

        /// <summary>
        /// Gets or sets BuildVersion.
        /// </summary>
        public virtual string BuildVersion { get; set; }

        /// <summary>
        /// Gets or sets CalcMode.
        /// </summary>
        public virtual string CalcMode { get; set; }

        /// <summary>
        /// Gets or sets CalcStackSize.
        /// </summary>
        public virtual int? CalcStackSize { get; set; }

        /// <summary>
        /// Gets or sets CalculationId.
        /// </summary>
        public virtual string CalculationId { get; set; }

        /// <summary>
        /// Gets or sets CheckComptiliblity.
        /// </summary>
        public virtual bool? CheckComptiliblity { get; set; }

        /// <summary>
        /// Gets or sets CheckExcelRestriction.
        /// </summary>
        public virtual bool? CheckExcelRestriction { get; set; }

        /// <summary>
        /// Gets or sets CrashSave.
        /// </summary>
        public virtual bool? CrashSave { get; set; }

        /// <summary>
        /// Gets or sets CreateCalcChain.
        /// </summary>
        public virtual bool? CreateCalcChain { get; set; }

        /// <summary>
        /// Gets or sets DataExtractLoad.
        /// </summary>
        public virtual bool? DataExtractLoad { get; set; }

        /// <summary>
        /// Gets or sets Date1904.
        /// </summary>
        public virtual bool? Date1904 { get; set; }

        /// <summary>
        /// Gets or sets DisplayDrawingObjects.
        /// </summary>
        public virtual string DisplayDrawingObjects { get; set; }

        /// <summary>
        /// Gets or sets EnableMacros.
        /// </summary>
        public virtual bool? EnableMacros { get; set; }

        /// <summary>
        /// Gets or sets FirstVisibleTab.
        /// </summary>
        public virtual int? FirstVisibleTab { get; set; }

        /// <summary>
        /// Gets or sets HidePivotFieldList.
        /// </summary>
        public virtual bool? HidePivotFieldList { get; set; }

        /// <summary>
        /// Gets or sets IsDefaultEncrypted.
        /// </summary>
        public virtual bool? IsDefaultEncrypted { get; set; }

        /// <summary>
        /// Gets or sets IsHidden.
        /// </summary>
        public virtual bool? IsHidden { get; set; }

        /// <summary>
        /// Gets or sets IsHScrollBarVisible.
        /// </summary>
        public virtual bool? IsHScrollBarVisible { get; set; }

        /// <summary>
        /// Gets or sets IsMinimized.
        /// </summary>
        public virtual bool? IsMinimized { get; set; }

        /// <summary>
        /// Gets or sets IsVScrollBarVisible.
        /// </summary>
        public virtual bool? IsVScrollBarVisible { get; set; }

        /// <summary>
        /// Gets or sets Iteration.
        /// </summary>
        public virtual bool? Iteration { get; set; }

        /// <summary>
        /// Gets or sets LanguageCode.
        /// </summary>
        public virtual string LanguageCode { get; set; }

        /// <summary>
        /// Gets or sets MaxChange.
        /// </summary>
        public virtual double? MaxChange { get; set; }

        /// <summary>
        /// Gets or sets MaxIteration.
        /// </summary>
        public virtual int? MaxIteration { get; set; }

        /// <summary>
        /// Gets or sets MemorySetting.
        /// </summary>
        public virtual string MemorySetting { get; set; }

        /// <summary>
        /// Gets or sets NumberDecimalSeparator.
        /// </summary>
        public virtual string NumberDecimalSeparator { get; set; }

        /// <summary>
        /// Gets or sets NumberGroupSeparator.
        /// </summary>
        public virtual string NumberGroupSeparator { get; set; }

        /// <summary>
        /// Gets or sets ParsingFormulaOnOpen.
        /// </summary>
        public virtual bool? ParsingFormulaOnOpen { get; set; }

        /// <summary>
        /// Gets or sets PrecisionAsDisplayed.
        /// </summary>
        public virtual bool? PrecisionAsDisplayed { get; set; }

        /// <summary>
        /// Gets or sets RecalculateBeforeSave.
        /// </summary>
        public virtual bool? RecalculateBeforeSave { get; set; }

        /// <summary>
        /// Gets or sets ReCalculateOnOpen.
        /// </summary>
        public virtual bool? ReCalculateOnOpen { get; set; }

        /// <summary>
        /// Gets or sets RecommendReadOnly.
        /// </summary>
        public virtual bool? RecommendReadOnly { get; set; }

        /// <summary>
        /// Gets or sets Region.
        /// </summary>
        public virtual string Region { get; set; }

        /// <summary>
        /// Gets or sets RemovePersonalInformation.
        /// </summary>
        public virtual bool? RemovePersonalInformation { get; set; }

        /// <summary>
        /// Gets or sets RepairLoad.
        /// </summary>
        public virtual bool? RepairLoad { get; set; }

        /// <summary>
        /// Gets or sets Shared.
        /// </summary>
        public virtual bool? Shared { get; set; }

        /// <summary>
        /// Gets or sets SheetTabBarWidth.
        /// </summary>
        public virtual int? SheetTabBarWidth { get; set; }

        /// <summary>
        /// Gets or sets ShowTabs.
        /// </summary>
        public virtual bool? ShowTabs { get; set; }

        /// <summary>
        /// Gets or sets UpdateAdjacentCellsBorder.
        /// </summary>
        public virtual bool? UpdateAdjacentCellsBorder { get; set; }

        /// <summary>
        /// Gets or sets UpdateLinksType.
        /// </summary>
        public virtual string UpdateLinksType { get; set; }

        /// <summary>
        /// Gets or sets WindowHeight.
        /// </summary>
        public virtual double? WindowHeight { get; set; }

        /// <summary>
        /// Gets or sets WindowLeft.
        /// </summary>
        public virtual double? WindowLeft { get; set; }

        /// <summary>
        /// Gets or sets WindowTop.
        /// </summary>
        public virtual double? WindowTop { get; set; }

        /// <summary>
        /// Gets or sets WindowWidth.
        /// </summary>
        public virtual double? WindowWidth { get; set; }

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
            sb.Append("  CalcStackSize: ").Append(this.CalcStackSize).Append("\n");
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
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
