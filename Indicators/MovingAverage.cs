using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace Indicators
{
    abstract class MovingAverage : IIndicator
    {
        public int Parameter
        { get; set; }

        public MovingAverage(int parameter) 
        {
            this.Parameter = parameter; 
        } 
        public abstract List<double> Calculate(List<double> data);
    }
}
