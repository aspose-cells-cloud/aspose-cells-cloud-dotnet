// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="MergeQueries.cs">
//   Copyright (c) 2026 Aspose.Cells Cloud
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
    /// Represents merge quesies.
    /// </summary>
    public class MergeQueries : AppliedOperate
    {
        /// <summary>
        /// Indicates the name of the data query , it is matched in the data query set.
        /// </summary>
        public virtual string DataQueryNameA { get; set; }

        /// <summary>
        /// Represents index field  of DataA.
        /// </summary>
        public virtual string DataAIndexField { get; set; }

        /// <summary>
        /// Indicates the name of the data query , it is matched in the data query set.
        /// </summary>
        public virtual string DataQueryNameB { get; set; }

        /// <summary>
        /// Represents index field  of DataB.
        /// </summary>
        public virtual string DataBIndexField { get; set; }

        /// <summary>
        /// Represents ethods of data consolidation.
        /// </summary>
        public virtual string JoinType { get; set; }

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
            sb.Append("class MergeQueries {\n");
            sb.Append("  DataQueryNameA: ").Append(this.DataQueryNameA).Append("\n");
            sb.Append("  DataAIndexField: ").Append(this.DataAIndexField).Append("\n");
            sb.Append("  DataQueryNameB: ").Append(this.DataQueryNameB).Append("\n");
            sb.Append("  DataBIndexField: ").Append(this.DataBIndexField).Append("\n");
            sb.Append("  JoinType: ").Append(this.JoinType).Append("\n");
            sb.Append("  AppliedOperateType: ").Append(this.AppliedOperateType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
