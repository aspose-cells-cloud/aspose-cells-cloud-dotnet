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
        /// Gets the .
        /// </summary>
        public virtual Area Area { get; set; }

        /// <summary>
        /// Represents if the value axis crosses the category axis between categories.
        /// </summary>
        public virtual bool? AxisBetweenCategories { get; set; }

        /// <summary>
        /// Gets the appearance of an Axis.
        /// </summary>
        public virtual Line AxisLine { get; set; }

        /// <summary>
        /// Represents the base unit scale for the category axis.
        /// </summary>
        public virtual string BaseUnitScale { get; set; }

        /// <summary>
        /// Represents the category axis type.
        /// </summary>
        public virtual string CategoryType { get; set; }

        /// <summary>
        /// Represents the point on the value axis where the category axis crosses it.
        /// </summary>
        public virtual double? CrossAt { get; set; }

        /// <summary>
        /// Represents the  on the specified axis where the other axis crosses.
        /// </summary>
        public virtual string CrossType { get; set; }

        /// <summary>
        /// Represents the unit label for the specified axis.
        /// </summary>
        public virtual string DisplayUnit { get; set; }

        /// <summary>
        /// Represents a unit label on an axis in the specified chart. 
        ///                         Unit labels are useful for charting large values— for example, in the millions or billions.
        /// </summary>
        public virtual LinkElement DisplayUnitLabel { get; set; }

        /// <summary>
        /// Indicates whether the labels shall be shown as multi level.
        /// </summary>
        public virtual bool? HasMultiLevelLabels { get; set; }

        /// <summary>
        /// Indicates whether the major unit of the axis is automatically assigned.
        /// </summary>
        public virtual bool? IsAutomaticMajorUnit { get; set; }

        /// <summary>
        /// Indicates whether the max value is automatically assigned.
        /// </summary>
        public virtual bool? IsAutomaticMaxValue { get; set; }

        /// <summary>
        /// Indicates whether the minor unit of the axis is automatically assigned.
        /// </summary>
        public virtual bool? IsAutomaticMinorUnit { get; set; }

        /// <summary>
        /// Indicates whether the min value is automatically assigned.
        /// </summary>
        public virtual bool? IsAutomaticMinValue { get; set; }

        /// <summary>
        /// Represents if the display unit label is shown on the specified axis.
        /// </summary>
        public virtual bool? IsDisplayUnitLabelShown { get; set; }

        /// <summary>
        /// Represents if the value axis scale type is logarithmic or not.
        /// </summary>
        public virtual bool? IsLogarithmic { get; set; }

        /// <summary>
        /// Represents if Microsoft Excel plots data points from last to first.
        /// </summary>
        public virtual bool? IsPlotOrderReversed { get; set; }

        /// <summary>
        /// Represents if the axis is visible.
        /// </summary>
        public virtual bool? IsVisible { get; set; }

        /// <summary>
        /// Represents the logarithmic base. Default value is 10.Only applies for Excel2007.
        /// </summary>
        public virtual double? LogBase { get; set; }

        /// <summary>
        /// Represents major gridlines on a chart axis.
        /// </summary>
        public virtual Line MajorGridLines { get; set; }

        /// <summary>
        /// Represents the type of major tick mark for the specified axis.
        /// </summary>
        public virtual string MajorTickMark { get; set; }

        /// <summary>
        /// Represents the major units for the axis.
        /// </summary>
        public virtual double? MajorUnit { get; set; }

        /// <summary>
        /// Represents the major unit scale for the category axis.
        /// </summary>
        public virtual string MajorUnitScale { get; set; }

        /// <summary>
        /// Represents the maximum value on the value axis.
        /// </summary>
        public virtual double? MaxValue { get; set; }

        /// <summary>
        /// Represents minor gridlines on a chart axis.
        /// </summary>
        public virtual Line MinorGridLines { get; set; }

        /// <summary>
        /// Represents the type of minor tick mark for the specified axis.
        /// </summary>
        public virtual string MinorTickMark { get; set; }

        /// <summary>
        /// Represents the minor units for the axis.
        /// </summary>
        public virtual double? MinorUnit { get; set; }

        /// <summary>
        /// Represents the major unit scale for the category axis.
        /// </summary>
        public virtual string MinorUnitScale { get; set; }

        /// <summary>
        /// Represents the minimum value on the value axis.
        /// </summary>
        public virtual double? MinValue { get; set; }

        /// <summary>
        /// Represents the position of tick-mark labels on the specified axis.
        /// </summary>
        public virtual string TickLabelPosition { get; set; }

        /// <summary>
        /// Returns a  object that represents the tick-mark labels for the specified axis.
        /// </summary>
        public virtual TickLabels TickLabels { get; set; }

        /// <summary>
        /// Represents the number of categories or series between tick-mark labels. Applies only to category and series axes.
        /// </summary>
        public virtual int? TickLabelSpacing { get; set; }

        /// <summary>
        /// Returns or sets the number of categories or series between tick marks. Applies only to category and series axes.
        /// </summary>
        public virtual int? TickMarkSpacing { get; set; }

        /// <summary>
        /// Gets the axis' title.
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
