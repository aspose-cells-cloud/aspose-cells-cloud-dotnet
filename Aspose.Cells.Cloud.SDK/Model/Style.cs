// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="Style.cs">
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
    /// Style.
    /// </summary>
    public class Style
    {
        /// <summary>
        /// Gets or sets Font.
        /// </summary>
        public virtual Font Font { get; set; }

        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        public virtual string Name { get; set; }

        /// <summary>
        /// Gets or sets CultureCustom.
        /// </summary>
        public virtual string CultureCustom { get; set; }

        /// <summary>
        /// Gets or sets Custom.
        /// </summary>
        public virtual string Custom { get; set; }

        /// <summary>
        /// Gets or sets BackgroundColor.
        /// </summary>
        public virtual Color BackgroundColor { get; set; }

        /// <summary>
        /// Gets or sets ForegroundColor.
        /// </summary>
        public virtual Color ForegroundColor { get; set; }

        /// <summary>
        /// Gets or sets IsFormulaHidden.
        /// </summary>
        public virtual bool? IsFormulaHidden { get; set; }

        /// <summary>
        /// Gets or sets IsDateTime.
        /// </summary>
        public virtual bool? IsDateTime { get; set; }

        /// <summary>
        /// Gets or sets IsTextWrapped.
        /// </summary>
        public virtual bool? IsTextWrapped { get; set; }

        /// <summary>
        /// Gets or sets IsGradient.
        /// </summary>
        public virtual bool? IsGradient { get; set; }

        /// <summary>
        /// Gets or sets IsLocked.
        /// </summary>
        public virtual bool? IsLocked { get; set; }

        /// <summary>
        /// Gets or sets IsPercent.
        /// </summary>
        public virtual bool? IsPercent { get; set; }

        /// <summary>
        /// Gets or sets ShrinkToFit.
        /// </summary>
        public virtual bool? ShrinkToFit { get; set; }

        /// <summary>
        /// Gets or sets IndentLevel.
        /// </summary>
        public virtual int? IndentLevel { get; set; }

        /// <summary>
        /// Gets or sets Number.
        /// </summary>
        public virtual int? Number { get; set; }

        /// <summary>
        /// Gets or sets RotationAngle.
        /// </summary>
        public virtual int? RotationAngle { get; set; }

        /// <summary>
        /// Gets or sets Pattern.
        /// </summary>
        public virtual string Pattern { get; set; }

        /// <summary>
        /// Gets or sets TextDirection.
        /// </summary>
        public virtual string TextDirection { get; set; }

        /// <summary>
        /// Gets or sets VerticalAlignment.
        /// </summary>
        public virtual string VerticalAlignment { get; set; }

        /// <summary>
        /// Gets or sets HorizontalAlignment.
        /// </summary>
        public virtual string HorizontalAlignment { get; set; }

        /// <summary>
        /// Gets or sets BorderCollection.
        /// </summary>
        public virtual IList<Border> BorderCollection { get; set; }

        /// <summary>
        /// Gets or sets BackgroundThemeColor.
        /// </summary>
        public virtual ThemeColor BackgroundThemeColor { get; set; }

        /// <summary>
        /// Gets or sets ForegroundThemeColor.
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
