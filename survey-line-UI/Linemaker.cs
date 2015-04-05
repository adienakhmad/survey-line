/*
 * Created by SharpDevelop.
 * User: SamsungNC108
 * Date: 2/14/2014
 * Time: 12:50
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Data;

namespace SurveyLineUI
{
    /// <summary>
    ///     Description of Line.
    /// </summary>
    public class LineMaker
    {
        public LineMaker()
        {
            Name = "Unnamed";
            StaIndex = 1;
            LineIndex = 1;
            Delimiter = "\t";
            LineSeparator = "-";
            PointsSeparator = "-";
            DecimalPlaces = 2;
        }

        public string Name { get; set; }

        public double XStart { get; set; }

        public double YStart { get; set; }

        public double Bearing { get; set; }

        public double Interval { get; set; }

        public int Station { get; set; }

        public double DisplacementX { get; set; }

        public double DisplacementY { get; set; }

        public int LineCount { get; set; }

        public double LineSpacing { get; set; }

        public string Type { get; set; }

        public double PlusBearing { get; set; }

        public string LineSeparator { get; set; }

        public string PointsSeparator { get; set; }

        public string Delimiter { get; set; }

        public int StaIndex { get; set; }

        public int LineIndex { get; set; }

        public int DecimalPlaces { get; set; }

        public string NumericFormat
        {
            get { return string.Format("F{0}", DecimalPlaces); }
        }


        public DataTable GenerateTable(bool multimode)
        {
            var dTable = new DataTable();
            DataColumn dColumn;
            DataRow dRow;

            // first column
            dColumn = new DataColumn
            {
                DataType = System.Type.GetType("System.String"),
                ColumnName = "Stations",
                ReadOnly = true,
                Unique = true
            };
            dTable.Columns.Add(dColumn);

            // second column
            dColumn = new DataColumn
            {
                DataType = System.Type.GetType("System.Double"),
                ColumnName = "X-Coor",
                ReadOnly = true,
                Unique = false
            };
            dTable.Columns.Add(dColumn);

            // third column
            dColumn = new DataColumn
            {
                DataType = System.Type.GetType("System.Double"),
                ColumnName = "Y-Coor",
                ReadOnly = true,
                Unique = false
            };
            dTable.Columns.Add(dColumn);

            DisplacementX = Interval*Math.Sin(Bearing*(Math.PI/180.0f));
            DisplacementY = Interval*Math.Cos(Bearing*(Math.PI/180.0f));

            string staLeadingZeros = string.Format("D{0}", Station.ToString().Length);
            string lineLeadingZeros = string.Format("D{0}", LineCount.ToString().Length);

            if (multimode)
            {
                double directionChange = Bearing + PlusBearing;
                int lineIndex = LineIndex;

                for (int i = 0; i < LineCount; i++)
                {
                    int pointIndex = StaIndex;
                    double xBegin = XStart + (i*(LineSpacing*Math.Sin(directionChange*(Math.PI/180.0f))));
                    double yBegin = YStart + (i*(LineSpacing*Math.Cos(directionChange*(Math.PI/180.0f))));

                    for (int j = 0; j < Station; j++)
                    {
                        dRow = dTable.NewRow();
                        dRow[0] = string.Format("{0}{1}{2}{3}{4}", Name, LineSeparator,
                            lineIndex.ToString(lineLeadingZeros), PointsSeparator, pointIndex.ToString(staLeadingZeros));
                        dRow[1] = xBegin;
                        dRow[2] = yBegin;
                        dTable.Rows.Add(dRow);
                        xBegin += DisplacementX;
                        yBegin += DisplacementY;
                        pointIndex++;
                    }


                    lineIndex++;
                }
            }

            else
            {
                int pointIndex = StaIndex;
                for (int i = 0; i < Station; i++)
                {
                    dRow = dTable.NewRow();
                    dRow[0] = string.Format("{0}{1}{2}", Name, PointsSeparator, pointIndex.ToString(staLeadingZeros));
                    dRow[1] = XStart;
                    dRow[2] = YStart;
                    dTable.Rows.Add(dRow);
                    XStart += DisplacementX;
                    YStart += DisplacementY;
                    pointIndex++;
                }
            }


            return dTable;
        }
    }
}