// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="IconSet.cs">
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
    /// Describe the IconSet conditional formatting rule. This conditional formatting
    ///     rule applies icons to cells according to their values.
    /// </summary>
    public class IconSet
    {
        /// <summary>
        /// Get the from the collection
        ///  
        /// </summary>
        public virtual IList<ConditionalFormattingIcon> CfIcons { get; set; }

        /// <summary>
        /// Get the CFValueObjects instance.
        ///  
        /// </summary>
        public virtual IList<ConditionalFormattingValue> Cfvos { get; set; }

        /// <summary>
        /// Indicates whether the icon set is custom.
        ///             Default value is false.
        ///  
        /// </summary>
        public virtual bool? IsCustom { get; set; }

        /// <summary>
        /// Get or set the flag indicating whether to reverses the default order of the icons in this icon set.
        ///             Default value is false.
        ///  
        /// </summary>
        public virtual bool? Reverse { get; set; }

        /// <summary>
        /// Get or set the flag indicating whether to show the values of the cells on which this icon set is applied.
        ///             Default value is true.
        ///  
        /// </summary>
        public virtual bool? ShowValue { get; set; }

        /// <summary>
        /// Get or Set the icon set type to display.  Setting the type will auto check
        ///    if the current Cfvos's count is accord with the new type. If not accord,
        ///    old Cfvos will be cleaned and default Cfvos will be added.
        ///             
        /// </summary>
        public virtual string IconSetType { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IconSet {\n");
            sb.Append("  CfIcons: ").Append(this.CfIcons).Append("\n");
            sb.Append("  Cfvos: ").Append(this.Cfvos).Append("\n");
            sb.Append("  IsCustom: ").Append(this.IsCustom).Append("\n");
            sb.Append("  Reverse: ").Append(this.Reverse).Append("\n");
            sb.Append("  ShowValue: ").Append(this.ShowValue).Append("\n");
            sb.Append("  IconSetType: ").Append(this.IconSetType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
