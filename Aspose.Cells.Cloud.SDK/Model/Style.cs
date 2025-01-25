// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="Style.cs">
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
    ///            Represents display style of excel document,such as font,color,alignment,border,etc.            The Style object contains all style attributes (font, number format, alignment, and so on) as properties.
    ///            
    /// </summary>
    public class Style
    {
        /// <summary>
        /// Gets a  object.
        ///  
        /// </summary>
        public virtual Font Font { get; set; }

        /// <summary>
        /// Gets or sets the name of the style.
        ///  
        /// </summary>
        public virtual string Name { get; set; }

        /// <summary>
        /// Gets and sets the culture-dependent pattern string for number format.
        ///             If no number format has been set for this object, null will be returned.
        ///             If number format is builtin, the pattern string corresponding to the builtin number will be returned.
        ///  
        /// </summary>
        public virtual string CultureCustom { get; set; }

        /// <summary>
        /// Represents the custom number format string of this style object.
        ///             If the custom number format is not set(For example, the number format is builtin), "" will be returned.
        ///  
        /// </summary>
        public virtual string Custom { get; set; }

        /// <summary>
        /// Gets or sets a style's background color.
        ///  
        /// </summary>
        public virtual Color BackgroundColor { get; set; }

        /// <summary>
        /// Gets or sets a style's foreground color.
        ///  
        /// </summary>
        public virtual Color ForegroundColor { get; set; }

        /// <summary>
        /// Represents if the formula will be hidden when the worksheet is protected.
        ///  
        /// </summary>
        public virtual bool? IsFormulaHidden { get; set; }

        /// <summary>
        /// Indicates whether the number format is a date format.
        ///  
        /// </summary>
        public virtual bool? IsDateTime { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the text within a cell is wrapped.
        ///  
        /// </summary>
        public virtual bool? IsTextWrapped { get; set; }

        /// <summary>
        /// Indicates whether the cell shading is a gradient pattern.
        ///  
        /// </summary>
        public virtual bool? IsGradient { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether a cell can be modified or not.
        ///  
        /// </summary>
        public virtual bool? IsLocked { get; set; }

        /// <summary>
        /// Indicates whether the number format is a percent format.
        ///  
        /// </summary>
        public virtual bool? IsPercent { get; set; }

        /// <summary>
        /// Represents if text automatically shrinks to fit in the available column width.
        ///  
        /// </summary>
        public virtual bool? ShrinkToFit { get; set; }

        /// <summary>
        /// Represents the indent level for the cell or range. Can only be an integer from 0 to 250.
        ///  
        /// </summary>
        public virtual int? IndentLevel { get; set; }

        /// <summary>
        /// Gets or sets the display format of numbers and dates. The formatting patterns are different for different regions.
        ///  
        /// </summary>
        public virtual int? Number { get; set; }

        /// <summary>
        /// Represents text rotation angle.
        ///  
        /// </summary>
        public virtual int? RotationAngle { get; set; }

        /// <summary>
        /// Gets or sets the cell background pattern type.
        ///  
        /// </summary>
        public virtual string Pattern { get; set; }

        /// <summary>
        /// Represents text reading order.
        ///  
        /// </summary>
        public virtual string TextDirection { get; set; }

        /// <summary>
        /// Gets or sets the vertical alignment type of the text in a cell.
        ///  
        /// </summary>
        public virtual string VerticalAlignment { get; set; }

        /// <summary>
        /// Gets or sets the horizontal alignment type of the text in a cell.
        ///  
        /// </summary>
        public virtual string HorizontalAlignment { get; set; }

        /// <summary>
        /// Gets or sets BorderCollection.
        /// </summary>
        public virtual IList<Border> BorderCollection { get; set; }

        /// <summary>
        /// Gets and sets the background theme color.
        ///  
        /// </summary>
        public virtual ThemeColor BackgroundThemeColor { get; set; }

        /// <summary>
        /// Gets and sets the foreground theme color.
        ///  
        /// </summary>
        public virtual ThemeColor ForegroundThemeColor { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Style {\n");
            sb.Append("  Font: ").Append(this.Font).Append("\n");
            sb.Append("  Name: ").Append(this.Name).Append("\n");
            sb.Append("  CultureCustom: ").Append(this.CultureCustom).Append("\n");
            sb.Append("  Custom: ").Append(this.Custom).Append("\n");
            sb.Append("  BackgroundColor: ").Append(this.BackgroundColor).Append("\n");
            sb.Append("  ForegroundColor: ").Append(this.ForegroundColor).Append("\n");
            sb.Append("  IsFormulaHidden: ").Append(this.IsFormulaHidden).Append("\n");
            sb.Append("  IsDateTime: ").Append(this.IsDateTime).Append("\n");
            sb.Append("  IsTextWrapped: ").Append(this.IsTextWrapped).Append("\n");
            sb.Append("  IsGradient: ").Append(this.IsGradient).Append("\n");
            sb.Append("  IsLocked: ").Append(this.IsLocked).Append("\n");
            sb.Append("  IsPercent: ").Append(this.IsPercent).Append("\n");
            sb.Append("  ShrinkToFit: ").Append(this.ShrinkToFit).Append("\n");
            sb.Append("  IndentLevel: ").Append(this.IndentLevel).Append("\n");
            sb.Append("  Number: ").Append(this.Number).Append("\n");
            sb.Append("  RotationAngle: ").Append(this.RotationAngle).Append("\n");
            sb.Append("  Pattern: ").Append(this.Pattern).Append("\n");
            sb.Append("  TextDirection: ").Append(this.TextDirection).Append("\n");
            sb.Append("  VerticalAlignment: ").Append(this.VerticalAlignment).Append("\n");
            sb.Append("  HorizontalAlignment: ").Append(this.HorizontalAlignment).Append("\n");
            sb.Append("  BorderCollection: ").Append(this.BorderCollection).Append("\n");
            sb.Append("  BackgroundThemeColor: ").Append(this.BackgroundThemeColor).Append("\n");
            sb.Append("  ForegroundThemeColor: ").Append(this.ForegroundThemeColor).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
