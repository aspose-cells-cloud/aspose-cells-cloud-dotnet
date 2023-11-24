// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="RangeSetOutlineBorderRequest.cs">
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
    /// Indicates range set outline border request.
    /// </summary>
    public class RangeSetOutlineBorderRequest
    {
        /// <summary>
        /// Encapsulates the object that represents a range of cells within a spreadsheet.
        /// </summary>
        public virtual Range Range { get; set; }

        /// <summary>
        /// LeftBorder, RightBorder, TopBorder, BottomBorder, DiagonalDown, DiagonalUp, Vertical and Horizontal.
        /// </summary>
        public virtual string borderEdge { get; set; }

        /// <summary>
        /// None, Thin, Medium, Dashed, Dotted, Thick, Double, Hair, MediumDashed, DashDot, MediumDashDot, DashDotDot, MediumDashDotDot and SlantedDashDot.
        /// </summary>
        public virtual string borderStyle { get; set; }

        /// <summary>
        /// Border color.
        /// </summary>
        public virtual Color borderColor { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RangeSetOutlineBorderRequest {\n");
            sb.Append("  Range: ").Append(this.Range).Append("\n");
            sb.Append("  borderEdge: ").Append(this.borderEdge).Append("\n");
            sb.Append("  borderStyle: ").Append(this.borderStyle).Append("\n");
            sb.Append("  borderColor: ").Append(this.borderColor).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
