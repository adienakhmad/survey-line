using System.Collections.Generic;

namespace SurveyLine.core
{
    class SurveyPoint
    {
        public string Name { get; private set; }
        public double X { get; private set; }
        public double Y { get; private set; }

        public SurveyPoint(double x, double y, string name)
        {
            X = x;
            Y = y;
            Name = name;
        }
        
    }
    class SurveyPointList
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
    }
}