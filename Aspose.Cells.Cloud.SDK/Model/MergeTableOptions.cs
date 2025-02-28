// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="MergeTableOptions.cs">
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
    /// MergeTableOptions.
    /// </summary>
    public class MergeTableOptions
    {
        /// <summary>
        /// Gets or sets MainTable.
        /// </summary>
        public virtual CombinationSourceData MainTable { get; set; }

        /// <summary>
        /// Gets or sets SecondaryTable.
        /// </summary>
        public virtual CombinationSourceData SecondaryTable { get; set; }

        /// <summary>
        /// Gets or sets DataMergeType.
        /// </summary>
        public virtual string DataMergeType { get; set; }

        /// <summary>
        /// Gets or sets OverwriteMainTable.
        /// </summary>
        public virtual bool? OverwriteMainTable { get; set; }

        /// <summary>
        /// Gets or sets SyncDataToTargetWorkbook.
        /// </summary>
        public virtual bool? SyncDataToTargetWorkbook { get; set; }

        /// <summary>
        /// Gets or sets MergedDataToPosition.
        /// </summary>
        public virtual DataOutputLocation MergedDataToPosition { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MergeTableOptions {\n");
            sb.Append("  MainTable: ").Append(this.MainTable).Append("\n");
            sb.Append("  SecondaryTable: ").Append(this.SecondaryTable).Append("\n");
            sb.Append("  DataMergeType: ").Append(this.DataMergeType).Append("\n");
            sb.Append("  OverwriteMainTable: ").Append(this.OverwriteMainTable).Append("\n");
            sb.Append("  SyncDataToTargetWorkbook: ").Append(this.SyncDataToTargetWorkbook).Append("\n");
            sb.Append("  MergedDataToPosition: ").Append(this.MergedDataToPosition).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
