// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="AutoFilter.cs">
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
    /// Represents autofiltering for the specified worksheet.
    /// </summary>
    public class AutoFilter : LinkElement
    {
        /// <summary>
        /// Gets the collection of the filter columns.
        /// </summary>
        public virtual IList<FilterColumn> FilterColumns { get; set; }

        /// <summary>
        /// Represents the range to which the specified AutoFilter applies.
        /// </summary>
        public virtual string Range { get; set; }

        /// <summary>
        /// Gets the data sorter.
        /// </summary>
        public virtual DataSorter Sorter { get; set; }

        /// <summary>
        /// Indicates whether the AutoFilter button for this column is visible.
        /// </summary>
        public virtual bool? ShowFilterButton { get; set; }

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
            sb.Append("class AutoFilter {\n");
            sb.Append("  FilterColumns: ").Append(this.FilterColumns).Append("\n");
            sb.Append("  Range: ").Append(this.Range).Append("\n");
            sb.Append("  Sorter: ").Append(this.Sorter).Append("\n");
            sb.Append("  ShowFilterButton: ").Append(this.ShowFilterButton).Append("\n");
            sb.Append("  link: ").Append(this.link).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
