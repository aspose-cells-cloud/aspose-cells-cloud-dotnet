// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ImageSaveOptions.cs">
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
  public class SqlScriptSaveOptions : SaveOptions 
  {                       
        /// <summary>
        /// Gets or sets CheckIfTableExists
        /// </summary>  
		[DataMember(Name="CheckIfTableExists", EmitDefaultValue=false)]
        public bool? CheckIfTableExists { get; set; }

        /// <summary>
        /// Gets or sets ColumnTypeMap
        /// </summary>  
		[DataMember(Name="ColumnTypeMap", EmitDefaultValue=false)]
        public string ColumnTypeMap { get; set; }

        /// <summary>
        /// Gets or sets CheckAllDataForColumnType
        /// </summary>  
		[DataMember(Name="CheckAllDataForColumnType", EmitDefaultValue=false)]
        public bool? CheckAllDataForColumnType { get; set; }

        /// <summary>
        /// Gets or sets AddBlankLineBetweenRows
        /// </summary>  
		[DataMember(Name="AddBlankLineBetweenRows", EmitDefaultValue=false)]
        public bool? AddBlankLineBetweenRows { get; set; }

        /// <summary>
        /// Gets or sets Separator
        /// </summary>  
		[DataMember(Name="Separator", EmitDefaultValue=false)]
        public char? Separator { get; set; }

        /// <summary>
        /// Gets or sets OperatorType
        /// </summary>  
		[DataMember(Name="OperatorType", EmitDefaultValue=false)]
        public string OperatorType { get; set; }

        /// <summary>
        /// Gets or sets PrimaryKey
        /// </summary>  
		[DataMember(Name="PrimaryKey", EmitDefaultValue=false)]
        public int? PrimaryKey { get; set; }

        /// <summary>
        /// Gets or sets CreateTable
        /// </summary>  
		[DataMember(Name="CreateTable", EmitDefaultValue=false)]
        public bool? CreateTable { get; set; }

        /// <summary>
        /// Gets or sets IdName
        /// </summary>  
		[DataMember(Name="IdName", EmitDefaultValue=false)]
        public string IdName { get; set; }

        /// <summary>
        /// Gets or sets StartId
        /// </summary>  
		[DataMember(Name="StartId", EmitDefaultValue=false)]
        public int? StartId { get; set; }

        /// <summary>
        /// Gets or sets TableName
        /// </summary>  
		[DataMember(Name="TableName", EmitDefaultValue=false)]
        public string TableName { get; set; }

        /// <summary>
        /// Gets or sets ExportAsString
        /// </summary>  
		[DataMember(Name="ExportAsString", EmitDefaultValue=false)]
        public int? ExportAsString { get; set; }
        /// <summary>
        /// Gets or sets ExportArea
        /// </summary>
        [DataMember(Name = "ExportArea", EmitDefaultValue = false)]
        public CellArea ExportArea { get; set; }
        /// <summary>
        /// Gets or sets HasHeaderRow
        /// </summary>
        [DataMember(Name = "HasHeaderRow", EmitDefaultValue = false)] 
        public bool? HasHeaderRow { get; set; }
        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class SqlScriptSaveOptions {\n");
          sb.Append("  CheckIfTableExists: ").Append(this.CheckIfTableExists).Append("\n");
          sb.Append("  ColumnTypeMap: ").Append(this.ColumnTypeMap).Append("\n");
          sb.Append("  CheckAllDataForColumnType: ").Append(this.CheckAllDataForColumnType).Append("\n");
          sb.Append("  AddBlankLineBetweenRows: ").Append(this.AddBlankLineBetweenRows).Append("\n");
          sb.Append("  Separator: ").Append(this.Separator).Append("\n");
          sb.Append("  OperatorType: ").Append(this.OperatorType).Append("\n");
          sb.Append("  PrimaryKey: ").Append(this.PrimaryKey).Append("\n");
          sb.Append("  CreateTable: ").Append(this.CreateTable).Append("\n");
          sb.Append("  IdName: ").Append(this.IdName).Append("\n");
          sb.Append("  StartId: ").Append(this.StartId).Append("\n");
          sb.Append("  TableName: ").Append(this.TableName).Append("\n");
          sb.Append("  ExportAsString: ").Append(this.ExportAsString).Append("\n");
          sb.Append("  ExportArea: ").Append(this.ExportArea).Append("\n");
          sb.Append("  HasHeaderRow: ").Append(this.HasHeaderRow).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
