// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ImageSaveOptions.cs">
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
  public class JsonSaveOptions : SaveOptions 
  {                       
        /// <summary>
        /// Gets or sets ChartImageType
        /// </summary>  
		[DataMember(Name= "ExportArea", EmitDefaultValue=false)]
        public CellArea ExportArea { get; set; }

        /// <summary>
        /// Gets or sets EmbededImageNameInSvg
        /// </summary>  
		[DataMember(Name= "HasHeaderRow", EmitDefaultValue=false)]
        public bool? HasHeaderRow { get; set; }

        /// <summary>
        /// Gets or sets HorizontalResolution
        /// </summary>  
		[DataMember(Name= "ExportAsString", EmitDefaultValue=false)]
        public bool? ExportAsString { get; set; }

        /// <summary>
        /// Gets or sets ImageFormat
        /// </summary>  
		[DataMember(Name= "Indent", EmitDefaultValue=false)]
        public string Indent { get; set; }

        

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class JsonSaveOptions {\n");
          sb.Append("  ExportArea: ").Append(this.ExportArea).Append("\n");
          sb.Append("  HasHeaderRow: ").Append(this.HasHeaderRow).Append("\n");
          sb.Append("  ExportAsString: ").Append(this.ExportAsString).Append("\n");
          sb.Append("  Indent: ").Append(this.Indent).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}