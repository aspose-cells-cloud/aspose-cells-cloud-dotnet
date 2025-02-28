// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ConvertWorksheetOptions.cs">
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
    /// ConvertWorksheetOptions.
    /// </summary>
    public class ConvertWorksheetOptions : BaseOperateOptions
    {
        /// <summary>
        /// The class has a public property named "Name" with a getter and setter method.
        /// </summary>
        public override string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual DataSource DataSource { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual FileInfo FileInfo { get; set; }

        /// <summary>
        /// Gets or sets WorksheetName.
        /// </summary>
        public virtual string WorksheetName { get; set; }

        /// <summary>
        /// Gets or sets PageSetup.
        /// </summary>
        public virtual PageSetup PageSetup { get; set; }

        /// <summary>
        /// Gets or sets ImageOrPrintOptions.
        /// </summary>
        public virtual ImageOrPrintOptions ImageOrPrintOptions { get; set; }

        /// <summary>
        /// Gets or sets ConvertFormat.
        /// </summary>
        public virtual string ConvertFormat { get; set; }

        /// <summary>
        /// Gets or sets CheckExcelRestriction.
        /// </summary>
        public virtual bool? CheckExcelRestriction { get; set; }

        /// <summary>
        /// Gets or sets Region.
        /// </summary>
        public virtual string Region { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConvertWorksheetOptions {\n");
            sb.Append("  Name: ").Append(this.Name).Append("\n");
            sb.Append("  DataSource: ").Append(this.DataSource).Append("\n");
            sb.Append("  FileInfo: ").Append(this.FileInfo).Append("\n");
            sb.Append("  WorksheetName: ").Append(this.WorksheetName).Append("\n");
            sb.Append("  PageSetup: ").Append(this.PageSetup).Append("\n");
            sb.Append("  ImageOrPrintOptions: ").Append(this.ImageOrPrintOptions).Append("\n");
            sb.Append("  ConvertFormat: ").Append(this.ConvertFormat).Append("\n");
            sb.Append("  CheckExcelRestriction: ").Append(this.CheckExcelRestriction).Append("\n");
            sb.Append("  Region: ").Append(this.Region).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
