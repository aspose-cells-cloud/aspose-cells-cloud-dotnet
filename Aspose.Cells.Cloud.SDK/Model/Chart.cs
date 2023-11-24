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
        /// True if Microsoft Excel scales a 3-D chart so that it's closer in size to the equivalent 2-D chart. 
        ///                         The RightAngleAxes property must be True.
        /// </summary>
        public virtual bool? AutoScaling { get; set; }

        /// <summary>
        /// Returns a  object that represents the back wall of a 3-D chart.
        /// </summary>
        public virtual LinkElement BackWall { get; set; }

        /// <summary>
        /// Gets the chart's X axis.
        /// </summary>
        public virtual LinkElement CategoryAxis { get; set; }

        /// <summary>
        /// Gets the chart area in the worksheet.
        /// </summary>
        public virtual LinkElement ChartArea { get; set; }

        /// <summary>
        /// Represents the chart data table.
        /// </summary>
        public virtual LinkElement ChartDataTable { get; set; }

        /// <summary>
        /// Represents the chartShape;
        /// </summary>
        public virtual LinkElement ChartObject { get; set; }

        /// <summary>
        /// Represents the depth of a 3-D chart as a percentage of the chart width (between 20 and 2000 percent).
        /// </summary>
        public virtual int? DepthPercent { get; set; }

        /// <summary>
        /// Represents the elevation of the 3-D chart view, in degrees.
        /// </summary>
        public virtual int? Elevation { get; set; }

        /// <summary>
        /// Gets or sets the angle of the first pie-chart or doughnut-chart slice, in degrees (clockwise from vertical). 
        ///                         Applies only to pie, 3-D pie, and doughnut charts, 0 to 360.
        /// </summary>
        public virtual int? FirstSliceAngle { get; set; }

        /// <summary>
        /// Returns a  object that represents the walls of a 3-D chart.
        /// </summary>
        public virtual LinkElement Floor { get; set; }

        /// <summary>
        /// Gets or sets the distance between the data series in a 3-D chart, as a percentage of the marker width.
        ///                         The value of this property must be between 0 and 500.
        /// </summary>
        public virtual int? GapDepth { get; set; }

        /// <summary>
        /// Returns or sets the space between bar or column clusters, as a percentage of the bar or column width.
        ///                         The value of this property must be between 0 and 500.
        /// </summary>
        public virtual int? GapWidth { get; set; }

        /// <summary>
        /// Returns or sets the height of a 3-D chart as a percentage of the chart width (between 5 and 500 percent).
        /// </summary>
        public virtual int? HeightPercent { get; set; }

        /// <summary>
        /// Indicates whether hide the pivot chart field buttons only when the chart is PivotChart.
        /// </summary>
        public virtual bool? HidePivotFieldButtons { get; set; }

        /// <summary>
        /// Indicates whether the chart is a 3d chart.
        /// </summary>
        public virtual bool? Is3D { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the chart area is rectangular cornered.
        ///                         Default is true.
        /// </summary>
        public virtual bool? IsRectangularCornered { get; set; }

        /// <summary>
        /// Gets the chart legend.
        /// </summary>
        public virtual LinkElement Legend { get; set; }

        /// <summary>
        /// Gets and sets the name of the chart.
        /// </summary>
        public virtual string Name { get; set; }

        /// <summary>
        /// Gets a  collection representing the data series in the chart.
        /// </summary>
        public virtual LinkElement NSeries { get; set; }

        /// <summary>
        /// Represents the page setup description in this chart.
        /// </summary>
        public virtual LinkElement PageSetup { get; set; }

        /// <summary>
        /// Returns or sets the perspective for the 3-D chart view. Must be between 0 and 100.
        ///                         This property is ignored if the RightAngleAxes property is True.
        /// </summary>
        public virtual int? Perspective { get; set; }

        /// <summary>
        /// The source is the data of the pivotTable.
        ///                         If PivotSource is not empty ,the chart is PivotChart.
        /// </summary>
        public virtual string PivotSource { get; set; }

        /// <summary>
        /// Represents the way the chart is attached to the cells below it.
        /// </summary>
        public virtual string Placement { get; set; }

        /// <summary>
        /// Gets the chart's plot area which includes axis tick labels.
        /// </summary>
        public virtual LinkElement PlotArea { get; set; }

        /// <summary>
        /// Gets and sets  how to plot the empty cells.
        /// </summary>
        public virtual string PlotEmptyCellsType { get; set; }

        /// <summary>
        /// Indicates whether only plot visible cells.
        /// </summary>
        public virtual bool? PlotVisibleCells { get; set; }

        /// <summary>
        /// Gets and sets the printed chart size.
        /// </summary>
        public virtual string PrintSize { get; set; }

        /// <summary>
        /// True if the chart axes are at right angles. Applies only for 3-D charts(except Column3D and 3-D Pie Charts).
        /// </summary>
        public virtual bool? RightAngleAxes { get; set; }

        /// <summary>
        /// Represents the rotation of the 3-D chart view (the rotation of the plot area around the z-axis, in degrees).
        /// </summary>
        public virtual int? RotationAngle { get; set; }

        /// <summary>
        /// Gets the chart's second X axis.
        /// </summary>
        public virtual LinkElement SecondCategoryAxis { get; set; }

        /// <summary>
        /// Gets the chart's second Y axis.
        /// </summary>
        public virtual LinkElement SecondValueAxis { get; set; }

        /// <summary>
        /// Gets the chart's series axis.
        /// </summary>
        public virtual LinkElement SeriesAxis { get; set; }

        /// <summary>
        /// Returns all drawing shapes in this chart.
        /// </summary>
        public virtual LinkElement Shapes { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the chart displays a data table.
        /// </summary>
        public virtual bool? ShowDataTable { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the chart legend will be displayed. Default is true.
        /// </summary>
        public virtual bool? ShowLegend { get; set; }

        /// <summary>
        /// Returns a  object that represents the side wall of a 3-D chart.
        /// </summary>
        public virtual LinkElement SideWall { get; set; }

        /// <summary>
        /// True if Microsoft Excel resizes the chart to match the size of the chart sheet window.
        /// </summary>
        public virtual bool? SizeWithWindow { get; set; }

        /// <summary>
        /// Gets and sets the builtin style.
        /// </summary>
        public virtual int? Style { get; set; }

        /// <summary>
        /// Gets the chart's title.
        /// </summary>
        public virtual LinkElement Title { get; set; }

        /// <summary>
        /// Gets or sets a chart's type.
        /// </summary>
        public virtual string Type { get; set; }

        /// <summary>
        /// Gets the chart's Y axis.
        /// </summary>
        public virtual LinkElement ValueAxis { get; set; }

        /// <summary>
        /// Returns a  object that represents the walls of a 3-D chart.
        /// </summary>
        public virtual LinkElement Walls { get; set; }

        /// <summary>
        /// True if gridlines are drawn two-dimensionally on a 3-D chart.
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
