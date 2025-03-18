// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="SvgSaveOptions.cs">
//   Copyright (c) 2025 Aspose.Cells Cloud
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
    /// Represents the options of saving .svg file.
    /// </summary>
    public class SvgSaveOptions : SaveOptions
    {
        /// <summary>
        /// Gets and sets which worksheet should be exported.  If the value is -1, the
        ///                 active worksheet will be exported.
        /// </summary>
        public virtual int? SheetIndex { get; set; }

        /// <summary>
        /// Indicate the chart imagetype when converting.
        /// </summary>
        public virtual string ChartImageType { get; set; }

        /// <summary>
        /// Indicate the filename of embeded image in svg. This should be full path with directory like "c:\\xpsEmbeded"
        /// </summary>
        public virtual string EmbededImageNameInSvg { get; set; }

        /// <summary>
        /// Gets or sets the horizontal resolution for generated images, in dots per inch.  
        ///                Applies generating image method except Emf format images.
        ///                The default value is 96.
        /// </summary>
        public virtual int? HorizontalResolution { get; set; }

        /// <summary>
        /// Gets or sets the format of the generated images.  Don't apply the method that returns a Bitmap object.
        ///              The default value is ImageFormat.Bmp.  Don't apply the method that returns a Bitmap object.
        /// </summary>
        public virtual string ImageFormat { get; set; }

        /// <summary>
        /// Indicates whether the width and height of the cells is automatically fitted by cell value. The default value is false.
        /// </summary>
        public virtual bool? IsCellAutoFit { get; set; }

        /// <summary>
        /// If OnePagePerSheet is true , all content of one sheet will output to only
        ///                 one page in result. The paper size of pagesetup will be invalid, and the
        ///                 other settings of pagesetup will still take effect.
        /// </summary>
        public virtual bool? OnePagePerSheet { get; set; }

        /// <summary>
        /// If this property is true , onle Area will be output, and no scale will take effect.
        /// </summary>
        public virtual bool? OnlyArea { get; set; }

        /// <summary>
        /// Indicates which pages will not be printed.
        /// </summary>
        public virtual string PrintingPage { get; set; }

        /// <summary>
        /// If PrintWithStatusDialog = true , there will be a dialog that shows current print status.  else no such dialog will show.
        /// </summary>
        public virtual bool? PrintWithStatusDialog { get; set; }

        /// <summary>
        /// Gets or sets a value determining the quality of the generated images to apply only when saving pages to the Jpeg format.
        ///             Has effect only when saving to JPEG.  The value must be between 0 and 100. The default value is 100.
        /// </summary>
        public virtual int? Quality { get; set; }

        /// <summary>
        /// Gets or sets the type of compression to apply only when saving pages to the Tiff format.
        ///             Has effect only when saving to TIFF.  The default value is Lzw.
        /// </summary>
        public virtual string TiffCompression { get; set; }

        /// <summary>
        /// Gets or sets the vertical resolution for generated images, in dots per inch.
        ///             Applies generating image method except Emf format image.
        ///             The default value is 96.
        /// </summary>
        public virtual int? VerticalResolution { get; set; }

        /// <summary>
        /// Gets or sets SaveFormat.
        /// </summary>
        public override string SaveFormat { get; set; }

        /// <summary>
        /// Gets or sets CachedFileFolder.
        /// </summary>
        public override string CachedFileFolder { get; set; }

        /// <summary>
        /// Gets or sets ClearData.
        /// </summary>
        public override bool? ClearData { get; set; }

        /// <summary>
        /// Gets or sets CreateDirectory.
        /// </summary>
        public override bool? CreateDirectory { get; set; }

        /// <summary>
        /// Gets or sets EnableHTTPCompression.
        /// </summary>
        public override bool? EnableHTTPCompression { get; set; }

        /// <summary>
        /// Gets or sets RefreshChartCache.
        /// </summary>
        public override bool? RefreshChartCache { get; set; }

        /// <summary>
        /// Gets or sets SortNames.
        /// </summary>
        public override bool? SortNames { get; set; }

        /// <summary>
        /// Gets or sets ValidateMergedAreas.
        /// </summary>
        public override bool? ValidateMergedAreas { get; set; }

        /// <summary>
        /// Gets or sets MergeAreas.
        /// </summary>
        public override bool? MergeAreas { get; set; }

        /// <summary>
        /// Gets or sets SortExternalNames.
        /// </summary>
        public override bool? SortExternalNames { get; set; }

        /// <summary>
        /// Gets or sets CheckExcelRestriction.
        /// </summary>
        public override bool? CheckExcelRestriction { get; set; }

        /// <summary>
        /// Gets or sets UpdateSmartArt.
        /// </summary>
        public override bool? UpdateSmartArt { get; set; }

        /// <summary>
        /// Gets or sets EncryptDocumentProperties.
        /// </summary>
        public override bool? EncryptDocumentProperties { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SvgSaveOptions {\n");
            sb.Append("  SheetIndex: ").Append(this.SheetIndex).Append("\n");
            sb.Append("  ChartImageType: ").Append(this.ChartImageType).Append("\n");
            sb.Append("  EmbededImageNameInSvg: ").Append(this.EmbededImageNameInSvg).Append("\n");
            sb.Append("  HorizontalResolution: ").Append(this.HorizontalResolution).Append("\n");
            sb.Append("  ImageFormat: ").Append(this.ImageFormat).Append("\n");
            sb.Append("  IsCellAutoFit: ").Append(this.IsCellAutoFit).Append("\n");
            sb.Append("  OnePagePerSheet: ").Append(this.OnePagePerSheet).Append("\n");
            sb.Append("  OnlyArea: ").Append(this.OnlyArea).Append("\n");
            sb.Append("  PrintingPage: ").Append(this.PrintingPage).Append("\n");
            sb.Append("  PrintWithStatusDialog: ").Append(this.PrintWithStatusDialog).Append("\n");
            sb.Append("  Quality: ").Append(this.Quality).Append("\n");
            sb.Append("  TiffCompression: ").Append(this.TiffCompression).Append("\n");
            sb.Append("  VerticalResolution: ").Append(this.VerticalResolution).Append("\n");
            sb.Append("  SaveFormat: ").Append(this.SaveFormat).Append("\n");
            sb.Append("  CachedFileFolder: ").Append(this.CachedFileFolder).Append("\n");
            sb.Append("  ClearData: ").Append(this.ClearData).Append("\n");
            sb.Append("  CreateDirectory: ").Append(this.CreateDirectory).Append("\n");
            sb.Append("  EnableHTTPCompression: ").Append(this.EnableHTTPCompression).Append("\n");
            sb.Append("  RefreshChartCache: ").Append(this.RefreshChartCache).Append("\n");
            sb.Append("  SortNames: ").Append(this.SortNames).Append("\n");
            sb.Append("  ValidateMergedAreas: ").Append(this.ValidateMergedAreas).Append("\n");
            sb.Append("  MergeAreas: ").Append(this.MergeAreas).Append("\n");
            sb.Append("  SortExternalNames: ").Append(this.SortExternalNames).Append("\n");
            sb.Append("  CheckExcelRestriction: ").Append(this.CheckExcelRestriction).Append("\n");
            sb.Append("  UpdateSmartArt: ").Append(this.UpdateSmartArt).Append("\n");
            sb.Append("  EncryptDocumentProperties: ").Append(this.EncryptDocumentProperties).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
