// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="Protection.cs">
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
    /// Represents the various types of protection options available for a worksheet.
    ///             
    /// </summary>
    public class Protection
    {
        /// <summary>
        /// Represents if the deletion of columns is allowed on a protected worksheet.
        ///  
        /// </summary>
        public virtual bool? AllowDeletingColumn { get; set; }

        /// <summary>
        /// Represents if the deletion of rows is allowed on a protected worksheet.
        ///  
        /// </summary>
        public virtual bool? AllowDeletingRow { get; set; }

        /// <summary>
        /// Represents if the user is allowed to make use of an AutoFilter that was created before the sheet was protected.
        ///  
        /// </summary>
        public virtual bool? AllowFiltering { get; set; }

        /// <summary>
        /// Represents if the formatting of cells is allowed on a protected worksheet.
        ///  
        /// </summary>
        public virtual bool? AllowFormattingCell { get; set; }

        /// <summary>
        /// Represents if the formatting of columns is allowed on a protected worksheet
        ///  
        /// </summary>
        public virtual bool? AllowFormattingColumn { get; set; }

        /// <summary>
        /// Represents if the formatting of rows is allowed on a protected worksheet
        ///  
        /// </summary>
        public virtual bool? AllowFormattingRow { get; set; }

        /// <summary>
        /// Represents if the insertion of columns is allowed on a protected worksheet
        ///  
        /// </summary>
        public virtual bool? AllowInsertingColumn { get; set; }

        /// <summary>
        /// Represents if the insertion of hyperlinks is allowed on a protected worksheet
        ///  
        /// </summary>
        public virtual bool? AllowInsertingHyperlink { get; set; }

        /// <summary>
        /// Represents if the insertion of rows is allowed on a protected worksheet
        ///  
        /// </summary>
        public virtual bool? AllowInsertingRow { get; set; }

        /// <summary>
        /// Represents if the sorting option is allowed on a protected worksheet.
        ///  
        /// </summary>
        public virtual bool? AllowSorting { get; set; }

        /// <summary>
        /// Represents if the user is allowed to manipulate pivot tables on a protected worksheet.
        ///  
        /// </summary>
        public virtual bool? AllowUsingPivotTable { get; set; }

        /// <summary>
        /// Represents if the user is allowed to edit contents of locked cells on a protected worksheet.
        ///  
        /// </summary>
        public virtual bool? AllowEditingContent { get; set; }

        /// <summary>
        /// Represents if the user is allowed to manipulate drawing objects on a protected worksheet.
        ///  
        /// </summary>
        public virtual bool? AllowEditingObject { get; set; }

        /// <summary>
        /// Represents if the user is allowed to edit scenarios on a protected worksheet.
        ///  
        /// </summary>
        public virtual bool? AllowEditingScenario { get; set; }

        /// <summary>
        /// Represents the password to protect the worksheet.
        ///  
        /// </summary>
        public virtual string Password { get; set; }

        /// <summary>
        /// Represents if the user is allowed to select locked cells on a protected worksheet.
        ///  
        /// </summary>
        public virtual bool? AllowSelectingLockedCell { get; set; }

        /// <summary>
        /// Represents if the user is allowed to select unlocked cells on a protected worksheet.
        ///  
        /// </summary>
        public virtual bool? AllowSelectingUnlockedCell { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Protection {\n");
            sb.Append("  AllowDeletingColumn: ").Append(this.AllowDeletingColumn).Append("\n");
            sb.Append("  AllowDeletingRow: ").Append(this.AllowDeletingRow).Append("\n");
            sb.Append("  AllowFiltering: ").Append(this.AllowFiltering).Append("\n");
            sb.Append("  AllowFormattingCell: ").Append(this.AllowFormattingCell).Append("\n");
            sb.Append("  AllowFormattingColumn: ").Append(this.AllowFormattingColumn).Append("\n");
            sb.Append("  AllowFormattingRow: ").Append(this.AllowFormattingRow).Append("\n");
            sb.Append("  AllowInsertingColumn: ").Append(this.AllowInsertingColumn).Append("\n");
            sb.Append("  AllowInsertingHyperlink: ").Append(this.AllowInsertingHyperlink).Append("\n");
            sb.Append("  AllowInsertingRow: ").Append(this.AllowInsertingRow).Append("\n");
            sb.Append("  AllowSorting: ").Append(this.AllowSorting).Append("\n");
            sb.Append("  AllowUsingPivotTable: ").Append(this.AllowUsingPivotTable).Append("\n");
            sb.Append("  AllowEditingContent: ").Append(this.AllowEditingContent).Append("\n");
            sb.Append("  AllowEditingObject: ").Append(this.AllowEditingObject).Append("\n");
            sb.Append("  AllowEditingScenario: ").Append(this.AllowEditingScenario).Append("\n");
            sb.Append("  Password: ").Append(this.Password).Append("\n");
            sb.Append("  AllowSelectingLockedCell: ").Append(this.AllowSelectingLockedCell).Append("\n");
            sb.Append("  AllowSelectingUnlockedCell: ").Append(this.AllowSelectingUnlockedCell).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
