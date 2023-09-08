// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="AbstractCalculationEngine.cs">
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
    /// Represents user's custom calculation engine to extend the default calculation engine of Aspose.Cells.
    ///  
    /// </summary>
    public class AbstractCalculationEngine
    {
        /// <summary>
        /// Indicates whether this engine needs the literal text of parameter while doing calculation. Default value is false.
        ///  
        /// </summary>
        public virtual bool? IsParamLiteralRequired { get; set; }

        /// <summary>
        /// Indicates whether this engine needs the parameter to be calculated in array mode. Default value is false.            If  is required when calculating custom            functions, this property needs to be set as true.
        ///  
        /// </summary>
        public virtual bool? IsParamArrayModeRequired { get; set; }

        /// <summary>
        /// Whether built-in functions that have been supported by the built-in engine            should be checked and processed by this implementation.            Default is false.            If user needs to change the calculation logic of some built-in functions, this property should be set as true.            Otherwise please leave this property as false for performance consideration.
        ///  
        /// </summary>
        public virtual bool? ProcessBuiltInFunctions { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AbstractCalculationEngine {\n");
            sb.Append("  IsParamLiteralRequired: ").Append(this.IsParamLiteralRequired).Append("\n");
            sb.Append("  IsParamArrayModeRequired: ").Append(this.IsParamArrayModeRequired).Append("\n");
            sb.Append("  ProcessBuiltInFunctions: ").Append(this.ProcessBuiltInFunctions).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
