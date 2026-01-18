// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="AnalyzedColumnDescription.cs">
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
    /// Represents description of analyzed column.
    /// </summary>
    public class AnalyzedColumnDescription
    {
        /// <summary>
        /// Column index.
        /// </summary>
        public virtual int? Index { get; set; }

        /// <summary>
        /// The true position index value of the column.
        /// </summary>
        public virtual int? ColumnIndex { get; set; }

        /// <summary>
        /// This class has a public property "Title" of type string with a default value of an empty string.
        /// </summary>
        public virtual string Title { get; set; }

        /// <summary>
        /// When the repetition rate is high, can it be viewed as a group display?
        /// </summary>
        public virtual double? RepetitionRate { get; set; }

        /// <summary>
        /// The column type is identified, and the attributes of the column are determined after data analysis.
        /// </summary>
        public virtual string ColumnDataDataType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual string NumberCategoryType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual string TextCategoryType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual int? StyleNumber { get; set; }

        /// <summary>
        /// Column data exception description.
        /// </summary>
        public virtual string columnDataExceptionDescription { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AnalyzedColumnDescription {\n");
            sb.Append("  Index: ").Append(this.Index).Append("\n");
            sb.Append("  ColumnIndex: ").Append(this.ColumnIndex).Append("\n");
            sb.Append("  Title: ").Append(this.Title).Append("\n");
            sb.Append("  RepetitionRate: ").Append(this.RepetitionRate).Append("\n");
            sb.Append("  ColumnDataDataType: ").Append(this.ColumnDataDataType).Append("\n");
            sb.Append("  NumberCategoryType: ").Append(this.NumberCategoryType).Append("\n");
            sb.Append("  TextCategoryType: ").Append(this.TextCategoryType).Append("\n");
            sb.Append("  StyleNumber: ").Append(this.StyleNumber).Append("\n");
            sb.Append("  columnDataExceptionDescription: ").Append(this.columnDataExceptionDescription).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
