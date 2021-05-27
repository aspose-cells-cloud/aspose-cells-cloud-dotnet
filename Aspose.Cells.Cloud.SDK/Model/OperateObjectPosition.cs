// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="OperateObjectPosition.cs">
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
  public class OperateObjectPosition 
  {                       
        /// <summary>
        /// Gets or sets ChartIndex
        /// </summary>  
		[DataMember(Name="ChartIndex", EmitDefaultValue=false)]
        public int? ChartIndex { get; set; }

        /// <summary>
        /// Gets or sets ListObjectIndex
        /// </summary>  
		[DataMember(Name="ListObjectIndex", EmitDefaultValue=false)]
        public int? ListObjectIndex { get; set; }

        /// <summary>
        /// Gets or sets SheetName
        /// </summary>  
		[DataMember(Name="SheetName", EmitDefaultValue=false)]
        public string SheetName { get; set; }

        /// <summary>
        /// Gets or sets ShapeIndex
        /// </summary>  
		[DataMember(Name="ShapeIndex", EmitDefaultValue=false)]
        public int? ShapeIndex { get; set; }

        /// <summary>
        /// Gets or sets CellName
        /// </summary>  
		[DataMember(Name="CellName", EmitDefaultValue=false)]
        public string CellName { get; set; }

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
          sb.Append("class OperateObjectPosition {\n");
          sb.Append("  ChartIndex: ").Append(this.ChartIndex).Append("\n");
          sb.Append("  ListObjectIndex: ").Append(this.ListObjectIndex).Append("\n");
          sb.Append("  SheetName: ").Append(this.SheetName).Append("\n");
          sb.Append("  ShapeIndex: ").Append(this.ShapeIndex).Append("\n");
          sb.Append("  CellName: ").Append(this.CellName).Append("\n");
          sb.Append("  Workbook: ").Append(this.Workbook).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
