# **paginatedSaveOptions**

Represents the options for pagination. 

## **Properties**

| Property Name | Property Type | Nullable |  ReadOnly | DefaultValue | Description | 
| :- | :- | :- |:- |  :- | :- |
|DefaultFont|String|true|false |  |When characters in the Excel are Unicode and not be set with correct font in cell style,They may appear as block in pdf,image.Set the DefaultFont such as MingLiu or MS Gothic to show these characters. If this property is not set, Aspose.Cells will use system default font to show these unicode characters.|
|CheckWorkbookDefaultFont|Boolean|true|false |  |When characters in the Excel are Unicode and not be set with correct font in cell style,They may appear as block in pdf,image.Set this to true to try to use workbook's default font to show these characters first.|
|CheckFontCompatibility|Boolean|true|false |  |Indicates whether to check font compatibility for every character in text.|
|IsFontSubstitutionCharGranularity|Boolean|true|false |  |Indicates whether to only substitute the font of character when the cell font is not compatibility for it.|
|OnePagePerSheet|Boolean|true|false |  |If OnePagePerSheet is true , all content of one sheet will output to only one page in result.The paper size of pagesetup will be invalid, and the other settings of pagesetup will still take effect.|
|AllColumnsInOnePagePerSheet|Boolean|true|false |  |If AllColumnsInOnePagePerSheet is true , all column content of one sheet will output to only one page in result.The width of paper size of pagesetup will be ignored, and the other settings of pagesetup will still take effect.|
|IgnoreError|Boolean|true|false |  |Indicates if you need to hide the error while rendering.The error can be error in shape, image, chart rendering, etc.|
|OutputBlankPageWhenNothingToPrint|Boolean|true|false |  |Indicates whether to output a blank page when there is nothing to print.|
|PageIndex|Integer|true|false |  |Gets or sets the 0-based index of the first page to save.|
|PageCount|Integer|true|false |  |Gets or sets the number of pages to save.|
|PrintingPageType|String|true|false |  |Indicates which pages will not be printed.|
|GridlineType|String|true|false |  |Gets or sets gridline type.|
|TextCrossType|String|true|false |  |Gets or sets displaying text type when the text width is larger than cell width.|
|DefaultEditLanguage|String|true|false |  |Gets or sets default edit language.|
|EmfRenderSetting|String|true|false |  ||
|MergeAreas|Boolean|true|false |  ||
|SortExternalNames|Boolean|true|false |  ||
|UpdateSmartArt|Boolean|true|false |  ||
|SaveFormat|String|true|false |  ||
|CachedFileFolder|String|true|false |  ||
|ClearData|Boolean|true|false |  ||
|CreateDirectory|Boolean|true|false |  ||
|EnableHTTPCompression|Boolean|true|false |  ||
|RefreshChartCache|Boolean|true|false |  ||
|SortNames|Boolean|true|false |  ||
|ValidateMergedAreas|Boolean|true|false |  ||

