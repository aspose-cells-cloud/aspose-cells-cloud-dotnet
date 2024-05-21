// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="FontSetting.cs">
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
    ///            Represents a range of characters within the cell text.
    ///            
    /// </summary>
    public class FontSetting
    {
        /// <summary>
        /// Returns the font of this object.
        ///  
        /// </summary>
        public virtual Font Font { get; set; }

        /// <summary>
        /// Gets the length of the characters.
        ///  
        /// </summary>
        public virtual int? Length { get; set; }

        /// <summary>
        /// Gets the start index of the characters.
        ///  
        /// </summary>
        public virtual int? StartIndex { get; set; }

        /// <summary>
        /// Returns the text options.
        ///  
        /// </summary>
        public virtual TextOptions TextOptions { get; set; }

        /// <summary>
        /// Gets the type of text node.
        ///  
        /// </summary>
        public virtual string Type { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FontSetting {\n");
            sb.Append("  Font: ").Append(this.Font).Append("\n");
            sb.Append("  Length: ").Append(this.Length).Append("\n");
            sb.Append("  StartIndex: ").Append(this.StartIndex).Append("\n");
            sb.Append("  TextOptions: ").Append(this.TextOptions).Append("\n");
            sb.Append("  Type: ").Append(this.Type).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
