using System;
using System.Collections.Generic;
using System.Linq;

namespace SurveyLine.Core
{
    public class SurveyPoint
    {
        public string Name { get; private set; }
        public double X { get; private set; }
        public double Y { get; private set; }

        public SurveyPoint(double x, double y, string name="Undefined")
        {
            X = x;
            Y = y;
            Name = name;
        }

        public void SetName(string name)
        {
            Name = name;
        }
        
    }
    public class SurveyPointList
    {
        private readonly List<SurveyPoint> _pointList;

        public SurveyPointList()
        {
            _pointList = new List<SurveyPoint>();
        }

        public void Add(SurveyPoint point)
        {
            _pointList.Add(point);

        }

        public List<SurveyPoint> ToList()
        {
            return _pointList;
        }

        public override string ToString()
        {
            return string.Join(Environment.NewLine, ToList().Select(point => string.Format("{0}\t{1:F6}\t{2:F6}", point.Name, point.X, point.Y)).ToArray());
        }
    }
}