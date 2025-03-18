# **pdfSaveOptions**

Represents options of saving pdf file. 

## **Properties**

| Property Name | Property Type | Nullable |  ReadOnly | DefaultValue | Description | 
| :- | :- | :- |:- |  :- | :- |
|DisplayDocTitle|Boolean|true|false |  |Indicates whether the window's title bar should display the document title.|
|ExportDocumentStructure|Boolean|true|false |  |Indicates whether to export document structure.|
|EmfRenderSetting|String|true|false |  |Setting for rendering Emf metafile.|
|CustomPropertiesExport|String|true|false |  |Specifies the way CustomDocumentPropertyCollection are exported to PDF file.|
|OptimizationType|String|true|false |  |Gets and sets pdf optimization type.|
|Producer|String|true|false |  |Gets and sets producer of generated pdf document.|
|PdfCompression|String|true|false |  |Indicate the compression algorithm.|
|FontEncoding|String|true|false |  |Gets or sets embedded font encoding in pdf.|
|Watermark|Class|true|false |  |Gets or sets watermark to output.|
|CalculateFormula|Boolean|true|false |  |Indicates whether calculate formulas before saving pdf file.The default value is false.|
|CheckFontCompatibility|Boolean|true|false |  |Indicates whether check font compatibility for every character in text.                The default value is true.  Disable this property may give better performance.                 But when the default or specified font of text/character cannot be used                to render it, unreadable characters(such as block) maybe occur in the generated                pdf.  For such situation user should keep this property as true so that alternative                font can be searched and used to render the text instead;|
|Compliance|String|true|false |  |Workbook converts to pdf will according to PdfCompliance in this property.|
|DefaultFont|String|true|false |  |When characters in the Excel are unicode and not be set with correct font in cell style,              They may appear as block in pdf,image.  Set the DefaultFont such as MingLiu or MS Gothic to show these characters.               If this property is not set, Aspose.Cells will use system default font to show these unicode characters.|
|OnePagePerSheet|Boolean|true|false |  |If OnePagePerSheet is true , all content of one sheet will output to only            one page in result. The paper size of pagesetup will be invalid, and the               other settings of pagesetup will still take effect.|
|PrintingPageType|String|true|false |  |Indicates which pages will not be printed.|
|SecurityOptions|Class|true|false |  |Set this options, when security is need in xls2pdf result.|
|desiredPPI|Integer|true|false |  |Set desired PPI(pixels per inch) of resample images and jpeg quality  All images will be converted to JPEG with the specified quality setting, and images that are greater than the specified PPI (pixels per inch) will be resampled.              Desired pixels per inch. 220 high quality. 150 screen quality. 96 email quality.|
|jpegQuality|Integer|true|false |  |Set desired PPI(pixels per inch) of resample images and jpeg quality  All images will be converted to JPEG with the specified quality setting, and images that are greater than the specified PPI (pixels per inch) will be resampled.              0 - 100% JPEG quality.|
|ImageType|String|true|false |  |Represents the image type when converting the chart and shape .|
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

