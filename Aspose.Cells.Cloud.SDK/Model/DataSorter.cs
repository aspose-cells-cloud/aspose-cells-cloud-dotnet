// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="DataSorter.cs">
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
    /// Summary description for DataSorter.
    /// </summary>
    public class DataSorter
    {
        /// <summary>
        /// Gets and sets whether case sensitive when comparing string.
        ///  
        /// </summary>
        public virtual bool? CaseSensitive { get; set; }

        /// <summary>
        /// Represents whether the range has headers.
        ///  
        /// </summary>
        public virtual bool? HasHeaders { get; set; }

        /// <summary>
        /// Gets the key list of data sorter.
        ///             
        /// </summary>
        public virtual IList<SortKey> KeyList { get; set; }

        /// <summary>
        /// True means that sorting orientation is from left to right.
        ///             False means that sorting orientation is from top to bottom.
        ///             The default value is false.
        ///  
        /// </summary>
        public virtual bool? SortLeftToRight { get; set; }

        /// <summary>
        /// Indicates whether sorting anything that looks like a number.
        ///  
        /// </summary>
        public virtual bool? SortAsNumber { get; set; }

        /// <summary>
        /// Gets the key list of data sorter.
        ///  
        /// </summary>
        public virtual IList<DataSorterKey> Keys { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DataSorter {\n");
            sb.Append("  CaseSensitive: ").Append(this.CaseSensitive).Append("\n");
            sb.Append("  HasHeaders: ").Append(this.HasHeaders).Append("\n");
            sb.Append("  KeyList: ").Append(this.KeyList).Append("\n");
            sb.Append("  SortLeftToRight: ").Append(this.SortLeftToRight).Append("\n");
            sb.Append("  SortAsNumber: ").Append(this.SortAsNumber).Append("\n");
            sb.Append("  Keys: ").Append(this.Keys).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
