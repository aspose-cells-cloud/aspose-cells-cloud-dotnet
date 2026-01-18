// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="Button.cs">
//   Copyright (c) 2026 Aspose.Cells Cloud
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
    /// Represents the Forms control: Button
    /// </summary>
    public class Button : Shape
    {
        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        public override string Name { get; set; }

        /// <summary>
        /// Gets or sets MsoDrawingType.
        /// </summary>
        public override string MsoDrawingType { get; set; }

        /// <summary>
        /// Gets or sets AutoShapeType.
        /// </summary>
        public override string AutoShapeType { get; set; }

        /// <summary>
        /// Gets or sets Placement.
        /// </summary>
        public override string Placement { get; set; }

        /// <summary>
        /// Gets or sets UpperLeftRow.
        /// </summary>
        public override int? UpperLeftRow { get; set; }

        /// <summary>
        /// Gets or sets Top.
        /// </summary>
        public override int? Top { get; set; }

        /// <summary>
        /// Gets or sets UpperLeftColumn.
        /// </summary>
        public override int? UpperLeftColumn { get; set; }

        /// <summary>
        /// Gets or sets Left.
        /// </summary>
        public override int? Left { get; set; }

        /// <summary>
        /// Gets or sets LowerRightRow.
        /// </summary>
        public override int? LowerRightRow { get; set; }

        /// <summary>
        /// Gets or sets Bottom.
        /// </summary>
        public override int? Bottom { get; set; }

        /// <summary>
        /// Gets or sets LowerRightColumn.
        /// </summary>
        public override int? LowerRightColumn { get; set; }

        /// <summary>
        /// Gets or sets Right.
        /// </summary>
        public override int? Right { get; set; }

        /// <summary>
        /// Gets or sets Width.
        /// </summary>
        public override int? Width { get; set; }

        /// <summary>
        /// Gets or sets Height.
        /// </summary>
        public override int? Height { get; set; }

        /// <summary>
        /// Gets or sets X.
        /// </summary>
        public override int? X { get; set; }

        /// <summary>
        /// Gets or sets Y.
        /// </summary>
        public override int? Y { get; set; }

        /// <summary>
        /// Gets or sets RotationAngle.
        /// </summary>
        public override double? RotationAngle { get; set; }

        /// <summary>
        /// Gets or sets HtmlText.
        /// </summary>
        public override string HtmlText { get; set; }

        /// <summary>
        /// Gets or sets Text.
        /// </summary>
        public override string Text { get; set; }

        /// <summary>
        /// Gets or sets AlternativeText.
        /// </summary>
        public override string AlternativeText { get; set; }

        /// <summary>
        /// Gets or sets TextHorizontalAlignment.
        /// </summary>
        public override string TextHorizontalAlignment { get; set; }

        /// <summary>
        /// Gets or sets TextHorizontalOverflow.
        /// </summary>
        public override string TextHorizontalOverflow { get; set; }

        /// <summary>
        /// Gets or sets TextOrientationType.
        /// </summary>
        public override string TextOrientationType { get; set; }

        /// <summary>
        /// Gets or sets TextVerticalAlignment.
        /// </summary>
        public override string TextVerticalAlignment { get; set; }

        /// <summary>
        /// Gets or sets TextVerticalOverflow.
        /// </summary>
        public override string TextVerticalOverflow { get; set; }

        /// <summary>
        /// Gets or sets IsGroup.
        /// </summary>
        public override bool? IsGroup { get; set; }

        /// <summary>
        /// Gets or sets IsHidden.
        /// </summary>
        public override bool? IsHidden { get; set; }

        /// <summary>
        /// Gets or sets IsLockAspectRatio.
        /// </summary>
        public override bool? IsLockAspectRatio { get; set; }

        /// <summary>
        /// Gets or sets IsLocked.
        /// </summary>
        public override bool? IsLocked { get; set; }

        /// <summary>
        /// Gets or sets IsPrintable.
        /// </summary>
        public override bool? IsPrintable { get; set; }

        /// <summary>
        /// Gets or sets IsTextWrapped.
        /// </summary>
        public override bool? IsTextWrapped { get; set; }

        /// <summary>
        /// Gets or sets IsWordArt.
        /// </summary>
        public override bool? IsWordArt { get; set; }

        /// <summary>
        /// Gets or sets LinkedCell.
        /// </summary>
        public override string LinkedCell { get; set; }

        /// <summary>
        /// Gets or sets ZOrderPosition.
        /// </summary>
        public override int? ZOrderPosition { get; set; }

        /// <summary>
        /// Gets or sets Font.
        /// </summary>
        public override Font Font { get; set; }

        /// <summary>
        /// Gets or sets Hyperlink.
        /// </summary>
        public override string Hyperlink { get; set; }

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
            sb.Append("class Button {\n");
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
