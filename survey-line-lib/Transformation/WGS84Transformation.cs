using ProjNet.CoordinateSystems;
using ProjNet.CoordinateSystems.Transformations;
using SurveyLine.Core;

namespace SurveyLine.Transformation
{
    public static class WGS84Transformation
    {
        public static SurveyPointList ToWGS84Geographic(this SurveyPointList pointList, UTMZone zone)
        {
            var surveyPointList = new SurveyPointList(pointList.Design);
            var utmzone = zone;

            IGeographicCoordinateSystem geo = GeographicCoordinateSystem.WGS84;
            IProjectedCoordinateSystem utm = ProjectedCoordinateSystem.WGS84_UTM(utmzone.Zone, utmzone.IsNorthHemisphere);
            CoordinateTransformationFactory ctf = new CoordinateTransformationFactory();
            ICoordinateTransformation trans = ctf.CreateFromCoordinateSystems(utm, geo);

            foreach (var point in pointList.ToList())
            {
                double[] fromPoint = {point.X, point.Y};
                double[] toPoint = trans.MathTransform.Transform(fromPoint);

                var surveyPoint = new SurveyPoint(toPoint[0], toPoint[1], point.Name);
                surveyPointList.Add(surveyPoint);
            }

            return surveyPointList;
        }
    }
}
