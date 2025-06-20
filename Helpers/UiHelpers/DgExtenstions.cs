﻿using System.Windows.Forms;

namespace SalesPro.Helpers.UiHelpers
{
    public class DgExtensions
    {
        public static void ConfigureDataGrid(DataGridView dataGrid, bool setUpIdLink, int columnIndex, Label notFoundLabel, params string[] fieldsToShow)
        {
            // Apply basic formatting
            DgFormatHelper.BasicGridFormat(dataGrid);
            dataGrid.AutoFormat();

            // Set up ID link if needed
            if (setUpIdLink)
            {
                DgFormatHelper.SetupLinkId(dataGrid, columnIndex);
            }

            // Show only specified fields
            DgFormatHelper.ShowOnlyField(dataGrid, fieldsToShow);

            // Set visibility of notFoundLabel
            notFoundLabel.Visible = dataGrid.Rows.Count == 0;
        }
    }

}
