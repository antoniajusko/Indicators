using System;
using System.Collections.Generic;
using System.Text;

namespace Indicators
{
    abstract class Oscillator : IIndicator
    {
        public int Parameter
        { get; set; }
        public (float, float) Thresholds
        { get; set; }

        public List<double> resultFromRSI;
        public List<double> resultFromADX;


        public Oscillator(int parameter, (float, float) thresholds)
        {
            this.Parameter = parameter;
            this.Thresholds = thresholds;
        }
        public abstract List<double> Calculate(List<double> data);
    }
}
