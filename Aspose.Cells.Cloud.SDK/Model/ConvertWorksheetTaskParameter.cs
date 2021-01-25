// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ConvertWorksheetTaskParameter.cs">
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
  public class ConvertWorksheetTaskParameter : TaskParameter 
  {                       
        /// <summary>
        /// Gets or sets Workbook
        /// </summary>  
		[DataMember(Name="Workbook", EmitDefaultValue=false)]
        public FileSource Workbook { get; set; }

        /// <summary>
        /// Gets or sets Sheet
        /// </summary>  
		[DataMember(Name="Sheet", EmitDefaultValue=false)]
        public string Sheet { get; set; }

        /// <summary>
        /// Gets or sets Target
        /// </summary>  
		[DataMember(Name="Target", EmitDefaultValue=false)]
        public FileSource Target { get; set; }

        /// <summary>
        /// Gets or sets Format
        /// </summary>  
		[DataMember(Name="Format", EmitDefaultValue=false)]
        public string Format { get; set; }

        /// <summary>
        /// Gets or sets Area
        /// </summary>  
		[DataMember(Name="Area", EmitDefaultValue=false)]
        public string Area { get; set; }

        /// <summary>
        /// Gets or sets PageIndex
        /// </summary>  
		[DataMember(Name="PageIndex", EmitDefaultValue=false)]
        public int? PageIndex { get; set; }

        /// <summary>
        /// Gets or sets VerticalResolution
        /// </summary>  
		[DataMember(Name="VerticalResolution", EmitDefaultValue=false)]
        public int? VerticalResolution { get; set; }

        /// <summary>
        /// Gets or sets HorizontalResolution
        /// </summary>  
		[DataMember(Name="HorizontalResolution", EmitDefaultValue=false)]
        public int? HorizontalResolution { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class ConvertWorksheetTaskParameter {\n");
          sb.Append("  Workbook: ").Append(this.Workbook).Append("\n");
          sb.Append("  Sheet: ").Append(this.Sheet).Append("\n");
          sb.Append("  Target: ").Append(this.Target).Append("\n");
          sb.Append("  Format: ").Append(this.Format).Append("\n");
          sb.Append("  Area: ").Append(this.Area).Append("\n");
          sb.Append("  PageIndex: ").Append(this.PageIndex).Append("\n");
          sb.Append("  VerticalResolution: ").Append(this.VerticalResolution).Append("\n");
          sb.Append("  HorizontalResolution: ").Append(this.HorizontalResolution).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
