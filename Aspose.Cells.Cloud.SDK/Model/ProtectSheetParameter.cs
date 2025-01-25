// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ProtectSheetParameter.cs">
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
    /// ProtectSheetParameter.
    /// </summary>
    public class ProtectSheetParameter
    {
        /// <summary>
        /// Gets or sets ProtectionType.
        /// </summary>
        public virtual string ProtectionType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual string Password { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual IList<string> AllowEditArea { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual string AllowDeletingColumn { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual string AllowDeletingRow { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual string AllowFiltering { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual string AllowFormattingCell { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual string AllowFormattingColumn { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual string AllowFormattingRow { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual string AllowInsertingColumn { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual string AllowInsertingHyperlink { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual string AllowInsertingRow { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual string AllowSelectingLockedCell { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual string AllowSelectingUnlockedCell { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual string AllowSorting { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual string AllowUsingPivotTable { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProtectSheetParameter {\n");
            sb.Append("  ProtectionType: ").Append(this.ProtectionType).Append("\n");
            sb.Append("  Password: ").Append(this.Password).Append("\n");
            sb.Append("  AllowEditArea: ").Append(this.AllowEditArea).Append("\n");
            sb.Append("  AllowDeletingColumn: ").Append(this.AllowDeletingColumn).Append("\n");
            sb.Append("  AllowDeletingRow: ").Append(this.AllowDeletingRow).Append("\n");
            sb.Append("  AllowFiltering: ").Append(this.AllowFiltering).Append("\n");
            sb.Append("  AllowFormattingCell: ").Append(this.AllowFormattingCell).Append("\n");
            sb.Append("  AllowFormattingColumn: ").Append(this.AllowFormattingColumn).Append("\n");
            sb.Append("  AllowFormattingRow: ").Append(this.AllowFormattingRow).Append("\n");
            sb.Append("  AllowInsertingColumn: ").Append(this.AllowInsertingColumn).Append("\n");
            sb.Append("  AllowInsertingHyperlink: ").Append(this.AllowInsertingHyperlink).Append("\n");
            sb.Append("  AllowInsertingRow: ").Append(this.AllowInsertingRow).Append("\n");
            sb.Append("  AllowSelectingLockedCell: ").Append(this.AllowSelectingLockedCell).Append("\n");
            sb.Append("  AllowSelectingUnlockedCell: ").Append(this.AllowSelectingUnlockedCell).Append("\n");
            sb.Append("  AllowSorting: ").Append(this.AllowSorting).Append("\n");
            sb.Append("  AllowUsingPivotTable: ").Append(this.AllowUsingPivotTable).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
