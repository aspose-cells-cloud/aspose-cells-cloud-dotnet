// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="FormulaFormatCondition.cs">
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
    /// Class summary: This class covers various features related to data visualization and graphical representation of data sets.
    /// </summary>
    public class FormulaFormatCondition
    {
        /// <summary>
        /// Gets and sets the value or expression associated with conditional formatting.
        /// </summary>
        public virtual string Formula1 { get; set; }

        /// <summary>
        /// Gets and sets the value or expression associated with conditional formatting.
        /// </summary>
        public virtual string Formula2 { get; set; }

        /// <summary>
        /// Gets and sets the conditional format operator type.
        /// </summary>
        public virtual string Operator { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FormulaFormatCondition {\n");
            sb.Append("  Formula1: ").Append(this.Formula1).Append("\n");
            sb.Append("  Formula2: ").Append(this.Formula2).Append("\n");
            sb.Append("  Operator: ").Append(this.Operator).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
