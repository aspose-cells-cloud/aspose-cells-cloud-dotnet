// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ImportDoubleArrayOption.cs">
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
    /// Class summary: The features include grammar and spell check, word count, readability analysis, and style suggestions for improving writing.
    /// </summary>
    public class ImportDoubleArrayOption : ImportOption
    {
        /// <summary>
        /// This class has a public property named FirstRow of type integer with both get and set accessors.
        /// </summary>
        public virtual int? FirstRow { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual int? FirstColumn { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual bool? IsVertical { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual List<double?> Data { get; set; }

        /// <summary>
        /// Gets or sets DestinationWorksheet.
        /// </summary>
        public override string DestinationWorksheet { get; set; }

        /// <summary>
        /// Gets or sets IsInsert.
        /// </summary>
        public override bool? IsInsert { get; set; }

        /// <summary>
        /// Gets or sets ImportDataType.
        /// </summary>
        public override string ImportDataType { get; set; }

        /// <summary>
        /// Gets or sets DataSource.
        /// </summary>
        public override DataSource DataSource { get; set; }

        /// <summary>
        /// Gets or sets Source.
        /// </summary>
        public override FileSource Source { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ImportDoubleArrayOption {\n");
            sb.Append("  FirstRow: ").Append(this.FirstRow).Append("\n");
            sb.Append("  FirstColumn: ").Append(this.FirstColumn).Append("\n");
            sb.Append("  IsVertical: ").Append(this.IsVertical).Append("\n");
            sb.Append("  Data: ").Append(this.Data).Append("\n");
            sb.Append("  DestinationWorksheet: ").Append(this.DestinationWorksheet).Append("\n");
            sb.Append("  IsInsert: ").Append(this.IsInsert).Append("\n");
            sb.Append("  ImportDataType: ").Append(this.ImportDataType).Append("\n");
            sb.Append("  DataSource: ").Append(this.DataSource).Append("\n");
            sb.Append("  Source: ").Append(this.Source).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
