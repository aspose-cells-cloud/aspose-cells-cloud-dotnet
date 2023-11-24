# **mHtmlSaveOptions**

Represents options of saving .mhtml file. 

## **Properties**

| Property Name | Property Type | Nullable |  ReadOnly | DefaultValue | Description | 
| :- | :- | :- |:- |  :- | :- |
|AttachedFilesDirectory|String|true|false |  |The directory that the attached files will be saved to.  Only for saving to html stream.|
|AttachedFilesUrlPrefix|String|true|false |  |Specify the Url prefix of attached files such as image in the html file. Only for saving to html stream.|
|Encoding|String|true|false |  |If not set,use Encoding.UTF8 as default enconding type.|
|ExportActiveWorksheetOnly|Boolean|true|false |  |Indicates if exporting the whole workbook to html file.|
|ExportChartImageFormat|String|true|false |  |Get or set the format of chart image before exporting|
|ExportImagesAsBase64|Boolean|true|false |  |Specifies whether images are saved in Base64 format to HTML, MHTML or EPUB.|
|HiddenColDisplayType|String|true|false |  |Hidden column(the width of this column is 0) in excel,before save this into                html format, if HtmlHiddenColDisplayType is "Remove",the hidden column would               ont been output, if the value is "Hidden", the column would been output,but was hidden,the default value is "Hidden"|
|HiddenRowDisplayType|String|true|false |  |Hidden row(the height of this row is 0) in excel,before save this into html                format, if HtmlHiddenRowDisplayType is "Remove",the hidden row would ont               been output, if the value is "Hidden", the row would been output,but was               hidden,the default value is "Hidden"|
|HtmlCrossStringType|String|true|false |  |Indicates if a cross-cell string will be displayed in the same way as MS               Excel when saving an Excel file in html format.  By default the value is               Default, so, for cross-cell strings, there is little difference between the               html files created by Aspose.Cells and MS Excel. But the performance for               creating large html files,setting the value to Cross would be several times               faster than setting it to Default or Fit2Cell.|
|IsExpImageToTempDir|Boolean|true|false |  |Indicates if export image files to temp directory.  Only for saving to html  stream.|
|PageTitle|String|true|false |  |The title of the html page.  Only for saving to html stream.|
|ParseHtmlTagInCell|Boolean|true|false |  |Parse html tag in cell,like ,as cell value,or as html tag,default is true|
|SaveFormat|String|true|false |  ||
|CachedFileFolder|String|true|false |  ||
|ClearData|Boolean|true|false |  ||
|CreateDirectory|Boolean|true|false |  ||
|EnableHTTPCompression|Boolean|true|false |  ||
|RefreshChartCache|Boolean|true|false |  ||
|SortNames|Boolean|true|false |  ||
|ValidateMergedAreas|Boolean|true|false |  ||

