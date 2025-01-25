// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="AnalyzedTableDescription.cs">
//   Copyright (c) 2025 Aspose.Cells Cloud
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
    /// Represents analyzed table description.
    /// </summary>
    public class AnalyzedTableDescription
    {
        /// <summary>
        /// Represents table name.
        /// </summary>
        public virtual string Name { get; set; }

        /// <summary>
        /// Represents worksheet name which is where the table is located.
        /// </summary>
        public virtual string SheetName { get; set; }

        /// <summary>
        /// Represents analyzed description about table columns.
        /// </summary>
        public virtual IList<AnalyzedColumnDescription> Columns { get; set; }

        /// <summary>
        /// Represents date columns list.
        /// </summary>
        public virtual IList<int?> DateColumns { get; set; }

        /// <summary>
        /// Represents number columns list.
        /// </summary>
        public virtual IList<int?> NumberColumns { get; set; }

        /// <summary>
        /// Represents string columns list.
        /// </summary>
        public virtual IList<int?> TextColumns { get; set; }

        /// <summary>
        /// Represents exception columns list.
        /// </summary>
        public virtual IList<int?> ExceptionColumns { get; set; }

        /// <summary>
        /// Represents there is a table header in the table.
        /// </summary>
        public virtual bool? HasTableHeaderRow { get; set; }

        /// <summary>
        /// Represents there is a total row in the table.
        /// </summary>
        public virtual bool? HasTableTotalRow { get; set; }

        /// <summary>
        /// Represents the column index as the start data column.
        /// </summary>
        public virtual int? StartDataColumnIndex { get; set; }

        /// <summary>
        /// Represents the column index as the end data column.
        /// </summary>
        public virtual int? EndDataColumnIndex { get; set; }

        /// <summary>
        /// Represents the row index as the start data row.
        /// </summary>
        public virtual int? StartDataRowIndex { get; set; }

        /// <summary>
        /// Represents the row index as the end data row.
        /// </summary>
        public virtual int? EndDataRowIndex { get; set; }

        /// <summary>
        /// Represents table thumbnail. Base64String
        /// </summary>
        public virtual string Thumbnail { get; set; }

        /// <summary>
        /// Represents a collection of charts, which is a collection of charts created based on data analysis of a table.
        /// </summary>
        public virtual IList<DiscoverChart> DiscoverCharts { get; set; }

        /// <summary>
        /// Represents a collection of pivot tables, which is a collection of pivot tables created based on data analysis of a table.
        /// </summary>
        public virtual IList<DiscoverPivotTable> DiscoverPivotTables { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AnalyzedTableDescription {\n");
            sb.Append("  Name: ").Append(this.Name).Append("\n");
            sb.Append("  SheetName: ").Append(this.SheetName).Append("\n");
            sb.Append("  Columns: ").Append(this.Columns).Append("\n");
            sb.Append("  DateColumns: ").Append(this.DateColumns).Append("\n");
            sb.Append("  NumberColumns: ").Append(this.NumberColumns).Append("\n");
            sb.Append("  TextColumns: ").Append(this.TextColumns).Append("\n");
            sb.Append("  ExceptionColumns: ").Append(this.ExceptionColumns).Append("\n");
            sb.Append("  HasTableHeaderRow: ").Append(this.HasTableHeaderRow).Append("\n");
            sb.Append("  HasTableTotalRow: ").Append(this.HasTableTotalRow).Append("\n");
            sb.Append("  StartDataColumnIndex: ").Append(this.StartDataColumnIndex).Append("\n");
            sb.Append("  EndDataColumnIndex: ").Append(this.EndDataColumnIndex).Append("\n");
            sb.Append("  StartDataRowIndex: ").Append(this.StartDataRowIndex).Append("\n");
            sb.Append("  EndDataRowIndex: ").Append(this.EndDataRowIndex).Append("\n");
            sb.Append("  Thumbnail: ").Append(this.Thumbnail).Append("\n");
            sb.Append("  DiscoverCharts: ").Append(this.DiscoverCharts).Append("\n");
            sb.Append("  DiscoverPivotTables: ").Append(this.DiscoverPivotTables).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
