# **workbookSettings**

           Represents all settings of the workbook.            

## **Properties**

| Property Name | Property Type | Nullable |  ReadOnly | DefaultValue | Description | 
| :- | :- | :- |:- |  :- | :- |
|AutoCompressPictures|Boolean|true|false |  |Specifies a boolean value that indicates the application automatically compressed pictures in the workbook. |
|AutoRecover|Boolean|true|false |  |Indicates whether the file is mark for auto-recovery. |
|BuildVersion|String|true|false |  |Specifies the incremental public release of the application. |
|CalcMode|String|true|false |  |It specifies whether to calculate formulas manually,            automatically or automatically except for multiple table operations. |
|CalculationId|String|true|false |  |Specifies the version of the calculation engine used to calculate values in the workbook. |
|CheckComptiliblity|Boolean|true|false |  |Indicates whether check comptiliblity when saving workbook.                         Remarks: The default value is true.             |
|CheckExcelRestriction|Boolean|true|false |  |Whether check restriction of excel file when user modify cells related objects.            For example, excel does not allow inputting string value longer than 32K.            When you input a value longer than 32K such as by Cell.PutValue(string), if this property is true, you will get an Exception.            If this property is false, we will accept your input string value as the cell's value so that later            you can output the complete string value for other file formats such as CSV.            However, if you have set such kind of value that is invalid for excel file format,            you should not save the workbook as excel file format later. Otherwise there may be unexpected error for the generated excel file. |
|CrashSave|Boolean|true|false |  |indicates whether the application last saved the workbook file after a crash. |
|CreateCalcChain|Boolean|true|false |  |Whether creates calculated formulas chain. Default is false. |
|DataExtractLoad|Boolean|true|false |  |indicates whether the application last opened the workbook for data recovery. |
|Date1904|Boolean|true|false |  |Gets or sets a value which represents if the workbook uses the 1904 date system. |
|DisplayDrawingObjects|String|true|false |  |Indicates whether and how to show objects in the workbook. |
|EnableMacros|Boolean|true|false |  |Enable macros; |
|FirstVisibleTab|Integer|true|false |  |Gets or sets the first visible worksheet tab. |
|HidePivotFieldList|Boolean|true|false |  |Gets and sets whether hide the field list for the PivotTable. |
|IsDefaultEncrypted|Boolean|true|false |  |Indicates whether encrypting the workbook with default password if Structure and Windows of the workbook are locked. |
|IsHidden|Boolean|true|false |  |Indicates whether this workbook is hidden. |
|IsHScrollBarVisible|Boolean|true|false |  |Gets or sets a value indicating whether the generated spreadsheet will contain a horizontal scroll bar. |
|IsMinimized|Boolean|true|false |  |Represents whether the generated spreadsheet will be opened Minimized. |
|IsVScrollBarVisible|Boolean|true|false |  |Gets or sets a value indicating whether the generated spreadsheet will contain a vertical scroll bar. |
|Iteration|Boolean|true|false |  |Indicates whether enable iterative calculation to resolve circular references. |
|LanguageCode|String|true|false |  |Gets or sets the user interface language of the Workbook version based on CountryCode that has saved the file. |
|MaxChange|Floating|true|false |  |Returns or sets the maximum number of change to resolve a circular reference. |
|MaxIteration|Integer|true|false |  |Returns or sets the maximum number of iterations to resolve a circular reference. |
|MemorySetting|String|true|false |  |Gets or sets the memory usage options. The new option will be taken as the default option for newly created worksheets but does not take effect for existing worksheets. |
|NumberDecimalSeparator|String|true|false |  |Gets or sets the decimal separator for formatting/parsing numeric values. Default is the decimal separator of current Region. |
|NumberGroupSeparator|String|true|false |  |Gets or sets the character that separates groups of digits to the left of the decimal in numeric values. Default is the group separator of current Region. |
|ParsingFormulaOnOpen|Boolean|true|false |  |Indicates whether parsing the formula when reading the file. |
|PrecisionAsDisplayed|Boolean|true|false |  |True if calculations in this workbook will be done using only the precision of the numbers as they're displayed |
|RecalculateBeforeSave|Boolean|true|false |  |Indicates whether to recalculate before saving the document. |
|ReCalculateOnOpen|Boolean|true|false |  |Indicates whether re-calculate all formulas on opening file. |
|RecommendReadOnly|Boolean|true|false |  |Indicates if the Read Only Recommended option is selected.            |
|Region|String|true|false |  |Gets or sets the regional settings for workbook. |
|RemovePersonalInformation|Boolean|true|false |  |True if personal information can be removed from the specified workbook. |
|RepairLoad|Boolean|true|false |  |Indicates whether the application last opened the workbook in safe or repair mode. |
|Shared|Boolean|true|false |  |Gets or sets a value that indicates whether the Workbook is shared. |
|SheetTabBarWidth|Integer|true|false |  |Width of worksheet tab bar (in 1/1000 of window width). |
|ShowTabs|Boolean|true|false |  |Get or sets a value whether the Workbook tabs are displayed. |
|UpdateAdjacentCellsBorder|Boolean|true|false |  |Indicates whether update adjacent cells' border. |
|UpdateLinksType|String|true|false |  |Gets and sets how updates external links when the workbook is opened. |
|WindowHeight|Floating|true|false |  |The height of the window, in unit of point. |
|WindowLeft|Floating|true|false |  |The distance from the left edge of the client area to the left edge of the window, in unit of point. |
|WindowTop|Floating|true|false |  |The distance from the top edge of the client area to the top edge of the window, in unit of point. |
|WindowWidth|Floating|true|false |  |The width of the window, in unit of point. |
|Author|String|true|false |  |Gets and sets the author of the file. |
|CheckCustomNumberFormat|Boolean|true|false |  |Indicates whether checking custom number format when setting Style.Custom. |
|ProtectionType|String|true|false |  |Gets the protection type of the workbook. |
|GlobalizationSettings|Class|true|false |  |Gets and sets the globalization settings. |
|Password|String|true|false |  |Represents Workbook file encryption password. |
|WriteProtection|Class|true|false |  |Provides access to the workbook write protection options. |
|IsEncrypted|Boolean|true|false |  |Gets a value that indicates whether a password is required to open this workbook. |
|IsProtected|Boolean|true|false |  |Gets a value that indicates whether the structure or window of the Workbook is protected. |
|MaxRow|Integer|true|false |  |Gets the max row index, zero-based. |
|MaxColumn|Integer|true|false |  |Gets the max column index, zero-based. |
|SignificantDigits|Integer|true|false |  |Gets and sets the number of significant digits.            The default value is . |
|CheckCompatibility|Boolean|true|false |  |Indicates whether check compatibility with earlier versions when saving workbook. |
|PaperSize|String|true|false |  |Gets and sets the default print paper size. |
|MaxRowsOfSharedFormula|Integer|true|false |  |Gets and sets the max row number of shared formula. |
|Compliance|String|true|false |  |Specifies the OOXML version for the output document. The default value is Ecma376_2006. |
|QuotePrefixToStyle|Boolean|true|false |  |Indicates whether setting  property when entering the string value(which starts  with single quote mark ) to the cell |
|FormulaSettings|Class|true|false |  |Gets the settings for formula-related features. |
|ForceFullCalculate|Boolean|true|false |  |Fully calculates every time when a calculation is triggered. |

