#nullable disable

using System;

namespace ClosedXML.Excel
{
    public interface IXLPivotTable
    {
        XLPivotTableTheme Theme { get; set; }

        IXLPivotFields ReportFilters { get; }

        /// <summary>
        /// Labels displayed in columns (i.e. horizontal axis) of the pivot table.
        /// </summary>
        IXLPivotFields ColumnLabels { get; }

        /// <summary>
        /// Labels displayed in rows (i.e. vertical axis) of the pivot table.
        /// </summary>
        IXLPivotFields RowLabels { get; }
        IXLPivotValues Values { get; }

        String Name { get; set; }
        String Title { get; set; }
        String Description { get; set; }

        String ColumnHeaderCaption { get; set; }
        String RowHeaderCaption { get; set; }

        /// <summary>
        /// Top left corner cell of a pivot table. If the pivot table contains filters fields, the target cell is top
        /// left cell of the first filter field.
        /// </summary>
        IXLCell TargetCell { get; set; }

        /// <summary>
        /// The cache of data for the pivot table. The pivot table is created
        /// from cached data, not up-to-date data in a worksheet.
        /// </summary>
        IXLPivotCache PivotCache { get; set; }

        Boolean MergeAndCenterWithLabels { get; set; } // MergeItem
        Int32 RowLabelIndent { get; set; } // Indent

        /// <summary>
        /// Filter fields layout setting that indicates layout order of filter fields. The layout
        /// uses <see cref="FilterFieldsPageWrap"/> to determine when to break to a new row or
        /// column. Default value is <see cref="XLFilterAreaOrder.DownThenOver"/>.
        /// </summary>
        XLFilterAreaOrder FilterAreaOrder { get; set; }

        /// <summary>
        /// Specifies the number of page fields to display before starting another row or column.
        /// Value = 0 means unlimited.
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">If value &lt; 0.</exception>
        Int32 FilterFieldsPageWrap { get; set; } // PageWrap
        String ErrorValueReplacement { get; set; } // ErrorCaption
        String EmptyCellReplacement { get; set; } // MissingCaption
        Boolean AutofitColumns { get; set; } //UseAutoFormatting
        Boolean PreserveCellFormatting { get; set; } // PreserveFormatting

        Boolean ShowGrandTotalsRows { get; set; } // RowGrandTotals
        Boolean ShowGrandTotalsColumns { get; set; } // ColumnGrandTotals
        Boolean FilteredItemsInSubtotals { get; set; } // Subtotal filtered page items
        Boolean AllowMultipleFilters { get; set; } // MultipleFieldFilters
        Boolean UseCustomListsForSorting { get; set; } // CustomListSort

        Boolean ShowExpandCollapseButtons { get; set; }
        Boolean ShowContextualTooltips { get; set; }
        Boolean ShowPropertiesInTooltips { get; set; }
        Boolean DisplayCaptionsAndDropdowns { get; set; }
        Boolean ClassicPivotTableLayout { get; set; }
        Boolean ShowValuesRow { get; set; }
        Boolean ShowEmptyItemsOnRows { get; set; }
        Boolean ShowEmptyItemsOnColumns { get; set; }
        Boolean DisplayItemLabels { get; set; }
        Boolean SortFieldsAtoZ { get; set; }

        Boolean PrintExpandCollapsedButtons { get; set; }
        Boolean RepeatRowLabels { get; set; }
        Boolean PrintTitles { get; set; }

        Boolean EnableShowDetails { get; set; }
        Boolean EnableCellEditing { get; set; }

        IXLPivotTable CopyTo(IXLCell targetCell);

        IXLPivotTable SetName(String value);

        IXLPivotTable SetTitle(String value);

        IXLPivotTable SetDescription(String value);

        IXLPivotTable SetMergeAndCenterWithLabels(); IXLPivotTable SetMergeAndCenterWithLabels(Boolean value);

        IXLPivotTable SetRowLabelIndent(Int32 value);

        IXLPivotTable SetFilterAreaOrder(XLFilterAreaOrder value);

        IXLPivotTable SetFilterFieldsPageWrap(Int32 value);

        IXLPivotTable SetErrorValueReplacement(String value);

        IXLPivotTable SetEmptyCellReplacement(String value);

        IXLPivotTable SetAutofitColumns(); IXLPivotTable SetAutofitColumns(Boolean value);

        IXLPivotTable SetPreserveCellFormatting(); IXLPivotTable SetPreserveCellFormatting(Boolean value);

