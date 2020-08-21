using Indicators;
using System;
using System.Collections.Generic;
using System.Text;

namespace Indicators
{
    class ExponentialMovingAverage : MovingAverage
    {
        public ExponentialMovingAverage(int parameter) : base(parameter) { }
        public override List<double> Calculate(List<double> data)
        {
            List<double> result_exponential_moving_average = new List<double>();

            SimpleMovingAverage SMA = new SimpleMovingAverage(Parameter);
            double sum = SMA.Calculate(data)[0];
            //double sum = data[0];
            double coeff = 2.0 / (1.0 + Parameter);

            for (int i = 0; i < data.Count; i++)
            {
                sum += coeff * (data[i] - sum);
                result_exponential_moving_average.Add(sum);
            }
            return result_exponential_moving_average;
        }
    }
}
