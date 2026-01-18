// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="Top10Filter.cs">
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
    ///            Represents the top 10 filter.
    ///            
    /// </summary>
    public class Top10Filter
    {
        /// <summary>
        /// An integer property named FieldIndex that can be accessed and modified.
        ///             
        /// </summary>
        public virtual int? FieldIndex { get; set; }

        /// <summary>
        ///  
        /// </summary>
        public virtual string Criteria { get; set; }

        /// <summary>
        /// Indicates whether the items is percent.
        ///  
        /// </summary>
        public virtual bool? IsPercent { get; set; }

        /// <summary>
        /// Indicates whether it's top filter.
        ///  
        /// </summary>
        public virtual bool? IsTop { get; set; }

        /// <summary>
        /// Gets and sets the items of the filter.
        ///  
        /// </summary>
        public virtual int? Items { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Top10Filter {\n");
            sb.Append("  FieldIndex: ").Append(this.FieldIndex).Append("\n");
            sb.Append("  Criteria: ").Append(this.Criteria).Append("\n");
            sb.Append("  IsPercent: ").Append(this.IsPercent).Append("\n");
            sb.Append("  IsTop: ").Append(this.IsTop).Append("\n");
            sb.Append("  Items: ").Append(this.Items).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
