// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ChartOperateParameter.cs">
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
    /// 
    /// </summary>
    public class ChartOperateParameter : OperateParameter
    {
        /// <summary>
        /// 
        /// </summary>
        public virtual int? ChartIndex { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual string ChartType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual int? UpperLeftRow { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual int? UpperLeftColumn { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual int? LowerRightRow { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual int? LowerRightColumn { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual string Area { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual bool? IsVertical { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual string CategoryData { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual bool? IsAutoGetSerialName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual string Title { get; set; }

        /// <summary>
        /// Gets or sets OperateType.
        /// </summary>
        public override string OperateType { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChartOperateParameter {\n");
            sb.Append("  ChartIndex: ").Append(this.ChartIndex).Append("\n");
            sb.Append("  ChartType: ").Append(this.ChartType).Append("\n");
            sb.Append("  UpperLeftRow: ").Append(this.UpperLeftRow).Append("\n");
            sb.Append("  UpperLeftColumn: ").Append(this.UpperLeftColumn).Append("\n");
            sb.Append("  LowerRightRow: ").Append(this.LowerRightRow).Append("\n");
            sb.Append("  LowerRightColumn: ").Append(this.LowerRightColumn).Append("\n");
            sb.Append("  Area: ").Append(this.Area).Append("\n");
            sb.Append("  IsVertical: ").Append(this.IsVertical).Append("\n");
            sb.Append("  CategoryData: ").Append(this.CategoryData).Append("\n");
            sb.Append("  IsAutoGetSerialName: ").Append(this.IsAutoGetSerialName).Append("\n");
            sb.Append("  Title: ").Append(this.Title).Append("\n");
            sb.Append("  OperateType: ").Append(this.OperateType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
