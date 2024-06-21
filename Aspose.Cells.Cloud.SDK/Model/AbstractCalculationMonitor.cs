// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="AbstractCalculationMonitor.cs">
//   Copyright (c) 2024 Aspose.Cells Cloud
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
    /// Monitor for user to track the progress of formula calculation.
    ///  
    /// </summary>
    public class AbstractCalculationMonitor
    {
        /// <summary>
        /// Gets the old value of the calculated cell. Should be used only in  and .
        ///  
        /// </summary>
        public virtual Object OriginalValue { get; set; }

        /// <summary>
        /// Whether the cell's value has been changed after the calculation.  Should be used only in .       
        ///  
        /// </summary>
        public virtual bool? ValueChanged { get; set; }

        /// <summary>
        /// Gets the newly calculated value of the cell. Should be used only in .       
        ///  
        /// </summary>
        public virtual Object CalculatedValue { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AbstractCalculationMonitor {\n");
            sb.Append("  OriginalValue: ").Append(this.OriginalValue).Append("\n");
            sb.Append("  ValueChanged: ").Append(this.ValueChanged).Append("\n");
            sb.Append("  CalculatedValue: ").Append(this.CalculatedValue).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
