# **svgSaveOptions**

Represents the options of saving .svg file. 

## **Properties**

| Property Name | Property Type | Nullable |  ReadOnly | DefaultValue | Description | 
| :- | :- | :- |:- |  :- | :- |
|SheetIndex|Integer|true|false |  |Gets and sets which worksheet should be exported.  If the value is -1, the                active worksheet will be exported.|
|ChartImageType|String|true|false |  |Indicate the chart imagetype when converting.|
|EmbededImageNameInSvg|String|true|false |  |Indicate the filename of embeded image in svg. This should be full path with directory like "c:\\xpsEmbeded"|
|HorizontalResolution|Integer|true|false |  |Gets or sets the horizontal resolution for generated images, in dots per inch.                 Applies generating image method except Emf format images.               The default value is 96.|
|ImageFormat|String|true|false |  |Gets or sets the format of the generated images.  Don't apply the method that returns a Bitmap object.             The default value is ImageFormat.Bmp.  Don't apply the method that returns a Bitmap object.|
|IsCellAutoFit|Boolean|true|false |  |Indicates whether the width and height of the cells is automatically fitted by cell value. The default value is false.|
|OnePagePerSheet|Boolean|true|false |  |If OnePagePerSheet is true , all content of one sheet will output to only                one page in result. The paper size of pagesetup will be invalid, and the                other settings of pagesetup will still take effect.|
|OnlyArea|Boolean|true|false |  |If this property is true , onle Area will be output, and no scale will take effect.|
|PrintingPage|String|true|false |  |Indicates which pages will not be printed.|
|PrintWithStatusDialog|Boolean|true|false |  |If PrintWithStatusDialog = true , there will be a dialog that shows current print status.  else no such dialog will show.|
|Quality|Integer|true|false |  |Gets or sets a value determining the quality of the generated images to apply only when saving pages to the Jpeg format.            Has effect only when saving to JPEG.  The value must be between 0 and 100. The default value is 100.|
|TiffCompression|String|true|false |  |Gets or sets the type of compression to apply only when saving pages to the Tiff format.            Has effect only when saving to TIFF.  The default value is Lzw.|
|VerticalResolution|Integer|true|false |  |Gets or sets the vertical resolution for generated images, in dots per inch.            Applies generating image method except Emf format image.            The default value is 96.|
|SaveFormat|String|true|false |  ||
|CachedFileFolder|String|true|false |  ||
|ClearData|Boolean|true|false |  ||
|CreateDirectory|Boolean|true|false |  ||
|EnableHTTPCompression|Boolean|true|false |  ||
|RefreshChartCache|Boolean|true|false |  ||
|SortNames|Boolean|true|false |  ||
|ValidateMergedAreas|Boolean|true|false |  ||
|MergeAreas|Boolean|true|false |  ||
|SortExternalNames|Boolean|true|false |  ||
|CheckExcelRestriction|Boolean|true|false |  ||
|UpdateSmartArt|Boolean|true|false |  ||
|EncryptDocumentProperties|Boolean|true|false |  ||

