using System;
using System.Collections.Generic;
using System.Linq;

namespace SurveyLine.Core
{
    public class StationList
    {
        private readonly List<Station> _pointList;

        public StationList(IEnumerable<Station> points)
        {
            _pointList = points.ToList();
        }

        public StationList()
        {
            _pointList = new List<Station>();
        }

        internal void Add(Station station)
        {
            _pointList.Add(station);
        }

        public List<Station> GetStations()
        {
            return _pointList;
        }

        public override string ToString()
        {
            return string.Join(Environment.NewLine, GetStations().Select(point => string.Format("{0}\t{1:F6}\t{2:F6}", point.Name, point.X, point.Y)).ToArray());
        }
    }
}