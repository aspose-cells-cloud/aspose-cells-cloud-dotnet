// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="AnalyzedResult.cs">
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
    /// Represents results of analyzed data.
    /// </summary>
    public class AnalyzedResult
    {
        /// <summary>
        /// Represents the file name of data file.
        /// </summary>
        public virtual string Filename { get; set; }

        /// <summary>
        /// Represents summary about results of analyzed data.
        /// </summary>
        public virtual string Description { get; set; }

        /// <summary>
        /// Represents Excel data statistics.
        /// </summary>
        public virtual ExcelDataStatistics BasicStatistics { get; set; }

        /// <summary>
        /// Represents analyzed table description.
        /// </summary>
        public virtual IList<AnalyzedTableDescription> Results { get; set; }

        /// <summary>
        /// base64String Excel file
        /// </summary>
        public virtual string SuggestedFile { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AnalyzedResult {\n");
            sb.Append("  Filename: ").Append(this.Filename).Append("\n");
            sb.Append("  Description: ").Append(this.Description).Append("\n");
            sb.Append("  BasicStatistics: ").Append(this.BasicStatistics).Append("\n");
            sb.Append("  Results: ").Append(this.Results).Append("\n");
            sb.Append("  SuggestedFile: ").Append(this.SuggestedFile).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
