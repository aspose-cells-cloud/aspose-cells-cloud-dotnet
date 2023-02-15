// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PivotTable.cs">
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
    /// PivotTable.
    /// </summary>
    public class PivotTable : LinkElement
    {
        /// <summary>
        /// Gets or sets AltTextDescription.
        /// </summary>
        public virtual string AltTextDescription { get; set; }

        /// <summary>
        /// Gets or sets AltTextTitle.
        /// </summary>
        public virtual string AltTextTitle { get; set; }

        /// <summary>
        /// Gets or sets AutoFormatType.
        /// </summary>
        public virtual string AutoFormatType { get; set; }

        /// <summary>
        /// Gets or sets BaseFields.
        /// </summary>
        public virtual IList<PivotField> BaseFields { get; set; }

        /// <summary>
        /// Gets or sets ColumnFields.
        /// </summary>
        public virtual IList<PivotField> ColumnFields { get; set; }

        /// <summary>
        /// Gets or sets ColumnGrand.
        /// </summary>
        public virtual bool? ColumnGrand { get; set; }

        /// <summary>
        /// Gets or sets ColumnHeaderCaption.
        /// </summary>
        public virtual string ColumnHeaderCaption { get; set; }

        /// <summary>
        /// Gets or sets ColumnRange.
        /// </summary>
        public virtual CellArea ColumnRange { get; set; }

        /// <summary>
        /// Gets or sets CustomListSort.
        /// </summary>
        public virtual bool? CustomListSort { get; set; }

        /// <summary>
        /// Gets or sets DataBodyRange.
        /// </summary>
        public virtual CellArea DataBodyRange { get; set; }

        /// <summary>
        /// Gets or sets DataField.
        /// </summary>
        public virtual PivotField DataField { get; set; }

        /// <summary>
        /// Gets or sets DataFields.
        /// </summary>
        public virtual IList<PivotField> DataFields { get; set; }

        /// <summary>
        /// Gets or sets DataSource.
        /// </summary>
        public virtual List<string> DataSource { get; set; }

        /// <summary>
        /// Gets or sets DisplayErrorString.
        /// </summary>
        public virtual bool? DisplayErrorString { get; set; }

        /// <summary>
        /// Gets or sets DisplayImmediateItems.
        /// </summary>
        public virtual bool? DisplayImmediateItems { get; set; }

        /// <summary>
        /// Gets or sets DisplayNullString.
        /// </summary>
        public virtual bool? DisplayNullString { get; set; }

        /// <summary>
        /// Gets or sets EnableDataValueEditing.
        /// </summary>
        public virtual bool? EnableDataValueEditing { get; set; }

        /// <summary>
        /// Gets or sets EnableDrilldown.
        /// </summary>
        public virtual bool? EnableDrilldown { get; set; }

        /// <summary>
        /// Gets or sets EnableFieldDialog.
        /// </summary>
        public virtual bool? EnableFieldDialog { get; set; }

        /// <summary>
        /// Gets or sets EnableFieldList.
        /// </summary>
        public virtual bool? EnableFieldList { get; set; }

        /// <summary>
        /// Gets or sets EnableWizard.
        /// </summary>
        public virtual bool? EnableWizard { get; set; }

        /// <summary>
        /// Gets or sets ErrorString.
        /// </summary>
        public virtual string ErrorString { get; set; }

        /// <summary>
        /// Gets or sets FieldListSortAscending.
        /// </summary>
        public virtual bool? FieldListSortAscending { get; set; }

        /// <summary>
        /// Gets or sets GrandTotalName.
        /// </summary>
        public virtual string GrandTotalName { get; set; }

        /// <summary>
        /// Gets or sets HasBlankRows.
        /// </summary>
        public virtual bool? HasBlankRows { get; set; }

        /// <summary>
        /// Gets or sets Indent.
        /// </summary>
        public virtual int? Indent { get; set; }

        /// <summary>
        /// Gets or sets IsAutoFormat.
        /// </summary>
        public virtual bool? IsAutoFormat { get; set; }

        /// <summary>
        /// Gets or sets IsGridDropZones.
        /// </summary>
        public virtual bool? IsGridDropZones { get; set; }

        /// <summary>
        /// Gets or sets IsMultipleFieldFilters.
        /// </summary>
        public virtual bool? IsMultipleFieldFilters { get; set; }

        /// <summary>
        /// Gets or sets IsSelected.
        /// </summary>
        public virtual bool? IsSelected { get; set; }

        /// <summary>
        /// Gets or sets ItemPrintTitles.
        /// </summary>
        public virtual bool? ItemPrintTitles { get; set; }

        /// <summary>
        /// Gets or sets ManualUpdate.
        /// </summary>
        public virtual bool? ManualUpdate { get; set; }

        /// <summary>
        /// Gets or sets MergeLabels.
        /// </summary>
        public virtual bool? MergeLabels { get; set; }

        /// <summary>
        /// Gets or sets MissingItemsLimit.
        /// </summary>
        public virtual string MissingItemsLimit { get; set; }

        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        public virtual string Name { get; set; }

        /// <summary>
        /// Gets or sets NullString.
        /// </summary>
        public virtual string NullString { get; set; }

        /// <summary>
        /// Gets or sets PageFieldOrder.
        /// </summary>
        public virtual string PageFieldOrder { get; set; }

        /// <summary>
        /// Gets or sets PageFields.
        /// </summary>
        public virtual IList<PivotField> PageFields { get; set; }

        /// <summary>
        /// Gets or sets PageFieldWrapCount.
        /// </summary>
        public virtual int? PageFieldWrapCount { get; set; }

        /// <summary>
        /// Gets or sets PivotFilters.
        /// </summary>
        public virtual IList<PivotFilter> PivotFilters { get; set; }

        /// <summary>
        /// Gets or sets PivotTableStyleName.
        /// </summary>
        public virtual string PivotTableStyleName { get; set; }

        /// <summary>
        /// Gets or sets PivotTableStyleType.
        /// </summary>
        public virtual string PivotTableStyleType { get; set; }

        /// <summary>
        /// Gets or sets PreserveFormatting.
        /// </summary>
        public virtual bool? PreserveFormatting { get; set; }

        /// <summary>
        /// Gets or sets PrintDrill.
        /// </summary>
        public virtual bool? PrintDrill { get; set; }

        /// <summary>
        /// Gets or sets PrintTitles.
        /// </summary>
        public virtual bool? PrintTitles { get; set; }

        /// <summary>
        /// Gets or sets RefreshDataFlag.
        /// </summary>
        public virtual bool? RefreshDataFlag { get; set; }

        /// <summary>
        /// Gets or sets RefreshDataOnOpeningFile.
        /// </summary>
        public virtual bool? RefreshDataOnOpeningFile { get; set; }

        /// <summary>
        /// Gets or sets RowFields.
        /// </summary>
        public virtual IList<PivotField> RowFields { get; set; }

        /// <summary>
        /// Gets or sets RowGrand.
        /// </summary>
        public virtual bool? RowGrand { get; set; }

        /// <summary>
        /// Gets or sets RowHeaderCaption.
        /// </summary>
        public virtual string RowHeaderCaption { get; set; }

        /// <summary>
        /// Gets or sets RowRange.
        /// </summary>
        public virtual CellArea RowRange { get; set; }

        /// <summary>
        /// Gets or sets SaveData.
        /// </summary>
        public virtual bool? SaveData { get; set; }

        /// <summary>
        /// Gets or sets ShowDataTips.
        /// </summary>
        public virtual bool? ShowDataTips { get; set; }

        /// <summary>
        /// Gets or sets ShowDrill.
        /// </summary>
        public virtual bool? ShowDrill { get; set; }

        /// <summary>
        /// Gets or sets ShowEmptyCol.
        /// </summary>
        public virtual bool? ShowEmptyCol { get; set; }

        /// <summary>
        /// Gets or sets ShowEmptyRow.
        /// </summary>
        public virtual bool? ShowEmptyRow { get; set; }

        /// <summary>
        /// Gets or sets ShowMemberPropertyTips.
        /// </summary>
        public virtual bool? ShowMemberPropertyTips { get; set; }

        /// <summary>
        /// Gets or sets ShowPivotStyleColumnHeader.
        /// </summary>
        public virtual bool? ShowPivotStyleColumnHeader { get; set; }

        /// <summary>
        /// Gets or sets ShowPivotStyleColumnStripes.
        /// </summary>
        public virtual bool? ShowPivotStyleColumnStripes { get; set; }

        /// <summary>
        /// Gets or sets ShowPivotStyleLastColumn.
        /// </summary>
        public virtual bool? ShowPivotStyleLastColumn { get; set; }

        /// <summary>
        /// Gets or sets ShowPivotStyleRowHeader.
        /// </summary>
        public virtual bool? ShowPivotStyleRowHeader { get; set; }

        /// <summary>
        /// Gets or sets ShowPivotStyleRowStripes.
        /// </summary>
        public virtual bool? ShowPivotStyleRowStripes { get; set; }

        /// <summary>
        /// Gets or sets ShowRowHeaderCaption.
        /// </summary>
        public virtual bool? ShowRowHeaderCaption { get; set; }

        /// <summary>
        /// Gets or sets ShowValuesRow.
        /// </summary>
        public virtual bool? ShowValuesRow { get; set; }

        /// <summary>
        /// Gets or sets SubtotalHiddenPageItems.
        /// </summary>
        public virtual bool? SubtotalHiddenPageItems { get; set; }

        /// <summary>
        /// Gets or sets TableRange1.
        /// </summary>
        public virtual CellArea TableRange1 { get; set; }

        /// <summary>
        /// Gets or sets TableRange2.
        /// </summary>
        public virtual CellArea TableRange2 { get; set; }

        /// <summary>
        /// Gets or sets Tag.
        /// </summary>
        public virtual string Tag { get; set; }

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
            sb.Append("class PivotTable {\n");
            sb.Append("  AltTextDescription: ").Append(this.AltTextDescription).Append("\n");
            sb.Append("  AltTextTitle: ").Append(this.AltTextTitle).Append("\n");
            sb.Append("  AutoFormatType: ").Append(this.AutoFormatType).Append("\n");
            sb.Append("  BaseFields: ").Append(this.BaseFields).Append("\n");
            sb.Append("  ColumnFields: ").Append(this.ColumnFields).Append("\n");
            sb.Append("  ColumnGrand: ").Append(this.ColumnGrand).Append("\n");
            sb.Append("  ColumnHeaderCaption: ").Append(this.ColumnHeaderCaption).Append("\n");
            sb.Append("  ColumnRange: ").Append(this.ColumnRange).Append("\n");
            sb.Append("  CustomListSort: ").Append(this.CustomListSort).Append("\n");
            sb.Append("  DataBodyRange: ").Append(this.DataBodyRange).Append("\n");
            sb.Append("  DataField: ").Append(this.DataField).Append("\n");
            sb.Append("  DataFields: ").Append(this.DataFields).Append("\n");
            sb.Append("  DataSource: ").Append(this.DataSource).Append("\n");
            sb.Append("  DisplayErrorString: ").Append(this.DisplayErrorString).Append("\n");
            sb.Append("  DisplayImmediateItems: ").Append(this.DisplayImmediateItems).Append("\n");
            sb.Append("  DisplayNullString: ").Append(this.DisplayNullString).Append("\n");
            sb.Append("  EnableDataValueEditing: ").Append(this.EnableDataValueEditing).Append("\n");
            sb.Append("  EnableDrilldown: ").Append(this.EnableDrilldown).Append("\n");
            sb.Append("  EnableFieldDialog: ").Append(this.EnableFieldDialog).Append("\n");
            sb.Append("  EnableFieldList: ").Append(this.EnableFieldList).Append("\n");
            sb.Append("  EnableWizard: ").Append(this.EnableWizard).Append("\n");
            sb.Append("  ErrorString: ").Append(this.ErrorString).Append("\n");
            sb.Append("  FieldListSortAscending: ").Append(this.FieldListSortAscending).Append("\n");
            sb.Append("  GrandTotalName: ").Append(this.GrandTotalName).Append("\n");
            sb.Append("  HasBlankRows: ").Append(this.HasBlankRows).Append("\n");
            sb.Append("  Indent: ").Append(this.Indent).Append("\n");
            sb.Append("  IsAutoFormat: ").Append(this.IsAutoFormat).Append("\n");
            sb.Append("  IsGridDropZones: ").Append(this.IsGridDropZones).Append("\n");
            sb.Append("  IsMultipleFieldFilters: ").Append(this.IsMultipleFieldFilters).Append("\n");
            sb.Append("  IsSelected: ").Append(this.IsSelected).Append("\n");
            sb.Append("  ItemPrintTitles: ").Append(this.ItemPrintTitles).Append("\n");
            sb.Append("  ManualUpdate: ").Append(this.ManualUpdate).Append("\n");
            sb.Append("  MergeLabels: ").Append(this.MergeLabels).Append("\n");
            sb.Append("  MissingItemsLimit: ").Append(this.MissingItemsLimit).Append("\n");
            sb.Append("  Name: ").Append(this.Name).Append("\n");
            sb.Append("  NullString: ").Append(this.NullString).Append("\n");
            sb.Append("  PageFieldOrder: ").Append(this.PageFieldOrder).Append("\n");
            sb.Append("  PageFields: ").Append(this.PageFields).Append("\n");
            sb.Append("  PageFieldWrapCount: ").Append(this.PageFieldWrapCount).Append("\n");
            sb.Append("  PivotFilters: ").Append(this.PivotFilters).Append("\n");
            sb.Append("  PivotTableStyleName: ").Append(this.PivotTableStyleName).Append("\n");
            sb.Append("  PivotTableStyleType: ").Append(this.PivotTableStyleType).Append("\n");
            sb.Append("  PreserveFormatting: ").Append(this.PreserveFormatting).Append("\n");
            sb.Append("  PrintDrill: ").Append(this.PrintDrill).Append("\n");
            sb.Append("  PrintTitles: ").Append(this.PrintTitles).Append("\n");
            sb.Append("  RefreshDataFlag: ").Append(this.RefreshDataFlag).Append("\n");
            sb.Append("  RefreshDataOnOpeningFile: ").Append(this.RefreshDataOnOpeningFile).Append("\n");
            sb.Append("  RowFields: ").Append(this.RowFields).Append("\n");
            sb.Append("  RowGrand: ").Append(this.RowGrand).Append("\n");
            sb.Append("  RowHeaderCaption: ").Append(this.RowHeaderCaption).Append("\n");
            sb.Append("  RowRange: ").Append(this.RowRange).Append("\n");
            sb.Append("  SaveData: ").Append(this.SaveData).Append("\n");
            sb.Append("  ShowDataTips: ").Append(this.ShowDataTips).Append("\n");
            sb.Append("  ShowDrill: ").Append(this.ShowDrill).Append("\n");
            sb.Append("  ShowEmptyCol: ").Append(this.ShowEmptyCol).Append("\n");
            sb.Append("  ShowEmptyRow: ").Append(this.ShowEmptyRow).Append("\n");
            sb.Append("  ShowMemberPropertyTips: ").Append(this.ShowMemberPropertyTips).Append("\n");
            sb.Append("  ShowPivotStyleColumnHeader: ").Append(this.ShowPivotStyleColumnHeader).Append("\n");
            sb.Append("  ShowPivotStyleColumnStripes: ").Append(this.ShowPivotStyleColumnStripes).Append("\n");
            sb.Append("  ShowPivotStyleLastColumn: ").Append(this.ShowPivotStyleLastColumn).Append("\n");
            sb.Append("  ShowPivotStyleRowHeader: ").Append(this.ShowPivotStyleRowHeader).Append("\n");
            sb.Append("  ShowPivotStyleRowStripes: ").Append(this.ShowPivotStyleRowStripes).Append("\n");
            sb.Append("  ShowRowHeaderCaption: ").Append(this.ShowRowHeaderCaption).Append("\n");
            sb.Append("  ShowValuesRow: ").Append(this.ShowValuesRow).Append("\n");
            sb.Append("  SubtotalHiddenPageItems: ").Append(this.SubtotalHiddenPageItems).Append("\n");
            sb.Append("  TableRange1: ").Append(this.TableRange1).Append("\n");
            sb.Append("  TableRange2: ").Append(this.TableRange2).Append("\n");
            sb.Append("  Tag: ").Append(this.Tag).Append("\n");
            sb.Append("  link: ").Append(this.link).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
