// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ConvertTextOptions.cs">
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
    /// Class summary: The features of the new smartphone include a high-resolution display, multiple camera lenses for versatile photography, a fast processor for seamless performance, and a larger battery for extended usage time.
    /// </summary>
    public class ConvertTextOptions : BaseOperateOptions
    {
        /// <summary>
        /// The class has a public property called "Name" of type string that can be accessed and modified.
        /// </summary>
        public override string Name { get; set; }

        /// <summary>
        /// Represents data source.  There are three types of data, they are CloudFileSystem, RequestFiles, HttpUri.
        /// </summary>
        public virtual DataSource DataSource { get; set; }

        /// <summary>
        /// Represents file information. Include of filename, filesize, and file content(base64String).
        /// </summary>
        public virtual FileInfo FileInfo { get; set; }

        /// <summary>
        /// Specifies the range of cells within the worksheet where the spreadsheet operations will be performed. This parameter allows users to define the exact area to be processed, ensuring that operations are applied only to the designated cells.
        /// </summary>
        public virtual ScopeOptions ScopeOptions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual string ConvertTextType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual string SourceCharacters { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual string TargetCharacters { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConvertTextOptions {\n");
            sb.Append("  Name: ").Append(this.Name).Append("\n");
            sb.Append("  DataSource: ").Append(this.DataSource).Append("\n");
            sb.Append("  FileInfo: ").Append(this.FileInfo).Append("\n");
            sb.Append("  ScopeOptions: ").Append(this.ScopeOptions).Append("\n");
            sb.Append("  ConvertTextType: ").Append(this.ConvertTextType).Append("\n");
            sb.Append("  SourceCharacters: ").Append(this.SourceCharacters).Append("\n");
            sb.Append("  TargetCharacters: ").Append(this.TargetCharacters).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
