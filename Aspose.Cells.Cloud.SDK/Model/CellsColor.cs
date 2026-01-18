// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="CellsColor.cs">
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
    ///            Represents all types of color.
    ///            
    /// </summary>
    public class CellsColor
    {
        /// <summary>
        /// Gets and sets the RGB color.
        ///  
        /// </summary>
        public virtual Color Color { get; set; }

        /// <summary>
        /// Gets and sets the color index in the color palette. Only applies of indexed color.
        ///  
        /// </summary>
        public virtual int? ColorIndex { get; set; }

        /// <summary>
        /// Gets and set the color which should apply to cell or shape.
        ///  
        /// </summary>
        public virtual bool? IsShapeColor { get; set; }

        /// <summary>
        /// Set the tint of the shape color
        /// </summary>
        public virtual double? tint { get; set; }

        /// <summary>
        /// Gets and sets the color from a 32-bit ARGB value.
        ///  
        /// </summary>
        public virtual int? Argb { get; set; }

        /// <summary>
        /// Gets the theme color. Only applies for theme color type.
        ///  
        /// </summary>
        public virtual ThemeColor ThemeColor { get; set; }

        /// <summary>
        /// The color type.
        ///  
        /// </summary>
        public virtual string Type { get; set; }

        /// <summary>
        /// Gets and sets transparency as a value from 0.0 (opaque) through 1.0 (clear).
        ///  
        /// </summary>
        public virtual double? Transparency { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CellsColor {\n");
            sb.Append("  Color: ").Append(this.Color).Append("\n");
            sb.Append("  ColorIndex: ").Append(this.ColorIndex).Append("\n");
            sb.Append("  IsShapeColor: ").Append(this.IsShapeColor).Append("\n");
            sb.Append("  tint: ").Append(this.tint).Append("\n");
            sb.Append("  Argb: ").Append(this.Argb).Append("\n");
            sb.Append("  ThemeColor: ").Append(this.ThemeColor).Append("\n");
            sb.Append("  Type: ").Append(this.Type).Append("\n");
            sb.Append("  Transparency: ").Append(this.Transparency).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
