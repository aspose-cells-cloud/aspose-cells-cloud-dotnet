# **copyOptions**

Represents the copy options. 

## **Properties**

| Property Name | Property Type | Nullable |  ReadOnly | DefaultValue | Description | 
| :- | :- | :- |:- |  :- | :- |
|ColumnCharacterWidth|Boolean|true|false |  |Indicates whether copying column width in unit of characters. |
|CopyInvalidFormulasAsValues|Boolean|true|false |  |If the formula is not valid for the dest destination, only copy values. |
|CopyNames|Boolean|true|false |  |Indicates whether copying the names. |
|ExtendToAdjacentRange|Boolean|true|false |  |Indicates whether extend ranges when copying the range to adjacent range. |
|ReferToDestinationSheet|Boolean|true|false |  |When copying the range in the same file and the chart refers to the source sheet,            False means the copied chart's data source will not be changed.            True means the copied chart's data source refers to the destination sheet. |
|ReferToSheetWithSameName|Boolean|true|false |  |In ms excel, when copying formulas which refer to other worksheets while copying a worksheet to another one,            the copied formulas should refer to source workbook.            However, for some situations user may need the copied formulas refer to worksheets with the same name            in the same workbook, such as when those worksheets have been copied before this copy operation,            then this property should be kept as true. |
|CopyTheme|Boolean|true|false |  ||

