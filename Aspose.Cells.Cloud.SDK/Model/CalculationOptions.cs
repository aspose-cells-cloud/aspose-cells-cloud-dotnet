// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="CalculationOptions.cs">
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
    /// 
    /// </summary>
    public class CalculationOptions
    {
        /// <summary>
        /// Specifies the stack size for calculating cells recursively.
        ///  
        /// </summary>
        public virtual int? CalcStackSize { get; set; }

        /// <summary>
        /// Indicates whether errors encountered while calculating formulas should be ignored.
        ///             The error may be unsupported function, external links, etc.
        ///             The default value is true.
        ///  
        /// </summary>
        public virtual bool? IgnoreError { get; set; }

        /// <summary>
        /// Specifies the strategy for processing precision of calculation.
        ///  
        /// </summary>
        public virtual string PrecisionStrategy { get; set; }

        /// <summary>
        /// Indicates whether calculate the dependent cells recursively when calculating one cell and it depends on other cells.
        ///             The default value is true.
        ///  
        /// </summary>
        public virtual bool? Recursive { get; set; }

        /// <summary>
        /// The custom formula calculation engine to extend the default calculation engine of Aspose.Cells.
        ///  
        /// </summary>
        public virtual AbstractCalculationEngine CustomEngine { get; set; }

        /// <summary>
        /// The monitor for user to track the progress of formula calculation.
        ///  
        /// </summary>
        public virtual AbstractCalculationMonitor CalculationMonitor { get; set; }

        /// <summary>
        /// Specifies the data sources for external links used in formulas.
        ///  
        /// </summary>
        public virtual List<Workbook> LinkedDataSources { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CalculationOptions {\n");
            sb.Append("  CalcStackSize: ").Append(this.CalcStackSize).Append("\n");
            sb.Append("  IgnoreError: ").Append(this.IgnoreError).Append("\n");
            sb.Append("  PrecisionStrategy: ").Append(this.PrecisionStrategy).Append("\n");
            sb.Append("  Recursive: ").Append(this.Recursive).Append("\n");
            sb.Append("  CustomEngine: ").Append(this.CustomEngine).Append("\n");
            sb.Append("  CalculationMonitor: ").Append(this.CalculationMonitor).Append("\n");
            sb.Append("  LinkedDataSources: ").Append(this.LinkedDataSources).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
