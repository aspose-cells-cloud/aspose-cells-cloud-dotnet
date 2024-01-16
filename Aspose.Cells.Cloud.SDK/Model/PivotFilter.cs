// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PivotFilter.cs">
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
    /// Represents a PivotFilter in PivotFilter Collection.
    /// </summary>
    public class PivotFilter
    {
        /// <summary>
        /// Gets the autofilter of the pivot filter.
        /// </summary>
        public virtual AutoFilter AutoFilter { get; set; }

        /// <summary>
        /// Gets the Evaluation Order of the pivot filter.
        /// </summary>
        public virtual int? EvaluationOrder { get; set; }

        /// <summary>
        /// Gets the field index of the pivot filter.
        /// </summary>
        public virtual int? FieldIndex { get; set; }

        /// <summary>
        /// Gets the autofilter type of the pivot filter.
        /// </summary>
        public virtual string FilterType { get; set; }

        /// <summary>
        /// Gets the measure field index of the pivot filter.
        ///             
        /// </summary>
        public virtual int? MeasureFldIndex { get; set; }

        /// <summary>
        /// Gets the member property field index of the pivot filter.
        ///             
        /// </summary>
        public virtual int? MemberPropertyFieldIndex { get; set; }

        /// <summary>
        /// Gets the name of the pivot filter.
        /// </summary>
        public virtual string Name { get; set; }

        /// <summary>
        /// Gets the string value1 of the label pivot filter.
        ///             
        /// </summary>
        public virtual string Value1 { get; set; }

        /// <summary>
        /// Gets the string value2 of the label pivot filter.
        ///             
        /// </summary>
        public virtual string Value2 { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PivotFilter {\n");
            sb.Append("  AutoFilter: ").Append(this.AutoFilter).Append("\n");
            sb.Append("  EvaluationOrder: ").Append(this.EvaluationOrder).Append("\n");
            sb.Append("  FieldIndex: ").Append(this.FieldIndex).Append("\n");
            sb.Append("  FilterType: ").Append(this.FilterType).Append("\n");
            sb.Append("  MeasureFldIndex: ").Append(this.MeasureFldIndex).Append("\n");
            sb.Append("  MemberPropertyFieldIndex: ").Append(this.MemberPropertyFieldIndex).Append("\n");
            sb.Append("  Name: ").Append(this.Name).Append("\n");
            sb.Append("  Value1: ").Append(this.Value1).Append("\n");
            sb.Append("  Value2: ").Append(this.Value2).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
