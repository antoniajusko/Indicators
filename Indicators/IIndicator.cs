using System;
using System.Collections.Generic;
using System.Text;

namespace Indicators
{
    interface IIndicator
    {
        public List<double> Calculate(List<double> data);

    }
}
