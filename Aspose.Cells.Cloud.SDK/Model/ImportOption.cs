// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ImportOption.cs">
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
    /// Class Summary: This class covers the features of artificial intelligence, machine learning, deep learning, and natural language processing.
    /// </summary>
    public class ImportOption
    {
        /// <summary>
        /// Destination worksheet name.  
        /// </summary>
        public virtual string DestinationWorksheet { get; set; }

        /// <summary>
        /// A boolean property `IsInsert` that can be both read and written.
        /// </summary>
        public virtual bool? IsInsert { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual string ImportDataType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual DataSource DataSource { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual FileSource Source { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ImportOption {\n");
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
