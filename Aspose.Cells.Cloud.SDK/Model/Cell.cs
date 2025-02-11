// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="Cell.cs">
//   Copyright (c) 2025 Aspose.Cells Cloud
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
    /// Encapsulates the object that represents a single Workbook cell.
    /// </summary>
    public class Cell : LinkElement
    {
        /// <summary>
        /// Gets the name of the cell.
        /// </summary>
        public virtual string Name { get; set; }

        /// <summary>
        /// Gets row number (zero based) of the cell.
        /// </summary>
        public virtual int? Row { get; set; }

        /// <summary>
        /// Gets column number (zero based) of the cell.
        /// </summary>
        public virtual int? Column { get; set; }

        /// <summary>
        /// Gets the value contained in this cell.
        /// </summary>
        public virtual string Value { get; set; }

        /// <summary>
        /// Represents cell value type.
        /// </summary>
        public virtual string Type { get; set; }

        /// <summary>
        /// Gets or sets a formula of the .
        /// </summary>
        public virtual string Formula { get; set; }

        /// <summary>
        /// Represents if the specified cell contains formula.
        /// </summary>
        public virtual bool? IsFormula { get; set; }

        /// <summary>
        /// Checks if a cell is part of a merged range or not.
        /// </summary>
        public virtual bool? IsMerged { get; set; }

        /// <summary>
        /// Indicates the cell's formula is and array formula 
        ///                         and it is the first cell of the array.
        /// </summary>
        public virtual bool? IsArrayHeader { get; set; }

        /// <summary>
        /// Indicates whether the cell formula is an array formula.
        /// </summary>
        public virtual bool? IsInArray { get; set; }

        /// <summary>
        /// Checks if the value of this cell is an error.
        /// </summary>
        public virtual bool? IsErrorValue { get; set; }

        /// <summary>
        /// Indicates whether this cell is part of table formula.
        /// </summary>
        public virtual bool? IsInTable { get; set; }

        /// <summary>
        /// Indicates if the cell's style is set. If return false, it means this cell has a default cell format.
        /// </summary>
        public virtual bool? IsStyleSet { get; set; }

        /// <summary>
        /// Gets and sets the html string which contains data and some formats in this cell.
        /// </summary>
        public virtual string HtmlString { get; set; }

        /// <summary>
        /// This class property represents a style element with the specified XML element name.
        /// </summary>
        public virtual LinkElement Style { get; set; }

        /// <summary>
        /// Gets the parent worksheet.
        /// </summary>
        public virtual string Worksheet { get; set; }

        /// <summary>
        /// Gets or sets link.
        /// </summary>
        public override Link link { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Cell {\n");
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
            sb.Append("  link: ").Append(this.link).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
