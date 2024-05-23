// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="WorksheetDataStatistics.cs">
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
    /// Represents worksheet data statistics.
    /// </summary>
    public class WorksheetDataStatistics
    {
        /// <summary>
        /// Represents worksheet name.
        /// </summary>
        public virtual string Name { get; set; }

        /// <summary>
        /// Represents chart number.
        /// </summary>
        public virtual int? ChartsCount { get; set; }

        /// <summary>
        /// Represents list object number.
        /// </summary>
        public virtual int? TablesCount { get; set; }

        /// <summary>
        /// Represents pivot table number.
        /// </summary>
        public virtual int? PivotTablesCount { get; set; }

        /// <summary>
        /// Represents shape number.
        /// </summary>
        public virtual int? ShapesCount { get; set; }

        /// <summary>
        /// Represents shape number.
        /// </summary>
        public virtual int? HyperlinksCount { get; set; }

        /// <summary>
        /// Represents hyperlink number.
        /// </summary>
        public virtual int? QueryTablesCount { get; set; }

        /// <summary>
        /// Represents query table number.
        /// </summary>
        public virtual int? CellsCount { get; set; }

        /// <summary>
        /// Represents cell number.
        /// </summary>
        public virtual int? CellsCountInTable { get; set; }

        /// <summary>
        /// Represents formula number.
        /// </summary>
        public virtual int? CellsCountIsFormula { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorksheetDataStatistics {\n");
            sb.Append("  Name: ").Append(this.Name).Append("\n");
            sb.Append("  ChartsCount: ").Append(this.ChartsCount).Append("\n");
            sb.Append("  TablesCount: ").Append(this.TablesCount).Append("\n");
            sb.Append("  PivotTablesCount: ").Append(this.PivotTablesCount).Append("\n");
            sb.Append("  ShapesCount: ").Append(this.ShapesCount).Append("\n");
            sb.Append("  HyperlinksCount: ").Append(this.HyperlinksCount).Append("\n");
            sb.Append("  QueryTablesCount: ").Append(this.QueryTablesCount).Append("\n");
            sb.Append("  CellsCount: ").Append(this.CellsCount).Append("\n");
            sb.Append("  CellsCountInTable: ").Append(this.CellsCountInTable).Append("\n");
            sb.Append("  CellsCountIsFormula: ").Append(this.CellsCountIsFormula).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
