// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="FormulaSettings.cs">
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
    /// Settings of formulas and calculation.
    ///  
    /// </summary>
    public class FormulaSettings
    {
        /// <summary>
        /// Indicates whether the application is required to perform a full calculation when the workbook is opened.
        ///  
        /// </summary>
        public virtual bool? CalculateOnOpen { get; set; }

        /// <summary>
        /// Indicates whether recalculate the workbook before saving the document, when in manual calculation mode.
        ///  
        /// </summary>
        public virtual bool? CalculateOnSave { get; set; }

        /// <summary>
        /// Indicates whether calculates all formulas every time when a calculation is triggered.
        ///  
        /// </summary>
        public virtual bool? ForceFullCalculation { get; set; }

        /// <summary>
        /// Gets or sets the mode for workbook calculation in ms excel.
        ///  
        /// </summary>
        public virtual string CalculationMode { get; set; }

        /// <summary>
        /// Specifies the version of the calculation engine used to calculate values in the workbook.
        ///  
        /// </summary>
        public virtual string CalculationId { get; set; }

        /// <summary>
        /// Indicates whether enable iterative calculation to resolve circular references.
        ///  
        /// </summary>
        public virtual bool? EnableIterativeCalculation { get; set; }

        /// <summary>
        /// The maximum iterations to resolve a circular reference.
        ///  
        /// </summary>
        public virtual int? MaxIteration { get; set; }

        /// <summary>
        /// The maximum change to resolve a circular reference.
        ///  
        /// </summary>
        public virtual double? MaxChange { get; set; }

        /// <summary>
        /// Whether the precision of calculated result be set as they are displayed while calculating formulas
        ///  
        /// </summary>
        public virtual bool? PrecisionAsDisplayed { get; set; }

        /// <summary>
        /// Whether enable calculation chain for formulas. Default is false.
        ///  
        /// </summary>
        public virtual bool? EnableCalculationChain { get; set; }

        /// <summary>
        /// Indicates whether preserve those spaces and line breaks that are padded between formula tokens
        ///             while getting and setting formulas.
        ///             Default value is false.
        ///  
        /// </summary>
        public virtual bool? PreservePaddingSpaces { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FormulaSettings {\n");
            sb.Append("  CalculateOnOpen: ").Append(this.CalculateOnOpen).Append("\n");
            sb.Append("  CalculateOnSave: ").Append(this.CalculateOnSave).Append("\n");
            sb.Append("  ForceFullCalculation: ").Append(this.ForceFullCalculation).Append("\n");
            sb.Append("  CalculationMode: ").Append(this.CalculationMode).Append("\n");
            sb.Append("  CalculationId: ").Append(this.CalculationId).Append("\n");
            sb.Append("  EnableIterativeCalculation: ").Append(this.EnableIterativeCalculation).Append("\n");
            sb.Append("  MaxIteration: ").Append(this.MaxIteration).Append("\n");
            sb.Append("  MaxChange: ").Append(this.MaxChange).Append("\n");
            sb.Append("  PrecisionAsDisplayed: ").Append(this.PrecisionAsDisplayed).Append("\n");
            sb.Append("  EnableCalculationChain: ").Append(this.EnableCalculationChain).Append("\n");
            sb.Append("  PreservePaddingSpaces: ").Append(this.PreservePaddingSpaces).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
