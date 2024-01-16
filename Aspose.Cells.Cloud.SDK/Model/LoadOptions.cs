// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="LoadOptions.cs">
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
    public class LoadOptions
    {
        /// <summary>
        /// 
        /// </summary>
        public virtual string ConvertNumericData { get; set; }

        /// <summary>
        /// Gets and sets the interrupt monitor.
        /// </summary>
        public virtual string InterruptMonitor { get; set; }

        /// <summary>
        /// Gets or sets the user interface language of the Workbook version based on CountryCode that has saved the file.
        /// </summary>
        public virtual string LanguageCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual string LoadDataOptions { get; set; }

        /// <summary>
        /// Gets the load format.
        /// </summary>
        public virtual string LoadFormat { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual string OnlyLoadDocumentProperties { get; set; }

        /// <summary>
        /// Indicates whether parsing the formula when reading the file.
        /// </summary>
        public virtual string ParsingFormulaOnOpen { get; set; }

        /// <summary>
        /// Gets and set the password of the workbook.
        /// </summary>
        public virtual string Password { get; set; }

        /// <summary>
        /// Gets or sets the system regional settings based on CountryCode at the time the file was loaded.
        /// </summary>
        public virtual string Region { get; set; }

        /// <summary>
        /// Sets the default standard font name
        /// </summary>
        public virtual string StandardFont { get; set; }

        /// <summary>
        /// Sets the default standard font size.
        /// </summary>
        public virtual double? StandardFontSize { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LoadOptions {\n");
            sb.Append("  ConvertNumericData: ").Append(this.ConvertNumericData).Append("\n");
            sb.Append("  InterruptMonitor: ").Append(this.InterruptMonitor).Append("\n");
            sb.Append("  LanguageCode: ").Append(this.LanguageCode).Append("\n");
            sb.Append("  LoadDataOptions: ").Append(this.LoadDataOptions).Append("\n");
            sb.Append("  LoadFormat: ").Append(this.LoadFormat).Append("\n");
            sb.Append("  OnlyLoadDocumentProperties: ").Append(this.OnlyLoadDocumentProperties).Append("\n");
            sb.Append("  ParsingFormulaOnOpen: ").Append(this.ParsingFormulaOnOpen).Append("\n");
            sb.Append("  Password: ").Append(this.Password).Append("\n");
            sb.Append("  Region: ").Append(this.Region).Append("\n");
            sb.Append("  StandardFont: ").Append(this.StandardFont).Append("\n");
            sb.Append("  StandardFontSize: ").Append(this.StandardFontSize).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
