// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="Validation.cs">
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
    /// Validation.
    /// </summary>
    public class Validation : LinkElement
    {
        /// <summary>
        /// Gets or sets AlertStyle.
        /// </summary>
        public virtual string AlertStyle { get; set; }

        /// <summary>
        /// Gets or sets AreaList.
        /// </summary>
        public virtual IList<CellArea> AreaList { get; set; }

        /// <summary>
        /// Gets or sets ErrorMessage.
        /// </summary>
        public virtual string ErrorMessage { get; set; }

        /// <summary>
        /// Gets or sets ErrorTitle.
        /// </summary>
        public virtual string ErrorTitle { get; set; }

        /// <summary>
        /// Gets or sets Formula1.
        /// </summary>
        public virtual string Formula1 { get; set; }

        /// <summary>
        /// Gets or sets Formula2.
        /// </summary>
        public virtual string Formula2 { get; set; }

        /// <summary>
        /// Gets or sets IgnoreBlank.
        /// </summary>
        public virtual bool? IgnoreBlank { get; set; }

        /// <summary>
        /// Gets or sets InCellDropDown.
        /// </summary>
        public virtual bool? InCellDropDown { get; set; }

        /// <summary>
        /// Gets or sets InputMessage.
        /// </summary>
        public virtual string InputMessage { get; set; }

        /// <summary>
        /// Gets or sets InputTitle.
        /// </summary>
        public virtual string InputTitle { get; set; }

        /// <summary>
        /// Gets or sets Operator.
        /// </summary>
        public virtual string Operator { get; set; }

        /// <summary>
        /// Gets or sets ShowError.
        /// </summary>
        public virtual bool? ShowError { get; set; }

        /// <summary>
        /// Gets or sets ShowInput.
        /// </summary>
        public virtual bool? ShowInput { get; set; }

        /// <summary>
        /// Gets or sets Type.
        /// </summary>
        public virtual string Type { get; set; }

        /// <summary>
        /// Gets or sets Value1.
        /// </summary>
        public virtual string Value1 { get; set; }

        /// <summary>
        /// Gets or sets Value2.
        /// </summary>
        public virtual string Value2 { get; set; }

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
            sb.Append("class Validation {\n");
            sb.Append("  AlertStyle: ").Append(this.AlertStyle).Append("\n");
            sb.Append("  AreaList: ").Append(this.AreaList).Append("\n");
            sb.Append("  ErrorMessage: ").Append(this.ErrorMessage).Append("\n");
            sb.Append("  ErrorTitle: ").Append(this.ErrorTitle).Append("\n");
            sb.Append("  Formula1: ").Append(this.Formula1).Append("\n");
            sb.Append("  Formula2: ").Append(this.Formula2).Append("\n");
            sb.Append("  IgnoreBlank: ").Append(this.IgnoreBlank).Append("\n");
            sb.Append("  InCellDropDown: ").Append(this.InCellDropDown).Append("\n");
            sb.Append("  InputMessage: ").Append(this.InputMessage).Append("\n");
            sb.Append("  InputTitle: ").Append(this.InputTitle).Append("\n");
            sb.Append("  Operator: ").Append(this.Operator).Append("\n");
            sb.Append("  ShowError: ").Append(this.ShowError).Append("\n");
            sb.Append("  ShowInput: ").Append(this.ShowInput).Append("\n");
            sb.Append("  Type: ").Append(this.Type).Append("\n");
            sb.Append("  Value1: ").Append(this.Value1).Append("\n");
            sb.Append("  Value2: ").Append(this.Value2).Append("\n");
            sb.Append("  link: ").Append(this.link).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
