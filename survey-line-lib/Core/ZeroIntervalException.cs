using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SurveyLine.Core
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
