namespace SurveyLine.Core
{
    public class SurveyFactory
    {
        public SurveyDesign Design { get; private set; }
        public StationNameDesign NamingDesign { get; private set; }

        /// <summary>
        /// Factory to build surveypoints from survey design and station naming design.
        /// </summary>
        /// <param name="design"></param>
        /// <param name="nameDesign"></param>
        public SurveyFactory(SurveyDesign design, StationNameDesign nameDesign)
        {
            Design = design;
            NamingDesign = nameDesign;
        }

        /// <summary>
        /// Factory to build surveypoints from survey design. Uses default station naming design.
        /// </summary>
        /// <param name="design"></param>
        public SurveyFactory(SurveyDesign design)
        {
            Design = design;
            NamingDesign = new StationNameDesign();
        }
    }
}
