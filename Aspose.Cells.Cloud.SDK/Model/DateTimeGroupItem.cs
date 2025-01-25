// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="DateTimeGroupItem.cs">
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
    /// Represents the datetime's group setting.
    /// </summary>
    public class DateTimeGroupItem : MultipleFilter
    {
        /// <summary>
        /// Gets and sets the group type.
        /// </summary>
        public virtual string DateTimeGroupingType { get; set; }

        /// <summary>
        /// Gets and sets the day of the grouped date time.
        /// </summary>
        public virtual int? Day { get; set; }

        /// <summary>
        /// Gets and sets the hour of the grouped date time.
        /// </summary>
        public virtual int? Hour { get; set; }

        /// <summary>
        /// Gets and sets the minute of the grouped date time.
        /// </summary>
        public virtual int? Minute { get; set; }

        /// <summary>
        /// Gets and sets the month of the grouped date time.
        /// </summary>
        public virtual int? Month { get; set; }

        /// <summary>
        /// Gets and sets the second of the grouped date time.
        /// </summary>
        public virtual int? Second { get; set; }

        /// <summary>
        /// Gets and sets the year of the grouped date time.
        /// </summary>
        public virtual int? Year { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DateTimeGroupItem {\n");
            sb.Append("  DateTimeGroupingType: ").Append(this.DateTimeGroupingType).Append("\n");
            sb.Append("  Day: ").Append(this.Day).Append("\n");
            sb.Append("  Hour: ").Append(this.Hour).Append("\n");
            sb.Append("  Minute: ").Append(this.Minute).Append("\n");
            sb.Append("  Month: ").Append(this.Month).Append("\n");
            sb.Append("  Second: ").Append(this.Second).Append("\n");
            sb.Append("  Year: ").Append(this.Year).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
