// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ErrorBar.cs">
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
    /// ErrorBar.
    /// </summary>
    public class ErrorBar : Line
    {
        /// <summary>
        /// Gets or sets Link.
        /// </summary>
        public virtual Link Link { get; set; }

        /// <summary>
        /// Gets or sets Amount.
        /// </summary>
        public virtual double? Amount { get; set; }

        /// <summary>
        /// Gets or sets DisplayType.
        /// </summary>
        public virtual string DisplayType { get; set; }

        /// <summary>
        /// Gets or sets MinusValue.
        /// </summary>
        public virtual string MinusValue { get; set; }

        /// <summary>
        /// Gets or sets PlusValue.
        /// </summary>
        public virtual string PlusValue { get; set; }

        /// <summary>
        /// Gets or sets ShowMarkerTTop.
        /// </summary>
        public virtual bool? ShowMarkerTTop { get; set; }

        /// <summary>
        /// Gets or sets Type.
        /// </summary>
        public virtual string Type { get; set; }

        /// <summary>
        /// Gets or sets BeginArrowLength.
        /// </summary>
        public override string BeginArrowLength { get; set; }

        /// <summary>
        /// Gets or sets BeginArrowWidth.
        /// </summary>
        public override string BeginArrowWidth { get; set; }

        /// <summary>
        /// Gets or sets BeginType.
        /// </summary>
        public override string BeginType { get; set; }

        /// <summary>
        /// Gets or sets CapType.
        /// </summary>
        public override string CapType { get; set; }

        /// <summary>
        /// Gets or sets Color.
        /// </summary>
        public override Color Color { get; set; }

        /// <summary>
        /// Gets or sets CompoundType.
        /// </summary>
        public override string CompoundType { get; set; }

        /// <summary>
        /// Gets or sets DashType.
        /// </summary>
        public override string DashType { get; set; }

        /// <summary>
        /// Gets or sets EndArrowLength.
        /// </summary>
        public override string EndArrowLength { get; set; }

        /// <summary>
        /// Gets or sets EndArrowWidth.
        /// </summary>
        public override string EndArrowWidth { get; set; }

        /// <summary>
        /// Gets or sets EndType.
        /// </summary>
        public override string EndType { get; set; }

        /// <summary>
        /// Gets or sets GradientFill.
        /// </summary>
        public override GradientFill GradientFill { get; set; }

        /// <summary>
        /// Gets or sets IsAuto.
        /// </summary>
        public override bool? IsAuto { get; set; }

        /// <summary>
        /// Gets or sets IsAutomaticColor.
        /// </summary>
        public override bool? IsAutomaticColor { get; set; }

        /// <summary>
        /// Gets or sets IsVisible.
        /// </summary>
        public override bool? IsVisible { get; set; }

        /// <summary>
        /// Gets or sets JoinType.
        /// </summary>
        public override string JoinType { get; set; }

        /// <summary>
        /// Gets or sets Style.
        /// </summary>
        public override string Style { get; set; }

        /// <summary>
        /// Gets or sets Transparency.
        /// </summary>
        public override double? Transparency { get; set; }

        /// <summary>
        /// Gets or sets Weight.
        /// </summary>
        public override string Weight { get; set; }

        /// <summary>
        /// Gets or sets WeightPt.
        /// </summary>
        public override double? WeightPt { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ErrorBar {\n");
            sb.Append("  Link: ").Append(this.Link).Append("\n");
            sb.Append("  Amount: ").Append(this.Amount).Append("\n");
            sb.Append("  DisplayType: ").Append(this.DisplayType).Append("\n");
            sb.Append("  MinusValue: ").Append(this.MinusValue).Append("\n");
            sb.Append("  PlusValue: ").Append(this.PlusValue).Append("\n");
            sb.Append("  ShowMarkerTTop: ").Append(this.ShowMarkerTTop).Append("\n");
            sb.Append("  Type: ").Append(this.Type).Append("\n");
            sb.Append("  BeginArrowLength: ").Append(this.BeginArrowLength).Append("\n");
            sb.Append("  BeginArrowWidth: ").Append(this.BeginArrowWidth).Append("\n");
            sb.Append("  BeginType: ").Append(this.BeginType).Append("\n");
            sb.Append("  CapType: ").Append(this.CapType).Append("\n");
            sb.Append("  Color: ").Append(this.Color).Append("\n");
            sb.Append("  CompoundType: ").Append(this.CompoundType).Append("\n");
            sb.Append("  DashType: ").Append(this.DashType).Append("\n");
            sb.Append("  EndArrowLength: ").Append(this.EndArrowLength).Append("\n");
            sb.Append("  EndArrowWidth: ").Append(this.EndArrowWidth).Append("\n");
            sb.Append("  EndType: ").Append(this.EndType).Append("\n");
            sb.Append("  GradientFill: ").Append(this.GradientFill).Append("\n");
            sb.Append("  IsAuto: ").Append(this.IsAuto).Append("\n");
            sb.Append("  IsAutomaticColor: ").Append(this.IsAutomaticColor).Append("\n");
            sb.Append("  IsVisible: ").Append(this.IsVisible).Append("\n");
            sb.Append("  JoinType: ").Append(this.JoinType).Append("\n");
            sb.Append("  Style: ").Append(this.Style).Append("\n");
            sb.Append("  Transparency: ").Append(this.Transparency).Append("\n");
            sb.Append("  Weight: ").Append(this.Weight).Append("\n");
            sb.Append("  WeightPt: ").Append(this.WeightPt).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
