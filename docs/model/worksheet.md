# **worksheet**

           Encapsulates the object that represents a single worksheet.            

## **Properties**

| Property Name | Property Type | Nullable |  ReadOnly | DefaultValue | Description | 
| :- | :- | :- |:- |  :- | :- |
|Links|Container|true|false |  |Property Summary: Contains a list of links represented by the class link.|
|DisplayRightToLeft|Boolean|true|false |  |Indicates if the specified worksheet is displayed from right to left instead of from left to right.            Default is false. |
|DisplayZeros|Boolean|true|false |  |True if zero values are displayed. |
|FirstVisibleColumn|Integer|true|false |  |Represents first visible column index. |
|FirstVisibleRow|Integer|true|false |  |Represents first visible row index. |
|Name|String|true|false |  |Gets or sets the name of the worksheet. |
|Index|Integer|true|false |  |Gets the index of sheet in the worksheet collection. |
|IsGridlinesVisible|Boolean|true|false |  |Gets or sets a value indicating whether the gridlines are visible.Default is true. |
|IsOutlineShown|Boolean|true|false |  |Indicates whether to show outline. |
|IsPageBreakPreview|Boolean|true|false |  |Indicates whether the specified worksheet is shown in normal view or page break preview. |
|IsVisible|Boolean|true|false |  |Represents if the worksheet is visible. |
|IsProtected|Boolean|true|false |  |Indicates if the worksheet is protected. |
|IsRowColumnHeadersVisible|Boolean|true|false |  |Gets or sets a value indicating whether the worksheet will display row and column headers.            Default is true. |
|IsRulerVisible|Boolean|true|false |  |Indicates whether the ruler is visible. This property is only applied for page break preview. |
|IsSelected|Boolean|true|false |  |Indicates whether this worksheet is selected when the workbook is opened. |
|TabColor|Class|true|false |  |Represents worksheet tab color. |
|TransitionEntry|Boolean|true|false |  |Indicates whether the Transition Formula Entry (Lotus compatibility) option is enabled. |
|TransitionEvaluation|Boolean|true|false |  |Indicates whether the Transition Formula Evaluation (Lotus compatibility) option is enabled. |
|Type|String|true|false |  |Represents worksheet type. |
|ViewType|String|true|false |  |Gets and sets the view type. |
|VisibilityType|String|true|false |  |Indicates the visible state for this sheet. |
|Zoom|Integer|true|false |  |Represents the scaling factor in percentage. It should be between 10 and 400. |
|Cells|Class|true|false |  |Gets the  collection. |
|Charts|Class|true|false |  |Gets a  collection |
|AutoShapes|Class|true|false |  ||
|OleObjects|Class|true|false |  |Represents a collection of  in a worksheet. |
|Comments|Class|true|false |  |Gets the  collection. |
|Pictures|Class|true|false |  |Gets a  collection. |
|MergedCells|Class|true|false |  ||
|Validations|Class|true|false |  |Gets the data validation setting collection in the worksheet. |
|ConditionalFormattings|Class|true|false |  |Gets the ConditionalFormattings in the worksheet. |
|Hyperlinks|Class|true|false |  |Gets the  collection. |

