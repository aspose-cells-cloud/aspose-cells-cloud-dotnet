// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ConvertTaskParameter.cs">
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
    /// Represents convert task parameter.
    /// </summary>
    public class ConvertTaskParameter : TaskParameter
    {
        /// <summary>
        /// Represents data source of task object.
        /// </summary>
        public virtual DataSource DataSource { get; set; }

        /// <summary>
        /// Represents data source of task object.
        /// </summary>
        public virtual FileSource Workbook { get; set; }

        /// <summary>
        /// Represents destination file.
        /// </summary>
        public virtual string DestinationFile { get; set; }

        /// <summary>
        /// Represents Excel data region.
        /// </summary>
        public virtual string Region { get; set; }

        /// <summary>
        /// Represents save options.
        /// </summary>
        public virtual SaveOptions SaveOptions { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConvertTaskParameter {\n");
            sb.Append("  DataSource: ").Append(this.DataSource).Append("\n");
            sb.Append("  Workbook: ").Append(this.Workbook).Append("\n");
            sb.Append("  DestinationFile: ").Append(this.DestinationFile).Append("\n");
            sb.Append("  Region: ").Append(this.Region).Append("\n");
            sb.Append("  SaveOptions: ").Append(this.SaveOptions).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
