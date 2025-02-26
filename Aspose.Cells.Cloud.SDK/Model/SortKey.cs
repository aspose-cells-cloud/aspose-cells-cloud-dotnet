// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="SortKey.cs">
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
    /// Represents sort key.
    /// </summary>
    public class SortKey
    {
        /// <summary>
        /// Represents the key of sorting.
        /// </summary>
        public virtual int? Key { get; set; }

        /// <summary>
        /// Represents the order of sorting.
        /// </summary>
        public virtual string SortOrder { get; set; }

        /// <summary>
        /// This class includes a property named CustomList that is an array of strings with both getter and setter methods.
        /// </summary>
        public virtual List<string> CustomList { get; set; }

        /// <summary>
        /// Indicates the order of sorting.
        /// </summary>
        public virtual string Order { get; set; }

        /// <summary>
        /// Gets the sorted column index(absolute position, column A is 0, B is 1, ...).
        /// </summary>
        public virtual int? Index { get; set; }

        /// <summary>
        /// Represents the type of sorting.
        /// </summary>
        public virtual string Type { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SortKey {\n");
            sb.Append("  Key: ").Append(this.Key).Append("\n");
            sb.Append("  SortOrder: ").Append(this.SortOrder).Append("\n");
            sb.Append("  CustomList: ").Append(this.CustomList).Append("\n");
            sb.Append("  Order: ").Append(this.Order).Append("\n");
            sb.Append("  Index: ").Append(this.Index).Append("\n");
            sb.Append("  Type: ").Append(this.Type).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
