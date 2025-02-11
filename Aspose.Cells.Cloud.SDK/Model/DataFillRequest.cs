// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="DataFillRequest.cs">
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
    /// I'm happy to help! Please provide the features you would like me to summarize.
    /// </summary>
    public class DataFillRequest
    {
        /// <summary>
        /// Spreadsheet files that require data fulling. 
        /// </summary>
        public virtual FileInfo File { get; set; }

        /// <summary>
        /// finish to data cleansing, outfile`s file format.
        /// </summary>
        public virtual string OutFileFormat { get; set; }

        /// <summary>
        /// Whether check restriction of Spreadsheet file when user modify cells related objects.
        /// </summary>
        public virtual bool? CheckExcelRestriction { get; set; }

        /// <summary>
        /// The regional settings for workbook.
        /// </summary>
        public virtual string Region { get; set; }

        /// <summary>
        /// Fill data default value.
        /// </summary>
        public virtual DataFill DataFill { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DataFillRequest {\n");
            sb.Append("  File: ").Append(this.File).Append("\n");
            sb.Append("  OutFileFormat: ").Append(this.OutFileFormat).Append("\n");
            sb.Append("  CheckExcelRestriction: ").Append(this.CheckExcelRestriction).Append("\n");
            sb.Append("  Region: ").Append(this.Region).Append("\n");
            sb.Append("  DataFill: ").Append(this.DataFill).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
