using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace SurveyLine.Transformation
{
    public class UTMZone
    {
        public bool IsNorthHemisphere { get; set; }

        public int Zone { get; set; }

        public string DisplayName { get; set; }

        public UTMZone(int mzone, bool hemisphere)
        {
            IsNorthHemisphere = hemisphere;
            Zone = mzone;

            if (IsNorthHemisphere)
            {
                DisplayName = "WGS84 UTM Zone " + Zone.ToString("00") + "N";
            }
            else
            {
                DisplayName = "WGS84 UTM Zone " + Zone.ToString("00") + "S";
            }
            

        }
    }

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
