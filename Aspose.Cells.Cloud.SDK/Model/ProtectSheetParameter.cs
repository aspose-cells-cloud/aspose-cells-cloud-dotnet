// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ProtectSheetParameter.cs">
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
  public class ProtectSheetParameter 
  {                       
        /// <summary>
        /// Gets or sets AllowSelectingUnlockedCell
        /// </summary>  
		[DataMember(Name="AllowSelectingUnlockedCell", EmitDefaultValue=false)]
        public string AllowSelectingUnlockedCell { get; set; }

        /// <summary>
        /// Gets or sets AllowFiltering
        /// </summary>  
		[DataMember(Name="AllowFiltering", EmitDefaultValue=false)]
        public string AllowFiltering { get; set; }

        /// <summary>
        /// Gets or sets AllowDeletingColumn
        /// </summary>  
		[DataMember(Name="AllowDeletingColumn", EmitDefaultValue=false)]
        public string AllowDeletingColumn { get; set; }

        /// <summary>
        /// Gets or sets AllowSelectingLockedCell
        /// </summary>  
		[DataMember(Name="AllowSelectingLockedCell", EmitDefaultValue=false)]
        public string AllowSelectingLockedCell { get; set; }

        /// <summary>
        /// Gets or sets AllowUsingPivotTable
        /// </summary>  
		[DataMember(Name="AllowUsingPivotTable", EmitDefaultValue=false)]
        public string AllowUsingPivotTable { get; set; }

        /// <summary>
        /// Gets or sets AllowEditArea
        /// </summary>  
		[DataMember(Name="AllowEditArea", EmitDefaultValue=false)]
        public List<string> AllowEditArea { get; set; }

        /// <summary>
        /// Gets or sets AllowInsertingHyperlink
        /// </summary>  
		[DataMember(Name="AllowInsertingHyperlink", EmitDefaultValue=false)]
        public string AllowInsertingHyperlink { get; set; }

        /// <summary>
        /// Gets or sets AllowFormattingCell
        /// </summary>  
		[DataMember(Name="AllowFormattingCell", EmitDefaultValue=false)]
        public string AllowFormattingCell { get; set; }

        /// <summary>
        /// Gets or sets AllowFormattingRow
        /// </summary>  
		[DataMember(Name="AllowFormattingRow", EmitDefaultValue=false)]
        public string AllowFormattingRow { get; set; }

        /// <summary>
        /// Gets or sets AllowInsertingRow
        /// </summary>  
		[DataMember(Name="AllowInsertingRow", EmitDefaultValue=false)]
        public string AllowInsertingRow { get; set; }

        /// <summary>
        /// Gets or sets AllowFormattingColumn
        /// </summary>  
		[DataMember(Name="AllowFormattingColumn", EmitDefaultValue=false)]
        public string AllowFormattingColumn { get; set; }

        /// <summary>
        /// Gets or sets AllowSorting
        /// </summary>  
		[DataMember(Name="AllowSorting", EmitDefaultValue=false)]
        public string AllowSorting { get; set; }

        /// <summary>
        /// Gets or sets AllowInsertingColumn
        /// </summary>  
		[DataMember(Name="AllowInsertingColumn", EmitDefaultValue=false)]
        public string AllowInsertingColumn { get; set; }

        /// <summary>
        /// Gets or sets Password
        /// </summary>  
		[DataMember(Name="Password", EmitDefaultValue=false)]
        public string Password { get; set; }

        /// <summary>
        /// Gets or sets AllowDeletingRow
        /// </summary>  
		[DataMember(Name="AllowDeletingRow", EmitDefaultValue=false)]
        public string AllowDeletingRow { get; set; }

        /// <summary>
        /// Gets or sets ProtectionType
        /// </summary>  
		[DataMember(Name="ProtectionType", EmitDefaultValue=false)]
        public string ProtectionType { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class ProtectSheetParameter {\n");
          sb.Append("  AllowSelectingUnlockedCell: ").Append(this.AllowSelectingUnlockedCell).Append("\n");
          sb.Append("  AllowFiltering: ").Append(this.AllowFiltering).Append("\n");
          sb.Append("  AllowDeletingColumn: ").Append(this.AllowDeletingColumn).Append("\n");
          sb.Append("  AllowSelectingLockedCell: ").Append(this.AllowSelectingLockedCell).Append("\n");
          sb.Append("  AllowUsingPivotTable: ").Append(this.AllowUsingPivotTable).Append("\n");
          sb.Append("  AllowEditArea: ").Append(this.AllowEditArea).Append("\n");
          sb.Append("  AllowInsertingHyperlink: ").Append(this.AllowInsertingHyperlink).Append("\n");
          sb.Append("  AllowFormattingCell: ").Append(this.AllowFormattingCell).Append("\n");
          sb.Append("  AllowFormattingRow: ").Append(this.AllowFormattingRow).Append("\n");
          sb.Append("  AllowInsertingRow: ").Append(this.AllowInsertingRow).Append("\n");
          sb.Append("  AllowFormattingColumn: ").Append(this.AllowFormattingColumn).Append("\n");
          sb.Append("  AllowSorting: ").Append(this.AllowSorting).Append("\n");
          sb.Append("  AllowInsertingColumn: ").Append(this.AllowInsertingColumn).Append("\n");
          sb.Append("  Password: ").Append(this.Password).Append("\n");
          sb.Append("  AllowDeletingRow: ").Append(this.AllowDeletingRow).Append("\n");
          sb.Append("  ProtectionType: ").Append(this.ProtectionType).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
