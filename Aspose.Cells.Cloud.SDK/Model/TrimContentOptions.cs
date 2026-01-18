// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="TrimContentOptions.cs">
//   Copyright (c) 2026 Aspose.Cells Cloud
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
    /// 
    /// </summary>
    public class TrimContentOptions
    {
        /// <summary>
        /// Represents data source.  There are three types of data, they are CloudFileSystem, RequestFiles, HttpUri.
        /// </summary>
        public virtual DataSource DataSource { get; set; }

        /// <summary>
        /// Represents file information. Include of filename, filesize, and file content(base64String).
        /// </summary>
        public virtual FileInfo FileInfo { get; set; }

        /// <summary>
        /// Trim Content
        /// </summary>
        public virtual string TrimContent { get; set; }

        /// <summary>
        /// If the trim leading value is true, the trim content before and after cell values will be deleted.
        /// </summary>
        public virtual bool? TrimLeading { get; set; }

        /// <summary>
        /// If the trim trailing value is true, the trim content before and after cell values will be deleted.
        /// </summary>
        public virtual bool? TrimTrailing { get; set; }

        /// <summary>
        /// When the trim space between word to 1 parameter is true, it enables the removal of extra spaces between words within a cell, ensuring that only a single space is maintained between words.
        /// </summary>
        public virtual bool? TrimSpaceBetweenWordTo1 { get; set; }

        /// <summary>
        /// Gets or sets TrimNonBreakingSpaces.
        /// </summary>
        public virtual bool? TrimNonBreakingSpaces { get; set; }

        /// <summary>
        /// When this parameter is enabled (set to True), it deletes extra line breaks within the selected range, ensuring that only necessary line breaks are retained.
        /// </summary>
        public virtual bool? RemoveExtraLineBreaks { get; set; }

        /// <summary>
        /// When this parameter is enabled (set to True), it removes all line breaks within the selected range, resulting in a continuous block of text without any line breaks.
        /// </summary>
        public virtual bool? RemoveAllLineBreaks { get; set; }

        /// <summary>
        /// Specifies the range of cells within the worksheet where the spreadsheet operations will be performed. This parameter allows users to define the exact area to be processed, ensuring that operations are applied only to the designated cells.
        /// </summary>
        public virtual ScopeOptions ScopeOptions { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TrimContentOptions {\n");
            sb.Append("  DataSource: ").Append(this.DataSource).Append("\n");
            sb.Append("  FileInfo: ").Append(this.FileInfo).Append("\n");
            sb.Append("  TrimContent: ").Append(this.TrimContent).Append("\n");
            sb.Append("  TrimLeading: ").Append(this.TrimLeading).Append("\n");
            sb.Append("  TrimTrailing: ").Append(this.TrimTrailing).Append("\n");
            sb.Append("  TrimSpaceBetweenWordTo1: ").Append(this.TrimSpaceBetweenWordTo1).Append("\n");
            sb.Append("  TrimNonBreakingSpaces: ").Append(this.TrimNonBreakingSpaces).Append("\n");
            sb.Append("  RemoveExtraLineBreaks: ").Append(this.RemoveExtraLineBreaks).Append("\n");
            sb.Append("  RemoveAllLineBreaks: ").Append(this.RemoveAllLineBreaks).Append("\n");
            sb.Append("  ScopeOptions: ").Append(this.ScopeOptions).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
