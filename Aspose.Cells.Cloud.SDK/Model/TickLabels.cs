// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="TickLabels.cs">
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
    /// Represents the tick-mark labels associated with tick marks on a chart axis.
    /// </summary>
    public class TickLabels : LinkElement
    {
        /// <summary>
        /// True if the text in the object changes font size when the object size changes. The default value is True.
        /// </summary>
        public virtual bool? AutoScaleFont { get; set; }

        /// <summary>
        /// Gets and sets the display mode of the background
        /// </summary>
        public virtual string BackgroundMode { get; set; }

        /// <summary>
        /// Returns a  object that represents the font of the specified TickLabels object.
        /// </summary>
        public virtual Font Font { get; set; }

        /// <summary>
        /// Represents the format number for the TickLabels object.
        /// </summary>
        public virtual int? Number { get; set; }

        /// <summary>
        /// Represents the format string for the TickLabels object.
        /// </summary>
        public virtual string NumberFormat { get; set; }

        /// <summary>
        /// True if the number format is linked to the cells 
        ///                         (so that the number format changes in the labels when it changes in the cells).
        /// </summary>
        public virtual bool? NumberFormatLinked { get; set; }

        /// <summary>
        /// Gets and sets the distance of labels from the axis.
        /// </summary>
        public virtual int? Offset { get; set; }

        /// <summary>
        /// Represents text rotation angle in clockwise.
        /// </summary>
        public virtual int? RotationAngle { get; set; }

        /// <summary>
        /// Represents text reading order.
        /// </summary>
        public virtual string TextDirection { get; set; }

        /// <summary>
        /// Represents text reading order.
        /// </summary>
        public virtual string ReadingOrder { get; set; }

        /// <summary>
        /// Gets and sets the direction of text.
        /// </summary>
        public virtual string DirectionType { get; set; }

        /// <summary>
        /// Gets or sets link.
        /// </summary>
        public override Link link { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TickLabels {\n");
            sb.Append("  AutoScaleFont: ").Append(this.AutoScaleFont).Append("\n");
            sb.Append("  BackgroundMode: ").Append(this.BackgroundMode).Append("\n");
            sb.Append("  Font: ").Append(this.Font).Append("\n");
            sb.Append("  Number: ").Append(this.Number).Append("\n");
            sb.Append("  NumberFormat: ").Append(this.NumberFormat).Append("\n");
            sb.Append("  NumberFormatLinked: ").Append(this.NumberFormatLinked).Append("\n");
            sb.Append("  Offset: ").Append(this.Offset).Append("\n");
            sb.Append("  RotationAngle: ").Append(this.RotationAngle).Append("\n");
            sb.Append("  TextDirection: ").Append(this.TextDirection).Append("\n");
            sb.Append("  ReadingOrder: ").Append(this.ReadingOrder).Append("\n");
            sb.Append("  DirectionType: ").Append(this.DirectionType).Append("\n");
            sb.Append("  link: ").Append(this.link).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
