// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="RangeCopyRequest.cs">
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
    /// Indicates range copy request
    /// </summary>
    public class RangeCopyRequest
    {
        /// <summary>
        /// copydata, copystyle, copyto, copyvalue.
        /// </summary>
        public virtual string Operate { get; set; }

        /// <summary>
        /// Source range. 
        /// </summary>
        public virtual Range Source { get; set; }

        /// <summary>
        /// Target range.
        /// </summary>
        public virtual Range Target { get; set; }

        /// <summary>
        /// Represents the paste special options.
        ///             
        /// </summary>
        public virtual PasteOptions PasteOptions { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RangeCopyRequest {\n");
            sb.Append("  Operate: ").Append(this.Operate).Append("\n");
            sb.Append("  Source: ").Append(this.Source).Append("\n");
            sb.Append("  Target: ").Append(this.Target).Append("\n");
            sb.Append("  PasteOptions: ").Append(this.PasteOptions).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
