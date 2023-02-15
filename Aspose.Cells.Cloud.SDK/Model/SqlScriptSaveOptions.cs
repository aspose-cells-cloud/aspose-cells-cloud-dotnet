// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="SqlScriptSaveOptions.cs">
//   Copyright (c) 2023 Aspose.Cells Cloud
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
    using System.Drawing;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// SqlScriptSaveOptions.
    /// </summary>
    public class SqlScriptSaveOptions : SaveOptions
    {
        /// <summary>
        /// Gets or sets CheckIfTableExists.
        /// </summary>
        public virtual bool? CheckIfTableExists { get; set; }

        /// <summary>
        /// Gets or sets ColumnTypeMap.
        /// </summary>
        public virtual string ColumnTypeMap { get; set; }

        /// <summary>
        /// Gets or sets CheckAllDataForColumnType.
        /// </summary>
        public virtual bool? CheckAllDataForColumnType { get; set; }

        /// <summary>
        /// Gets or sets AddBlankLineBetweenRows.
        /// </summary>
        public virtual bool? AddBlankLineBetweenRows { get; set; }

        /// <summary>
        /// Gets or sets Separator.
        /// </summary>
        public virtual string Separator { get; set; }

        /// <summary>
        /// Gets or sets OperatorType.
        /// </summary>
        public virtual string OperatorType { get; set; }

        /// <summary>
        /// Gets or sets PrimaryKey.
        /// </summary>
        public virtual int? PrimaryKey { get; set; }

        /// <summary>
        /// Gets or sets CreateTable.
        /// </summary>
        public virtual bool? CreateTable { get; set; }

        /// <summary>
        /// Gets or sets IdName.
        /// </summary>
        public virtual string IdName { get; set; }

        /// <summary>
        /// Gets or sets StartId.
        /// </summary>
        public virtual int? StartId { get; set; }

        /// <summary>
        /// Gets or sets TableName.
        /// </summary>
        public virtual string TableName { get; set; }

        /// <summary>
        /// Gets or sets ExportAsString.
        /// </summary>
        public virtual bool? ExportAsString { get; set; }

        /// <summary>
        /// Gets or sets ExportArea.
        /// </summary>
        public virtual CellArea ExportArea { get; set; }

        /// <summary>
        /// Gets or sets HasHeaderRow.
        /// </summary>
        public virtual bool? HasHeaderRow { get; set; }

        /// <summary>
        /// Gets or sets SaveFormat.
        /// </summary>
        public override string SaveFormat { get; set; }

        /// <summary>
        /// Gets or sets CachedFileFolder.
        /// </summary>
        public override string CachedFileFolder { get; set; }

        /// <summary>
        /// Gets or sets ClearData.
        /// </summary>
        public override bool? ClearData { get; set; }

        /// <summary>
        /// Gets or sets CreateDirectory.
        /// </summary>
        public override bool? CreateDirectory { get; set; }

        /// <summary>
        /// Gets or sets EnableHTTPCompression.
        /// </summary>
        public override bool? EnableHTTPCompression { get; set; }

        /// <summary>
        /// Gets or sets RefreshChartCache.
        /// </summary>
        public override bool? RefreshChartCache { get; set; }

        /// <summary>
        /// Gets or sets SortNames.
        /// </summary>
        public override bool? SortNames { get; set; }

        /// <summary>
        /// Gets or sets ValidateMergedAreas.
        /// </summary>
        public override bool? ValidateMergedAreas { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
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
            sb.Append("  SaveFormat: ").Append(this.SaveFormat).Append("\n");
            sb.Append("  CachedFileFolder: ").Append(this.CachedFileFolder).Append("\n");
            sb.Append("  ClearData: ").Append(this.ClearData).Append("\n");
            sb.Append("  CreateDirectory: ").Append(this.CreateDirectory).Append("\n");
            sb.Append("  EnableHTTPCompression: ").Append(this.EnableHTTPCompression).Append("\n");
            sb.Append("  RefreshChartCache: ").Append(this.RefreshChartCache).Append("\n");
            sb.Append("  SortNames: ").Append(this.SortNames).Append("\n");
            sb.Append("  ValidateMergedAreas: ").Append(this.ValidateMergedAreas).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
