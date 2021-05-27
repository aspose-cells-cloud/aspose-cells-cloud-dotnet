// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PivotTable.cs">
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
  /// 
  /// </summary>  
  [DataContract]
  public class PivotTable 
  {                       
        /// <summary>
        /// Gets or sets Link
        /// </summary>  
		[DataMember(Name="link", EmitDefaultValue=false)]
        public Link Link { get; set; }

        /// <summary>
        /// Gets or sets ShowPivotStyleLastColumn
        /// </summary>  
		[DataMember(Name="ShowPivotStyleLastColumn", EmitDefaultValue=false)]
        public bool? ShowPivotStyleLastColumn { get; set; }

        /// <summary>
        /// Gets or sets RowHeaderCaption
        /// </summary>  
		[DataMember(Name="RowHeaderCaption", EmitDefaultValue=false)]
        public string RowHeaderCaption { get; set; }

        /// <summary>
        /// Gets or sets ColumnRange
        /// </summary>  
		[DataMember(Name="ColumnRange", EmitDefaultValue=false)]
        public CellArea ColumnRange { get; set; }

        /// <summary>
        /// Gets or sets RefreshDataOnOpeningFile
        /// </summary>  
		[DataMember(Name="RefreshDataOnOpeningFile", EmitDefaultValue=false)]
        public bool? RefreshDataOnOpeningFile { get; set; }

        /// <summary>
        /// Gets or sets PageFields
        /// </summary>  
		[DataMember(Name="PageFields", EmitDefaultValue=false)]
        public List<PivotField> PageFields { get; set; }

        /// <summary>
        /// Gets or sets DataFields
        /// </summary>  
		[DataMember(Name="DataFields", EmitDefaultValue=false)]
        public List<PivotField> DataFields { get; set; }

        /// <summary>
        /// Gets or sets DataBodyRange
        /// </summary>  
		[DataMember(Name="DataBodyRange", EmitDefaultValue=false)]
        public CellArea DataBodyRange { get; set; }

        /// <summary>
        /// Gets or sets ShowDrill
        /// </summary>  
		[DataMember(Name="ShowDrill", EmitDefaultValue=false)]
        public bool? ShowDrill { get; set; }

        /// <summary>
        /// Gets or sets RefreshDataFlag
        /// </summary>  
		[DataMember(Name="RefreshDataFlag", EmitDefaultValue=false)]
        public bool? RefreshDataFlag { get; set; }

        /// <summary>
        /// Gets or sets ColumnGrand
        /// </summary>  
		[DataMember(Name="ColumnGrand", EmitDefaultValue=false)]
        public bool? ColumnGrand { get; set; }

        /// <summary>
        /// Gets or sets PivotTableStyleName
        /// </summary>  
		[DataMember(Name="PivotTableStyleName", EmitDefaultValue=false)]
        public string PivotTableStyleName { get; set; }

        /// <summary>
        /// Gets or sets PivotFilters
        /// </summary>  
		[DataMember(Name="PivotFilters", EmitDefaultValue=false)]
        public List<PivotFilter> PivotFilters { get; set; }

        /// <summary>
        /// Gets or sets NullString
        /// </summary>  
		[DataMember(Name="NullString", EmitDefaultValue=false)]
        public string NullString { get; set; }

        /// <summary>
        /// Gets or sets ItemPrintTitles
        /// </summary>  
		[DataMember(Name="ItemPrintTitles", EmitDefaultValue=false)]
        public bool? ItemPrintTitles { get; set; }

        /// <summary>
        /// Gets or sets DisplayNullString
        /// </summary>  
		[DataMember(Name="DisplayNullString", EmitDefaultValue=false)]
        public bool? DisplayNullString { get; set; }

        /// <summary>
        /// Gets or sets EnableFieldList
        /// </summary>  
		[DataMember(Name="EnableFieldList", EmitDefaultValue=false)]
        public bool? EnableFieldList { get; set; }

        /// <summary>
        /// Gets or sets TableRange2
        /// </summary>  
		[DataMember(Name="TableRange2", EmitDefaultValue=false)]
        public CellArea TableRange2 { get; set; }

        /// <summary>
        /// Gets or sets RowFields
        /// </summary>  
		[DataMember(Name="RowFields", EmitDefaultValue=false)]
        public List<PivotField> RowFields { get; set; }

        /// <summary>
        /// Gets or sets PageFieldOrder
        /// </summary>  
		[DataMember(Name="PageFieldOrder", EmitDefaultValue=false)]
        public string PageFieldOrder { get; set; }

        /// <summary>
        /// Gets or sets AutoFormatType
        /// </summary>  
		[DataMember(Name="AutoFormatType", EmitDefaultValue=false)]
        public string AutoFormatType { get; set; }

        /// <summary>
        /// Gets or sets EnableDataValueEditing
        /// </summary>  
		[DataMember(Name="EnableDataValueEditing", EmitDefaultValue=false)]
        public bool? EnableDataValueEditing { get; set; }

        /// <summary>
        /// Gets or sets ShowPivotStyleRowHeader
        /// </summary>  
		[DataMember(Name="ShowPivotStyleRowHeader", EmitDefaultValue=false)]
        public bool? ShowPivotStyleRowHeader { get; set; }

        /// <summary>
        /// Gets or sets IsGridDropZones
        /// </summary>  
		[DataMember(Name="IsGridDropZones", EmitDefaultValue=false)]
        public bool? IsGridDropZones { get; set; }

        /// <summary>
        /// Gets or sets EnableWizard
        /// </summary>  
		[DataMember(Name="EnableWizard", EmitDefaultValue=false)]
        public bool? EnableWizard { get; set; }

        /// <summary>
        /// Gets or sets ShowMemberPropertyTips
        /// </summary>  
		[DataMember(Name="ShowMemberPropertyTips", EmitDefaultValue=false)]
        public bool? ShowMemberPropertyTips { get; set; }

        /// <summary>
        /// Gets or sets AltTextDescription
        /// </summary>  
		[DataMember(Name="AltTextDescription", EmitDefaultValue=false)]
        public string AltTextDescription { get; set; }

        /// <summary>
        /// Gets or sets ShowDataTips
        /// </summary>  
		[DataMember(Name="ShowDataTips", EmitDefaultValue=false)]
        public bool? ShowDataTips { get; set; }

        /// <summary>
        /// Gets or sets PrintTitles
        /// </summary>  
		[DataMember(Name="PrintTitles", EmitDefaultValue=false)]
        public bool? PrintTitles { get; set; }

        /// <summary>
        /// Gets or sets TableRange1
        /// </summary>  
		[DataMember(Name="TableRange1", EmitDefaultValue=false)]
        public CellArea TableRange1 { get; set; }

        /// <summary>
        /// Gets or sets ShowEmptyRow
        /// </summary>  
		[DataMember(Name="ShowEmptyRow", EmitDefaultValue=false)]
        public bool? ShowEmptyRow { get; set; }

        /// <summary>
        /// Gets or sets IsMultipleFieldFilters
        /// </summary>  
		[DataMember(Name="IsMultipleFieldFilters", EmitDefaultValue=false)]
        public bool? IsMultipleFieldFilters { get; set; }

        /// <summary>
        /// Gets or sets ShowEmptyCol
        /// </summary>  
		[DataMember(Name="ShowEmptyCol", EmitDefaultValue=false)]
        public bool? ShowEmptyCol { get; set; }

        /// <summary>
        /// Gets or sets ShowRowHeaderCaption
        /// </summary>  
		[DataMember(Name="ShowRowHeaderCaption", EmitDefaultValue=false)]
        public bool? ShowRowHeaderCaption { get; set; }

        /// <summary>
        /// Gets or sets HasBlankRows
        /// </summary>  
		[DataMember(Name="HasBlankRows", EmitDefaultValue=false)]
        public bool? HasBlankRows { get; set; }

        /// <summary>
        /// Gets or sets DataSource
        /// </summary>  
		[DataMember(Name="DataSource", EmitDefaultValue=false)]
        public List<string> DataSource { get; set; }

        /// <summary>
        /// Gets or sets Tag
        /// </summary>  
		[DataMember(Name="Tag", EmitDefaultValue=false)]
        public string Tag { get; set; }

        /// <summary>
        /// Gets or sets EnableDrilldown
        /// </summary>  
		[DataMember(Name="EnableDrilldown", EmitDefaultValue=false)]
        public bool? EnableDrilldown { get; set; }

        /// <summary>
        /// Gets or sets Indent
        /// </summary>  
		[DataMember(Name="Indent", EmitDefaultValue=false)]
        public int? Indent { get; set; }

        /// <summary>
        /// Gets or sets Name
        /// </summary>  
		[DataMember(Name="Name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets RowGrand
        /// </summary>  
		[DataMember(Name="RowGrand", EmitDefaultValue=false)]
        public bool? RowGrand { get; set; }

        /// <summary>
        /// Gets or sets GrandTotalName
        /// </summary>  
		[DataMember(Name="GrandTotalName", EmitDefaultValue=false)]
        public string GrandTotalName { get; set; }

        /// <summary>
        /// Gets or sets DisplayErrorString
        /// </summary>  
		[DataMember(Name="DisplayErrorString", EmitDefaultValue=false)]
        public bool? DisplayErrorString { get; set; }

        /// <summary>
        /// Gets or sets RowRange
        /// </summary>  
		[DataMember(Name="RowRange", EmitDefaultValue=false)]
        public CellArea RowRange { get; set; }

        /// <summary>
        /// Gets or sets IsSelected
        /// </summary>  
		[DataMember(Name="IsSelected", EmitDefaultValue=false)]
        public bool? IsSelected { get; set; }

        /// <summary>
        /// Gets or sets ColumnFields
        /// </summary>  
		[DataMember(Name="ColumnFields", EmitDefaultValue=false)]
        public List<PivotField> ColumnFields { get; set; }

        /// <summary>
        /// Gets or sets ColumnHeaderCaption
        /// </summary>  
		[DataMember(Name="ColumnHeaderCaption", EmitDefaultValue=false)]
        public string ColumnHeaderCaption { get; set; }

        /// <summary>
        /// Gets or sets ShowValuesRow
        /// </summary>  
		[DataMember(Name="ShowValuesRow", EmitDefaultValue=false)]
        public bool? ShowValuesRow { get; set; }

        /// <summary>
        /// Gets or sets EnableFieldDialog
        /// </summary>  
		[DataMember(Name="EnableFieldDialog", EmitDefaultValue=false)]
        public bool? EnableFieldDialog { get; set; }

        /// <summary>
        /// Gets or sets MissingItemsLimit
        /// </summary>  
		[DataMember(Name="MissingItemsLimit", EmitDefaultValue=false)]
        public string MissingItemsLimit { get; set; }

        /// <summary>
        /// Gets or sets ShowPivotStyleRowStripes
        /// </summary>  
		[DataMember(Name="ShowPivotStyleRowStripes", EmitDefaultValue=false)]
        public bool? ShowPivotStyleRowStripes { get; set; }

        /// <summary>
        /// Gets or sets ManualUpdate
        /// </summary>  
		[DataMember(Name="ManualUpdate", EmitDefaultValue=false)]
        public bool? ManualUpdate { get; set; }

        /// <summary>
        /// Gets or sets IsAutoFormat
        /// </summary>  
		[DataMember(Name="IsAutoFormat", EmitDefaultValue=false)]
        public bool? IsAutoFormat { get; set; }

        /// <summary>
        /// Gets or sets DisplayImmediateItems
        /// </summary>  
		[DataMember(Name="DisplayImmediateItems", EmitDefaultValue=false)]
        public bool? DisplayImmediateItems { get; set; }

        /// <summary>
        /// Gets or sets ErrorString
        /// </summary>  
		[DataMember(Name="ErrorString", EmitDefaultValue=false)]
        public string ErrorString { get; set; }

        /// <summary>
        /// Gets or sets CustomListSort
        /// </summary>  
		[DataMember(Name="CustomListSort", EmitDefaultValue=false)]
        public bool? CustomListSort { get; set; }

        /// <summary>
        /// Gets or sets MergeLabels
        /// </summary>  
		[DataMember(Name="MergeLabels", EmitDefaultValue=false)]
        public bool? MergeLabels { get; set; }

        /// <summary>
        /// Gets or sets PageFieldWrapCount
        /// </summary>  
		[DataMember(Name="PageFieldWrapCount", EmitDefaultValue=false)]
        public int? PageFieldWrapCount { get; set; }

        /// <summary>
        /// Gets or sets ShowPivotStyleColumnStripes
        /// </summary>  
		[DataMember(Name="ShowPivotStyleColumnStripes", EmitDefaultValue=false)]
        public bool? ShowPivotStyleColumnStripes { get; set; }

        /// <summary>
        /// Gets or sets FieldListSortAscending
        /// </summary>  
		[DataMember(Name="FieldListSortAscending", EmitDefaultValue=false)]
        public bool? FieldListSortAscending { get; set; }

        /// <summary>
        /// Gets or sets AltTextTitle
        /// </summary>  
		[DataMember(Name="AltTextTitle", EmitDefaultValue=false)]
        public string AltTextTitle { get; set; }

        /// <summary>
        /// Gets or sets PreserveFormatting
        /// </summary>  
		[DataMember(Name="PreserveFormatting", EmitDefaultValue=false)]
        public bool? PreserveFormatting { get; set; }

        /// <summary>
        /// Gets or sets PivotTableStyleType
        /// </summary>  
		[DataMember(Name="PivotTableStyleType", EmitDefaultValue=false)]
        public string PivotTableStyleType { get; set; }

        /// <summary>
        /// Gets or sets DataField
        /// </summary>  
		[DataMember(Name="DataField", EmitDefaultValue=false)]
        public PivotField DataField { get; set; }

        /// <summary>
        /// Gets or sets SaveData
        /// </summary>  
		[DataMember(Name="SaveData", EmitDefaultValue=false)]
        public bool? SaveData { get; set; }

        /// <summary>
        /// Gets or sets SubtotalHiddenPageItems
        /// </summary>  
		[DataMember(Name="SubtotalHiddenPageItems", EmitDefaultValue=false)]
        public bool? SubtotalHiddenPageItems { get; set; }

        /// <summary>
        /// Gets or sets PrintDrill
        /// </summary>  
		[DataMember(Name="PrintDrill", EmitDefaultValue=false)]
        public bool? PrintDrill { get; set; }

        /// <summary>
        /// Gets or sets ShowPivotStyleColumnHeader
        /// </summary>  
		[DataMember(Name="ShowPivotStyleColumnHeader", EmitDefaultValue=false)]
        public bool? ShowPivotStyleColumnHeader { get; set; }

        /// <summary>
        /// Gets or sets BaseFields
        /// </summary>  
		[DataMember(Name="BaseFields", EmitDefaultValue=false)]
        public List<PivotField> BaseFields { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class PivotTable {\n");
          sb.Append("  Link: ").Append(this.Link).Append("\n");
          sb.Append("  ShowPivotStyleLastColumn: ").Append(this.ShowPivotStyleLastColumn).Append("\n");
          sb.Append("  RowHeaderCaption: ").Append(this.RowHeaderCaption).Append("\n");
          sb.Append("  ColumnRange: ").Append(this.ColumnRange).Append("\n");
          sb.Append("  RefreshDataOnOpeningFile: ").Append(this.RefreshDataOnOpeningFile).Append("\n");
          sb.Append("  PageFields: ").Append(this.PageFields).Append("\n");
          sb.Append("  DataFields: ").Append(this.DataFields).Append("\n");
          sb.Append("  DataBodyRange: ").Append(this.DataBodyRange).Append("\n");
          sb.Append("  ShowDrill: ").Append(this.ShowDrill).Append("\n");
          sb.Append("  RefreshDataFlag: ").Append(this.RefreshDataFlag).Append("\n");
          sb.Append("  ColumnGrand: ").Append(this.ColumnGrand).Append("\n");
          sb.Append("  PivotTableStyleName: ").Append(this.PivotTableStyleName).Append("\n");
          sb.Append("  PivotFilters: ").Append(this.PivotFilters).Append("\n");
          sb.Append("  NullString: ").Append(this.NullString).Append("\n");
          sb.Append("  ItemPrintTitles: ").Append(this.ItemPrintTitles).Append("\n");
          sb.Append("  DisplayNullString: ").Append(this.DisplayNullString).Append("\n");
          sb.Append("  EnableFieldList: ").Append(this.EnableFieldList).Append("\n");
          sb.Append("  TableRange2: ").Append(this.TableRange2).Append("\n");
          sb.Append("  RowFields: ").Append(this.RowFields).Append("\n");
          sb.Append("  PageFieldOrder: ").Append(this.PageFieldOrder).Append("\n");
          sb.Append("  AutoFormatType: ").Append(this.AutoFormatType).Append("\n");
          sb.Append("  EnableDataValueEditing: ").Append(this.EnableDataValueEditing).Append("\n");
          sb.Append("  ShowPivotStyleRowHeader: ").Append(this.ShowPivotStyleRowHeader).Append("\n");
          sb.Append("  IsGridDropZones: ").Append(this.IsGridDropZones).Append("\n");
          sb.Append("  EnableWizard: ").Append(this.EnableWizard).Append("\n");
          sb.Append("  ShowMemberPropertyTips: ").Append(this.ShowMemberPropertyTips).Append("\n");
          sb.Append("  AltTextDescription: ").Append(this.AltTextDescription).Append("\n");
          sb.Append("  ShowDataTips: ").Append(this.ShowDataTips).Append("\n");
          sb.Append("  PrintTitles: ").Append(this.PrintTitles).Append("\n");
          sb.Append("  TableRange1: ").Append(this.TableRange1).Append("\n");
          sb.Append("  ShowEmptyRow: ").Append(this.ShowEmptyRow).Append("\n");
          sb.Append("  IsMultipleFieldFilters: ").Append(this.IsMultipleFieldFilters).Append("\n");
          sb.Append("  ShowEmptyCol: ").Append(this.ShowEmptyCol).Append("\n");
          sb.Append("  ShowRowHeaderCaption: ").Append(this.ShowRowHeaderCaption).Append("\n");
          sb.Append("  HasBlankRows: ").Append(this.HasBlankRows).Append("\n");
          sb.Append("  DataSource: ").Append(this.DataSource).Append("\n");
          sb.Append("  Tag: ").Append(this.Tag).Append("\n");
          sb.Append("  EnableDrilldown: ").Append(this.EnableDrilldown).Append("\n");
          sb.Append("  Indent: ").Append(this.Indent).Append("\n");
          sb.Append("  Name: ").Append(this.Name).Append("\n");
          sb.Append("  RowGrand: ").Append(this.RowGrand).Append("\n");
          sb.Append("  GrandTotalName: ").Append(this.GrandTotalName).Append("\n");
          sb.Append("  DisplayErrorString: ").Append(this.DisplayErrorString).Append("\n");
          sb.Append("  RowRange: ").Append(this.RowRange).Append("\n");
          sb.Append("  IsSelected: ").Append(this.IsSelected).Append("\n");
          sb.Append("  ColumnFields: ").Append(this.ColumnFields).Append("\n");
          sb.Append("  ColumnHeaderCaption: ").Append(this.ColumnHeaderCaption).Append("\n");
          sb.Append("  ShowValuesRow: ").Append(this.ShowValuesRow).Append("\n");
          sb.Append("  EnableFieldDialog: ").Append(this.EnableFieldDialog).Append("\n");
          sb.Append("  MissingItemsLimit: ").Append(this.MissingItemsLimit).Append("\n");
          sb.Append("  ShowPivotStyleRowStripes: ").Append(this.ShowPivotStyleRowStripes).Append("\n");
          sb.Append("  ManualUpdate: ").Append(this.ManualUpdate).Append("\n");
          sb.Append("  IsAutoFormat: ").Append(this.IsAutoFormat).Append("\n");
          sb.Append("  DisplayImmediateItems: ").Append(this.DisplayImmediateItems).Append("\n");
          sb.Append("  ErrorString: ").Append(this.ErrorString).Append("\n");
          sb.Append("  CustomListSort: ").Append(this.CustomListSort).Append("\n");
          sb.Append("  MergeLabels: ").Append(this.MergeLabels).Append("\n");
          sb.Append("  PageFieldWrapCount: ").Append(this.PageFieldWrapCount).Append("\n");
          sb.Append("  ShowPivotStyleColumnStripes: ").Append(this.ShowPivotStyleColumnStripes).Append("\n");
          sb.Append("  FieldListSortAscending: ").Append(this.FieldListSortAscending).Append("\n");
          sb.Append("  AltTextTitle: ").Append(this.AltTextTitle).Append("\n");
          sb.Append("  PreserveFormatting: ").Append(this.PreserveFormatting).Append("\n");
          sb.Append("  PivotTableStyleType: ").Append(this.PivotTableStyleType).Append("\n");
          sb.Append("  DataField: ").Append(this.DataField).Append("\n");
          sb.Append("  SaveData: ").Append(this.SaveData).Append("\n");
          sb.Append("  SubtotalHiddenPageItems: ").Append(this.SubtotalHiddenPageItems).Append("\n");
          sb.Append("  PrintDrill: ").Append(this.PrintDrill).Append("\n");
          sb.Append("  ShowPivotStyleColumnHeader: ").Append(this.ShowPivotStyleColumnHeader).Append("\n");
          sb.Append("  BaseFields: ").Append(this.BaseFields).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
