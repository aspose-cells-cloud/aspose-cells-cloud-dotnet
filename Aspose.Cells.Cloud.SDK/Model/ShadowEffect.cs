// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ShadowEffect.cs">
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
    ///            This class specifies the shadow effect of the chart element or shape.
    ///            
    /// </summary>
    public class ShadowEffect
    {
        /// <summary>
        /// Gets and sets the lighting angle. Range from 0 to 359.9 degrees.
        ///  
        /// </summary>
        public virtual double? Angle { get; set; }

        /// <summary>
        /// Gets and sets the blur of the shadow. Range from 0 to 100 points.
        ///  
        /// </summary>
        public virtual double? Blur { get; set; }

        /// <summary>
        /// Gets and sets the color of the shadow.
        ///  
        /// </summary>
        public virtual CellsColor Color { get; set; }

        /// <summary>
        /// Gets and sets the distance of the shadow. Range from 0 to 200 points.
        ///  
        /// </summary>
        public virtual double? Distance { get; set; }

        /// <summary>
        /// Gets and sets the preset shadow type of the shadow.
        ///  
        /// </summary>
        public virtual string PresetType { get; set; }

        /// <summary>
        /// Gets and sets the size of the shadow. Range from 0 to 2.0. 
        ///             Meaningless in inner shadow.
        ///  
        /// </summary>
        public virtual double? Size { get; set; }

        /// <summary>
        /// Gets and sets the degree of transparency of the shadow. Range from 0.0 (opaque) to 1.0 (clear).
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
            sb.Append("class ShadowEffect {\n");
            sb.Append("  Angle: ").Append(this.Angle).Append("\n");
            sb.Append("  Blur: ").Append(this.Blur).Append("\n");
            sb.Append("  Color: ").Append(this.Color).Append("\n");
            sb.Append("  Distance: ").Append(this.Distance).Append("\n");
            sb.Append("  PresetType: ").Append(this.PresetType).Append("\n");
            sb.Append("  Size: ").Append(this.Size).Append("\n");
            sb.Append("  Transparency: ").Append(this.Transparency).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
