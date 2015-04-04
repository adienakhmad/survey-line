namespace SurveyLine.core
{
    class SurveyLineDesign
    {
        #region Field Declaration
        public string Name { get; set; }

        public double XStart { get; set; }

        public double YStart { get; set; }

        public double Bearing { get; set; }

        public double Interval { get; set; }

        public int StationCount { get; set; }

        public double DisplacementX { get; set; }

        public double DisplacementY { get; set; }

        public int LineCount { get; set; }

        public double LineSpacing { get; set; }

        public string Type { get; set; }

        public double PlusBearing { get; set; }

        public string LineSeparator { get; set; }

        public string PointsSeparator { get; set; }

        public string Delimiter { get; set; }

        public int StaIndex { get; set; }

        public int LineIndex { get; set; }

        public int DecimalPlaces { get; set; }

        #endregion
    }
}
