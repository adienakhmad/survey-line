using ProjNet.CoordinateSystems;
using ProjNet.CoordinateSystems.Transformations;
using SurveyLine.Core;

namespace SurveyLine.Transformation
{
    public static class WGS84Transformation
    {
        public static Core.StationList ToWGS84Geographic(this Core.StationList line, UTMZone zone)
        {
            var surveyPointList = new Core.StationList();
            var utmzone = zone;

            IGeographicCoordinateSystem geo = GeographicCoordinateSystem.WGS84;
            IProjectedCoordinateSystem utm = ProjectedCoordinateSystem.WGS84_UTM(utmzone.Zone, utmzone.IsNorthHemisphere);
            CoordinateTransformationFactory ctf = new CoordinateTransformationFactory();
            ICoordinateTransformation trans = ctf.CreateFromCoordinateSystems(utm, geo);

            foreach (var point in line.GetStations())
            {
                double[] fromPoint = {point.X, point.Y};
                double[] toPoint = trans.MathTransform.Transform(fromPoint);

                var surveyPoint = new Station(toPoint[0], toPoint[1], point.Name);
                surveyPointList.Add(surveyPoint);
            }

            return surveyPointList;
        }
    }
}
