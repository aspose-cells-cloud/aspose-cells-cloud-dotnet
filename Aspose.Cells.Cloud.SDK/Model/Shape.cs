// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="Shape.cs">
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
    /// 
    /// </summary>
    public class Shape : LinkElement
    {
        /// <summary>
        /// Gets and sets the name of the shape.
        /// </summary>
        public virtual string Name { get; set; }

        /// <summary>
        /// Gets mso drawing type.
        /// </summary>
        public virtual string MsoDrawingType { get; set; }

        /// <summary>
        /// Gets and sets the auto shape type.
        /// </summary>
        public virtual string AutoShapeType { get; set; }

        /// <summary>
        /// Represents the way the drawing object is attached to the cells below it.
        ///                         The property controls the placement of an object on a worksheet.
        /// </summary>
        public virtual string Placement { get; set; }

        /// <summary>
        /// Represents upper left corner row index.
        /// </summary>
        public virtual int? UpperLeftRow { get; set; }

        /// <summary>
        /// Represents the vertical offset of shape from its top row, in unit of pixels.
        /// </summary>
        public virtual int? Top { get; set; }

        /// <summary>
        /// Represents upper left corner column index.
        /// </summary>
        public virtual int? UpperLeftColumn { get; set; }

        /// <summary>
        /// Represents the horizontal offset of shape from its left column, in unit of pixels.
        /// </summary>
        public virtual int? Left { get; set; }

        /// <summary>
        /// Represents lower right corner row index.
        /// </summary>
        public virtual int? LowerRightRow { get; set; }

        /// <summary>
        /// Represents the width of the shape's vertical offset from its lower bottom corner row, in unit of pixels.
        /// </summary>
        public virtual int? Bottom { get; set; }

        /// <summary>
        /// Represents lower right corner column index.
        /// </summary>
        public virtual int? LowerRightColumn { get; set; }

        /// <summary>
        /// Represents the width of the shape's horizontal  offset from its lower right corner column, in unit of pixels.
        /// </summary>
        public virtual int? Right { get; set; }

        /// <summary>
        /// Represents the width of shape, in unit of pixels.
        /// </summary>
        public virtual int? Width { get; set; }

        /// <summary>
        /// Represents the height of shape, in unit of pixel.
        /// </summary>
        public virtual int? Height { get; set; }

        /// <summary>
        /// Gets and sets the horizontal offset of shape from worksheet left border,in unit of pixels.
        /// </summary>
        public virtual int? X { get; set; }

        /// <summary>
        /// Gets and sets the vertical offset of shape from worksheet top border,in unit of pixels.
        /// </summary>
        public virtual int? Y { get; set; }

        /// <summary>
        /// Gets and sets the rotation of the shape.
        /// </summary>
        public virtual double? RotationAngle { get; set; }

        /// <summary>
        /// Gets and sets the html string which contains data and some formats in this textbox.
        /// </summary>
        public virtual string HtmlText { get; set; }

        /// <summary>
        /// Represents the string in this TextBox object.
        /// </summary>
        public virtual string Text { get; set; }

        /// <summary>
        /// Returns or sets the descriptive (alternative) text string of the  object.
        /// </summary>
        public virtual string AlternativeText { get; set; }

        /// <summary>
        /// Gets and sets the text horizontal alignment type of the shape.
        /// </summary>
        public virtual string TextHorizontalAlignment { get; set; }

        /// <summary>
        /// Gets and sets the text horizontal overflow type of the shape which contains text.
        /// </summary>
        public virtual string TextHorizontalOverflow { get; set; }

        /// <summary>
        /// Gets and sets the text orientation type of the shape.
        /// </summary>
        public virtual string TextOrientationType { get; set; }

        /// <summary>
        /// Gets and sets the text vertical alignment type of the shape.
        /// </summary>
        public virtual string TextVerticalAlignment { get; set; }

        /// <summary>
        /// Gets and sets the text vertical overflow type of the shape which contains text.
        /// </summary>
        public virtual string TextVerticalOverflow { get; set; }

        /// <summary>
        /// Indicates whether the shape is a group.
        /// </summary>
        public virtual bool? IsGroup { get; set; }

        /// <summary>
        /// Indicates whether the object is visible.
        /// </summary>
        public virtual bool? IsHidden { get; set; }

        /// <summary>
        /// True means that don't allow changes in aspect ratio.
        /// </summary>
        public virtual bool? IsLockAspectRatio { get; set; }

        /// <summary>
        /// True if the object is locked, False if the object can be modified when the sheet is protected.
        /// </summary>
        public virtual bool? IsLocked { get; set; }

        /// <summary>
        /// True if the object is printable
        /// </summary>
        public virtual bool? IsPrintable { get; set; }

        /// <summary>
        /// Gets and sets the text wrapped type of the shape which contains text.
        /// </summary>
        public virtual bool? IsTextWrapped { get; set; }

        /// <summary>
        /// Indicates whether this shape is a word art.
        /// </summary>
        public virtual bool? IsWordArt { get; set; }

        /// <summary>
        /// Gets or sets the worksheet range linked to the control's value.
        /// </summary>
        public virtual string LinkedCell { get; set; }

        /// <summary>
        /// Returns the position of a shape in the z-order.
        /// </summary>
        public virtual int? ZOrderPosition { get; set; }

        /// <summary>
        /// Represents the font of shape.
        /// </summary>
        public virtual Font Font { get; set; }

        /// <summary>
        /// Gets the hyperlink of the shape.
        /// </summary>
        public virtual string Hyperlink { get; set; }

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
            sb.Append("class Shape {\n");
            sb.Append("  Name: ").Append(this.Name).Append("\n");
            sb.Append("  MsoDrawingType: ").Append(this.MsoDrawingType).Append("\n");
            sb.Append("  AutoShapeType: ").Append(this.AutoShapeType).Append("\n");
            sb.Append("  Placement: ").Append(this.Placement).Append("\n");
            sb.Append("  UpperLeftRow: ").Append(this.UpperLeftRow).Append("\n");
            sb.Append("  Top: ").Append(this.Top).Append("\n");
            sb.Append("  UpperLeftColumn: ").Append(this.UpperLeftColumn).Append("\n");
            sb.Append("  Left: ").Append(this.Left).Append("\n");
            sb.Append("  LowerRightRow: ").Append(this.LowerRightRow).Append("\n");
            sb.Append("  Bottom: ").Append(this.Bottom).Append("\n");
            sb.Append("  LowerRightColumn: ").Append(this.LowerRightColumn).Append("\n");
            sb.Append("  Right: ").Append(this.Right).Append("\n");
            sb.Append("  Width: ").Append(this.Width).Append("\n");
            sb.Append("  Height: ").Append(this.Height).Append("\n");
            sb.Append("  X: ").Append(this.X).Append("\n");
            sb.Append("  Y: ").Append(this.Y).Append("\n");
            sb.Append("  RotationAngle: ").Append(this.RotationAngle).Append("\n");
            sb.Append("  HtmlText: ").Append(this.HtmlText).Append("\n");
            sb.Append("  Text: ").Append(this.Text).Append("\n");
            sb.Append("  AlternativeText: ").Append(this.AlternativeText).Append("\n");
            sb.Append("  TextHorizontalAlignment: ").Append(this.TextHorizontalAlignment).Append("\n");
            sb.Append("  TextHorizontalOverflow: ").Append(this.TextHorizontalOverflow).Append("\n");
            sb.Append("  TextOrientationType: ").Append(this.TextOrientationType).Append("\n");
            sb.Append("  TextVerticalAlignment: ").Append(this.TextVerticalAlignment).Append("\n");
            sb.Append("  TextVerticalOverflow: ").Append(this.TextVerticalOverflow).Append("\n");
            sb.Append("  IsGroup: ").Append(this.IsGroup).Append("\n");
            sb.Append("  IsHidden: ").Append(this.IsHidden).Append("\n");
            sb.Append("  IsLockAspectRatio: ").Append(this.IsLockAspectRatio).Append("\n");
            sb.Append("  IsLocked: ").Append(this.IsLocked).Append("\n");
            sb.Append("  IsPrintable: ").Append(this.IsPrintable).Append("\n");
            sb.Append("  IsTextWrapped: ").Append(this.IsTextWrapped).Append("\n");
            sb.Append("  IsWordArt: ").Append(this.IsWordArt).Append("\n");
            sb.Append("  LinkedCell: ").Append(this.LinkedCell).Append("\n");
            sb.Append("  ZOrderPosition: ").Append(this.ZOrderPosition).Append("\n");
            sb.Append("  Font: ").Append(this.Font).Append("\n");
            sb.Append("  Hyperlink: ").Append(this.Hyperlink).Append("\n");
            sb.Append("  link: ").Append(this.link).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
