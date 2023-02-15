// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ListObject.cs">
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
    /// ListObject.
    /// </summary>
    public class ListObject : LinkElement
    {
        /// <summary>
        /// Gets or sets AutoFilter.
        /// </summary>
        public virtual AutoFilter AutoFilter { get; set; }

        /// <summary>
        /// Gets or sets DisplayName.
        /// </summary>
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets StartColumn.
        /// </summary>
        public virtual int? StartColumn { get; set; }

        /// <summary>
        /// Gets or sets StartRow.
        /// </summary>
        public virtual int? StartRow { get; set; }

        /// <summary>
        /// Gets or sets EndColumn.
        /// </summary>
        public virtual int? EndColumn { get; set; }

        /// <summary>
        /// Gets or sets EndRow.
        /// </summary>
        public virtual int? EndRow { get; set; }

        /// <summary>
        /// Gets or sets ListColumns.
        /// </summary>
        public virtual IList<ListColumn> ListColumns { get; set; }

        /// <summary>
        /// Gets or sets ShowHeaderRow.
        /// </summary>
        public virtual bool? ShowHeaderRow { get; set; }

        /// <summary>
        /// Gets or sets ShowTableStyleColumnStripes.
        /// </summary>
        public virtual bool? ShowTableStyleColumnStripes { get; set; }

        /// <summary>
        /// Gets or sets ShowTableStyleFirstColumn.
        /// </summary>
        public virtual bool? ShowTableStyleFirstColumn { get; set; }

        /// <summary>
        /// Gets or sets ShowTableStyleLastColumn.
        /// </summary>
        public virtual bool? ShowTableStyleLastColumn { get; set; }

        /// <summary>
        /// Gets or sets ShowTableStyleRowStripes.
        /// </summary>
        public virtual bool? ShowTableStyleRowStripes { get; set; }

        /// <summary>
        /// Gets or sets ShowTotals.
        /// </summary>
        public virtual bool? ShowTotals { get; set; }

        /// <summary>
        /// Gets or sets TableStyleName.
        /// </summary>
        public virtual string TableStyleName { get; set; }

        /// <summary>
        /// Gets or sets TableStyleType.
        /// </summary>
        public virtual string TableStyleType { get; set; }

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
            sb.Append("class ListObject {\n");
            sb.Append("  AutoFilter: ").Append(this.AutoFilter).Append("\n");
            sb.Append("  DisplayName: ").Append(this.DisplayName).Append("\n");
            sb.Append("  StartColumn: ").Append(this.StartColumn).Append("\n");
            sb.Append("  StartRow: ").Append(this.StartRow).Append("\n");
            sb.Append("  EndColumn: ").Append(this.EndColumn).Append("\n");
            sb.Append("  EndRow: ").Append(this.EndRow).Append("\n");
            sb.Append("  ListColumns: ").Append(this.ListColumns).Append("\n");
            sb.Append("  ShowHeaderRow: ").Append(this.ShowHeaderRow).Append("\n");
            sb.Append("  ShowTableStyleColumnStripes: ").Append(this.ShowTableStyleColumnStripes).Append("\n");
            sb.Append("  ShowTableStyleFirstColumn: ").Append(this.ShowTableStyleFirstColumn).Append("\n");
            sb.Append("  ShowTableStyleLastColumn: ").Append(this.ShowTableStyleLastColumn).Append("\n");
            sb.Append("  ShowTableStyleRowStripes: ").Append(this.ShowTableStyleRowStripes).Append("\n");
            sb.Append("  ShowTotals: ").Append(this.ShowTotals).Append("\n");
            sb.Append("  TableStyleName: ").Append(this.TableStyleName).Append("\n");
            sb.Append("  TableStyleType: ").Append(this.TableStyleType).Append("\n");
            sb.Append("  link: ").Append(this.link).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
