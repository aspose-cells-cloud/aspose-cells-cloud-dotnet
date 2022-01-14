// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PdfSecurityOptions.cs">
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
  public class PdfSecurityOptions 
  {                       
        /// <summary>
        /// Gets or sets AnnotationsPermission
        /// </summary>  
		[DataMember(Name="AnnotationsPermission", EmitDefaultValue=false)]
        public bool? AnnotationsPermission { get; set; }

        /// <summary>
        /// Gets or sets AssembleDocumentPermission
        /// </summary>  
		[DataMember(Name="AssembleDocumentPermission", EmitDefaultValue=false)]
        public bool? AssembleDocumentPermission { get; set; }

        /// <summary>
        /// Make the workbook empty after saving the file.
        /// </summary>  
		[DataMember(Name="ExtractContentPermission", EmitDefaultValue=false)]
        public bool? ExtractContentPermission { get; set; }

        /// <summary>
        /// The cached file folder is used to store some large data.
        /// </summary>  
		[DataMember(Name="ExtractContentPermissionObsolete", EmitDefaultValue=false)]
        public bool? ExtractContentPermissionObsolete { get; set; }

        /// <summary>
        /// Indicates whether validate merged areas before saving the file. The default value is false.             
        /// </summary>  
		[DataMember(Name="FillFormsPermission", EmitDefaultValue=false)]
        public bool? FillFormsPermission { get; set; }

        /// <summary>
        /// Gets or sets FullQualityPrintPermission
        /// </summary>  
		[DataMember(Name="FullQualityPrintPermission", EmitDefaultValue=false)]
        public bool? FullQualityPrintPermission { get; set; }

        /// <summary>
        /// If true and the directory does not exist, the directory will be automatically created before saving the file.             
        /// </summary>  
		[DataMember(Name="ModifyDocumentPermission", EmitDefaultValue=false)]
        public bool? ModifyDocumentPermission { get; set; }

        /// <summary>
        /// Gets or sets OwnerPassword
        /// </summary>  
		[DataMember(Name="OwnerPassword", EmitDefaultValue=false)]
        public string OwnerPassword { get; set; }

        /// <summary>
        /// Gets or sets PrintPermission
        /// </summary>  
		[DataMember(Name="PrintPermission", EmitDefaultValue=false)]
        public bool? PrintPermission { get; set; }

        /// <summary>
        /// Gets or sets UserPassword
        /// </summary>  
		[DataMember(Name="UserPassword", EmitDefaultValue=false)]
        public string UserPassword { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class PdfSecurityOptions {\n");
          sb.Append("  AnnotationsPermission: ").Append(this.AnnotationsPermission).Append("\n");
          sb.Append("  AssembleDocumentPermission: ").Append(this.AssembleDocumentPermission).Append("\n");
          sb.Append("  ExtractContentPermission: ").Append(this.ExtractContentPermission).Append("\n");
          sb.Append("  ExtractContentPermissionObsolete: ").Append(this.ExtractContentPermissionObsolete).Append("\n");
          sb.Append("  FillFormsPermission: ").Append(this.FillFormsPermission).Append("\n");
          sb.Append("  FullQualityPrintPermission: ").Append(this.FullQualityPrintPermission).Append("\n");
          sb.Append("  ModifyDocumentPermission: ").Append(this.ModifyDocumentPermission).Append("\n");
          sb.Append("  OwnerPassword: ").Append(this.OwnerPassword).Append("\n");
          sb.Append("  PrintPermission: ").Append(this.PrintPermission).Append("\n");
          sb.Append("  UserPassword: ").Append(this.UserPassword).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
