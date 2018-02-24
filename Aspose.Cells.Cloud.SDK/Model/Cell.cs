// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="Cell.cs">
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
  /// Encapsulates the object that represents a single Workbook cell.
  /// </summary>  
  [DataContract]
  public class Cell 
  {                       
        /// <summary>
        /// Gets or sets Link
        /// </summary>  
		[DataMember(Name="link", EmitDefaultValue=false)]
        public Link Link { get; set; }

        /// <summary>
        /// Gets the name of the cell.             
        /// </summary>  
		[DataMember(Name="Name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets row number (zero based) of the cell.             
        /// </summary>  
		[DataMember(Name="Row", EmitDefaultValue=false)]
        public int? Row { get; set; }

        /// <summary>
        /// Gets column number (zero based) of the cell.             
        /// </summary>  
		[DataMember(Name="Column", EmitDefaultValue=false)]
        public int? Column { get; set; }

        /// <summary>
        /// Gets or sets Value
        /// </summary>  
		[DataMember(Name="Value", EmitDefaultValue=false)]
        public string Value { get; set; }

        /// <summary>
        /// Specifies a cell value type.
        /// </summary>  
		[DataMember(Name="Type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets a formula of the Aspose.Cells.Cell.
        /// </summary>  
		[DataMember(Name="Formula", EmitDefaultValue=false)]
        public string Formula { get; set; }

        /// <summary>
        /// Represents if the specified cell contains formula.             
        /// </summary>  
		[DataMember(Name="IsFormula", EmitDefaultValue=false)]
        public bool? IsFormula { get; set; }

        /// <summary>
        /// Checks if a cell is part of a merged range or not.             
        /// </summary>  
		[DataMember(Name="IsMerged", EmitDefaultValue=false)]
        public bool? IsMerged { get; set; }

        /// <summary>
        /// Inidicates the cell's formula is and array formula and it is the first cell of the array.
        /// </summary>  
		[DataMember(Name="IsArrayHeader", EmitDefaultValue=false)]
        public bool? IsArrayHeader { get; set; }

        /// <summary>
        /// Indicates whether the cell formula is an array formula.
        /// </summary>  
		[DataMember(Name="IsInArray", EmitDefaultValue=false)]
        public bool? IsInArray { get; set; }

        /// <summary>
        /// Checks if a formula can properly evaluate a result.             
        /// </summary>  
		[DataMember(Name="IsErrorValue", EmitDefaultValue=false)]
        public bool? IsErrorValue { get; set; }

        /// <summary>
        /// Indicates whethe this cell is part of table formula.             
        /// </summary>  
		[DataMember(Name="IsInTable", EmitDefaultValue=false)]
        public bool? IsInTable { get; set; }

        /// <summary>
        /// Indicates if the cell's style is set. If return false, it means this cell has a default cell format.             
        /// </summary>  
		[DataMember(Name="IsStyleSet", EmitDefaultValue=false)]
        public bool? IsStyleSet { get; set; }

        /// <summary>
        /// Gets and sets the html string which contains data and some formattings in this cell.             
        /// </summary>  
		[DataMember(Name="HtmlString", EmitDefaultValue=false)]
        public string HtmlString { get; set; }

        /// <summary>
        /// Gets or sets Style
        /// </summary>  
		[DataMember(Name="Style", EmitDefaultValue=false)]
        public LinkElement Style { get; set; }

        /// <summary>
        /// Gets the parent worksheet.
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
          sb.Append("class Cell {\n");
          sb.Append("  Link: ").Append(this.Link).Append("\n");
          sb.Append("  Name: ").Append(this.Name).Append("\n");
          sb.Append("  Row: ").Append(this.Row).Append("\n");
          sb.Append("  Column: ").Append(this.Column).Append("\n");
          sb.Append("  Value: ").Append(this.Value).Append("\n");
          sb.Append("  Type: ").Append(this.Type).Append("\n");
          sb.Append("  Formula: ").Append(this.Formula).Append("\n");
          sb.Append("  IsFormula: ").Append(this.IsFormula).Append("\n");
          sb.Append("  IsMerged: ").Append(this.IsMerged).Append("\n");
          sb.Append("  IsArrayHeader: ").Append(this.IsArrayHeader).Append("\n");
          sb.Append("  IsInArray: ").Append(this.IsInArray).Append("\n");
          sb.Append("  IsErrorValue: ").Append(this.IsErrorValue).Append("\n");
          sb.Append("  IsInTable: ").Append(this.IsInTable).Append("\n");
          sb.Append("  IsStyleSet: ").Append(this.IsStyleSet).Append("\n");
          sb.Append("  HtmlString: ").Append(this.HtmlString).Append("\n");
          sb.Append("  Style: ").Append(this.Style).Append("\n");
          sb.Append("  Worksheet: ").Append(this.Worksheet).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
