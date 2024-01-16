// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="Font.cs">
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
    /// Font.
    /// </summary>
    public class Font
    {
        /// <summary>
        /// Gets or sets the  of the font.
        ///  
        /// </summary>
        public virtual Color Color { get; set; }

        /// <summary>
        /// Gets and sets the double size of the font.
        ///  
        /// </summary>
        public virtual double? DoubleSize { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the font is bold.
        ///  
        /// </summary>
        public virtual bool? IsBold { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the font is italic.
        ///  
        /// </summary>
        public virtual bool? IsItalic { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the font is single strikeout.
        ///  
        /// </summary>
        public virtual bool? IsStrikeout { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the font is subscript.
        ///  
        /// </summary>
        public virtual bool? IsSubscript { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the font is super script.
        ///  
        /// </summary>
        public virtual bool? IsSuperscript { get; set; }

        /// <summary>
        /// Gets  or sets the name of the .
        ///  
        /// </summary>
        public virtual string Name { get; set; }

        /// <summary>
        /// Gets or sets the size of the font.
        ///  
        /// </summary>
        public virtual int? Size { get; set; }

        /// <summary>
        /// Gets or sets the font underline type.
        ///  
        /// </summary>
        public virtual string Underline { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Font {\n");
            sb.Append("  Color: ").Append(this.Color).Append("\n");
            sb.Append("  DoubleSize: ").Append(this.DoubleSize).Append("\n");
            sb.Append("  IsBold: ").Append(this.IsBold).Append("\n");
            sb.Append("  IsItalic: ").Append(this.IsItalic).Append("\n");
            sb.Append("  IsStrikeout: ").Append(this.IsStrikeout).Append("\n");
            sb.Append("  IsSubscript: ").Append(this.IsSubscript).Append("\n");
            sb.Append("  IsSuperscript: ").Append(this.IsSuperscript).Append("\n");
            sb.Append("  Name: ").Append(this.Name).Append("\n");
            sb.Append("  Size: ").Append(this.Size).Append("\n");
            sb.Append("  Underline: ").Append(this.Underline).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
