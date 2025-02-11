// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="TextOptions.cs">
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
    /// Represents the text options.
    /// </summary>
    public class TextOptions : Font
    {
        /// <summary>
        /// Represents fill format.
        /// </summary>
        public virtual FillFormat Fill { get; set; }

        /// <summary>
        /// Represents kerning.
        /// </summary>
        public virtual double? Kerning { get; set; }

        /// <summary>
        /// Represents outline format.
        /// </summary>
        public virtual LineFormat Outline { get; set; }

        /// <summary>
        /// Represents shadow effect.
        /// </summary>
        public virtual ShadowEffect Shadow { get; set; }

        /// <summary>
        /// Represents spacing.
        /// </summary>
        public virtual double? Spacing { get; set; }

        /// <summary>
        /// Represents under line color.
        /// </summary>
        public virtual CellsColor UnderlineColor { get; set; }

        /// <summary>
        /// Gets or sets Color.
        /// </summary>
        public override Color Color { get; set; }

        /// <summary>
        /// Gets or sets DoubleSize.
        /// </summary>
        public override double? DoubleSize { get; set; }

        /// <summary>
        /// Gets or sets IsBold.
        /// </summary>
        public override bool? IsBold { get; set; }

        /// <summary>
        /// Gets or sets IsItalic.
        /// </summary>
        public override bool? IsItalic { get; set; }

        /// <summary>
        /// Gets or sets IsStrikeout.
        /// </summary>
        public override bool? IsStrikeout { get; set; }

        /// <summary>
        /// Gets or sets IsSubscript.
        /// </summary>
        public override bool? IsSubscript { get; set; }

        /// <summary>
        /// Gets or sets IsSuperscript.
        /// </summary>
        public override bool? IsSuperscript { get; set; }

        /// <summary>
        /// The class has a public property named "Name" with a getter and setter method.
        /// </summary>
        public override string Name { get; set; }

        /// <summary>
        /// Gets or sets Size.
        /// </summary>
        public override int? Size { get; set; }

        /// <summary>
        /// Gets or sets Underline.
        /// </summary>
        public override string Underline { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TextOptions {\n");
            sb.Append("  Fill: ").Append(this.Fill).Append("\n");
            sb.Append("  Kerning: ").Append(this.Kerning).Append("\n");
            sb.Append("  Outline: ").Append(this.Outline).Append("\n");
            sb.Append("  Shadow: ").Append(this.Shadow).Append("\n");
            sb.Append("  Spacing: ").Append(this.Spacing).Append("\n");
            sb.Append("  UnderlineColor: ").Append(this.UnderlineColor).Append("\n");
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
