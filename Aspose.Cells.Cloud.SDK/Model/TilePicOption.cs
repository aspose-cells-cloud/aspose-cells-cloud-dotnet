// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="TilePicOption.cs">
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
    ///            Represents tile picture as texture.
    ///            
    /// </summary>
    public class TilePicOption
    {
        /// <summary>
        /// Gets or sets the X offset for tiling picture.
        ///  
        /// </summary>
        public virtual double? OffsetX { get; set; }

        /// <summary>
        /// Gets or sets the Y offset for tiling picture.
        ///  
        /// </summary>
        public virtual double? OffsetY { get; set; }

        /// <summary>
        /// Gets or sets the X scale for tiling picture.
        ///  
        /// </summary>
        public virtual double? ScaleX { get; set; }

        /// <summary>
        /// Gets or sets the Y scale for tiling picture.
        ///  
        /// </summary>
        public virtual double? ScaleY { get; set; }

        /// <summary>
        /// Gets or sets the alignment for tiling.
        ///  
        /// </summary>
        public virtual string AlignmentType { get; set; }

        /// <summary>
        /// Gets or sets the mirror type for tiling.
        ///  
        /// </summary>
        public virtual string MirrorType { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TilePicOption {\n");
            sb.Append("  OffsetX: ").Append(this.OffsetX).Append("\n");
            sb.Append("  OffsetY: ").Append(this.OffsetY).Append("\n");
            sb.Append("  ScaleX: ").Append(this.ScaleX).Append("\n");
            sb.Append("  ScaleY: ").Append(this.ScaleY).Append("\n");
            sb.Append("  AlignmentType: ").Append(this.AlignmentType).Append("\n");
            sb.Append("  MirrorType: ").Append(this.MirrorType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
