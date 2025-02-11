// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="CellValue.cs">
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
    /// Represents the cell value and corresponding type.
    /// </summary>
    public class CellValue
    {
        /// <summary>
        /// A public integer property called "rowIndex" with both getter and setter.
        /// </summary>
        public virtual int? rowIndex { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual int? columnIndex { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual string type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual string value { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual string formula { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual Style style { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CellValue {\n");
            sb.Append("  rowIndex: ").Append(this.rowIndex).Append("\n");
            sb.Append("  columnIndex: ").Append(this.columnIndex).Append("\n");
            sb.Append("  type: ").Append(this.type).Append("\n");
            sb.Append("  value: ").Append(this.value).Append("\n");
            sb.Append("  formula: ").Append(this.formula).Append("\n");
            sb.Append("  style: ").Append(this.style).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
