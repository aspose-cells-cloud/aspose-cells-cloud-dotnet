// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="Chart.cs">
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
    /// Chart.
    /// </summary>
    public class Chart : LinkElement
    {
        /// <summary>
        /// Gets or sets AutoScaling.
        /// </summary>
        public virtual bool? AutoScaling { get; set; }

        /// <summary>
        /// Gets or sets BackWall.
        /// </summary>
        public virtual LinkElement BackWall { get; set; }

        /// <summary>
        /// Gets or sets CategoryAxis.
        /// </summary>
        public virtual LinkElement CategoryAxis { get; set; }

        /// <summary>
        /// Gets or sets ChartArea.
        /// </summary>
        public virtual LinkElement ChartArea { get; set; }

        /// <summary>
        /// Gets or sets ChartDataTable.
        /// </summary>
        public virtual LinkElement ChartDataTable { get; set; }

        /// <summary>
        /// Gets or sets ChartObject.
        /// </summary>
        public virtual LinkElement ChartObject { get; set; }

        /// <summary>
        /// Gets or sets DepthPercent.
        /// </summary>
        public virtual int? DepthPercent { get; set; }

        /// <summary>
        /// Gets or sets Elevation.
        /// </summary>
        public virtual int? Elevation { get; set; }

        /// <summary>
        /// Gets or sets FirstSliceAngle.
        /// </summary>
        public virtual int? FirstSliceAngle { get; set; }

        /// <summary>
        /// Gets or sets Floor.
        /// </summary>
        public virtual LinkElement Floor { get; set; }

        /// <summary>
        /// Gets or sets GapDepth.
        /// </summary>
        public virtual int? GapDepth { get; set; }

        /// <summary>
        /// Gets or sets GapWidth.
        /// </summary>
        public virtual int? GapWidth { get; set; }

        /// <summary>
        /// Gets or sets HeightPercent.
        /// </summary>
        public virtual int? HeightPercent { get; set; }

        /// <summary>
        /// Gets or sets HidePivotFieldButtons.
        /// </summary>
        public virtual bool? HidePivotFieldButtons { get; set; }

        /// <summary>
        /// Gets or sets Is3D.
        /// </summary>
        public virtual bool? Is3D { get; set; }

        /// <summary>
        /// Gets or sets IsRectangularCornered.
        /// </summary>
        public virtual bool? IsRectangularCornered { get; set; }

        /// <summary>
        /// Gets or sets Legend.
        /// </summary>
        public virtual LinkElement Legend { get; set; }

        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        public virtual string Name { get; set; }

        /// <summary>
        /// Gets or sets NSeries.
        /// </summary>
        public virtual LinkElement NSeries { get; set; }

        /// <summary>
        /// Gets or sets PageSetup.
        /// </summary>
        public virtual LinkElement PageSetup { get; set; }

        /// <summary>
        /// Gets or sets Perspective.
        /// </summary>
        public virtual int? Perspective { get; set; }

        /// <summary>
        /// Gets or sets PivotSource.
        /// </summary>
        public virtual string PivotSource { get; set; }

        /// <summary>
        /// Gets or sets Placement.
        /// </summary>
        public virtual string Placement { get; set; }

        /// <summary>
        /// Gets or sets PlotArea.
        /// </summary>
        public virtual LinkElement PlotArea { get; set; }

        /// <summary>
        /// Gets or sets PlotEmptyCellsType.
        /// </summary>
        public virtual string PlotEmptyCellsType { get; set; }

        /// <summary>
        /// Gets or sets PlotVisibleCells.
        /// </summary>
        public virtual bool? PlotVisibleCells { get; set; }

        /// <summary>
        /// Gets or sets PrintSize.
        /// </summary>
        public virtual string PrintSize { get; set; }

        /// <summary>
        /// Gets or sets RightAngleAxes.
        /// </summary>
        public virtual bool? RightAngleAxes { get; set; }

        /// <summary>
        /// Gets or sets RotationAngle.
        /// </summary>
        public virtual int? RotationAngle { get; set; }

        /// <summary>
        /// Gets or sets SecondCategoryAxis.
        /// </summary>
        public virtual LinkElement SecondCategoryAxis { get; set; }

        /// <summary>
        /// Gets or sets SecondValueAxis.
        /// </summary>
        public virtual LinkElement SecondValueAxis { get; set; }

        /// <summary>
        /// Gets or sets SeriesAxis.
        /// </summary>
        public virtual LinkElement SeriesAxis { get; set; }

        /// <summary>
        /// Gets or sets Shapes.
        /// </summary>
        public virtual LinkElement Shapes { get; set; }

        /// <summary>
        /// Gets or sets ShowDataTable.
        /// </summary>
        public virtual bool? ShowDataTable { get; set; }

        /// <summary>
        /// Gets or sets ShowLegend.
        /// </summary>
        public virtual bool? ShowLegend { get; set; }

        /// <summary>
        /// Gets or sets SideWall.
        /// </summary>
        public virtual LinkElement SideWall { get; set; }

        /// <summary>
        /// Gets or sets SizeWithWindow.
        /// </summary>
        public virtual bool? SizeWithWindow { get; set; }

        /// <summary>
        /// Gets or sets Style.
        /// </summary>
        public virtual int? Style { get; set; }

        /// <summary>
        /// Gets or sets Title.
        /// </summary>
        public virtual LinkElement Title { get; set; }

        /// <summary>
        /// Gets or sets Type.
        /// </summary>
        public virtual string Type { get; set; }

        /// <summary>
        /// Gets or sets ValueAxis.
        /// </summary>
        public virtual LinkElement ValueAxis { get; set; }

        /// <summary>
        /// Gets or sets Walls.
        /// </summary>
        public virtual LinkElement Walls { get; set; }

        /// <summary>
        /// Gets or sets WallsAndGridlines2D.
        /// </summary>
        public virtual bool? WallsAndGridlines2D { get; set; }

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
            sb.Append("class Chart {\n");
            sb.Append("  AutoScaling: ").Append(this.AutoScaling).Append("\n");
            sb.Append("  BackWall: ").Append(this.BackWall).Append("\n");
            sb.Append("  CategoryAxis: ").Append(this.CategoryAxis).Append("\n");
            sb.Append("  ChartArea: ").Append(this.ChartArea).Append("\n");
            sb.Append("  ChartDataTable: ").Append(this.ChartDataTable).Append("\n");
            sb.Append("  ChartObject: ").Append(this.ChartObject).Append("\n");
            sb.Append("  DepthPercent: ").Append(this.DepthPercent).Append("\n");
            sb.Append("  Elevation: ").Append(this.Elevation).Append("\n");
            sb.Append("  FirstSliceAngle: ").Append(this.FirstSliceAngle).Append("\n");
            sb.Append("  Floor: ").Append(this.Floor).Append("\n");
            sb.Append("  GapDepth: ").Append(this.GapDepth).Append("\n");
            sb.Append("  GapWidth: ").Append(this.GapWidth).Append("\n");
            sb.Append("  HeightPercent: ").Append(this.HeightPercent).Append("\n");
            sb.Append("  HidePivotFieldButtons: ").Append(this.HidePivotFieldButtons).Append("\n");
            sb.Append("  Is3D: ").Append(this.Is3D).Append("\n");
            sb.Append("  IsRectangularCornered: ").Append(this.IsRectangularCornered).Append("\n");
            sb.Append("  Legend: ").Append(this.Legend).Append("\n");
            sb.Append("  Name: ").Append(this.Name).Append("\n");
            sb.Append("  NSeries: ").Append(this.NSeries).Append("\n");
            sb.Append("  PageSetup: ").Append(this.PageSetup).Append("\n");
            sb.Append("  Perspective: ").Append(this.Perspective).Append("\n");
            sb.Append("  PivotSource: ").Append(this.PivotSource).Append("\n");
            sb.Append("  Placement: ").Append(this.Placement).Append("\n");
            sb.Append("  PlotArea: ").Append(this.PlotArea).Append("\n");
            sb.Append("  PlotEmptyCellsType: ").Append(this.PlotEmptyCellsType).Append("\n");
            sb.Append("  PlotVisibleCells: ").Append(this.PlotVisibleCells).Append("\n");
            sb.Append("  PrintSize: ").Append(this.PrintSize).Append("\n");
            sb.Append("  RightAngleAxes: ").Append(this.RightAngleAxes).Append("\n");
            sb.Append("  RotationAngle: ").Append(this.RotationAngle).Append("\n");
            sb.Append("  SecondCategoryAxis: ").Append(this.SecondCategoryAxis).Append("\n");
            sb.Append("  SecondValueAxis: ").Append(this.SecondValueAxis).Append("\n");
            sb.Append("  SeriesAxis: ").Append(this.SeriesAxis).Append("\n");
            sb.Append("  Shapes: ").Append(this.Shapes).Append("\n");
            sb.Append("  ShowDataTable: ").Append(this.ShowDataTable).Append("\n");
            sb.Append("  ShowLegend: ").Append(this.ShowLegend).Append("\n");
            sb.Append("  SideWall: ").Append(this.SideWall).Append("\n");
            sb.Append("  SizeWithWindow: ").Append(this.SizeWithWindow).Append("\n");
            sb.Append("  Style: ").Append(this.Style).Append("\n");
            sb.Append("  Title: ").Append(this.Title).Append("\n");
            sb.Append("  Type: ").Append(this.Type).Append("\n");
            sb.Append("  ValueAxis: ").Append(this.ValueAxis).Append("\n");
            sb.Append("  Walls: ").Append(this.Walls).Append("\n");
            sb.Append("  WallsAndGridlines2D: ").Append(this.WallsAndGridlines2D).Append("\n");
            sb.Append("  link: ").Append(this.link).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
