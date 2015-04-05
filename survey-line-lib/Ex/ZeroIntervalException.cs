using System;

namespace SurveyLine.Ex
{
    class ZeroIntervalException:Exception
    {
        public ZeroIntervalException()
        {
            
        }
        public ZeroIntervalException(string message)
            : base (message)
        {

        }
    }
}
