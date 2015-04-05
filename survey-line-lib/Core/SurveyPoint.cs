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
}