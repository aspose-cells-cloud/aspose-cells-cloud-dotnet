// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ChartArea.cs">
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
  public class ChartArea 
  {                       
        /// <summary>
        /// Gets or sets IsInnerMode
        /// </summary>  
		[DataMember(Name="IsInnerMode", EmitDefaultValue=false)]
        public bool? IsInnerMode { get; set; }

        /// <summary>
        /// Gets or sets ShapeProperties
        /// </summary>  
		[DataMember(Name="ShapeProperties", EmitDefaultValue=false)]
        public List<LinkElement> ShapeProperties { get; set; }

        /// <summary>
        /// Gets or sets AutoScaleFont
        /// </summary>  
		[DataMember(Name="AutoScaleFont", EmitDefaultValue=false)]
        public bool? AutoScaleFont { get; set; }

        /// <summary>
        /// Gets or sets Area
        /// </summary>  
		[DataMember(Name="Area", EmitDefaultValue=false)]
        public Area Area { get; set; }

        /// <summary>
        /// Gets or sets Height
        /// </summary>  
		[DataMember(Name="Height", EmitDefaultValue=false)]
        public int? Height { get; set; }

        /// <summary>
        /// Gets or sets Width
        /// </summary>  
		[DataMember(Name="Width", EmitDefaultValue=false)]
        public int? Width { get; set; }

        /// <summary>
        /// Gets or sets BackgroundMode
        /// </summary>  
		[DataMember(Name="BackgroundMode", EmitDefaultValue=false)]
        public string BackgroundMode { get; set; }

        /// <summary>
        /// Gets or sets IsAutomaticSize
        /// </summary>  
		[DataMember(Name="IsAutomaticSize", EmitDefaultValue=false)]
        public bool? IsAutomaticSize { get; set; }

        /// <summary>
        /// Gets or sets Y
        /// </summary>  
		[DataMember(Name="Y", EmitDefaultValue=false)]
        public int? Y { get; set; }

        /// <summary>
        /// Gets or sets X
        /// </summary>  
		[DataMember(Name="X", EmitDefaultValue=false)]
        public int? X { get; set; }

        /// <summary>
        /// Gets or sets Shadow
        /// </summary>  
		[DataMember(Name="Shadow", EmitDefaultValue=false)]
        public bool? Shadow { get; set; }

        /// <summary>
        /// Gets or sets Font
        /// </summary>  
		[DataMember(Name="Font", EmitDefaultValue=false)]
        public Font Font { get; set; }

        /// <summary>
        /// Gets or sets Border
        /// </summary>  
		[DataMember(Name="Border", EmitDefaultValue=false)]
        public Line Border { get; set; }

        /// <summary>
        /// Gets or sets Link
        /// </summary>  
		[DataMember(Name="link", EmitDefaultValue=false)]
        public Link Link { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class ChartArea {\n");
          sb.Append("  IsInnerMode: ").Append(this.IsInnerMode).Append("\n");
          sb.Append("  ShapeProperties: ").Append(this.ShapeProperties).Append("\n");
          sb.Append("  AutoScaleFont: ").Append(this.AutoScaleFont).Append("\n");
          sb.Append("  Area: ").Append(this.Area).Append("\n");
          sb.Append("  Height: ").Append(this.Height).Append("\n");
          sb.Append("  Width: ").Append(this.Width).Append("\n");
          sb.Append("  BackgroundMode: ").Append(this.BackgroundMode).Append("\n");
          sb.Append("  IsAutomaticSize: ").Append(this.IsAutomaticSize).Append("\n");
          sb.Append("  Y: ").Append(this.Y).Append("\n");
          sb.Append("  X: ").Append(this.X).Append("\n");
          sb.Append("  Shadow: ").Append(this.Shadow).Append("\n");
          sb.Append("  Font: ").Append(this.Font).Append("\n");
          sb.Append("  Border: ").Append(this.Border).Append("\n");
          sb.Append("  Link: ").Append(this.Link).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
