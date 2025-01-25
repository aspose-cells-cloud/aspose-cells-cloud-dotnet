// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="DataLabels.cs">
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
    /// Encapsulates a collection of all the DataLabel objects for the specified Series.
    /// </summary>
    public class DataLabels : ChartFrame
    {
        /// <summary>
        /// Indicates the text is auto generated.
        /// </summary>
        public virtual bool? IsAutoText { get; set; }

        /// <summary>
        /// Gets or sets IsDeleted.
        /// </summary>
        public virtual bool? IsDeleted { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual string LinkedSource { get; set; }

        /// <summary>
        /// Gets and sets the built-in number format.
        /// </summary>
        public virtual int? Number { get; set; }

        /// <summary>
        /// Represents the format string for the DataLabels object.
        /// </summary>
        public virtual string NumberFormat { get; set; }

        /// <summary>
        /// True if the number format is linked to the cells 
        ///                         (so that the number format changes in the labels when it changes in the cells).
        /// </summary>
        public virtual bool? NumberFormatLinked { get; set; }

        /// <summary>
        /// Represents the position of the data label.
        /// </summary>
        public virtual string Position { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual int? RotationAngle { get; set; }

        /// <summary>
        /// Gets or sets the separator type used for the data labels on a chart.
        /// </summary>
        public virtual string Separator { get; set; }

        /// <summary>
        /// Represents a specified chart's data label percentage value display behavior. True displays the percentage value. False to hide.
        /// </summary>
        public virtual bool? ShowBubbleSize { get; set; }

        /// <summary>
        /// Represents a specified chart's data label category name display behavior.True to display the category name for the data labels on a chart. False to hide.
        /// </summary>
        public virtual bool? ShowCategoryName { get; set; }

        /// <summary>
        /// Represents a specified chart's data label legend key display behavior.
        ///                         True if the data label legend key is visible.
        /// </summary>
        public virtual bool? ShowLegendKey { get; set; }

        /// <summary>
        /// Represents a specified chart's data label percentage value display behavior. True displays the percentage value. False to hide.
        /// </summary>
        public virtual bool? ShowPercentage { get; set; }

        /// <summary>
        /// Returns or sets a Boolean to indicate the series name display behavior for the data labels on a chart.
        ///                         True to show the series name. False to hide.
        /// </summary>
        public virtual bool? ShowSeriesName { get; set; }

        /// <summary>
        /// Represents a specified chart's data label values display behavior. True displays the values. False to hide.
        /// </summary>
        public virtual bool? ShowValue { get; set; }

        /// <summary>
        /// Gets or sets the text of data label.
        /// </summary>
        public virtual string Text { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual string TextDirection { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual string TextHorizontalAlignment { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual string TextVerticalAlignment { get; set; }

        /// <summary>
        /// Gets or sets Area.
        /// </summary>
        public override Area Area { get; set; }

        /// <summary>
        /// Gets or sets AutoScaleFont.
        /// </summary>
        public override bool? AutoScaleFont { get; set; }

        /// <summary>
        /// Gets or sets BackgroundMode.
        /// </summary>
        public override string BackgroundMode { get; set; }

        /// <summary>
        /// Gets or sets Border.
        /// </summary>
        public override Line Border { get; set; }

        /// <summary>
        /// Gets or sets Font.
        /// </summary>
        public override Font Font { get; set; }

        /// <summary>
        /// Gets or sets IsAutomaticSize.
        /// </summary>
        public override bool? IsAutomaticSize { get; set; }

        /// <summary>
        /// Gets or sets IsInnerMode.
        /// </summary>
        public override bool? IsInnerMode { get; set; }

        /// <summary>
        /// Gets or sets Shadow.
        /// </summary>
        public override bool? Shadow { get; set; }

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
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DataLabels {\n");
            sb.Append("  IsAutoText: ").Append(this.IsAutoText).Append("\n");
            sb.Append("  IsDeleted: ").Append(this.IsDeleted).Append("\n");
            sb.Append("  LinkedSource: ").Append(this.LinkedSource).Append("\n");
            sb.Append("  Number: ").Append(this.Number).Append("\n");
            sb.Append("  NumberFormat: ").Append(this.NumberFormat).Append("\n");
            sb.Append("  NumberFormatLinked: ").Append(this.NumberFormatLinked).Append("\n");
            sb.Append("  Position: ").Append(this.Position).Append("\n");
            sb.Append("  RotationAngle: ").Append(this.RotationAngle).Append("\n");
            sb.Append("  Separator: ").Append(this.Separator).Append("\n");
            sb.Append("  ShowBubbleSize: ").Append(this.ShowBubbleSize).Append("\n");
            sb.Append("  ShowCategoryName: ").Append(this.ShowCategoryName).Append("\n");
            sb.Append("  ShowLegendKey: ").Append(this.ShowLegendKey).Append("\n");
            sb.Append("  ShowPercentage: ").Append(this.ShowPercentage).Append("\n");
            sb.Append("  ShowSeriesName: ").Append(this.ShowSeriesName).Append("\n");
            sb.Append("  ShowValue: ").Append(this.ShowValue).Append("\n");
            sb.Append("  Text: ").Append(this.Text).Append("\n");
            sb.Append("  TextDirection: ").Append(this.TextDirection).Append("\n");
            sb.Append("  TextHorizontalAlignment: ").Append(this.TextHorizontalAlignment).Append("\n");
            sb.Append("  TextVerticalAlignment: ").Append(this.TextVerticalAlignment).Append("\n");
            sb.Append("  Area: ").Append(this.Area).Append("\n");
            sb.Append("  AutoScaleFont: ").Append(this.AutoScaleFont).Append("\n");
            sb.Append("  BackgroundMode: ").Append(this.BackgroundMode).Append("\n");
            sb.Append("  Border: ").Append(this.Border).Append("\n");
            sb.Append("  Font: ").Append(this.Font).Append("\n");
            sb.Append("  IsAutomaticSize: ").Append(this.IsAutomaticSize).Append("\n");
            sb.Append("  IsInnerMode: ").Append(this.IsInnerMode).Append("\n");
            sb.Append("  Shadow: ").Append(this.Shadow).Append("\n");
            sb.Append("  Width: ").Append(this.Width).Append("\n");
            sb.Append("  Height: ").Append(this.Height).Append("\n");
            sb.Append("  X: ").Append(this.X).Append("\n");
            sb.Append("  Y: ").Append(this.Y).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
