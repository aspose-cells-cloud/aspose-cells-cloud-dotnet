// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="Comment.cs">
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
  public class Comment 
  {                       
        /// <summary>
        /// Gets or sets Link
        /// </summary>  
		[DataMember(Name="link", EmitDefaultValue=false)]
        public Link Link { get; set; }

        /// <summary>
        /// Gets or sets AutoSize
        /// </summary>  
		[DataMember(Name="AutoSize", EmitDefaultValue=false)]
        public bool? AutoSize { get; set; }

        /// <summary>
        /// Gets or sets Author
        /// </summary>  
		[DataMember(Name="Author", EmitDefaultValue=false)]
        public string Author { get; set; }

        /// <summary>
        /// Gets or sets IsVisible
        /// </summary>  
		[DataMember(Name="IsVisible", EmitDefaultValue=false)]
        public bool? IsVisible { get; set; }

        /// <summary>
        /// Gets or sets TextOrientationType
        /// </summary>  
		[DataMember(Name="TextOrientationType", EmitDefaultValue=false)]
        public string TextOrientationType { get; set; }

        /// <summary>
        /// Gets or sets Height
        /// </summary>  
		[DataMember(Name="Height", EmitDefaultValue=false)]
        public int? Height { get; set; }

        /// <summary>
        /// Gets or sets Note
        /// </summary>  
		[DataMember(Name="Note", EmitDefaultValue=false)]
        public string Note { get; set; }

        /// <summary>
        /// Gets or sets Width
        /// </summary>  
		[DataMember(Name="Width", EmitDefaultValue=false)]
        public int? Width { get; set; }

        /// <summary>
        /// Gets or sets TextVerticalAlignment
        /// </summary>  
		[DataMember(Name="TextVerticalAlignment", EmitDefaultValue=false)]
        public string TextVerticalAlignment { get; set; }

        /// <summary>
        /// Gets or sets CellName
        /// </summary>  
		[DataMember(Name="CellName", EmitDefaultValue=false)]
        public string CellName { get; set; }

        /// <summary>
        /// Gets or sets HtmlNote
        /// </summary>  
		[DataMember(Name="HtmlNote", EmitDefaultValue=false)]
        public string HtmlNote { get; set; }

        /// <summary>
        /// Gets or sets TextHorizontalAlignment
        /// </summary>  
		[DataMember(Name="TextHorizontalAlignment", EmitDefaultValue=false)]
        public string TextHorizontalAlignment { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class Comment {\n");
          sb.Append("  Link: ").Append(this.Link).Append("\n");
          sb.Append("  AutoSize: ").Append(this.AutoSize).Append("\n");
          sb.Append("  Author: ").Append(this.Author).Append("\n");
          sb.Append("  IsVisible: ").Append(this.IsVisible).Append("\n");
          sb.Append("  TextOrientationType: ").Append(this.TextOrientationType).Append("\n");
          sb.Append("  Height: ").Append(this.Height).Append("\n");
          sb.Append("  Note: ").Append(this.Note).Append("\n");
          sb.Append("  Width: ").Append(this.Width).Append("\n");
          sb.Append("  TextVerticalAlignment: ").Append(this.TextVerticalAlignment).Append("\n");
          sb.Append("  CellName: ").Append(this.CellName).Append("\n");
          sb.Append("  HtmlNote: ").Append(this.HtmlNote).Append("\n");
          sb.Append("  TextHorizontalAlignment: ").Append(this.TextHorizontalAlignment).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
