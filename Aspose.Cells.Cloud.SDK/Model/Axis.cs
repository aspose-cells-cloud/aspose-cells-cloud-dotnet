// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="Axis.cs">
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
    /// Axis.
    /// </summary>
    public class Axis : LinkElement
    {
        /// <summary>
        /// Gets or sets Area.
        /// </summary>
        public virtual Area Area { get; set; }

        /// <summary>
        /// Gets or sets AxisBetweenCategories.
        /// </summary>
        public virtual bool? AxisBetweenCategories { get; set; }

        /// <summary>
        /// Gets or sets AxisLine.
        /// </summary>
        public virtual Line AxisLine { get; set; }

        /// <summary>
        /// Gets or sets BaseUnitScale.
        /// </summary>
        public virtual string BaseUnitScale { get; set; }

        /// <summary>
        /// Gets or sets CategoryType.
        /// </summary>
        public virtual string CategoryType { get; set; }

        /// <summary>
        /// Gets or sets CrossAt.
        /// </summary>
        public virtual double? CrossAt { get; set; }

        /// <summary>
        /// Gets or sets CrossType.
        /// </summary>
        public virtual string CrossType { get; set; }

        /// <summary>
        /// Gets or sets DisplayUnit.
        /// </summary>
        public virtual string DisplayUnit { get; set; }

        /// <summary>
        /// Gets or sets DisplayUnitLabel.
        /// </summary>
        public virtual LinkElement DisplayUnitLabel { get; set; }

        /// <summary>
        /// Gets or sets HasMultiLevelLabels.
        /// </summary>
        public virtual bool? HasMultiLevelLabels { get; set; }

        /// <summary>
        /// Gets or sets IsAutomaticMajorUnit.
        /// </summary>
        public virtual bool? IsAutomaticMajorUnit { get; set; }

        /// <summary>
        /// Gets or sets IsAutomaticMaxValue.
        /// </summary>
        public virtual bool? IsAutomaticMaxValue { get; set; }

        /// <summary>
        /// Gets or sets IsAutomaticMinorUnit.
        /// </summary>
        public virtual bool? IsAutomaticMinorUnit { get; set; }

        /// <summary>
        /// Gets or sets IsAutomaticMinValue.
        /// </summary>
        public virtual bool? IsAutomaticMinValue { get; set; }

        /// <summary>
        /// Gets or sets IsDisplayUnitLabelShown.
        /// </summary>
        public virtual bool? IsDisplayUnitLabelShown { get; set; }

        /// <summary>
        /// Gets or sets IsLogarithmic.
        /// </summary>
        public virtual bool? IsLogarithmic { get; set; }

        /// <summary>
        /// Gets or sets IsPlotOrderReversed.
        /// </summary>
        public virtual bool? IsPlotOrderReversed { get; set; }

        /// <summary>
        /// Gets or sets IsVisible.
        /// </summary>
        public virtual bool? IsVisible { get; set; }

        /// <summary>
        /// Gets or sets LogBase.
        /// </summary>
        public virtual double? LogBase { get; set; }

        /// <summary>
        /// Gets or sets MajorGridLines.
        /// </summary>
        public virtual Line MajorGridLines { get; set; }

        /// <summary>
        /// Gets or sets MajorTickMark.
        /// </summary>
        public virtual string MajorTickMark { get; set; }

        /// <summary>
        /// Gets or sets MajorUnit.
        /// </summary>
        public virtual double? MajorUnit { get; set; }

        /// <summary>
        /// Gets or sets MajorUnitScale.
        /// </summary>
        public virtual string MajorUnitScale { get; set; }

        /// <summary>
        /// Gets or sets MaxValue.
        /// </summary>
        public virtual double? MaxValue { get; set; }

        /// <summary>
        /// Gets or sets MinorGridLines.
        /// </summary>
        public virtual Line MinorGridLines { get; set; }

        /// <summary>
        /// Gets or sets MinorTickMark.
        /// </summary>
        public virtual string MinorTickMark { get; set; }

        /// <summary>
        /// Gets or sets MinorUnit.
        /// </summary>
        public virtual double? MinorUnit { get; set; }

        /// <summary>
        /// Gets or sets MinorUnitScale.
        /// </summary>
        public virtual string MinorUnitScale { get; set; }

        /// <summary>
        /// Gets or sets MinValue.
        /// </summary>
        public virtual double? MinValue { get; set; }

        /// <summary>
        /// Gets or sets TickLabelPosition.
        /// </summary>
        public virtual string TickLabelPosition { get; set; }

        /// <summary>
        /// Gets or sets TickLabels.
        /// </summary>
        public virtual TickLabels TickLabels { get; set; }

        /// <summary>
        /// Gets or sets TickLabelSpacing.
        /// </summary>
        public virtual int? TickLabelSpacing { get; set; }

        /// <summary>
        /// Gets or sets TickMarkSpacing.
        /// </summary>
        public virtual int? TickMarkSpacing { get; set; }

        /// <summary>
        /// Gets or sets Title.
        /// </summary>
        public virtual Title Title { get; set; }

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
            sb.Append("class Axis {\n");
            sb.Append("  Area: ").Append(this.Area).Append("\n");
            sb.Append("  AxisBetweenCategories: ").Append(this.AxisBetweenCategories).Append("\n");
            sb.Append("  AxisLine: ").Append(this.AxisLine).Append("\n");
            sb.Append("  BaseUnitScale: ").Append(this.BaseUnitScale).Append("\n");
            sb.Append("  CategoryType: ").Append(this.CategoryType).Append("\n");
            sb.Append("  CrossAt: ").Append(this.CrossAt).Append("\n");
            sb.Append("  CrossType: ").Append(this.CrossType).Append("\n");
            sb.Append("  DisplayUnit: ").Append(this.DisplayUnit).Append("\n");
            sb.Append("  DisplayUnitLabel: ").Append(this.DisplayUnitLabel).Append("\n");
            sb.Append("  HasMultiLevelLabels: ").Append(this.HasMultiLevelLabels).Append("\n");
            sb.Append("  IsAutomaticMajorUnit: ").Append(this.IsAutomaticMajorUnit).Append("\n");
            sb.Append("  IsAutomaticMaxValue: ").Append(this.IsAutomaticMaxValue).Append("\n");
            sb.Append("  IsAutomaticMinorUnit: ").Append(this.IsAutomaticMinorUnit).Append("\n");
            sb.Append("  IsAutomaticMinValue: ").Append(this.IsAutomaticMinValue).Append("\n");
            sb.Append("  IsDisplayUnitLabelShown: ").Append(this.IsDisplayUnitLabelShown).Append("\n");
            sb.Append("  IsLogarithmic: ").Append(this.IsLogarithmic).Append("\n");
            sb.Append("  IsPlotOrderReversed: ").Append(this.IsPlotOrderReversed).Append("\n");
            sb.Append("  IsVisible: ").Append(this.IsVisible).Append("\n");
            sb.Append("  LogBase: ").Append(this.LogBase).Append("\n");
            sb.Append("  MajorGridLines: ").Append(this.MajorGridLines).Append("\n");
            sb.Append("  MajorTickMark: ").Append(this.MajorTickMark).Append("\n");
            sb.Append("  MajorUnit: ").Append(this.MajorUnit).Append("\n");
            sb.Append("  MajorUnitScale: ").Append(this.MajorUnitScale).Append("\n");
            sb.Append("  MaxValue: ").Append(this.MaxValue).Append("\n");
            sb.Append("  MinorGridLines: ").Append(this.MinorGridLines).Append("\n");
            sb.Append("  MinorTickMark: ").Append(this.MinorTickMark).Append("\n");
            sb.Append("  MinorUnit: ").Append(this.MinorUnit).Append("\n");
            sb.Append("  MinorUnitScale: ").Append(this.MinorUnitScale).Append("\n");
            sb.Append("  MinValue: ").Append(this.MinValue).Append("\n");
            sb.Append("  TickLabelPosition: ").Append(this.TickLabelPosition).Append("\n");
            sb.Append("  TickLabels: ").Append(this.TickLabels).Append("\n");
            sb.Append("  TickLabelSpacing: ").Append(this.TickLabelSpacing).Append("\n");
            sb.Append("  TickMarkSpacing: ").Append(this.TickMarkSpacing).Append("\n");
            sb.Append("  Title: ").Append(this.Title).Append("\n");
            sb.Append("  link: ").Append(this.link).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
