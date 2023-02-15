// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="Cell.cs">
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
    /// Cell.
    /// </summary>
    public class Cell : LinkElement
    {
        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        public virtual string Name { get; set; }

        /// <summary>
        /// Gets or sets Row.
        /// </summary>
        public virtual int? Row { get; set; }

        /// <summary>
        /// Gets or sets Column.
        /// </summary>
        public virtual int? Column { get; set; }

        /// <summary>
        /// Gets or sets Value.
        /// </summary>
        public virtual string Value { get; set; }

        /// <summary>
        /// Gets or sets Type.
        /// </summary>
        public virtual string Type { get; set; }

        /// <summary>
        /// Gets or sets Formula.
        /// </summary>
        public virtual string Formula { get; set; }

        /// <summary>
        /// Gets or sets IsFormula.
        /// </summary>
        public virtual bool? IsFormula { get; set; }

        /// <summary>
        /// Gets or sets IsMerged.
        /// </summary>
        public virtual bool? IsMerged { get; set; }

        /// <summary>
        /// Gets or sets IsArrayHeader.
        /// </summary>
        public virtual bool? IsArrayHeader { get; set; }

        /// <summary>
        /// Gets or sets IsInArray.
        /// </summary>
        public virtual bool? IsInArray { get; set; }

        /// <summary>
        /// Gets or sets IsErrorValue.
        /// </summary>
        public virtual bool? IsErrorValue { get; set; }

        /// <summary>
        /// Gets or sets IsInTable.
        /// </summary>
        public virtual bool? IsInTable { get; set; }

        /// <summary>
        /// Gets or sets IsStyleSet.
        /// </summary>
        public virtual bool? IsStyleSet { get; set; }

        /// <summary>
        /// Gets or sets HtmlString.
        /// </summary>
        public virtual string HtmlString { get; set; }

        /// <summary>
        /// Gets or sets Style.
        /// </summary>
        public virtual LinkElement Style { get; set; }

        /// <summary>
        /// Gets or sets Worksheet.
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
