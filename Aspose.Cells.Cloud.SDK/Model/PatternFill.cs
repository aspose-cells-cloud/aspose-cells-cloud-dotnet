// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PatternFill.cs">
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
    ///            Encapsulates the object that represents pattern fill format
    ///            
    /// </summary>
    public class PatternFill
    {
        /// <summary>
        /// Gets or sets the fill pattern type
        ///  
        /// </summary>
        public virtual string Pattern { get; set; }

        /// <summary>
        /// Gets and sets the foreground  object.
        ///  
        /// </summary>
        public virtual CellsColor BackgroundCellsColor { get; set; }

        /// <summary>
        /// Gets and sets the foreground  object.
        ///  
        /// </summary>
        public virtual CellsColor ForegroundCellsColor { get; set; }

        /// <summary>
        /// Gets or sets the foreground .
        ///  
        /// </summary>
        public virtual Color ForegroundColor { get; set; }

        /// <summary>
        /// Gets or sets the background  of the .
        ///  
        /// </summary>
        public virtual Color BackgroundColor { get; set; }

        /// <summary>
        /// Gets or sets the transparency of background color.
        ///  
        /// </summary>
        public virtual double? BackTransparency { get; set; }

        /// <summary>
        /// Gets or sets the transparency of foreground color.
        ///  
        /// </summary>
        public virtual double? ForeTransparency { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PatternFill {\n");
            sb.Append("  Pattern: ").Append(this.Pattern).Append("\n");
            sb.Append("  BackgroundCellsColor: ").Append(this.BackgroundCellsColor).Append("\n");
            sb.Append("  ForegroundCellsColor: ").Append(this.ForegroundCellsColor).Append("\n");
            sb.Append("  ForegroundColor: ").Append(this.ForegroundColor).Append("\n");
            sb.Append("  BackgroundColor: ").Append(this.BackgroundColor).Append("\n");
            sb.Append("  BackTransparency: ").Append(this.BackTransparency).Append("\n");
            sb.Append("  ForeTransparency: ").Append(this.ForeTransparency).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
