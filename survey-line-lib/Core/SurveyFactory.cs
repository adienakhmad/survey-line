namespace SurveyLine.Core
{
    public class SurveyFactory
    {
        public SurveyDesign Design { get; private set; }
        public StationNameDesign Naming { get; private set; }

        /// <summary>
        /// Factory to build surveypoints from survey design and station naming design.
        /// </summary>
        /// <param name="design"></param>
        /// <param name="name"></param>
        public SurveyFactory(SurveyDesign design, StationNameDesign name)
        {
            Design = design;
            Naming = name;
        }

        /// <summary>
        /// Factory to build surveypoints from survey design. Uses default station naming design.
        /// </summary>
        /// <param name="design"></param>
        public SurveyFactory(SurveyDesign design)
        {
            Design = design;
            Naming = new StationNameDesign();
        }
    }
}
