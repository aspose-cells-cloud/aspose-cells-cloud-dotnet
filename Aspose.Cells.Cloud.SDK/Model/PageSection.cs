// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PageSection.cs">
//   Copyright (c) 2021 Aspose.Cells Cloud
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
  public class PageSection 
  {                       
        /// <summary>
        /// Gets or sets Picture
        /// </summary>  
		[DataMember(Name="Picture", EmitDefaultValue=false)]
        public byte[] Picture { get; set; }

        /// <summary>
        /// 0,1,2  left , middle ,right
        /// </summary>  
		[DataMember(Name="Section", EmitDefaultValue=false)]
        public int? Section { get; set; }

        /// <summary>
        /// fisrt page context script
        /// </summary>  
		[DataMember(Name="FisrtPageContext", EmitDefaultValue=false)]
        public string FisrtPageContext { get; set; }

        /// <summary>
        /// page context script             
        /// </summary>  
		[DataMember(Name="Context", EmitDefaultValue=false)]
        public string Context { get; set; }

        /// <summary>
        /// Even page context script
        /// </summary>  
		[DataMember(Name="EvenPageContext", EmitDefaultValue=false)]
        public string EvenPageContext { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class PageSection {\n");
          sb.Append("  Picture: ").Append(this.Picture).Append("\n");
          sb.Append("  Section: ").Append(this.Section).Append("\n");
          sb.Append("  FisrtPageContext: ").Append(this.FisrtPageContext).Append("\n");
          sb.Append("  Context: ").Append(this.Context).Append("\n");
          sb.Append("  EvenPageContext: ").Append(this.EvenPageContext).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
