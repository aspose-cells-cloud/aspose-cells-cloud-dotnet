// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="Row.cs">
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
    /// Row.
    /// </summary>
    public class Row : LinkElement
    {
        /// <summary>
        /// Gets or sets GroupLevel.
        /// </summary>
        public virtual int? GroupLevel { get; set; }

        /// <summary>
        /// Gets or sets Height.
        /// </summary>
        public virtual double? Height { get; set; }

        /// <summary>
        /// Gets or sets Index.
        /// </summary>
        public virtual int? Index { get; set; }

        /// <summary>
        /// Gets or sets IsBlank.
        /// </summary>
        public virtual bool? IsBlank { get; set; }

        /// <summary>
        /// Gets or sets IsHeightMatched.
        /// </summary>
        public virtual bool? IsHeightMatched { get; set; }

        /// <summary>
        /// Gets or sets IsHidden.
        /// </summary>
        public virtual bool? IsHidden { get; set; }

        /// <summary>
        /// Gets or sets Style.
        /// </summary>
        public virtual LinkElement Style { get; set; }

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
            sb.Append("class Row {\n");
            sb.Append("  GroupLevel: ").Append(this.GroupLevel).Append("\n");
            sb.Append("  Height: ").Append(this.Height).Append("\n");
            sb.Append("  Index: ").Append(this.Index).Append("\n");
            sb.Append("  IsBlank: ").Append(this.IsBlank).Append("\n");
            sb.Append("  IsHeightMatched: ").Append(this.IsHeightMatched).Append("\n");
            sb.Append("  IsHidden: ").Append(this.IsHidden).Append("\n");
            sb.Append("  Style: ").Append(this.Style).Append("\n");
            sb.Append("  link: ").Append(this.link).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
