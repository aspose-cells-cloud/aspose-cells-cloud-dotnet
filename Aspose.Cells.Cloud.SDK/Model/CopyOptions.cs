// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="CopyOptions.cs">
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
    /// CopyOptions.
    /// </summary>
    public class CopyOptions
    {
        /// <summary>
        /// Gets or sets ColumnCharacterWidth.
        /// </summary>
        public virtual bool? ColumnCharacterWidth { get; set; }

        /// <summary>
        /// Gets or sets CopyInvalidFormulasAsValues.
        /// </summary>
        public virtual bool? CopyInvalidFormulasAsValues { get; set; }

        /// <summary>
        /// Gets or sets CopyNames.
        /// </summary>
        public virtual bool? CopyNames { get; set; }

        /// <summary>
        /// Gets or sets ExtendToAdjacentRange.
        /// </summary>
        public virtual bool? ExtendToAdjacentRange { get; set; }

        /// <summary>
        /// Gets or sets ReferToDestinationSheet.
        /// </summary>
        public virtual bool? ReferToDestinationSheet { get; set; }

        /// <summary>
        /// Gets or sets ReferToSheetWithSameName.
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
