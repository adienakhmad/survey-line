using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        /// This function return an automated survey station naming.
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
                case SurveyDesign.DesignType.RectangularGrid:
                case SurveyDesign.DesignType.SquareGrid:
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
            var leadingZeroFormat = string.Format("D{0}", digitCount);
            string returnedName;
            switch (design.LineIndexType)
            {
                case StationNameDesign.IndexType.Alphabet:
                    var dividend = number;
                    var lineName = String.Empty;

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
        /// Project survey station to specified bearing and distance.
        /// </summary>
        /// <param name="station"></param>
        /// <param name="bearing"></param>
        /// <param name="distance"></param>
        /// <returns></returns>
        static public Station ProjectTo(this Station station, double bearing, double distance)
        {
            var x = station.X;
            var y = station.Y;

            var xProj = x + (distance*Math.Sin(ToRadians(bearing)));
            var yProj = y + (distance*Math.Cos(ToRadians(bearing)));

            return new Station(xProj, yProj, String.Format("{0} Projected",station.Name));
        }

        /// <summary>
        /// Generate StationList from a factory object.
        /// </summary>
        /// <param name="factory"></param>
        /// <returns></returns>
        static public StationListContainer BuildSurveyPoints(this SurveyFactory factory)
        {
            var design = factory.Design;
            if (design == null) throw new SurveyDesignNotFoundException();
            var nameDesign = factory.Naming;

//          throw ZeroIntervalException if spacing is zero
            if (Math.Abs(design.Interval) < 1e-12) throw new ZeroIntervalException("Spacing cannot be zero.");
            if (Math.Abs(design.LineSpacing) < 1e-12 && (design.Type == SurveyDesign.DesignType.MultiLine || design.Type == SurveyDesign.DesignType.MultiLine)) 
                throw new ZeroIntervalException("Line spacing cannot be zero.");

            StationList currentLine;
            List<StationList> lineCollection;
            var startPoint = new Station(design.XStart, design.YStart);
            var stationStartingIndex = nameDesign.StationStartingIndex;
            var lineStartingIndex = nameDesign.LineStartingIndex;

            switch (design.Type)
            {
                #region DesignType.SingleLine
                case SurveyDesign.DesignType.SingleLine:

                    currentLine = new StationList();
                    for (var i = 0; i < design.StationCount; i++)
                    {
                        var point = ProjectTo(startPoint, design.Bearing, i * design.Interval);
                        point.SetName(CreateStationNamebyDesign(design, nameDesign, stationStartingIndex + i));
                        currentLine.Add(point);
                    }

                    return new StationListContainer(design,currentLine);

                    #endregion
                
                #region DesignType.MultiLine
                case SurveyDesign.DesignType.MultiLine:

                    lineCollection = new List<StationList>();

                    for (var j = 0; j < design.LineCount; j++)
                    {
                        currentLine = new StationList();
                        var lineFirstPoint = ProjectTo(startPoint, design.Bearing + design.PlusBearing,
                            j * design.LineSpacing);

                        for (var i = 0; i < design.StationCount; i++)
                        {
                            var point = ProjectTo(lineFirstPoint, design.Bearing, i * design.Interval);
                            point.SetName(CreateStationNamebyDesign(design, nameDesign, stationStartingIndex + i, lineStartingIndex + j));
                            currentLine.Add(point);
                        }
                        lineCollection.Add(currentLine);
                    }
                    return new StationListContainer(design,lineCollection);

                    #endregion

                #region DesignType.RectangularGrid
                case SurveyDesign.DesignType.RectangularGrid:
                    lineCollection = new List<StationList>();
                    for (var j = 0; j < design.LineCount; j++)
                    {
                        currentLine = new StationList();

                        var lineFirstPoint = ProjectTo(startPoint, design.Bearing + design.PlusBearing,
                            j * design.Interval);

                        for (var i = 0; i < design.StationCount; i++)
                        {
                            var point = ProjectTo(lineFirstPoint, design.Bearing, i * design.Interval);
                            point.SetName(CreateStationNamebyDesign(design, nameDesign, stationStartingIndex + i, lineStartingIndex + j));
                            currentLine.Add(point);
                        }

                        lineCollection.Add(currentLine);
                    }

                    return new StationListContainer(design,lineCollection);
                #endregion

                #region DesignType.SquareGrid
                case SurveyDesign.DesignType.SquareGrid:
                    lineCollection = new List<StationList>();
                    for (var j = 0; j < design.StationCount; j++)
                    {
                        currentLine = new StationList();

                        var lineFirstPoint = ProjectTo(startPoint, design.Bearing + design.PlusBearing,
                            j * design.Interval);

                        for (var i = 0; i < design.StationCount; i++)
                        {
                            var point = ProjectTo(lineFirstPoint, design.Bearing, i * design.Interval);
                            point.SetName(CreateStationNamebyDesign(design, nameDesign, stationStartingIndex + i, stationStartingIndex + j));
                            Debug.WriteLine(CreateStationNamebyDesign(design, nameDesign, stationStartingIndex + i, stationStartingIndex + j));
                            currentLine.Add(point);
                        }

                        lineCollection.Add(currentLine);
                    }

                    return new StationListContainer(design, lineCollection);
                #endregion

                default:
                    throw new DesignTypeInvalidException("Design Type Unrecognized");
            }
            
        }

        /// <summary>
        /// Export the Points List to text file with delimiter
        /// </summary>
        /// <param name="points"></param>
        /// <param name="filename"></param>
        /// <param name="delimiter"></param>
        public static void ExportToText(this StationList points, string filename, string delimiter="\t")
        {
            var writer = new StreamWriter(filename);
            writer.WriteLine();
            writer.WriteLine("X-Position{0}Y-Position{0}Station", delimiter);

            var str = new List<string>();
            foreach (var surveyPoint in points.GetStations())
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