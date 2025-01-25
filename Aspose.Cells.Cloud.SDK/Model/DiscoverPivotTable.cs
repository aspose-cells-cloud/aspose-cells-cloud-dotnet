// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="DiscoverPivotTable.cs">
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
    /// Represents a pivot table, which is a pivot table created based on data analysis of a table.
    /// </summary>
    public class DiscoverPivotTable
    {
        /// <summary>
        /// Represents pivot table name.
        /// </summary>
        public virtual string Name { get; set; }

        /// <summary>
        /// Represents pivot table title.
        /// </summary>
        public virtual string Title { get; set; }

        /// <summary>
        /// Represents pivot table data range.
        /// </summary>
        public virtual string DataRange { get; set; }

        /// <summary>
        /// Represents row fields in a PivotTable report.
        /// </summary>
        public virtual List<int?> PivotFieldRows { get; set; }

        /// <summary>
        /// Represents column fields in a PivotTable report.
        /// </summary>
        public virtual List<int?> PivotFieldColumns { get; set; }

        /// <summary>
        /// Represents data fields in a PivotTable report.
        /// </summary>
        public virtual List<int?> PivotFieldData { get; set; }

        /// <summary>
        /// Represents pivot table thumbnail. Base64String
        /// </summary>
        public virtual string Thumbnail { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DiscoverPivotTable {\n");
            sb.Append("  Name: ").Append(this.Name).Append("\n");
            sb.Append("  Title: ").Append(this.Title).Append("\n");
            sb.Append("  DataRange: ").Append(this.DataRange).Append("\n");
            sb.Append("  PivotFieldRows: ").Append(this.PivotFieldRows).Append("\n");
            sb.Append("  PivotFieldColumns: ").Append(this.PivotFieldColumns).Append("\n");
            sb.Append("  PivotFieldData: ").Append(this.PivotFieldData).Append("\n");
            sb.Append("  Thumbnail: ").Append(this.Thumbnail).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
