// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="CreatePivotTableRequest.cs">
//   Copyright (c) 2023 Aspose.Cells Cloud
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
    /// CreatePivotTableRequest.
    /// </summary>
    public class CreatePivotTableRequest
    {
        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        public virtual string Name { get; set; }

        /// <summary>
        /// Gets or sets SourceData.
        /// </summary>
        public virtual string SourceData { get; set; }

        /// <summary>
        /// Gets or sets DestCellName.
        /// </summary>
        public virtual string DestCellName { get; set; }

        /// <summary>
        /// Gets or sets UseSameSource.
        /// </summary>
        public virtual bool? UseSameSource { get; set; }

        /// <summary>
        /// Gets or sets PivotFieldRows.
        /// </summary>
        public virtual List<int?> PivotFieldRows { get; set; }

        /// <summary>
        /// Gets or sets PivotFieldColumns.
        /// </summary>
        public virtual List<int?> PivotFieldColumns { get; set; }

        /// <summary>
        /// Gets or sets PivotFieldData.
        /// </summary>
        public virtual List<int?> PivotFieldData { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreatePivotTableRequest {\n");
            sb.Append("  Name: ").Append(this.Name).Append("\n");
            sb.Append("  SourceData: ").Append(this.SourceData).Append("\n");
            sb.Append("  DestCellName: ").Append(this.DestCellName).Append("\n");
            sb.Append("  UseSameSource: ").Append(this.UseSameSource).Append("\n");
            sb.Append("  PivotFieldRows: ").Append(this.PivotFieldRows).Append("\n");
            sb.Append("  PivotFieldColumns: ").Append(this.PivotFieldColumns).Append("\n");
            sb.Append("  PivotFieldData: ").Append(this.PivotFieldData).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
