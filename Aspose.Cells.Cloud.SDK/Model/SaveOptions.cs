// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="SaveOptions.cs">
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
    /// SaveOptions.
    /// </summary>
    public class SaveOptions
    {
        /// <summary>
        /// Gets or sets SaveFormat.
        /// </summary>
        public virtual string SaveFormat { get; set; }

        /// <summary>
        /// The cached file folder is used to store some large data.
        /// </summary>
        public virtual string CachedFileFolder { get; set; }

        /// <summary>
        /// Make the workbook empty after saving the file.
        /// </summary>
        public virtual bool? ClearData { get; set; }

        /// <summary>
        /// If true and the directory does not exist, the directory will be automatically created before saving the file.
        ///             
        /// </summary>
        public virtual bool? CreateDirectory { get; set; }

        /// <summary>
        /// Gets or sets EnableHTTPCompression.
        /// </summary>
        public virtual bool? EnableHTTPCompression { get; set; }

        /// <summary>
        /// Gets or sets RefreshChartCache.
        /// </summary>
        public virtual bool? RefreshChartCache { get; set; }

        /// <summary>
        /// Gets or sets SortNames.
        /// </summary>
        public virtual bool? SortNames { get; set; }

        /// <summary>
        /// Indicates whether validate merged areas before saving the file.
        /// The default value is false.
        ///             
        /// </summary>
        public virtual bool? ValidateMergedAreas { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SaveOptions {\n");
            sb.Append("  SaveFormat: ").Append(this.SaveFormat).Append("\n");
            sb.Append("  CachedFileFolder: ").Append(this.CachedFileFolder).Append("\n");
            sb.Append("  ClearData: ").Append(this.ClearData).Append("\n");
            sb.Append("  CreateDirectory: ").Append(this.CreateDirectory).Append("\n");
            sb.Append("  EnableHTTPCompression: ").Append(this.EnableHTTPCompression).Append("\n");
            sb.Append("  RefreshChartCache: ").Append(this.RefreshChartCache).Append("\n");
            sb.Append("  SortNames: ").Append(this.SortNames).Append("\n");
            sb.Append("  ValidateMergedAreas: ").Append(this.ValidateMergedAreas).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
