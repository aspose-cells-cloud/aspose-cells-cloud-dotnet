// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="SplitTextOptions.cs">
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
    /// Appliance features: 1. Automatic defrost system 2. Energy-efficient LED lighting 3. Adjustable glass shelves 4. Ice and water dispenser with filtration system
    /// </summary>
    public class SplitTextOptions : BaseOperateOptions
    {
        /// <summary>
        /// The property "Name" is a publicly accessible and overridable property of type string in the class.
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
        /// 
        /// </summary>
        public virtual string Worksheet { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual string Range { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual string SplitDelimitersType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual string CustomDelimiter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual bool? KeepDelimitersInResultingCells { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual string KeepDelimitersPosition { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual string HowToSplit { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SplitTextOptions {\n");
            sb.Append("  Name: ").Append(this.Name).Append("\n");
            sb.Append("  DataSource: ").Append(this.DataSource).Append("\n");
            sb.Append("  FileInfo: ").Append(this.FileInfo).Append("\n");
            sb.Append("  Worksheet: ").Append(this.Worksheet).Append("\n");
            sb.Append("  Range: ").Append(this.Range).Append("\n");
            sb.Append("  SplitDelimitersType: ").Append(this.SplitDelimitersType).Append("\n");
            sb.Append("  CustomDelimiter: ").Append(this.CustomDelimiter).Append("\n");
            sb.Append("  KeepDelimitersInResultingCells: ").Append(this.KeepDelimitersInResultingCells).Append("\n");
            sb.Append("  KeepDelimitersPosition: ").Append(this.KeepDelimitersPosition).Append("\n");
            sb.Append("  HowToSplit: ").Append(this.HowToSplit).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
