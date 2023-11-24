# **pageSetup**

 

## **Properties**

| Property Name | Property Type | Nullable |  ReadOnly | DefaultValue | Description | 
| :- | :- | :- |:- |  :- | :- |
|BlackAndWhite|Boolean|true|false |  |Represents if elements of the document will be printed in black and white.|
|BottomMargin|Floating|true|false |  |Represents the size of the bottom margin, in unit of centimeters.|
|CenterHorizontally|Boolean|true|false |  |Represent if the sheet is printed centered horizontally.|
|CenterVertically|Boolean|true|false |  |Represent if the sheet is printed centered vertically.|
|FirstPageNumber|Integer|true|false |  |Represents the first page number that will be used when this sheet is printed.|
|FitToPagesTall|Integer|true|false |  |Represents  the number of pages tall the worksheet will be scaled to when it's printed.                        The default value is 1.|
|FitToPagesWide|Integer|true|false |  |Represents the number of pages wide the worksheet will be scaled to when it's printed.                        The default value is 1.|
|FooterMargin|Floating|true|false |  |Represents the distance from the bottom of the page to the footer, in unit of centimeters.|
|HeaderMargin|Floating|true|false |  |Represents the distance from the top of the page to the header, in unit of centimeters.|
|IsAutoFirstPageNumber|Boolean|true|false |  |Indicates whether the first the page number is automatically assigned.|
|IsHFAlignMargins|Boolean|true|false |  |Indicates whether header and footer margins are aligned with the page margins.                        If this property is true, the left header and footer will be aligned with the left margin,                        and the right header and footer will be aligned with the right margin.                        This option is enabled by default.|
|IsHFDiffFirst|Boolean|true|false |  |True means that the header/footer of the first page is different with other pages.|
|IsHFDiffOddEven|Boolean|true|false |  |True means that the header/footer of the odd pages is different with odd pages.|
|IsHFScaleWithDoc|Boolean|true|false |  |Indicates whether header and footer are scaled with document scaling.                        Only applies for Excel 2007.|
|IsPercentScale|Boolean|true|false |  |If this property is False, the FitToPagesWide and FitToPagesTall properties control how the worksheet is scaled.|
|LeftMargin|Floating|true|false |  |Represents the size of the left margin, in unit of centimeters.|
|Order|String|true|false |  |Represents the order that Microsoft Excel uses to number pages when printing a large worksheet.|
|Orientation|String|true|false |  |Represents page print orientation.|
|PaperSize|String|true|false |  |Represents the size of the paper.|
|PrintArea|String|true|false |  |Represents the range to be printed.|
|PrintComments|String|true|false |  |Represents the way comments are printed with the sheet.|
|PrintCopies|Integer|true|false |  |Get and sets number of copies to print.|
|PrintDraft|Boolean|true|false |  |Represents if the sheet will be printed without graphics.|
|PrintErrors|String|true|false |  |Specifies the type of print error displayed.|
|PrintGridlines|Boolean|true|false |  |Represents if cell gridlines are printed on the page.|
|PrintHeadings|Boolean|true|false |  |Represents if row and column headings are printed with this page.|
|PrintQuality|Integer|true|false |  |Represents the print quality.|
|PrintTitleColumns|String|true|false |  |Represents the columns that contain the cells to be repeated on the left side of each page.|
|PrintTitleRows|String|true|false |  |Represents the rows that contain the cells to be repeated at the top of each page.|
|RightMargin|Floating|true|false |  |Represents the size of the right margin, in unit of centimeters.|
|TopMargin|Floating|true|false |  |Represents the size of the top margin, in unit of centimeters.|
|Zoom|Integer|true|false |  |Represents the scaling factor in percent. It should be between 10 and 400.|
|Header|Container|true|false |  |Represents the page header.|
|Footer|Container|true|false |  |Represents the page footor.|
|link|Class|true|false |  ||

