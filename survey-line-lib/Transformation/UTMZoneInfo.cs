using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace SurveyLineLib.Transformation
{
    public static class UTMZoneInfo
    {
        public static ReadOnlyCollection<UTMZone> GetAllZones()
        {
            var utmZones = new List<UTMZone>();

            for (int i = 0; i < 60; i++)
            {
                var zoneNumber = i + 1;
                var isNorth = true;

                for (int j = 0; j < 2; j++)
                {
                    var zone = new UTMZone(zoneNumber, isNorth);
                    utmZones.Add(zone);
                    isNorth = !isNorth;    
                }
            }

            var zones = new ReadOnlyCollection<UTMZone>(utmZones);
            return zones;

        }
    }
}