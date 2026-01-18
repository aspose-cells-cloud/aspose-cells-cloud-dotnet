// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="MergedCell.cs">
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
    /// I'm happy to help! Could you please provide me with the features you would like me to summarize for the class?
    /// </summary>
    public class MergedCell : LinkElement
    {
        /// <summary>
        /// An integer property named "EndColumn" with the XML element name "endcolumn".
        /// </summary>
        public virtual int? EndColumn { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual int? EndRow { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual int? StartColumn { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual int? StartRow { get; set; }

        /// <summary>
        /// Gets or sets link.
        /// </summary>
        public override Link link { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MergedCell {\n");
            sb.Append("  EndColumn: ").Append(this.EndColumn).Append("\n");
            sb.Append("  EndRow: ").Append(this.EndRow).Append("\n");
            sb.Append("  StartColumn: ").Append(this.StartColumn).Append("\n");
            sb.Append("  StartRow: ").Append(this.StartRow).Append("\n");
            sb.Append("  link: ").Append(this.link).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
