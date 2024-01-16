// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="CopyOptions.cs">
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
    /// Represents the copy options.
    /// </summary>
    public class CopyOptions
    {
        /// <summary>
        /// Indicates whether copying column width in unit of characters.
        ///  
        /// </summary>
        public virtual bool? ColumnCharacterWidth { get; set; }

        /// <summary>
        /// If the formula is not valid for the dest destination, only copy values.
        ///  
        /// </summary>
        public virtual bool? CopyInvalidFormulasAsValues { get; set; }

        /// <summary>
        /// Indicates whether copying the names.
        ///  
        /// </summary>
        public virtual bool? CopyNames { get; set; }

        /// <summary>
        /// Indicates whether extend ranges when copying the range to adjacent range.
        ///  
        /// </summary>
        public virtual bool? ExtendToAdjacentRange { get; set; }

        /// <summary>
        /// When copying the range in the same file and the chart refers to the source sheet,
        ///             False means the copied chart's data source will not be changed.
        ///             True means the copied chart's data source refers to the destination sheet.
        ///  
        /// </summary>
        public virtual bool? ReferToDestinationSheet { get; set; }

        /// <summary>
        /// In ms excel, when copying formulas which refer to other worksheets while copying a worksheet to another one,
        ///             the copied formulas should refer to source workbook.
        ///             However, for some situations user may need the copied formulas refer to worksheets with the same name
        ///             in the same workbook, such as when those worksheets have been copied before this copy operation,
        ///             then this property should be kept as true.
        ///  
        /// </summary>
        public virtual bool? ReferToSheetWithSameName { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CopyOptions {\n");
            sb.Append("  ColumnCharacterWidth: ").Append(this.ColumnCharacterWidth).Append("\n");
            sb.Append("  CopyInvalidFormulasAsValues: ").Append(this.CopyInvalidFormulasAsValues).Append("\n");
            sb.Append("  CopyNames: ").Append(this.CopyNames).Append("\n");
            sb.Append("  ExtendToAdjacentRange: ").Append(this.ExtendToAdjacentRange).Append("\n");
            sb.Append("  ReferToDestinationSheet: ").Append(this.ReferToDestinationSheet).Append("\n");
            sb.Append("  ReferToSheetWithSameName: ").Append(this.ReferToSheetWithSameName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
