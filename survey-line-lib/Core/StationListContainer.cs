using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace SurveyLine.Core
{
    public class StationListContainer
    {
        private readonly ReadOnlyCollection<StationList> _lines;

        public ReadOnlyCollection<StationList> Lines
        {
            get { return _lines; }
        }

        private readonly SurveyDesign _design;

        public SurveyDesign Design
        {
            get { return _design; }
        }

        public StationListContainer(SurveyDesign design, IEnumerable<StationList> lines )
        {
            _design = design;
            _lines = new ReadOnlyCollection<StationList>(lines.ToList());
        }

        public StationListContainer(SurveyDesign design, StationList singleLine)
        {
            _design = design;
            _lines = new ReadOnlyCollection<StationList>(new List<StationList> {singleLine});
        }

        public List<Station> GetAllStations()
        {
            var allStation = new List<Station>();

            foreach (var line in _lines)
            {
                allStation.AddRange(line.GetStations());
            }

            return allStation;
        }
    }
}
