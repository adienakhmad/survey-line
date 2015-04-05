using System;

namespace SurveyLineLib.Ex
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
