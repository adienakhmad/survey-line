using System;

namespace SurveyLine.Ex
{
    public class ZeroIntervalException:Exception
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
