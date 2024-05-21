// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PivotField.cs">
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
    ///            Represents a field in a PivotTable report.
    ///            
    /// </summary>
    public class PivotField
    {
        /// <summary>
        /// 
        /// </summary>
        public virtual int? AutoShowCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual int? AutoShowField { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual int? AutoSortField { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual int? BaseField { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual int? BaseIndex { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual int? BaseItem { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual string BaseItemPosition { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual int? CurrentPageItem { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual string DataDisplayFormat { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual bool? DragToColumn { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual bool? DragToData { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual bool? DragToHide { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual bool? DragToPage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual bool? DragToRow { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual string Function { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual bool? InsertBlankRow { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual bool? IsAscendShow { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual bool? IsAscendSort { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual bool? IsAutoShow { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual bool? IsAutoSort { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual bool? IsAutoSubtotals { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual bool? IsCalculatedField { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual bool? IsIncludeNewItemsInFilter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual bool? IsInsertPageBreaksBetweenItems { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual bool? IsMultipleItemSelectionAllowed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual bool? IsRepeatItemLabels { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual int? ItemCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual List<string> Items { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual int? Number { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual string NumberFormat { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual List<string> OriginalItems { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual IList<PivotItem> PivotItems { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual int? Position { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual bool? ShowAllItems { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual bool? ShowCompact { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual bool? ShowInOutlineForm { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual bool? ShowSubtotalAtTop { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PivotField {\n");
            sb.Append("  AutoShowCount: ").Append(this.AutoShowCount).Append("\n");
            sb.Append("  AutoShowField: ").Append(this.AutoShowField).Append("\n");
            sb.Append("  AutoSortField: ").Append(this.AutoSortField).Append("\n");
            sb.Append("  BaseField: ").Append(this.BaseField).Append("\n");
            sb.Append("  BaseIndex: ").Append(this.BaseIndex).Append("\n");
            sb.Append("  BaseItem: ").Append(this.BaseItem).Append("\n");
            sb.Append("  BaseItemPosition: ").Append(this.BaseItemPosition).Append("\n");
            sb.Append("  CurrentPageItem: ").Append(this.CurrentPageItem).Append("\n");
            sb.Append("  DataDisplayFormat: ").Append(this.DataDisplayFormat).Append("\n");
            sb.Append("  DisplayName: ").Append(this.DisplayName).Append("\n");
            sb.Append("  DragToColumn: ").Append(this.DragToColumn).Append("\n");
            sb.Append("  DragToData: ").Append(this.DragToData).Append("\n");
            sb.Append("  DragToHide: ").Append(this.DragToHide).Append("\n");
            sb.Append("  DragToPage: ").Append(this.DragToPage).Append("\n");
            sb.Append("  DragToRow: ").Append(this.DragToRow).Append("\n");
            sb.Append("  Function: ").Append(this.Function).Append("\n");
            sb.Append("  InsertBlankRow: ").Append(this.InsertBlankRow).Append("\n");
            sb.Append("  IsAscendShow: ").Append(this.IsAscendShow).Append("\n");
            sb.Append("  IsAscendSort: ").Append(this.IsAscendSort).Append("\n");
            sb.Append("  IsAutoShow: ").Append(this.IsAutoShow).Append("\n");
            sb.Append("  IsAutoSort: ").Append(this.IsAutoSort).Append("\n");
            sb.Append("  IsAutoSubtotals: ").Append(this.IsAutoSubtotals).Append("\n");
            sb.Append("  IsCalculatedField: ").Append(this.IsCalculatedField).Append("\n");
            sb.Append("  IsIncludeNewItemsInFilter: ").Append(this.IsIncludeNewItemsInFilter).Append("\n");
            sb.Append("  IsInsertPageBreaksBetweenItems: ").Append(this.IsInsertPageBreaksBetweenItems).Append("\n");
            sb.Append("  IsMultipleItemSelectionAllowed: ").Append(this.IsMultipleItemSelectionAllowed).Append("\n");
            sb.Append("  IsRepeatItemLabels: ").Append(this.IsRepeatItemLabels).Append("\n");
            sb.Append("  ItemCount: ").Append(this.ItemCount).Append("\n");
            sb.Append("  Items: ").Append(this.Items).Append("\n");
            sb.Append("  Name: ").Append(this.Name).Append("\n");
            sb.Append("  Number: ").Append(this.Number).Append("\n");
            sb.Append("  NumberFormat: ").Append(this.NumberFormat).Append("\n");
            sb.Append("  OriginalItems: ").Append(this.OriginalItems).Append("\n");
            sb.Append("  PivotItems: ").Append(this.PivotItems).Append("\n");
            sb.Append("  Position: ").Append(this.Position).Append("\n");
            sb.Append("  ShowAllItems: ").Append(this.ShowAllItems).Append("\n");
            sb.Append("  ShowCompact: ").Append(this.ShowCompact).Append("\n");
            sb.Append("  ShowInOutlineForm: ").Append(this.ShowInOutlineForm).Append("\n");
            sb.Append("  ShowSubtotalAtTop: ").Append(this.ShowSubtotalAtTop).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
