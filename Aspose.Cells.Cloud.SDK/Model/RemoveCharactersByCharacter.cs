// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="RemoveCharactersByCharacter.cs">
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
    /// Class summary: The features include fast and reliable performance, high-quality camera with portrait mode, long-lasting battery life, and a durable water-resistant design.
    ///             
    /// </summary>
    public class RemoveCharactersByCharacter
    {
        /// <summary>
        /// Property: "RemoveTextMethod" is serialized using a string representation of the enum value.
        /// </summary>
        public virtual string RemoveTextMethod { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual IList<string> RemoveCharacters { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual string RemoveCharacterSetsType { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RemoveCharactersByCharacter {\n");
            sb.Append("  RemoveTextMethod: ").Append(this.RemoveTextMethod).Append("\n");
            sb.Append("  RemoveCharacters: ").Append(this.RemoveCharacters).Append("\n");
            sb.Append("  RemoveCharacterSetsType: ").Append(this.RemoveCharacterSetsType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
