// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="Workbook.cs">
//   Copyright (c) 2016 Aspose.Cells for Cloud
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
  using Newtonsoft.Json;
  using Newtonsoft.Json.Converters;

  /// <summary>
  /// 
  /// </summary>  
  [DataContract]
  public class Workbook 
  {                       
        /// <summary>
        /// Gets or sets Links
        /// </summary>  
		[DataMember(Name="Links", EmitDefaultValue=false)]
        public List<Link> Links { get; set; }

        /// <summary>
        /// Gets or sets Settings
        /// </summary>  
		[DataMember(Name="Settings", EmitDefaultValue=false)]
        public LinkElement Settings { get; set; }

        /// <summary>
        /// Gets or sets IsProtected
        /// </summary>  
		[DataMember(Name="IsProtected", EmitDefaultValue=false)]
        public string IsProtected { get; set; }

        /// <summary>
        /// Gets or sets IsWriteProtected
        /// </summary>  
		[DataMember(Name="IsWriteProtected", EmitDefaultValue=false)]
        public string IsWriteProtected { get; set; }

        /// <summary>
        /// Gets or sets FileName
        /// </summary>  
		[DataMember(Name="FileName", EmitDefaultValue=false)]
        public string FileName { get; set; }

        /// <summary>
        /// Gets or sets DocumentProperties
        /// </summary>  
		[DataMember(Name="DocumentProperties", EmitDefaultValue=false)]
        public LinkElement DocumentProperties { get; set; }

        /// <summary>
        /// Gets or sets Names
        /// </summary>  
		[DataMember(Name="Names", EmitDefaultValue=false)]
        public LinkElement Names { get; set; }

        /// <summary>
        /// Gets or sets DefaultStyle
        /// </summary>  
		[DataMember(Name="DefaultStyle", EmitDefaultValue=false)]
        public LinkElement DefaultStyle { get; set; }

        /// <summary>
        /// Gets or sets IsEncryption
        /// </summary>  
		[DataMember(Name="IsEncryption", EmitDefaultValue=false)]
        public string IsEncryption { get; set; }

        /// <summary>
        /// Gets or sets Worksheets
        /// </summary>  
		[DataMember(Name="Worksheets", EmitDefaultValue=false)]
        public LinkElement Worksheets { get; set; }

        /// <summary>
        /// Gets or sets Password
        /// </summary>  
		[DataMember(Name="Password", EmitDefaultValue=false)]
        public string Password { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class Workbook {\n");
          sb.Append("  Links: ").Append(this.Links).Append("\n");
          sb.Append("  Settings: ").Append(this.Settings).Append("\n");
          sb.Append("  IsProtected: ").Append(this.IsProtected).Append("\n");
          sb.Append("  IsWriteProtected: ").Append(this.IsWriteProtected).Append("\n");
          sb.Append("  FileName: ").Append(this.FileName).Append("\n");
          sb.Append("  DocumentProperties: ").Append(this.DocumentProperties).Append("\n");
          sb.Append("  Names: ").Append(this.Names).Append("\n");
          sb.Append("  DefaultStyle: ").Append(this.DefaultStyle).Append("\n");
          sb.Append("  IsEncryption: ").Append(this.IsEncryption).Append("\n");
          sb.Append("  Worksheets: ").Append(this.Worksheets).Append("\n");
          sb.Append("  Password: ").Append(this.Password).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
