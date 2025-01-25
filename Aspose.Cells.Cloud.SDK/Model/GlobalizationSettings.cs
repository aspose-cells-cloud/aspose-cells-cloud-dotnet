// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="GlobalizationSettings.cs">
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
    /// Represents the globalization settings.
    ///  
    /// </summary>
    public class GlobalizationSettings
    {
        /// <summary>
        /// Gets or sets the globalization settings for Chart.
        ///  
        /// </summary>
        public virtual ChartGlobalizationSettings ChartSettings { get; set; }

        /// <summary>
        /// Gets or sets the globalization settings for pivot table.
        ///  
        /// </summary>
        public virtual PivotGlobalizationSettings PivotSettings { get; set; }

        /// <summary>
        /// Gets the separator for list, parameters of function, ...etc.
        ///  
        /// </summary>
        public virtual string ListSeparator { get; set; }

        /// <summary>
        /// Gets the separator for rows in array data in formula.
        ///  
        /// </summary>
        public virtual string RowSeparatorOfFormulaArray { get; set; }

        /// <summary>
        /// Gets the separator for the items in array's row data in formula.
        ///  
        /// </summary>
        public virtual string ColumnSeparatorOfFormulaArray { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GlobalizationSettings {\n");
            sb.Append("  ChartSettings: ").Append(this.ChartSettings).Append("\n");
            sb.Append("  PivotSettings: ").Append(this.PivotSettings).Append("\n");
            sb.Append("  ListSeparator: ").Append(this.ListSeparator).Append("\n");
            sb.Append("  RowSeparatorOfFormulaArray: ").Append(this.RowSeparatorOfFormulaArray).Append("\n");
            sb.Append("  ColumnSeparatorOfFormulaArray: ").Append(this.ColumnSeparatorOfFormulaArray).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
