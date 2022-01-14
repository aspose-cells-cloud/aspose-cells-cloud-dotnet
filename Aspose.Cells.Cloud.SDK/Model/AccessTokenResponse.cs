// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="AccessTokenResponse.cs">
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
  public class AccessTokenResponse 
  {                       
        /// <summary>
        /// Gets or sets Expires
        /// </summary>  
		[DataMember(Name="expires", EmitDefaultValue=false)]
        public string Expires { get; set; }

        /// <summary>
        /// Gets or sets AccessToken
        /// </summary>  
		[DataMember(Name="access_token", EmitDefaultValue=false)]
        public string AccessToken { get; set; }

        /// <summary>
        /// Gets or sets Issued
        /// </summary>  
		[DataMember(Name="issued", EmitDefaultValue=false)]
        public string Issued { get; set; }

        /// <summary>
        /// Gets or sets ClientRefreshTokenLifeTimeInMinutes
        /// </summary>  
		[DataMember(Name="clientRefreshTokenLifeTimeInMinutes", EmitDefaultValue=false)]
        public string ClientRefreshTokenLifeTimeInMinutes { get; set; }

        /// <summary>
        /// Gets or sets ExpiresIn
        /// </summary>  
		[DataMember(Name="expires_in", EmitDefaultValue=false)]
        public long? ExpiresIn { get; set; }

        /// <summary>
        /// Gets or sets TokenType
        /// </summary>  
		[DataMember(Name="token_type", EmitDefaultValue=false)]
        public string TokenType { get; set; }

        /// <summary>
        /// Gets or sets ClientId
        /// </summary>  
		[DataMember(Name="client_id", EmitDefaultValue=false)]
        public string ClientId { get; set; }

        /// <summary>
        /// Gets or sets RefreshToken
        /// </summary>  
		[DataMember(Name="refresh_token", EmitDefaultValue=false)]
        public string RefreshToken { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class AccessTokenResponse {\n");
          sb.Append("  Expires: ").Append(this.Expires).Append("\n");
          sb.Append("  AccessToken: ").Append(this.AccessToken).Append("\n");
          sb.Append("  Issued: ").Append(this.Issued).Append("\n");
          sb.Append("  ClientRefreshTokenLifeTimeInMinutes: ").Append(this.ClientRefreshTokenLifeTimeInMinutes).Append("\n");
          sb.Append("  ExpiresIn: ").Append(this.ExpiresIn).Append("\n");
          sb.Append("  TokenType: ").Append(this.TokenType).Append("\n");
          sb.Append("  ClientId: ").Append(this.ClientId).Append("\n");
          sb.Append("  RefreshToken: ").Append(this.RefreshToken).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
