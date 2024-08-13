// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="TrimContentOptions.cs">
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
    /// TrimContentOptions.
    /// </summary>
    public class TrimContentOptions
    {
        /// <summary>
        /// Gets or sets DataSource.
        /// </summary>
        public virtual DataSource DataSource { get; set; }

        /// <summary>
        /// Gets or sets FileInfo.
        /// </summary>
        public virtual FileInfo FileInfo { get; set; }

        /// <summary>
        /// Gets or sets TrimContent.
        /// </summary>
        public virtual string TrimContent { get; set; }

        /// <summary>
        /// Gets or sets TrimLeading.
        /// </summary>
        public virtual bool? TrimLeading { get; set; }

        /// <summary>
        /// Gets or sets TrimTrailing.
        /// </summary>
        public virtual bool? TrimTrailing { get; set; }

        /// <summary>
        /// Gets or sets TrimSpaceBetweenWordTo1.
        /// </summary>
        public virtual bool? TrimSpaceBetweenWordTo1 { get; set; }

        /// <summary>
        /// Gets or sets TrimNonBreakingSpaces.
        /// </summary>
        public virtual bool? TrimNonBreakingSpaces { get; set; }

        /// <summary>
        /// Gets or sets RemoveExtraLineBreaks.
        /// </summary>
        public virtual bool? RemoveExtraLineBreaks { get; set; }

        /// <summary>
        /// Gets or sets RemoveAllLineBreaks.
        /// </summary>
        public virtual bool? RemoveAllLineBreaks { get; set; }

        /// <summary>
        /// Gets or sets ScopeOptions.
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
