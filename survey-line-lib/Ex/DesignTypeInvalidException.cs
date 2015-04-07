using System;

namespace SurveyLine.Ex
{
    class DesignTypeInvalidException:Exception
    {
        public DesignTypeInvalidException()
        {
            
        }

        public DesignTypeInvalidException(string message) : base(message)
        {
            
        }
    }
}
