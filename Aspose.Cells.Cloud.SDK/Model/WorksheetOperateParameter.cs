// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="WorksheetOperateParameter.cs">
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
  public class WorksheetOperateParameter : OperateParameter 
  {                       
        /// <summary>
        /// Gets or sets Name
        /// </summary>  
		[DataMember(Name="Name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets SheetType
        /// </summary>  
		[DataMember(Name="SheetType", EmitDefaultValue=false)]
        public string SheetType { get; set; }

        /// <summary>
        /// Gets or sets NewName
        /// </summary>  
		[DataMember(Name="NewName", EmitDefaultValue=false)]
        public string NewName { get; set; }

        /// <summary>
        /// Gets or sets MovingRequest
        /// </summary>  
		[DataMember(Name="MovingRequest", EmitDefaultValue=false)]
        public WorksheetMovingRequest MovingRequest { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class WorksheetOperateParameter {\n");
          sb.Append("  Name: ").Append(this.Name).Append("\n");
          sb.Append("  SheetType: ").Append(this.SheetType).Append("\n");
          sb.Append("  NewName: ").Append(this.NewName).Append("\n");
          sb.Append("  MovingRequest: ").Append(this.MovingRequest).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
