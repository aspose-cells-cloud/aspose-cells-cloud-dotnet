// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="TextOptions.cs">
//   Copyright (c) 2021 Aspose.Cells Cloud
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
  public class TextOptions 
  {                       
        /// <summary>
        /// Gets or sets IsItalic
        /// </summary>  
		[DataMember(Name="IsItalic", EmitDefaultValue=false)]
        public bool? IsItalic { get; set; }

        /// <summary>
        /// Gets or sets Name
        /// </summary>  
		[DataMember(Name="Name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets DoubleSize
        /// </summary>  
		[DataMember(Name="DoubleSize", EmitDefaultValue=false)]
        public double? DoubleSize { get; set; }

        /// <summary>
        /// Gets or sets Color
        /// </summary>  
		[DataMember(Name="Color", EmitDefaultValue=false)]
        public Color Color { get; set; }

        /// <summary>
        /// Gets or sets IsBold
        /// </summary>  
		[DataMember(Name="IsBold", EmitDefaultValue=false)]
        public bool? IsBold { get; set; }

        /// <summary>
        /// Gets or sets IsSubscript
        /// </summary>  
		[DataMember(Name="IsSubscript", EmitDefaultValue=false)]
        public bool? IsSubscript { get; set; }

        /// <summary>
        /// Gets or sets IsSuperscript
        /// </summary>  
		[DataMember(Name="IsSuperscript", EmitDefaultValue=false)]
        public bool? IsSuperscript { get; set; }

        /// <summary>
        /// Gets or sets IsStrikeout
        /// </summary>  
		[DataMember(Name="IsStrikeout", EmitDefaultValue=false)]
        public bool? IsStrikeout { get; set; }

        /// <summary>
        /// Gets or sets Underline
        /// </summary>  
		[DataMember(Name="Underline", EmitDefaultValue=false)]
        public string Underline { get; set; }

        /// <summary>
        /// Gets or sets Size
        /// </summary>  
		[DataMember(Name="Size", EmitDefaultValue=false)]
        public int? Size { get; set; }

        /// <summary>
        /// Gets or sets Outline
        /// </summary>  
		[DataMember(Name="Outline", EmitDefaultValue=false)]
        public LineFormat Outline { get; set; }

        /// <summary>
        /// Gets or sets Spacing
        /// </summary>  
		[DataMember(Name="Spacing", EmitDefaultValue=false)]
        public double? Spacing { get; set; }

        /// <summary>
        /// Gets or sets Kerning
        /// </summary>  
		[DataMember(Name="Kerning", EmitDefaultValue=false)]
        public double? Kerning { get; set; }

        /// <summary>
        /// Gets or sets Shadow
        /// </summary>  
		[DataMember(Name="Shadow", EmitDefaultValue=false)]
        public ShadowEffect Shadow { get; set; }

        /// <summary>
        /// Gets or sets Fill
        /// </summary>  
		[DataMember(Name="Fill", EmitDefaultValue=false)]
        public FillFormat Fill { get; set; }

        /// <summary>
        /// Gets or sets UnderlineColor
        /// </summary>  
		[DataMember(Name="UnderlineColor", EmitDefaultValue=false)]
        public CellsColor UnderlineColor { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class TextOptions {\n");
          sb.Append("  IsItalic: ").Append(this.IsItalic).Append("\n");
          sb.Append("  Name: ").Append(this.Name).Append("\n");
          sb.Append("  DoubleSize: ").Append(this.DoubleSize).Append("\n");
          sb.Append("  Color: ").Append(this.Color).Append("\n");
          sb.Append("  IsBold: ").Append(this.IsBold).Append("\n");
          sb.Append("  IsSubscript: ").Append(this.IsSubscript).Append("\n");
          sb.Append("  IsSuperscript: ").Append(this.IsSuperscript).Append("\n");
          sb.Append("  IsStrikeout: ").Append(this.IsStrikeout).Append("\n");
          sb.Append("  Underline: ").Append(this.Underline).Append("\n");
          sb.Append("  Size: ").Append(this.Size).Append("\n");
          sb.Append("  Outline: ").Append(this.Outline).Append("\n");
          sb.Append("  Spacing: ").Append(this.Spacing).Append("\n");
          sb.Append("  Kerning: ").Append(this.Kerning).Append("\n");
          sb.Append("  Shadow: ").Append(this.Shadow).Append("\n");
          sb.Append("  Fill: ").Append(this.Fill).Append("\n");
          sb.Append("  UnderlineColor: ").Append(this.UnderlineColor).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
