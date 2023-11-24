# **ooxmlSaveOptions**

Represents options of saving ooxml file. 

## **Properties**

| Property Name | Property Type | Nullable |  ReadOnly | DefaultValue | Description | 
| :- | :- | :- |:- |  :- | :- |
|ExportCellName|Boolean|true|false |  |Indicates if export cell name to Excel2007 .xlsx (.xlsm, .xltx, .xltm) file.               If the output file may be accessed by SQL Server DTS, this value must be               true.  Setting the value to false will highly increase the performance and               reduce the file size when creating large file.  Default value is false.|
|UpdateZoom|Boolean|true|false |  |Indicates whether update scaling factor before saving the file if the PageSetup.FitToPagesWide and PageSetup.FitToPagesTall properties control how the worksheet is scaled.|
|EnableZip64|Boolean|true|false |  |Always use ZIP64 extensions when writing zip archives, even when unnecessary.|
|EmbedOoxmlAsOleObject|Boolean|true|false |  |Indicates whether embedding Ooxml files of OleObject as ole object.|
|CompressionType|String|true|false |  |Gets and sets the compression type for ooxml file.|
|SaveFormat|String|true|false |  ||
|CachedFileFolder|String|true|false |  ||
|ClearData|Boolean|true|false |  ||
|CreateDirectory|Boolean|true|false |  ||
|EnableHTTPCompression|Boolean|true|false |  ||
|RefreshChartCache|Boolean|true|false |  ||
|SortNames|Boolean|true|false |  ||
|ValidateMergedAreas|Boolean|true|false |  ||

