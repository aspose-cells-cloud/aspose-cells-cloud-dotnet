// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ListObject.cs">
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
  public class ListObject 
  {                       
        /// <summary>
        /// Gets or sets Link
        /// </summary>  
		[DataMember(Name="link", EmitDefaultValue=false)]
        public Link Link { get; set; }

        /// <summary>
        /// Gets and sets whether this ListObject show total row.
        /// </summary>  
		[DataMember(Name="ShowTotals", EmitDefaultValue=false)]
        public bool? ShowTotals { get; set; }

        /// <summary>
        /// Gets and the built-in table style.
        /// </summary>  
		[DataMember(Name="TableStyleType", EmitDefaultValue=false)]
        public string TableStyleType { get; set; }

        /// <summary>
        /// Gets and sets the display name.Gets the data range of the ListObject.
        /// </summary>  
		[DataMember(Name="DisplayName", EmitDefaultValue=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets and sets whether this ListObject show header row.             
        /// </summary>  
		[DataMember(Name="ShowHeaderRow", EmitDefaultValue=false)]
        public bool? ShowHeaderRow { get; set; }

        /// <summary>
        /// Gets the start column of the range.
        /// </summary>  
		[DataMember(Name="StartColumn", EmitDefaultValue=false)]
        public int? StartColumn { get; set; }

        /// <summary>
        /// Indicates whether the last column in the table should have the style applied.
        /// </summary>  
		[DataMember(Name="ShowTableStyleLastColumn", EmitDefaultValue=false)]
        public bool? ShowTableStyleLastColumn { get; set; }

        /// <summary>
        /// Indicates whether column stripe formatting is applied.
        /// </summary>  
		[DataMember(Name="ShowTableStyleColumnStripes", EmitDefaultValue=false)]
        public bool? ShowTableStyleColumnStripes { get; set; }

        /// <summary>
        /// Inidicates whether the first column in the table should have the style applied.
        /// </summary>  
		[DataMember(Name="ShowTableStyleFirstColumn", EmitDefaultValue=false)]
        public bool? ShowTableStyleFirstColumn { get; set; }

        /// <summary>
        /// Gets the start row of the range.
        /// </summary>  
		[DataMember(Name="StartRow", EmitDefaultValue=false)]
        public int? StartRow { get; set; }

        /// <summary>
        /// Gets auto filter.             
        /// </summary>  
		[DataMember(Name="AutoFilter", EmitDefaultValue=false)]
        public AutoFilter AutoFilter { get; set; }

        /// <summary>
        /// Indicates whether row stripe formatting is applied.
        /// </summary>  
		[DataMember(Name="ShowTableStyleRowStripes", EmitDefaultValue=false)]
        public bool? ShowTableStyleRowStripes { get; set; }

        /// <summary>
        /// Gets the end column of the range.
        /// </summary>  
		[DataMember(Name="EndColumn", EmitDefaultValue=false)]
        public int? EndColumn { get; set; }

        /// <summary>
        /// Gets and sets the table style name.
        /// </summary>  
		[DataMember(Name="TableStyleName", EmitDefaultValue=false)]
        public string TableStyleName { get; set; }

        /// <summary>
        /// Gets ListColumns of the ListObject.
        /// </summary>  
		[DataMember(Name="ListColumns", EmitDefaultValue=false)]
        public List<ListColumn> ListColumns { get; set; }

        /// <summary>
        /// Gets the end row of the range.
        /// </summary>  
		[DataMember(Name="EndRow", EmitDefaultValue=false)]
        public int? EndRow { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class ListObject {\n");
          sb.Append("  Link: ").Append(this.Link).Append("\n");
          sb.Append("  ShowTotals: ").Append(this.ShowTotals).Append("\n");
          sb.Append("  TableStyleType: ").Append(this.TableStyleType).Append("\n");
          sb.Append("  DisplayName: ").Append(this.DisplayName).Append("\n");
          sb.Append("  ShowHeaderRow: ").Append(this.ShowHeaderRow).Append("\n");
          sb.Append("  StartColumn: ").Append(this.StartColumn).Append("\n");
          sb.Append("  ShowTableStyleLastColumn: ").Append(this.ShowTableStyleLastColumn).Append("\n");
          sb.Append("  ShowTableStyleColumnStripes: ").Append(this.ShowTableStyleColumnStripes).Append("\n");
          sb.Append("  ShowTableStyleFirstColumn: ").Append(this.ShowTableStyleFirstColumn).Append("\n");
          sb.Append("  StartRow: ").Append(this.StartRow).Append("\n");
          sb.Append("  AutoFilter: ").Append(this.AutoFilter).Append("\n");
          sb.Append("  ShowTableStyleRowStripes: ").Append(this.ShowTableStyleRowStripes).Append("\n");
          sb.Append("  EndColumn: ").Append(this.EndColumn).Append("\n");
          sb.Append("  TableStyleName: ").Append(this.TableStyleName).Append("\n");
          sb.Append("  ListColumns: ").Append(this.ListColumns).Append("\n");
          sb.Append("  EndRow: ").Append(this.EndRow).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
