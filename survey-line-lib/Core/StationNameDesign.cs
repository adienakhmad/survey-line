namespace SurveyLine.Core
{
    public class StationNameDesign
    {
        public enum IndexType { Number, Alphabet }
        public int LineStartingIndex { get; set; }
        public int StationStartingIndex { get; set; }
        public string PointsSeparator { get; set; }
        public string LineSeparator { get; set; }
        public IndexType LineIndexType { get; set; }

        /// <summary>
        /// Default Constructor with default naming design
        /// </summary>
        public StationNameDesign()
        {
            SetNamingDefault();
        }

        /// <summary>
        /// Constructor with custom naming design.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="lineSeparator"></param>
        /// <param name="pointSeparator"></param>
        /// <param name="lineStartIndex"></param>
        /// <param name="stationStartIndex"></param>
        public StationNameDesign(IndexType type, string lineSeparator, string pointSeparator, int lineStartIndex,
            int stationStartIndex)
        {
            LineIndexType = type;
            LineSeparator = lineSeparator;
            PointsSeparator = pointSeparator;
            LineStartingIndex = lineStartIndex;
            StationStartingIndex = stationStartIndex;
        }

        /// <summary>
        /// Set Default Naming Design
        /// </summary>
        private void SetNamingDefault()
        {
            LineIndexType = IndexType.Alphabet;
            LineSeparator = "-";
            PointsSeparator = "-";
            StationStartingIndex = 1;
            LineStartingIndex = 1;
        }
    }
}
