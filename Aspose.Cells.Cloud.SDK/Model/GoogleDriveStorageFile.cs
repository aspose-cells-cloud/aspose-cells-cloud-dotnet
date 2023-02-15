// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="GoogleDriveStorageFile.cs">
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
    /// GoogleDriveStorageFile.
    /// </summary>
    public class GoogleDriveStorageFile : StorageFile
    {
        /// <summary>
        /// Gets or sets MimeType.
        /// </summary>
        public virtual string MimeType { get; set; }

        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        public override string Name { get; set; }

        /// <summary>
        /// Gets or sets IsFolder.
        /// </summary>
        public override bool? IsFolder { get; set; }

        /// <summary>
        /// Gets or sets ModifiedDate.
        /// </summary>
        public override DateTime? ModifiedDate { get; set; }

        /// <summary>
        /// Gets or sets Size.
        /// </summary>
        public override long? Size { get; set; }

        /// <summary>
        /// Gets or sets Path.
        /// </summary>
        public override string Path { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GoogleDriveStorageFile {\n");
            sb.Append("  MimeType: ").Append(this.MimeType).Append("\n");
            sb.Append("  Name: ").Append(this.Name).Append("\n");
            sb.Append("  IsFolder: ").Append(this.IsFolder).Append("\n");
            sb.Append("  ModifiedDate: ").Append(this.ModifiedDate).Append("\n");
            sb.Append("  Size: ").Append(this.Size).Append("\n");
            sb.Append("  Path: ").Append(this.Path).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
