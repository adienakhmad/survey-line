using System;
using System.Collections.Generic;
using System.Linq;

namespace SurveyLine.Core
{
    public class SurveyPointList
    {
        public SurveyDesign Design { get; private set; }
        private readonly List<SurveyPoint> _pointList;

        public SurveyPointList(SurveyDesign design)
        {
            _pointList = new List<SurveyPoint>();
            Design = design;
        }

        internal void Add(SurveyPoint point)
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