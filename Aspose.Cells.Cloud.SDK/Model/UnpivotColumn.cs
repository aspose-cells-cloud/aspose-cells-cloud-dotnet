// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="UnpivotColumn.cs">
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
    /// Unpivot column.
    /// </summary>
    public class UnpivotColumn : AppliedOperate
    {
        /// <summary>
        /// Indicates unpivot column names.
        /// </summary>
        public virtual IList<string> UnpivotColumnNames { get; set; }

        /// <summary>
        /// Indicates the column is used to store the name of unpivot columns.
        /// </summary>
        public virtual string ColumnMapName { get; set; }

        /// <summary>
        /// Indicates the column is used to store the value of unpivot columns.
        /// </summary>
        public virtual string ValueMapName { get; set; }

        /// <summary>
        /// Gets or sets AppliedOperateType.
        /// </summary>
        public override string AppliedOperateType { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UnpivotColumn {\n");
            sb.Append("  UnpivotColumnNames: ").Append(this.UnpivotColumnNames).Append("\n");
            sb.Append("  ColumnMapName: ").Append(this.ColumnMapName).Append("\n");
            sb.Append("  ValueMapName: ").Append(this.ValueMapName).Append("\n");
            sb.Append("  AppliedOperateType: ").Append(this.AppliedOperateType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
