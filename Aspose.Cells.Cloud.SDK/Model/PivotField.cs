// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PivotField.cs">
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
  public class PivotField 
  {                       
        /// <summary>
        /// Gets or sets PivotItems
        /// </summary>  
		[DataMember(Name="PivotItems", EmitDefaultValue=false)]
        public List<PivotItem> PivotItems { get; set; }

        /// <summary>
        /// Gets or sets DisplayName
        /// </summary>  
		[DataMember(Name="DisplayName", EmitDefaultValue=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets NumberFormat
        /// </summary>  
		[DataMember(Name="NumberFormat", EmitDefaultValue=false)]
        public string NumberFormat { get; set; }

        /// <summary>
        /// Gets or sets DragToColumn
        /// </summary>  
		[DataMember(Name="DragToColumn", EmitDefaultValue=false)]
        public bool? DragToColumn { get; set; }

        /// <summary>
        /// Gets or sets IsAutoShow
        /// </summary>  
		[DataMember(Name="IsAutoShow", EmitDefaultValue=false)]
        public bool? IsAutoShow { get; set; }

        /// <summary>
        /// Gets or sets IsRepeatItemLabels
        /// </summary>  
		[DataMember(Name="IsRepeatItemLabels", EmitDefaultValue=false)]
        public bool? IsRepeatItemLabels { get; set; }

        /// <summary>
        /// Gets or sets DragToRow
        /// </summary>  
		[DataMember(Name="DragToRow", EmitDefaultValue=false)]
        public bool? DragToRow { get; set; }

        /// <summary>
        /// Gets or sets IsAutoSort
        /// </summary>  
		[DataMember(Name="IsAutoSort", EmitDefaultValue=false)]
        public bool? IsAutoSort { get; set; }

        /// <summary>
        /// Gets or sets InsertBlankRow
        /// </summary>  
		[DataMember(Name="InsertBlankRow", EmitDefaultValue=false)]
        public bool? InsertBlankRow { get; set; }

        /// <summary>
        /// Gets or sets ShowSubtotalAtTop
        /// </summary>  
		[DataMember(Name="ShowSubtotalAtTop", EmitDefaultValue=false)]
        public bool? ShowSubtotalAtTop { get; set; }

        /// <summary>
        /// Gets or sets ShowCompact
        /// </summary>  
		[DataMember(Name="ShowCompact", EmitDefaultValue=false)]
        public bool? ShowCompact { get; set; }

        /// <summary>
        /// Gets or sets Function
        /// </summary>  
		[DataMember(Name="Function", EmitDefaultValue=false)]
        public string Function { get; set; }

        /// <summary>
        /// Gets or sets IsMultipleItemSelectionAllowed
        /// </summary>  
		[DataMember(Name="IsMultipleItemSelectionAllowed", EmitDefaultValue=false)]
        public bool? IsMultipleItemSelectionAllowed { get; set; }

        /// <summary>
        /// Gets or sets DataDisplayFormat
        /// </summary>  
		[DataMember(Name="DataDisplayFormat", EmitDefaultValue=false)]
        public string DataDisplayFormat { get; set; }

        /// <summary>
        /// Gets or sets BaseItemPosition
        /// </summary>  
		[DataMember(Name="BaseItemPosition", EmitDefaultValue=false)]
        public string BaseItemPosition { get; set; }

        /// <summary>
        /// Gets or sets IsInsertPageBreaksBetweenItems
        /// </summary>  
		[DataMember(Name="IsInsertPageBreaksBetweenItems", EmitDefaultValue=false)]
        public bool? IsInsertPageBreaksBetweenItems { get; set; }

        /// <summary>
        /// Gets or sets ShowAllItems
        /// </summary>  
		[DataMember(Name="ShowAllItems", EmitDefaultValue=false)]
        public bool? ShowAllItems { get; set; }

        /// <summary>
        /// Gets or sets BaseItem
        /// </summary>  
		[DataMember(Name="BaseItem", EmitDefaultValue=false)]
        public int? BaseItem { get; set; }

        /// <summary>
        /// Gets or sets ItemCount
        /// </summary>  
		[DataMember(Name="ItemCount", EmitDefaultValue=false)]
        public int? ItemCount { get; set; }

        /// <summary>
        /// Gets or sets Name
        /// </summary>  
		[DataMember(Name="Name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets ShowInOutlineForm
        /// </summary>  
		[DataMember(Name="ShowInOutlineForm", EmitDefaultValue=false)]
        public bool? ShowInOutlineForm { get; set; }

        /// <summary>
        /// Gets or sets Items
        /// </summary>  
		[DataMember(Name="Items", EmitDefaultValue=false)]
        public List<string> Items { get; set; }

        /// <summary>
        /// Gets or sets AutoShowField
        /// </summary>  
		[DataMember(Name="AutoShowField", EmitDefaultValue=false)]
        public int? AutoShowField { get; set; }

        /// <summary>
        /// Gets or sets IsAutoSubtotals
        /// </summary>  
		[DataMember(Name="IsAutoSubtotals", EmitDefaultValue=false)]
        public bool? IsAutoSubtotals { get; set; }

        /// <summary>
        /// Gets or sets IsIncludeNewItemsInFilter
        /// </summary>  
		[DataMember(Name="IsIncludeNewItemsInFilter", EmitDefaultValue=false)]
        public bool? IsIncludeNewItemsInFilter { get; set; }

        /// <summary>
        /// Gets or sets CurrentPageItem
        /// </summary>  
		[DataMember(Name="CurrentPageItem", EmitDefaultValue=false)]
        public int? CurrentPageItem { get; set; }

        /// <summary>
        /// Gets or sets Position
        /// </summary>  
		[DataMember(Name="Position", EmitDefaultValue=false)]
        public int? Position { get; set; }

        /// <summary>
        /// Gets or sets IsAscendSort
        /// </summary>  
		[DataMember(Name="IsAscendSort", EmitDefaultValue=false)]
        public bool? IsAscendSort { get; set; }

        /// <summary>
        /// Gets or sets IsAscendShow
        /// </summary>  
		[DataMember(Name="IsAscendShow", EmitDefaultValue=false)]
        public bool? IsAscendShow { get; set; }

        /// <summary>
        /// Gets or sets BaseField
        /// </summary>  
		[DataMember(Name="BaseField", EmitDefaultValue=false)]
        public int? BaseField { get; set; }

        /// <summary>
        /// Gets or sets AutoSortField
        /// </summary>  
		[DataMember(Name="AutoSortField", EmitDefaultValue=false)]
        public int? AutoSortField { get; set; }

        /// <summary>
        /// Gets or sets AutoShowCount
        /// </summary>  
		[DataMember(Name="AutoShowCount", EmitDefaultValue=false)]
        public int? AutoShowCount { get; set; }

        /// <summary>
        /// Gets or sets Number
        /// </summary>  
		[DataMember(Name="Number", EmitDefaultValue=false)]
        public int? Number { get; set; }

        /// <summary>
        /// Gets or sets DragToPage
        /// </summary>  
		[DataMember(Name="DragToPage", EmitDefaultValue=false)]
        public bool? DragToPage { get; set; }

        /// <summary>
        /// Gets or sets DragToData
        /// </summary>  
		[DataMember(Name="DragToData", EmitDefaultValue=false)]
        public bool? DragToData { get; set; }

        /// <summary>
        /// Gets or sets BaseIndex
        /// </summary>  
		[DataMember(Name="BaseIndex", EmitDefaultValue=false)]
        public int? BaseIndex { get; set; }

        /// <summary>
        /// Gets or sets OriginalItems
        /// </summary>  
		[DataMember(Name="OriginalItems", EmitDefaultValue=false)]
        public List<string> OriginalItems { get; set; }

        /// <summary>
        /// Gets or sets DragToHide
        /// </summary>  
		[DataMember(Name="DragToHide", EmitDefaultValue=false)]
        public bool? DragToHide { get; set; }

        /// <summary>
        /// Gets or sets IsCalculatedField
        /// </summary>  
		[DataMember(Name="IsCalculatedField", EmitDefaultValue=false)]
        public bool? IsCalculatedField { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class PivotField {\n");
          sb.Append("  PivotItems: ").Append(this.PivotItems).Append("\n");
          sb.Append("  DisplayName: ").Append(this.DisplayName).Append("\n");
          sb.Append("  NumberFormat: ").Append(this.NumberFormat).Append("\n");
          sb.Append("  DragToColumn: ").Append(this.DragToColumn).Append("\n");
          sb.Append("  IsAutoShow: ").Append(this.IsAutoShow).Append("\n");
          sb.Append("  IsRepeatItemLabels: ").Append(this.IsRepeatItemLabels).Append("\n");
          sb.Append("  DragToRow: ").Append(this.DragToRow).Append("\n");
          sb.Append("  IsAutoSort: ").Append(this.IsAutoSort).Append("\n");
          sb.Append("  InsertBlankRow: ").Append(this.InsertBlankRow).Append("\n");
          sb.Append("  ShowSubtotalAtTop: ").Append(this.ShowSubtotalAtTop).Append("\n");
          sb.Append("  ShowCompact: ").Append(this.ShowCompact).Append("\n");
          sb.Append("  Function: ").Append(this.Function).Append("\n");
          sb.Append("  IsMultipleItemSelectionAllowed: ").Append(this.IsMultipleItemSelectionAllowed).Append("\n");
          sb.Append("  DataDisplayFormat: ").Append(this.DataDisplayFormat).Append("\n");
          sb.Append("  BaseItemPosition: ").Append(this.BaseItemPosition).Append("\n");
          sb.Append("  IsInsertPageBreaksBetweenItems: ").Append(this.IsInsertPageBreaksBetweenItems).Append("\n");
          sb.Append("  ShowAllItems: ").Append(this.ShowAllItems).Append("\n");
          sb.Append("  BaseItem: ").Append(this.BaseItem).Append("\n");
          sb.Append("  ItemCount: ").Append(this.ItemCount).Append("\n");
          sb.Append("  Name: ").Append(this.Name).Append("\n");
          sb.Append("  ShowInOutlineForm: ").Append(this.ShowInOutlineForm).Append("\n");
          sb.Append("  Items: ").Append(this.Items).Append("\n");
          sb.Append("  AutoShowField: ").Append(this.AutoShowField).Append("\n");
          sb.Append("  IsAutoSubtotals: ").Append(this.IsAutoSubtotals).Append("\n");
          sb.Append("  IsIncludeNewItemsInFilter: ").Append(this.IsIncludeNewItemsInFilter).Append("\n");
          sb.Append("  CurrentPageItem: ").Append(this.CurrentPageItem).Append("\n");
          sb.Append("  Position: ").Append(this.Position).Append("\n");
          sb.Append("  IsAscendSort: ").Append(this.IsAscendSort).Append("\n");
          sb.Append("  IsAscendShow: ").Append(this.IsAscendShow).Append("\n");
          sb.Append("  BaseField: ").Append(this.BaseField).Append("\n");
          sb.Append("  AutoSortField: ").Append(this.AutoSortField).Append("\n");
          sb.Append("  AutoShowCount: ").Append(this.AutoShowCount).Append("\n");
          sb.Append("  Number: ").Append(this.Number).Append("\n");
          sb.Append("  DragToPage: ").Append(this.DragToPage).Append("\n");
          sb.Append("  DragToData: ").Append(this.DragToData).Append("\n");
          sb.Append("  BaseIndex: ").Append(this.BaseIndex).Append("\n");
          sb.Append("  OriginalItems: ").Append(this.OriginalItems).Append("\n");
          sb.Append("  DragToHide: ").Append(this.DragToHide).Append("\n");
          sb.Append("  IsCalculatedField: ").Append(this.IsCalculatedField).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
