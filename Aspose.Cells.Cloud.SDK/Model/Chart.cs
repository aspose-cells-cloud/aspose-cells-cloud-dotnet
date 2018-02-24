// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="Chart.cs">
//   Copyright (c) 2016 Aspose.Cells for Cloud
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
  using Newtonsoft.Json;
  using Newtonsoft.Json.Converters;

  /// <summary>
  /// 
  /// </summary>  
  [DataContract]
  public class Chart 
  {                       
        /// <summary>
        /// Gets or sets Link
        /// </summary>  
		[DataMember(Name="link", EmitDefaultValue=false)]
        public Link Link { get; set; }

        /// <summary>
        /// True if Microsoft Excel scales a 3-D chart so that it's closer in size to the equivalent 2-D chart. The RightAngleAxes property must be True.
        /// </summary>  
		[DataMember(Name="AutoScaling", EmitDefaultValue=false)]
        public bool? AutoScaling { get; set; }

        /// <summary>
        /// Gets or sets BackWall
        /// </summary>  
		[DataMember(Name="BackWall", EmitDefaultValue=false)]
        public LinkElement BackWall { get; set; }

        /// <summary>
        /// Gets the chart's X axis. The property is read only
        /// </summary>  
		[DataMember(Name="CategoryAxis", EmitDefaultValue=false)]
        public LinkElement CategoryAxis { get; set; }

        /// <summary>
        /// Gets the chart area in the worksheet
        /// </summary>  
		[DataMember(Name="ChartArea", EmitDefaultValue=false)]
        public LinkElement ChartArea { get; set; }

        /// <summary>
        /// Represents the chart data table.
        /// </summary>  
		[DataMember(Name="ChartDataTable", EmitDefaultValue=false)]
        public LinkElement ChartDataTable { get; set; }

        /// <summary>
        /// Represents the chartShape;
        /// </summary>  
		[DataMember(Name="ChartObject", EmitDefaultValue=false)]
        public LinkElement ChartObject { get; set; }

        /// <summary>
        /// Represents the depth of a 3-D chart as a percentage of the chart width (between 20 and 2000 percent).
        /// </summary>  
		[DataMember(Name="DepthPercent", EmitDefaultValue=false)]
        public int? DepthPercent { get; set; }

        /// <summary>
        /// Represents the elevation of the 3-D chart view, in degrees.
        /// </summary>  
		[DataMember(Name="Elevation", EmitDefaultValue=false)]
        public int? Elevation { get; set; }

        /// <summary>
        /// Gets or sets the angle of the first pie-chart or doughnut-chart slice, in degrees (clockwise from vertical). Applies only to pie, 3-D pie, and doughnut charts, 0 to 360.
        /// </summary>  
		[DataMember(Name="FirstSliceAngle", EmitDefaultValue=false)]
        public int? FirstSliceAngle { get; set; }

        /// <summary>
        /// Returns a Floor object that represents the walls of a 3-D chart.             
        /// </summary>  
		[DataMember(Name="Floor", EmitDefaultValue=false)]
        public LinkElement Floor { get; set; }

        /// <summary>
        /// Gets or sets the distance between the data series in a 3-D chart, as a percentage of the marker width.The value of this property must be between 0 and 500.
        /// </summary>  
		[DataMember(Name="GapDepth", EmitDefaultValue=false)]
        public int? GapDepth { get; set; }

        /// <summary>
        /// Returns or sets the space between bar or column clusters, as a percentage of the bar or column width. The value of this property must be between 0 and 500.             
        /// </summary>  
		[DataMember(Name="GapWidth", EmitDefaultValue=false)]
        public int? GapWidth { get; set; }

        /// <summary>
        /// Returns or sets the height of a 3-D chart as a percentage of the chart width (between 5 and 500 percent).
        /// </summary>  
		[DataMember(Name="HeightPercent", EmitDefaultValue=false)]
        public int? HeightPercent { get; set; }

        /// <summary>
        /// Indicates whether hide the pivot chart field buttons only when the chart is PivotChart
        /// </summary>  
		[DataMember(Name="HidePivotFieldButtons", EmitDefaultValue=false)]
        public bool? HidePivotFieldButtons { get; set; }

        /// <summary>
        /// Indicates whether the chart is a 3d chart.
        /// </summary>  
		[DataMember(Name="Is3D", EmitDefaultValue=false)]
        public bool? Is3D { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the chart displays a data table.
        /// </summary>  
		[DataMember(Name="IsRectangularCornered", EmitDefaultValue=false)]
        public bool? IsRectangularCornered { get; set; }

        /// <summary>
        /// Gets the chart legend.
        /// </summary>  
		[DataMember(Name="Legend", EmitDefaultValue=false)]
        public LinkElement Legend { get; set; }

        /// <summary>
        /// Gets and sets the name of the chart.
        /// </summary>  
		[DataMember(Name="Name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets a SeriesCollection collection representing the data series in the chart.
        /// </summary>  
		[DataMember(Name="NSeries", EmitDefaultValue=false)]
        public LinkElement NSeries { get; set; }

        /// <summary>
        /// Represents the page setup description in this chart.
        /// </summary>  
		[DataMember(Name="PageSetup", EmitDefaultValue=false)]
        public LinkElement PageSetup { get; set; }

        /// <summary>
        /// Returns or sets the perspective for the 3-D chart view. Must be between 0 and 100.This property is ignored if the RightAngleAxes property is True.
        /// </summary>  
		[DataMember(Name="Perspective", EmitDefaultValue=false)]
        public int? Perspective { get; set; }

        /// <summary>
        /// The source is the data of the pivotTable.If PivotSource is not empty ,the chart is PivotChart.
        /// </summary>  
		[DataMember(Name="PivotSource", EmitDefaultValue=false)]
        public string PivotSource { get; set; }

        /// <summary>
        /// Represents the way the chart is attached to the cells below it.
        /// </summary>  
		[DataMember(Name="Placement", EmitDefaultValue=false)]
        public string Placement { get; set; }

        /// <summary>
        /// Gets the chart's plot area which includes axis tick lables.
        /// </summary>  
		[DataMember(Name="PlotArea", EmitDefaultValue=false)]
        public LinkElement PlotArea { get; set; }

        /// <summary>
        /// Gets and sets how to plot the empty cells.
        /// </summary>  
		[DataMember(Name="PlotEmptyCellsType", EmitDefaultValue=false)]
        public string PlotEmptyCellsType { get; set; }

        /// <summary>
        /// Indicates whether only plot visible cells.
        /// </summary>  
		[DataMember(Name="PlotVisibleCells", EmitDefaultValue=false)]
        public bool? PlotVisibleCells { get; set; }

        /// <summary>
        /// Gets and sets the printed chart size.
        /// </summary>  
		[DataMember(Name="PrintSize", EmitDefaultValue=false)]
        public string PrintSize { get; set; }

        /// <summary>
        /// True if the chart axes are at right angles.Applies only for 3-D charts(except Column3D and 3-D Pie Charts).
        /// </summary>  
		[DataMember(Name="RightAngleAxes", EmitDefaultValue=false)]
        public bool? RightAngleAxes { get; set; }

        /// <summary>
        /// Represents the rotation of the 3-D chart view (the rotation of the plot area around the z-axis, in degrees).
        /// </summary>  
		[DataMember(Name="RotationAngle", EmitDefaultValue=false)]
        public int? RotationAngle { get; set; }

        /// <summary>
        /// Gets the chart's second X axis.
        /// </summary>  
		[DataMember(Name="SecondCategoryAxis", EmitDefaultValue=false)]
        public LinkElement SecondCategoryAxis { get; set; }

        /// <summary>
        /// Gets the chart's second Y axis.
        /// </summary>  
		[DataMember(Name="SecondValueAxis", EmitDefaultValue=false)]
        public LinkElement SecondValueAxis { get; set; }

        /// <summary>
        /// Gets the chart's series axis.
        /// </summary>  
		[DataMember(Name="SeriesAxis", EmitDefaultValue=false)]
        public LinkElement SeriesAxis { get; set; }

        /// <summary>
        /// Returns all drawing shapes in this chart.
        /// </summary>  
		[DataMember(Name="Shapes", EmitDefaultValue=false)]
        public LinkElement Shapes { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the chart displays a data table.
        /// </summary>  
		[DataMember(Name="ShowDataTable", EmitDefaultValue=false)]
        public bool? ShowDataTable { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the chart legend will be displayed. Default is true.
        /// </summary>  
		[DataMember(Name="ShowLegend", EmitDefaultValue=false)]
        public bool? ShowLegend { get; set; }

        /// <summary>
        /// Gets or sets SideWall
        /// </summary>  
		[DataMember(Name="SideWall", EmitDefaultValue=false)]
        public LinkElement SideWall { get; set; }

        /// <summary>
        /// True if Microsoft Excel resizes the chart to match the size of the chart sheet window.
        /// </summary>  
		[DataMember(Name="SizeWithWindow", EmitDefaultValue=false)]
        public bool? SizeWithWindow { get; set; }

        /// <summary>
        /// Gets and sets the builtin style.
        /// </summary>  
		[DataMember(Name="Style", EmitDefaultValue=false)]
        public int? Style { get; set; }

        /// <summary>
        /// Gets the chart's title.
        /// </summary>  
		[DataMember(Name="Title", EmitDefaultValue=false)]
        public LinkElement Title { get; set; }

        /// <summary>
        /// Gets or sets a chart's type.
        /// </summary>  
		[DataMember(Name="Type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets the chart's Y axis.
        /// </summary>  
		[DataMember(Name="ValueAxis", EmitDefaultValue=false)]
        public LinkElement ValueAxis { get; set; }

        /// <summary>
        /// Returns a Walls object that represents the walls of a 3-D chart.
        /// </summary>  
		[DataMember(Name="Walls", EmitDefaultValue=false)]
        public LinkElement Walls { get; set; }

        /// <summary>
        /// True if gridlines are drawn two-dimensionally on a 3-D chart.
        /// </summary>  
		[DataMember(Name="WallsAndGridlines2D", EmitDefaultValue=false)]
        public bool? WallsAndGridlines2D { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class Chart {\n");
          sb.Append("  Link: ").Append(this.Link).Append("\n");
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
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
