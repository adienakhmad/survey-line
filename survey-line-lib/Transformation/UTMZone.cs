namespace SurveyLineLib.Transformation
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
}
