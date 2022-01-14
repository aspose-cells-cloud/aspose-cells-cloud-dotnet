// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="CellsDocumentProperty.cs">
//   Copyright (c) 2022 Aspose.Cells for Cloud
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
  public class CellsDocumentProperty 
  {                       
        /// <summary>
        /// Gets or sets Link
        /// </summary>  
		[DataMember(Name="link", EmitDefaultValue=false)]
        public Link Link { get; set; }

        /// <summary>
        /// Returns the name of the property.             
        /// </summary>  
		[DataMember(Name="Name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the value of the property.
        /// </summary>  
		[DataMember(Name="Value", EmitDefaultValue=false)]
        public string Value { get; set; }

        /// <summary>
        /// Indicates whether this property is linked to content
        /// </summary>  
		[DataMember(Name="IsLinkedToContent", EmitDefaultValue=false)]
        public string IsLinkedToContent { get; set; }

        /// <summary>
        /// The linked content source.
        /// </summary>  
		[DataMember(Name="Source", EmitDefaultValue=false)]
        public string Source { get; set; }

        /// <summary>
        /// Gets the data type of the property.             
        /// </summary>  
		[DataMember(Name="Type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Returns true if this property does not have a name in the OLE2 storage and a   unique name was generated only for the public API.             
        /// </summary>  
		[DataMember(Name="IsGeneratedName", EmitDefaultValue=false)]
        public string IsGeneratedName { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class CellsDocumentProperty {\n");
          sb.Append("  Link: ").Append(this.Link).Append("\n");
          sb.Append("  Name: ").Append(this.Name).Append("\n");
          sb.Append("  Value: ").Append(this.Value).Append("\n");
          sb.Append("  IsLinkedToContent: ").Append(this.IsLinkedToContent).Append("\n");
          sb.Append("  Source: ").Append(this.Source).Append("\n");
          sb.Append("  Type: ").Append(this.Type).Append("\n");
          sb.Append("  IsGeneratedName: ").Append(this.IsGeneratedName).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
