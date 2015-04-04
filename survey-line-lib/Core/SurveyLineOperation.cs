using System;

namespace SurveyLine.Core
{
    public static class SurveyLineOperation
    {
        /// <summary>
        /// Project survey point to specified bearing and distance.
        /// </summary>
        /// <param name="point"></param>
        /// <param name="bearing"></param>
        /// <param name="distance"></param>
        /// <param name="newname"></param>
        /// <returns></returns>
        static public SurveyPoint ProjectSurveyPoint(SurveyPoint point, double bearing, double distance, string newname="New Projected")
        {
            var x = point.X;
            var y = point.Y;

            var xProj = x + (distance*Math.Sin(ToRadians(bearing)));
            var yProj = y + (distance*Math.Cos(ToRadians(bearing)));

            return new SurveyPoint(xProj, yProj, newname);
        }

        /// <summary>
        /// Generate SurveyPointList from a SurveyDesign object
        /// </summary>
        /// <param name="design"></param>
        /// <param name="nameDesign"></param>
        /// <returns></returns>
        static public SurveyPointList GenerateSurveyPointList(SurveyDesign design, SurveyNamingDesign nameDesign)
        {
            SurveyPointList surveyPointList = new SurveyPointList();

            switch (design.Type)
            {
                #region DesignType.SingleLine
                case SurveyDesign.DesignType.SingleLine:
                    var staNumber = nameDesign.StationStartingIndex;
                    var surveyPoint = new SurveyPoint(design.XStart, design.YStart, PointNameGenerator(design,nameDesign,staNumber));
                    surveyPointList.Add(surveyPoint);

                    for (int i = 0; i < design.StationCount; i++)
                    {
                        if (i == 0) continue; // skip the first point
            
                        surveyPoint = ProjectSurveyPoint(surveyPoint, design.Bearing, design.Interval);
                        surveyPoint.SetName(PointNameGenerator(design, nameDesign, staNumber + i));

                        surveyPointList.Add(surveyPoint);
                    }

                    break;
                #endregion
                
                #region DesignType.MultiLine
                
                case SurveyDesign.DesignType.MultiLine:
                    // TODO : Implement MultiLine mode
                    break;
                #endregion

                #region DesignType.FixedGrid
                case SurveyDesign.DesignType.FixedGrid:
                    // TODO : Implement Fixed Grid mode
                    break;
                #endregion
            }

            return surveyPointList;
        }

        /// <summary>
        /// Simple functio to convert from degree to radians
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        static private double ToRadians(double number)
        {
            return number*(Math.PI/180.00d);
        }

        /// <summary>
        /// Return a specialized numbering. Alphabet numbering or Standard Numbering
        /// </summary>
        /// <param name="design"></param>
        /// <param name="number"></param>
        /// <returns></returns>
        static private string LineNameGenerator(SurveyNamingDesign design, int number)
        {
            string returnedName;
            switch (design.LineIndexType)
            {
                    case SurveyNamingDesign.IndexType.Alphabet:
                        int dividend = number;
                        string lineName = String.Empty;
                        int modulo;

                        while (dividend > 0)
                        {
                            modulo = (dividend - 1) % 26;
                            lineName = Convert.ToChar(65 + modulo).ToString() + lineName;
                            dividend = (dividend - modulo) / 26;
                        }
                        returnedName = lineName;
                        break;
                    case SurveyNamingDesign.IndexType.Number:
                        returnedName = number.ToString();
                        break;
                default:
                    returnedName = number.ToString();
                        break;

            }
            return returnedName;
        }

        /// <summary>
        /// This function return an automated survey point naming.
        /// </summary>
        /// <param name="design"></param>
        /// <param name="nameDesign"></param>
        /// <param name="staindex"></param>
        /// <param name="lineindex"></param>
        /// <returns></returns>
        static private string PointNameGenerator(SurveyDesign design, SurveyNamingDesign nameDesign, int staindex, int lineindex=0)
        {
            string pointname;
            switch (design.Type)
            {
                case SurveyDesign.DesignType.SingleLine:
                    pointname = string.Format("{0}{1}{2}", design.Name, nameDesign.PointsSeparator, staindex.ToString());
                    break;
                case SurveyDesign.DesignType.MultiLine:
                case SurveyDesign.DesignType.FixedGrid:
                    pointname = string.Format("{0}{1}{2}{3}{4}", design.Name, nameDesign.LineSeparator, LineNameGenerator(nameDesign, lineindex), nameDesign.PointsSeparator, staindex.ToString());
                    break;
                default:
                    pointname = string.Empty;
                    break;
            }

            return pointname;
        }

//        static public string DebugPointNameGenerator(SurveyDesign design, int staindex, int lineindex = 0)
//        {
//            return PointNameGenerator(design, staindex, lineindex);
//        }
    }
}