// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="QueryTable.cs">
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
    /// Represents QueryTable information.
    /// </summary>
    public class QueryTable
    {
        /// <summary>
        /// Gets the connection id of the query table.
        /// </summary>
        public virtual int? ConnectionId { get; set; }

        /// <summary>
        /// Gets the name of querytable.
        /// </summary>
        public virtual string Name { get; set; }

        /// <summary>
        /// Gets the range of the result.
        /// </summary>
        public virtual Range ResultRange { get; set; }

        /// <summary>
        /// Returns or sets the PreserveFormatting of the object.
        /// </summary>
        public virtual bool? PreserveFormatting { get; set; }

        /// <summary>
        /// Returns or sets the AdjustColumnWidth of the object.
        /// </summary>
        public virtual bool? AdjustColumnWidth { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueryTable {\n");
            sb.Append("  ConnectionId: ").Append(this.ConnectionId).Append("\n");
            sb.Append("  Name: ").Append(this.Name).Append("\n");
            sb.Append("  ResultRange: ").Append(this.ResultRange).Append("\n");
            sb.Append("  PreserveFormatting: ").Append(this.PreserveFormatting).Append("\n");
            sb.Append("  AdjustColumnWidth: ").Append(this.AdjustColumnWidth).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
