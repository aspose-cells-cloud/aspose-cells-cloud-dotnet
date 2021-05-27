// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="SplitWorkbookTaskParameter.cs">
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
  public class SplitWorkbookTaskParameter : TaskParameter 
  {                       
        /// <summary>
        /// Gets or sets DestinationFileFormat
        /// </summary>  
		[DataMember(Name="DestinationFileFormat", EmitDefaultValue=false)]
        public string DestinationFileFormat { get; set; }

        /// <summary>
        /// Gets or sets DestinationFilePosition
        /// </summary>  
		[DataMember(Name="DestinationFilePosition", EmitDefaultValue=false)]
        public FileSource DestinationFilePosition { get; set; }

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
        /// Gets or sets SplitNameRule
        /// </summary>  
		[DataMember(Name="SplitNameRule", EmitDefaultValue=false)]
        public string SplitNameRule { get; set; }

        /// <summary>
        /// Gets or sets Workbook
        /// </summary>  
		[DataMember(Name="Workbook", EmitDefaultValue=false)]
        public FileSource Workbook { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class SplitWorkbookTaskParameter {\n");
          sb.Append("  DestinationFileFormat: ").Append(this.DestinationFileFormat).Append("\n");
          sb.Append("  DestinationFilePosition: ").Append(this.DestinationFilePosition).Append("\n");
          sb.Append("  VerticalResolution: ").Append(this.VerticalResolution).Append("\n");
          sb.Append("  HorizontalResolution: ").Append(this.HorizontalResolution).Append("\n");
          sb.Append("  SplitNameRule: ").Append(this.SplitNameRule).Append("\n");
          sb.Append("  Workbook: ").Append(this.Workbook).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
