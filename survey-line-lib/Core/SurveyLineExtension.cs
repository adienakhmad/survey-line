using System;
using System.Collections.Generic;
using System.IO;
using SurveyLine.Ex;

namespace SurveyLine.Core
{
    public static class SurveyLineExtension
    {
        /// <summary>
        /// Simple functio to convert from degree to radians
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        static private double ToRadians(double number)
        {
            return number * (Math.PI / 180.0);
        }

        /// <summary>
        /// This function return an automated survey point naming.
        /// </summary>
        /// <param name="design"></param>
        /// <param name="nameDesign"></param>
        /// <param name="staindex"></param>
        /// <param name="lineindex"></param>
        /// <returns></returns>
        static private string CreateStationNamebyDesign(SurveyDesign design, StationNameDesign nameDesign, int staindex, int lineindex=0)
        {
            var stationLeadingZeroFormat = string.Format("D{0}", design.StationCount.ToString().Length);
            var lineDigitCount = design.LineCount.ToString().Length;
            string pointname;
            switch (design.Type)
            {
                case SurveyDesign.DesignType.SingleLine:
                    pointname = string.Format("{0}{1}{2}", design.Name, nameDesign.PointsSeparator, staindex.ToString(stationLeadingZeroFormat));
                    break;
                case SurveyDesign.DesignType.MultiLine:
                case SurveyDesign.DesignType.FixedGrid:
                    pointname = string.Format("{0}{1}{2}{3}{4}", design.Name, nameDesign.LineSeparator, CreateLineNamebyDesign(nameDesign, lineindex, lineDigitCount), nameDesign.PointsSeparator, staindex.ToString(stationLeadingZeroFormat));
                    break;
                default:
                    pointname = string.Empty;
                    break;
            }

            return pointname;
        }

        /// <summary>
        /// Return a specialized numbering. Alphabet numbering or Standard Numbering
        /// </summary>
        /// <param name="design"></param>
        /// <param name="number"></param>
        /// <param name="digitCount"></param>
        /// <returns></returns>
        static private string CreateLineNamebyDesign(StationNameDesign design, int number, int digitCount)
        {
            string leadingZeroFormat = string.Format("D{0}", digitCount);
            string returnedName;
            switch (design.LineIndexType)
            {
                case StationNameDesign.IndexType.Alphabet:
                    int dividend = number;
                    string lineName = String.Empty;

                    while (dividend > 0)
                    {
                        var modulo = (dividend - 1) % 26;
                        lineName = Convert.ToChar(65 + modulo).ToString() + lineName; // starts with char(65) = A
                        dividend = (dividend - modulo) / 26;
                    }
                    returnedName = lineName;
                    break;
                case StationNameDesign.IndexType.Number:
                    returnedName = number.ToString(leadingZeroFormat);
                    break;
                default:
                    returnedName = number.ToString(leadingZeroFormat);
                    break;

            }
            return returnedName;
        }

        /// <summary>
        /// Project survey point to specified bearing and distance.
        /// </summary>
        /// <param name="point"></param>
        /// <param name="bearing"></param>
        /// <param name="distance"></param>
        /// <returns></returns>
        static public SurveyPoint ProjectTo(this SurveyPoint point, double bearing, double distance)
        {
            var x = point.X;
            var y = point.Y;

            var xProj = x + (distance*Math.Sin(ToRadians(bearing)));
            var yProj = y + (distance*Math.Cos(ToRadians(bearing)));

            return new SurveyPoint(xProj, yProj, String.Format("{0} Projected",point.Name));
        }

        /// <summary>
        /// Generate SurveyPointList from a factory object.
        /// </summary>
        /// <param name="factory"></param>
        /// <returns></returns>
        static public SurveyPointList BuildSurveyPoints(this SurveyFactory factory)
        {
            var design = factory.Design;
            var nameDesign = factory.NamingDesign;

//          throw ZeroIntervalException if interval is zero
            if (Math.Abs(design.Interval) < 1e-12) throw new ZeroIntervalException();

            var surveyPointList = new SurveyPointList(design);
            var startPoint = new SurveyPoint(design.XStart, design.YStart);
            var stationStartingIndex = nameDesign.StationStartingIndex;
            var lineStartingIndex = nameDesign.LineStartingIndex;

            switch (design.Type)
            {
                #region DesignType.SingleLine
                case SurveyDesign.DesignType.SingleLine:

                    for (int i = 0; i < design.StationCount; i++)
                    {
                        var point = ProjectTo(startPoint, design.Bearing, (i+1) * design.Interval);
                        point.SetName(CreateStationNamebyDesign(design, nameDesign, stationStartingIndex + i));
                        surveyPointList.Add(point);
                    }

                    break;
                #endregion
                
                #region DesignType.MultiLine
                case SurveyDesign.DesignType.MultiLine:
                    for (int j = 0; j < design.LineCount; j++)
                    {
                        var lineFirstPoint = ProjectTo(startPoint, design.Bearing + design.PlusBearing,
                            j * design.LineSpacing);

                        for (int i = 0; i < design.StationCount; i++)
                        {
                            var point = ProjectTo(lineFirstPoint, design.Bearing, i * design.Interval);
                            point.SetName(CreateStationNamebyDesign(design, nameDesign, stationStartingIndex + i, lineStartingIndex + j));
                            surveyPointList.Add(point);
                        }
                    }
                    break;
                #endregion

                #region DesignType.FixedGrid
                case SurveyDesign.DesignType.FixedGrid:
                    for (int j = 0; j < design.LineCount; j++)
                    {
                        var lineFirstPoint = ProjectTo(startPoint, design.Bearing + design.PlusBearing,
                            j * design.Interval);

                        for (int i = 0; i < design.StationCount; i++)
                        {
                            var point = ProjectTo(lineFirstPoint, design.Bearing, i * design.Interval);
                            point.SetName(CreateStationNamebyDesign(design, nameDesign, stationStartingIndex + i, lineStartingIndex + j));
                            surveyPointList.Add(point);
                        }
                    }
                    break;
                #endregion
            }

            return surveyPointList;
        }

        /// <summary>
        /// Export the Points List to text file with delimiter
        /// </summary>
        /// <param name="points"></param>
        /// <param name="filename"></param>
        /// <param name="delimiter"></param>
        public static void ExportToText(this SurveyPointList points, string filename, string delimiter="\t")
        {
            var writer = new StreamWriter(filename);
            writer.WriteLine();
            writer.WriteLine("X-Position{0}Y-Position{0}Station", delimiter);

            var str = new List<string>();
            foreach (var surveyPoint in points.ToList())
            {
                str.Add(String.Format("{0,10:F6}", surveyPoint.X));
                str.Add(String.Format("{0,10:F6}", surveyPoint.Y));
                str.Add(String.Format("{0}", surveyPoint.Name));

                writer.WriteLine(string.Join(delimiter,str.ToArray()));
                str.Clear();
            }

            writer.Flush();
            writer.Close();

        }
    }
}