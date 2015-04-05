using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using SurveyLine.Form;
using SurveyLine.Properties;

namespace SurveyLine
{
    class Utilities
    {
        public static void WriteDataTable(DataTable sourceTable, TextWriter writer, bool includeHeaders, string delimiter, string numformat)
        {

            if (includeHeaders)
            {
                var headerValues = new List<string>();

                headerValues.Add(sourceTable.Columns[1].ColumnName);
                headerValues.Add(sourceTable.Columns[2].ColumnName);
                headerValues.Add(sourceTable.Columns[0].ColumnName);
                

                writer.WriteLine(String.Join(delimiter, headerValues.ToArray()));
            }

            var format = "{0:" + numformat + "}{1}{2:" + numformat +"}{1}{3}";
            foreach (DataRow row in sourceTable.Rows)
            {
                string item = string.Format(format, row[1], delimiter, row[2],
                    row[0]);
                writer.WriteLine(item);
            }

            writer.Flush();
        }

        public static DataTable GenerateBlankTable(int rowcount)
        {
            var dtable = new DataTable();

            var dcolumn = new DataColumn {ColumnName = "Stations"};
            dtable.Columns.Add(dcolumn);

            dcolumn = new DataColumn {ColumnName = "X-Coor"};
            dtable.Columns.Add(dcolumn);

            dcolumn = new DataColumn {ColumnName = "Y-Coor"};
            dtable.Columns.Add(dcolumn);

            for (var i = 0; i < rowcount; i++)
            {
                var dataRow = dtable.NewRow();
                dtable.Rows.Add(dataRow);
            }

            return dtable;

        }

        public static void FeatureUnavailable()
        {
            BetterDialog.ShowDialog("Sorry", "Feature Unavailable", "I am sorry to tell you that this feature is currently still under development.",
                null, "Close", null);
        }
    }
}
