// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="Area.cs">
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
    ///            Encapsulates the object that represents an area format.
    ///            
    /// </summary>
    public class Area
    {
        /// <summary>
        /// Gets or sets the background  of the .
        ///  
        /// </summary>
        public virtual Color BackgroundColor { get; set; }

        /// <summary>
        /// Represents a  object that contains fill formatting properties for the specified chart or shape.
        ///  
        /// </summary>
        public virtual FillFormat FillFormat { get; set; }

        /// <summary>
        /// Gets or sets the foreground .
        ///  
        /// </summary>
        public virtual Color ForegroundColor { get; set; }

        /// <summary>
        /// Gets or sets Format.
        /// </summary>
        public virtual string Format { get; set; }

        /// <summary>
        /// If the property is true and the value of chart point is a negative number,
        ///             the foreground color and background color will be exchanged.
        ///  
        /// </summary>
        public virtual bool? InvertIfNegative { get; set; }

        /// <summary>
        /// Returns or sets the degree of transparency of the area as a value from 0.0 (opaque) through 1.0 (clear).
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
            sb.Append("class Area {\n");
            sb.Append("  BackgroundColor: ").Append(this.BackgroundColor).Append("\n");
            sb.Append("  FillFormat: ").Append(this.FillFormat).Append("\n");
            sb.Append("  ForegroundColor: ").Append(this.ForegroundColor).Append("\n");
            sb.Append("  Format: ").Append(this.Format).Append("\n");
            sb.Append("  InvertIfNegative: ").Append(this.InvertIfNegative).Append("\n");
            sb.Append("  Transparency: ").Append(this.Transparency).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
