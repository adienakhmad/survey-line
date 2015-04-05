using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SurveyLine.Ex
{
    class SurveyDesignNotFoundException:Exception
    {
        public SurveyDesignNotFoundException()
        {
            
        }

        public SurveyDesignNotFoundException(string message) : base(message)
        {
            
        }
            
    }
}
