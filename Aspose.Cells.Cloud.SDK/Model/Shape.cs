// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="Shape.cs">
//   Copyright (c) 2022 Aspose.Cells for Cloud
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
  public class Shape 
  {                       
        /// <summary>
        /// Gets or sets Link
        /// </summary>  
		[DataMember(Name="link", EmitDefaultValue=false)]
        public Link Link { get; set; }

        /// <summary>
        /// Gets or sets AlternativeText
        /// </summary>  
		[DataMember(Name="AlternativeText", EmitDefaultValue=false)]
        public string AlternativeText { get; set; }

        /// <summary>
        /// Gets or sets Bottom
        /// </summary>  
		[DataMember(Name="Bottom", EmitDefaultValue=false)]
        public int? Bottom { get; set; }

        /// <summary>
        /// Gets or sets Top
        /// </summary>  
		[DataMember(Name="Top", EmitDefaultValue=false)]
        public int? Top { get; set; }

        /// <summary>
        /// Gets or sets Width
        /// </summary>  
		[DataMember(Name="Width", EmitDefaultValue=false)]
        public int? Width { get; set; }

        /// <summary>
        /// Gets or sets HtmlText
        /// </summary>  
		[DataMember(Name="HtmlText", EmitDefaultValue=false)]
        public string HtmlText { get; set; }

        /// <summary>
        /// Gets or sets TextVerticalAlignment
        /// </summary>  
		[DataMember(Name="TextVerticalAlignment", EmitDefaultValue=false)]
        public string TextVerticalAlignment { get; set; }

        /// <summary>
        /// Gets or sets AutoShapeType
        /// </summary>  
		[DataMember(Name="AutoShapeType", EmitDefaultValue=false)]
        public string AutoShapeType { get; set; }

        /// <summary>
        /// Gets or sets IsPrintable
        /// </summary>  
		[DataMember(Name="IsPrintable", EmitDefaultValue=false)]
        public bool? IsPrintable { get; set; }

        /// <summary>
        /// Gets or sets UpperLeftColumn
        /// </summary>  
		[DataMember(Name="UpperLeftColumn", EmitDefaultValue=false)]
        public int? UpperLeftColumn { get; set; }

        /// <summary>
        /// Gets or sets IsLockAspectRatio
        /// </summary>  
		[DataMember(Name="IsLockAspectRatio", EmitDefaultValue=false)]
        public bool? IsLockAspectRatio { get; set; }

        /// <summary>
        /// Gets or sets IsGroup
        /// </summary>  
		[DataMember(Name="IsGroup", EmitDefaultValue=false)]
        public bool? IsGroup { get; set; }

        /// <summary>
        /// Gets or sets RotationAngle
        /// </summary>  
		[DataMember(Name="RotationAngle", EmitDefaultValue=false)]
        public double? RotationAngle { get; set; }

        /// <summary>
        /// Gets or sets ZOrderPosition
        /// </summary>  
		[DataMember(Name="ZOrderPosition", EmitDefaultValue=false)]
        public int? ZOrderPosition { get; set; }

        /// <summary>
        /// Gets or sets TextHorizontalOverflow
        /// </summary>  
		[DataMember(Name="TextHorizontalOverflow", EmitDefaultValue=false)]
        public string TextHorizontalOverflow { get; set; }

        /// <summary>
        /// Gets or sets MsoDrawingType
        /// </summary>  
		[DataMember(Name="MsoDrawingType", EmitDefaultValue=false)]
        public string MsoDrawingType { get; set; }

        /// <summary>
        /// Gets or sets TextOrientationType
        /// </summary>  
		[DataMember(Name="TextOrientationType", EmitDefaultValue=false)]
        public string TextOrientationType { get; set; }

        /// <summary>
        /// Gets or sets Placement
        /// </summary>  
		[DataMember(Name="Placement", EmitDefaultValue=false)]
        public string Placement { get; set; }

        /// <summary>
        /// Gets or sets Name
        /// </summary>  
		[DataMember(Name="Name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets IsWordArt
        /// </summary>  
		[DataMember(Name="IsWordArt", EmitDefaultValue=false)]
        public bool? IsWordArt { get; set; }

        /// <summary>
        /// Gets or sets LinkedCell
        /// </summary>  
		[DataMember(Name="LinkedCell", EmitDefaultValue=false)]
        public string LinkedCell { get; set; }

        /// <summary>
        /// Gets or sets UpperLeftRow
        /// </summary>  
		[DataMember(Name="UpperLeftRow", EmitDefaultValue=false)]
        public int? UpperLeftRow { get; set; }

        /// <summary>
        /// Gets or sets IsLocked
        /// </summary>  
		[DataMember(Name="IsLocked", EmitDefaultValue=false)]
        public bool? IsLocked { get; set; }

        /// <summary>
        /// Gets or sets LowerRightRow
        /// </summary>  
		[DataMember(Name="LowerRightRow", EmitDefaultValue=false)]
        public int? LowerRightRow { get; set; }

        /// <summary>
        /// Gets or sets IsTextWrapped
        /// </summary>  
		[DataMember(Name="IsTextWrapped", EmitDefaultValue=false)]
        public bool? IsTextWrapped { get; set; }

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
        /// Gets or sets IsHidden
        /// </summary>  
		[DataMember(Name="IsHidden", EmitDefaultValue=false)]
        public bool? IsHidden { get; set; }

        /// <summary>
        /// Gets or sets Left
        /// </summary>  
		[DataMember(Name="Left", EmitDefaultValue=false)]
        public int? Left { get; set; }

        /// <summary>
        /// Gets or sets Right
        /// </summary>  
		[DataMember(Name="Right", EmitDefaultValue=false)]
        public int? Right { get; set; }

        /// <summary>
        /// Gets or sets Text
        /// </summary>  
		[DataMember(Name="Text", EmitDefaultValue=false)]
        public string Text { get; set; }

        /// <summary>
        /// Gets or sets LowerRightColumn
        /// </summary>  
		[DataMember(Name="LowerRightColumn", EmitDefaultValue=false)]
        public int? LowerRightColumn { get; set; }

        /// <summary>
        /// Gets or sets Height
        /// </summary>  
		[DataMember(Name="Height", EmitDefaultValue=false)]
        public int? Height { get; set; }

        /// <summary>
        /// Gets or sets TextHorizontalAlignment
        /// </summary>  
		[DataMember(Name="TextHorizontalAlignment", EmitDefaultValue=false)]
        public string TextHorizontalAlignment { get; set; }

        /// <summary>
        /// Gets or sets TextVerticalOverflow
        /// </summary>  
		[DataMember(Name="TextVerticalOverflow", EmitDefaultValue=false)]
        public string TextVerticalOverflow { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class Shape {\n");
          sb.Append("  Link: ").Append(this.Link).Append("\n");
          sb.Append("  AlternativeText: ").Append(this.AlternativeText).Append("\n");
          sb.Append("  Bottom: ").Append(this.Bottom).Append("\n");
          sb.Append("  Top: ").Append(this.Top).Append("\n");
          sb.Append("  Width: ").Append(this.Width).Append("\n");
          sb.Append("  HtmlText: ").Append(this.HtmlText).Append("\n");
          sb.Append("  TextVerticalAlignment: ").Append(this.TextVerticalAlignment).Append("\n");
          sb.Append("  AutoShapeType: ").Append(this.AutoShapeType).Append("\n");
          sb.Append("  IsPrintable: ").Append(this.IsPrintable).Append("\n");
          sb.Append("  UpperLeftColumn: ").Append(this.UpperLeftColumn).Append("\n");
          sb.Append("  IsLockAspectRatio: ").Append(this.IsLockAspectRatio).Append("\n");
          sb.Append("  IsGroup: ").Append(this.IsGroup).Append("\n");
          sb.Append("  RotationAngle: ").Append(this.RotationAngle).Append("\n");
          sb.Append("  ZOrderPosition: ").Append(this.ZOrderPosition).Append("\n");
          sb.Append("  TextHorizontalOverflow: ").Append(this.TextHorizontalOverflow).Append("\n");
          sb.Append("  MsoDrawingType: ").Append(this.MsoDrawingType).Append("\n");
          sb.Append("  TextOrientationType: ").Append(this.TextOrientationType).Append("\n");
          sb.Append("  Placement: ").Append(this.Placement).Append("\n");
          sb.Append("  Name: ").Append(this.Name).Append("\n");
          sb.Append("  IsWordArt: ").Append(this.IsWordArt).Append("\n");
          sb.Append("  LinkedCell: ").Append(this.LinkedCell).Append("\n");
          sb.Append("  UpperLeftRow: ").Append(this.UpperLeftRow).Append("\n");
          sb.Append("  IsLocked: ").Append(this.IsLocked).Append("\n");
          sb.Append("  LowerRightRow: ").Append(this.LowerRightRow).Append("\n");
          sb.Append("  IsTextWrapped: ").Append(this.IsTextWrapped).Append("\n");
          sb.Append("  Y: ").Append(this.Y).Append("\n");
          sb.Append("  X: ").Append(this.X).Append("\n");
          sb.Append("  IsHidden: ").Append(this.IsHidden).Append("\n");
          sb.Append("  Left: ").Append(this.Left).Append("\n");
          sb.Append("  Right: ").Append(this.Right).Append("\n");
          sb.Append("  Text: ").Append(this.Text).Append("\n");
          sb.Append("  LowerRightColumn: ").Append(this.LowerRightColumn).Append("\n");
          sb.Append("  Height: ").Append(this.Height).Append("\n");
          sb.Append("  TextHorizontalAlignment: ").Append(this.TextHorizontalAlignment).Append("\n");
          sb.Append("  TextVerticalOverflow: ").Append(this.TextVerticalOverflow).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
