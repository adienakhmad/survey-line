﻿using System;
using System.Collections.Generic;

namespace SurveyLine.Core
{
    public class SurveyDesign
    {
        public enum DesignType { SingleLine, MultiLine, FixedGrid}
        

        #region Field Declaration

        public DesignType Type { get; private set; }
        public string Name { get; set; }

        public double XStart { get; set; }

        public double YStart { get; set; }

        public double Bearing { get; set; }

        public double Interval { get; set; }

        public int StationCount { get; set; }

        public int LineCount { get; set; }

        public double LineSpacing { get; set; }

        public double PlusBearing { get; set; }

        #endregion

        #region Constructor
        /// <summary>
        /// SurveyDesign constructor for SingleLine mode.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="xStart"></param>
        /// <param name="yStart"></param>
        /// <param name="bearing"></param>
        /// <param name="interval"></param>
        /// <param name="stationCount"></param>
        public SurveyDesign(string name, double xStart, double yStart, double bearing, double interval, int stationCount)
        {
            Type = DesignType.SingleLine;
            Name = name;
            XStart = xStart;
            YStart = yStart;
            Bearing = bearing;
            Interval = interval;
            StationCount = stationCount;
            LineCount = 1;
        }

        /// <summary>
        /// Constructor for MultiLine mode
        /// </summary>
        /// <param name="name"></param>
        /// <param name="xStart"></param>
        /// <param name="yStart"></param>
        /// <param name="bearing"></param>
        /// <param name="interval"></param>
        /// <param name="stationCount"></param>
        /// <param name="plusBearing"></param>
        /// <param name="lineCount"></param>
        /// <param name="lineSpacing"></param>
        public SurveyDesign(string name, double xStart, double yStart, double bearing, double interval, int stationCount,  double plusBearing, int lineCount, double lineSpacing)
        {
            Type = DesignType.MultiLine;
            Name = name;
            XStart = xStart;
            YStart = yStart;
            Bearing = bearing;
            Interval = interval;
            StationCount = stationCount;
            LineCount = lineCount;
            LineSpacing = lineSpacing;
            PlusBearing = plusBearing;
        }

        /// <summary>
        /// Constructor for Fixed Grid mode.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="xStart"></param>
        /// <param name="yStart"></param>
        /// <param name="bearing"></param>
        /// <param name="interval"></param>
        /// <param name="stationCount"></param>
        /// <param name="plusBearing"></param>
        /// <param name="lineCount"></param>
        public SurveyDesign(string name, double xStart, double yStart, double bearing, double interval, int stationCount, double plusBearing, int lineCount)
        {
            Type = DesignType.FixedGrid;
            Name = name;
            XStart = xStart;
            YStart = yStart;
            Bearing = bearing;
            Interval = interval;
            StationCount = stationCount;
            LineCount = lineCount;
            LineSpacing = Interval;
            PlusBearing = plusBearing;
        }
        #endregion

        #region Methods

        public override string ToString()
        {
            var str = new List<String>
            {
                string.Format("Type: {0}", Type),
                string.Format("X0 : {0}", XStart),
                string.Format("Y0 : {0}", YStart),
                string.Format("Bearing: {0}", Bearing),
                string.Format("Inteval: {0}", Interval),
                string.Format("Num of stations: {0}", StationCount),
                string.Format("Num of lines: {0}", LineCount),
                string.Format("Line spacing: {0}", LineSpacing),
                string.Format("Plus Bearing: {0}", PlusBearing)
            };


            return string.Join(Environment.NewLine, str.ToArray());
        }

        #endregion
    }
}
