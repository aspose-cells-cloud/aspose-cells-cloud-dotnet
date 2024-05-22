// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="Comment.cs">
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
    public class Comment : LinkElement
    {
        /// <summary>
        /// 
        /// </summary>
        public virtual string CellName { get; set; }

        /// <summary>
        /// Gets and sets Name of the original comment author
        /// </summary>
        public virtual string Author { get; set; }

        /// <summary>
        /// Gets and sets the html string which contains data and some formats in this comment.
        /// </summary>
        public virtual string HtmlNote { get; set; }

        /// <summary>
        /// Represents the content of comment.
        /// </summary>
        public virtual string Note { get; set; }

        /// <summary>
        /// Indicates if size of comment is adjusted automatically according to its content.
        /// </summary>
        public virtual bool? AutoSize { get; set; }

        /// <summary>
        /// Represents if the comment is visible or not.
        /// </summary>
        public virtual bool? IsVisible { get; set; }

        /// <summary>
        /// Represents the width of the comment, in unit of pixels.
        /// </summary>
        public virtual int? Width { get; set; }

        /// <summary>
        /// Represents the Height of the comment, in unit of pixels.
        /// </summary>
        public virtual int? Height { get; set; }

        /// <summary>
        /// Gets and sets the text horizontal alignment type of the comment.
        /// </summary>
        public virtual string TextHorizontalAlignment { get; set; }

        /// <summary>
        /// Gets and sets the text orientation type of the comment.
        /// </summary>
        public virtual string TextOrientationType { get; set; }

        /// <summary>
        /// Gets and sets the text vertical alignment type of the comment.
        /// </summary>
        public virtual string TextVerticalAlignment { get; set; }

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
            sb.Append("class Comment {\n");
            sb.Append("  CellName: ").Append(this.CellName).Append("\n");
            sb.Append("  Author: ").Append(this.Author).Append("\n");
            sb.Append("  HtmlNote: ").Append(this.HtmlNote).Append("\n");
            sb.Append("  Note: ").Append(this.Note).Append("\n");
            sb.Append("  AutoSize: ").Append(this.AutoSize).Append("\n");
            sb.Append("  IsVisible: ").Append(this.IsVisible).Append("\n");
            sb.Append("  Width: ").Append(this.Width).Append("\n");
            sb.Append("  Height: ").Append(this.Height).Append("\n");
            sb.Append("  TextHorizontalAlignment: ").Append(this.TextHorizontalAlignment).Append("\n");
            sb.Append("  TextOrientationType: ").Append(this.TextOrientationType).Append("\n");
            sb.Append("  TextVerticalAlignment: ").Append(this.TextVerticalAlignment).Append("\n");
            sb.Append("  link: ").Append(this.link).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
