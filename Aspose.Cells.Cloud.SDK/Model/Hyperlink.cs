// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="Hyperlink.cs">
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
    /// Encapsulates the object that represents a hyperlink.
    /// </summary>
    public class Hyperlink : LinkElement
    {
        /// <summary>
        /// Represents the address of a hyperlink.
        /// </summary>
        public virtual string Address { get; set; }

        /// <summary>
        /// Gets the range of hyperlink.
        /// </summary>
        public virtual CellArea Area { get; set; }

        /// <summary>
        /// Returns or sets the ScreenTip text for the specified hyperlink.
        /// </summary>
        public virtual string ScreenTip { get; set; }

        /// <summary>
        /// Represents the text to be displayed for the specified hyperlink. The default value is the address of the hyperlink.
        /// </summary>
        public virtual string TextToDisplay { get; set; }

        /// <summary>
        /// Gets the link type.
        /// </summary>
        public virtual string LinkType { get; set; }

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
            sb.Append("class Hyperlink {\n");
            sb.Append("  Address: ").Append(this.Address).Append("\n");
            sb.Append("  Area: ").Append(this.Area).Append("\n");
            sb.Append("  ScreenTip: ").Append(this.ScreenTip).Append("\n");
            sb.Append("  TextToDisplay: ").Append(this.TextToDisplay).Append("\n");
            sb.Append("  LinkType: ").Append(this.LinkType).Append("\n");
            sb.Append("  link: ").Append(this.link).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
