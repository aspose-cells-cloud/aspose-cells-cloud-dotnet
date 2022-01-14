// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="Range.cs">
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
  public class Range 
  {                       
        /// <summary>
        /// Gets the count of columns in the range.
        /// </summary>  
		[DataMember(Name="ColumnCount", EmitDefaultValue=false)]
        public int? ColumnCount { get; set; }

        /// <summary>
        /// Sets or gets the height of rows in this range
        /// </summary>  
		[DataMember(Name="RowHeight", EmitDefaultValue=false)]
        public double? RowHeight { get; set; }

        /// <summary>
        /// Gets or sets the name of the range.
        /// </summary>  
		[DataMember(Name="Name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets the index of the first column of the range.
        /// </summary>  
		[DataMember(Name="FirstColumn", EmitDefaultValue=false)]
        public int? FirstColumn { get; set; }

        /// <summary>
        /// Sets or gets the column width of this range
        /// </summary>  
		[DataMember(Name="ColumnWidth", EmitDefaultValue=false)]
        public double? ColumnWidth { get; set; }

        /// <summary>
        /// Gets the range's refers to.
        /// </summary>  
		[DataMember(Name="RefersTo", EmitDefaultValue=false)]
        public string RefersTo { get; set; }

        /// <summary>
        /// Gets the count of rows in the range.
        /// </summary>  
		[DataMember(Name="RowCount", EmitDefaultValue=false)]
        public int? RowCount { get; set; }

        /// <summary>
        /// Gets the index of the first row of the range.
        /// </summary>  
		[DataMember(Name="FirstRow", EmitDefaultValue=false)]
        public int? FirstRow { get; set; }

        /// <summary>
        /// Gets the Aspose.Cells.Range.Worksheetobject which contains this range.
        /// </summary>  
		[DataMember(Name="Worksheet", EmitDefaultValue=false)]
        public string Worksheet { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class Range {\n");
          sb.Append("  ColumnCount: ").Append(this.ColumnCount).Append("\n");
          sb.Append("  RowHeight: ").Append(this.RowHeight).Append("\n");
          sb.Append("  Name: ").Append(this.Name).Append("\n");
          sb.Append("  FirstColumn: ").Append(this.FirstColumn).Append("\n");
          sb.Append("  ColumnWidth: ").Append(this.ColumnWidth).Append("\n");
          sb.Append("  RefersTo: ").Append(this.RefersTo).Append("\n");
          sb.Append("  RowCount: ").Append(this.RowCount).Append("\n");
          sb.Append("  FirstRow: ").Append(this.FirstRow).Append("\n");
          sb.Append("  Worksheet: ").Append(this.Worksheet).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
