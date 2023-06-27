// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="BatchSplitRequest.cs">
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
    /// BatchSplitRequest.
    /// </summary>
    public class BatchSplitRequest
    {
        /// <summary>
        /// Gets or sets SourceFolder.
        /// </summary>
        public virtual string SourceFolder { get; set; }

        /// <summary>
        /// Gets or sets SourceStorage.
        /// </summary>
        public virtual string SourceStorage { get; set; }

        /// <summary>
        /// Gets or sets MatchCondition.
        /// </summary>
        public virtual MatchConditionRequest MatchCondition { get; set; }

        /// <summary>
        /// Gets or sets Format.
        /// </summary>
        public virtual string Format { get; set; }

        /// <summary>
        /// Gets or sets FromIndex.
        /// </summary>
        public virtual int? FromIndex { get; set; }

        /// <summary>
        /// Gets or sets ToIndex.
        /// </summary>
        public virtual int? ToIndex { get; set; }

        /// <summary>
        /// Gets or sets OutFolder.
        /// </summary>
        public virtual string OutFolder { get; set; }

        /// <summary>
        /// Gets or sets OutStorage.
        /// </summary>
        public virtual string OutStorage { get; set; }

        /// <summary>
        /// Gets or sets SaveOptions.
        /// </summary>
        public virtual SaveOptions SaveOptions { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchSplitRequest {\n");
            sb.Append("  SourceFolder: ").Append(this.SourceFolder).Append("\n");
            sb.Append("  SourceStorage: ").Append(this.SourceStorage).Append("\n");
            sb.Append("  MatchCondition: ").Append(this.MatchCondition).Append("\n");
            sb.Append("  Format: ").Append(this.Format).Append("\n");
            sb.Append("  FromIndex: ").Append(this.FromIndex).Append("\n");
            sb.Append("  ToIndex: ").Append(this.ToIndex).Append("\n");
            sb.Append("  OutFolder: ").Append(this.OutFolder).Append("\n");
            sb.Append("  OutStorage: ").Append(this.OutStorage).Append("\n");
            sb.Append("  SaveOptions: ").Append(this.SaveOptions).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