        IXLPivotTable SetShowGrandTotalsRows(); IXLPivotTable SetShowGrandTotalsRows(Boolean value);

        /// <summary>
        /// Should pivot table display a grand total for each row in the last column of a pivot
        /// table (it will enlarge pivot table for extra column).
        /// </summary>
        /// <remarks>
        /// This API has inverse row/column names than the Excel. Excel: <em>On for rows
        /// </em> should use this method <em>ShowGrandTotalsColumns</em>.
        /// </remarks>
        IXLPivotTable SetShowGrandTotalsColumns(); IXLPivotTable SetShowGrandTotalsColumns(Boolean value);

        IXLPivotTable SetFilteredItemsInSubtotals(); IXLPivotTable SetFilteredItemsInSubtotals(Boolean value);

        IXLPivotTable SetAllowMultipleFilters(); IXLPivotTable SetAllowMultipleFilters(Boolean value);

        IXLPivotTable SetUseCustomListsForSorting(); IXLPivotTable SetUseCustomListsForSorting(Boolean value);

        IXLPivotTable SetShowExpandCollapseButtons(); IXLPivotTable SetShowExpandCollapseButtons(Boolean value);

        IXLPivotTable SetShowContextualTooltips(); IXLPivotTable SetShowContextualTooltips(Boolean value);

        IXLPivotTable SetShowPropertiesInTooltips(); IXLPivotTable SetShowPropertiesInTooltips(Boolean value);

        IXLPivotTable SetDisplayCaptionsAndDropdowns(); IXLPivotTable SetDisplayCaptionsAndDropdowns(Boolean value);

        IXLPivotTable SetClassicPivotTableLayout(); IXLPivotTable SetClassicPivotTableLayout(Boolean value);

        IXLPivotTable SetShowValuesRow(); IXLPivotTable SetShowValuesRow(Boolean value);

        IXLPivotTable SetShowEmptyItemsOnRows(); IXLPivotTable SetShowEmptyItemsOnRows(Boolean value);

        IXLPivotTable SetShowEmptyItemsOnColumns(); IXLPivotTable SetShowEmptyItemsOnColumns(Boolean value);

        IXLPivotTable SetDisplayItemLabels(); IXLPivotTable SetDisplayItemLabels(Boolean value);

        IXLPivotTable SetSortFieldsAtoZ(); IXLPivotTable SetSortFieldsAtoZ(Boolean value);

        IXLPivotTable SetPrintExpandCollapsedButtons(); IXLPivotTable SetPrintExpandCollapsedButtons(Boolean value);

        IXLPivotTable SetRepeatRowLabels(); IXLPivotTable SetRepeatRowLabels(Boolean value);

        IXLPivotTable SetPrintTitles(); IXLPivotTable SetPrintTitles(Boolean value);


        IXLPivotTable SetEnableShowDetails(); IXLPivotTable SetEnableShowDetails(Boolean value);



        IXLPivotTable SetEnableCellEditing(); IXLPivotTable SetEnableCellEditing(Boolean value);

        IXLPivotTable SetColumnHeaderCaption(String value);

        IXLPivotTable SetRowHeaderCaption(String value);

        Boolean ShowRowHeaders { get; set; }
        Boolean ShowColumnHeaders { get; set; }
        Boolean ShowRowStripes { get; set; }
        Boolean ShowColumnStripes { get; set; }
        XLPivotSubtotals Subtotals { get; set; }
        XLPivotLayout Layout { set; }
        Boolean InsertBlankLines { set; }

        IXLPivotTable SetShowRowHeaders(); IXLPivotTable SetShowRowHeaders(Boolean value);

        IXLPivotTable SetShowColumnHeaders(); IXLPivotTable SetShowColumnHeaders(Boolean value);

        IXLPivotTable SetShowRowStripes(); IXLPivotTable SetShowRowStripes(Boolean value);

        IXLPivotTable SetShowColumnStripes(); IXLPivotTable SetShowColumnStripes(Boolean value);

        IXLPivotTable SetSubtotals(XLPivotSubtotals value);

        IXLPivotTable SetLayout(XLPivotLayout value);

        IXLPivotTable SetInsertBlankLines(); IXLPivotTable SetInsertBlankLines(Boolean value);

        IXLWorksheet Worksheet { get; }

        IXLPivotTableStyleFormats StyleFormats { get; }
    }
}
