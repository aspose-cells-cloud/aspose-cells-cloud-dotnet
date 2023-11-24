// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="Border.cs">
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
    /// Border.
    /// </summary>
    public class Border
    {
        /// <summary>
        /// Gets or sets the cell border type.
        ///  
        /// </summary>
        public virtual string LineStyle { get; set; }

        /// <summary>
        /// Gets or sets the  of the border.
        ///  
        /// </summary>
        public virtual Color Color { get; set; }

        /// <summary>
        /// Gets or sets BorderType.
        /// </summary>
        public virtual string BorderType { get; set; }

        /// <summary>
        /// Gets and sets the theme color of the border.
        ///  
        /// </summary>
        public virtual ThemeColor ThemeColor { get; set; }

        /// <summary>
        /// Gets and sets the color with a 32-bit ARGB value.
        ///  
        /// </summary>
        public virtual int? ArgbColor { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Border {\n");
            sb.Append("  LineStyle: ").Append(this.LineStyle).Append("\n");
            sb.Append("  Color: ").Append(this.Color).Append("\n");
            sb.Append("  BorderType: ").Append(this.BorderType).Append("\n");
            sb.Append("  ThemeColor: ").Append(this.ThemeColor).Append("\n");
            sb.Append("  ArgbColor: ").Append(this.ArgbColor).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
