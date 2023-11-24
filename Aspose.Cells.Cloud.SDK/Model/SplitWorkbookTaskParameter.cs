// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="SplitWorkbookTaskParameter.cs">
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
    /// 
    /// </summary>
    public class SplitWorkbookTaskParameter : TaskParameter
    {
        /// <summary>
        /// 
        /// </summary>
        public virtual FileSource Workbook { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual FileSource DestinationFilePosition { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual string DestinationFileFormat { get; set; }

        /// <summary>
        /// SheetName /NewGuid
        /// </summary>
        public virtual string SplitNameRule { get; set; }

        /// <summary>
        /// When destination file format is image , vertical resolution can not be null.
        /// </summary>
        public virtual int? VerticalResolution { get; set; }

        /// <summary>
        /// When destination file format is image , horizontal resolution can not be null.
        /// </summary>
        public virtual int? HorizontalResolution { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SplitWorkbookTaskParameter {\n");
            sb.Append("  Workbook: ").Append(this.Workbook).Append("\n");
            sb.Append("  DestinationFilePosition: ").Append(this.DestinationFilePosition).Append("\n");
            sb.Append("  DestinationFileFormat: ").Append(this.DestinationFileFormat).Append("\n");
            sb.Append("  SplitNameRule: ").Append(this.SplitNameRule).Append("\n");
            sb.Append("  VerticalResolution: ").Append(this.VerticalResolution).Append("\n");
            sb.Append("  HorizontalResolution: ").Append(this.HorizontalResolution).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
