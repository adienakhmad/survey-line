using System;

namespace SurveyLine.Core
{
    public static class SurveyPointOperation
    {
        static private double ToRadians(double number)
        {
            return number*(Math.PI/180.00d);
        }

        static public SurveyPoint ProjectLocation(SurveyPoint point, double bearing, double distance, string newname="New Projected")
        {
            var x = point.X;
            var y = point.Y;

            var xProj = x + (distance*Math.Sin(ToRadians(bearing)));
            var yProj = y + (distance*Math.Cos(ToRadians(bearing)));

            return new SurveyPoint(xProj, yProj, newname);
        }
    }
}