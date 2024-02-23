// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="AnalyzeSuggestion.cs">
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
    /// 
    /// </summary>
    public class AnalyzeSuggestion
    {
        /// <summary>
        /// 
        /// </summary>
        public virtual string Name { get; set; }

        /// <summary>
        /// Excel file name.
        /// </summary>
        public virtual string Filename { get; set; }

        /// <summary>
        /// The worksheet where the data is aAnalyzed.
        /// </summary>
        public virtual string SheetName { get; set; }

        /// <summary>
        /// The type of data being analyzed.
        /// </summary>
        public virtual string DateSourceType { get; set; }

        /// <summary>
        /// Based on the results of the data analysis, suggestions for creating new data types are given.
        /// </summary>
        public virtual string SuggestedOutputType { get; set; }

        /// <summary>
        /// Based on the results of the data analysis, a business description of the new data object is created.
        /// </summary>
        public virtual string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual string DataSouceThumbnail { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual string Thumbnail { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AnalyzeSuggestion {\n");
            sb.Append("  Name: ").Append(this.Name).Append("\n");
            sb.Append("  Filename: ").Append(this.Filename).Append("\n");
            sb.Append("  SheetName: ").Append(this.SheetName).Append("\n");
            sb.Append("  DateSourceType: ").Append(this.DateSourceType).Append("\n");
            sb.Append("  SuggestedOutputType: ").Append(this.SuggestedOutputType).Append("\n");
            sb.Append("  Description: ").Append(this.Description).Append("\n");
            sb.Append("  DataSouceThumbnail: ").Append(this.DataSouceThumbnail).Append("\n");
            sb.Append("  Thumbnail: ").Append(this.Thumbnail).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
