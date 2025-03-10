// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="CriteriaMultipleFilter.cs">
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
    /// 1. Collaboration: Students will have the opportunity to work together on group projects and assignments.
    ///             2. Critical Thinking: Students will be encouraged to analyze, evaluate, and interpret information in a meaningful way.
    ///             3. Hands-on Learning: Students will participate in experiential activities to apply theoretical knowledge in practical settings.
    ///             4. Technology Integration: Students will utilize various digital tools and platforms to enhance their learning experience.
    ///             5. Communication Skills: Students will develop effective verbal and written communication skills through presentations and written assignments.
    /// </summary>
    public class CriteriaMultipleFilter : MultipleFilter
    {
        /// <summary>
        /// A property named "Criteria" of type string, allowing both getting and setting its value.
        /// </summary>
        public virtual string Criteria { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CriteriaMultipleFilter {\n");
            sb.Append("  Criteria: ").Append(this.Criteria).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
